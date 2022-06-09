using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_7._2._4.Modelo
{
    class PruebaTrabajadores
    {
        static void Main(string[] args)
        {
            Trabajador t1 = new Trabajador();
            Programador p1 = new Programador();
            Analista a1 = new Analista();
            Ingeniero i1 = new Ingeniero();
            IngenieroInformatico ii1 = new IngenieroInformatico();

            Trabajador[] MisTrabajadores = new Trabajador[8];
            MisTrabajadores[0] = new Ingeniero();
            MisTrabajadores[1] = new Analista();
            MisTrabajadores[2] = new IngenieroInformatico();
            MisTrabajadores[3] = new Programador();

            for (byte i = 4; i < 7; i++)
                MisTrabajadores[i] = new Programador();
            MisTrabajadores[7] = new Trabajador();
            
            Animal[] misAnimales = new Animal[8];

            misAnimales[0] = new Perro();
            misAnimales[1] = new Gato();
            misAnimales[2] = new GatoSiames();

            for (byte i = 3; i < 7; i++)
                misAnimales[i] = new Perro();

            misAnimales[7] = new Animal();
        }
    }
}
