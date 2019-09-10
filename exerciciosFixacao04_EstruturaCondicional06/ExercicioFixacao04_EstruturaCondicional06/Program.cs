using System;
using System.Globalization;

namespace ExercicioFixacao04_EstruturaCondicional06
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(valor>100 || valor < 0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (valor < 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if(valor < 50)
            {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if (valor < 75)
            {
                Console.WriteLine("Intervalo [50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo [75,100]");
            }

        }
    }
}
