using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program6
{
    //calling base class constructor from derived class by using 'base' keyword
    internal class Program
    {
        static void Main(string[] args)
        {
            WildAnimal wildanimal = new WildAnimal("Leopard", "wild");
            Console.WriteLine(wildanimal.Name);
            Console.WriteLine(wildanimal.Type);
            Console.ReadKey();
        }
    }
}
