using System;
using System.IO;

namespace ejercicio_8._10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un nombre para el fichero");
            string nombre = Console.ReadLine();
            Console.WriteLine("Introduce una palabra para buscar");
            string palabra = Console.ReadLine();
            
            FileStream fichero = File.OpenRead(nombre);

            int count = 0;
            int dato;
            do {
                dato = fichero.ReadByte();
                if (dato != -1)
                {
                     string palabraBuscar = Convert.ToString((byte) dato);
                    if (palabraBuscar == palabra)
                        count++;
                }
            } while (dato != -1);
            Console.WriteLine($"Tiene {count} palabras {palabra}");
            fichero.Close();
        }
    }
}
