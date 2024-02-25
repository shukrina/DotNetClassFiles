using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    //program to illustrate getter & setter and field & property
    internal class Animal
    {
        private int Age;
        public int age
        {
            get { return Age; }
            set { Age = value; }
        }
        public void display()
        {
            Console.WriteLine(Age+ " is the value of Age (field).");
        }
    }
}
