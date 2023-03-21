using ProyectoConsola.Clases;
using ProyectoConsola.Context;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsola.Funciones
{
    public class CrudCurso
    {

        public void Crear()
        {

            using (var _context = new ApplicationDbContext())
            {
                Curso curso = new Curso()
                {
                    NumCurso = 797,
                    Materia = "Poo",
                    Duracion = 2

                };

                _context.Cursos.Add(curso);
                _context.SaveChanges();

            }

        }

        public void Editar(int id)
        {

            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                Curso curso = _context.Cursos.Find(id);

                curso.NumCurso = 123;
                curso.Materia = "Mate";
                curso.Duracion = 2;

                _context.Cursos.Update(curso);
                _context.SaveChanges();

            }
        }

        public void Leer()
        {

            using (ApplicationDbContext _context = new ApplicationDbContext())
            {

                var curso = _context.Cursos.ToList();

                Console.WriteLine("--Lista de Cursos--");
                foreach (var item in curso)
                {

                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($">> Id: {item.Id}"   );
                    Console.WriteLine($">> NumCurso: {item.NumCurso}");
                    Console.WriteLine($">> Materia: {item.Materia}");
                    Console.WriteLine($">> Duracion: {item.Duracion}");
                    Console.WriteLine("_________________________________");


                }

            }
        }


    }
}
