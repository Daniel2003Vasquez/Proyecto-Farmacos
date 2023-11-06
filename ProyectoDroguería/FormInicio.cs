using Microsoft.Win32;
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


        private void button1_Click_1(object sender, EventArgs e)
        {
            FormRegistrarProducto registrar = new FormRegistrarProducto();
            panelContenedor.Controls.Clear(); //Preguntar si está bien
            registrar.TopLevel = false;
            registrar.FormBorderStyle = FormBorderStyle.None; //Muestra los bordes de la ventana
            panelContenedor.Controls.Add(registrar);
            registrar.Dock = DockStyle.Fill; //Acopla el contenedor
            registrar.Show();
        }


        private void button1_Click_2(object sender, EventArgs e)
        {

            FormHola formHola = new FormHola();
            panelContenedor.Controls.Clear();
            formHola.TopLevel = false;
            formHola.FormBorderStyle = FormBorderStyle.None; 
            panelContenedor.Controls.Add(formHola);
            formHola.Dock = DockStyle.Fill;
            formHola.Show();
        }
    }
}
