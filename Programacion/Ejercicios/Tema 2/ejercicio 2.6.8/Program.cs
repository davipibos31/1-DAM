using System;

namespace ejercicio_2._6._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int precio, pagado;



            do

            {

                Console.Write("Precio?: ");

                precio = Convert.ToInt32(Console.ReadLine());



                if (precio <= 0)

                    goto fin;



                Console.Write("Pagado?: ");

                pagado = Convert.ToInt32(Console.ReadLine());



                while (precio > pagado) // pagado >= precio

                {

                    Console.Write("Todavia me falta {0}: ", precio - pagado);

                    pagado += Convert.ToInt32(Console.ReadLine());

                }



                Console.WriteLine();



                cambio:

                if (pagado == precio)

                {

                    Console.WriteLine("Todo pagado, gracias. \n");

                }

                else if (pagado - precio >= 100)

                {

                    pagado -= 100; Console.Write("100 "); goto cambio;

                }

                else if (pagado - precio >= 50)

                {

                    pagado -= 50; Console.Write("50 "); goto cambio;

                }

                else if (pagado - precio >= 20)

                {

                    pagado -= 20; Console.Write("20 "); goto cambio;

                }

                else if (pagado - precio >= 10)

                {

                    pagado -= 10; Console.Write("10 "); goto cambio;

                }

                else if (pagado - precio >= 5)

                {

                    pagado -= 5; Console.Write("5 "); goto cambio;

                }

                else if (pagado - precio >= 2)

                {

                    pagado -= 2; Console.Write("2 "); goto cambio;

                }

                else

                {

                    pagado -= 1; Console.Write("1");

                }

            } while (true);

            fin:

            Console.WriteLine("FIN PROGRAMA");
        }
    }
}
