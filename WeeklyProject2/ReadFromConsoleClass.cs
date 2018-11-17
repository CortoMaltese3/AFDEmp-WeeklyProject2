using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyProject2
{
    class ReadFromConsoleClass
    {
        public static double ReadFromConsole()
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
    }
}
