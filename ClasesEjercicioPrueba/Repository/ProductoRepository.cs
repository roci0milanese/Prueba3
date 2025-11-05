using ClasesEjercicioPrueba.Data1;
using ClasesEjercicioPrueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEjercicioPrueba.Repository
{
    public class ProductoRepository
    {

        public static void GuardarProducto(Producto producto)
        {
            using var context = new ApplicationDbContext();
            context.productos.Add(producto);

            context.SaveChanges();
        }

        public static List<Producto> ObtenerProducto()
        {
            using var context = new ApplicationDbContext();
            return context.productos.ToList();
        }
    }
}
