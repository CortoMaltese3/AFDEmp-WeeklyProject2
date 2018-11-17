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
    }
}
