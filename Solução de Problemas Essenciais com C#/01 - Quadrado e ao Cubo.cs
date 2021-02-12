using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                double q = Math.Pow(i, 2);
                double c = Math.Pow(i, 3);
                Console.WriteLine($" {i} {q} {c}");
            }
        }
    }
}
