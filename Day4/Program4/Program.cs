using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    //program to use 'new' keyword
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Name = "Dog";
            animal.Type = "domestic";
            Console.WriteLine(animal.Name);
            animal.WhereItLives();

            WildAnimal wildAnimal=new WildAnimal();
            wildAnimal.Name = "Lion";
            wildAnimal.Type = "wild";
            Console.WriteLine(wildAnimal.Name);
            wildAnimal.WhereItLives();
            Console.ReadKey();
        }
    }
}
