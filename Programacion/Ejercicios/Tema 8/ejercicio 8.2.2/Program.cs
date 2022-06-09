using System;
using System.IO;

namespace ejercicio_8._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter fichero = new StreamWriter("registroDeUsuario.txt");
            string final = "fin";
            string palabra;
            bool salir = false;

            do
            {
                Console.Write("Escribe una palabra: ");

                palabra = Console.ReadLine();
                if (palabra != "fin")
                    fichero.WriteLine(palabra);
                else
                    salir = true;

            } while (palabra != final && salir != true);

            fichero.Close();

            StreamReader fichero2 = new StreamReader("registroDeUsuario.txt");
            string linea;

            do
            {
                linea = fichero2.ReadLine();
                if (linea != null)
                    Console.WriteLine(linea);
            } while (linea != null);

            fichero2.Close();
        }
    }
}
