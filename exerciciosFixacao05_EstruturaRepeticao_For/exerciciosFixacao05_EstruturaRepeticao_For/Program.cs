﻿using System;

namespace exerciciosFixacao05_EstruturaRepeticao_For
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            for(int i=1; i<=numero; i++)
            {
                if(numero % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
