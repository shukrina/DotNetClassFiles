using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program9
{
    //interface basic program
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new WildAnimal();
            animal.Name = "Lion";
            animal.Type = "wild";
            animal.WhereItLives();
            Console.ReadKey();
        }
    }
}
