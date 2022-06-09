using System;

namespace ejercicio_4._4._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba una frase: ");
            string frase = Console.ReadLine();
            Console.Write("Escribe una letra: ");
            char letra = Convert.ToChar(Console.ReadLine());
            bool condicion = false;

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == letra)
                    condicion = true;
            }
            if (condicion == true)
                Console.WriteLine($"La letra {letra} se encuentra en la frase");
            else 
                Console.WriteLine($"La letra {letra} no se encuentra en la frase");
        }
    }
}
