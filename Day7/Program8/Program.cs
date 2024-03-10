using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program8
{
    //program using LINQ - lambda Expressions to print items that match the given string from a list
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Console.WriteLine("Matched items are: ");
            list = GetAppropriateList("jun");
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
                list.Where(person => person.ToUpper()==name.ToUpper()).ToList();
                //For case sensitive,
                //list.Where(person => person==name).ToList();
        }
    }
}
