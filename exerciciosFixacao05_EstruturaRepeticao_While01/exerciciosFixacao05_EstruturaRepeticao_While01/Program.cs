using System;

namespace exerciciosFixacao05_EstruturaRepeticao_While01
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = int.Parse(Console.ReadLine());     
            while (senha != 2002)
            {
                Console.WriteLine("Senha Inválida");
                senha = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("Acesso permitido");
        }
    }
}
