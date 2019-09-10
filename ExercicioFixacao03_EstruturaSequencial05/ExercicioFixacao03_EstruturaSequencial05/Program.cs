using System;
using System.Globalization;

namespace ExercicioFixacao03_EstruturaSequencial05
{
    class Program
    {
        static void Main(string[] args)
        {

            int cod1, cod2, qtd_pecas1, qtd_pecas2;
            double preco1, preco2, total;

            cod1 = int.Parse(Console.ReadLine());
            qtd_pecas1 = int.Parse(Console.ReadLine());
            preco1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            cod2 = int.Parse(Console.ReadLine());
            qtd_pecas2 = int.Parse(Console.ReadLine());
            preco2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = (preco1 * qtd_pecas1) + (preco2 * qtd_pecas2);
            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
