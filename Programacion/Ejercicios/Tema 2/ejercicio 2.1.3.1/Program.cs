using System;

namespace ejercicio_2._1._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int producto;


            Console.WriteLine("Introduzca un número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            if (numero1 == 0)
            {
                Console.WriteLine("El producto de 0 por cualquier número es 0");
            }
            else {
                Console.WriteLine("Escribe un segundo número: ");
                numero2 = Convert.ToInt32(Console.ReadLine());
                producto = numero1 * numero2;
                Console.WriteLine("El producto de  {0} y {1} es igual a {2}", numero1, numero2, producto);
            }
            
        }
    }
}
