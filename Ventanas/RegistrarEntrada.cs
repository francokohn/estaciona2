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
    public partial class RegistrarEntrada : Form
    {
        //creacion de los objetos/atributos a ser utilizados por esta clase
        private Clases.BaseDeDatos bd = new Clases.BaseDeDatos();
        private Clases.Tarifa tarifa;
        private Clases.Propietario propietario;
        private Ventanas.Mapa mapa = new Ventanas.Mapa();
        public RegistrarEntrada()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(232, 150);
            mapa.Show();
            mapa.Base(bd);
        }
       

        public void SetPropietario(Clases.Propietario p)
        {
            propietario = p;
        }

        public void SetBaseDeDatos(Clases.BaseDeDatos b)
        {
             bd= b.Abrir();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int nro = 0;
            DateTime entra = entrada.Value;
            DateTime sale = salida.Value;

            //validacion de entrada/selección de datos

            if (entrada.Value.ToString() == salida.Value.ToString())
            {
                errorProvider1.SetError(entrada, "Ingrese fechas/horas distintas");
                entrada.Focus();
                return;
            }
            errorProvider1.SetError(entrada, "");


            if (!int.TryParse(txtNro.Text, out nro))
            {
                errorProvider1.SetError(txtNro, "Debe ingresar un numero");
                txtNro.Focus();
                return;
            }
            errorProvider1.SetError(txtNro, "");

            if (Convert.ToInt32(txtNro.Text) < 1 || Convert.ToInt32(txtNro.Text) > 44)
            {
                errorProvider1.SetError(txtNro, "Ingrese numero valido");
                txtNro.Focus();
                return;
            }
            errorProvider1.SetError(txtNro, "");


            if (comboTecho.Text == "Seleccionar")
            {
                comboTecho.Focus();
                return;
            }

            //asignacion de variables a ser utilizadas
            bool pulido, aspirado, tapizado, lavado;
            int num = 0;

            if (checkaspi.Checked == true)
            {
                aspirado = true;
            }
            else { aspirado = false; }
            if (checkpuli.Checked == true)
            {
                pulido = true;
            }
            else { pulido = false; }
            if (checktapi.Checked == true)
            {
                tapizado = true;
            }
            else { tapizado = false; }
            if (checklava.Checked == true)
            {
                lavado = true;
            }
            else { lavado = false; }
            if (comboTecho.Text == "Seleccionar")
            {
                comboTecho.Focus();
                return;
            }
            if (txtNro.Text == "")
            {
                txtNro.Focus();
                return;
            }
            if (!disponible())
            {
                errorProvider1.SetError(txtNro, "");
                MessageBox.Show("Ingrese un lugar que no esté ocupado...");
                txtNro.Focus();
                return;
            }
            num = Convert.ToInt32(txtNro.Text);

            //creacion de los objetos para instanciar el objeto tarifa

            bool techo;
            if (comboTecho.SelectedItem.ToString() == "Si")
            {
                techo = true;
            } else techo = false;
            Clases.Servicio service = new Clases.Servicio(lavado, pulido, aspirado, tapizado);
            int tipo;
            if (propietario.Vehiculo.Tipo == "Moto")
            {
                tipo = 0;
            } else if (propietario.Vehiculo.Tipo == "Auto")
            {
                tipo = 1;
            }
            else { tipo = 2; }
            tarifa = new Clases.Tarifa(tipo, entra, sale, service, techo,num);

            //guardado de la tarifa en el objeto de base de datos

            bd.tarifas.Add(tarifa);
            bd.Guardar();
            ocupar();
            this.button3.Enabled = false;
            this.button2.Enabled = true;
            this.button1.Enabled = true;
        }

        private void ocupar()
        {
            mapa.Show();
            for (int i = 0; i < bd.tarifas.Count; i++)
            {
                mapa.colorear(bd.tarifas[i].Casillero);

                mapa.Base(bd);
            }
        }
        private bool disponible()
        {
            bool bande = true;
                for(int i = 0; i < bd.tarifas.Count && bande; i++)
                {
                    if(bd.tarifas[i].Casillero == Convert.ToInt32(txtNro.Text))
                    {
                        bande = false;
                    }
                }
            return bande;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pasaje de base de datos
            mapa.Close();
            Registrar registrar = new Registrar();
            this.Hide();
            registrar.Show();
            registrar.Base(bd);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //pasaje de la base de datos para el muestreo final
            Muestra mostrar = new Muestra();
            mostrar.Show();
            mostrar.SetBaseDeDatos(bd);
        }
    }
}
