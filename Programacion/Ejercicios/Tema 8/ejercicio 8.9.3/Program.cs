using System;
using System.IO;

namespace ejercicio_8._9._3
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fichero;
            string nombre;
            byte unDato;

            Console.WriteLine("Introduzca el nombre del archivo");
            nombre = Console.ReadLine() + ".gif";
            fichero = File.Create(nombre);
            fichero.Close();

            try
            {
                fichero = File.OpenRead(nombre);
                unDato = (byte)fichero.ReadByte();
                Console.WriteLine($"El byte leido es un {unDato}");
                fichero.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return;
            }
        }
    }
}
