using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program7
{
    //calling base class function from derived class using 'base' keyword
    internal class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type {  get; set; }
        public Animal(string name, string description, string type)
        {
            Name = name;
            Description = description;
            Type = type;
        }
        public void WhereItLives()
        {
            if (Type == "wild")
                Console.WriteLine("It lives in jungle");
            else
                Console.WriteLine("It lives at home.");

        }
        public void WhatItEats()
        {
            if (Description == "herbivorous")
                Console.WriteLine("It eats grass.");
            else if (Description == "carnivorous")
                Console.WriteLine("It eats meat");
            else
                Console.WriteLine("It eats both grass and meat.");
        }
    }
    internal class WildAnimal: Animal
    {
        public WildAnimal(string name, string description, string type) : base(name, description, type) { }
        public new void WhereItLives()
        {
            Console.WriteLine(Name + " lives in jungle.");
            base.WhatItEats();//this is the base keyword used to call base class function
        }
        
    }
}
