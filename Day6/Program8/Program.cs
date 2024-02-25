using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program8
{
    //using finally for garnai parney kaam
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = Convert.ToInt32("1313rs");
                int divisor = 0;
                int result = 17 / divisor;
            }
            catch (FormatException)
            {
                Console.WriteLine("Input was not in correct format.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You attempted to divide by zero.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("You did what needs to be done.");
            }
            Console.ReadKey();
        }
    }
}
