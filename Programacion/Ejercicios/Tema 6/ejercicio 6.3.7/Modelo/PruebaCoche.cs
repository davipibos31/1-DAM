using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_6._3._7.Modelo
{
    class PruebaCoche
    {
        static void Main(string[] args)
        {
            Coche p1 = new Coche();

            Console.Write("Marca del coche: ");
            p1.SetMarca(Console.ReadLine());
            Console.Write("Modelo del coche: ");
            p1.SetTexto(Console.ReadLine());
            Console.Write("Cilindrada del coche: ");
            p1.SetCilindrada(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Potencia del coche: ");
            p1.SetPotencia(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine();

            Console.WriteLine(p1.GetMarca());
            Console.WriteLine(p1.GetTexto());
            Console.WriteLine(p1.GetCilindrada());
            Console.WriteLine(p1.GetPotencia());
        }
    }
}
