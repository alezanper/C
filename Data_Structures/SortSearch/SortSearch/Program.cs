using System;
using System.Collections.Generic;

namespace SortSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Alexander", "Homero", "Marge" };
            names.Add("Maria");
            names.Add("Juana");
            names.Remove("Homero");

            foreach(var name in names)
            {
                Console.WriteLine(name);
            };

            Console.WriteLine(names[0]);

            var index = names.IndexOf("Juana");

            if(index == -1)
            {
                Console.WriteLine($"When an item is not found, indexof returns: {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index: {index}");
            }

            names.Sort();
            Console.WriteLine("\nSorting: ");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            };


        }
    }
}
