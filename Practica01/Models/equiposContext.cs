using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Practica01.Models
{
    public class equiposContext : DbContext
    {
        public equiposContext(DbContextOptions<equiposContext> dbContext) : base(dbContext) { 
            
      
        }

        public DbSet<equipos> equipos { get; set; }

        public DbSet<Marcas> marcas { get; set; }

        public DbSet<Estados_equipo> estados_equipo { get; set; }

        public DbSet<Tipo_equipo> tipo_equipo { get; set; }

        public DbSet<Estados_reserva> estados_reserva { get; set; }

        public DbSet<Facultad> facultades { get; set; }

        public DbSet<Carrera> carreras { get; set; }

        public DbSet<Usuario> usuarios { get; set; }

        public DbSet<Reserva> reservas { get; set; }




    }
}
