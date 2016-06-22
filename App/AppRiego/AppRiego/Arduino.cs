using System;
using System.IO.Ports;

namespace AppRiego
{
    class Arduino
    {
        SerialPort serial;
        public bool openSerial(string puerto)
        {
            serial = new SerialPort(puerto, 9600);
            try
            {
                serial.Open();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool closeSerial()
        {
            try
            {
                serial.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void cambiarLed(int led, bool estado)
        {
            try
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

                serial.WriteLine(letra);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
