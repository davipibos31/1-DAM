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

namespace Prueba_Wpf_y_objetos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Persona p = new Persona("carlos", 27);

            Label l = new Label();
            l.Name = "lblnombre";
            l.Content = "Nombre: ";
            l.Height = 40;
            l.Width = 100;
            l.VerticalAlignment = VerticalAlignment.Top;
            l.HorizontalAlignment = HorizontalAlignment.Left;
            l.Margin = new Thickness(104, 78, 0, 0);
            l.Background = Brushes.YellowGreen;

            principal.Children.Add(l);

            principal.Children.Add(p.mostrar());
        }
    }
}
