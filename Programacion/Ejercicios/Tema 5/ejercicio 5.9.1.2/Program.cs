using System;

namespace ejercicio_5._9._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dado();
        }
        static void Dado()
        {
            
            int cont = 1;
            bool correcto = true;
            Random numero = new Random();
            int aleatorio = numero.Next(1, 100);
            Console.WriteLine(aleatorio);
            Console.Write("Introduze un número: ");
            int aceptado = Convert.ToInt32(Console.ReadLine());
            do {
                if (aleatorio == aceptado)
                    correcto = false;
                else if (aleatorio != aceptado)
                {
                    Console.Write("Introduze un número: ");
                    aceptado = Convert.ToInt32(Console.ReadLine());
                    correcto = true;
                    cont++;
                }
            } while (correcto != false && cont < 6);
        }
    }
}
