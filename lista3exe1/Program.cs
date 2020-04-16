using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a senha");
            string senha = Console.ReadLine();
            while (senha != "2002")
            {
                Console.WriteLine("Senha Inválida");
                senha = Console.ReadLine();
            }

            Console.WriteLine("Acesso Permitido");

        }

    }
}
