using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Conversor
    {
        /// <summary>
        /// Converts a integer number into a binary string.
        /// </summary>
        /// <param name="integerNumber">The number to convert.</param>
        /// <returns>The binary string.</returns>
        public static string IntegerToBinary(int integerNumber)
        {
            string reverseBinaryNumber = "";
            string binaryNumber = "";
            char[] listReverseBinaryNumber;

            do
            {
                reverseBinaryNumber += integerNumber % 2;
                integerNumber /= 2;

            } while (integerNumber>0);

            listReverseBinaryNumber = reverseBinaryNumber.ToCharArray();
            Array.Reverse(listReverseBinaryNumber);
            binaryNumber = new string(listReverseBinaryNumber);

            return binaryNumber;
        }

        /// <summary>
        /// Converts a binary string into a integer number.
        /// </summary>
        /// <param name="binary">The binary string to convert</param>
        /// <returns>The integer number of the binary string.</returns>
        public static int BinaryToDecimal(string binary)
        {

            const int DIV = 10;
            int number = 0;
            int digitNumber = 0;
            long binario = 0;

            long.TryParse(binary, out binario);

            for (long i = binario, j = 0; i > 0; i /= DIV, j++)
            {
                digitNumber = (int)i % DIV;
                if (digitNumber != 1 && digitNumber != 0)
                {
                    return -1;
                }
                number += digitNumber * (int)Math.Pow(2, j);
            }

            return number;
        }
    }
}
