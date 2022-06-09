using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6_4_1
{
    class CPorton : CPuerta
    {
        bool bloquear;

        public void Bloquear()
        {
            this.bloquear = true;
        }

        public void Desbloquear()
        {
            this.bloquear = false;
        }

        public bool GetBloquear()
        {
            return this.bloquear;
        }

        public new string MostrarEstado()
        {
            String estado = base.MostrarEstado();

            return estado + "\nBloquado : " + (this.bloquear ? "sí" : "no");
        }
    }
}
