using System;

namespace ejercicio_4._4._5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frase = new string[10];
            string texto = "";
            bool condicion = false;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Escribe una frase: ");
                frase[i] = Convert.ToString(Console.ReadLine());
            }
            do
            {
                string respuesta = "";
                Console.Write("Escribe un texto: ");
                texto = Convert.ToString(Console.ReadLine());
                for (int i = 0; i < 10; i++)
                {
                    if (texto.IndexOf(frase[i]) >= 0)
                    {
                        respuesta = "esta";
                        condicion = true;
                    }
                }
                if (texto != "fin" && condicion != false)
                {
                    Console.WriteLine($"La frase {respuesta}");
                    Console.WriteLine();
                }
                if (texto != "fin" && condicion == false)
                {
                    Console.WriteLine($"La frase no esta");
                    Console.WriteLine();
                }
                condicion = false;
            } while (texto != "fin");
        }
    }
}