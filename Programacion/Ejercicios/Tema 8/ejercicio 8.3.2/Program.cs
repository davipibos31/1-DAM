using System;
using System.IO;

namespace ejercicio_8._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader fichero = new StreamReader("prueba.txt"))
            {
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
}
