using ClasesEjercicioPrueba.Data1;
using ClasesEjercicioPrueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEjercicioPrueba.Repository
{
    public class ClienteRepository
    {

        public static void GuardarCliente(Cliente cliente)
        {
            using var context = new ApplicationDbContext();
            context.clientes.Add(cliente);
            context.SaveChanges();
        }

        public static List<Cliente> ObtenerCliente()
        {
            using var context = new ApplicationDbContext();
            return context.clientes.ToList();
        }
    }
}
