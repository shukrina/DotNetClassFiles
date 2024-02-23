﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    //parameterized constructor and constructor overloading
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal();
            Console.WriteLine(animal1.Name);
            Console.WriteLine(animal1.Description);
            Console.WriteLine(animal1.Type);
            Animal animal2 = new Animal("Tiger","carnivorous","wild"); ;
            Console.WriteLine(animal2.Name);
            Console.WriteLine(animal2.Description);
            Console.WriteLine(animal2.Type);
            Console.ReadKey();
        }
    }
}
