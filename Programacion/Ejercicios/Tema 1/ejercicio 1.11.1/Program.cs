using System;

namespace ejercicio_1._11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos las variables

            int numero1;
            int numero2;
            int producto;
            int suma;
            int resta;

            //damos valor a las variables

            Console.WriteLine("Introduce el primer número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            
            //operaciones

            producto = numero1 * numero2;
            suma = numero1 + numero2;
            resta = numero1 - numero2;

            //realizamos la operación
            
            Console.WriteLine("La operación (a+b)*(a-b) es la siguiente: ");
            Console.WriteLine("Tenemos ({0}+{1})*({0}-{1})", numero1, numero2);
            Console.WriteLine("El resultado es el siguiente: ");
            Console.WriteLine((numero1+numero2)*(numero1-numero2));

            //realizamos la siguiente operación

            Console.WriteLine("la operación a^2-b^2 es la siguiente: ");
            Console.WriteLine("Tenemos {0}^{0}-{1}^{1}", numero1, numero2);
            Console.WriteLine("El resultado es el siguiente: ");
            Console.WriteLine(((numero1*numero1)-(numero2*numero2)));
        }
    }
}
