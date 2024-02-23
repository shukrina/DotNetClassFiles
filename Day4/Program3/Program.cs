using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    //program to implement partial classses
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal= new Animal();
            animal.Name = "Tiger";
            animal.Description = "carnivorous";
            animal.Type = "wild";
            animal.WhereItLives();
            animal.WhatItEats();
            Console.ReadKey();
        }
    }
}
