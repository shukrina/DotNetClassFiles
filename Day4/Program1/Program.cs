using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    //program showing multi-level inheritance
    internal class Program
    {
        static void Main(string[] args)
        {
            Predator predator = new Predator();
            predator.Name = "Lion";
            predator.Description = "carnivorous";
            predator.describe();
            predator.WhatItEats();
            predator.WhereItLives();
            Console.ReadKey();
        }
    }
}
