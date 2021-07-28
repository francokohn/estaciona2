using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstacionamiento.Clases
{
    [Serializable]
    public class Modelo
    {
        public string modelo { get; private set; }
        public string Color { get; private set; }
        public int Cilindrada { get; private set; }

        public Modelo(string modelo, string color, int cilindrada)
        {
            this.modelo = modelo;
            this.Color = color;
            this.Cilindrada = cilindrada;
        }
    }
}
