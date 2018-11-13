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
            int num1 = 0; int num2 = 0;
            string mathOperation;
            int result;

            

            Console.WriteLine("Type a number and press Enter : ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nType a second number and press Enter : ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose a math operation between these two numbers.\nChoices are + , - , * , / , % , square root");
            mathOperation = Console.ReadLine();

            switch (mathOperation)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Result : {num1} + {num2} = " + (num1 + num2));
                    break;
                case "-":
                    result = num1 + num2;
                    Console.WriteLine($"Result : {num1} - {num2} = " + (num1 - num2));
                    break;
                case "*":
                    result = num1 + num2;
                    Console.WriteLine($"Result : {num1} * {num2} = " + (num1 * num2));
                    break;
                case "/":
                    Console.WriteLine($"Result : {num1} / {num2} = " + (num1 / num2));
                    result = num1 + num2;
                    break;
                case "%":
                    Console.WriteLine($"Result : {num1} % {num2} = " + (num1 % num2));
                    result = num1 + num2;
                    break;
                case "square root":
                    Console.WriteLine($"Result : {num1} sqrt {num2} = " + (Math.Pow(num1, (1/num2))));
                    //TODO check division by zero
                    break;
                default:
                    Console.WriteLine("Incorrect Option");
                    break;

            }

            Console.WriteLine("Press any key to close the app");
            Console.ReadKey();

        }

    }
}