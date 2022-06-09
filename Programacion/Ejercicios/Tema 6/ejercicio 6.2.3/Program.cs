using System;

namespace ejercicio_6._2._3
{

    public class libro
    {
        static void Main(string[] args)
        {
            libro p1 = new libro();
            p1.SetAutor("David");
            p1.SetTitulo("Programación");
            p1.SetUbicacion("Alicante");

            Console.WriteLine("Nombre del autor: {0}",p1.GetAutor());
            Console.WriteLine("Titulo: {0}",p1.GetTitulo());
            Console.WriteLine("Ubicacion: {0}",p1.GetUbicacion());
        }

        string autor, titulo, ubicacion;

        public string GetAutor()
        {
            return autor;
        }

        public string GetTitulo()
        {
            return titulo;
        }

        public string GetUbicacion()
        {
            return ubicacion;
        }

        public void SetAutor(string autor)
        {
            this.autor = autor;
        }

        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public void SetUbicacion(string ubicacion)
        {
            this.ubicacion = ubicacion;
        }


    }
}
