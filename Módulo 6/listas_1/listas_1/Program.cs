using System;
using System.Collections.Generic;

namespace listas_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            
            list.Add("a");
            list.Add("b");
            list.Add("c");
            list.Add("d");
            list.Insert(0, "I'm the First");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("List count: " + list.Count);

        }
    }
}
