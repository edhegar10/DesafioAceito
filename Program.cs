using System;

namespace ConsoleCadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Console.WriteLine("Olá Mundo!");

            int a = 1;    
            int b = 2;
            int resultado = a + b;
            long c = 1;
            string caixaDeTexto = "caixa" + "de" + "texto" + 2;
            double d = 2.1;
            float f = 2.1f;

            Console.WriteLine("O resultado é " + resultado);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine("C=" + c + " Valor maximo de long" + long.MaxValue );
            Console.WriteLine(caixaDeTexto);
            Console.WriteLine("Valor de double = " + d);
            Console.WriteLine("Valor de float = " + f);
            */
            FazerCafe("caramelo");
            FazerCafe("chocolate");

        }
        static void FazerCafe(string capsula)
        {
            System.Console.WriteLine("Esquentar água");
            System.Console.WriteLine("Coloca pó de magia(café)");
            System.Console.WriteLine("Colocar " + capsula);
        }
    }
}
