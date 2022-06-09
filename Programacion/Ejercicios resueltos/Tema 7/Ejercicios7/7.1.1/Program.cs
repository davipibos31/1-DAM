using System;

/*
 * Amplía el ejemplo 07_01a con un función "static" llamada "EscribirCentrado", 
 * que escriba centrado horizontalmente el texto que se le indique como parámetro.
 */

namespace _7._1._1
{
    public class Hardware
    {
        public static void BorrarPantalla()
        {
            for (byte i = 0; i < 25; i++)
                Console.WriteLine();
        }
        public static void EscribirCentrado(string txt)
        {
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (txt.Length / 2)) + "}", txt));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string txt;
            Console.WriteLine("Introduce texto para centrarlo");
            txt = Console.ReadLine();
            Hardware.EscribirCentrado(txt);
        }
    }
}
