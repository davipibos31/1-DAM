using System;

namespace ejercicio_6._2._1
{
    
    public class persona
    {
        public string nombre;

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void Saludar()
        {
            Console.WriteLine($"Hola soy {nombre}");
        }
    }
    public class PruebaPersona
    {
        static void Main(string[] args)
        {
            persona p1 = new persona();
            persona p2 = new persona();
            Console.Write("Escribe tu nombre: ");
            p1.SetNombre(Console.ReadLine());
            p1.Saludar();
            Console.Write("Escribe un segundo nombre: ");
            p2.SetNombre(Console.ReadLine());
            p2.Saludar();
        }
    }
}
