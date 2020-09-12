using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_12
{
    class Program
    {
        static void Ejercicio_12() {
            int suma = 0;
            int numero;
            char respuesta = 's';
            bool confirma = true;
            
            while (confirma){
                Console.WriteLine("\nIngresa un numero: ");
                suma += numero = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Seguir? s/n");
                ConsoleKeyInfo cki = Console.ReadKey();
                
                confirma = ValidarRespuesta.ValidaS_N(respuesta = cki.KeyChar);
            }
            Console.WriteLine("\nSuma: {0}", suma);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Ejercicio_12();
        }
    }
}
