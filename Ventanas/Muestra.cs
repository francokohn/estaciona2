using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEstacionamiento
{

    public partial class Muestra : Form
    {
        private Clases.BaseDeDatos BD;
        private Clases.BaseDeDatos bd;
        public Muestra()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(30, 150);
            cargar();
        }

        public void SetBaseDeDatos(Clases.BaseDeDatos b)
        {
            bd = b.Abrir();
        }
        private List<Clases.Vehiculo> vehiculos = new List<Clases.Vehiculo>();
        private List<Clases.Modelo> modelos = new List<Clases.Modelo>();
        DataTable table = new DataTable("table");
        private void cargar()
        {
            bd = new Clases.BaseDeDatos();
            BD = bd.Abrir();

            for (int i = 0; i < BD.propietarios.Count; i++)
            {
                vehiculos.Add(BD.propietarios[i].Vehiculo);
                modelos.Add(BD.propietarios[i].Vehiculo.modelo);
            }
            //dataGridView1.DataSource = BD.propietarios;
            if (BD.propietarios.Count > 0)
            {
                table.Columns.Add("Apellido:");
                table.Columns.Add("Nombre:");
                table.Columns.Add("D.N.I:");
                table.Columns.Add("Correo:");
                table.Columns.Add("Telefono:");
                table.Columns.Add("Rol:");
                table.Columns.Add("Cilindrada:");
                table.Columns.Add("Color:");
                table.Columns.Add("Modelo:");
                table.Columns.Add("Marca:");
                table.Columns.Add("Patente:");
                table.Columns.Add("Tipo:");
                table.Columns.Add("Monto ($):");
                table.Columns.Add("Servicios:");
                table.Columns.Add("Tiempo:");
                table.Columns.Add("Casillero:");



                for (int i = 0; i < BD.propietarios.Count; i++)
                {
                    DataRow row = table.NewRow();
                    row["Apellido:"] = BD.propietarios[i].Apellido;
                    row["Nombre:"] = BD.propietarios[i].Nombre;
                    row["D.N.I:"] = BD.propietarios[i].DNI;
                    row["Correo:"] = BD.propietarios[i].Correo;
                    row["Telefono:"] = BD.propietarios[i].Telefono;
                    row["Rol:"] = BD.propietarios[i].Rol;
                    row["Marca:"] = BD.propietarios[i].Vehiculo.Marca;
                    row["Patente:"] = BD.propietarios[i].Vehiculo.Patente;
                    row["Tipo:"] = BD.propietarios[i].Vehiculo.Tipo;

                    row["Cilindrada:"] = BD.propietarios[i].Vehiculo.modelo.Cilindrada;
                    row["Color:"] = BD.propietarios[i].Vehiculo.modelo.Color;
                    row["Modelo:"] = BD.propietarios[i].Vehiculo.modelo.modelo;

                    row["Casillero:"] = BD.tarifas[i].Casillero;
                    row["Servicios:"] = BD.tarifas[i].Servicios;
                    row["Tiempo:"] = BD.tarifas[i].Tiempo;
                    row["Monto ($):"] = BD.tarifas[i].Monto;
                    table.Rows.Add(row);

                }
                dataGridView1.DataSource = table;
            }
            else MessageBox.Show("Lista Vacía");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BD.Abrir();
            int fila=dataGridView1.CurrentRow.Index;
            BD.propietarios.RemoveAt(fila);
            BD.tarifas.RemoveAt(fila);
            BD.Guardar();
            cargar();
        }
    }
}
