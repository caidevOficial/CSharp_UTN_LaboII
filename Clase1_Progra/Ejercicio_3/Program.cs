using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        /*
         Mostrar por pantalla todos los números primos que haya hasta el número 
        que ingrese el usuario por consola. Nota: Utilizar estructuras repetitivas, 
        selectivas y la función módulo (%).
        */
        static void Ejercicio3()
        {
            int num = 2, divisor, primoHasta;
            bool esPrimo;

            Console.Title = "Ejercicio 3";
            Console.Write("Mostrar primos hasta el: ");
            primoHasta = int.Parse(Console.ReadLine());

            if (primoHasta > 1) {
               
                for (num = 2; num <= primoHasta; num++) {
                    esPrimo = true;
                    for (divisor = 2; divisor < num; divisor++) {
                       
                        if ((num % divisor) == 0) {
                            esPrimo = false;
                            break;
                        }
                    }
                    if (esPrimo) {
                        Console.WriteLine("{0} es numero primo", num);
                    }
                }
            }
            Console.ReadLine(); // para frenar la consola
        }

        static void Main(string[] args)
        {
            Ejercicio3();
        }
    }
}
