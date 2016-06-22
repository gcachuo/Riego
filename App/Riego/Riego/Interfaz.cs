using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Riego
{
    public partial class Interfaz : Form
    {
        Arduino arduino;
        Clima clima;
        string result;
        bool op;
        DateTime horaRegado;
        BackgroundWorker bw;

        void error(string msg)
        {
            MessageBox.Show(
                msg,
                "ERROR",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        void encenderLed(int led, Button boton)
        {
            result = arduino.cambiarLed(led, true);
            if (result != "true")
            {
                error(result);
                boton.BackColor = Color.Red;
            }
            else
                boton.BackColor = Color.Green;
        }

        void apagarLed(int led, Button boton)
        {
            result = arduino.cambiarLed(led, false);
            if (result != "true")
            {
                error(result);
                boton.BackColor = Color.Green;
            }
            else
                boton.BackColor = Color.Red;
        }

        public Interfaz()
        {
            InitializeComponent();
            arduino = new Arduino();
            clima = new Clima();
            op = true;
            horaRegado = new DateTime();
            horaRegado = (dtpHoraRegado.Value);
        }

        private void Interfaz_Load(object sender, EventArgs e)
        {
            bw = new BackgroundWorker();
            bw.DoWork += bw_DoWork;
        }
        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            while (op)
            {
                var hora = DateTime.Now;
                if (hora.Hour >= horaRegado.Hour && hora.Minute <= (horaRegado.Minute + 20) && hora.Hour < (horaRegado.Hour + 1))
                {
                    consultarClima();
                }
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            var boton = (Button)sender;
            if (boton.BackColor == Color.Green)
            {
                arduino.closeSerial();
                boton.BackColor = Color.Red;
            }
            else
            {
                var conectar = arduino.openSerial("COM" + numPuerto.Value);
                if (conectar != "true")
                {
                    error(conectar);
                    boton.BackColor = Color.Red;
                    op = false;
                }
                else
                {
                    boton.BackColor = Color.Green;
                    op = true;
                    bw.RunWorkerAsync();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var boton = (Button)sender;
            var led = 1;

            if (boton.BackColor == Color.Green)
                apagarLed(led, boton);
            else
                encenderLed(led, boton);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var boton = (Button)sender;
            var led = 2;

            if (boton.BackColor == Color.Green)
                apagarLed(led, boton);
            else
                encenderLed(led, boton);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var boton = (Button)sender;
            var led = 3;

            if (boton.BackColor == Color.Green)
                apagarLed(led, boton);
            else
                encenderLed(led, boton);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var boton = (Button)sender;
            var led = 4;

            if (boton.BackColor == Color.Green)
                apagarLed(led, boton);
            else
                encenderLed(led, boton);
        }

        private void btnClima_Click(object sender, EventArgs e)
        {
            consultarClima();
        }
        void secuenciaEncendido()
        {
            for (var x = 1; x <= 4; x++)
            {
                Button boton = null;
                switch (x)
                {
                    case 1:
                        boton = button1;
                        break;
                    case 2:
                        boton = button2;
                        break;
                    case 3:
                        boton = button3;
                        break;
                    case 4:
                        boton = button4;
                        break;
                }
                encenderLed(x, boton);
                Thread.Sleep(5000);
            }
        }
        void consultarClima()
        {
            try
            {
                var valoresClima = clima.obtenerClima();
                float
                    climaDia = valoresClima[0],
                    climaNoche = valoresClima[1];

                if (climaDia < 55 || climaNoche < 55)
                {
                    secuenciaEncendido();
                }
                lblValores.Text = (climaDia.ToString() + "; " + climaNoche.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
