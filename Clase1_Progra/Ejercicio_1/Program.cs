using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        /*
         Ingresar 5 números por consola, guardándolos en una variable escalar. 
        Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
        */
        static void Ejercicio1()
        {
            sbyte index;
            byte suma = 0;
            byte numero;
            byte maximo = byte.MinValue;
            byte minimo = byte.MaxValue;
            float promedio = float.MinValue;

            Console.Title = "Ejercicio 1";
            for (index = 0; index < 5; index++)
            {
                Console.Write("Ingrese el " + (index + 1) + "° numero: ");
                byte.TryParse(Console.ReadLine(), out numero);
               
                while (!byte.TryParse(Console.ReadLine(), out numero)) {
                    Console.Write("Ingrese el " + (index + 1) + "° numero: ");
                    byte.TryParse(Console.ReadLine(), out numero);
                }

                if (numero < minimo)
                {
                    minimo = numero;
                }
                else if (numero > maximo)
                {
                    maximo = numero;
                }
                suma += numero;
            }

            promedio = suma / index;
            Console.WriteLine("El promedio es:" + promedio.ToString());
            Console.WriteLine("El Maximo es:" + maximo.ToString());
            Console.WriteLine("El Minimo es:" + minimo.ToString());
            Console.ReadKey();

        }

        static void Main(string[] args)
        {
            Ejercicio1();
        }
    }
}
