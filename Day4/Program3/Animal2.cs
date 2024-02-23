using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    internal partial class Animal
    {
        //program to implement partial classses

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
