using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstacionamiento.Clases
{
    [Serializable]
    public class Vehiculo
    {
        public string Tipo { get; private set; }
        public string Marca { get; private set; }
        public string Patente { get; private set; }
        public Modelo modelo;

        public Vehiculo(int tipo, string marca, string patente, string model, string color, int cilindrada)
        {
            
            if (tipo == 0)
            {
                Tipo = "Moto";
            }
            else if (tipo == 1)
            {
                Tipo = "Auto";
            }
            else if(tipo == 2)
            {
                Tipo = "Camioneta";
            }
            Marca = marca;
            Patente = patente;
            modelo = new Modelo(model, color, cilindrada);
        }
    }
}
