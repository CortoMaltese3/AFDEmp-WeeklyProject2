using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyProject2
{
    class GreatestCommonDivisor
    {
        public static int GCD(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Calculating the Greatest Common Divisor, using the past two results of the Calculator\r\nNote that the results will be transformed to integers");

            int Remainder;

            while (secondNumber != 0)
            {
                Remainder = firstNumber % secondNumber;
                firstNumber = secondNumber;
                secondNumber = Remainder;
            }
            return firstNumber;

        }
    }
}
