using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    //program to use 'sealed' keyword
    internal class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        //public string NameAndDesc;
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
    internal sealed class WildAnimal : Animal
    {
        public void WhereItLives()
        {
            Console.WriteLine("It lives in jungle.");
        }
    }
}
