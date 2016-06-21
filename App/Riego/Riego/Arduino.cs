using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riego
{
    class Arduino
    {
        SerialPort serial;
        public string openSerial(string puerto)
        {
            serial = new SerialPort(puerto, 9600);
            try
            {
                serial.Open();
                return "true";
            }
            catch(Exception ex)
            {
                return "Puerto no válido \n("+ex.Message+")";
            }
        }
        public string closeSerial()
        {
            try
            {
                serial.Close();
                return "true";
            }catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public string cambiarLed(int led, bool estado)
        {
            string letra = "";
            switch (led)
            {
                case 1:
                    if (estado)
                        letra = "a";
                    else
                        letra = "A";
                    break;
                case 2:
                    if (estado)
                        letra = "b";
                    else
                        letra = "B";
                    break;
                case 3:
                    if (estado)
                        letra = "c";
                    else
                        letra = "C";
                    break;
                case 4:
                    if (estado)
                        letra = "d";
                    else
                        letra = "D";
                    break;
            }
            try
            {
                serial.WriteLine(letra);
                return "true";
            }
            catch(Exception ex)
            {                
                return "Error al encender led \n("+ex.Message+")";
            }
        }
    }
}
