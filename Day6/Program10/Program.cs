using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program10
{
    //using interface to implement multiple inheritance
    internal class Program
    {
        static void Main(string[] args)
        {
            WildAnimal wildAnimal = new WildAnimal();
            wildAnimal.Name = "Lion";
            wildAnimal.Description = "carnivorous";
            wildAnimal.Type = "wild";
            wildAnimal.WhereItLives();
            wildAnimal.WhatItEats();
            Console.ReadKey();
        }
    }
}
