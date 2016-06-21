using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Riego
{
    public partial class Interfaz : Form
    {
        Arduino arduino;
        Clima clima;
        string result;

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
        }

        private void Interfaz_Load(object sender, EventArgs e)
        {

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
                }
                else
                    boton.BackColor = Color.Green;
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
            var valoresClima = clima.obtenerClima();
            float
                climaDia = valoresClima[0],
                climaNoche = valoresClima[1];
            /*MessageBox.Show(
                "Dia: " + climaDia.ToString() + "%\nNoche: " + climaNoche.ToString() + "%",
                "CLIMA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);*/

            if (climaDia > 60 || climaNoche > 60)
            {
                MessageBox.Show(
                "Secuencia de encendido",
                "CLIMA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
    }
}
