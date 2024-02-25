using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program6
{
    //illustrating how the first exception is the one to be handled
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = Convert.ToInt32("net");
                int divisor = 0;
                int result = 17 / divisor;
            }
            catch(FormatException)
            {
                Console.WriteLine("Format exception.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Dividing by zero was attempted.");
            }
            Console.ReadKey();
        }
    }
}
