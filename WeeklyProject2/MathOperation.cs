using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyProject2
{
    class MathOperation
    {
        public void DoCalculations()
        {
            double num1, num2;

            Console.WriteLine("Type a number and press Enter : ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nType a second number and press Enter : ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose a math operation between these two numbers.\nChoices are + , - , * , / , % , square root");
            string mathOperation = Console.ReadLine();

            switch (mathOperation)
            {
                case "+":
                    Console.WriteLine($"Result : {num1} + {num2} = " + num1 + num2);
                    break;
                case "-":
                    Console.WriteLine($"Result : {num1} - {num2} = " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine($"Result : {num1} * {num2} = " + (num1 * num2));
                    break;
                case "/":
                    while (num2 == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        num2 = double.Parse(Console.ReadLine());
                    }
                    Console.WriteLine($"Result : {num1} / {num2} = " + (num1 / num2));

                    break;
                case "%":
                    while (num2 == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        num2 = double.Parse(Console.ReadLine());
                    }
                    Console.WriteLine($"Result : {num1} % {num2} = " + (num1 % num2));
                    break;
                case "square root":
                    Console.WriteLine($"Result : {num1} sqrt {num2} = " + Math.Pow(num1, 1 / num2));
                    //TODO check division by zero
                    break;
                default:
                    Console.WriteLine("Incorrect Option");
                    break;

            }
        }
    }
}
