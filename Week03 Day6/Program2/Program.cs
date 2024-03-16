using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    //program to show how only function with 'abstract' function need to be overridden.
    internal class Program
    {
        static void Main(string[] args)
        {
            WildAnimal wildAnimal = new WildAnimal();
            wildAnimal.Name = "Lion";
            wildAnimal.Description = "carnivorous";
            wildAnimal.Type = "wild";
            wildAnimal.WhatItEats();
            wildAnimal.WhereItLives();
            Console.ReadKey();
        }
    }
}
