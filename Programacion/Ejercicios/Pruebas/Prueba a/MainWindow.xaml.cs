using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;                                  // He imprementado en el menu el boton salir y el inicio. En el de salir cierro el programa 
using System.Windows.Media;                                  // y en el de inicio oculto los tabcontrol mostrando el escritorio del programa

namespace Practica_4
{
    // ------------------------------------------------
    // David Piñuel Bosque
    // Curso DAM                                                    
    // Modalidad Presencial
    // Práctica nº 4
    // ------------------------------------------------
    public partial class MainWindow : Window
    {
        public static Cliente[] Clientes = new Cliente[5];
        public static sucursal[] sucursales = new sucursal[5];
        public static sucursal s1 = new sucursal();
        public static Cuenta_Bancaria c1 = new Cuenta_Bancaria();           //Variables y clases globales
        public static Cliente cl1 = new Cliente();
        public static int num = 0;
        public static int num2 = 0;
        public MainWindow()
        {
            InitializeComponent();                          //Inicializa los componentes
        }
        
        private void Mbanc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tcbanco.Visibility = Visibility.Visible;                                //Al hacer click habilita el tabcontrol correcpondiente y oculta el que no es correspondiente
                tcformulario.Visibility = Visibility.Hidden;
            }
            catch (Exception)
            {
                MessageBox.Show("Error visibilidad");
            }
            try
            {
                alta_cliente.Children.Remove(Formulario_cliente());
                alta_sucursal.Children.Remove(Formulario_sucursal());
                alta_cliente.Children.Clear();
                alta_sucursal.Children.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Error formulario");
            }
        }

        private void Mform_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tcformulario.Visibility = Visibility.Visible;
                tcbanco.Visibility = Visibility.Hidden;                                 //Al hacer click habilita el tabcontrol correcpondiente y oculta el que no es correspondiente
            }
            catch (Exception)
            {
                MessageBox.Show("Error visibilidad");
            }
            try
            {
                alta_cliente.Children.Add(Formulario_cliente());
                alta_sucursal.Children.Add(Formulario_sucursal());
            }
            catch (Exception)
            {
                MessageBox.Show("Error formulario");
            }
            try
            {
                list_Cliente.SelectedIndex = -1;
                list_CuentasSucursal.SelectedIndex = -1;
                list_Sucursal.SelectedIndex = -1;
            }
            catch
            {
                MessageBox.Show("Error seleccionamiento");
            }
        }

        private void Msalir_Click(object sender, RoutedEventArgs e)
        {
            Close();                                                               //Al hacer click cierra el programa
        }

        private void Minicio_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tcbanco.Visibility = Visibility.Hidden;
                tcformulario.Visibility = Visibility.Hidden;                          //Al hacer click Vuelve a mostrar el inicio del programa ocultando los items 
            }
            catch (Exception)
            {
                MessageBox.Show("Error visibilidad");
            }
            try
            {
                grid_cliente.Children.Clear();
                grid_Sucursal.Children.Clear();
            }
            catch
            {
                MessageBox.Show("Error borrar elementos");
            }
            try
            {
                list_Cliente.SelectedIndex = -1;
                list_CuentasSucursal.SelectedIndex = -1;
                list_Sucursal.SelectedIndex = -1;
            }
            catch
            {
                MessageBox.Show("Error seleccionamiento");
            }
        }

        public static TextBox txt_nombre;
        public static TextBox txt_primer_apellido;
        public static TextBox txt_dni;
        public static Label lbl_cuenta2;                                    // Variables globales para el formulario cliente
        public static Grid grid_cliente;
        public static ComboBox cbx_sucursal;
        public static Button btn_crear_cliente;
        public Grid Formulario_cliente()
        {
            try
            {
                Label lbl_nombre = new Label();
                lbl_nombre.Content = "Nombre: ";
                lbl_nombre.Width = 70;
                lbl_nombre.Height = 50;
                lbl_nombre.HorizontalAlignment = HorizontalAlignment.Left;
                lbl_nombre.VerticalAlignment = VerticalAlignment.Top;
                lbl_nombre.Margin = new Thickness(24, 47, 0, 0);
                lbl_nombre.Foreground = Brushes.White;


                txt_nombre = new TextBox();
                txt_nombre.Foreground = Brushes.Black;
                txt_nombre.Text = "";
                txt_nombre.Width = 150;
                txt_nombre.Height = 20;
                txt_nombre.VerticalAlignment = VerticalAlignment.Top;
                txt_nombre.HorizontalAlignment = HorizontalAlignment.Left;          //En esta función creo los elementos para trabajar con los datos y los añado en el grid de alta cliente
                txt_nombre.Margin = new Thickness(147, 47, 0, 0);
                txt_nombre.MaxLength = 32;
                txt_nombre.Background = Brushes.LightSalmon;


                Label lbl_primer_apellido = new Label();
                lbl_primer_apellido.Content = "Primer Apellido: ";
                lbl_primer_apellido.Width = 120;
                lbl_primer_apellido.Height = 50;
                lbl_primer_apellido.HorizontalAlignment = HorizontalAlignment.Left;
                lbl_primer_apellido.VerticalAlignment = VerticalAlignment.Top;
                lbl_primer_apellido.Margin = new Thickness(24, 87, 0, 0);
                lbl_primer_apellido.Foreground = Brushes.White;


                txt_primer_apellido = new TextBox();
                txt_primer_apellido.Foreground = Brushes.Black;
                txt_primer_apellido.Text = "";
                txt_primer_apellido.Width = 150;
                txt_primer_apellido.Height = 20;
                txt_primer_apellido.VerticalAlignment = VerticalAlignment.Top;
                txt_primer_apellido.HorizontalAlignment = HorizontalAlignment.Left;
                txt_primer_apellido.Margin = new Thickness(147, 90, 0, 0);
                txt_primer_apellido.MaxLength = 32;
                txt_primer_apellido.Background = Brushes.LightSalmon;


                Label lbl_dni = new Label();
                lbl_dni.Content = "DNI: ";
                lbl_dni.Width = 120;
                lbl_dni.Height = 50;
                lbl_dni.HorizontalAlignment = HorizontalAlignment.Left;
                lbl_dni.VerticalAlignment = VerticalAlignment.Top;
                lbl_dni.Margin = new Thickness(24, 127, 0, 0);
                lbl_dni.Foreground = Brushes.White;


                txt_dni = new TextBox();
                txt_dni.Foreground = Brushes.Black;
                txt_dni.Text = "";
                txt_dni.Width = 150;
                txt_dni.Height = 20;
                txt_dni.VerticalAlignment = VerticalAlignment.Top;
                txt_dni.HorizontalAlignment = HorizontalAlignment.Left;
                txt_dni.Margin = new Thickness(147, 133, 0, 0);
                txt_dni.MaxLength = 8;
                txt_dni.Background = Brushes.LightSalmon;
                txt_dni.KeyDown += KeyDown2;


                Label lbl_cuenta = new Label();
                lbl_cuenta.Content = "Cuenta: ";
                lbl_cuenta.Width = 120;
                lbl_cuenta.Height = 50;
                lbl_cuenta.HorizontalAlignment = HorizontalAlignment.Left;
                lbl_cuenta.VerticalAlignment = VerticalAlignment.Top;
                lbl_cuenta.Margin = new Thickness(24, 167, 0, 0);
                lbl_cuenta.Foreground = Brushes.White;


                lbl_cuenta2 = new Label();
                lbl_cuenta2.Foreground = Brushes.Black;
                try
                {
                    lbl_cuenta2.Content = c1.Aleatorio();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error generar codigo");
                }
                lbl_cuenta2.Width = 120;
                lbl_cuenta2.Height = 50;
                lbl_cuenta2.VerticalAlignment = VerticalAlignment.Top;
                lbl_cuenta2.HorizontalAlignment = HorizontalAlignment.Left;
                lbl_cuenta2.Margin = new Thickness(147, 176, 0, 0);
                lbl_cuenta2.Foreground = Brushes.LightSalmon;


                Label lbl_sucursal = new Label();
                lbl_sucursal.Content = "Sucursal: ";
                lbl_sucursal.Width = 120;
                lbl_sucursal.Height = 50;
                lbl_sucursal.HorizontalAlignment = HorizontalAlignment.Left;
                lbl_sucursal.VerticalAlignment = VerticalAlignment.Top;
                lbl_sucursal.Margin = new Thickness(24, 197, 0, 0);
                lbl_sucursal.Foreground = Brushes.White;


                cbx_sucursal = new ComboBox();
                cbx_sucursal.Height = 20;
                cbx_sucursal.Width = 100;
                cbx_sucursal.VerticalAlignment = VerticalAlignment.Top;
                cbx_sucursal.HorizontalAlignment = HorizontalAlignment.Left;
                cbx_sucursal.Margin = new Thickness(147, 206, 0, 0);
              

                btn_crear_cliente = new Button();
                btn_crear_cliente.Click += btn_crear_cliente_Click;
                btn_crear_cliente.Content = "Crear Cliente";
                btn_crear_cliente.Margin = new Thickness(556,220,0,0);
                btn_crear_cliente.VerticalAlignment = VerticalAlignment.Top;
                btn_crear_cliente.HorizontalAlignment = HorizontalAlignment.Left;
                btn_crear_cliente.Width = 81;
                btn_crear_cliente.Height = 25;
                btn_crear_cliente.Name = "btn_crear_cliente";


                grid_cliente = new Grid();
                grid_cliente.Children.Add(lbl_nombre);
                grid_cliente.Children.Add(txt_nombre);
                grid_cliente.Children.Add(lbl_primer_apellido);
                grid_cliente.Children.Add(txt_primer_apellido);
                grid_cliente.Children.Add(lbl_dni);
                grid_cliente.Children.Add(txt_dni);
                grid_cliente.Children.Add(lbl_cuenta);
                grid_cliente.Children.Add(lbl_cuenta2);
                grid_cliente.Children.Add(lbl_sucursal);
                grid_cliente.Children.Add(cbx_sucursal);
                grid_cliente.Children.Add(btn_crear_cliente);
            }
            catch (Exception)
            {
                MessageBox.Show("Error creación fomulario");
            }
            return grid_cliente;
        }
      
        public static TextBox txt_codigo_postal;
        public static ComboBox cbx_ubicacion;
        public static ComboBox cbx_ciudad;                          //Variables globales para el formulario sucursal
        public static Label lbl_codigo_aleatorio;
        public static Grid grid_Sucursal;
        public static Button btn_crear_sucursal;

        public void KeyDown2(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                    e.Handled = false;                                                                         //En esta funcion lo que hacemos es que sean solo numeros al teclearlos en el textbox
                else
                    e.Handled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error dato numérico");
            }
        }
        public Grid Formulario_sucursal()
        {
            try
            {
                Label lbl_codigo = new Label();
                lbl_codigo.Content = "Código: ";
                lbl_codigo.Width = 120;
                lbl_codigo.Height = 50;
                lbl_codigo.HorizontalAlignment = HorizontalAlignment.Left;
                lbl_codigo.VerticalAlignment = VerticalAlignment.Top;
                lbl_codigo.Margin = new Thickness(24, 47, 0, 0);
                lbl_codigo.Foreground = Brushes.White;


                lbl_codigo_aleatorio = new Label();
                try
                {
                    lbl_codigo_aleatorio.Content = s1.GetCodigo2();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error generar codigo");
                }
                lbl_codigo_aleatorio.Width = 120;
                lbl_codigo_aleatorio.Height = 50;
                lbl_codigo_aleatorio.HorizontalAlignment = HorizontalAlignment.Left;           //En esta función creo los elementos para trabajar con los datos y los añado en el grid de alta sucursal
                lbl_codigo_aleatorio.VerticalAlignment = VerticalAlignment.Top;
                lbl_codigo_aleatorio.Margin = new Thickness(147, 47, 0, 0);
                lbl_codigo_aleatorio.Foreground = Brushes.LightSalmon;
                

                Label lbl_ciudad = new Label();
                lbl_ciudad.Content = "Ciudad: ";
                lbl_ciudad.Width = 150;
                lbl_ciudad.Height = 50;
                lbl_ciudad.HorizontalAlignment = HorizontalAlignment.Left;
                lbl_ciudad.VerticalAlignment = VerticalAlignment.Top;
                lbl_ciudad.Margin = new Thickness(24, 87, 0, 0);
                lbl_ciudad.Foreground = Brushes.White;


                cbx_ciudad = new ComboBox();
                cbx_ciudad.Items.Clear();
                cbx_ciudad.Height = 20;
                cbx_ciudad.Width = 100;
                cbx_ciudad.VerticalAlignment = VerticalAlignment.Top;
                cbx_ciudad.HorizontalAlignment = HorizontalAlignment.Left;
                cbx_ciudad.Margin = new Thickness(147, 90, 0, 0);
                cbx_ciudad.Items.Add("Alicante");
                cbx_ciudad.Items.Add("Elche");
                cbx_ciudad.Items.Add("Elda");


                Label lbl_ubicacion = new Label();
                lbl_ubicacion.Content = "Ubicación: ";
                lbl_ubicacion.Width = 150;
                lbl_ubicacion.Height = 50;
                lbl_ubicacion.HorizontalAlignment = HorizontalAlignment.Left;
                lbl_ubicacion.VerticalAlignment = VerticalAlignment.Top;
                lbl_ubicacion.Margin = new Thickness(24, 127, 0, 0);
                lbl_ubicacion.Foreground = Brushes.White;


                cbx_ubicacion = new ComboBox();
                cbx_ubicacion.Items.Clear();
                cbx_ubicacion.Height = 20;
                cbx_ubicacion.Width = 100;
                cbx_ubicacion.VerticalAlignment = VerticalAlignment.Top;
                cbx_ubicacion.HorizontalAlignment = HorizontalAlignment.Left;
                cbx_ubicacion.Margin = new Thickness(147, 133, 0, 0);
                cbx_ubicacion.Items.Add("Alicante");
                cbx_ubicacion.Items.Add("Castellón");
                cbx_ubicacion.Items.Add("Valencia");


                Label lbl_codigo_postal = new Label();
                lbl_codigo_postal.Content = "CP: ";
                lbl_codigo_postal.Width = 120;
                lbl_codigo_postal.Height = 50;
                lbl_codigo_postal.HorizontalAlignment = HorizontalAlignment.Left;
                lbl_codigo_postal.VerticalAlignment = VerticalAlignment.Top;
                lbl_codigo_postal.Margin = new Thickness(24, 167, 0, 0);
                lbl_codigo_postal.Foreground = Brushes.White;


                txt_codigo_postal = new TextBox();
                txt_codigo_postal.Foreground = Brushes.Black;
                txt_codigo_postal.Text = "";
                txt_codigo_postal.Width = 150;
                txt_codigo_postal.Height = 20;
                txt_codigo_postal.VerticalAlignment = VerticalAlignment.Top;
                txt_codigo_postal.HorizontalAlignment = HorizontalAlignment.Left;
                txt_codigo_postal.Margin = new Thickness(147, 176, 0, 0);
                txt_codigo_postal.MaxLength = 5;
                txt_codigo_postal.Background = Brushes.LightSalmon;
                txt_codigo_postal.KeyDown += KeyDown2;


                btn_crear_sucursal = new Button();
                btn_crear_sucursal.Click += btn_crear_sucursal_Click;
                btn_crear_sucursal.Content = "Crear Sucursal";
                btn_crear_sucursal.Margin = new Thickness(556, 220, 0, 0);
                btn_crear_sucursal.VerticalAlignment = VerticalAlignment.Top;
                btn_crear_sucursal.HorizontalAlignment = HorizontalAlignment.Left;
                btn_crear_sucursal.Width = 81;
                btn_crear_sucursal.Height = 25;
                btn_crear_sucursal.Name = "btn_crear_sucursal";


                grid_Sucursal = new Grid();
                grid_Sucursal.Children.Add(lbl_codigo);
                grid_Sucursal.Children.Add(lbl_codigo_aleatorio);
                grid_Sucursal.Children.Add(lbl_ciudad);
                grid_Sucursal.Children.Add(cbx_ciudad);
                grid_Sucursal.Children.Add(lbl_ubicacion);
                grid_Sucursal.Children.Add(cbx_ubicacion);
                grid_Sucursal.Children.Add(lbl_codigo_postal);
                grid_Sucursal.Children.Add(txt_codigo_postal);
                grid_Sucursal.Children.Add(btn_crear_sucursal);
            }
            catch (Exception)
            {
                MessageBox.Show("Error creación formulario");
            }
            return grid_Sucursal;
        }
        public void btn_crear_cliente_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_nombre.Text == "" || txt_primer_apellido.Text == "" || txt_dni.Text == "" || lbl_cuenta2.Content.ToString() == "")
                {
                    MessageBox.Show("Rellena los campos");
                }
                else
                {
                    Clientes[num] = new Cliente(txt_nombre.Text, txt_primer_apellido.Text, Convert.ToInt32(txt_dni.Text), Convert.ToInt32(lbl_cuenta2.Content.ToString()));
                    MessageBox.Show("Cliente Creado");
                    try
                    {
                        list_Cliente.Items.Add(Clientes[num].GetNombre() + " " + Clientes[num].GetPrimer_apellido());
                    }
                    catch
                    {
                        MessageBox.Show("Error cliente");
                    }
                    try
                    {
                        list_Cuenta_bancaria.Items.Add(Clientes[num].GetCuenta());                      //En esta funcion lo que hago es que si no estan relenos los datos muestre error y si estas que los meta en sus correspondientes listas en el tabcontrol de banco y reseteo los valores
                    }
                    catch
                    {
                        MessageBox.Show("Error sucursal");
                    }
                    num++;
                    try
                    {
                         lbl_cuenta2.Content = c1.Aleatorio();
                         txt_nombre.Text = txt_dni.Text = txt_primer_apellido.Text = "";
                    }
                    catch
                    {
                        MessageBox.Show("Error datos");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error creación cliente");
            }
        }
        public static Cliente cliente_nuevo;
        public static sucursal sucursal_nuevo;                    // Variables globales (clases)
        private void list_Cliente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox lb = (ListBox)sender;
            try
            {
                cliente_nuevo = Clientes[lb.SelectedIndex];
                sucursal_nuevo = sucursales[lb.SelectedIndex];
            }
            catch (Exception)                                                                           //En esta funcion lo que hago es que cuando seleccione un elemento de la lsita aparezcan sus datos
            {
                MessageBox.Show("Selecciona en las listas un cliente o sucursal");
            }
            try
            {
                Label lb1 = new Label();
                try
                {
                    lb1.Content = "Nombre: " + cliente_nuevo.GetNombre() + "; Primer Apellido: " + cliente_nuevo.GetPrimer_apellido() + "; DNI: " + cliente_nuevo.GetDni() + "; Cuenta: " + cliente_nuevo.GetCuenta() + "; Sucursal: " + sucursal_nuevo.GetCodigo();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error datos");
                }

                lb1.Width = 500;
                lb1.Height = 30;
                lb1.Background = Brushes.Brown;
                lb1.HorizontalAlignment = HorizontalAlignment.Left;
                lb1.VerticalAlignment = VerticalAlignment.Top;
                lb1.Margin = new Thickness(206, 16, 0, 0);                              
                lb1.Foreground = Brushes.White;
               
                gcliente.Children.Add(lb1);
                try
                {
                    btn_Ingresar_dinero.Visibility = Visibility.Visible;
                    btn_retirar_dinero.Visibility = Visibility.Visible;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error visibilidad");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error lista seleccionada");
            }
        }
        private void btn_crear_sucursal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (cbx_ubicacion.Text == "" || lbl_codigo_aleatorio.Content.ToString() == "" || cbx_ciudad.Text == "" || txt_codigo_postal.Text == "")
                {
                    MessageBox.Show("Rellena los campos");
                }
                else
                {
                    sucursales[num2] = new sucursal(cbx_ubicacion.Text, Convert.ToInt32(lbl_codigo_aleatorio.Content), cbx_ciudad.Text, Convert.ToInt32(txt_codigo_postal.Text));
                    MessageBox.Show("Sucursal Creada");
                    try
                    {
                        list_Sucursal.Items.Add(sucursales[num2].GetCodigo());
                        cbx_sucursal.Items.Add(sucursales[num2].GetCodigo());
                    }                                                                                                   //En esta funcion lo que hago es que si no estan relenos los datos muestre error y si estas que los meta en sus correspondientes listas en el tabcontrol de banco y reseteo los valores
                    catch (Exception)
                    {
                        MessageBox.Show("Error sucursal");
                    }
                    num2++;
                    try
                    {
                         lbl_codigo_aleatorio.Content = s1.GetCodigo2();
                         cbx_ubicacion.Text = cbx_ciudad.Text = txt_codigo_postal.Text = "";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error datos");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error creación sucursal");
            }
        }
        public static sucursal sucursal_nueva;
        private void list_Sucursal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox lb = (ListBox)sender;
            try
            {
                sucursal_nueva = sucursales[lb.SelectedIndex];
            }
             catch (Exception)
            {
                MessageBox.Show("Selecciona en las listas un cliente o una sucursal");
            }
            try
            {
                Label lb2 = new Label();

                try
                {
                    lb2.Content = "Código: " + sucursal_nueva.GetCodigo() + "; Ubicación: " + sucursal_nueva.GetUbicacion() + "; Ciudad: " + sucursal_nueva.GetCiudad() + "; Código Postal: " + sucursal_nueva.GetCodigo_postal();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error datos");
                }

                lb2.Width = 500;
                lb2.Height = 30;
                lb2.Background = Brushes.Brown;
                lb2.HorizontalAlignment = HorizontalAlignment.Left;
                lb2.VerticalAlignment = VerticalAlignment.Top;                                          //En esta funcion lo que hago es que cuando seleccione un elemento de la lsita aparezcan sus datos
                lb2.Margin = new Thickness(206, 16, 0, 0);
                lb2.Foreground = Brushes.White;

                gsucursal.Children.Add(lb2);
            }
            catch (Exception)
            {
                MessageBox.Show("Error lista seleccionada");
            }
        }

        private void btn_crear_IBAN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sucursal_nueva = sucursales[list_Cliente.SelectedIndex];
                cliente_nuevo = Clientes[list_Cliente.SelectedIndex];
            }
            catch (Exception)
            {
                MessageBox.Show("Selecciona en las listas un cliente o una sucursal");
            }
            try
            {
                Label lb2 = new Label();
                try
                {
                    lb2.Content = "IBAN: " + sucursal_nueva.GetCodigo() + " " + cliente_nuevo.GetCuenta() + " " + cliente_nuevo.GetDni();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error datos");
                }

                lb2.Width = 500;
                lb2.Height = 30;
                lb2.Background = Brushes.Brown;
                lb2.HorizontalAlignment = HorizontalAlignment.Left;                             //En esta funcion lo que hago es que cuando seleccione un elemento de la lsita ceinte aparezcan sus datos formando el IBAN 
                lb2.VerticalAlignment = VerticalAlignment.Top;
                lb2.Margin = new Thickness(206, 56, 0, 0);
                lb2.Foreground = Brushes.White;
                
                gcliente.Children.Add(lb2);
            }
            catch (Exception)
            {
                MessageBox.Show("Error IBAN");
            }
        }
        private void list_Cuenta_bancaria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox lb = (ListBox)sender;
            try
            {
                cliente_nuevo = Clientes[lb.SelectedIndex];
                sucursal_nueva = sucursales[lb.SelectedIndex];
            }
            catch (Exception)
            { 
                MessageBox.Show("Error selección listas cliente o sucursal"); 
            }
            try
            {
                Label lb5 = new Label();
                try
                {
                    lb5.Content = "Nombre: " + cliente_nuevo.GetNombre() + "; Primer Apellido: " + cliente_nuevo.GetPrimer_apellido() + "; Cuenta: " + cliente_nuevo.GetCuenta() + "\n" + "Dinero Disponible: " + cliente_nuevo.GetDinero_disponible() + "; Sucursal Pertenece: " + sucursal_nueva.GetCodigo();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error datos");
                }

                lb5.Width = 500;
                lb5.Height = 50;
                lb5.Background = Brushes.Brown;
                lb5.HorizontalAlignment = HorizontalAlignment.Left;
                lb5.VerticalAlignment = VerticalAlignment.Top;
                lb5.Margin = new Thickness(206, 16, 0, 0);                                                                          //En esta funcion lo que hago es que cuando seleccione un elemento de la lsita aparezcan sus datos
                lb5.Foreground = Brushes.White;
                
                gcuenta_bancaria.Children.Add(lb5);
            }
            catch (Exception)
            {
                MessageBox.Show("Error listas seleccionadas");
            }
        }

        private void btn_cuentas_asociadas_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                list_CuentasSucursal.Visibility = Visibility.Visible;
            }
            catch (Exception)
            {
                MessageBox.Show("Error visibilidad");
            }
            try
            {
                cliente_nuevo = Clientes[list_Sucursal.SelectedIndex];                                           //En esta funcion lo que hago es que muestre en una lista las cuentas asociadas a la sucursal seleccionada
            }
            catch (Exception)
            {
                MessageBox.Show("Error lista seleccionada");
            }
            try
            {
                list_CuentasSucursal.Items.Add(cliente_nuevo.GetCuenta());
            }
            catch (Exception)
            {
                MessageBox.Show("Error cuenta");
            }
        }
        public static Label lbl_Ingresar, lbl_retirar;                    // Variables gobales para ingresar y retirar
        public static TextBox txt_Ingresar_dinero, txt_retirar_dinero;
        private void btn_Ingresar_dinero_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cliente_nuevo = Clientes[list_Cliente.SelectedIndex];
            }
            catch (Exception)
            {
                MessageBox.Show("Error lista selecionada");
            }
            try
            {
                lbl_Ingresar = new Label();
                lbl_Ingresar.Content = "Ingresar: ";
                lbl_Ingresar.VerticalAlignment = VerticalAlignment.Top;
                lbl_Ingresar.HorizontalAlignment = HorizontalAlignment.Left;
                lbl_Ingresar.Margin = new Thickness(261, 178, 0, 0);
                lbl_Ingresar.Foreground = Brushes.White;
                lbl_Ingresar.Width = 500;
                lbl_Ingresar.Height = 30;


                txt_Ingresar_dinero = new TextBox();
                txt_Ingresar_dinero = new TextBox();
                txt_Ingresar_dinero.Foreground = Brushes.Black;
                txt_Ingresar_dinero.Text = "";                                              //En esta funcion creo y muestro los datos para ingresar dinero
                txt_Ingresar_dinero.Width = 150;
                txt_Ingresar_dinero.Height = 20;
                txt_Ingresar_dinero.VerticalAlignment = VerticalAlignment.Top;
                txt_Ingresar_dinero.HorizontalAlignment = HorizontalAlignment.Left;
                txt_Ingresar_dinero.Margin = new Thickness(329, 183, 0, 0);
                txt_Ingresar_dinero.MaxLength = 9;
                txt_Ingresar_dinero.Background = Brushes.LightSalmon;
                txt_Ingresar_dinero.KeyDown += KeyDown2;
                
                gcliente.Children.Add(lbl_Ingresar);
                gcliente.Children.Add(txt_Ingresar_dinero);
            }
            catch (Exception)
            {
                MessageBox.Show("Error ingresar dinero");
            }
            try
            {
                btn_ingresar.Visibility = Visibility.Visible;
                btn_retirar.Visibility = Visibility.Hidden;
            }
            catch (Exception)
            {
                MessageBox.Show("Error visibilidad");
            }
        }
        private void btn_retirar_dinero_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cliente_nuevo = Clientes[list_Cliente.SelectedIndex];
            }
            catch (Exception)
            {
                MessageBox.Show("Error lista seleccionada");
            }
            try
            {
                lbl_retirar = new Label();
                lbl_retirar.Content = "Retirar: ";
                lbl_retirar.VerticalAlignment = VerticalAlignment.Top;
                lbl_retirar.HorizontalAlignment = HorizontalAlignment.Left;
                lbl_retirar.Margin = new Thickness(261, 178, 0, 0);
                lbl_retirar.Foreground = Brushes.White;
                lbl_retirar.Width = 500;
                lbl_retirar.Height = 30;


                txt_retirar_dinero = new TextBox();                                                                 //En esta funcion creo y muestro los datos para retirar dinero
                txt_retirar_dinero.Foreground = Brushes.Black;
                txt_retirar_dinero.Text = "";
                txt_retirar_dinero.Width = 150;
                txt_retirar_dinero.Height = 20;
                txt_retirar_dinero.VerticalAlignment = VerticalAlignment.Top;
                txt_retirar_dinero.HorizontalAlignment = HorizontalAlignment.Left;
                txt_retirar_dinero.Margin = new Thickness(329, 183, 0, 0);
                txt_retirar_dinero.MaxLength = 9;
                txt_retirar_dinero.Background = Brushes.LightSalmon;
                txt_retirar_dinero.KeyDown += KeyDown2;
                
                gcliente.Children.Add(lbl_retirar);
                gcliente.Children.Add(txt_retirar_dinero);
            }
            catch (Exception)
            {
                MessageBox.Show("Error retirar dinero");
            }
            try
            {
                btn_retirar.Visibility = Visibility.Visible;
                btn_ingresar.Visibility = Visibility.Hidden;
            }
            catch (Exception)
            {
                MessageBox.Show("Error visibilidad");
            }
        }
        public static double ing, ret;             //variable global para ingresar
        private void btn_retirar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
             //  ListBox lb = new ListBox();
              // cliente_nuevo = Clientes[lb.SelectedIndex];
            
                ret = Convert.ToDouble(txt_retirar_dinero.Text);
                cliente_nuevo.SetDinero_disponible(ret);                    
                txt_retirar_dinero.Visibility = Visibility.Hidden;
                
              // cliente_nuevo.SetDinero_disponible(-ret);
                MessageBox.Show("Dinero retirado");
            }
            catch (Exception)
            {
                MessageBox.Show("Error retirar dinero");
            }
            try
            {
                lbl_retirar.Visibility = Visibility.Hidden;
                btn_retirar.Visibility = Visibility.Hidden;
            }
            catch (Exception)
            {
                MessageBox.Show("Error de visibilidad");
            }
        }                                                                                                   //en estas dos funciones lo que hago es que cuando se ingrese o se retire se oculte cada elemento para no molestar el funcionamiento del programa y se ejecute en la variable del dinero
        private void btn_ingresar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ing = Convert.ToDouble(txt_Ingresar_dinero.Text);
                cliente_nuevo.SetDinero_disponible(ing);
                txt_Ingresar_dinero.Visibility = Visibility.Hidden;
                MessageBox.Show("Dinero ingresado");
            }
            catch (Exception)
            {
                MessageBox.Show("Error ingresar dinero");
            }
            try
            {
                lbl_Ingresar.Visibility = Visibility.Hidden;
                btn_ingresar.Visibility = Visibility.Hidden;
            }
            catch (Exception)
            {
                MessageBox.Show("Error de visibilidad");
            }
        }
    }                       // He imprementado en el menu el boton salir y el inicio en el de salir cierro el programa y en el de inicio oculto los tabcontrol mostrando el escritorio del programa
}                                           //Espero que te guste Carlos