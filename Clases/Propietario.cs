using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstacionamiento.Clases
{
    [Serializable]
    public class Propietario : Persona
    {
        public Vehiculo Vehiculo;
        public string Rol { get; private set; }
        public string Correo { get; private set; }
        public Propietario(string nombre, string apellido, long dNI, long telefono,string correo,string rol, int tipo, string marca, string patente,string  model,string color,int cilindrada) : base(nombre, apellido, dNI, telefono)
        {
            base.Nombre = nombre;
            base.Apellido = apellido;
            base.DNI = dNI;
            base.Telefono = telefono;
            this.Correo = correo;
            this.Rol = rol;
            Vehiculo = new Vehiculo(tipo, marca, patente,model,color,cilindrada);
        }
    }
}
