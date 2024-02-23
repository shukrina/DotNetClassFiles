using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    //program showing multi-level inheritance
    internal class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public void WhatItEats()
        {
            if (Description == "herbivorous")
                Console.WriteLine("It eats grass.");
            else if (Description == "carnivorous")
                Console.WriteLine("It eats flesh. ");
            else if (Description == "omnivorous")
                Console.WriteLine("It eats grass and flesh.");
            else
                Console.WriteLine("Description not appropriate.");
        }
    }
    internal class WildAnimal : Animal
    {
        public void WhereItLives()
        {
            Console.WriteLine("It lives in jungle.");
        }
    }
    internal class Predator: WildAnimal
    {
        internal void describe()
        {
            Console.WriteLine(Name+ " eats meat.");
        }
    }
}
