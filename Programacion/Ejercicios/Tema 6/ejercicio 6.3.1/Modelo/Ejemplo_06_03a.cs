using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_6._3._1
{
    public class Ejemplo_06_03a
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
        }

    }
}
