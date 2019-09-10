using System;

namespace exerciciosFixacao05_EstruturaRepeticao_For5
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatorial = 1;
            int numero = int.Parse(Console.ReadLine());
            
                if (numero == 0)
                {
                fatorial = 1;
                   }
                else
                {
                    for (int i = 1; i <= numero; i++)
                {
                    fatorial = fatorial * i;
                }
                }
            Console.WriteLine(fatorial);
            
        }
    }
}
