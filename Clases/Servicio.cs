using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstacionamiento.Clases
{
    [Serializable]
    public class Servicio
    {
        public bool lavado { get; private set; } 
        public bool pulido { get; private set; }
        public bool aspirado { get; private set; }
        public bool tapizado { get; private set; }

        public Servicio(bool lavado, bool pulido, bool aspirado,bool tapizado)
        {
            this.aspirado = aspirado;
            this.tapizado = tapizado;
            this.lavado = lavado;
            this.pulido = pulido;
        }
        public int monto()
        {
            int montoTotal = 0;
            if (aspirado == true)
            {
                montoTotal += 250;
            }
            if (lavado == true)
            {
                montoTotal += 150;
            }
            if (pulido == true)
            {
                montoTotal += 300;
            }
            if (tapizado == true)
            {
                montoTotal += 500;
            }
            return montoTotal;
        }
    }
}
