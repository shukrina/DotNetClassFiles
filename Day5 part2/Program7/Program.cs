using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program7
{
    //calling base class function from derived class using 'base' keyword
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("rabbit", "herbivorous", "domestic");
            Console.WriteLine(animal.Name +" is a " + animal.Description + " and a " + animal.Type+" animal");
            animal.WhereItLives(animal.Type);
            animal.WhatItEats (animal.Description);
            Console.WriteLine();

            WildAnimal animal2 = new WildAnimal("Leopard", "carnivorous", "wild");
            Console.WriteLine(animal2.Name+ " is a "+ animal2.Description+ " and a "+ animal2.Type+" animal");
            animal2.WhereItLives(animal2.Type);
            Console.ReadKey();
        }
    }
}
