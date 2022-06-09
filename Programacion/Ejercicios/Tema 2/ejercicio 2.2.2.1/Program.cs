using System;

namespace ejercicio_2._2._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int numero1;
            int suma;
            int resultado;
            int total;

           
            do
            {
                Console.WriteLine("Introduze un número: ");
                numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduze un segundo número: ");
                numero1 = Convert.ToInt32(Console.ReadLine());
                suma = numero + numero1;
                resultado = suma + numero + numero1;
                total = resultado + suma;
                Console.WriteLine("La suma es {0}", suma);
                while (((suma != 0) && (numero > 0) && (numero1 > 0) && (numero > 0) && (numero1 > 0)))
                {   
                    Console.WriteLine("Introduze un número: ");
                    numero = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduze un segundo número: ");
                    numero1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("La suma total es {0}", resultado);
                    while ((resultado == (suma + numero + numero1) && (numero > 0) && (numero1 > 0)))
                    {
                        Console.WriteLine("Introduze un número: ");
                        numero = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introduze un segundo número: ");
                        numero1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma total es {0}", suma + resultado);
                    }
                }
            }
            while ((numero > 0) || (numero1 > 0));
           
        }
    }
}
