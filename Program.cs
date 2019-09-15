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

        private static void CalcularMediaAluno()
        {
            Console.WriteLine("Digite o nome do aluno");

            string nome = Console.ReadLine();
            int qtdNotas = 3;

            Console.WriteLine("Digite as " + qtdNotas + " notas do aluno " + nome);

            List<int> notas = new List<int>();
            int totalNotas = 0;

            for (int i = 0; i < qtdNotas; i++)
            {
                Console.WriteLine("Digite a nota numero " + i);

                int nota = int.Parse(Console.ReadLine());

                totalNotas += nota;

                notas.Add(nota);
            }
            int media = totalNotas / notas.Count();

            Console.WriteLine("A media do aluno " + nome + " é: " + media);
        }

        public static void Menu()
        {
            while (true)
            {
                string message = "Olá usuario, bem vindo ao programa\n" +
                "\n Utilizando programação funcional" +
                "\n\n" +
                "\n Digite uma das opções abaixo:" +
                "\n     0 - Sair do programa" +
                "\n     1 - Para ler arquivos" +
                "\n     2 - Para executar a tabuada" +
                "\n     3 - Calcular média de Alunos";

                Console.WriteLine(message);

                String strValue = Console.ReadLine();
                int value = int.Parse(strValue);

                if (value == SCHEDULED_EXIT)
                {
                    break;
                }
                else if (value == READ_FILES)
                {
                    Console.WriteLine("======== Opção ler arquivos =========");
                    ReadFileTxt(1);
                }
                else if (value == MULTIPLICATION_TABLE)
                {
                    Console.WriteLine("======== Opção tabuada =========");
                    Console.WriteLine("Digite o numero que deseja na tabuada.");

                    MultiplicationTable(1);
                }
                else if (value == MEDIA_CALCULATION)
                {
                    CalcularMediaAluno();
                }
                else
                {
                    Console.WriteLine("Opção invalida. Tente novamente.");
                }
            }
        }

        /** CONSTANTS */
        public const int SCHEDULED_EXIT = 0;
        public const int READ_FILES = 1;
        public const int MULTIPLICATION_TABLE = 2;
        public const int MEDIA_CALCULATION = 3;

        static void Main(string[] args)
        {
            Menu();
        }
    }
}
