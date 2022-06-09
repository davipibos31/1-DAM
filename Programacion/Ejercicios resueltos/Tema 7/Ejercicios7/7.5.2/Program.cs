using System;

/*
 * Crea una clase Puerta con un ancho, un alto y un método "MostrarEstado" que muestre su ancho y su alto. 
 * Crea una clase Casa, que contenga 3 puertas y otro método "MostrarEstado" que escriba "Casa" 
 * y luego muestre el estado de sus tres puertas.
 */

namespace _7._5._2
{
    class Casa
    {
        public Puerta puerta1 = new Puerta(90, 200);
        public Puerta puerta2 = new Puerta(80, 180);
        public Puerta puerta3 = new Puerta();

        public void MostrarEstado()
        {
            Console.WriteLine("CASA");

            Console.Write("\nPuerta 1 -> ");
            puerta1.MostrarEstado();

            Console.Write("\nPuerta 2 -> ");
            puerta2.MostrarEstado();

            Console.Write("\nPuerta 3 -> ");
            puerta3.MostrarEstado();
        }
    }
    class Puerta
    {
        public int ancho;
        public int alto;

        public Puerta() 
		{
            this.ancho = 80;
            this.alto = 180;		
		}
		
        public Puerta(int ancho, int alto)
        {
            this.ancho = ancho;
            this.alto = alto;
        }
		
        public void MostrarEstado()
        {
            Console.Write("Ancho: {0}, Alto: {1}", this.ancho, this.alto);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Casa casa = new Casa();
            casa.MostrarEstado();
        }
    }
}
