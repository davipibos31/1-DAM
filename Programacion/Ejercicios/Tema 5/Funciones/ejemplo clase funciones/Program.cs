using System;

namespace ejemplo_clase_funciones
{
    class Program
    {
        public int numero;
        static void Main(string[] args)
        {
            int numero1 = PedirNumero();
            int numero2 = PedirNumero();
            Console.WriteLine(numero1);
            int sumar = Sumar(ref numero1, ref numero2);
            Console.WriteLine(numero1);
            Console.WriteLine(sumar);
        }
        static int PedirNumero()
        {
            Console.WriteLine("Dame un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            return numero;
        }
        static int Sumar(ref int x, ref int y)
        {
            x = 10;
            return x + y;
        }
    }
}
