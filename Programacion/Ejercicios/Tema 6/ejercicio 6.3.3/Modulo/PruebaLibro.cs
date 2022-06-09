using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_6._3._3.Modulo
{
    class PruebaLibro
    {
        static void Main(string[] args)
        {
            Libro p1 = new Libro();
            p1.SetAutor("David");
            p1.SetTitulo("Programación");
            p1.SetUbicacion("Alicante");

            Console.WriteLine("Nombre del autor: {0}", p1.GetAutor());
            Console.WriteLine("Titulo: {0}", p1.GetTitulo());
            Console.WriteLine("Ubicacion: {0}", p1.GetUbicacion());
        }
    }
}
