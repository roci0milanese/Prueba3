using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEjercicioPrueba.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

 
        public Cliente(string nombre, string email, string telefono)
        {
            Nombre = nombre;
            Email = email;
            Telefono = telefono;
        }


        public Cliente() { }
    }
}
