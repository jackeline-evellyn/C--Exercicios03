﻿using System;

namespace exerciciosFixacao05_EstruturaRepeticao_For1
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());
            for(int i =1; i<=valor; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
