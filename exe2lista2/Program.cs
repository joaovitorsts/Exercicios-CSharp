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
            if(n1 % 2 == 0)
                Console.WriteLine("PAR");
            else
                Console.WriteLine("ÍMPAR");
        }
    }
}
