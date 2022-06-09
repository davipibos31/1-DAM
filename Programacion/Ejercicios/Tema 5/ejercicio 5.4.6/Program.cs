using System;

namespace ejercicio_5._4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            MostrarPerimSuperfCuadrado(num);
        }
        static void MostrarPerimSuperfCuadrado(int num)
        {
            int perimetro = num + num + num + num;
            int superficie = num * num;

            Console.WriteLine($"La superficie de un cuadrado de {num}cm es {superficie}");
            Console.WriteLine($"El perimetro de un cuadrado de {num}cm es {perimetro}");
        }
    }
}
