using System;

class Desafio {
    static void Main(string[] args)
    {
      double [] notas = new double [2];
      double soma = 0;
      double nota = 0;
    for (int i = 0; i < notas.Length; i++)
    {
        nota = double.Parse(Console.ReadLine());
        if ((nota < 0) || (nota > 10))
        {
            Console.WriteLine("nota invalida");
            i--;
        }
        else
        {
            notas[i] = nota;
        }
    }

    for (int i = 0; i < notas.Length; i++)
    {
        soma = soma + notas[i];
    }
    double media = soma / 2;
    Console.WriteLine("media = " + media.ToString("F2"));

  }
}
