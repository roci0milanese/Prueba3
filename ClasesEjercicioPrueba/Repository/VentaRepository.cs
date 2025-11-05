using System.Collections.Generic;
using System.Linq;
using ClasesEjercicioPrueba.Data1;
using ClasesEjercicioPrueba.Models;
using Microsoft.EntityFrameworkCore;

namespace ClasesEjercicioPrueba.Repository
{
    public static class VentaRepository
    {
        public static void GuardarVenta(int idCliente, int idProducto, int cantidad)
        {
            using (var context = new ApplicationDbContext())
            {
                var cliente = context.clientes.Find(idCliente);
                var producto = context.productos.Find(idProducto);

                if (cliente == null || producto == null)
                {
                    Console.WriteLine("Cliente o producto no encontrado.");
                    return;
                }

                if (producto.Cantidad < cantidad)
                {
                    Console.WriteLine($"No hay suficiente stock. Disponible: {producto.Cantidad}");
                    return;
                }

                var venta = new Venta();
                venta.Cliente = cliente;
                venta.Producto = producto;
                venta.Fecha = DateTime.Now;
                venta.Total = producto.Precio * cantidad;

                producto.Cantidad -= cantidad;

                context.venta.Add(venta);
                context.SaveChanges();

                Console.WriteLine("Venta registrada correctamente.");
            }
        }

        public static List<Venta> ObtenerVentasPorCliente(int idCliente)
        {
            using (var context = new ApplicationDbContext())
            {
                // Incluir las entidades relacionadas para que Producto y Cliente no sean null
                return context.venta
                    .Include(v => v.Producto)
                    .Include(v => v.Cliente)
                    .Where(v => v.Cliente.Id == idCliente)
                    .ToList();
            }
        }
    }
}
