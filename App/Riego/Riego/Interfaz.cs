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

        public Interfaz()
        {
            InitializeComponent();
            arduino = new Arduino();
        }

        private void Interfaz_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            var conectar = arduino.openSerial("COM" + numPuerto);
            if (conectar != "true")
                MessageBox.Show(conectar);
            else
            {
                arduino.cambiarLed(1, true);
                arduino.cambiarLed(2, true);
                arduino.cambiarLed(3, true);
                arduino.cambiarLed(4, true);
            }
        }
    }
}
