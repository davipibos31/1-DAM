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

namespace Formulario_y_Calculadora_WPF
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

        private void txt_nombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txt_nombre.Text != "")
                txt_nombre.Background = Brushes.White;
            else
                txt_nombre.Background = Brushes.IndianRed;
            barraprogreso();
        }

        private void txt_primer_apellido_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txt_primer_apellido.Text != "")
                txt_primer_apellido.Background = Brushes.White;
            else
                txt_primer_apellido.Background = Brushes.IndianRed;
            barraprogreso();
        }

        private void txt_segundo_apellido_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txt_segundo_apellido.Text != "")
                txt_segundo_apellido.Background = Brushes.White;
            else
                txt_segundo_apellido.Background = Brushes.IndianRed;
            barraprogreso();
        }

        private void btn_Salir1_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_Enviar_Click(object sender, RoutedEventArgs e)
        {
            if (txt_nombre.Text == "")
            {
                txt_nombre.Background = Brushes.IndianRed;
                txt_nombre.Focus();
            }
            else if (txt_primer_apellido.Text == "")
            {
                txt_primer_apellido.Background = Brushes.IndianRed;
                txt_primer_apellido.Focus();
            }
            else if (txt_segundo_apellido.Text == "")
            {
                txt_segundo_apellido.Background = Brushes.IndianRed;
                txt_segundo_apellido.Focus();
            }
            else if (txt_email.Text == "")
            {
                txt_email.Background = Brushes.IndianRed;
                txt_email.Focus();
            }
            else if (txt_movil.Text == "")
            {
                txt_movil.Background = Brushes.IndianRed;
                txt_movil.Focus();
            }
            else if (txt_telefono.Text == "")
            {
                txt_telefono.Background = Brushes.IndianRed;
                txt_telefono.Focus();
            }
            else
                MessageBox.Show("Formulario Completo Y Enviado", "Datos Formulario");
        }

        private void txt_email_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txt_email.Text != "")
                txt_email.Background = Brushes.White;
            else
                txt_email.Background = Brushes.IndianRed;
            barraprogreso();
        }

        private void txt_movil_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txt_movil.Text != "")
                txt_movil.Background = Brushes.White;
            else
                txt_movil.Background = Brushes.IndianRed;
            barraprogreso();
        }

        private void txt_telefono_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txt_telefono.Text != "")
                txt_telefono.Background = Brushes.White;
            else
                txt_telefono.Background = Brushes.IndianRed;
            barraprogreso();


        }

        private void lbx_opcion2_Selected(object sender, RoutedEventArgs e)
        {
            barraprogreso();
        }

        private void lbx_opcion1_Selected(object sender, RoutedEventArgs e)
        {
            barraprogreso();
        }

        private void barraprogreso(object sender, RoutedEventArgs e)
        {
            barraprogreso();
        }

        private void rb_masculino_Checked(object sender, RoutedEventArgs e)
        {
            barraprogreso();
        }

        private void cb_3_Checked(object sender, RoutedEventArgs e)
        {
            barraprogreso();
        }

        private void cb_2_Checked(object sender, RoutedEventArgs e)
        {
            barraprogreso();
        }

        private void cb_1_Checked(object sender, RoutedEventArgs e)
        {
            barraprogreso();
        }

        private void cbx_localidad_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            barraprogreso();
        }

        private void cb_4_Checked(object sender, RoutedEventArgs e)
        {
            barraprogreso();
        }

        private void rb_femenino_Checked(object sender, RoutedEventArgs e)
        {
            barraprogreso();
        }

        private void barraprogreso()
        {
           int valor = 0;
            pb_Barra.Value = 0;

            if (txt_nombre.Text != "")
            {
                pb_Barra.Value++;
                valor++;
            }
            if (txt_primer_apellido.Text != "")
            {
                pb_Barra.Value++;
                valor++;
            }
            if (txt_segundo_apellido.Text != "")
            {
                pb_Barra.Value++;
                valor++;
            }
            if (cb_1.IsChecked == true || cb_2.IsChecked == true || cb_3.IsChecked == true || cb_4.IsChecked == true)
            {
                pb_Barra.Value++;
                valor++;
            }
            if (rb_masculino.IsChecked == true || rb_femenino.IsChecked == true)
            {
                pb_Barra.Value++;
                valor++;
            }
            if (cbx_localidad.IsLoaded == true)
            {
                pb_Barra.Value++;
                valor++;
            }
            if (lbx_opcion1.IsSelected == true || lbx_opcion2.IsSelected == true)
            {
                pb_Barra.Value++;
                valor++;
            }
            if (txt_email.Text != "")
            {
                pb_Barra.Value++;
                valor++;
            }
            if (txt_movil.Text != "")
            {
                pb_Barra.Value++;
                valor++;
            }
            if (txt_telefono.Text != "")
            {
                pb_Barra.Value++;
                valor++;
            }
            lbl_barra_progreso.Content = valor + "/10";
        }
    }
}
