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
using System.IO;

namespace Practica5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary> 
    //----------------------------------------
    // David Piñuel Bosque
    // Curso DAM
    // Modalidad Presencial
    // Práctica nº 5
    // ---------------------------------------

    public partial class MainWindow : Window
    {
        // Variables Globales

        List<Cliente> ListaCliente = new List<Cliente>();
        public static int num = 0;
        public static StreamWriter Escritura;
        public static StreamReader Lectura;
        public static string nombre;
        public static string nombre_cliente;
        public static string apellido_cliente;
        public static string provincia_cliente;
        public static Cliente Cliente;
        public static string texto;

        public MainWindow()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Inicialización de la ventana" + MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Cierra el programa/ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click(object sender, RoutedEventArgs e) 
        { 
            Close(); 
        }

        /// <summary>
        /// Visibilidad de los tabcontrol dependiendo que queremos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                tb_fomulario.Visibility = Visibility.Hidden;
                tb_datos.Visibility = Visibility.Hidden;
            }
            catch (Exception)
            {
                MessageBox.Show("Error visibilidad" + MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Visibilidad de los tabcontrol dependiendo que queremos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            try 
            {
                tb_fomulario.Visibility = Visibility.Visible;
                tb_datos.Visibility = Visibility.Hidden;
            }
            catch (Exception)
            {
                MessageBox.Show("Error visibilidad" + MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Visibilidad de los tabcontrol dependiendo que queremos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            try
            { 
                tb_datos.Visibility = Visibility.Visible;
                tb_fomulario.Visibility = Visibility.Hidden;
            }
            catch (Exception)
            {
                MessageBox.Show("Error visibilidad" + MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Crear un cliente y mostrarlo en las listas pero si estan rellenos los campos obligatorios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_enviar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_nombre.Text == "")
                    MessageBox.Show("Rellena el campo Nombre", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                else if (txt_primer_apellido.Text == "")
                    MessageBox.Show("Rellena el campo Apellido", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                else if (cbx_provincia.SelectedItem == null)
                    MessageBox.Show("Selecciona la Provincia", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                else
                {
                    try
                    {
                        Cliente = new Cliente(txt_nombre.Text, txt_primer_apellido.Text, cbx_provincia.Text);
                        ListaCliente.Add(Cliente);
                        if (cbx_provincia.Text == "Alicante")
                            list_alicante.Items.Add(Cliente.GetNombre());
                        else if (cbx_provincia.Text == "Valencia")
                            list_valencia.Items.Add(Cliente.GetNombre());
                        else if (cbx_provincia.Text == "Castellon")
                            list_castellon.Items.Add(Cliente.GetNombre());
                        list_cliente.Items.Add(Cliente.GetNombre());
                        MessageBox.Show("Cliente Creado Correctamente" + MessageBoxResult.OK);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error: Creación cliente" + MessageBoxImage.Warning);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Envio de datos" + MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Resetear los campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancelar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (tb_formulario_formulario.IsSelected == true)
                {
                    txt_nombre.Text = txt_primer_apellido.Text = cbx_provincia.Text = "";
                }
                else if (tb_formulario_añadir.IsSelected == true)
                {
                    txt_nombre_añadir.Text = txt_primer_apellido_añadir.Text = cbx_provincia_añadir.Text = cbx_ficheros_añadir.Text = "";
                }
                else if (tb_formulario_modificar.IsSelected == true)
                {
                    txt_nombre_modificar.Text = cbx_ficheros_modificar.Text = "";
                }
                else if (tb_formulario_eliminar.IsSelected == true)
                {
                    txt_nombre_eliminar.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Reseteo del formulario" + MessageBoxImage.Warning);
            }
        }

        /// <summary>
        /// Escritura de los ficheros para crear y escribir los datos de los clientes en los ficheros correspondientes
        /// Y lectura de los ficheros para saber si estan vacios eliminarlos
        /// </summary>
        public void EscrituraFicheros()
        {
            try
            {
                nombre = "Cliente.txt";

                if (!File.Exists(nombre))
                {
                    
                    Escritura = File.CreateText(nombre);
                    foreach (Cliente item in ListaCliente)
                    {
                        Escritura.WriteLine(item.GetNombre() + "#" + item.GetApellido() + "#" + item.GetProvincia());
                    }
                    Escritura.Close();
                    if (ListaCliente.Count == 0)
                    {
                        File.Delete(nombre);
                    }
                }
                else
                {
                    File.Delete(nombre);
                    Escritura = File.AppendText(nombre);
                    foreach (Cliente item in ListaCliente)
                    {
                        Escritura.WriteLine(item.GetNombre() + "#" + item.GetApellido() + "#" + item.GetProvincia());
                    }
                    Escritura.Close();
                    if (ListaCliente.Count == 0)
                    {
                        File.Delete(nombre);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Escritura/Lectura del Fichero" + MessageBoxImage.Error);
            }

            nombre = "Alicante.txt";

            try
            {
                if (!File.Exists(nombre))
                {
                    Escritura = File.CreateText(nombre);
                    foreach (Cliente item in ListaCliente)
                    {
                        if (item.GetProvincia() == "Alicante")
                            Escritura.WriteLine(item.GetNombre() + " " + item.GetApellido());
                    }
                    Escritura.Close();
                    Lectura = File.OpenText(nombre);
                    if (Lectura.ReadLine() == null)
                    {
                        Lectura.Close();
                        File.Delete(nombre);
                    }
                    if (list_alicante.Items.Count == 0)
                    {
                        File.Delete(nombre);
                    }
                }
                else
                {
                    File.Delete(nombre);
                    Escritura = File.AppendText(nombre);
                    foreach (Cliente item in ListaCliente)
                    {
                        if (item.GetProvincia() == "Alicante")
                            Escritura.WriteLine(item.GetNombre() + " " + item.GetApellido());
                    }
                    Escritura.Close();
                    Lectura = File.OpenText(nombre);
                    if (Lectura.ReadLine() == null)
                    {
                        Lectura.Close();
                        File.Delete(nombre);
                    }
                    if (list_alicante.Items.Count == 0)
                    {
                        File.Delete(nombre);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Escritura/Lectura del Fichero" + MessageBoxImage.Error);
            }

            try
            {
                nombre = "Valencia.txt";

                if (!File.Exists(nombre))
                {
                    Escritura = File.CreateText(nombre);
                    foreach (Cliente item in ListaCliente)
                    {
                        if (item.GetProvincia() == "Valencia")
                            Escritura.WriteLine(item.GetNombre() + " " + item.GetApellido());
                    }
                    Escritura.Close();
                    Lectura = File.OpenText(nombre);
                    if (Lectura.ReadLine() == null)
                    {
                        Lectura.Close();
                        File.Delete(nombre);
                    }
                    if (list_valencia.Items.Count == 0)
                    {
                        File.Delete(nombre);
                    }
                }
                else
                {
                    File.Delete(nombre);
                    Escritura = File.AppendText(nombre);
                    foreach (Cliente item in ListaCliente)
                    {
                        if (item.GetProvincia() == "Valencia")
                            Escritura.WriteLine(item.GetNombre() + " " + item.GetApellido());
                    }
                    Escritura.Close();
                    Lectura = File.OpenText(nombre);
                    if (Lectura.ReadLine() == null)
                    {
                        Lectura.Close();
                        File.Delete(nombre);
                    }
                    if (list_valencia.Items.Count == 0)
                    {
                        File.Delete(nombre);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Escritura/Lectura del Fichero" + MessageBoxImage.Error);
            }


            try
            {
                nombre = "Castellon.txt";

                if (!File.Exists(nombre))
                {
                    Escritura = File.CreateText(nombre);
                    foreach (Cliente item in ListaCliente)
                    {
                        if (item.GetProvincia() == "Castellon")
                            Escritura.WriteLine(item.GetNombre() + " " + item.GetApellido());
                    }
                    Escritura.Close();
                    Lectura = File.OpenText(nombre);
                    if (Lectura.ReadLine() == null)
                    {
                        Lectura.Close();
                        File.Delete(nombre);
                    }
                    if (list_castellon.Items.Count == 0)
                    {
                        File.Delete(nombre);
                    }
                }
                else
                {
                    File.Delete(nombre);
                    Escritura = File.AppendText(nombre);
                    foreach (Cliente item in ListaCliente)
                    {
                        if (item.GetProvincia() == "Castellon")
                            Escritura.WriteLine(item.GetNombre() + " " + item.GetApellido());
                    }
                    Escritura.Close();
                    Lectura = File.OpenText(nombre);
                    if (Lectura.ReadLine() == null)
                    {
                        Lectura.Close();
                        File.Delete(nombre);
                    }
                    if (list_castellon.Items.Count == 0)
                    {
                        File.Delete(nombre);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Escritura/Lectura del Fichero" + MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Generar los ficheros correspondientes dependiendo de los clientes que hayan se crearan unos y otros no
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_generar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                EscrituraFicheros();
                MessageBox.Show("Ficheros Generados Correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Generación de los ficheros" + MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Mostrar los datos del cliente seleccionado en las listas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void list_cliente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ListBox lb = (ListBox)sender;
                Cliente Cliente1 = ListaCliente[lb.SelectedIndex];

                lbl_cliente_mostrar.Content = "Cliente: \nNombre: " + Cliente1.GetNombre() + " Primer Apellido: " + Cliente1.GetApellido() + " Provincia: " + Cliente1.GetProvincia();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Listas cliente" + MessageBoxImage.Warning);
            }
        }

        /// <summary>
        /// Añadir/Crear un cliente y mostrarlo en las listas correspondientes pero si estan rellenos los campos obligatorios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_añadir_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_nombre_añadir.Text == "")
                    MessageBox.Show("Rellena el campo Nombre", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                else if (txt_primer_apellido_añadir.Text == "")
                    MessageBox.Show("Rellena el campo Apellido", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                else if (cbx_provincia_añadir.SelectedItem == null)
                    MessageBox.Show("Selecciona la Provincia", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                else if (cbx_ficheros_añadir.SelectedItem == null)
                    MessageBox.Show("Selecciona el fichero", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                else
                {
                    if (cbx_provincia_añadir.Text == "Cliente")
                    {
                        try
                        {
                            Cliente = new Cliente(txt_nombre_añadir.Text, txt_primer_apellido_añadir.Text, cbx_provincia_añadir.Text);
                            ListaCliente.Add(Cliente);
                            list_cliente.Items.Add(Cliente.GetNombre());
                            MessageBox.Show("Cliente Añadido Correctamente");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error: Añadir Cliente" + MessageBoxImage.Error);
                        }
                    }
                    else if (cbx_provincia_añadir.Text == "Alicante")
                    {
                        try
                        {
                            Cliente = new Cliente(txt_nombre_añadir.Text, txt_primer_apellido_añadir.Text, cbx_provincia_añadir.Text);
                            ListaCliente.Add(Cliente);
                            list_cliente.Items.Add(Cliente.GetNombre());
                            list_alicante.Items.Add(Cliente.GetNombre());
                            MessageBox.Show("Cliente Añadido Correctamente");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error: Añadir Cliente" + MessageBoxImage.Error);
                        }
                    }
                    else if (cbx_provincia_añadir.Text == "Valencia")
                    {
                        try
                        {
                            Cliente = new Cliente(txt_nombre_añadir.Text, txt_primer_apellido_añadir.Text, cbx_provincia_añadir.Text);
                            ListaCliente.Add(Cliente);
                            list_valencia.Items.Add(Cliente.GetNombre());
                            list_cliente.Items.Add(Cliente.GetNombre());
                            MessageBox.Show("Cliente Añadido Correctamente");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error: Añadir Cliente" + MessageBoxImage.Error);
                        }
                    }
                    else if (cbx_provincia_añadir.Text == "Castellon")
                    {
                        try
                        {
                            Cliente = new Cliente(txt_nombre_añadir.Text, txt_primer_apellido_añadir.Text, cbx_provincia_añadir.Text);
                            ListaCliente.Add(Cliente);
                            list_castellon.Items.Add(Cliente.GetNombre());
                            list_cliente.Items.Add(Cliente.GetNombre());
                            MessageBox.Show("Cliente Añadido Correctamente");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error: Añadir Cliente" + MessageBoxImage.Error);
                        }
                    }
                }
                txt_nombre_añadir.Text = txt_primer_apellido_añadir.Text = cbx_provincia_añadir.Text = cbx_ficheros_añadir.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Datos Cliente" + MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Eliminar un cliente y quitarlo de las listas correspondientes pero si estan rellenos los campos obligatorios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_eliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_nombre_eliminar.Text == "")
                    MessageBox.Show("Rellena el campo Nombre", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                else if (cbx_ficheros_eliminar.SelectedItem == null)
                    MessageBox.Show("Selecciona el fichero", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                else
                {
                    if (cbx_ficheros_eliminar.Text == "Cliente.txt")
                    {
                        try
                        {
                            Cliente cliente = new Cliente(txt_nombre_eliminar.Text, Cliente.GetApellido(), Cliente.GetProvincia());
                            list_cliente.Items.Remove(cliente.GetNombre());
                            ListaCliente.Remove(cliente);
                            MessageBox.Show("Cliente Eliminado Correctamente");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error: Eliminación Cliente" + MessageBoxImage.Warning);
                        }
                    }
                    else if (cbx_ficheros_eliminar.Text == "Alicante.txt")
                    {
                        try
                        {
                            Cliente cliente = new Cliente(txt_nombre_eliminar.Text, Cliente.GetApellido(), Cliente.GetProvincia());
                            list_cliente.Items.Remove(cliente.GetNombre());
                            list_alicante.Items.Remove(cliente.GetNombre());
                            ListaCliente.Remove(cliente);
                            MessageBox.Show("Cliente Eliminado Correctamente");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error: Eliminación Cliente" + MessageBoxImage.Warning);
                        }
                    }
                    else if (cbx_ficheros_eliminar.Text == "Valencia.txt")
                    {
                        try
                        {
                            Cliente cliente = new Cliente(txt_nombre_eliminar.Text, Cliente.GetApellido(), Cliente.GetProvincia());
                            list_cliente.Items.Remove(cliente.GetNombre());
                            list_valencia.Items.Remove(cliente.GetNombre());
                            ListaCliente.Remove(cliente);
                            MessageBox.Show("Cliente Eliminado Correctamente");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error: Eliminación Cliente" + MessageBoxImage.Warning);
                        }
                    }
                    else if (cbx_ficheros_eliminar.Text == "Castellon.txt")
                    {
                        try
                        {
                            Cliente cliente = new Cliente(txt_nombre_eliminar.Text, Cliente.GetApellido(), Cliente.GetProvincia());
                            list_cliente.Items.Remove(cliente.GetNombre());
                            list_castellon.Items.Remove(cliente.GetNombre());
                            ListaCliente.Remove(cliente);
                            MessageBox.Show("Cliente Eliminado Correctamente");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error: Eliminación Cliente" + MessageBoxImage.Warning);
                        }
                    }
                }
                txt_nombre_eliminar.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Eliminación Cliente" + MessageBoxImage.Warning);
            }
        }

        /// <summary>
        /// Modificar un cliente y mostrarlo en las listas correspondientes pero si estan rellenos los campos obligatorios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_modificar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_nombre_modificar.Text == "" || txt_nombre_modificar_2.Text == "")
                    MessageBox.Show("Rellena los campos");
                else if (cbx_ficheros_modificar.SelectedItem == null)
                    MessageBox.Show("Rellena los campos");
                else
                {
                    if (cbx_ficheros_modificar.Text == "Cliente.txt")
                    {
                        try
                        {
                            Cliente cliente = new Cliente(txt_nombre_modificar_2.Text, Cliente.GetApellido(), Cliente.GetProvincia());

                            var indice = list_cliente.Items.IndexOf(txt_nombre_modificar.Text);
                            list_cliente.Items.RemoveAt(indice);
                            list_cliente.Items.Insert(indice, cliente.GetNombre());

                            ListaCliente.RemoveAt(indice);
                            ListaCliente.Insert(indice, cliente);
                            MessageBox.Show("Cliente Modificado Correctamente");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error: Modificación Cliente" + MessageBoxImage.Error);
                        }
                    }
                    if (cbx_ficheros_modificar.Text == "Alicante.txt")
                    {
                        try
                        {
                            Cliente cliente = new Cliente(txt_nombre_modificar_2.Text);

                            var indice = list_cliente.Items.IndexOf(txt_nombre_modificar.Text);
                            list_cliente.Items.RemoveAt(indice);
                            list_cliente.Items.Insert(indice, cliente.GetNombre());
                            list_alicante.Items.RemoveAt(indice);
                            list_alicante.Items.Insert(indice, cliente.GetNombre());

                            ListaCliente.RemoveAt(indice);
                            ListaCliente.Insert(indice, cliente);
                            MessageBox.Show("Cliente Modificado Correctamente");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error: Modificación Cliente" + MessageBoxImage.Error);
                        }
                    }
                    if (cbx_ficheros_modificar.Text == "Valencia.txt")
                    {
                        try
                        {
                            Cliente cliente = new Cliente(txt_nombre_modificar_2.Text);

                            var indice = list_cliente.Items.IndexOf(txt_nombre_modificar.Text);
                            list_cliente.Items.RemoveAt(indice);
                            list_cliente.Items.Insert(indice, cliente.GetNombre());
                            list_valencia.Items.RemoveAt(indice);
                            list_valencia.Items.Insert(indice, cliente.GetNombre());

                            ListaCliente.RemoveAt(indice);
                            ListaCliente.Insert(indice, cliente);
                            MessageBox.Show("Cliente Modificado Correctamente");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error: Modificación Cliente" + MessageBoxImage.Error);
                        }
                    }
                    if (cbx_ficheros_modificar.Text == "Castellon.txt")
                    {
                        try
                        {
                            Cliente cliente = new Cliente(txt_nombre_modificar_2.Text);

                            var indice = list_cliente.Items.IndexOf(txt_nombre_modificar.Text);
                            list_cliente.Items.RemoveAt(indice);
                            list_cliente.Items.Insert(indice, cliente.GetNombre());
                            list_castellon.Items.RemoveAt(indice);
                            list_castellon.Items.Insert(indice, cliente.GetNombre());

                            ListaCliente.RemoveAt(indice);
                            ListaCliente.Insert(indice, cliente);
                            MessageBox.Show("Cliente Modificado Correctamente");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error: Modificación Cliente" + MessageBoxImage.Error);
                        }
                    }
                }
                txt_nombre_modificar.Text = txt_nombre_modificar_2.Text = cbx_ficheros_modificar.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Modificación Cliente" + MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Mostrar los datos del cliente en alicante seleccionado en las listas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void list_alicante_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ListBox lb = (ListBox)sender;
                Cliente Cliente1 = ListaCliente[lb.SelectedIndex];

                lbl_alicante_mostrar.Content = "Cliente: \nNombre: " + Cliente1.GetNombre() + " Primer Apellido: " + Cliente1.GetApellido();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Listas Alicante" + MessageBoxImage.Warning);
            }
        }

        /// <summary>
        /// Mostrar los datos del cliente en valencia seleccionado en las listas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void list_valencia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ListBox lb = (ListBox)sender;
                Cliente Cliente1 = ListaCliente[lb.SelectedIndex];

                lbl_valencia_mostrar.Content = "Cliente: \nNombre: " + Cliente1.GetNombre() + " Primer Apellido: " + Cliente1.GetApellido();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Listas Valencia" + MessageBoxImage.Warning);
            }
        }

        /// <summary>
        /// Mostrar los datos del cliente en castellon seleccionado en las listas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void list_castellon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ListBox lb = (ListBox)sender;
                Cliente Cliente1 = ListaCliente[lb.SelectedIndex];

                lbl_castellon_mostrar.Content = "Cliente: \nNombre: " + Cliente1.GetNombre() + " Primer Apellido: " + Cliente1.GetApellido();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Listas Castellon" + MessageBoxImage.Warning);
            }
        }

        /// <summary>
        /// Borrar fichero alicante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Borrar_fichero_alicante_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (File.Exists("Alicante.txt"))
                {
                    File.Delete("Alicante.txt");
                    MessageBox.Show("Fichero Borrado Correctamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Eliminación fichero");
            }
        }

        /// <summary>
        /// Borrar fichero Valencia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Borrar_fichero_valencia_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (File.Exists("Valencia.txt"))
                {
                    File.Delete("Valencia.txt");
                    MessageBox.Show("Fichero Borrado Correctamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Eliminación fichero");
            }
        }

        /// <summary>
        /// Borrar fichero Castellon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Borrar_fichero_Castellon_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (File.Exists("Castellon.txt"))
                {
                    File.Delete("Castellon.txt");
                    MessageBox.Show("Fichero Borrado Correctamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Eliminación fichero");
            }
        }

        private void btn_guardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                try
                {
                    nombre = "Cliente.txt";

                    if (!File.Exists(nombre))
                    {

                        Escritura = File.AppendText(nombre);
                        foreach (Cliente item in ListaCliente)
                        {
                            Escritura.WriteLine(item.GetNombre() + "#" + item.GetApellido() + "#" + item.GetProvincia());
                        }
                        Escritura.Close();
                        if (ListaCliente.Count == 0)
                        {
                            File.Delete(nombre);
                        }
                    }
                    else
                    {
                        Escritura = File.AppendText(nombre);
                        foreach (Cliente item in ListaCliente)
                        {
                            Escritura.WriteLine(item.GetNombre() + "#" + item.GetApellido() + "#" + item.GetProvincia());
                        }
                        Escritura.Close();
                        if (ListaCliente.Count == 0)
                        {
                            File.Delete(nombre);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Escritura/Lectura del Fichero" + MessageBoxImage.Error);
                }

                nombre = "Alicante.txt";

                try
                {
                    if (!File.Exists(nombre))
                    {
                        Escritura = File.AppendText(nombre);
                        foreach (Cliente item in ListaCliente)
                        {
                            if (item.GetProvincia() == "Alicante")
                                Escritura.WriteLine(item.GetNombre() + " " + item.GetApellido());
                        }
                        Escritura.Close();
                        Lectura = File.OpenText(nombre);
                        if (Lectura.ReadLine() == null)
                        {
                            Lectura.Close();
                            File.Delete(nombre);
                        }
                        if (list_alicante.Items.Count == 0)
                        {
                            File.Delete(nombre);
                        }
                    }
                    else
                    {
                        Escritura = File.AppendText(nombre);
                        foreach (Cliente item in ListaCliente)
                        {
                            if (item.GetProvincia() == "Alicante")
                                Escritura.WriteLine(item.GetNombre() + " " + item.GetApellido());
                        }
                        Escritura.Close();
                        Lectura = File.OpenText(nombre);
                        if (Lectura.ReadLine() == null)
                        {
                            Lectura.Close();
                            File.Delete(nombre);
                        }
                        if (list_alicante.Items.Count == 0)
                        {
                            File.Delete(nombre);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Escritura/Lectura del Fichero" + MessageBoxImage.Error);
                }

                try
                {
                    nombre = "Valencia.txt";

                    if (!File.Exists(nombre))
                    {
                        Escritura = File.AppendText(nombre);
                        foreach (Cliente item in ListaCliente)
                        {
                            if (item.GetProvincia() == "Valencia")
                                Escritura.WriteLine(item.GetNombre() + " " + item.GetApellido());
                        }
                        Escritura.Close();
                        Lectura = File.OpenText(nombre);
                        if (Lectura.ReadLine() == null)
                        {
                            Lectura.Close();
                            File.Delete(nombre);
                        }
                        if (list_valencia.Items.Count == 0)
                        {
                            File.Delete(nombre);
                        }
                    }
                    else
                    {
                        Escritura = File.AppendText(nombre);
                        foreach (Cliente item in ListaCliente)
                        {
                            if (item.GetProvincia() == "Valencia")
                                Escritura.WriteLine(item.GetNombre() + " " + item.GetApellido());
                        }
                        Escritura.Close();
                        Lectura = File.OpenText(nombre);
                        if (Lectura.ReadLine() == null)
                        {
                            Lectura.Close();
                            File.Delete(nombre);
                        }
                        if (list_valencia.Items.Count == 0)
                        {
                            File.Delete(nombre);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Escritura/Lectura del Fichero" + MessageBoxImage.Error);
                }


                try
                {
                    nombre = "Castellon.txt";

                    if (!File.Exists(nombre))
                    {
                        Escritura = File.AppendText(nombre);
                        foreach (Cliente item in ListaCliente)
                        {
                            if (item.GetProvincia() == "Castellon")
                                Escritura.WriteLine(item.GetNombre() + " " + item.GetApellido());
                        }
                        Escritura.Close();
                        Lectura = File.OpenText(nombre);
                        if (Lectura.ReadLine() == null)
                        {
                            Lectura.Close();
                            File.Delete(nombre);
                        }
                        if (list_castellon.Items.Count == 0)
                        {
                            File.Delete(nombre);
                        }
                    }
                    else
                    {
                        Escritura = File.AppendText(nombre);
                        foreach (Cliente item in ListaCliente)
                        {
                            if (item.GetProvincia() == "Castellon")
                                Escritura.WriteLine(item.GetNombre() + " " + item.GetApellido());
                        }
                        Escritura.Close();
                        Lectura = File.OpenText(nombre);
                        if (Lectura.ReadLine() == null)
                        {
                            Lectura.Close();
                            File.Delete(nombre);
                        }
                        if (list_castellon.Items.Count == 0)
                        {
                            File.Delete(nombre);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Escritura/Lectura del Fichero" + MessageBoxImage.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Ficheros no guardados" + MessageBoxImage.Error);
            }
        }
    }
}