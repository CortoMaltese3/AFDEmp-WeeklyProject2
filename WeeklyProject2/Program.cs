using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bi-Weekly Project 2 - Individual");
            Console.WriteLine("--------------------------------\n");

            Console.WriteLine("The following application calculates the result of a math operation between two numbers of your choice");

            int firstResult = (int)MathOperation.DoCalculations();
            int SecondResult = (int)MathOperation.DoCalculations();

            //GreatestCommonDivisor.GCD(firstResult, SecondResult);
            Console.WriteLine($"The Greatest Common Divisor of {firstResult} and {SecondResult} is {GreatestCommonDivisor.GCD(firstResult, SecondResult)} ");




            Console.WriteLine("Press any key to close the app");
            Console.ReadKey();

        }
    }
}
