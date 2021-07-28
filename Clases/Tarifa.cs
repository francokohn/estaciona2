using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstacionamiento.Clases
{
    [Serializable]
    public class Tarifa
    {
        public double Monto { get; private set; }
        private Servicio Servicio;
        private Tiempo tiempo { get; set; }
        public bool Techo;
        public int Tiempo;
        private int tipo;
        private int precioHora = 5;
        public string Servicios { get; private set; }
        public int Casillero { get; private set; }
        public Tarifa() { }

        public Tarifa(int tipo, DateTime tiempo1, DateTime tiempo2, Servicio servicio,bool techo,int num)
        {
            this.tipo = tipo;
            tiempo = new Tiempo(tiempo1, tiempo2);
            this.Servicio = servicio;
            this.Techo = techo;
            Monto = CalcularMonto();
            Tiempo = tiempo.Temp();
            Servicios = MostrarServicios();
            Casillero = num;
        }
        private double CalcularMonto()
        {
            int monto = Tiempo * precioHora;
            if (Techo == true)
            {
                Monto *= 2;
            }
            monto += Servicio.monto();
            return monto;
        }
        public string MostrarServicios()
        {
            string service = "";
            if (Servicio.lavado == true)
            {
                service += " Lavado ";
            }
            if (Servicio.pulido == true)
            {
                service += " Pulido ";
            }
            if (Servicio.aspirado == true)
            {
                service += " Aspirado ";
            }
            if (Servicio.tapizado == true)
            {
                service += " Tapizado ";
            }
            return service;
        }
    }
}
