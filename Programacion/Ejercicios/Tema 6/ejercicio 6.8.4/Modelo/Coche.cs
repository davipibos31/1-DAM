using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_6._5._5.Modelo
{
    class Coche : Vehiculo
    {
        public Coche()
        {
            Console.WriteLine("Entrando al constructor de coche");
            CantidadDeRuedas = 4;
        }
    }
}
