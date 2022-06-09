using System;

namespace ejercicio_4._1._3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombre = new string[10];
            string segundo_nombre;
            bool encontrar = false;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Introduce el nombre {i+1}: ");
                nombre[i] = Console.ReadLine();
            }
            do
            {
                string respuesta = "";
                Console.Write("Introduce el nombre que buscas: ");
                segundo_nombre = Convert.ToString(Console.ReadLine());
                for (int i = 0; i < 10; i++)
                {
                    if (segundo_nombre == nombre[i])
                    {
                        respuesta = "esta";
                        encontrar = true;
                    }
                }
                if (segundo_nombre != "fin" && encontrar != false)
                {
                    Console.WriteLine($"El nombre {segundo_nombre} {respuesta}");
                }
                    if (segundo_nombre != "fin" && encontrar == false)
                    Console.WriteLine($"El nombre {segundo_nombre} no esta");
                encontrar = false;
            } while (segundo_nombre != "fin");
               
            
        }
    }
}
