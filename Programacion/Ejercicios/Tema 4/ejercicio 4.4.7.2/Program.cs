using System;

namespace ejercicio_4._4._7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca varios números separados por espacios: ");
            string numeros = Console.ReadLine();
            char[] delimitadores = { ' ' };
            string[] numero_separados = numeros.Split(delimitadores);
            int[] numero = new int[numero_separados.Length];
            int suma = 0;

            for (int i = 0; i < numero_separados.Length; i++)
            {
                Console.WriteLine($"Los números {i} son {numero_separados[i]}");
            }
            for (int i = 0; i < numero_separados.Length; i++)
            {
                numero[i] = Convert.ToInt32(numero_separados[i]);
            }
            for (int i = 0; i < numero_separados.Length; i++)
            {
                Console.WriteLine($"El numero es {numero[i]}");
            }
            for (int i = 0; i < numero_separados.Length; i++)
            {
                suma += numero[i];
            }
            Console.WriteLine($"La suma es {suma}");
        }
    }
}
