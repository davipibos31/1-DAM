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

namespace Examen_2Evaluacion
{

//-----------------------------------------
// David PIñuel Bosque
// Curso DAM
// Modalidad Presencial
// Examen Segunda Evaluación
//------------------------------------------

    public partial class MainWindow : Window                //Carlos esto a sido muy largo no da tiempo ha hacerlo en 2 horas
                                                            //He dejado comentarios de lo que queria haver para que veas que se havcerlo pero no ha dado tiempo
                                                            //Al no dar tiempo lo he hecho sin usar las clases para que te pueda compilar y funcione y funcona completamente
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }
        public static Cliente[] Clientes = new Cliente[5];                      //En la linea comentada he creado un clinete con el constructor para dar sus datos de los elemetos de wpf pero no me ha dado tiempo
        public static Distribuidor[] distribuidores = new Distribuidor[5];
        //public static Cliente C1 = new Cliente(txt_nombre.Text, txt_primer_apellido.Text, Convert.ToInt32(txt_telefono1.Text), txt_correo_electronico.Text, txt_direccion.Text, txt_provincia.Text);
        public static int num1 = 0;
        public static int num2 = 0;
        private void menu_salir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void menu_alta_distribuidor_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                altas_ambos.Visibility = Visibility.Visible;
                datos_ambos.Visibility = Visibility.Hidden;             //en esta funcion he comentado una parte que no me ha dado tiempo y era para agregar al grid del tabcontrol de alta poner sus elementos que luego hanria que trabajr con las clases sus campos 
                                                                        //alta_distribuidores.Children.Add(grid_cliente);
            }
            catch (Exception)
            {
                MessageBox.Show("Error de visibilidad");
            }
        }

        private void txt_telefono1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                    e.Handled = false;
                else
                    e.Handled = true;                       //ene esta funcion hago que sean solo numeros
            }
            catch (Exception)
            {
                MessageBox.Show("Error numérico");
            }
        }
        public static TextBox txt_provincia = new TextBox();
        private void rb_cliente_Checked(object sender, RoutedEventArgs e)
        {
            cbx_provincia.IsEnabled = true;
            cbx_provincia.Items.Clear();
            cbx_provincia.Items.Add("Castellon");
            cbx_provincia.Items.Add("Valencia");                            //Con esta funcion hago que cuando sea el radiobutton checkeado ponga en el combobox sus items correspondientes y lo habilite
            cbx_provincia.Items.Add("Alicante");
        }

        private void rb_distribuidor_Checked(object sender, RoutedEventArgs e)
        {
            cbx_provincia.IsEnabled = true;
            cbx_provincia.Items.Clear();
            cbx_provincia.Items.Add("Castellon");
            cbx_provincia.Items.Add("Valencia");                        //Con esta funcion hago que cuando sea el radiobutton checkeado ponga en el combobox sus items correspondientes y lo habilite
            cbx_provincia.Items.Add("Alicante");
            cbx_provincia.Items.Add("Murcia");
            cbx_provincia.Items.Add("Albacete");
            cbx_provincia.Items.Add("Cuenca");
            cbx_provincia.Items.Add("Teruel");
        }

        private void btn_cancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        public static Label Cliente_datos, Distribuidor_datos;

      // public static TextBox txt_telefono2,txt_nombre, txt_primer_apellido, txt_telefono1, txt_direccion, txt_correo_electronico;

        //public static Grid grid_cliente;
                            
      /*  public Grid Crear_cliente()
        {
            txt_nombre = new TextBox();
            txt_nombre.Text ="";
            txt_nombre.HorizontalAlignment = HorizontalAlignment.Left;
            txt_nombre.VerticalAlignment = VerticalAlignment.Top;
            txt_nombre.Width = 120;
            txt_nombre.Height = 22;
            txt_nombre.Margin = new Thickness(141, 38, 0, 0);
            txt_nombre.TextWrapping = TextWrapping.Wrap;
            txt_nombre.MaxLength = 32;
                                                                                                               //   En esta funcion lo que he querido hacer es crear los textbox que luego trabajariamos con ellos para dar los valores en las clases y poder trabajar con ellos                                                     
            txt_primer_apellido = new TextBox();
            txt_primer_apellido.Text = "";
            txt_primer_apellido.HorizontalAlignment = HorizontalAlignment.Left;
            txt_primer_apellido.VerticalAlignment = VerticalAlignment.Top;
            txt_primer_apellido.Width = 120;
            txt_primer_apellido.Height = 22;
            txt_primer_apellido.Margin = new Thickness(141, 83, 0, 0);
            txt_primer_apellido.TextWrapping = TextWrapping.Wrap;
            txt_primer_apellido.MaxLength = 32;


            txt_telefono1 = new TextBox();
            txt_telefono1.Text = "";
            txt_telefono1.HorizontalAlignment = HorizontalAlignment.Left;
            txt_telefono1.VerticalAlignment = VerticalAlignment.Top;
            txt_telefono1.Width = 120;
            txt_telefono1.Height = 22;
            txt_telefono1.Margin = new Thickness(141, 128, 0, 0);
            txt_telefono1.TextWrapping = TextWrapping.Wrap;
            txt_telefono1.MaxLength = 9;
            txt_telefono1.KeyDown += txt_telefono1_KeyDown;


            txt_telefono2 = new TextBox();
            txt_telefono2.Text = "";
            txt_telefono2.HorizontalAlignment = HorizontalAlignment.Left;
            txt_telefono2.VerticalAlignment = VerticalAlignment.Top;
            txt_telefono2.Width = 120;
            txt_telefono2.Height = 22;
            txt_telefono2.Margin = new Thickness(141, 173, 0, 0);
            txt_telefono2.TextWrapping = TextWrapping.Wrap;
            txt_telefono2.MaxLength = 9;
            txt_telefono2.KeyDown += txt_telefono1_KeyDown;



            txt_correo_electronico = new TextBox();
            txt_correo_electronico.Text = "";
            txt_correo_electronico.HorizontalAlignment = HorizontalAlignment.Left;
            txt_correo_electronico.VerticalAlignment = VerticalAlignment.Top;
            txt_correo_electronico.Width = 120;
            txt_correo_electronico.Height = 22;
            txt_correo_electronico.Margin = new Thickness(509, 36, 0, 0);
            txt_correo_electronico.TextWrapping = TextWrapping.Wrap;
            txt_correo_electronico.MaxLength = 100;


            txt_direccion = new TextBox();
            txt_direccion.Text = "";
            txt_direccion.HorizontalAlignment = HorizontalAlignment.Left;
            txt_direccion.VerticalAlignment = VerticalAlignment.Top;
            txt_direccion.Width = 120;
            txt_direccion.Height = 22;
            txt_direccion.Margin = new Thickness(509, 83, 0, 0);
            txt_direccion.TextWrapping = TextWrapping.Wrap;
            txt_direccion.MaxLength = 100;

            grid_cliente.Children.Add(txt_nombre);
            grid_cliente.Children.Add(txt_primer_apellido);
            grid_cliente.Children.Add(txt_telefono1);
            grid_cliente.Children.Add(txt_telefono2);
            grid_cliente.Children.Add(txt_direccion);
            grid_cliente.Children.Add(txt_correo_electronico);
            return grid_cliente;
        }*/
        private void btn_aceptar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_nombre.Text == "" || txt_primer_apellido.Text == "" || txt_telefono1.Text == ""
                    || txt_direccion.Text == "" || txt_correo_electronico.Text == "" || cbx_provincia.SelectedIndex == -1)
                    MessageBox.Show("Rellena los datos obligatorios");
                else
                {
                    MessageBox.Show("Datos enviados");

                    if (rb_cliente.IsChecked == true)
                    {
                        Cliente_datos = new Label();
                        Cliente_datos.Content = "Nombre: " + txt_nombre.Text + " Primer Apellido: "
                            + txt_primer_apellido.Text + " Telefono: " + txt_telefono1.Text + " Dirección: "
                            + txt_direccion.Text + " Correo Electronico: " + txt_correo_electronico.Text
                            + " Provincia: " + cbx_provincia.SelectedItem;
                        Cliente_datos.Foreground = Brushes.Black;
                        Cliente_datos.HorizontalAlignment = HorizontalAlignment.Left;
                        Cliente_datos.VerticalAlignment = VerticalAlignment.Top;                                                                    //en esta funcion hago que cuando haga click mande los datos en el grid correspondiente y diga si estan vacios o no                            
                        Cliente_datos.Width = 700;
                        Cliente_datos.Height = 300;
                        Cliente_datos.Margin = new Thickness(40, 34, 0, 0);



                        g_cliente.Children.Add(Cliente_datos);
                    }
                    else if (rb_distribuidor.IsChecked == true)
                    {
                        Distribuidor_datos = new Label();
                        Distribuidor_datos.Content = "Nombre: " + txt_nombre.Text + " Primer Apellido: "
                            + txt_primer_apellido.Text + " Telefono: " + txt_telefono1.Text + " Dirección: "
                            + txt_direccion.Text + " Correo Electronico: " + txt_correo_electronico.Text
                            + " Provincia: " + cbx_provincia.SelectedItem;
                        Distribuidor_datos.Foreground = Brushes.Black;
                        Distribuidor_datos.HorizontalAlignment = HorizontalAlignment.Left;
                        Distribuidor_datos.VerticalAlignment = VerticalAlignment.Top;
                        Distribuidor_datos.Width = 700;
                        Distribuidor_datos.Height = 300;
                        Distribuidor_datos.Margin = new Thickness(40, 34, 0, 0);

                        g_distribuidor.Children.Add(Distribuidor_datos);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error de datos");
            }
        }

        private void menu_datos_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                altas_ambos.Visibility = Visibility.Hidden;
                datos_ambos.Visibility = Visibility.Visible;
            }
            catch (Exception)
            {
                MessageBox.Show("Error de visibilidad");
            }
        }
    }
}
