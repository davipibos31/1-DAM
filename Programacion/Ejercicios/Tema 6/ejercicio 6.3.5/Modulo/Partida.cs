using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_6._3._5.Modulo
{
    class Partida
    {
        public void lanzar()
        {
            Console.WriteLine("Esta sería la pantalla de juego. Pulse Intro para salir");
            Console.WriteLine(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Bienvenida p1 = new Bienvenida();
            Partida p2 = new Partida();

            p1.bienvenidas();
            p2.lanzar();
        }
    }
}
