using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_7._2._2.Modelo
{
    class Libro
    {
        protected string autor, titulo, ubicacion;

        public Libro()
        {
            autor = "David";
            titulo = "Programación";
            ubicacion = "Alicante";
            Console.WriteLine("Creando libro");
        }
        
        public Libro(string autor2, string titulo2) : this() 
        {
            this.autor = autor2;
            this.titulo = titulo2;
            ubicacion = "No detallada";
        }
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
