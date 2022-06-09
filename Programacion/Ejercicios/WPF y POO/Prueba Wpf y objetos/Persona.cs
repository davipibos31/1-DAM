using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Prueba_Wpf_y_objetos
{
    class Persona
    {
        private string nombre;
        private int edad;

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public Grid mostrar()
        {
            Label l = new Label();
            l.Content = "Nombre: " + nombre;

            Label le = new Label();
            le.Content = "Edad: " + edad;
            le.HorizontalAlignment = HorizontalAlignment.Right;
            Grid g = new Grid();

            g.Children.Add(l);
            g.Children.Add(le);

            return g;
        }
    }
}
