using System;

    class Program
    {
        static void Main(string[] args)
        {
            int R = Convert.ToInt32(Console.ReadLine());
            int V = Convert.ToInt32(Console.ReadLine());

            while (R >= V)
            {
                V = Convert.ToInt32(Console.ReadLine());
            }

            int soma = R;
            int contInt = 1;

            while (V >= soma)
            {
                R += 1;
                soma += R;
                contInt++;
            }

            Console.WriteLine(contInt);
        }
    }
