using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_6._3._3.Modulo
{
    class Libro
    {

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
