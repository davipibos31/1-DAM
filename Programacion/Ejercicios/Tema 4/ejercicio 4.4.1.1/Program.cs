using System;

namespace ejercicio_4._4._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido_primero;
            string apellido_segundo;

            Console.WriteLine("Dime tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Dime tu primer apellido: ");
            apellido_primero = Console.ReadLine();
            Console.WriteLine("Dime tu segundo apellido: ");
            apellido_segundo = Console.ReadLine();

            if (nombre == "David" && apellido_primero == "Piñuel" && apellido_segundo == "Bosque")
                Console.WriteLine("Dices que eres David Piñuel Bosque?");
            else
                Console.WriteLine("Asi que no eres David Piñuel Bosque?");
        }
    }
}
