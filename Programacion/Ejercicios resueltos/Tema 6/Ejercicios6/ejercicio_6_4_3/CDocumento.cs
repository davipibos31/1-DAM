using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6_4_3
{
    public class CDocumento
    {
        private int paginas;

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
