using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace c_sharp_in_practice
{
    class Program
    {
        /** # FUNCTION
            sintax: (local) (type) (return) (name) (params)

            --------------******-------------
            PascalCase, camelCase, under_line
            ---------------------------------
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

        /** #RECURSIVE FUNCTION */
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
        /** CONSTANTS */
        public const int SCHEDULED_EXIT = 1;

        static void Main(string[] args)
        {
            /** 
                SCHEDULED_EXIT = 2;
                
                IF YOU TRY CHANGE VALUE OF THE ONE CONSTANT VARIABLE, YOU PROGRAM NOT STARTED. 
                THE VALUE OF CONSTANT VARIABLE BE MUST IMMUTABLE 
            */
            
            while(true) 
            {
                Console.WriteLine("DIGITE "+SCHEDULED_EXIT+" P/ SAIR DO PROGRAMA.");

                String strValue = Console.ReadLine();
                int value = int.Parse(strValue);

                if (SCHEDULED_EXIT == value)
                {
                    break;
                }
            }

            ReadFileTxt(1);
        }
    }
}
