using System;

namespace exerciciosFixacao04_EstruturaCondicional03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores");
            string[] valores = Console.ReadLine().Split(' ');
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);

            if(a%b==0 || b % a == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao multiplos");
            }
        }
    }
}
