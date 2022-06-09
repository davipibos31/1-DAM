using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace ejercicio_6_8_2
{
    class Documento
    {
        private int paginas;

        public Documento()
        {
            Trace.WriteLine("Creando documento");
        }

        public void SetPaginas(int paginas)
        {
            this.paginas = paginas;
        }

        public int GetPaginas()
        {
            return this.paginas;
        }
    }
}
