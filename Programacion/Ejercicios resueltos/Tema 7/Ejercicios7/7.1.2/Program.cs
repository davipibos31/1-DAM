using System;

/*
 * Amplía el ejemplo 07_01b con un función llamada "EscribirCentrado", que escriba centrado horizontalmente
 * el texto que se le indique como parámetro. Al contrario que en el ejercicio 7.1.1, esta versión no será "static".
 */

namespace _7._1._2
{
    public class Hardware
    {
        public void BorrarPantalla()
        {
            for (byte i = 0; i < 25; i++)
                Console.WriteLine();
        }
        public void EscribirCentrado(string txt)
        {
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (txt.Length / 2)) + "}", txt));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string txt;
            Console.WriteLine("Escribe texto a centrar:");
            txt = Console.ReadLine();

            Hardware centrar = new Hardware();
            centrar.EscribirCentrado(txt);
        }
    }
}
