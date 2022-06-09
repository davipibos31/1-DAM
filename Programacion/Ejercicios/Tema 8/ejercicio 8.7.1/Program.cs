using System;
using System.IO;

namespace ejercicio_8._7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreFichero = "";
            string nombreFichero2 = "";
            try
            {
                Console.Write("Introduzca un nombre para el fichero de origen: ");
                nombreFichero = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            try
            {
                StreamWriter origen = File.CreateText(nombreFichero);

                Console.WriteLine("Escribe una frase: ");
                origen.WriteLine(Console.ReadLine());
                Console.WriteLine("Escribe otra frase: ");
                origen.WriteLine(Console.ReadLine());

                origen.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error no existe");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Error de ruta larga");
            }
            catch (IOException)
            {
                Console.WriteLine("Error de escritura");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            try
            {
                Console.Write("Introduzca un nombre para el fichero de destino: ");
                nombreFichero2 = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            try
            {
                StreamWriter destino = File.CreateText(nombreFichero2);



                StreamReader destinonuevo = new StreamReader(nombreFichero);
                string linea;
                do
                {
                    linea = destinonuevo.ReadLine();
                    if (linea != null)
                    {
                        destino.WriteLine(linea.ToUpper());
                    }
                } while (linea != null);
                destino.Close();
                destinonuevo.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error no existe");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Error de ruta larga");
            }
            catch (IOException)
            {
                Console.WriteLine("Error de escritura");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
