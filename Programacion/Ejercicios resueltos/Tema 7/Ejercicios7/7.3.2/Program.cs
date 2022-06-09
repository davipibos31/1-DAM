using System;

/*
 * Crea una variante del ejercicio 7.2.2 (array de Trabajador y derivadas), en la que se cree un único array "de trabajadores",
 * que contenga un objeto de cada clase, y exista un método "Saludar" que se redefina en todas las clases hijas, 
 * usando "new" y probándolo desde "Main"
 */

namespace _7._3._2
{
    class Trabajador
    {
        public  void Saludar()
        {
            Console.WriteLine("Hola! Soy un trabajador");
        }
    }
    class Informatico : Trabajador
    {
        public new void Saludar()
        {
            Console.WriteLine("Hola, yo soy informático");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // si creamos un informatico saluda con el metodo redefinido
            Informatico informatico = new Informatico();
            informatico.Saludar();

            //pero si se crea desde un array de trabajadores saluda con el método del padre
            Trabajador[] empleado = new Trabajador[5];

            for (int i=0; i<5; i++)
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
