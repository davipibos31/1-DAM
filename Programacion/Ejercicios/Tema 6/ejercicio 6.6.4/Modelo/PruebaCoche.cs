using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_6._5._5.Modelo
{
    class PruebaCoche
    {
        static void Main(string[] args)
        {
            Moto p1 = new Moto();
            Coche p2 = new Coche();

            Console.Write("Marca de la moto: ");
            p1.SetMarca(Console.ReadLine());
            Console.Write("Modelo de la moto: ");
            p1.SetTexto(Console.ReadLine());
            Console.Write("Cilindrada de la moto: ");
            p1.SetCilindrada(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Potencia de la moto: ");
            p1.SetPotencia(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine();

            Console.WriteLine(p1.GetMarca());
            Console.WriteLine(p1.GetTexto());
            Console.WriteLine(p1.GetCilindrada());
            Console.WriteLine(p1.GetPotencia());

            Console.WriteLine();

            Console.Write("Marca del coche: ");
            p2.SetMarca(Console.ReadLine());
            Console.Write("Modelo del coche: ");
            p2.SetTexto(Console.ReadLine());
            Console.Write("Cilindrada del coche: ");
            p2.SetCilindrada(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Potencia del coche: ");
            p2.SetPotencia(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine();

            Console.WriteLine(p2.GetMarca());
            Console.WriteLine(p2.GetTexto());
            Console.WriteLine(p2.GetCilindrada());
            Console.WriteLine(p2.GetPotencia());

            Console.WriteLine();

            Console.WriteLine($"Cantidad de ruedas de la moto: {p1.GetCantidadDeRuedas()}");
            Console.WriteLine($"Cantidad de ruedas del coche: {p2.GetCantidadDeRuedas()}");
        }
    }
}
