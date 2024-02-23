using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    //program to show how reference of the method in class is passed to another method
    //yo alik mileko xaina jasto lagyo
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Name = "Tiger";
            animal.Description = "carnivorous";
            animal.Type = "wild";
            Console.WriteLine(animal.Name);
            ChangeAnimalName(animal);
            Console.WriteLine(animal.Name);
            Console.ReadKey();
        }
        static void ChangeAnimalName(Animal animal)
        {
            animal.Name = "Lion";
            Console.WriteLine(animal.Name);
        }
    }
}
