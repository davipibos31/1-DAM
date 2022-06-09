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

namespace Ejercicio6_2_2
{
    public class Juego
    {
        public void Lanzar()
        {
            MessageBox.Show("Bienvenido a Console Invaders");
        }
    }

    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Juego juego;

        public MainWindow()
        {
            InitializeComponent();

            juego = new Juego();

            juego.Lanzar();
        }
    }
}
