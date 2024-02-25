using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    //program to show how only function with 'abstract' function need to be overridden.
    abstract internal class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        abstract public void WhereItLives();
        public void WhatItEats()
        {
            if (Description == "herbivorous")
                Console.WriteLine("It eats grass.");
            else if (Description == "carnivorous")
                Console.WriteLine("It eats meat.");
            else
                Console.WriteLine("It eats both grass and meat.");
        }

    }
    internal class WildAnimal : Animal
    {
        public override void WhereItLives()
        {
            Console.WriteLine(Name + " lives in jungle.");
        }
    }
}
