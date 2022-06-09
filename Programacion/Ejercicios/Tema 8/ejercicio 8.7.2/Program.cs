using System;

namespace ejercicio_8._7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            char operacion = '0';
            int resultado = 0;
            Console.Write("Introduzca un número: ");

            try
            {
                numero1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Introduzca un nuevo número");
                numero1 = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Introduzca una operación +, -, *, /: ");
            
            try
            {
                operacion = Convert.ToChar(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Introduzca un nuevo número");
                operacion = Convert.ToChar(Console.ReadLine());
            }
            
            Console.Write("Introduzca un número: ");
            
            try
            {
                numero2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Introduzca un nuevo número");
                numero2 = Convert.ToInt32(Console.ReadLine());
            }

            switch (operacion)
            {
                case '+':
                    resultado = numero1 + numero2;
                    break;
                case '-':
                    resultado = numero1 - numero2;
                    break;
                case '*':
                    resultado = numero1 * numero2;
                    break;
                case '/':
                    resultado = numero1 / numero2;
                    break;
            }
            Console.WriteLine("El resultado es : " + resultado);
        }
    }
}
