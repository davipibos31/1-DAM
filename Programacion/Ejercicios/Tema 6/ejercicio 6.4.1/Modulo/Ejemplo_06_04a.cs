using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_6._4._1.Modulo
{
    class Ejemplo_06_04a
    {
        public static void Main()
        {
            Puerta p = new Puerta();
            Console.WriteLine("Valores iniciales...");
            p.MostrarEstado();
            Console.WriteLine();
            Console.WriteLine("Vamos a abrir...");
            p.Abrir();
            p.SetAncho(80);
            p.MostrarEstado();
            Console.WriteLine();
            Console.WriteLine("Ahora el portón...");
            Porton p2 = new Porton();
            p2.SetAncho(300);
            p2.Bloquear();
            p2.MostrarEstado();
        }
    }
}
