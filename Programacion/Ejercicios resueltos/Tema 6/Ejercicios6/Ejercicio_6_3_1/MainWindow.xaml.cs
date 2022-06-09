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

namespace Ejercicio6_3_1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CPuerta puerta;

        public MainWindow()
        {
            InitializeComponent();

            puerta = new CPuerta();

            MessageBox.Show("Valores iniciales:");
            puerta.MostrarEstado();

            MessageBox.Show("Vamos a abrir...");
            puerta.Abrir();
            puerta.SetAncho(80);
            puerta.MostrarEstado();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                puerta.SetAncho(Convert.ToInt32(txtAncho.Text));
                puerta.SetAlto(Convert.ToInt32(txtAlto.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(puerta.MostrarEstado());
        }
    }
}
