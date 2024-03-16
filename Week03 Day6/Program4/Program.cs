using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    //format exception handling
    internal class Program
    {
        static void Main(string[] args)
        {
            int a ;
            try
            {
                a = Convert.ToInt32("Ram");
            }
            catch(FormatException e)  //catch(FormatException) matra rakhey ni chalxa
            {
                //Console.WriteLine(e.Message);
                Console.WriteLine("There is a format exception");
            }
            Console.ReadKey();
        }
    }
}
