using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDroguería
{
    public partial class formlogin : Form
    {
        public formlogin()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txtContrasena.Text = "";
            txtUsuario.Text = "";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            FormInicio formInicio = new FormInicio();

            if (txtUsuario.Text == "Admin" && txtContrasena.Text == "Admin")
            {
                this.Hide(); //Lo oculta, pero, no culmina la compilación
                formInicio.Show();
            }
            else
            {
                MessageBox.Show("Contraseña o usuario incorrecto");
                Limpiar();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = true;
        }

        private void checkVerContrasena_CheckedChanged(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = !checkVerContrasena.Checked;
        }
    }
}
