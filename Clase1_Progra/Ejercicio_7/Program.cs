using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static bool EsBisiesto(int anho)
        {
            bool esBisiesto = false;

            if ((anho % 4) == 0)
            {
                if ((anho % 100) != 0 || (anho % 400) == 0)
                {
                    esBisiesto = true;
                }
            }
            return esBisiesto;
        }

        /*
         7.Hacer un programa que pida por pantalla la fecha de nacimiento 
        de una persona (día, mes y año) y calcule el número de días vividos 
        por esa persona hasta la fecha actual (tomar la fecha del sistema
        con DateTime.Now). Nota: Utilizar estructuras selectivas. Tener en 
        cuenta los años bisiestos.*/
        static void Ejercicio7()
        {
            int anho;
            int cantidadDias = 0;
            DateTime ahora = DateTime.Now;

            Console.Title = "Ejercicio 7";
            Console.WriteLine("Indicame el año: ");
            anho = int.Parse(Console.ReadLine());

            for (int anio = anho; anio < ahora.Year; anio++)
            {
                if (EsBisiesto(anio)) // Terminar ejercicio.
                {
                    cantidadDias += 365;
                }
                else
                {
                    cantidadDias += 364;
                }
            }

            Console.WriteLine("Hay dias: " + cantidadDias);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
        }
    }
}
