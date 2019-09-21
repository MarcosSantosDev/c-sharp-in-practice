using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ReadFile
{
    class ReadFiles
    {
        /** #RECURSIVE FUNCTION */
        public static void ReadFileTxt(int numberFile)
        {
            string fileName = @"file" + numberFile + ".txt";
            string pathFile = @"./test_files/" + fileName;

            if (File.Exists(pathFile))
            {
                Console.WriteLine("Arquivo: " + fileName);

                using (var reader = new StreamReader(pathFile))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }

            int next = numberFile + 1;
            string pathNextFile = @"./test_files/file" + next + ".txt";

            if (File.Exists(pathNextFile))
            {
                ReadFileTxt(numberFile + 1);
            }
        }
    }
}