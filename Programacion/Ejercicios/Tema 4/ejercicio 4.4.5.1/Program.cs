using System;

namespace ejercicio_4._4._5._1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] frase = new string[10];
            string texto = "";
            bool condicion = false;
            bool contain = true;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Escribe una frase {i + 1}: ");
                frase[i] = Convert.ToString(Console.ReadLine());
            }
            do
            {
                string respuesta = "";
                Console.Write("Escribe un texto: ");
                texto = Convert.ToString(Console.ReadLine());
                for (int i = 0; i < 10; i++)
                {
                    if (texto.Contains(frase[i]) == contain)
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
