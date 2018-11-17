using System;

namespace WeeklyProject2
{
    class ReadFromConsole
    {
        public static double ReadNumberFromConsole()
        {
            while (true)
            {
                try
                {
                    return double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Input needs to be a real number. Try again...");
                }
            }
        }

        //TODo can i check if the user input for operation is correct?

        //public enum MathOperators {giorgos, maria }


        //public static string ReadMathOperatorFromConsole(MathOperators mathOperators)
        //{
        //    while (true)
        //    {
        //        try
        //        {
        //            return Console.ReadLine() as MathOperators;
        //        }
        //        catch (Exception)
        //        {
        //            Console.WriteLine("Input needs to be a real number. Try again...");
        //        }
        //    }
        //}
    }
}
