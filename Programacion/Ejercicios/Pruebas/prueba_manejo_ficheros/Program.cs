using System;
using System.IO;

namespace Files
{
    class Program
    {
        public const string RUTA = "C:\\Users\\david\\source\\repos\\prueba_manejo_ficheros\\file\\";

        static void Main(string[] args)
        {
            /*
            StreamWriter fichero = new StreamWriter("prueba.txt");
            
            fichero.WriteLine("Primera Linea");
            fichero.Write("Hola ");
            fichero.Write("Adios");

            fichero.Close();
            */

            //StreamReader fichero = File.OpenText("prueba.txt");

            string nombreFichero = RUTA + "prueba2.txt";

            StreamWriter ficheroCrear = new StreamWriter(nombreFichero);
            ficheroCrear.WriteLine("ASDDSASD");
            ficheroCrear.Close();

            if (File.Exists(nombreFichero))
            {
                Mostrar(nombreFichero);

                StreamWriter ficheroWriter = File.AppendText(nombreFichero);
                ficheroWriter.WriteLine("Otra linea más");
                ficheroWriter.Close();

                Console.WriteLine();

                Mostrar(nombreFichero);
            }
            else
            {
                Console.WriteLine("Ese fichero no existe.");
            }
        }

        public static void Mostrar(string nombreFichero)
        {
            StreamReader ficheroReader = new StreamReader(nombreFichero);
            string linea;

            do
            {
                linea = ficheroReader.ReadLine();
                if (linea != null)
                    Console.WriteLine(linea);
            } while (linea != null);

            ficheroReader.Close();
        }
    }    
}
