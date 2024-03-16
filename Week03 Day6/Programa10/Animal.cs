using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program10
{
    //using interface to implement multiple inheritance
    internal interface Animal
    {
        string Name { get; set; }
        string Description { get; set; }
        void WhatItEats();
    }
    internal interface Vertebrate
    {
        string Type { get; set; }
        void WhereItLives();

    }
    internal class WildAnimal : Animal, Vertebrate
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public void WhereItLives()
        {
            if (Type == "wild")
                Console.WriteLine(Name + " lives in jungle.");
            else
                Console.WriteLine(Name + " lives at home.");
        }
        public void WhatItEats()
        {
            if (Description == "herbivorous")
                Console.WriteLine(Name + " eats grass.");
            else if (Description == "carnivorous")
                Console.WriteLine(Name + " eats meat.");
            else
                Console.WriteLine(Name + " eats both grass and meat.");
        }
    }
}
