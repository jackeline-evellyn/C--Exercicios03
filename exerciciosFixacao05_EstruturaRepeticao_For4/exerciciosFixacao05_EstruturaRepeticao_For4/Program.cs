using System;
using System.Globalization;

namespace exerciciosFixacao05_EstruturaRepeticao_For4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int primeiro = 0;
            int segundo = 0;
            double resultado = 0.0;

            string[] valores = Console.ReadLine().Split(' ');
            primeiro = int.Parse(valores[0]);
            segundo = int.Parse(valores[1]);

            for (int i=1; i <= n; i++)
            {
               
                if(segundo != 0)
                {
                    resultado = (double)primeiro / segundo;
                    Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Divisão impossivel");
                }
                valores = Console.ReadLine().Split(' ');
                primeiro = int.Parse(valores[0]);
                segundo = int.Parse(valores[1]);
            }
        }
    }
}
