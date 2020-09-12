using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Calculadora
    {
        private static bool Validar(int number) {
            return (number > 0);
        }

        public static void Calcular(int number1, int number2, char sign) {
            double result = double.MinValue;
            bool noDividePorCero = true;
            switch (sign) {
                case '+':
                    result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '/':
                    if (number2 != 0)
                        result = number1 / number2;
                    else
                        Console.WriteLine("No se puede dividir por cero!");
                    noDividePorCero = false;
                    break;
                default:
                    Console.WriteLine("El signo " + sign + " no es valido");
                    break;
            }
            if(noDividePorCero)
                Console.WriteLine("El resultado de {0} {1} {2} es: {3}",number1,sign,number2,result);
                Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer numero: ");
            if(int.TryParse(Console.ReadLine(), out int number1))
                Console.Write("Ingrese el segundo numero: ");
                if (int.TryParse(Console.ReadLine(), out int number2))
                    Console.Write("Ingrese la operacion: [+,-,*,/] ");
                    if (char.TryParse(Console.ReadLine(), out char sign))
                        Calcular(number1, number2, sign);
        }
    }
}
