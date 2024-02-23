using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    //pass by reference using 'ref' keyword
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 13;
            Console.WriteLine(x);
            ChangeInteger(ref x);
            Console.WriteLine(x);
            Console.ReadKey();
        }
        static void ChangeInteger(ref int a)
        {
            a = 17;
            Console.WriteLine(a);
        }
    }
}
