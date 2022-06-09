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

namespace Formulario
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

        public void Numeros(object sender, KeyEventArgs e) 
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                e.Handled = false;
            else
                e.Handled = true;
        }
        public static int Codigo_aleatorio_Cliente;
        private void rb_cliente_Checked(object sender, RoutedEventArgs e)
        {
            cb_provincia.Items.Clear();
            cb_provincia.Items.Add("Alicante");
            cb_provincia.Items.Add("Valencia");
            cb_provincia.Items.Add("Castellón");

            Random r = new Random();
            Codigo_aleatorio_Cliente = r.Next(1000, 10000);

            lbl_codigo1.Content = Codigo_aleatorio_Cliente;
        }

        private void rb_distribuidor_Checked(object sender, RoutedEventArgs e)
        {
            cb_provincia.Items.Clear();
            cb_provincia.Items.Add("Alicante");
            cb_provincia.Items.Add("Valencia");
            cb_provincia.Items.Add("Castellón");
            cb_provincia.Items.Add("Murcia");
            cb_provincia.Items.Add("Alabcete");
            cb_provincia.Items.Add("Cuenca");
            cb_provincia.Items.Add("Teruel");


            var letrasnumeros = "abcdefghijklmnopqrstuvwyz0123456789";
            var caracter = new char[10];
            var random = new Random();

            for (int i = 0; i < caracter.Length; i++)
            {
                caracter[i] = letrasnumeros[random.Next(letrasnumeros.Length)];
            }
            var resultado = new string(caracter);

            lbl_codigo1.Content = resultado;
        }

        private void btn_cancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_aceptar_Click(object sender, RoutedEventArgs e)
        {
            if (txt_nombre.Text == "" || txt_primer_apellido.Text == "" || txt_telefono1.Text == "" || txt_correo.Text == "" || txt_direccion.Text == "" || cb_provincia.SelectedIndex == -1)
                MessageBox.Show("Rellena los campos");
            else if (rb_cliente.IsChecked == false && rb_distribuidor.IsChecked == false)
                MessageBox.Show("Rellena los campos");
            else
            {
                if (rb_cliente.IsChecked == true)
                    CrearCliente();
                if (rb_distribuidor.IsChecked == true)
                    CrearDistribuidor();
            }
        }

        public static Cliente[] clientes = new Cliente[5];
        public static Distribuidor[] distribuidores = new Distribuidor[5];
        public static int m = 0;
        public static List<Cliente> listacliente = new List<Cliente>();
        public static List<Distribuidor> listadistribuidor = new List<Distribuidor>();

        public void CrearCliente()
        {
            Cliente Cliente = new Cliente(txt_nombre.Text, txt_primer_apellido.Text, txt_correo.Text, txt_direccion.Text, cb_provincia.Text, Convert.ToInt32(txt_telefono1.Text), Convert.ToInt32(txt_telefono2.Text), Convert.ToInt32(lbl_codigo1.Content));
            
            MessageBox.Show("Nombre: " + Cliente.GetNombre() + " Primer Apellido: " + Cliente.GetPrimerApellido() + " Correo: " + Cliente.GetCorreo() + " Dirección: " + Cliente.GetDirrecion() +
                " Provincia: " + Cliente.GetProvincia() + " Telefono: " + Cliente.GetTelefono1() + " Codigo: " + Cliente.Getcodigo());


            listacliente.Add(Cliente);
            list_cliente.Items.Add(Cliente.GetNombre());
           
            txt_nombre.Text = txt_primer_apellido.Text = txt_correo.Text = txt_direccion.Text = cb_provincia.Text = txt_telefono1.Text = txt_telefono2.Text = ""; rb_cliente.IsChecked = false;

        }
        public void CrearDistribuidor()
        {
            Distribuidor distribuidor = new Distribuidor(txt_nombre.Text, txt_primer_apellido.Text, txt_correo.Text, txt_direccion.Text, cb_provincia.Text, Convert.ToInt32(txt_telefono1.Text), Convert.ToInt32(txt_telefono2.Text), lbl_codigo1.Content.ToString());

            MessageBox.Show("Nombre: " + distribuidor.GetNombre() + " Primer Apellido: " + distribuidor.GetPrimerApellido() + " Correo: " + distribuidor.GetCorreo() + " Dirección: " + distribuidor.GetDirrecion() +
                " Provincia: " + distribuidor.GetProvincia() + " Telefono: " + distribuidor.GetTelefono1() + " Codigo: " + distribuidor.Getcodigo());

            listadistribuidor.Add(distribuidor);
            list_distribuidor.Items.Add(distribuidor.GetNombre());

            txt_nombre.Text = txt_primer_apellido.Text = txt_correo.Text = txt_direccion.Text = cb_provincia.Text = txt_telefono1.Text = txt_telefono2.Text = ""; rb_distribuidor.IsChecked = false;
        }

        private void list_cliente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox lb = (ListBox)sender;
            Cliente Cliente1 = listacliente[lb.SelectedIndex];

            lbl_mostrar_cliente.Content = "Cliente: \nNombre: " + Cliente1.GetNombre() + " Primer Apellido: " + Cliente1.GetPrimerApellido() + "\nCorreo: " + Cliente1.GetCorreo() + " Dirección: " + Cliente1.GetDirrecion() +
                " Provincia: " + Cliente1.GetProvincia() + "\nTelefono: " + Cliente1.GetTelefono1() + " Codigo: " + Cliente1.Getcodigo();
        }

        private void list_distribuidor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox lb = (ListBox)sender;
            Distribuidor Distribuidor1 = listadistribuidor[lb.SelectedIndex];
           
            lbl_mostrar_distribuidor.Content = "Distribuidor: \nNombre: " + Distribuidor1.GetNombre() + " Primer Apellido: " + Distribuidor1.GetPrimerApellido() + "\nCorreo: " + Distribuidor1.GetCorreo() + " Dirección: " + Distribuidor1.GetDirrecion() +
               " Provincia: " + Distribuidor1.GetProvincia() + "\nTelefono: " + Distribuidor1.GetTelefono1() + " Codigo: " + Distribuidor1.Getcodigo();
        }

        private void btn_añadir_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}