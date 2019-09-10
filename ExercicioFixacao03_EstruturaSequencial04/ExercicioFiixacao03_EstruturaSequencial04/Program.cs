using System;
using System.Globalization;

namespace ExercicioFiixacao03_EstruturaSequencial04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, horas_trabalhadas;
            double sal_hora, salario;

            numero = int.Parse(Console.ReadLine());
            horas_trabalhadas = int.Parse(Console.ReadLine());
            sal_hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horas_trabalhadas * sal_hora;

            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
