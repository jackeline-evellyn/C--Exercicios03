using System;
using System.Globalization;

namespace exerciciosFixacao04_EstruturaCondicional05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int qtd = int.Parse(valores[1]);
            double total =0.00;
            
            if(codigo == 1)
            {
                total = 4.00 * qtd;
            }
            else if(codigo ==2){
                total = 4.50 * qtd;
            }
            else if(codigo == 3)
            {
                total = 5.00 * qtd;
            } else if(codigo ==4) {
                total = 2.00 * qtd;
            }
            else
            {
                total = 1.50 * qtd;
            }
            Console.WriteLine("Total: R$ "+total.ToString("F2", CultureInfo.InvariantCulture ));
           


       }
    }
}
