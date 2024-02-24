using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    //default, parameterless constructor
    internal class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type {  get; set; }
        public Animal() {
            Console.WriteLine("An object of animal is created.");
            Name = "Rabbit";
            Description = "herbivorous";
            Type = "pet";
        }
    }
}
