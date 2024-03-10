using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    //program to print items that contains 'ON' from a list
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Console.WriteLine("Items in the list containing 'ON' are: ");
            list = GetAppropriateList("ON");
            foreach(string personName in list) 
            {
                Console.WriteLine(personName);
            }
            Console.ReadKey();
        }
        static List<string> GetAppropriateList(string name)
        {
            List<string> list=new List<string>();
            list.Add("Scoups");
            list.Add("Jeonghan");
            list.Add("Joshua");
            list.Add("Jun");
            list.Add("Hoshi");
            list.Add("Wonwoo");
            list.Add("Woozi");
            return
                (from person in list where person.ToUpper().Contains(name.ToUpper()) select person ).ToList();
                //For case sensitive,
                //(from person in list where person.Contains(name) select person ).ToList();
        }
    }
}
