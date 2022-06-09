using System;

namespace ejercicio_2._2._1._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int contraseña;

            Console.WriteLine("Escribe una contraseña numérica: ");
            contraseña = Convert.ToInt32(Console.ReadLine());

            while (contraseña != 1111)
            {
                if (contraseña > 1111)
                {
                    Console.WriteLine("Contraseña erronea, vuelve a introducer la contraseña: ");
                    contraseña = Convert.ToInt32(Console.ReadLine());
                }
                else if (contraseña < 1111)
                {
                    Console.WriteLine("Contraseña erronea, vuelve a introducir la contraseña: ");
                    contraseña = Convert.ToInt32(Console.ReadLine());
                }
                else
                    Console.WriteLine("Contraseña aceptada");
            }
        }
    }
}
