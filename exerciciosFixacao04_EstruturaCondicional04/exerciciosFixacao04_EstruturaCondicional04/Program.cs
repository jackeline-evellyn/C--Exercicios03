using System;

namespace exerciciosFixacao04_EstruturaCondicional04
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] valores = Console.ReadLine().Split(' ');
            int valor1 = int.Parse(valores[0]);
            int valor2 = int.Parse(valores[1]);
            int duracao = 0;

            if(valor2> valor1)
            {
                duracao = valor2 - valor1;
            }
            else
            {
                duracao = 24 - valor1 + valor2;
            }
            Console.WriteLine("O JOGO DUROU "+ duracao + " HORA(S)");
        }
    }
}
