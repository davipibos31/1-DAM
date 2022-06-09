using System;
using System.Collections.Generic;
using System.Linq;

namespace prueba_clase
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            numeros[0] = 1543;

            List<int> lista = new List<int>();
            lista.Add(11);
            lista.Add(numeros[0]);
            lista.IndexOf(11);
            lista.Remove(11);
            lista.Count();
            Console.WriteLine(lista.Count());
            lista.Clear();
        }
    }
}
