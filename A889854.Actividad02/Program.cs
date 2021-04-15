using System;
using System.Collections.Generic;
using System.Linq;

namespace A889854.Actividad02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> alumnos = new List<Alumno>();
            List<Curso> cursos = new List<Curso>();
            char agregarAlumnos = 's';
            char agregarCursos = 's';

            // Carga alumnos hasta que se presiona "n".
            do
            {
                Console.WriteLine("Ingrese los datos del primer alumno...\n");
                alumnos.Add(new Alumno());
                Console.WriteLine("Presione 's' para agregar otro alumno o 'n' para continuar...");
                agregarAlumnos = Validaciones.siono(Console.ReadKey().KeyChar);
                Console.Clear();

            } while (agregarAlumnos == 's');


            // Carga cursos hasta que se presiona "n".
            do
            {
                Console.WriteLine("Ingrese los datos del primer curso...\n");
                cursos.Add(new Curso());
                Console.WriteLine("Presione 's' para agregar otro curso o 'n' para continuar...");
                agregarCursos = Validaciones.siono(Console.ReadKey().KeyChar);
                Console.Clear();

            } while (agregarCursos == 's');

            // Ordena alumnos por ranking.

            alumnos.Sort((y, x) => x.getRanking.CompareTo(y.getRanking));

            // Si hay cursos disponibles inscribe al alumno, luego ordena la lista de cursos para que queden al principio los de mas capacidad libre.
            foreach (Alumno alumno in alumnos)
            {
                if (cursos.Any(c => c.getCapacidad > 0))
                {
                    alumno.inscripto = true;
                    cursos.Sort((y, x) => x.getCapacidad.CompareTo(y.getCapacidad));
                    cursos[0].inscribiralumno();
                }
            }

            // Muestra las inscripciones a cursos.

            Console.WriteLine("Inscriptiones a cursos:\n");
            foreach (Curso curso in cursos)
            {
                Console.WriteLine(curso);
            }

            // Muestra alumnos no inscriptos.

            Console.WriteLine("\nLos siguientes alumnos no fueron inscriptos:\n");
            foreach (Alumno alumno in alumnos)
            {
                if (!alumno.inscripto)
                {
                    Console.WriteLine(alumno);
                }

            }
            Console.WriteLine("Presione cualquier tecla para salir.");


            Console.ReadKey();

        }

    }
}
