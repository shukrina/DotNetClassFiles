using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    //program to illustrate getter & setter and field & property
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.age = 11;
            animal.display();
            Console.WriteLine(animal.age+" is the value of age (property).");
            Console.ReadKey();
        }
    }
}
