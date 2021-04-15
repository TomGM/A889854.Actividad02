using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A889854.Actividad02
{
    class Curso
    {
        private int numerocurso;
        private int capacidad;
        private int inscriptos = 0;
       
        // Constructor
        public Curso()
        {
            Console.WriteLine("Ingrese el número de curso:\n");
            this.numerocurso = Validaciones.ingresarEntero();
            Console.WriteLine("Ingrese la capacidad del curso:\n");
            this.capacidad = Validaciones.ingresarEntero();
            Console.Clear();
        }

        public int getCapacidad => capacidad;
        
        public int getInscriptos => inscriptos;
       
        // Inscribir un alumno al curso y bajar la capacidad disponible.
        public void inscribiralumno() 
        {
            inscriptos++;
            capacidad--;
        }

        // Muestra los inscriptos al curso.
        public override string ToString()
        {
            return "Curso " + numerocurso + " --> " + inscriptos + " inscriptos." + Environment.NewLine;
        }
    }
}
