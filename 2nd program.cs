using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace afcseg
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            Console.Write("The names in Alphabetical Order:");
            names.Add("Kums");
            names.Add("Kishore");
            names.Add("Shyam");
            names.Add("Perumal");
            names.Add("Abbi");
            names.Sort();
            foreach (string s in names)
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
