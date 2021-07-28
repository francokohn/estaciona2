using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace ProyectoEstacionamiento.Clases
{
    [Serializable]
    public class BaseDeDatos
    {
        //Nombre de archivo del archivo de la base de datos.
        private string Nombre = "BaseDeDatos.dat";
        public List<Propietario> propietarios = new List<Propietario>();
        public List<Tarifa> tarifas = new List<Tarifa>();

        public BaseDeDatos(){}


        public void Guardar()
        {
            FileStream file = new FileStream("c:\\Data\\" + Nombre, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file, this);
            file.Close();
        }

        public BaseDeDatos Abrir()
        {
            FileStream file = new FileStream("c:\\Data\\" + Nombre, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            BaseDeDatos resultado = formatter.Deserialize(file) as BaseDeDatos;
            file.Close();
            return resultado;
        }

    }
}
