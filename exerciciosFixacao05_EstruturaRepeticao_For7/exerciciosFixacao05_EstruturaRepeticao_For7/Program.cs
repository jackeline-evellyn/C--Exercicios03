using System;

namespace exerciciosFixacao05_EstruturaRepeticao_For7
{
    class Program
    {
        static void Main(string[] args)
        {
            int quadrado = 0, cubo = 0;
            int numero = int.Parse(Console.ReadLine());
            for(int i=1; i <= numero; i++)
            {
                quadrado = (int) Math.Pow(i, 2);
                cubo = (int) Math.Pow(i, 3);
                Console.WriteLine("{0} {1} {2}", i, quadrado, cubo);
            }
        }
    }
}
