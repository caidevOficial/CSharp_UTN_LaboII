using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        /*
         6.Escribir un programa que determine si un año es bisiesto.
        Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 
        no son bisiestos, salvo si ellos también son múltiplos de 400. Por ejemplo: 
        el año 2000 es bisiesto pero 1900 no. Pedirle al usuario un año de inicio y 
        otro de fin y mostrar todos los años bisiestos en ese rango.
        Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).*/
        static void Ejercicio6()
        {

            int anhoInicio;
            int anhoFin;
            Console.Title = "Ejercicio 6";

            Console.WriteLine("Ingrese año de inicio: ");
            anhoInicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese año de fin: ");
            anhoFin = int.Parse(Console.ReadLine());

            for (int inicio = anhoInicio; inicio <= anhoFin; inicio++)
            {
                if ((inicio % 4) == 0)
                {
                    if ((inicio % 100) != 0 || (inicio % 400) == 0)
                    {
                        Console.WriteLine("Es bisiesto el año " + inicio);
                    }
                }
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Ejercicio6();
        }
    }
}
