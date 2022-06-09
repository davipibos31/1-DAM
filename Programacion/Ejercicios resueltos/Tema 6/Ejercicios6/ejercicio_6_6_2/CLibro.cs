using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6_6_2
{
    public class CLibro 
    {
        string autor;
        string titulo;
        string ubicacion;

        public CLibro(string autor, string titulo, string ubicacion)
        {
            this.autor = autor;
            this.titulo = titulo;
            this.ubicacion = ubicacion;
        }

        public void SetAutor(string autor)
        {
            this.autor = autor;
        }

        public string GetAutor()
        {
            return this.autor;
        }

        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public string GetTitulo()
        {
            return this.titulo;
        }

        public void SetUbicacion(string ubicacion)
        {
            this.ubicacion = ubicacion;
        }

        public string GetUbicacion()
        {
            return this.ubicacion;
        }
    }

}
