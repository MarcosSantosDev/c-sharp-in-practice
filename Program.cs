using System;
using System.Collections.Generic;
using System.Linq;

namespace c_sharp_in_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // # ARRAY
            Console.WriteLine("## - ARRAY -##");

            string[] names1 = new string[3];

            names1[0] = "Marcos";
            names1[1] = "Wesley";
            names1[2] = "Diego";

            foreach (var name in names1)
            {
                Console.WriteLine(name);
            }

            // Exists in Array
            if (Array.Exists(names1, e => e == "Marcos"))
            {
                Console.WriteLine("O nome Marcos foi encontrado no Array.");
            }

            // Get length array
            int size_array = names1.Length;

            Console.WriteLine("## - COLLECTION -##");
            
            // # COLLECTIONS
            List<String> names2 = new List<String>();
            names2.Add("Marcos");
            names2.Add("Wesley");
            names2.Add("Diego");

            foreach (var name in names2)
            {
                Console.WriteLine(name);
            }

            // Exists collection
            if (names2.Exists(e => e == "Marcos"))
            {
                Console.WriteLine("O nome Marcos foi encontrado na collection list.");
            }

            // Get length collection
            int size_collection = names2.Count();
        }
    }
}
