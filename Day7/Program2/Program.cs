using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    //program to print items that starts with 'Ju' from a list
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Console.WriteLine("Items in the list starting with 'Ju' are: ");
            list = GetAppropriateList("ju");
            foreach (string personName in list)
            {
                Console.WriteLine(personName);
            }
            Console.ReadKey();
        }
        static List<string> GetAppropriateList(string name)
        {
            List<string> list = new List<string>();
            list.Add("Scoups");
            list.Add("Jeonghan");
            list.Add("Joshua");
            list.Add("Jun");
            list.Add("Hoshi");
            list.Add("Wonwoo");
            list.Add("Woozi");
            return
                (from person in list where person.ToUpper().StartsWith(name.ToUpper()) select person).ToList();
                //For case sensitive,
                //(from person in list where person.StartsWith(name) select person ).ToList();
        }
    }
}
