using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyProject2
{
    class MathOperation
    {

        public double DoCalculations()
        {
            double num1, num2, result;

            Console.WriteLine("Type the first number and press Enter : ");

            double num3 = ReadFromConsoleClass.ReadFromConsole();
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n\rType the second number and press Enter : ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose a math operation between these two numbers.\nChoices are + , - , * , / , % , square root");
            string mathOperation = Console.ReadLine();

            result = 0;

            switch (mathOperation)
            {
                //TODO's : personalize the messages according to the operation
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Result : {num1} + {num2} = " + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Result : {num1} - {num2} = " + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Result : {num1} * {num2} = " + result);
                    break;
                case "/":
                    while (num2 == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        num2 = double.Parse(Console.ReadLine());
                    }
                    result = num1 / num2;
                    Console.WriteLine($"Result : {num1} / {num2} = " + result);

                    break;
                case "%":
                    while (num2 == 0)
                    {
                        Console.WriteLine("Division with zero returns a non-real number. Enter a non-zero divisor: ");
                        num2 = double.Parse(Console.ReadLine());
                    }
                    result = num1 % num2;
                    Console.WriteLine($"Result : {num1} % {num2} = " + result);
                    break;
                case "square root":
                    while (num1 < 0)
                    {
                        Console.WriteLine("Only non-negative numbers are permitted under a root. Enter a non-negative number: ");
                        num1 = double.Parse(Console.ReadLine());
                    }
                    result = Math.Pow(num1, 1 / num2);
                    Console.WriteLine($"Result : {num1} sqrt {num2} = " + result);
                    //TODO check division by zero
                    break;
                default:
                    Console.WriteLine("Incorrect Option");
                    break;
            }
            return result;
        }


    }





}
