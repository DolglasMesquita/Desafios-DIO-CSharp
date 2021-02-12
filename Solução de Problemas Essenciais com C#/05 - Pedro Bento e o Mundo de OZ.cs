using System;
using System.Collections.Generic;
using System.Linq;

class Program {

  static void Main(string[] args) {
    var joias = new List<string>();
    while(true)
    {
      string joia = Console.ReadLine();
      if (!string.IsNullOrWhiteSpace(joia))
        joias.Add(joia);
      else
        break;
    }

    var ocorrencias = joias.Distinct().ToList();
    Console.WriteLine(ocorrencias.Count);
  }

}
