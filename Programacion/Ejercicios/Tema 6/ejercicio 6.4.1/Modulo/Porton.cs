using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_6._4._1.Modulo
{
    using System;
    class Porton
    {
        bool bloqueada;
        int ancho;
        public void Bloquear()
        {
            bloqueada = true;
        }
        public void Desbloquear()
        {
            bloqueada = false;
        }
        public  void MostrarEstado()
        {
            Console.WriteLine("Portón.");
            Console.WriteLine("Bloqueada: {0}", bloqueada);
        }
        public void SetAncho(int ancho)
        {
            this.ancho = ancho;
        }
    }
}
