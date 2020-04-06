using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            Console.WriteLine("Digite o valor do raio da circunferência");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = pi * Math.Pow(2, raio);
            Console.WriteLine($"A área é igual a {area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}
