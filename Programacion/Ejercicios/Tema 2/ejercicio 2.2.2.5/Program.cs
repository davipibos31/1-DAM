using System;

namespace ejercicio_2._2._2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string Identificador;
            string Contraseña;
            string usu;
            string password;

            usu = "Pedro";
            password = "Peter";

            Console.WriteLine("Introduzca su Identificador: ");
            Identificador = Convert.ToString(Console.ReadLine());
            do
            {
                if (Identificador == usu)
                    Console.WriteLine("Identificador Correcto");
                else
                {
                    Console.WriteLine("Identificador Incorrecto");
                    Console.Write("Vuelva a introducir Identificador: ");
                    Identificador = Convert.ToString(Console.ReadLine());
                    }
            }
            while (Identificador != usu);
            Console.WriteLine("Introduzca su Contraseña: ");
            Contraseña = Convert.ToString(Console.ReadLine());
            do
            {
                if (Contraseña == password)
                    Console.WriteLine("Contraseña Correcta");
                else
                {
                    Console.WriteLine("Contraseña Incorrecara");
                    Console.Write("Vuelva a introducir Contraseña: ");
                    Contraseña = Convert.ToString(Console.ReadLine());
                }
            } while (Contraseña != password);
        }
    }
}
