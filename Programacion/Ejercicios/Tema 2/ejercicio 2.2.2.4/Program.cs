using System;

namespace ejercicio_2._2._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int identificador;
            int Contraseña;
            int num1;
            int num2;

            num1 = 1111;
            num2 = 1234;

            Console.WriteLine("Introduze un identificador: ");
            identificador = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (identificador < num2)
                {
                    Console.WriteLine("Identificador Incorrecto");
                    Console.WriteLine("Vuelve a introducir Identificador: ");
                    identificador = Convert.ToInt32(Console.ReadLine());
                }
                else if (identificador > num2)
                {
                    Console.WriteLine("Identificador Incorrecto");
                    Console.WriteLine("Vuelve a introducir Identificador: ");
                    identificador = Convert.ToInt32(Console.ReadLine());
                }
                else
                    Console.WriteLine("Identificador Correcto");
            }
            while (identificador != num2);
            Console.WriteLine("Introduze una contraseña: ");
            Contraseña = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (Contraseña == num1)
                    Console.WriteLine("Contraseña Correcto");
                else if (Contraseña < num1)
                {
                    Console.WriteLine("Contraseña Incorrecta");
                    Console.WriteLine("Vuelve a introducir Contraseña: ");
                    Contraseña = Convert.ToInt32(Console.ReadLine());
                }
                else if (Contraseña > num1)
                {
                    Console.WriteLine("Contraseña Incorrecta");
                    Console.WriteLine("Vuelve a introducir Contraseña: ");
                    Contraseña = Convert.ToInt32(Console.ReadLine());
                }
            } while (Contraseña != num1);
        }
    }
}
