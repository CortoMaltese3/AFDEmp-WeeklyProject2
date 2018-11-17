using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyProject2
{
    class FibonacciClass
    {
        public static int Fibonacci(int secondNumber)
        {
            if (secondNumber == 1 || secondNumber == 2)
            {
                return 1;
            }
            int prev_number = 0, curr_number = 1, next_number = 0;
            for (int index = 1; index < secondNumber; index++)
            {
                next_number = prev_number + curr_number;
                prev_number = curr_number;
                curr_number = next_number;
            }
            return next_number;
        }

        public static bool FibonacciSequence(int n)
        {

            int[] i = new[] { 0, 1, 0 };
            while (i[0] < n || i[1] < n)
            {
                i[i[2] % 2] = i[0] + i[1]; i[2]++;
            }
            return n == i[0] || n == i[1];
        }

        public static void FibonacciCheck(int firstNumber)
        {
            if (FibonacciSequence(firstNumber) == true)
            {
                Console.WriteLine($"The number {firstNumber} corresponds to a number of the Fibonacci Sequence");
            }
            else
            {
                Console.WriteLine($"The number {firstNumber} does not correspond to a number of the Fibonacci Sequence");
            }
        }
    }
}
