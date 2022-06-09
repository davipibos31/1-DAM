using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6_4_1
{
    public class CPuerta
    {
        private int ancho;
        public int alto;
        int color;
        bool abierta; 
        
        public void Abrir() 
        { 
            abierta = true; 
        } 
        
        public void Cerrar() 
        { 
            abierta = false; 
        }

        public int GetAncho()
        {
            return ancho;
        }

        public void SetAncho(int ancho) 
        {
            this.ancho = ancho; 
        }

        public void SetAlto(int alto)
        {
            this.alto = alto;
        }

        public string MostrarEstado() 
        { 
            return "Ancho: " + this.ancho + 
                            "\nAlto: " + this.alto +
                            "\nColor: " + this.color +
                            "\nAbierta: " + this.abierta; 
        }
    }
}
