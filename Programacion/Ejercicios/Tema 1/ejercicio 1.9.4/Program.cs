using System;

namespace ejercicio_1._9._4
{
    class Program
    {
        static void Main(string[] args)
        {

            //creamos las variables

            int millas;
            int metros;

            //damos valor a las variables

            millas = Convert.ToInt32(Console.ReadLine());
            metros = millas * 1852;

            //realizamos la operación

            Console.WriteLine("La conversión de {0} millas a metros es {1}", millas, metros);
        }
    }
}
