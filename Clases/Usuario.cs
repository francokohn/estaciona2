using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstacionamiento.Clases
{
    public class Usuario
    {
        private string usuario = "admin", Contrasena = "admin";

        public Usuario(){}

        public bool validacion(string usu,string contra)
        {
            if (usuario==usu && Contrasena==contra)
                return true;
            else return false;
        } 
    }
}
