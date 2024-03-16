using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    //start of week 3
    //program to show basic abstract class
    internal class Program
    {
        static void Main(string[] args)
        {
            WildAnimal wildAnimal = new WildAnimal();
            wildAnimal.Name = "Lion";
            wildAnimal.Type = "wild";
            wildAnimal.WhereItLives();
            Console.ReadKey();
        }
    }
}
