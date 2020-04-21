using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade números para verificar");
            int qtdValores = int.Parse(Console.ReadLine());
            int dentro = 0;
            int fora = 0;
           
            for(int i = 0; i <= qtdValores; i++)
            {
                Console.WriteLine("Digite um valor a ser verificado");
                int valor = int.Parse(Console.ReadLine());
                if (valor > 9 & valor < 21) 
                {
                    dentro += 1;
                }
                else
                {
                    fora += 1;
                }
            }

            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");
        }
    }
}
