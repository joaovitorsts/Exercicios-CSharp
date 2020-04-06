using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número inteiro");
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;
            Console.WriteLine($"A soma dos valores é igual a {soma}");
        }
    }
}
