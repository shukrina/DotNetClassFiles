using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program9
{
    //interface basic program
    public interface Animal
    {
        string Name { get; set; }
        string Type { get; set; }

        void WhereItLives();
    }
    internal class WildAnimal: Animal
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public void WhereItLives()
        {
            if (Type == "wild")
                Console.WriteLine(Name+ " lives in jungle.");
            else
                Console.WriteLine(Name+ " lives at home.");
        }
    }
}
