using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_6._5._3.Modelo
{
    class Documento : Libro
    {
        protected int paginas;

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
