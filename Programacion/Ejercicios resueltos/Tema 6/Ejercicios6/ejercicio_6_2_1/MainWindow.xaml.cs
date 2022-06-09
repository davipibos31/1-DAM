using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ejercicio_6_2_1
{
    public class Persona
    {
        String nombre;

        public void SetNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public void Saludar()
        {
            MessageBox.Show("Hola, soy " + nombre);
        }
    }

    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Persona persona1 = new Persona();
        Persona persona2;

        public MainWindow()
        {
            InitializeComponent();

            persona2 = new Persona();
        }

        private void btnAsignarNombre_Click(object sender, RoutedEventArgs e)
        {
            persona1.SetNombre(txtNombre1.Text);
            persona2.SetNombre(txtNombre2.Text);
        }

        private void btnSaludar_Click(object sender, RoutedEventArgs e)
        {
            persona1.Saludar();
            persona2.Saludar();
        }
    }
}
