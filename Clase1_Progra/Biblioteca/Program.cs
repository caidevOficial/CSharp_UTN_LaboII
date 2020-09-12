using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double area) {
            return (Math.Pow(area, 2));
        }

        public static double CalcularTriangulo(double b, double h) {
            return (b * h) / 2;
        }

        public static double CalcularCirculo(double r) {
            return Math.PI * (Math.Pow(r, 2));
        }

        static void Main(string[] args)
        {
            //int number;
            Console.Write("Ingrese un lado del cuadrado: ");
            if (double.TryParse(Console.ReadLine(), out double square)) {
                double squareArea = CalcularCuadrado(square);
                Console.WriteLine("El Area del cuadrado es: " + squareArea);
            }

            Console.Write("Ingrese la base del triangulo: ");
            if (double.TryParse(Console.ReadLine(), out double b))
            {
                Console.Write("Ingrese la altura del triangulo: ");
                if (double.TryParse(Console.ReadLine(), out double h))
                {
                    double triangleArea = CalcularTriangulo(b,h);
                    Console.WriteLine("El Area del triangulo es: " + triangleArea);
                }
                    
            }

            Console.Write("Ingrese el radio del circulo: ");
            if (double.TryParse(Console.ReadLine(), out double radio))
            {
                double circleArea = CalcularCirculo(radio);
                Console.WriteLine("El Area del circulo es: " + circleArea);
            }
            Console.ReadKey();
        }
    }
}
