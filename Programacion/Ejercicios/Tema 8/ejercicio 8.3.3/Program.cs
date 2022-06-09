using System;
using System.IO;

namespace ejercicio_8._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un nombre para el fichero .txt");
            string nombre = Console.ReadLine();
            
            
            StreamWriter fichero;
            fichero = File.CreateText(nombre);

            for (int i = 0; i <= 60; i++)
            {
                fichero.WriteLine($"parrafo {i}");
            }
            fichero.Close();


            StreamReader fichero2;
            fichero2 = File.OpenText(nombre);
            string linea;
            do
            {
                
                linea = fichero2.ReadLine();
                if (linea != null)
                {
                    if (linea == "parrafo 24" || linea == "parrafo 48")
                    {
                        Console.ReadKey();
                    }
                    Console.WriteLine(linea);
                }
            } while (linea != null);
            fichero2.Close();
        }
    }
}