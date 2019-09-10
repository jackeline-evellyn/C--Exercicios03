using System;
using System.Globalization;

namespace exerciciosFixacao05_EstruturaRepeticao_For3
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd = int.Parse(Console.ReadLine());
            double valor1 =0.0, valor2=0.0, valor3=0.0, media=0.0;
            for(int i=1; i<=qtd; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                valor1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                valor2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
                valor3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

                media = ((valor1 * 2.0) + (valor2 * 3.0) + (valor3 * 5.0)) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
