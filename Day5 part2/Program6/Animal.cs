using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program6
{
    //calling base class constructor from derived class by using 'base' keyword
    public class Animal
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Animal(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
    public class WildAnimal : Animal
    {
        public WildAnimal(string Name, string Type) : base(Name, Type)
        {
            Console.WriteLine("Constructor within a derived class is invoked.");
        }

    }
}
