using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o código da peça");
            int codigo_peca1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de peças");
            int qtd_peca1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor unitário");
            double preco_unitario1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double total1 = preco_unitario1 * qtd_peca1; 

            Console.WriteLine("-------- SEGUNDA PEÇA --------");

            Console.WriteLine("Digite o código da peça");
            int codigo_peca2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de peças");
            int qtd_peca2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor unitário");
            double preco_unitario2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double total2 = preco_unitario2 * qtd_peca2;

            double total = total1 + total2;

            Console.WriteLine($"VALOR A PAGAR: {total.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
