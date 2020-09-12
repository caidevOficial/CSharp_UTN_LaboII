using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//using DateTime.Now;

namespace sarasa
{
    class Program
    {
 
        /*
         5.Un centro numérico es un número que separa una lista
        de números enteros (comenzando en 1) en dos grupos de números, 
        cuyas sumas son iguales. El primer centro numérico es el 6, 
        el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) 
        cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, 
        el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) 
        cuyas sumas son ambas iguales a 595. Se pide elaborar una aplicación 
        que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.
        Nota: Utilizar estructuras repetitivas y selectivas.*/
       
        /// <summary>
        /// asdasdasd
        /// </summary>
        static void Ejercicio5() {

            Console.Title = "Ejercicio 5";
            Console.WriteLine("ingrese un numero:");
            String numero = Console.ReadLine();
            int j;

            if (int.TryParse(numero, out j))
            {
                for (int centro = 1; centro < j; centro++)
                {
                    int acum = 0;
                    // Sumo numeros inferiores al centro
                    for (int i = 1; i < centro; i++)
                    {
                        acum+=i;
                    }
                    // Sumo numeros superiores al centro
                    int contador = centro + 1;
                    do
                    {
                        acum -= contador;
                        contador++;
                    } while (acum > 0);

                    // Si acum es 0 es xq es un centro numerico
                    if (acum == 0)
                        Console.WriteLine("{0} es centro numerico", centro);
                    else
                        Console.WriteLine("{0} no es centro numerico", centro);
                }
            }
            else
                Console.WriteLine("No es un numero");
            Console.ReadKey();
        }

        

        static void Main(string[] args)
        {
            Ejercicio5();

        }
    }
}

