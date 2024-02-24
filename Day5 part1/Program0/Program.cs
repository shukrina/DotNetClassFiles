using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    //program to show how value of the object in class is passed to another method
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Name = "Tiger";
            animal.Description = "carnivorous";
            animal.Type = "wild";
            Console.WriteLine(animal.Name);
            ChangeAnimalName(animal.Name);
            Console.WriteLine(animal.Name);
            Console.ReadKey();
        }
        static void ChangeAnimalName(string Name)
        {
            Name = "Lion";
            Console.WriteLine(Name);
        }
    }
}
