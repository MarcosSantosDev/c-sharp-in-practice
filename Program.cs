using System;
using System.Collections.Generic;
using System.Linq;

namespace c_sharp_in_practice
{
    class Program
    {
        /** # Funçoes
            sintax: (local) (tipo) (retorno) (nome) (parametro)


            * PascalCase, camelCase, under_line
        */

        private static int Sum(int a, int b)
        {
            int result = a + b;

            return result;
        }

        public static void ShowHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        public static void MultiplicationTable(int num)
        {
            Console.WriteLine("*=============*==============*");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(num+" X "+i+": "+(num*i));
            }
            Console.WriteLine("*=============*==============*");
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Sum(10, 20));

            /** TABUADA */
            MultiplicationTable(1);
            MultiplicationTable(2);
            MultiplicationTable(7);
        }
    }
}
