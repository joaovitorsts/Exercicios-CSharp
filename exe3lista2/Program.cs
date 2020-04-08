using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor inteiro");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor inteiro");
            int n2 = int.Parse(Console.ReadLine());

            bool is_divisible = true;

            if (n1 > n2)
                is_divisible = n1 % n2 == 0;
            else
                is_divisible = n2 % n1 == 0;

            if (is_divisible)
                Console.WriteLine("São múltiplos");
            else
                Console.WriteLine("Não são múltiplos");

        }
    }
}
