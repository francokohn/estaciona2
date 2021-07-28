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
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }
        //utilizacion de bases de datos para el almacenaje de los objetos creados

        private Clases.BaseDeDatos bd = new Clases.BaseDeDatos();

        //pasaje de bases de datos para no perder los datos
        public void Base(Clases.BaseDeDatos b)
        {
            bd = b.Abrir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;

            //Validación de ingresos no vacios 
            //utilizacion de error provider para notificar el error
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Debe Ingresar nombre");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            if (txtapellido.Text == "")
            {
                errorProvider1.SetError(txtapellido, "Debe Ingresar apellido");
                txtapellido.Focus();
                return;
            }
            errorProvider1.SetError(txtapellido, "");

            if (!int.TryParse(txtdni.Text, out num))
            {
                errorProvider1.SetError(txtdni, "Ingrese solo numeros.");
                txtdni.Focus();
                return;
            }
            errorProvider1.SetError(txtdni, "");

            if (!int.TryParse(txtelefono.Text, out num))
            {
                errorProvider1.SetError(txtelefono, "Ingrese solo numeros.");
                txtelefono.Focus();
                return;
            }
            errorProvider1.SetError(txtelefono, "");

            if (comboRol.SelectedIndex.ToString() == "0")
            {
                errorProvider1.SetError(comboRol, "Debe seleccionar rol");
                comboRol.Focus();
                return;
            }
            errorProvider1.SetError(comboRol, "");

            if (txtCorreo.Text == "")
            {
                errorProvider1.SetError(txtCorreo, "Debe ingresar correo");
                txtCorreo.Focus();
                return;
            }
            else if (!validarCorreo())
            {
                txtCorreo.Focus();
                MessageBox.Show("Ingrese un correo valido");
                return;
            }
            errorProvider1.SetError(txtCorreo, "");

            if (txtMarca.Text == "")
            {
                errorProvider1.SetError(txtMarca, "Debe ingresar maquina");
                txtMarca.Focus();
                return;
            }
            errorProvider1.SetError(txtMarca, "");

            if (txtPatente.Text == "")
            {
                errorProvider1.SetError(txtPatente, "Debe ingresar patente");
                txtPatente.Focus();
                return;
            }
            errorProvider1.SetError(txtPatente, "");

            if (ComboTipo.Text.ToString() == "Seleccionar")
            {
                errorProvider1.SetError(ComboTipo, "Debe seleccionar un tipo");
                ComboTipo.Focus();
                return;
            }
            errorProvider1.SetError(ComboTipo, "");
            if (txtModelo.Text == "")
            {
                errorProvider1.SetError(txtModelo, "Debe ingresar modelo");
                txtModelo.Focus();
                return;
            }
            errorProvider1.SetError(txtModelo, "");

            if (txtColor.Text == "")
            {
                errorProvider1.SetError(txtColor, "Debe ingresar modelo");
                txtColor.Focus();
                return;
            }
            errorProvider1.SetError(txtColor, "");

            if(!int.TryParse(txtCilind.Text, out num))
            {
                errorProvider1.SetError(txtCilind, "Ingrese solo numeros.");
                txtCilind.Focus();
                return;
            }
            errorProvider1.SetError(txtCilind, "");


            //lectura de elementos y creacion de objetos tipo propietario y tarifa

            string name = this.txtNombre.Text;
            string ape = this.txtapellido.Text;
            long telefono = Convert.ToInt64(this.txtelefono.Text);
            long dni = Convert.ToInt64(this.txtdni.Text);
            string correo = txtCorreo.Text;
            string rol = comboRol.SelectedItem.ToString();
            string marca = this.txtMarca.Text;
            string patente = this.txtPatente.Text;
            int tipo = this.ComboTipo.SelectedIndex;
            string model = this.txtModelo.Text;
            string color = this.txtColor.Text;
            int cilindrada = Convert.ToInt32(this.txtCilind.Text);
            Clases.Propietario propietario = new Clases.Propietario(name, ape, dni, telefono,correo,rol, tipo, marca, patente,model,color,cilindrada);

            //carga deltipo de datos registro que almacenará todos los propietarios y tarifas

            bd.propietarios.Add(propietario);
            bd.Guardar();

            //pasaje del objeto registro a la otra formulario

            RegistrarEntrada formulario = new RegistrarEntrada();
            this.Hide();
            formulario.SetPropietario(propietario);
            formulario.Show();
            formulario.SetBaseDeDatos(bd);
        }

        //validacion del correo 
        private bool validarCorreo()
        {
            string email = "@gmail.com";
            string hotmail = "@hotmail.com";
            return (this.txtCorreo.Text.Contains(email)
                || this.txtCorreo.Text.Contains(hotmail)) ;
        }
        

       
        
    }
}
