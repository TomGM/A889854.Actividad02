using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A889854.Actividad02
{
    static class Validaciones
    {

        // Valida enteros.
        public static int ingresarEntero()
        {
            int nroentero;
            while (!int.TryParse(Console.ReadLine(), out nroentero))
                Console.Write("Ingrese un número entero válido.\n");
            return nroentero;
        }

        // Valida decimales.
        public static decimal ingresarDecimal()
        {
            decimal nrodecimal;
            while (!decimal.TryParse(Console.ReadLine(), out nrodecimal))
                Console.Write("Ingrese un número decimal válido.\n");
            return nrodecimal;

        }

        // Valida si el usuario tipea 's' o 'n'.
        public static char siono(char respuesta)
        {
            while (respuesta != 's' && respuesta != 'n')
            {
                Console.WriteLine("Ingrese una opción válida.\n");
                respuesta = Console.ReadKey().KeyChar;
                Console.Clear();
            }
            return respuesta;

        }

    }
}
