using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Practica3
{
    // --------------------------------------------
    // David Piñuel Bosque
    // Curso DAM
    // Modalidad Presencial
    // Práctica nº 3
    // --------------------------------------------
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();                                              //Inicializa los componentes
        }

        private void btn_Cancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();                                                            //En esta funcion cierra / termina el programa
        }

        private void rb_cliente_Checked(object sender, RoutedEventArgs e)
        {
            if (rb_cliente.IsChecked == true)
            {
                cbx_cliente.IsEnabled = true;                                   //En esta funcion habilita el combobox para el cliente o distribuidor y lo hace visible
                cbx_cliente.Visibility = Visibility.Visible;
                Borrar();
            }
            
        }

        private void btn_Enviar_Click(object sender, RoutedEventArgs e)         // En esta funcion cuando le das a enviar dependiendo de si es cliente o distribuidor manda un mensaje de insercion sql
        {
            if (rb_cliente.IsChecked == true)
                MessageBox.Show($"INSERT INTO clientes (nombre,primer_apellido,segundo_apellido,poblacion,codigo_postal,direccion,correo_electronico,telefono1,telefono2,provincia) VALUES ({txt_nombre.Text}, {txt_primer_apellido.Text}, {txt_segundo_apellido.Text}, {txt_poblacion.Text}, {txt_codigo_postal.Text}, {txt_direccion.Text}, {txt_correo_electronico.Text}, {txt_telefono1.Text}, {txt_telefono2.Text}, {cbx_cliente.Text.ToString()})", "SQL Inserción");        
            else if (rb_Distribuidor.IsChecked == true)
                MessageBox.Show($"INSERT INTO distribuidores (nombre,primer_apellido,segundo_apellido,poblacion,codigo_postal,direccion,correo_electronico,telefono1,telefono2,provincia) VALUES ({txt_nombre.Text}, {txt_primer_apellido.Text}, {txt_segundo_apellido.Text}, {txt_poblacion.Text}, {txt_codigo_postal.Text}, {txt_direccion.Text}, {txt_correo_electronico.Text}, {txt_telefono1.Text}, {txt_telefono2.Text}, {cbx_cliente.Text.ToString()})", "SQL Inserción");
            barraprogreso();
        }
        public void Borrar()
        {
            cbx_cliente.SelectedIndex = -1;                               // En esta función hago que se borre la selección de cada combobox y la llamo en cada radiobuton
        }
        private void txt_segundo_apellido_TextChanged(object sender, TextChangedEventArgs e)
        {
            txt_segundo_apellido.MaxLength = 32;
            barraprogreso();                                                                      // En esta funcion pondremos solo la longitud que pide para el textbox
        }

        private void txt_telefono2_TextChanged(object sender, TextChangedEventArgs e)
        {
            txt_telefono2.MaxLength = 9;                                                        // En esta funcion pondremos solo la longitud que pide para el textbox
            barraprogreso();
        }

        private void habilitar(object sender, RoutedEventArgs e)
        {

            if (txt_nombre.Text == "")
            {
                btn_Enviar.IsEnabled = false;
            }
            else if (txt_primer_apellido.Text == "")
            {
                btn_Enviar.IsEnabled = false;
            }
            else if (txt_telefono1.Text == "")
            {
                btn_Enviar.IsEnabled = false;             //En estos if lo que hago es que si esta vacio no habilite el boton pero si lo esta que lo habilite
            }
            else if (txt_correo_electronico.Text == "")
            {
                btn_Enviar.IsEnabled = false;
            }
            else if (txt_direccion.Text == "")
            {
                btn_Enviar.IsEnabled = false;
            }
            else if (txt_codigo_postal.Text == "")
            {
                btn_Enviar.IsEnabled = false;
            }
            else if (txt_poblacion.Text == "")
            {
                btn_Enviar.IsEnabled = false;
            }
            else if (rb_cliente.IsChecked == false && rb_Distribuidor.IsChecked == false)
            {
                btn_Enviar.IsEnabled = false;
            }
            else if (cbx_cliente.SelectedIndex == -1)
            {
                btn_Enviar.IsEnabled = false;
            }
            else
            {
                btn_Enviar.IsEnabled = true;
            }
            txt_correo_electronico.MaxLength = 100;
            txt_poblacion.MaxLength = 32;
            txt_direccion.MaxLength = 100;
            txt_codigo_postal.MaxLength = 5;                    // Estas sentencias son las restriciones para los textbox obligatorios 
            txt_telefono1.MaxLength = 9;
            txt_primer_apellido.MaxLength = 32;
            txt_nombre.MaxLength = 32;
           
            if (rb_cliente.IsChecked == true)
            {
                cb7.IsEnabled = true;
                cb7.Visibility = Visibility.Visible;
                cb8.IsEnabled = true;
                cb8.Visibility = Visibility.Visible;
                cb9.IsEnabled = true;
                cb9.Visibility = Visibility.Visible;
                cb10.IsEnabled = true;
                cb10.Visibility = Visibility.Visible;              //Esta sentencia if else if lo que hago es poner las opciones items del combobox dependiendo de si es ciente o distribuidor
                sep1.Visibility = Visibility.Visible;
                sep2.Visibility = Visibility.Visible;
                sep3.Visibility = Visibility.Visible;
                cb4.IsEnabled = true;
                cb5.IsEnabled = true;
                cb6.IsEnabled = true;
            }
            else if (rb_Distribuidor.IsChecked == true)
            {
                cb7.IsEnabled = false;
                cb7.Visibility = Visibility.Hidden;
                cb8.IsEnabled = false;
                cb8.Visibility = Visibility.Hidden;
                cb9.IsEnabled = false;
                cb9.Visibility = Visibility.Hidden;
                cb10.IsEnabled = false;
                cb10.Visibility = Visibility.Hidden;
                sep1.Visibility = Visibility.Hidden;
                sep2.Visibility = Visibility.Hidden;
                sep3.Visibility = Visibility.Hidden;
                cb4.IsEnabled = true;
                cb5.IsEnabled = true;
                cb6.IsEnabled = true;
            }
            barraprogreso();
        }
        private void txt_telefono1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                e.Handled = false;                                  //En esta funcion lo que hacemos es que sean solo numeros al teclearlos en el textbox
            else
                e.Handled = true;
        }

        private void txt_telefono2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                e.Handled = false;                                    //En esta funcion lo que hacemos es que sean solo numeros al teclearlos en el textbox
            else
                e.Handled = true;
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
                pb_Barra.Value++;                           //En esta funcion lo que hacemos es el progreso de la barra conforme vamos rellenando el formulario que es obligatotio
                valor++;
            }
            if (rb_cliente.IsChecked == true || rb_Distribuidor.IsChecked == true)
            {
                pb_Barra.Value++;
                valor++;
            }
            if (txt_telefono1.Text != "")
            {
                pb_Barra.Value++;
                valor++;                                                    //En cada funcion de cada campo obligatorio llamo a esta función
            }
            
            if (txt_poblacion.Text != "")
            {
                pb_Barra.Value++;
                valor++;
            }
            if (txt_direccion.Text != "")
            {
                pb_Barra.Value++;
                valor++;
            }
            if (txt_correo_electronico.Text != "")
            {
                pb_Barra.Value++;
                valor++;
            }
            if (txt_codigo_postal.Text != "")
            {
                pb_Barra.Value++;
                valor++;
            }
            if (cbx_cliente.SelectedIndex != -1)
            {
                pb_Barra.Value++;
                valor++;
            }
            lbl_Barra_progreso.Content = valor + "/9";       //Espero que te haya gustado :)
        }
    }                                     //he puesto una imagen, una la barra de progreso y he añadido los campos completos en la injeccion sql de añadido
}
