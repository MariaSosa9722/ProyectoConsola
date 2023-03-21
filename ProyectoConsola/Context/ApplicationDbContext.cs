
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ProyectoConsola.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsola.Context
{
    public class ApplicationDbContext : DbContext
    {
        //AQUI VA LA CONEXION A LA BD

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MAJO;Database=SchoolDB;Trusted_Connection=True;");
        }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }




    }
}
