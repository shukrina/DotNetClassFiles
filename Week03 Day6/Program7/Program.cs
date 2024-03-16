using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program7
{
    //general case for exception handling
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = Convert.ToInt32("111111111111111111111");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
