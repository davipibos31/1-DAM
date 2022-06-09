using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Practica_4
{
    public class Cliente : Cuenta_Bancaria
    {
        private string nombre;
        private string primer_apellido;
        private int dni_numerico;
        private int cuenta;
        public Cliente(string nombre, string primer_apellido, int dni_numerico, int cuenta)
        {
            this.nombre = nombre;
            this.primer_apellido = primer_apellido;                                             
            this.dni_numerico = dni_numerico;
            this.cuenta = cuenta;
        }

        public Cliente()
        {                                                                               //Dos contructores, uno parametrizado
            
        }
        public string GetNombre()
        {
            return nombre;
        }
        public string GetPrimer_apellido()                                          //Cada metodo Get de las variables
        {
            return primer_apellido;
        }
        public int GetDni()
        {
            return dni_numerico;
        }
        public int GetCuenta()
        {
            return cuenta;
        }
    }
}
