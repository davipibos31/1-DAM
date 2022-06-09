using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Examen_2Evaluacion
{
    public class Cliente
    {
        private string nombre;
        private string primer_apellido;
        private int telefono1;
        private int telefono2;
        private string correo_electronico;
        private string direccion;
        private string provincia;
        public Random codigo = new Random();
        int codigo_aleatorio;

        public Cliente(string nombre, string primer_apellido, 
            int telefono1, string correo_electronico, string direccion, string provincia)
        {
        }
        public int GetCodigo()
        {
            codigo_aleatorio = codigo.Next(1000, 10000);
            return codigo_aleatorio;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public string GetPrimer_apellido()
        {
            return primer_apellido;
        }
        public int GetTelefono1()
        {
            return telefono1;
        }
        public int GetTelefono2()
        {
            return telefono2;
        }
        public string GetCorreo_electronico()
        {
            return correo_electronico;
        }
        public string GetDireccion()
        {
            return direccion;
        }
        public string GetProvincia()
        {
            return provincia;
        }
    }
}
