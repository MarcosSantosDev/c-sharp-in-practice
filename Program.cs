using System;
using System.Collections.Generic;
using System.Linq;

namespace c_sharp_in_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            /** LOOPINGS
                TIPOS: [
                    while,
                    do while,
                    for,
                    foreach,
                    funções recursivas
                ]
            */

            // # while
            var n1 = 1;

            while (n1 <= 4)
            {
                Console.WriteLine(n1);
                n1++;
            }

            Console.WriteLine("****** -- ******");

            // # do while
            do
            {
                Console.WriteLine(n1);
                n1++;
            } while (n1 <= 10);

            Console.WriteLine("****** -- ******");

            // # for
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("****** -- ******");

            // # foreach
            var collection = new List<int>();
            collection.Add(1);
            collection.Add(2);
            collection.Add(3);
            collection.Add(4);

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("****** -- ******");

            // #funções recursiva;
            looping(1);
        }

        public static void looping(int a)
        {
            Console.WriteLine(a);
            if (a < 4)
            {
                looping(a + 1);
            }
        }
    }
}
