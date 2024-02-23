using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    //program to implement partial classses
    internal partial class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type {  get; set; }
        public void WhereItLives()
        {
            if (Type == "wild")
                Console.WriteLine(Name + " lives in jungle.");
            else
                Console.WriteLine(Name + " is raised in home.");
        }

    }
}
