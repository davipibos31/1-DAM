using System;
using System.IO;

namespace ejercicio_8._10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el nombre del fichero");
            string nombre = Console.ReadLine();
            FileStream fichero = File.OpenRead(nombre);
            int count = 0;
            int dato;
            do
            {
                dato = fichero.ReadByte();
                if (dato != -1)
                {
                    char letra = Convert.ToChar((byte)dato);
                    if (letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' ||letra == 'U'
                        || letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                        count++;
                }
            }
            while (dato != -1);
            Console.WriteLine("Tiene {0} letras A", count);
            fichero.Close();

        }
    }
}
