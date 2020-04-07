using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero_funcionario = int.Parse(Console.ReadLine());
            int horas_trabalhadas = int.Parse(Console.ReadLine());
            float valor_hora = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            float salario = valor_hora * horas_trabalhadas;
            Console.WriteLine($"NUMBER = {numero_funcionario}");
            Console.WriteLine($"SALARY = {salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
