using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClasesEjercicioPrueba.Models;

namespace ClasesEjercicioPrueba.Data1
{
    public class ApplicationDbContext : DbContext
    {
    
        public DbSet<Venta> venta { get; set; }
        public DbSet <Producto> productos { get; set; }
        public DbSet <Cliente> clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
               "Server=localhost;Database=Parcial_Programacion_3;Trusted_Connection=True;TrustServerCertificate=True;"
           );
        }



    }
}
