using System;

namespace exerciciosFixacao05_EstruturaRepeticao_While03
{
    class Program
    {
        static void Main(string[] args)
        {
            int produto = int.Parse(Console.ReadLine());
            int alcool = 0, gasolina = 0, diesel = 0;
            while(produto != 4)
            {
                if(produto == 1)
                {
                    alcool += 1;
                }
                else if(produto == 2)
                {
                    gasolina += 1;
                }
                else if(produto == 3)
                {
                    diesel += 1;
                }
                
                produto = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADA!");
            Console.WriteLine("Alcool: "+alcool );
            Console.WriteLine("Gasolina: "+gasolina);
            Console.WriteLine("Diesel: "+diesel);
        }
    }
}
