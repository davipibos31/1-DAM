using System;

namespace ejercicio_6._2._2
{

    public class juego
    {
        public void lanzar()
        {
            Console.WriteLine("Bienvenido a Console Invaders. Pulse intro para salir-->");
            Console.WriteLine(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            juego p1 = new juego();
            p1.lanzar();
        }
    }
}
