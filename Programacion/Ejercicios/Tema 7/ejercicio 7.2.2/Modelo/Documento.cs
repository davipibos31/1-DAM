using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_7._2._2.Modelo
{
    class Documento : Libro
    {
        protected int paginas;

        public Documento()
        {
            Console.WriteLine("Creando documneto");
        }
        public void SetPaginas(int paginas)
        {
            this.paginas = paginas;
        }
        public int GetPaginas()
        {
            return paginas;
        }
    }
}
