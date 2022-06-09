using System;

/*
 * Crea una clase Casa, con una superficie (por ejemplo, 90 m2) y un método "MostrarEstado" que escriba su superficie. 
 * Cada casa debe contener 3 puertas. Las puertas tendrán un ancho, un alto y un método "MostrarEstado" 
 * que muestre su ancho y su alto y la superficie de la casa en la que se encuentran. 
 * Crea un programa de prueba que cree una casa y muestre sus datos y los de sus tres puertas.
 */

namespace _7._5._3
{
    public class Casa
    {
        public int superficie;

        Puerta puerta1 = new Puerta(80, 200);
        Puerta puerta2 = new Puerta(90, 180);
        Puerta puerta3 = new Puerta(100, 200);


        public Casa(int superficie = 90)
        {
            this.superficie = superficie;
        }
		
        public void MostrarEstado()
        {
            Console.WriteLine("Superficie: {0}", this.superficie);
            Console.WriteLine("Puerta 1:");
            puerta1.MostrarEstado();
            Console.WriteLine("Puerta 2:");
            puerta2.MostrarEstado();
            Console.WriteLine("Puerta 3:");
            puerta3.MostrarEstado();
        }
    }
    public class Puerta
    {
        public int ancho;
        public int alto;

        public Puerta(int ancho, int alto)
        {
            this.ancho = ancho;
            this.alto = alto;
        }

        public void MostrarEstado()
        {
            Console.WriteLine("Ancho: " + this.ancho);
            Console.WriteLine("Alto: " + this.alto);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Puerta(superficie, ancho, alto)
            Casa casa = new Casa();
            casa.MostrarEstado();
        }
    }
}