using System;

namespace ejercicio_4._4._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce un número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce una operación: ");
            string operacion = Convert.ToString(Console.ReadLine());
            int resultado = 0;

            switch (operacion)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    resultado = numero1 / numero2;
                    break;
                case "x":
                    resultado = numero1 * numero2;
                    break;
                case "X":
                    resultado = numero1 * numero2;
                    break;
                case "suma":
                    resultado = numero1 + numero2;
                    break;
                case "resta":
                    resultado = numero1 - numero2;
                    break;
                case "multiplicacion":
                    resultado = numero1 * numero2;
                    break;
                case "division":
                    resultado = numero1 / numero2;
                    break;
                default:
                    resultado = 0;
                    break;
            }
            Console.WriteLine($"El resultado es {resultado}");
        }
    }
}
