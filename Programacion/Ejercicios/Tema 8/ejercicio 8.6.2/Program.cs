using System;
using System.IO;

namespace ejercicio_8._6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fichero;
            string nombre;
            bool salir = true;
            while (salir) // Interrumpimos desde dentro con "break"
            {
                Console.Write("Nombre del fichero (\"fin\" para terminar)? ");
                nombre = Console.ReadLine();
                if (nombre == "fin")
                    salir = false;
                else if (File.Exists(nombre))
                {
                    fichero = File.OpenText(nombre);
                    Console.WriteLine("Su primera linea es: {0}", fichero.ReadLine());
                    fichero.Close();
                }
                else
                {
                    Console.WriteLine("No existe!");
                    StreamWriter fichero2 = File.CreateText(nombre);
                    fichero2.Close();
                }
            }
        }
    }
}
