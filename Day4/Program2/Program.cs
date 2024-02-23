using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Program2
{
    //program to use 'sealed' keyword
    internal class Program
    {
        static void Main(string[] args)
        {
            WildAnimal wildAnimal = new WildAnimal();
            wildAnimal.Name = "Tiger";
            wildAnimal.Description = "carnivorous";
            wildAnimal.WhereItLives();
            wildAnimal.WhatItEats();
            Console.ReadKey();
        }
    }
}
