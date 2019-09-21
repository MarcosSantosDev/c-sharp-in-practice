using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Calculation;
using Calculator;
using ReadFile;

namespace Menu
{
    class CreateMenu
    {
        /** CONSTANTS */
        public const int SCHEDULED_EXIT = 0;
        public const int READ_FILES = 1;
        public const int MULTIPLICATION_TABLE = 2;
        public const int MEDIA_CALCULATION = 3;

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
                    ReadFiles.ReadFileTxt(1);
                }
                else if (value == MULTIPLICATION_TABLE)
                {
                    Console.WriteLine("======== Opção tabuada =========");
                    Console.WriteLine("Digite o numero que deseja na tabuada.");
                    
                    int number = int.Parse(Console.ReadLine());

                    Option.MultiplicationTable(number);
                }
                else if (value == MEDIA_CALCULATION)
                {
                    Media.CalcularMediaAluno();
                }
                else
                {
                    Console.WriteLine("Opção invalida. Tente novamente.");
                }
            }
        }
    }
}