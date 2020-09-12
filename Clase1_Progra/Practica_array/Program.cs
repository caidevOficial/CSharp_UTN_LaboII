using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //string auxName;
            string[] nombres = new string[4];

            // pido nombres con for
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write("Escriba el {0}° nombre: ", (i + 1));
                nombres[i] = Console.ReadLine();
            }

            //muestro noombres con for
            /*
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);
                //nombres[i] = Console.ReadLine();
            }*/

            foreach (string auxNombre in nombres)
            {
                Console.WriteLine(auxNombre);
            }

            Console.ReadKey();
        }
    }
}
