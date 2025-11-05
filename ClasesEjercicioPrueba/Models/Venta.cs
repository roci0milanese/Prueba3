using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEjercicioPrueba.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public List<Producto> Productos { get; set; }
        public decimal Total { get; set; }
        public Producto Producto { get; set; }
        public Venta()
        {
            Productos = new List<Producto>();
            Fecha = DateTime.Now;
        }

        public void CalcularTotal()
        {
            decimal suma = 0;

            for (int i = 0; i < Productos.Count; i++)
            {
                suma = suma + (Productos[i].Precio * Productos[i].Cantidad);
            }

            Total = suma;
        }

    }
}
