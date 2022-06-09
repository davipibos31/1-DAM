using System;

namespace ejercicio_4._1._3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[100];
            string nombre = "";
            int contador = 0;

            Console.Write("Introduce un nombre: ");
            nombre = Convert.ToString(Console.ReadLine());

            while ((nombre != "") && (contador < 100))
            {
                nombres[contador] = nombre;
                contador++;
                Console.Write("Introduce un nombre: ");
                nombre = Convert.ToString(Console.ReadLine());
            }
            for (int j = 0; j < contador; j++)
                Console.WriteLine(nombres[j]);
        }
    }
}
