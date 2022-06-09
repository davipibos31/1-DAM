using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_6._8._1.Modelo
{
    class PruebaTrabajadores
    {
        static void Main(string[] args)
        {
            Trabajador[] MisTrabajadores = new Trabajador[3];
            Analista[] MisAnalistas = new Analista[3];
            Programador[] MisProgramadores = new Programador[3];
            Ingeniero[] MisIngenieros = new Ingeniero[3];
            IngenieroInformatico[] MisIngenierosInformaticos = new IngenieroInformatico[3];

            for (byte i = 0; i < 3; i++)
            {
                MisTrabajadores[i] = new Trabajador();
                MisAnalistas[i] = new Analista();
                MisProgramadores[i] = new Programador();
                MisIngenieros[i] = new Ingeniero();
                MisIngenierosInformaticos[i] = new IngenieroInformatico();
            }
        }
    }
}
