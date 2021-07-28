using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstacionamiento
{
    [Serializable]
    abstract public class Persona
    {
        public string Nombre { get;protected set; }
        public string Apellido { get;protected set; }
        public long DNI { get; protected set; }
        public long Telefono { get; protected set; }

        public Persona(string nombre, string apellido, long dNI,long telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dNI;
            Telefono = telefono;
        }
    }
}
