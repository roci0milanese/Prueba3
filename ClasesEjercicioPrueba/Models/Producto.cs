using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEjercicioPrueba.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }

        public Producto(string nombre, int cantidad, decimal precio, string descripcion)
        {
            NombreProducto = nombre;
            Cantidad = cantidad;
            Precio = precio;
            Descripcion = descripcion;
        }

 
        public Producto() { }
    }
}
