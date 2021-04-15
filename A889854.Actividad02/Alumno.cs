using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A889854.Actividad02
{
    class Alumno
    {
        private int registro;
        private decimal ranking;
        public bool inscripto = false;
        // Constructor.
        public Alumno ()
        {
            Console.WriteLine("Ingrese el número de registro:");
            this.registro = Validaciones.ingresarEntero();
            Console.WriteLine("Ingrese el ranking del alumno:");
            this.ranking = Validaciones.ingresarDecimal();
            Console.Clear();
        }

        public decimal getRanking => ranking;

        public override string ToString()
        {
            return "Registro N° " + registro + " / Ranking: " + ranking + Environment.NewLine;
        }

    }
}
