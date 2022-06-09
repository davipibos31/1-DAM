using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_6._5._3.Modelo
{
    class PruebaLibro
    {
        static void Main(string[] args)
        {
            Libro p1 = new Libro();
           
            p1.SetAutor("David");
            p1.SetTitulo("Programación en c#");
            p1.SetUbicacion("Elche");
           
            Console.WriteLine("Nombre del autor: {0}", p1.GetAutor());
            Console.WriteLine("Titulo: {0}", p1.GetTitulo());
            Console.WriteLine("Ubicacion: {0}", p1.GetUbicacion());
            Console.WriteLine();
           
            
            Libro p3 = new Libro();
            
            
            Console.WriteLine("Nombre del autor: {0}", p3.GetAutor());
            Console.WriteLine("Titulo: {0}", p3.GetTitulo());
            Console.WriteLine("Ubicacion: {0}", p3.GetUbicacion());
            Console.WriteLine();

            Libro p4 = new Libro("Lorena", "Medicina");
            
            Console.WriteLine("Nombre del autor: {0}", p4.GetAutor());
            Console.WriteLine("Titulo: {0}", p4.GetTitulo());
            Console.WriteLine("Ubicacion: {0}", p4.GetUbicacion());
            Console.WriteLine();


            Documento p2 = new Documento();
            
            p2.SetAutor("Lorena");
            p2.SetTitulo("Enfermería");
            p2.SetUbicacion("Alicante");
            p2.SetPaginas(9);

            Console.WriteLine("Nombre del autor: {0}", p2.GetAutor());
            Console.WriteLine("Titulo: {0}", p2.GetTitulo());
            Console.WriteLine("Ubicacion: {0}", p2.GetUbicacion());
            Console.WriteLine("Paginas: {0}", p2.GetPaginas());
            Console.WriteLine();
        }
    }
}
