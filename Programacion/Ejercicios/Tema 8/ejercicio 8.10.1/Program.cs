using System;
using System.IO;
namespace ejercicio_8._10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el nombre del fichero");
            string nombre = Console.ReadLine();
            char letra;
            Console.WriteLine("Introdizca una letra");
            letra = Convert.ToChar(Console.ReadLine());
            FileStream fichero;
              fichero =   File.OpenRead(nombre);
            int count = 0;
            int dato;
            do
            {
                dato = fichero.ReadByte();
                if (dato != -1)
                {
                     letra = Convert.ToChar((byte)dato);
                    if (letra == 'A')
                        count++;
                }
            }
            while (dato != -1);
            Console.WriteLine("Tiene {0} letras A", count);
            fichero.Close();
        }
    }
}
