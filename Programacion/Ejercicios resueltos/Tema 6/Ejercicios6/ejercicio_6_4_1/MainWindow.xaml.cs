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

namespace ejercicio_6_4_1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CPorton porton;
        public MainWindow()
        {
            InitializeComponent();

            porton = new CPorton();
        }

        private void ckbBloquear_Click(object sender, RoutedEventArgs e)
        {
            if (ckbBloquear.IsChecked == true)
                porton.Bloquear();
            else
                porton.Desbloquear();
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(porton.MostrarEstado());
        }
    }
}
