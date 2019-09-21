using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Calculation
{
    class Media
    {
        public static void CalcularMediaAluno()
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
    }
}