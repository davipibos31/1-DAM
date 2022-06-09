using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Media;

namespace Practica4Solucion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int topSucursal = 25; // +65 (90, 155, 220)
        public static int topCliente = 25;
        public static int topCuenta = 25;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void mBanco_Click(object sender, RoutedEventArgs e)
        {
            tcBanco.Visibility = Visibility.Visible;
            tcFormulario.Visibility = Visibility.Hidden;
            
            lblVista.Content = "Banco";
            lblVista.Visibility = Visibility.Visible;
        }

        private void mFormulario_Click(object sender, RoutedEventArgs e)
        {
            tcFormulario.Visibility = Visibility.Visible;
            tcBanco.Visibility = Visibility.Hidden;
            
            lblVista.Content = "Formulario";
            lblVista.Visibility = Visibility.Visible;
        }

        public void AñadirSucursal(Sucursal s)
        {
            Grid g = CrearGrid(topSucursal);
            g.Background = Brushes.AliceBlue;

            g.Children.Add(CrearLabel("Código: " + s.GetCodigo(), 10, 0));
            g.Children.Add(CrearLabel("Ciudad: " + s.GetCiudad(), 125, 0));
            g.Children.Add(CrearLabel("Ubicación: " + s.GetUbicacion(), 10, 25));
            g.Children.Add(CrearLabel("Código Postal: " + s.GetPostal(), 250, 0));
            g.Children.Add(CrearBoton("Cuentas", 250, 25));

            gSucursales.Children.Add(g);
            topSucursal += 65;

            cbSucursales.Items.Add(s.GetCodigo());
        }

        public void AñadirCliente(Cliente c)
        {
            Grid g = CrearGrid(topCliente);
            g.Background = Brushes.Bisque;

            g.Children.Add(CrearLabel("DNI: " + c.GetDni(), 10, 0));
            g.Children.Add(CrearLabel("Nombre: " + c.GetNombre(), 10, 25));
            g.Children.Add(CrearLabel("Cuenta: " + c.GetCodigoCuenta(), 125, 0));
            g.Children.Add(CrearLabel("Apellido: " + c.GetApellido(), 125, 25));
            g.Children.Add(CrearLabel("Sucursal: " + c.GetCodigoSucursal(), 250, 0));
            g.Children.Add(CrearBoton("Operar", 375, 0));
            g.Children.Add(CrearBoton("IBAN", 375, 25));

            gClientes.Children.Add(g);
            topCliente += 65;
        }

        public void AñadirCuenta(Cuenta c)
        {
            Grid g = CrearGrid(topCuenta);
            g.Background = Brushes.PaleGreen;

            g.Children.Add(CrearLabel("Código: " + c.GetCodigo(), 10, 0));
            g.Children.Add(CrearLabel("Sucursal: "+ c.GetCodigoSucursal(), 10, 25));
            g.Children.Add(CrearLabel("Cliente: " + c.GetDniCliente(), 125, 0));
            g.Children.Add(CrearLabel("Dinero: " + c.GetDinero(), 125, 25));

            gCuentas.Children.Add(g);
            topCuenta += 65;
        }

        public Grid CrearGrid(int top)
        {
            Grid g = new Grid();
            g.Width = 600;
            g.Height = 50;
            g.HorizontalAlignment = HorizontalAlignment.Left;
            g.VerticalAlignment = VerticalAlignment.Top;
            g.Margin = new Thickness(25, top, 349, 0);
            return g;
        }

        public Label CrearLabel(string contenido, int left, int top)
        {
            Label lbl = new Label();
            lbl.Content = contenido;
            lbl.HorizontalAlignment = HorizontalAlignment.Left;
            lbl.VerticalAlignment = VerticalAlignment.Top;
            lbl.Margin = new Thickness(left, top, 0, 0);

            return lbl;
        }

        public Button CrearBoton(string contenido, int left, int top)
        {
            Button btn = new Button();
            btn.Content = contenido;
            btn.HorizontalAlignment = HorizontalAlignment.Left;
            btn.VerticalAlignment = VerticalAlignment.Top;
            btn.Margin = new Thickness(left, top, 0, 0);

            if (contenido == "Cuentas")
                btn.Click += MostrarCuentas;
            else if (contenido == "IBAN")
                btn.Click += GenerarIban;
            else
                btn.Click += Operar;

            return btn;
        }

        private void MostrarCuentas(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Grid g = (Grid)btn.Parent;
            Label lbl = (Label)g.Children[0];
            int codigo = Convert.ToInt32(GetDato(lbl.Content.ToString()));

            Cuenta[] cuentas = Sucursal.GetSucursal(codigo).GetCuentas();

            string msg;
            
            if (cuentas.Length > 0)
                msg = "";
            else
                msg = "No hay Cuentas";

            foreach (Cuenta c in cuentas)
                msg += "Cuenta: " + c.GetCodigo() + " Cliente: " + c.GetDniCliente() + "\n";

            MessageBox.Show(msg);
        }

        private void GenerarIban(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Grid g = (Grid)btn.Parent;
            Label lbl = (Label)g.Children[0];
            string dni = GetDato(lbl.Content.ToString());

            MessageBox.Show("IBAN: " + Cliente.GetIban(dni));
        }

        private void Operar(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Grid g = (Grid)btn.Parent;
            Label lbl = (Label)g.Children[0];
            string dni = GetDato(lbl.Content.ToString());

            Cliente c = Cliente.GetCliente(dni);

            gOperar.Visibility = Visibility.Visible;
            lblCuenta.Content = "Cuenta: " + c.GetCodigoCuenta();
            lblDisponible.Content = "Dinero disponible: " + c.GetCuenta().GetDinero();
        }
        
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text != "")
                tb.Background = Brushes.White;
        }

        private void Number_Validation(object sender, TextCompositionEventArgs e)
        {
            char caracter = Convert.ToChar(e.Text);

            if (caracter >= '0' && caracter <= '9')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnCrearSucursal_Click(object sender, RoutedEventArgs e)
        {
            if (txtCiudad.Text == "")
            {
                txtCiudad.Background = Brushes.Red;
                txtCiudad.Focus();
            }
            else if (txtUbicacion.Text == "")
            {
                txtUbicacion.Background = Brushes.Red;
                txtUbicacion.Focus();
            }
            else if (txtPostal.Text == "")
            {
                txtPostal.Background = Brushes.Red;
                txtPostal.Focus();
            }
            else
            {
                if (Sucursal.indice < 2)
                {
                    Sucursal s = new Sucursal(txtCiudad.Text, txtUbicacion.Text, Convert.ToInt32(txtPostal.Text));
                    Sucursal.sucursales[Sucursal.indice++] = s;
                    AñadirSucursal(s);

                    MessageBox.Show("Sucursal creada");
                    txtCiudad.Text = txtUbicacion.Text = txtPostal.Text = "";
                }
                else
                {
                    MessageBox.Show("No se pueden añadir más sucursales");
                }
                
            }
        }

        private void btnCrearCliente_Click(object sender, RoutedEventArgs e)
        {
            if (txtDNI.Text == "")
            {
                txtDNI.Background = Brushes.Red;
                txtDNI.Focus();
            }
            else if (txtNombre.Text == "")
            {
                txtNombre.Background = Brushes.Red;
                txtNombre.Focus();
            }
            else if (txtApellido.Text == "")
            {
                txtApellido.Background = Brushes.Red;
                txtApellido.Focus();
            }
            else if (cbSucursales.SelectedItem == null)
            {
                MessageBox.Show("Selecciona la sucursal. Si no hay, primero crea una.");
            }
            else
            {
                if (Sucursal.sucursales[cbSucursales.SelectedIndex].isComplete())
                    MessageBox.Show("No se pueden añadir más clientes a esa sucursal");
                else
                {
                    Cliente c = new Cliente(txtDNI.Text, txtNombre.Text, txtApellido.Text);
                    Sucursal.sucursales[cbSucursales.SelectedIndex].AñadirCliente(c);
                    AñadirCliente(c);
                    AñadirCuenta(c.GetCuenta());

                    MessageBox.Show("Cliente creado");
                    txtDNI.Text = txtNombre.Text = txtApellido.Text = cbSucursales.Text = "";
                }                
            }
        }
       
        private string GetDato(string dato)
        {
            return dato.Split(": ")[1];
        }

        private void btnRetirar_Click(object sender, RoutedEventArgs e)
        {
            int cantidad = 0;
            Cuenta c = ObtenerCuentaCantidad(ref cantidad);

            int nueva = c.RetirarDinero(cantidad);

            if (nueva == -1)
                MessageBox.Show("No puedes retirar más de lo que tienes");
            else
            {
                MessageBox.Show("Has retirado " + cantidad + "\nLa nueva canitdad es: " + nueva);
                ReiniciarOperar();
            }
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            int cantidad = 0;
            Cuenta c = ObtenerCuentaCantidad(ref cantidad);

            int nueva = c.IngresarDinero(cantidad);

            MessageBox.Show("Has ingresado " + cantidad + "\nLa nueva canitdad es: " + nueva);
            ReiniciarOperar();
        }

        private Cuenta ObtenerCuentaCantidad(ref int cantidad)
        {
            int cuenta = Convert.ToInt32(GetDato(lblCuenta.Content.ToString()));
            cantidad = Convert.ToInt32(txtCantidad.Text);
            Cuenta c = Cuenta.GetCuenta(cuenta);

            return c;
        }

        private void ReiniciarOperar()
        {
            foreach (object cuenta in gCuentas.Children)
            {
                Grid g = (Grid)cuenta;
                Label lblCodigo = (Label)g.Children[0];
                string codigo = GetDato(lblCuenta.Content.ToString());

                if (codigo == GetDato(lblCodigo.Content.ToString()))
                {
                    Label lblDinero = (Label)g.Children[3];
                    lblDinero.Content = "Dinero: " + Cuenta.GetCuenta(Convert.ToInt32(codigo)).GetDinero();
                }
            }

            gOperar.Visibility = Visibility.Hidden;
            lblCuenta.Content = "";
            lblDisponible.Content = "";
            txtCantidad.Text = "";
        }
    }
}
