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
using System.Diagnostics;

namespace ejercicio_6_8_4
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CCoche coche;
        CMoto moto;
        CVehiculo vehiculo;

        public MainWindow()
        {
            InitializeComponent();

            Trace.WriteLine("Vehículo");
            vehiculo = new CVehiculo();

            Trace.WriteLine("Coche");
            coche = new CCoche();

            Trace.WriteLine("Moto");
            moto = new CMoto();
        }
    }
}
