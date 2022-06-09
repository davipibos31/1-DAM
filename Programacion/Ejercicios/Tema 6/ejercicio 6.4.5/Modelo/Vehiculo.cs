using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_6._4._5.Modelo
{
    class Vehiculo
    {
        string marca;
        string texto;
        int cilindrada;
        double potencia;

        public void SetMarca(string marca)
        {
            this.marca = marca;
        }
        public void SetTexto(string texto)
        {
            this.texto = texto;
        }
        public void SetCilindrada(int cilindrada)
        {
            this.cilindrada = cilindrada;
        }
        public void SetPotencia(double potencia)
        {
            this.potencia = potencia;
        }
        public string GetMarca()
        {
            return marca;
        }
        public string GetTexto()
        {
            return texto;
        }
        public int GetCilindrada()
        {
            return cilindrada;
        }
        public double GetPotencia()
        {
            return potencia;
        }
    }
}
