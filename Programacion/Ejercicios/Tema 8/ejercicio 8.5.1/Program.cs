using System;
using System.IO;

namespace ejercicio_8._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int par1, par2, resultado;
                Console.WriteLine("Introduce dos numeros pares");
                Console.Write("Primer par: ");
                par1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Segundo par: ");
                par2 = Convert.ToInt32(Console.ReadLine());
                resultado = par1 + par2;
                string nombreFichero = @"d:\sumas.txt";

                try
                {
                    StreamWriter escritura = File.AppendText(nombreFichero);
                    escritura.WriteLine("Resultado: " + par1 + " + " + par2 + " = " + resultado);
                    escritura.Close();
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
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            
        }
    }
}
