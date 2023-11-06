using ProyectoDroguería.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDroguería
{
    public partial class FormRegistrarProducto : Form
    {
        public FormRegistrarProducto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void LimpiarTxtEnRegistro()
        {
            txtNombreR.Text = "";
            txtSerialR.Text = "";
            txtCantidadR.Text = "";
            txtDescripcionR.Text = "";
            comboCategoriaR.Text = "";
            txtPrecioR.Text = "";
        }
        private void Registrar_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarR_Click(object sender, EventArgs e)
        {
            LimpiarTxtEnRegistro();
        }

        //Botón Fotos
        private void btnFotoR_Click(object sender, EventArgs e) //Configurar
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta de la imagen seleccionada
                string rutaImagen = openFileDialog.FileName;

                // Mostrar la imagen en el PictureBox
                pictureBox1.Image = new System.Drawing.Bitmap(rutaImagen);

                // Obtener el nombre del serial
                long nombreSerial = long.Parse(txtSerialR.Text);
                string nombre = txtNombreR.Text;
                long cantidad = long.Parse(txtCantidadR.Text);
                string descripcion = txtDescripcionR.Text;
                string categoria = comboCategoriaR.Text;
                long precio = long.Parse(txtPrecioR.Text);

                // Construir la ruta de destino para guardar la imagen
                string carpetaDestino = "C:\\Users\\Daniel Vásquez\\Desktop\\Proyecto Programación III\\ProyectoDroguería\\Resources\\Inventario"; // Cambia esto con la ruta de tu carpeta destino
                string nombreArchivo = Path.Combine(carpetaDestino, $"{nombreSerial}.jpg");

                // Guardar la imagen en la carpeta destino
                File.Copy(rutaImagen, nombreArchivo);

                // Crear una instancia de DatosImagen
                Producto product = new Producto
                {
                    Serial = nombreSerial,
                    Nombre = nombre,
                    Cantidad = cantidad,
                    Descripcion = descripcion,
                    Caterogia = categoria,
                    Precio = precio,
                    RutaImagen = nombreArchivo
                };

                Archivo archivo = new Archivo();
                // Guardar los datos en Excel
                archivo.GuardarDatosEnExcel(product);
                MessageBox.Show("Imagen seleccionada y datos guardados con éxito.");
            }
        }

        private void btnRegistrarR_Click(object sender, EventArgs e) //Boton Registrar
        {
            
        }
    }
}
