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

namespace Prueba_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_enviar_Click(object sender, RoutedEventArgs e)
        {
            /* string error = "Primero rellena los campos";
             if (txtnombre.Text == "")
                 MessageBox.Show(error, "Ventana Error");
             else if (txtemail.Text == "")
                 MessageBox.Show(error, "Ventana Error");
             else
                 MessageBox.Show(txtnombre.Text + "\n" + txtemail.Text, "Ventana Datos");*/

            if (txtnombre.Text == "")
            {
                txtnombre.Background = Brushes.IndianRed;
                txtnombre.Focus();
            }
            else if (txtemail.Text == "")
            {
                txtemail.Background = Brushes.IndianRed;
                txtemail.Focus();
            }
            else
                MessageBox.Show(txtnombre.Text + "\n" + txtemail.Text, "Ventana Datos"); 
        }

        private void txtnombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtnombre.Text != "")
                txtnombre.Background = Brushes.White;
            else
                txtnombre.Background = Brushes.IndianRed;
        }

        private void txtemail_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtemail.Text != "")
                txtemail.Background = Brushes.White;
            else
                txtemail.Background = Brushes.IndianRed;
        }

        private void btn_cerrar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_hola_Click(object sender, RoutedEventArgs e)
        {
            if (txtnombre.Text == "")
                txtnombre.Text = btn_hola.Content.ToString();
            else if (txtnombre.Text != "")
                txtnombre.Text = btn_hola.Content.ToString();
        }

        private void btn_adios_Click(object sender, RoutedEventArgs e)
        {
            if (txtnombre.Text == "")
                txtnombre.Text = btn_adios.Content.ToString();
            else if (txtnombre.Text != "")
                txtnombre.Text = btn_adios.Content.ToString();
        }

        private void calcular(object sender, RoutedEventArgs e)
        {
            if (txtnumero.Text == "")
            {
                txtnumero.Background = Brushes.IndianRed;
                txtnumero.Focus();
            }
            else if (txtnumero1.Text == "")
            {
                txtnumero1.Background = Brushes.IndianRed;
                txtnumero1.Focus();
            }
            else
            {
                int numero2 = Convert.ToInt32(txtnumero.Text);
                int numero3 = Convert.ToInt32(txtnumero1.Text);

                Button btn = (Button)sender;
                char operacion = Convert.ToChar(btn.Content.ToString());

                switch (operacion)
                {
                    case '+': txtresultado.Text = "" + (numero2 + numero3).ToString(); break;
                    case '-': txtresultado.Text = "" + (numero2 - numero3).ToString(); break;
                    case '*': txtresultado.Text = "" + (numero2 * numero3).ToString(); break;
                    case '/': txtresultado.Text = "" + (numero2 / numero3).ToString(); break;
                }
            }
        }

        private void chx_trabajas_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Gooooool!!!!");
        }

        private void chx_estudias_Click(object sender, RoutedEventArgs e)
        {
            if (chx_estudias.IsChecked == true)
            {
                ltx_ciudad.IsEnabled = true;
                cbx_ciudad.IsEnabled = true;
            }
            else
            {
                ltx_ciudad.IsEnabled = false;
                cbx_ciudad.IsEnabled = false;
            }
        }

        private void chx_trabajas_Copy_Checked(object sender, RoutedEventArgs e)
        {
           if (chx_trabajas_Copy.IsChecked == true)
            {
                ltx_ciudad.IsEnabled = true;
                cbx_ciudad.IsEnabled = true;
            }
            else
            {
                ltx_ciudad.IsEnabled = false;
                cbx_ciudad.IsEnabled = false;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            pb_barra.Value += 25;
        }
    }
}