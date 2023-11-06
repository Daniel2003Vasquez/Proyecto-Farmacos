using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;


namespace ProyectoDroguería.Modelo
{
    public class Archivo
    {
        public void GuardarDatosEnExcel(Producto producto)
        {
            string rutaArchivoExcel = "C:\\Users\\Daniel Vásquez\\Desktop\\Proyecto Programación III\\ProyectoDroguería\\Resources\\Excel\\Inventario.xlsx"; //Ruta del Archivo
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Agregar una hoja de trabajo
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Producto");

                // Escribir datos en la hoja de trabajo
                worksheet.Cells["A1"].Value = "Serial";
                worksheet.Cells["B1"].Value = "Nombre";
                worksheet.Cells["C1"].Value = "Descripcion";
                worksheet.Cells["D1"].Value = "Categoria";
                worksheet.Cells["E1"].Value = "Precio";
                worksheet.Cells["F1"].Value = "Cantidad";
                worksheet.Cells["G1"].Value = "RutaImagen";

                worksheet.Cells["A2"].Value = producto.Serial;
                worksheet.Cells["B2"].Value = producto.Nombre;
                worksheet.Cells["C2"].Value = producto.Descripcion;
                worksheet.Cells["D2"].Value = producto.Caterogia;
                worksheet.Cells["E2"].Value = producto.Precio;
                worksheet.Cells["F2"].Value = producto.Cantidad;
                worksheet.Cells["G2"].Value = producto.RutaImagen;

                // Guardar el archivo Excel
                FileInfo excelFile = new FileInfo(rutaArchivoExcel);
                excelPackage.SaveAs(excelFile);
            }

            Console.WriteLine("Datos guardados en el archivo Excel con éxito.");
        }
    }
}
