using System;

namespace ejercicio_5._5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce una palabra: ");
            string palabra = Console.ReadLine();
            Console.Write("Introduce una letra: ");
            char letra = Convert.ToChar(Console.ReadLine());
            ContarLetra(palabra,letra);
        }
        static void ContarLetra(string palabra, char letra)
        {
            int cont = 0;
            
            foreach (char caracter in palabra)
            {
                if (caracter == letra)
                    cont++;
            }
            Console.WriteLine(cont);
        }
    }
}
