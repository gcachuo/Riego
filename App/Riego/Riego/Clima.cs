using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Riego
{
    class Clima
    {
        servicioClima.sustentabilidadWSPortTypeClient servicio;
        public Clima()
        {
            servicio = new servicioClima.sustentabilidadWSPortTypeClient();
        }
        public float[] obtenerClima()
        {
            try
            {
                var result = servicio.getRainPobability();
                var split = result.Split(';');
                return new float[2] { float.Parse(split[0]), float.Parse(split[1]) };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
