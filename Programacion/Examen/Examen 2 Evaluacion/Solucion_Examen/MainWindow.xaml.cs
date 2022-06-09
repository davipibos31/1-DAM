using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace Examen2Solucion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Variable global que almacena mis Clientes
        public static List<Cliente> clientes = new List<Cliente>();
        
        //Variable global que almacena mis Distribuidores
        public static List<Distribuidor> distribuidores = new List<Distribuidor>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Number_Validation(object sender, TextCompositionEventArgs e)
        {
            //Convertimos el caracter introducido a char
            char c = Convert.ToChar(e.Text);

            //Comprobamos si está dentro del rango de 0 - 9 para saber si
            //hay que bloquear su escritura.
            e.Handled = c < '0' || c > '9';
        }

        // Función asociada al check de Cliente que muestra el Desplegable
        private void rbCliente_Checked(object sender, RoutedEventArgs e)
        {
            cbProvincia.Visibility = Visibility.Visible;
            lbProvincia.Visibility = Visibility.Hidden;
        }

        // Función asociada al check de Distribuidor que muestra la Lista
        private void rbDistribuidor_Checked(object sender, RoutedEventArgs e)
        {
            lbProvincia.Visibility = Visibility.Visible;
            cbProvincia.Visibility = Visibility.Hidden;
        }

        // Función asociada al evento Click del botón Cancelar
        // que cierra el programa
        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        // Función asociada al evento Click del botón Enviar
        // que comprueba los datos, crea los objetos y añade la información
        // para que pueda ser vista en al interfaz.
        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
            if (txtNombre.Text == "")
                MessageBox.Show("Rellena el campo Nombre", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else if (txtApellido.Text == "")
                MessageBox.Show("Rellena el campo Apellido", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else if (rbCliente.IsChecked != true && rbDistribuidor.IsChecked != true)
                MessageBox.Show("Selecciona el Tipo", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else if (txtTelefono1.Text == "")
                MessageBox.Show("Rellena el campo Teléfono 1", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else if (txtTelefono1.Text.Length < 9)
                MessageBox.Show("El Teléfono 1 debe tener 9 dígitos", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else if (txtTelefono2.Text != "" && txtTelefono2.Text.Length < 9)
                MessageBox.Show("Si se rellena, el Teléfono 2 debe tener 9 dígitos", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else if (txtEmail.Text == "")
                MessageBox.Show("Rellena el campo Email", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else if (txtDireccion.Text == "")
                MessageBox.Show("Rellena el campo Dirección", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else if (txtPoblacion.Text == "")
                MessageBox.Show("Rellena el campo Población", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else if (cbProvincia.SelectedItem == null && lbProvincia.SelectedItem == null)
                MessageBox.Show("Selecciona la Provincia", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else
            {
                if (rbCliente.IsChecked == true)
                {
                    Cliente cliente = new Cliente(txtNombre.Text, txtApellido.Text, txtTelefono1.Text, txtTelefono2.Text, txtDireccion.Text, txtEmail.Text, txtPoblacion.Text, cbProvincia.Text);
                    clientes.Add(cliente);
                    AñadirElemento("Cliente", cliente);
                }
                else
                {
                    Distribuidor distribuidor = new Distribuidor(txtNombre.Text, txtApellido.Text, txtTelefono1.Text, txtTelefono2.Text, txtDireccion.Text, txtEmail.Text, txtPoblacion.Text, lbProvincia.SelectedItem.ToString());
                    distribuidores.Add(distribuidor);
                    AñadirElemento("Distribuidor", distribuidor);
                }
            }
        }

        //Función que confirma el elemento creado y reinicia el formulario
        private void ReiniciarFormulario(string tipo)
        {
            if (tipo == "Cliente")
                MessageBox.Show("Se ha dado de alta un nuevo Cliente");
            else
                MessageBox.Show("Se ha dado de alta un nuevo Distribuidor");
            
            txtNombre.Text = txtApellido.Text = "";
            rbCliente.IsChecked = rbDistribuidor.IsChecked = false;
            txtTelefono1.Text = txtTelefono2.Text = "";
            txtEmail.Text = txtDireccion.Text = txtPoblacion.Text = "";
            cbProvincia.SelectedItem = lbProvincia.SelectedItem = null;
            cbProvincia.Visibility = lbProvincia.Visibility = Visibility.Hidden;
        }

        //Función que añade el elemento creado a la lista correspondiente
        private void AñadirElemento(string tipo, Persona p)
        {
            ReiniciarFormulario(tipo);
            
            if (p.GetType().Name == "Cliente")
                lbClientes.Items.Add(((Cliente)p).ToString());
            else
                lbDistribuidor.Items.Add(((Distribuidor)p).ToString());
        }
    }
}
