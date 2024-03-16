using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    //start of week 3
    //program to show basic abstract class
    abstract internal class Animal
    {
        public string Name { get; set; }
        public string Type { get; set; }
        abstract public void WhereItLives();

    }
    internal class WildAnimal: Animal
    {
        public override void WhereItLives()
        {
            Console.WriteLine(Name+ " lives in jungle.");
        }
    }
}
