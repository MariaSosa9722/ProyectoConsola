using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsola.Funciones
{
    public class Menu
    {
        public void Inicio()
        {

            CrudCurso curso = new CrudCurso();
       

            Console.WriteLine("Elije una opcion");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    curso.Crear();
                    break;

                case 2:
                    curso.Editar(2);
                    break;

                case 3:

                    curso.Leer();
                    break;
            }

        }

    }
}
