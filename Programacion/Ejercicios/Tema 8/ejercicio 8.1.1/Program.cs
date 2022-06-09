using System;
using System.IO;

namespace ejercicio_8._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter fichero;
            fichero = File.CreateText("registroDeUsuario.txt");
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

            } while (palabra != final && salir != true) ;
            fichero.Close();
        }
    }
}
