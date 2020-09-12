using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio__11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int minimo = -100;
            int maximo = 100;
            int suma = 0;
            int limite = 10;
            int mayor = int.MinValue;
            int menor = int.MaxValue;
            float promedio = 0;
            bool primerNumeroValido = true; ;

            for (int i = 0; i < limite; i++) {
                Console.WriteLine("Ingresa el " + (i + 1) + "° numero: ");
                numero = int.Parse(Console.ReadLine());
               
                if (Validacion.Validar(numero, minimo, maximo)) {
                    Console.WriteLine("El numero [" + numero + "] es Valido!\n");
                    suma += numero;
                    if (primerNumeroValido)
                    {
                        mayor = numero;
                        menor = numero;
                        primerNumeroValido = false;
                    }
                    if (mayor < numero)
                    {
                        
                        mayor = numero;
                    }
                    else if (menor > numero) {
                        
                        menor = numero;
                    }
                }
                else
                    Console.WriteLine("El numero [" + numero + "] es Invalido");
            }
            promedio = suma / limite;
            Console.WriteLine("Promedio: {0} - Menor: {1} - Mayor {2}",promedio,menor,mayor);
            Console.ReadKey();
        }
    }
}
