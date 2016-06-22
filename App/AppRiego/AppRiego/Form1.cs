using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRiego
{
    public partial class Form1 : Form
    {
        #region Propiedades globales de la clase
        Arduino arduino;
        BackgroundWorker bw;
        bool listener;
        #endregion

        #region Constructores de la clase
        public Form1()
        {
           InitializeComponent();
            Init();
        }
        #endregion

        #region Eventos de la aplicación
        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                arduino.openSerial("COM" + txtPuerto.Value);
                btnRegadoManual.Enabled = true;

                listener = true;

                bw = new BackgroundWorker();
                bw.DoWork += iniciarEscucha;
                bw.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " :O");
            }
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            try
            {
                Configuracion.Hora = dtpHoraRegado.Value;
                Configuracion.Duracion = (int) txtDuracion.Value;

                MessageBox.Show("Hora y duración de riego configurados :)");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " :O");
            }
        }

        private void iniciarEscucha(object sender, DoWorkEventArgs e)
        {
            while (listener)
            {
                var hour = DateTime.Now.Hour;
                var minute = DateTime.Now.Minute;

                var cHour = Configuracion.Hora.Hour;
                var cMinute = Configuracion.Hora.Minute;

                if (hour == cHour && minute == cMinute)
                {

                    double day = 100, night = 100;
                    try
                    {
                        var client = new WeatherService.sustentabilidadWSPortTypeClient();
                        var response = client.getRainPobability();

                        var probabilities = response.Split(';');
                        day = double.Parse(probabilities[0]);
                        night = double.Parse(probabilities[1]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " :O");
                    }

                    if (day <= 70 || night <= 70)
                    {
                        listener = false;
                        IniciarRiego();
                    }
                }
            }
        }

        private void btnRegadoManual_Click(object sender, EventArgs e)
        {
            listener = false;
            IniciarRiego();
        }
        #endregion

        #region Métodos de la clase
        private void IniciarRiego()
        {
            var t = Task.Run(() =>
            {
                for (int i = 1; i <= 5; i++)
                {
                    switch (i)
                    {
                        case 1:
                            arduino.cambiarLed(1, true);
                            break;
                        case 2:
                            arduino.cambiarLed(1, false);
                            arduino.cambiarLed(2, true);
                            break;
                        case 3:
                            arduino.cambiarLed(2, false);
                            arduino.cambiarLed(3, true);
                            break;
                        case 4:
                            arduino.cambiarLed(3, false);
                            arduino.cambiarLed(4, true);
                            break;
                        default:
                            arduino.cambiarLed(4, false);
                            return;
                    }

                    Thread.Sleep((Configuracion.Duracion * 60000) / 4);
                }
            });

            t.Wait();

            listener = true;

            bw = new BackgroundWorker();
            bw.DoWork += iniciarEscucha;
            bw.RunWorkerAsync();
        }

        private void Init()
        {
            dtpHoraRegado.Value = Configuracion.Hora;
            txtDuracion.Value = Configuracion.Duracion;

            arduino = new Arduino();
        }
        #endregion
    }
}
