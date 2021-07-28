using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEstacionamiento.Ventanas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtContra.PasswordChar='*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                errorProvider1.SetError(txtUsuario, " Ingrese un usuario ...");
                txtUsuario.Focus();
                return;
            }

            if (txtContra.Text == "")
            {
                errorProvider1.SetError(txtContra, " Ingrese una contraseña ...");
                txtContra.Focus();
                return;
            }

            string usuario = txtUsuario.Text;
            string contra = txtContra.Text;

            Clases.Usuario usu = new Clases.Usuario();
            if (!usu.validacion(usuario, contra)) 
            {
                txtUsuario.Text = "";
                txtContra.Text = "";
                MessageBox.Show("Ingrese usuario y/o contraseña correctas...");
                return;
            }
            Registrar registrar = new Registrar();
            registrar.Show();
        }
    }
}
