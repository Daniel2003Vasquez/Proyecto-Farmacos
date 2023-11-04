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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }
        private void FormInicio_Load(object sender, EventArgs e)
        {

        }

        private void FormHijo(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Registrar registrar = new Registrar();
            registrar.TopLevel = false;
            registrar.FormBorderStyle = FormBorderStyle.None; //Muestra los bordes de la ventana
            panelContenedor.Controls.Add(registrar);
            registrar.Dock = DockStyle.Fill; //Acopla el contenedor
            registrar.Show();
        }
    }
}
