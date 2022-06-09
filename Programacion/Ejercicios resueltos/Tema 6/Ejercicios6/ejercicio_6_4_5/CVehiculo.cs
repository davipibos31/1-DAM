using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6_4_5
{
    public class CVehiculo
    {
        string marca;
        string modelo;
        int cilindrada;
        double potencia;

        public void SetMarca(string marca)
        {
            this.marca = marca;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public void SetMoledo(string modelo)
        {
            this.modelo = modelo;
        }

        public string GetModelo()
        {
            return this.modelo;
        }

        public void SetCilindrada(int cilindrada)
        {
            this.cilindrada = cilindrada;
        }

        public int GetCilindrada()
        {
            return this.cilindrada;
        }

        public void SetPotencia(double potencia)
        {
            this.potencia = potencia;
        }

        public double GetPotencia()
        {
            return this.potencia;
        }
    }

}

