using System;
using System.IO;

namespace ejercicio_8._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fichero = new StreamReader("prueba.txt");
            string linea;
            do
            {
                linea = fichero.ReadLine();
                if (linea != null)
                    Console.WriteLine(linea);
            }
            while (linea != null);
            fichero.Close();
        }
    }
}
