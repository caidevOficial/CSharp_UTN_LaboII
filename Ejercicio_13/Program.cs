using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string binary = Conversor.IntegerToBinary(35055007);
            int integerNumber = Conversor.BinaryToDecimal(binary);
            Console.WriteLine(binary);
            Console.WriteLine(integerNumber);
            Console.ReadKey();
        }
    }
}
