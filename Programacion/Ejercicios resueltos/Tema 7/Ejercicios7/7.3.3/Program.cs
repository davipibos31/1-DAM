using System;

namespace _7._3._3
{
    class Trabajador
    {
        public virtual void Saludar()
        {
            Console.WriteLine("Hola! Soy un trabajador");
        }
    }
    class Informatico : Trabajador
    {
        public override void Saludar()
        {
            Console.WriteLine("Hola, yo soy informático");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // usando override cada empleado saluda como le corresponde
            Trabajador[] empleado = new Trabajador[5];

            for (int i = 0; i < 5; i++)
            {
                if (i % 2 == 0)
                {
                    empleado[i] = new Trabajador();
                    empleado[i].Saludar();
                }

                else
                {
                    empleado[i] = new Informatico();
                    empleado[i].Saludar();
                }
            }
        }
    }
}
