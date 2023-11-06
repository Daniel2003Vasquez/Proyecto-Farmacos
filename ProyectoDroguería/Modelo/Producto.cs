using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDroguería.Modelo
{
    public class Producto
    {
        public long Serial { get; set; }
        public string Nombre { get; set;}
        public string Descripcion { get; set; }
        public string Caterogia { get; set; }
        public long Precio { get; set; }
        public long Cantidad { get; set; }
        public string RutaImagen { get; set; }

        
    }
}
