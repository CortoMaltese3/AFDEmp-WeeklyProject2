using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyProject2
{
    class MathOperation
    {
        static void SymbolsToList()
        {
            List<string> Symbols = new List<string>();
            Symbols.Add("+");
            Symbols.Add("-");
            Symbols.Add("*");
            Symbols.Add("/");
            Symbols.Add("%");
            Symbols.Add("square root");
        }
        


        public int Num1 { get; set; }
        public int Num2 { get; set; }

        MathOperation(int num1, int num2)
        {
            num1 = Num1;
            num2 = Num2;

            switch (mathOperation)
            {
                case "+":
                    Console.WriteLine($"Result : {num1} + {num2} = " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine($"Result : {num1} - {num2} = " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine($"Result : {num1} * {num2} = " + (num1 * num2));
                    break;
                case "/":
                    Console.WriteLine($"Result : {num1} / {num2} = " + (num1 / num2));
                    break;
                case "%":
                    Console.WriteLine($"Result : {num1} % {num2} = " + (num1 % num2));
                    break;
                case "square root":
                    Console.WriteLine($"Result : {num1} sqrt {num2} = " + (Math.Pow(num1, (1 / num2))));
                    //TODO check division by zero
                    break;
                default:
                    Console.WriteLine("Incorrect Option");
                    break;

            }
        }
    }
}
