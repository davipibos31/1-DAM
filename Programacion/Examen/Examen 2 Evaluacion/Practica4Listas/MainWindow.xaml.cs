using System;
using System.Collections.Generic;
using System.IO;
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

namespace Practica4Listas
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
        
        public static Cliente[] clientes = new Cliente[5];
        public static Distribuidor[] distribuidores = new Distribuidor[5];
        public static int m = 0;
        public static List<Cliente> listacliente = new List<Cliente>();
        public static List<Distribuidor> listadistribuidor = new List<Distribuidor>();
        public static int Codigo_aleatorio_Cliente;
        public static StreamWriter Escritura;
        public static StreamReader Lectura;
        public static string nombre;
        public static string texto;

        /// <summary>
        /// Funciona para cerrar el programa es un elemento del menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click(object sender, RoutedEventArgs e) { Close(); }

        /// <summary>
        /// Funciona para dar visibilidad al tabcontrol correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            tc_Formulario.Visibility = Visibility.Visible;
            tc_operaciones.Visibility = Visibility.Hidden;
            tc_datos.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Funciona para dar visibilidad al tabcontrol correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            tc_operaciones.Visibility = Visibility.Visible;
            tc_Formulario.Visibility = Visibility.Hidden;
            tc_datos.Visibility = Visibility.Hidden;
        }
       
        /// <summary>
        /// Funciona para quitar visibilidad a los tabcontrol del programa y mostrar el fondo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            tc_Formulario.Visibility = Visibility.Hidden;
            tc_operaciones.Visibility = Visibility.Hidden;
            tc_datos.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Funciona para dar visibilidad al tabcontrol correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            tc_datos.Visibility = Visibility.Visible;
            tc_Formulario.Visibility = Visibility.Hidden;
            tc_operaciones.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Funciona para escribir solo numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Numeros(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                e.Handled = false;
            else
                e.Handled = true;
        }
        
        /// <summary>
        /// Funciona para dar las opciones dependiendo de si es un combobox o otro y para dar el codigo aleatorio (para cliente)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rb_cliente_Checked(object sender, RoutedEventArgs e)
        {
            if (rb_cliente.IsChecked == true)
            {
                cb_provincia.Items.Clear();
                cb_provincia.Items.Add("Alicante");
                cb_provincia.Items.Add("Valencia");
                cb_provincia.Items.Add("Castellón");

                Random r = new Random();
                Codigo_aleatorio_Cliente = r.Next(1000, 10000);

                lbl_codigo1.Content = Codigo_aleatorio_Cliente;
            }
            else if (rb_cliente2.IsChecked == true)
            {
                cb_provincia2.Items.Clear();
                cb_provincia2.Items.Add("Alicante");
                cb_provincia2.Items.Add("Valencia");
                cb_provincia2.Items.Add("Castellón");

                Random r = new Random();
                Codigo_aleatorio_Cliente = r.Next(1000, 10000);

                lbl_codigo2.Content = Codigo_aleatorio_Cliente;
            }
            
        }

        /// <summary>
        /// Funciona para dar las opciones dependiendo de si es un combobox o otro y para dar el codigo aleatorio (para distribuidor)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rb_distribuidor_Checked(object sender, RoutedEventArgs e)
        {
            if (rb_distribuidor.IsChecked == true)
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
            else if (rb_distribuidor2.IsChecked == true)
            {
                cb_provincia2.Items.Clear();
                cb_provincia2.Items.Add("Alicante");
                cb_provincia2.Items.Add("Valencia");
                cb_provincia2.Items.Add("Castellón");
                cb_provincia2.Items.Add("Murcia");
                cb_provincia2.Items.Add("Alabcete");
                cb_provincia2.Items.Add("Cuenca");
                cb_provincia2.Items.Add("Teruel");


                var letrasnumeros = "abcdefghijklmnopqrstuvwyz0123456789";
                var caracter = new char[10];
                var random = new Random();

                for (int i = 0; i < caracter.Length; i++)
                {
                    caracter[i] = letrasnumeros[random.Next(letrasnumeros.Length)];
                }
                var resultado = new string(caracter);

                lbl_codigo2.Content = resultado;
            }
            
        }

        /// <summary>
        /// Funciona para cerrar el programa es un boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancelar_Click(object sender, RoutedEventArgs e) { Close(); }

        /// <summary>
        /// Funciona si los elementos estan escritos, se creará un cliente o distribuidor dependiendo de que elección 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Funciona creando un cliente dando sus datos, muestra un mensaje y añade a la lista de cliente y listbox despues resetea los datos
        /// </summary>
        public void CrearCliente()
        {
            Cliente Cliente = new Cliente(txt_nombre.Text, txt_primer_apellido.Text, txt_correo.Text, txt_direccion.Text, cb_provincia.Text, Convert.ToInt32(txt_telefono1.Text), Convert.ToInt32(txt_telefono2.Text), Convert.ToInt32(lbl_codigo1.Content));

            MessageBox.Show("Nombre: " + Cliente.GetNombre() + " Primer Apellido: " + Cliente.GetPrimerApellido() + " Correo: " + Cliente.GetCorreo() + " Dirección: " + Cliente.GetDirrecion() +
                " Provincia: " + Cliente.GetProvincia() + " Telefono: " + Cliente.GetTelefono1() + " Codigo: " + Cliente.Getcodigo());

            listacliente.Add(Cliente);
            list_cliente.Items.Add(Cliente.GetNombre());
            listacliente.Sort();

            txt_nombre.Text = txt_primer_apellido.Text = txt_correo.Text = txt_direccion.Text = cb_provincia.Text = txt_telefono1.Text = txt_telefono2.Text = ""; rb_cliente.IsChecked = false;

        }

        /// <summary>
        /// Funciona creando un distribuidor dando sus datos, muestra un mensaje y añade a la lista de distribuidor y listbox despues resetea los datos
        /// </summary>
        public void CrearDistribuidor()
        {
            Distribuidor distribuidor = new Distribuidor(txt_nombre.Text, txt_primer_apellido.Text, txt_correo.Text, txt_direccion.Text, cb_provincia.Text, Convert.ToInt32(txt_telefono1.Text), Convert.ToInt32(txt_telefono2.Text), lbl_codigo1.Content.ToString());

            MessageBox.Show("Distribuidor:\nNombre: " + distribuidor.GetNombre() + " Primer Apellido: " + distribuidor.GetPrimerApellido() + " Correo: " + distribuidor.GetCorreo() + " Dirección: " + distribuidor.GetDirrecion() +
                " Provincia: " + distribuidor.GetProvincia() + " Telefono: " + distribuidor.GetTelefono1() + " Codigo: " + distribuidor.Getcodigo());

            listadistribuidor.Add(distribuidor);
            list_distribuidor.Items.Add(distribuidor.GetNombre());
            listadistribuidor.Sort();
            txt_nombre.Text = txt_primer_apellido.Text = txt_correo.Text = txt_direccion.Text = cb_provincia.Text = txt_telefono1.Text = txt_telefono2.Text = ""; rb_distribuidor.IsChecked = false;
        }

        /// <summary>
        /// Funciona desde la elección del listbox crea un cliente y lo muestra en el label del cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void list_cliente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ListBox lb = (ListBox)sender;
                Cliente Cliente1 = listacliente[lb.SelectedIndex];

                lbl_mostrar_cliente.Content = "Cliente: \nNombre: " + Cliente1.GetNombre() + " Primer Apellido: " + Cliente1.GetPrimerApellido() + "\nCorreo: " + Cliente1.GetCorreo() + " Dirección: " + Cliente1.GetDirrecion() +
                    " Provincia: " + Cliente1.GetProvincia() + "\nTelefono: " + Cliente1.GetTelefono1() + " Codigo: " + Cliente1.Getcodigo();
            }
            catch (Exception)
            {
                MessageBox.Show("Error Listas cliente");
            }
        }

        /// <summary>
        /// Funciona desde la elección del listbox crea un distribuidor y lo muestra en el label del distruibuidor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void list_distribuidor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ListBox lb = (ListBox)sender;
                Distribuidor Distribuidor1 = listadistribuidor[lb.SelectedIndex];

                lbl_mostrar_distribuidor.Content = "Distribuidor: \nNombre: " + Distribuidor1.GetNombre() + " Primer Apellido: " + Distribuidor1.GetPrimerApellido() + "\nCorreo: " + Distribuidor1.GetCorreo() + " Dirección: " + Distribuidor1.GetDirrecion() +
                   " Provincia: " + Distribuidor1.GetProvincia() + "\nTelefono: " + Distribuidor1.GetTelefono1() + " Codigo: " + Distribuidor1.Getcodigo();
            }
            catch (Exception)
            {
                MessageBox.Show("Error listas distribuidor");
            }
        }

        /// <summary>
        /// Funciona si los elementos estan escritos, se añadirá un cliente o distribuidor dependiendo de que elección 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_añadir_Click(object sender, RoutedEventArgs e)
        {
            if (txt_nombreAñadir.Text == "")
                MessageBox.Show("Rellena los campos");
            else if (rb_cliente2.IsChecked == false && rb_distribuidor2.IsChecked == false)
                MessageBox.Show("Rellena los campos");
            else
            {
                if (rb_cliente2.IsChecked == true)
                    AñadirCliente();
                if (rb_distribuidor2.IsChecked == true)
                    AñadirDistribuidor();
            }
        }

        /// <summary>
        /// Funciona creando un objeto cliente darle sus datos introducidos y añadiendolo a las listas y al listbox, despúes se restablece el textbox
        /// </summary>
        public void AñadirCliente()
        {
            Cliente Cliente = new Cliente(txt_nombreAñadir.Text, txt_primer_apellido2.Text, txt_correo2.Text, txt_direccion2.Text, cb_provincia2.Text, Convert.ToInt32(lbl_codigo2.Content), Convert.ToInt32(txt_telefono12.Text));

            MessageBox.Show("Nombre: " + Cliente.GetNombre() + " Primer Apellido: " + Cliente.GetPrimerApellido() + " Correo: " + Cliente.GetCorreo() + " Dirección: " + Cliente.GetDirrecion() +
                " Provincia: " + Cliente.GetProvincia() + " Telefono: " + Cliente.GetTelefono1() + " Codigo: " + Cliente.Getcodigo());

            listacliente.Add(Cliente);
            list_cliente.Items.Add(Cliente.GetNombre());
            //listacliente.Sort();
            
            txt_nombreAñadir.Text = "";
        }

        /// <summary>
        /// Funciona creando un objeto distribuidor darle sus datos introducidos y añadiendolo a las listas y al listbox, despúes se restablece el textbox
        /// </summary>
        public void AñadirDistribuidor()
        {
            Distribuidor distribuidor = new Distribuidor(txt_nombreAñadir.Text, txt_primer_apellido2.Text, txt_correo2.Text, txt_direccion2.Text, cb_provincia2.Text, Convert.ToInt32(txt_telefono12.Text), lbl_codigo2.Content.ToString());

            MessageBox.Show("Distribuidor:\nNombre: " + distribuidor.GetNombre() + " Primer Apellido: " + distribuidor.GetPrimerApellido() + " Correo: " + distribuidor.GetCorreo() + " Dirección: " + distribuidor.GetDirrecion() +
               " Provincia: " + distribuidor.GetProvincia() + " Telefono: " + distribuidor.GetTelefono1() + " Codigo: " + distribuidor.Getcodigo());

            listadistribuidor.Add(distribuidor);
            list_distribuidor.Items.Add(distribuidor.GetNombre());
            //listadistribuidor.Sort();
            
            txt_nombreAñadir.Text = "";
        }

        /// <summary>
        /// Funciona creando un objeto distribuidor y cliente darle sus datos introducidos y eliminandolo de las listas y del listbox, despúes se restablece el textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Eliminar_Click(object sender, RoutedEventArgs e)
        {
            if (txt_nombreEliminar.Text == "")
                MessageBox.Show("Rellena los campos");
            else if (rb_cliente4.IsChecked == false && rb_distribuidor4.IsChecked == false)
                 MessageBox.Show("Rellena los campos");
            else
            {
                if (rb_cliente4.IsChecked == true)
                {
                    Cliente cliente = new Cliente(txt_nombreEliminar.Text);
                    list_cliente.Items.Remove(cliente.GetNombre());
                    listacliente.Remove(cliente);
                    //listacliente.Sort();
                }
                else if (rb_distribuidor4.IsChecked == true)
                {
                    Distribuidor distribuidor = new Distribuidor(txt_nombreEliminar.Text);
                    list_distribuidor.Items.Remove(distribuidor.GetNombre());
                    listadistribuidor.Remove(distribuidor);
                    //listadistribuidor.Sort();
                }
            }
            txt_nombreEliminar.Text = "";
        }

        /// <summary>
        /// Funciona creando un objeto distribuidor y cliente darle sus datos introducidos y eliminando de las listas y del listbox e insertandolo despúes, se restablece el textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Modificar_Click(object sender, RoutedEventArgs e)
        {
            if (txt_nombreModificar.Text == "" || txt_nombreModificar_2.Text == "")
                MessageBox.Show("Rellena los campos");
            else if (rb_cliente3.IsChecked == false && rb_distribuidor3.IsChecked == false)
                MessageBox.Show("Rellena los campos");
            else
            {
                if (rb_cliente3.IsChecked == true)
                {
                    Cliente cliente = new Cliente(txt_nombreModificar_2.Text);

                    var indice = list_cliente.Items.IndexOf(txt_nombreModificar.Text);
                    list_cliente.Items.RemoveAt(indice);
                    list_cliente.Items.Insert(indice, cliente.GetNombre());

                    listacliente.RemoveAt(indice);
                    listacliente.Insert(indice, cliente);
                    //listacliente.Sort();
                }
                else if (rb_distribuidor3.IsChecked == true)
                {
                    Distribuidor distribuidor = new Distribuidor(txt_nombreModificar_2.Text);

                    var indice = list_distribuidor.Items.IndexOf(txt_nombreModificar.Text);
                    list_distribuidor.Items.RemoveAt(indice);
                    list_distribuidor.Items.Insert(indice, distribuidor.GetNombre());

                    listadistribuidor.RemoveAt(indice);
                    listadistribuidor.Insert(indice, distribuidor);
                    //listadistribuidor.Sort();
                }
            }
            txt_nombreModificar.Text = txt_nombreModificar_2.Text = "";
        }

        /// <summary>
        /// Funciona para generar un archivo de clientes y otro de distribuidores desde lo almacenado en las listas de clientes y distribuidores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_generar_Click(object sender, RoutedEventArgs e)
        {
            nombre = "Cliente.txt";

            if (!File.Exists(nombre))
            {
                Escritura = File.CreateText(nombre);
                foreach (Cliente item in listacliente)
                {
                    Escritura.WriteLine(item.GetNombre() + " " + item.GetPrimerApellido() + " " + item.GetCorreo() + " " + item.GetDirrecion() +
                 " " + item.GetProvincia() + " " + item.GetTelefono1() + " " + item.Getcodigo());
                }
                Escritura.Close();
            }
            else
            {
                File.Delete(nombre);
                Escritura = File.AppendText(nombre);
                foreach (Cliente item in listacliente)
                {
                    Escritura.WriteLine(item.GetNombre() + " " + item.GetPrimerApellido() + " " + item.GetCorreo() + " " + item.GetDirrecion() +
                " " + item.GetProvincia() + " " + item.GetTelefono1() + " " + item.Getcodigo());
                }
                Escritura.Close();
            }

            nombre = "Distribuidor.txt";

            if (!File.Exists(nombre))
            {
                Escritura = File.CreateText(nombre);
                foreach (Distribuidor item in listadistribuidor)
                {
                    Escritura.WriteLine(item.GetNombre() + " " + item.GetPrimerApellido() + " " + item.GetCorreo() + " " + item.GetDirrecion() +
                " " + item.GetProvincia() + " " + item.GetTelefono1() + " " + item.Getcodigo());
                }
                Escritura.Close();
            }
            else
            {
                    
                 File.Delete(nombre);
                 Escritura = File.AppendText(nombre);
                 foreach (Distribuidor item in listadistribuidor)
                 {
                     Escritura.WriteLine(item.GetNombre() + " " + item.GetPrimerApellido() + " " + item.GetCorreo() + " " + item.GetDirrecion() +
                 " " + item.GetProvincia() + " " + item.GetTelefono1() + " " + item.Getcodigo());
                 }
                 Escritura.Close();
            }
        }
    }
}