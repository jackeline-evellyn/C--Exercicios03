using System;

namespace exerciciosFixacao05_EstruturaRepeticao_For2
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd = int.Parse(Console.ReadLine());
            int numero = 0;
            int dentro = 0;
            int fora=0;
            for(int i=1; i<=qtd; i++)
            {
                numero = int.Parse(Console.ReadLine());
                if(numero>=10 && numero <= 20)
                {
                    dentro += 1; 
                }
                else
                {
                    fora += 1;
                }
            }
            Console.WriteLine("{0} in",dentro);
            Console.WriteLine("{0} out", fora);
        }
    }
}
