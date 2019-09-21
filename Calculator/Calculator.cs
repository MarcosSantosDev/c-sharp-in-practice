using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Calculator
{
    class Option
    {
        /** # FUNCTION
            sintax: (local) (type) (return) (name) (params)

            --------------******-------------
            PascalCase, camelCase, under_line
            ---------------------------------
        */

        public static int Sum(int a, int b)
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
                Console.WriteLine(num + " X " + i + ": " + (num * i));
            }
            Console.WriteLine("*=============*==============*");
        }
    }
}