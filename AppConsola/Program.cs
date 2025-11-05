using ClasesEjercicioPrueba.Data1;
using ClasesEjercicioPrueba.Models;
using ClasesEjercicioPrueba.Repository;

namespace Parcial2
{
    public class Program
    {

        static void Main(string[] args)
        {

            int opcion = 0;
           
            do
            {

                Console.Clear();
                Console.WriteLine("Bienvenido :)");
                Console.WriteLine("Seleccione una opcion:");
                Console.WriteLine("1. Registrar un nuevo producto ");
                Console.WriteLine("2. Registrar un nuevo cliente ");
                Console.WriteLine("3. Registrar una nueva venta ");
                Console.WriteLine("4. Mostrar un reporte de ventas por cliente");
                Console.WriteLine("5. Salir");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Agreguemos un nuevo producto :)");
                        Console.WriteLine("ingrese el nombre del producto:");
                        string nombreProducto = (Console.ReadLine());
                        Console.WriteLine("ingrese el precio del producto:");
                        decimal precioProducto = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese la cantidad del producto:");
                        int cantidadProducto = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese la descripcion del producto");
                        string descripcionProducto = (Console.ReadLine());
                        ProductoRepository.GuardarProducto(new Producto { NombreProducto = nombreProducto, Precio = precioProducto, Cantidad = cantidadProducto, Descripcion = descripcionProducto });
                        break;

                    case 2:
                        Console.WriteLine("Agreguemos un nuevo cliente :)");
                        Console.WriteLine("ingrese el nombre del cliente:");
                        string nombreCliente = (Console.ReadLine());
                        Console.WriteLine("ingrese el email del cliente:");
                        string emailCliente = (Console.ReadLine());
                        Console.WriteLine("ingrese el telefono del cliente");
                        string telefonoCliente = (Console.ReadLine());

                        ClienteRepository.GuardarCliente(new Cliente { Nombre = nombreCliente, Email = emailCliente , Telefono = telefonoCliente });
                        break;


                    case 3:

                        Console.WriteLine("Registremos una nueva venta :)");
                        Console.Write("Ingrese el ID del cliente: ");
                        int idCliente = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el ID del producto: ");
                        int idProducto = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese la cantidad: ");
                        int cantidad = int.Parse(Console.ReadLine());

                        VentaRepository.GuardarVenta(idCliente, idProducto, cantidad);
                        break;

                    case 4:
                        Console.WriteLine("Creemos un nuevo reporte :)");

                        Console.Write("Ingrese el ID del cliente: ");
                        int idClienteReporte = int.Parse(Console.ReadLine());

                        var ventasCliente = VentaRepository.ObtenerVentasPorCliente(idClienteReporte);

                        if (ventasCliente.Count > 0)
                        {
                            Console.WriteLine("\nVentas del cliente:");
                            foreach (var venta in ventasCliente)
                            {
                                Console.WriteLine($"Fecha: {venta.Fecha} - Producto: {venta.Producto.NombreProducto} - Total: ${venta.Total}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("El cliente no tiene ventas registradas.");
                        }
                        break;


                    default:

                        break;
                }

                if (opcion != 5)
                {
                    Console.WriteLine("\nPresione una tecla para salir");
                    Console.ReadKey();
                }

            } while (opcion != 5); //mientras no sea 5 lo repite

        }
    }
}