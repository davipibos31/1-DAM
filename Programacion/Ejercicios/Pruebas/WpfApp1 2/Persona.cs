using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;


namespace WpfApp1_2
{
    public class Persona
    {
        public string nombre;
        public int edad;
        public string ciudad;

        public Persona(string nombre, int edad, string ciudad)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.ciudad = ciudad;
        }

        public string GetNombre()
        {
            return nombre;
        }
        public int GetEdad()
        {
            return edad;
        }
        public string GetCiudad()
        {
            return ciudad;
        }
    }
}
