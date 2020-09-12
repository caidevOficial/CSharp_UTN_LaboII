using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Program
    {

        static void Main(string[] args)
        {
            Boligrafo lapiAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo lapiRoja = new Boligrafo(50, ConsoleColor.Red);
            string dibujo;
            lapiRoja.Pintar(-1, out dibujo); // arreglar
            Console.WriteLine(dibujo);
            Console.ReadKey();



        }
    }
}
