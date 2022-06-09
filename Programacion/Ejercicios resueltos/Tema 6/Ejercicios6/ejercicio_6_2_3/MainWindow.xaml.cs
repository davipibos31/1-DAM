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

namespace ejercicio_6_2_3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Libro libro;
        public MainWindow()
        {
            InitializeComponent();

            libro = new Libro();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            libro.SetAutor(txtAutor.Text);
            libro.SetTitulo(txtTitulo.Text);
            libro.SetUbicacion(txtUbicacion.Text);
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Autor: " + libro.GetAutor() +
                "\nTítulo: " + libro.GetTitulo() +
                "\nUbicación: " + libro.GetUbicacion());
        }
    }

    public class Libro
    {
        string autor;
        string titulo;
        string ubicacion;

        public void SetAutor(string autor)
        {
            this.autor = autor;
        }

        public string GetAutor()
        {
            return this.autor;
        }

        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public string GetTitulo()
        {
            return this.titulo;
        }

        public void SetUbicacion(string ubicacion)
        {
            this.ubicacion = ubicacion;
        }

        public string GetUbicacion()
        {
            return this.ubicacion;
        }
    }

}
