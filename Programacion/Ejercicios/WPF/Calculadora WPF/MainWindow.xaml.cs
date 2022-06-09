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

namespace Calculadora_WPF
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

        private void btn_Salir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        
        private void MostrarNumeros(object sender, RoutedEventArgs e)
        {
            if (txt_Resultado.Text == "0")
                txt_Resultado.Text = "";

            Button btn = (Button)sender;
            txt_Resultado.Text += btn.Content.ToString();
        }

        private void Borrar(object sender, RoutedEventArgs e)
        {
            if (txt_Resultado.Text.Length > 1)
            {
                txt_Resultado.Text = txt_Resultado.Text.Substring(0, txt_Resultado.Text.Length - 1);
            }
            else
            {
                txt_Resultado.Text = "0";
            }
        }

        double numero1 = 0, numero2 = 0;
        char operacion = '0';

        private void clickIgual(object sender, RoutedEventArgs e)
        {
            numero2 = Convert.ToDouble(txt_Resultado.Text);

            if (operacion == '+')
            { 
                txt_Resultado.Text = (numero1 + numero2).ToString();
                numero1 = Convert.ToDouble(txt_Resultado.Text);
            }
            else if (operacion == '-')
            {
                txt_Resultado.Text = (numero1 - numero2).ToString();
                numero1 = Convert.ToDouble(txt_Resultado.Text);
            }
            else if (operacion == '*')
            {
                txt_Resultado.Text = (numero1 * numero2).ToString();
                numero1 = Convert.ToDouble(txt_Resultado.Text);
            }
            else if (operacion == '/')
            {
                txt_Resultado.Text = (numero1 / numero2).ToString();
                numero1 = Convert.ToDouble(txt_Resultado.Text);
            }
        }
        private void ClickOperacion(object sender, RoutedEventArgs e)
        {
            numero1 = Convert.ToDouble(txt_Resultado.Text);
            var btn = (Button)sender;
            operacion = Convert.ToChar(btn.Tag);
            txt_Resultado.Text = "0";
        }
    }
}
