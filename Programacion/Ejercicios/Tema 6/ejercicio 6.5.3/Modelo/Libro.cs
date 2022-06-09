using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_6._5._3.Modelo
{
    class Libro
    {
        protected string autor, titulo, ubicacion;

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
