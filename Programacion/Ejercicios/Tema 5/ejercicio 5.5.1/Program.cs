using System;

namespace ejercicio_5._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "El año es correcto";
            int minacep = 1800;
            int maxacep = 2100;
            PedirNumero(texto, minacep, maxacep);
        }
        static void PedirNumero(string texto, int minacep, int maxacep)
        {
            try
            {
                int año;
                bool correcto = true;
                do
                {
                    Console.WriteLine($"Introduce un año comprendido entre {minacep} y {maxacep}");
                    año = Convert.ToInt32(Console.ReadLine());
                    if (año >= minacep && año <= maxacep)
                        correcto = false;
                    else
                        Console.WriteLine("--> Número Incorrecto");
                } while (correcto != false);
                Console.WriteLine(texto);
            }
            catch (Exception)
            {
                Console.WriteLine("--> Número Incorrecto");
            }
        }
    }
}
