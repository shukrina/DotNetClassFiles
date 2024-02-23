using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    //pass by value
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 13;
            Console.WriteLine(x);
            ChangeInteger(x);
            Console.WriteLine(x);
            Console.ReadKey();
        }
        static void ChangeInteger(int a)
        {
            a = 17;
            Console.WriteLine(a);
        }
    }
}
