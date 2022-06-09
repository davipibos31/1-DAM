using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_6._5._5.Modelo
{
    class Vehiculo
    {
        protected string marca;
        protected string texto;
        protected int cilindrada;
        protected double potencia;
        protected int CantidadDeRuedas;
        protected int velocidad;
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
        public void SetCantidadDeRuedas(int CantidadDeRuedas)
        {
            this.CantidadDeRuedas = CantidadDeRuedas;
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
        public int GetCantidadDeRuedas()
        {
            return CantidadDeRuedas;
        }
        public int Circular()
        {
            velocidad = 50;
            return velocidad;
        }
        public int Circular(int v)
        {
            return v;
        }
    }
}
