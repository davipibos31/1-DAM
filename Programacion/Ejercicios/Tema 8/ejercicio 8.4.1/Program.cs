using System;
using System.IO;

namespace ejercicio_8._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter fichero;
            string frase;

            fichero = File.AppendText("log.txt");
            do
            {
                Console.Write("Escribe una frase: ");
                frase = Console.ReadLine();
                if (frase != "")
                    fichero.WriteLine(frase);
            } while (frase != "");

            fichero.Close();
        }
    }
}
