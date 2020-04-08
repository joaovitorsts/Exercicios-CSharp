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
            if(n1 < 0)
                Console.WriteLine("NEGATIVO");
            else
                Console.WriteLine("NÃO NEGATIVO");
        }
    }
}
