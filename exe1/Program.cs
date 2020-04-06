using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Você digitou {n1}");
            Console.WriteLine($"Você digitou {ch}");
            Console.WriteLine($"Você digitou {n2.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Segunda Parte");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Digite seu nome completo");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite quantos quartos há na sua casa");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço de um produto");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu último nome, idade, altura");
            string[] dados = Console.ReadLine().Split(' ');
            string ultimo_nome = dados[0];
            int idade = int.Parse(dados[1]);
            float altura = float.Parse(dados[2]);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(ultimo_nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}
