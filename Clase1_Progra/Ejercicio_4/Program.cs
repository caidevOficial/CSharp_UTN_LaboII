using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        /*
         4.Un número perfecto es un entero positivo, que es igual a la 
        suma de todos los enteros positivos (excluido el mismo) que son 
        divisores del número. El primer número perfecto es 6, ya que los 
        divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6. Escribir una aplicación 
        que encuentre los 4 primeros números perfectos. Nota: Utilizar 
        estructuras repetitivas y selectivas.*/
        static void Ejercicio4()
        {
            int divisor;
            int sumaDivisores;
            int cantidadPerfectos = 0;
            Console.Title = "Ejercicio 4";

            // chequeo tener 4 perfectos y recorro numeros.
            for (int numero = 1; cantidadPerfectos < 4; numero++)
            {
                sumaDivisores = 0;

                // recorro divisores del numero.
                for (divisor = 1; divisor <= (numero / 2); divisor++)
                {
                    // si es divisor, lo sumo.
                    if ((numero % divisor) == 0)
                    {
                        sumaDivisores += divisor;
                    }
                }

                //si la suma es igual al numero iterado, IT'S PERFECT PERRI!.
                if (sumaDivisores == numero)
                {
                    Console.WriteLine("El numero " + numero + " es perfecto");
                    cantidadPerfectos++; //Actualizo cantidad de perfectos.
                }
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Ejercicio4();
        }
    }
}
