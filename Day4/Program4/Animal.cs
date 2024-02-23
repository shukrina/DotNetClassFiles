using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    //program to use 'new' keyword to re-implement a method
    internal class Animal
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public void WhereItLives()
        {
            if (Type == "wild")
                Console.WriteLine("It lives in jungle.");
            else
                Console.WriteLine("It lives at home.");
        }
    }
    internal class WildAnimal : Animal
    {
        //new public void WhereItLives()  is also correct
        public new void WhereItLives()
        {
            Console.WriteLine(Name + " lives in jungle.");
        }
    }
}
