using System;

namespace ejercicio_4._4._9._1
{
    using System;
    using System.Text; // Usaremos un System.Text.StringBuilder
    public class Ejemplo_04_04_09a
    {
        public static void Main()
        {
            StringBuilder cadenaModificable = new StringBuilder("Hola");
            cadenaModificable[1] = 'o';
            cadenaModificable[3] = 'o';
            Console.WriteLine("Cadena modificada: {0}", cadenaModificable);
            string cadenaNormal;
            cadenaNormal = cadenaModificable.ToString();
            Console.WriteLine("Cadena normal a partir de ella: {0}", cadenaNormal);
        }
    }
}
