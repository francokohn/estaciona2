using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstacionamiento.Clases
{
    [Serializable]
    public class Tiempo
    {
        private DateTime tiempo1;
        private DateTime tiempo2;
        public Tiempo(DateTime entra, DateTime sale)
        {
            this.tiempo1 = entra;
            this.tiempo2 = sale;
        }
        public int Temp()
        {
            int tiempo = 0;
            TimeSpan time = tiempo2 - tiempo1;
            if (time.Days > 0)
            {
                tiempo = time.Days * 24;
            }
            tiempo += time.Hours;
            return tiempo;
        }
    }
}
