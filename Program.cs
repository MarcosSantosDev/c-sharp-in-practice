using System;
using System.Collections.Generic;
using System.Linq;

namespace c_sharp_in_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            /** OPERADORES LÓGICOS: [ 
                    "==", "!=", 
                    ">", "<", ">=", <=,
                    "&&", "||" 
                ]
                CONDICIONAIS: [
                    COMUM: "if", "else if", "else"),
                    CASE: "switch",
                    TERNARIO: (1 == 1 ? true : false;)
                ] */

            // CONDICIONAL COMUM("if", "else if", "else")
            // OPERADORES: ("==", "!=")
            var n1 = 1;
            if (n1 == 1)
                Console.WriteLine("entrou na condição do if a == 1");
            else if (n1 != 2)
                Console.WriteLine("entrou na condição do else if a != 2");
            else
                Console.WriteLine("entrou na condição do else");

            // OPERADORES: (">", "<", ">=", <=)
            var n2 = 2;
            if (n1 > n2)
            {
                Console.WriteLine(n1 + " e maior que " + n2);
            }

            if (n1 < n2)
            {
                Console.WriteLine(n1 + " e menor que " + n2);
            }

            if (n1 >= n2)
            {
                Console.WriteLine(n1 + " e maior ou igual a " + n2);
            }

            if (n1 <= n2)
            {
                Console.WriteLine(n1 + " e menor ou igual a " + n2);
            }

            // OPERADORES: ("&&", "||")
            if (2 > 1 || 1 == 2)
            {
                Console.WriteLine("2 é maior ou igual a 1");
            }

            if (2 > 1 && 1 != 2)
            {
                Console.WriteLine("2 é maior que 1 e 1 e diferente de 2");
            }

            // CONDICIONAL CASE("switch")
            int value = 1;
            switch (value)
            {
                case 1:
                    Console.WriteLine("Valor igual a 1");
                    break;
                case 2:
                    Console.WriteLine("Valor igual a 2");
                    break;
                default:
                    Console.WriteLine("Nenhum dos valores entre os casos");
                    break;
            }

            // CONDICIONAL TERNARIO
            int n = 1;
            string result = (n == 1 ? "é igual " : "não é igual ");

            Console.WriteLine("A variavel n " + result + " 1");
        }
    }
}
