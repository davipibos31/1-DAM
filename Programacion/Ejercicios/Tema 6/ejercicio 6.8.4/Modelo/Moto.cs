using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_6._5._5.Modelo
{
    class Moto : Vehiculo
    {
        public Moto()
        {
            Console.WriteLine("Entrando al constructor de moto");
            CantidadDeRuedas = 2;
        }
    }
}
