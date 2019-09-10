using System;

namespace exerciciosFixacao04_EstruturaCondicional01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NÂO NEGATIVO");
            }
        }
    }
}
