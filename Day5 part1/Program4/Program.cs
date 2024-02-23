using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    //default constructor
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal= new Animal();
            Console.WriteLine(animal.Name);
            Console.WriteLine(animal.Description);
            Console.WriteLine(animal.Type);
            Console.ReadKey();
        }
    }
}
