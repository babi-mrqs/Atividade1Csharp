using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosAula
{
    public class AppDbContext : DbContext
    {
            public DbSet<Usuario> Usuarios { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder
    optionsBuilder)
            {
                optionsBuilder.UseSqlite("Data Source=exercicios.db");
            }

    }
    
}
