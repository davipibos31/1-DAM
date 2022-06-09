using System;

namespace ejercicio_2._1._8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int positivo;

            Console.WriteLine("Introduzca un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            positivo = numero >= 0 ? numero : - numero;
            Console.WriteLine("El número introducido es {0}", positivo);
        }
    }
}
