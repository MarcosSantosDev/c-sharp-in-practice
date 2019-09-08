using System;
using System.Collections.Generic;
using System.Linq;

namespace c_sharp_in_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            /** TIPOS DE VARIÁVEIS
            var nome_variavel = valor; variavel dinamica 
            <tipo> nome_variavel = valor; variavel estatica
            */

            // Integer
            var int2 = 6;
            int int1 = 3;
            // Double
            var double2 = 6.1;
            double double1 = 3.1;
            // String
            var str2 = "Santos";
            string str1 = "Marcos";
            // Bool
            var boll2 = false;
            bool boll1 = true;

            Console.WriteLine(int1);
            Console.WriteLine(int2);
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(boll1);
            Console.WriteLine(boll2);

            /* CONVERSÕES */
            var v1 = 1.0;

            bool boolean1 = bool.Parse("false");
            bool boolean2 = Convert.ToBoolean(v1);

            Animal a = new Animal();
            Leao l = new Leao();

            l = (Leao)a;

            a = l;
        }

        public class Animal { }

        public class Leao : Animal { }
    }
}
