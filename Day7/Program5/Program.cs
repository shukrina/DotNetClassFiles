using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    //DivideByZero Exception Handling
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int divisor = 0;
                int result = 13 / divisor;

            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("You attempted to perform dividing by zero, which is not possible");
            }
            Console.ReadKey();
        }
    }
}
