using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        /*
         2.Ingresar un número y mostrar: el cuadrado y el cubo del mismo. 
        Se debe validar que el número sea mayor que cero, caso contrario, 
        mostrar el mensaje: "ERROR. ¡Reingresar número!".
        Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
        */
        static void Ejercicio2()
        {
            int numero;
            double quadra = 0;
            double cube = 0;

            Console.Title = "Ejercicio 2";
            Console.WriteLine("Ingrese un numero y te mostrare su cuadrado y cubo: ");
            numero = int.Parse(Console.ReadLine());
            if (numero < 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }
            else
            {
                quadra = Math.Pow(numero, 2);
                cube = Math.Pow(numero, 3);
            }

            Console.WriteLine("Numero: {0,-5}, Cuadrado: {1,-5}, Cubo: {2,-5}", numero, quadra, cube);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Ejercicio2();
        }
    }
}
