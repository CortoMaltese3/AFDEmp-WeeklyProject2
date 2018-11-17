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
            Console.WriteLine("--------------------------------");
            //Console.WriteLine("The following application calculates the result of a math operation between two numbers of your choice");

            Console.WriteLine("Steps 1-2 : Calculator");
            Console.WriteLine("Enter two numbers and a math operator of your choice to calculate the first result...");
            int firstResult = Convert.ToInt32(MathOperation.DoCalculations());
            Console.WriteLine("Enter two numbers and a math operator of your choice to calculate the second result...");
            int SecondResult = Convert.ToInt32(MathOperation.DoCalculations());
            Console.WriteLine("\r\nPress any key to continue...\r\n");
            Console.ReadKey();


            Console.WriteLine("Step 4 : Calculating the GCD");
            Console.WriteLine($"Based on the last two results, the Greatest Common Divisor of {firstResult} and {SecondResult} is {GreatestCommonDivisor.GCD(firstResult, SecondResult)} \r\nNote that the numbers you entered were rounded up accordingly ");
            Console.WriteLine("\r\nPress any key to continue...\r\n");
            Console.ReadKey();

            Console.WriteLine("Step 3 : Checking if the second result is a Prime Number");
            PrimeNumberClass.PrimeNumberCheck(SecondResult);

            Console.WriteLine("Press any key to close the app");
            Console.ReadKey();

        }
    }
}
