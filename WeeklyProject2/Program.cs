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

            MathOperation math = new MathOperation();
            math.DoCalculations();


            

            Console.WriteLine("Press any key to close the app");
            Console.ReadKey();

        }
    }
}
