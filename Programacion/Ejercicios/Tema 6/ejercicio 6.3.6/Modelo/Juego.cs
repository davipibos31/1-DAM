using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_6._3._5.Modulo
{
    class Juego
    {
        public void lanzar()
        {
            Bienvenida b1 = new Bienvenida();
            b1.bienvenidas();
            presionartecla();
            Console.Clear();
        }
        public bool GetSalir(bool salir)
        {
            salir = true;
            return salir;
        }
        bool salir = false;
        public void presionartecla()
        {
            ConsoleKeyInfo tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.Escape)
            {
                salir = true;
            }
            else if (tecla.Key == ConsoleKey.Enter)
            {
                salir = true;
            }
            else
                salir = true;
        }
    }
}
