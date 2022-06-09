using System;

namespace ejercicio_1._8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos las variables

            int millas;
            int resultado;

            //damos un valor a las variables

            
            millas = 3000;
            resultado = millas / 1609;

            //realizamos el resultado de la conversion
            Console.WriteLine("El número usado es {0}", millas);
            Console.WriteLine("La conversión es: {0}", resultado);

            //el usuario escribira su número

            Console.WriteLine("Escriba su número: ");
            millas = Convert.ToInt32(Console.ReadLine());
            resultado = millas / 1609;

            Console.WriteLine("La conversión es: {0}", resultado);
        }
    }
}
