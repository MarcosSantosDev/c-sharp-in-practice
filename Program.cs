using System;
using System.Collections.Generic;
using System.IO;
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
                Console.WriteLine(num + " X " + i + ": " + (num * i));
            }
            Console.WriteLine("*=============*==============*");
        }

        /** # Funçao recursiva */
        private static void ReadFileTxt(int numberFile) 
        {
            string pathFile = @"./test_files/file"+numberFile+".txt";

            if(File.Exists(pathFile)) {
                using (var reader = new StreamReader(pathFile))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }

            int next = numberFile+1;
            string pathNextFile = @"./test_files/file"+next+".txt";

            if(File.Exists(pathNextFile)) {
                ReadFileTxt(numberFile+1);
            }
        }

        static void Main(string[] args)
        {
            ReadFileTxt(1);
        }
    }
}
