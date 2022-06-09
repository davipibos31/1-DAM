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
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Examen3Evaluacion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// //
    // David Piñuel Bosque
    // Curso DAM
    // Modalidad Presencial
    // Examen Tercera Evaluación
    public partial class MainWindow : Window
    {
        public static List<Cliente> ListasClientes = new List<Cliente>();
        public static List<Distribuidor> ListasDistribuidor = new List<Distribuidor>();
        public static Cliente clientes;
        public static Distribuidor distribuidores;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, RoutedEventArgs e)
        {
            if (txt_nombre.Text == "")
            {
                MessageBox.Show("Error: Rellena el nombre", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else if (txt_apellido.Text == "")
            {
                MessageBox.Show("Error: Rellena el apellido", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else if (txt_direcion.Text == "")
            {
                MessageBox.Show("Error: Rellena la direccion", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else if (txt_telefono.Text == "")
            {
                MessageBox.Show("Error: Rellena el telefono", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else if (rb_cliente.IsChecked == false && rb_distribuidor.IsChecked == false)
            {
                MessageBox.Show("Error: Selecciona cliente o distribuidor", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                if (rb_cliente.IsChecked == true)
                {
                    clientes = new Cliente(txt_nombre.Text, txt_apellido.Text, Convert.ToInt32(txt_telefono.Text), txt_direcion.Text);
                    ListasClientes.Add(clientes);
                    listbox_cliente.Items.Add(clientes.GetNombre());
                    MessageBox.Show("Cliente creado");
                }
                else if (rb_distribuidor.IsChecked == true)
                {
                    distribuidores = new Distribuidor(txt_nombre.Text, txt_apellido.Text, Convert.ToInt32(txt_telefono.Text), txt_direcion.Text);
                    ListasDistribuidor.Add(distribuidores);
                    listbox_distribuidor.Items.Add(distribuidores.GetNombre());
                    MessageBox.Show("Distribuidor creado");
                }
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            formulario.Visibility = Visibility.Visible;
            datos.Visibility = Visibility.Hidden;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            formulario.Visibility = Visibility.Hidden;
            datos.Visibility = Visibility.Visible;
        }

        private void listbox_cliente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox lb = (ListBox)sender;
            Cliente cliente = ListasClientes[lb.SelectedIndex];
            lbl_mostrar_cliente.Content = "Cliente: Nombre: " + cliente.GetNombre() + " Apellido: " + cliente.GeApellido()
                + " Telefono: " + cliente.GetTelefono() + " Direccion: " + cliente.GetDireccion();
        }

        private void listbox_distribuidor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox lb = (ListBox)sender;
            Distribuidor distribuidor = ListasDistribuidor[lb.SelectedIndex];
            lbl_mostrar_distribuidor.Content = "Distribuidor: Nombre: " + distribuidor.GetNombre() + " Apellido: " + distribuidor.GeApellido()
                + " Telefono: " + distribuidor.GetTelefono() + " Direccion: " + distribuidor.GetDireccion() ;
        }

        public static StreamWriter Escritura;
        public static StreamReader Lectura;
        public static string nombre = "";
        private void btn_generar_ficheros_txt_Click(object sender, RoutedEventArgs e)
        {
           
            nombre = "Cliente.txt";
            if (!File.Exists(nombre))
            {
                Escritura = File.CreateText(nombre);
                foreach (Cliente item in ListasClientes)
                {
                    Escritura.WriteLine( item.GetNombre() + "#" + item.GeApellido() + "#" + item.GetTelefono() + "#" + item.GetDireccion());
                }
                Escritura.Close();
                if (ListasClientes.Count == 0)
                {
                    File.Delete(nombre);
                }
            }
            else
            {
                File.Delete(nombre);
                Escritura = File.AppendText(nombre);
                foreach (Cliente item in ListasClientes)
                {
                    Escritura.WriteLine( item.GetNombre() + "#" + item.GeApellido() + "#" + item.GetTelefono() + "#" + item.GetDireccion());
                }
                Escritura.Close();
                if (ListasClientes.Count == 0)
                {
                    File.Delete(nombre);
                }
            }

            nombre = "Distribuidor.txt";
            if (!File.Exists(nombre))
            {
                Escritura = File.CreateText(nombre);
                foreach (Distribuidor item in ListasDistribuidor)
                {
                    Escritura.WriteLine(item.GetNombre() + "#" + item.GeApellido() + "#" + item.GetTelefono() + "#" + item.GetDireccion());
                }
                Escritura.Close();
                if (ListasClientes.Count == 0)
                {
                    File.Delete(nombre);
                }
            }
            else
            {
                File.Delete(nombre);
                Escritura = File.AppendText(nombre);
                foreach (Distribuidor item in ListasDistribuidor)
                {
                    Escritura.WriteLine(item.GetNombre() + "#" + item.GeApellido() + "#" + item.GetTelefono() + "#" + item.GetDireccion());
                }
                Escritura.Close();
                if (ListasClientes.Count == 0)
                {
                    File.Delete(nombre);
                }
            }
            MessageBox.Show("Ficheros TXT creados");
        }

        private void btn_generar_pdf_Click(object sender, RoutedEventArgs e)
        {
            Document doc = new Document();

            FileStream file = new FileStream("Datos.pdf", FileMode.Create);

            PdfWriter.GetInstance(doc, file);

            doc.Open();

            PdfPTable tabla = new PdfPTable(4);
            PdfPCell cell = new PdfPCell(new Phrase("Cliente"));

            cell.Colspan = 4;
            cell.HorizontalAlignment = 1;
            tabla.AddCell(cell);


            PdfPTable tabla1 = new PdfPTable(4);
            PdfPCell cell1 = new PdfPCell(new Phrase(clientes.GetNombre().ToString()));

            cell1.Colspan = 1;
            cell1.HorizontalAlignment = 1;
            tabla1.AddCell(cell1);

            PdfPTable tabla2 = new PdfPTable(1);
            PdfPCell cell2 = new PdfPCell(new Phrase(clientes.GeApellido().ToString()));

            cell2.Colspan = 1;
            cell2.HorizontalAlignment = 1;
            tabla1.AddCell(cell2);


            PdfPTable tabla3 = new PdfPTable(1);
            PdfPCell cell3 = new PdfPCell(new Phrase(clientes.GetTelefono().ToString()));

            cell3.Colspan = 1;
            cell3.HorizontalAlignment = 1;
            tabla1.AddCell(cell3);



            PdfPTable tabla4 = new PdfPTable(1);
            PdfPCell cell4 = new PdfPCell(new Phrase(clientes.GetDireccion().ToString()));

            cell4.Colspan = 1;
            cell4.HorizontalAlignment = 1;
            tabla1.AddCell(cell4);
            tabla1.SpacingAfter = 30f;




            PdfPTable tabla5 = new PdfPTable(4);
            PdfPCell cell5 = new PdfPCell(new Phrase("Distribuidor"));

            cell5.Colspan = 4;
            cell5.HorizontalAlignment = 1;
            tabla5.AddCell(cell5);


            PdfPTable tabla6 = new PdfPTable(4);
            PdfPCell cell6 = new PdfPCell(new Phrase(distribuidores.GetNombre().ToString()));

            cell6.Colspan = 1;
            cell6.HorizontalAlignment = 1;
            tabla6.AddCell(cell6);

            PdfPTable tabla7 = new PdfPTable(1);
            PdfPCell cell7 = new PdfPCell(new Phrase(distribuidores.GeApellido().ToString()));

            cell7.Colspan = 1;
            cell7.HorizontalAlignment = 1;
            tabla6.AddCell(cell7);


            PdfPTable tabla8 = new PdfPTable(1);
            PdfPCell cell8 = new PdfPCell(new Phrase(distribuidores.GetTelefono().ToString()));

            cell8.Colspan = 1;
            cell8.HorizontalAlignment = 1;
            tabla6.AddCell(cell8);



            PdfPTable tabla9 = new PdfPTable(1);
            PdfPCell cell9 = new PdfPCell(new Phrase(distribuidores.GetDireccion().ToString()));

            cell9.Colspan = 1;
            cell9.HorizontalAlignment = 1;
            tabla6.AddCell(cell9);
            tabla6.SpacingAfter = 30f;

            doc.Add(tabla);
            doc.Add(tabla1);
            doc.Add(tabla2);
            doc.Add(tabla3);
            doc.Add(tabla4);
            doc.Add(tabla5);
            doc.Add(tabla6);
            doc.Add(tabla7);
            doc.Add(tabla8);
            doc.Add(tabla9);
            doc.Close();
            MessageBox.Show("Fichero PDF creado");
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void txt_telefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                e.Handled =false;
            else
                e.Handled = true;
        }

        private void btn_eliminar_Click(object sender, RoutedEventArgs e)
        {
            if (clientes.GetNombre() == txt_nombre_eliminar.Text)
            {
                ListasClientes.Remove(clientes);
                listbox_cliente.Items.Remove(clientes);
                MessageBox.Show("Se ha eliminado correctamente");
            }
            else if (distribuidores.GetNombre() == txt_nombre_eliminar.Text)
            {
                ListasDistribuidor.Remove(distribuidores);
                listbox_distribuidor.Items.Remove(distribuidores);
                MessageBox.Show("Se ha eliminado correctamente");
            }
            else
                MessageBox.Show("No hay un cliente o distribuidor con ese nombre");
        }

        private void btn_modificar_Click(object sender, RoutedEventArgs e)
        {
            if (clientes.GetNombre() == txt_nombre_eliminar.Text)
            {
                
                int posicion = ListasClientes.IndexOf(clientes);
                ListasClientes.RemoveAt(posicion);
                listbox_cliente.Items.RemoveAt(posicion);
                ListasClientes.Insert(posicion,clientes);
                listbox_cliente.Items.Insert(posicion,clientes);
                MessageBox.Show("Se ha modificado correctamente");
            }
            else if (distribuidores.GetNombre() == txt_nombre_eliminar.Text)
            {
                int posicion = ListasDistribuidor.IndexOf(distribuidores);
                ListasDistribuidor.RemoveAt(posicion);
                listbox_distribuidor.Items.RemoveAt(posicion);
                ListasDistribuidor.Insert(posicion, distribuidores);
                listbox_distribuidor.Items.Insert(posicion, distribuidores);
                MessageBox.Show("Se ha eliminado correctamente");
            }
            else
                MessageBox.Show("No hay un cliente o distribuidor con ese nombre");
        }

        private void btn_generar_ficheros_txt_Copy_Click(object sender, RoutedEventArgs e)
        {
            nombre = "Cliente.json";
            if (!File.Exists(nombre))
            {
                Escritura = File.CreateText(nombre);
                foreach (Cliente item in ListasClientes)
                {
                    Escritura.WriteLine("{\"nombre\": \"" + item.GetNombre() + "\", \"apellido\": \"" + item.GeApellido() + "\", \"telefono\": \"" + item.GetTelefono() + "\", \"direccion\": \"" + item.GetDireccion() + "\"}");
                }
                Escritura.Close();
                if (ListasClientes.Count == 0)
                {
                    File.Delete(nombre);
                }
            }
            else
            {
                File.Delete(nombre);
                Escritura = File.AppendText(nombre);
                foreach (Cliente item in ListasClientes)
                {
                    Escritura.WriteLine("{\"nombre\": \"" + item.GetNombre() + "\", \"apellido\": \"" + item.GeApellido() + "\", \"telefono\": \"" + item.GetTelefono() + "\", \"direccion\": \"" + item.GetDireccion() + "\"}");
                }
                Escritura.Close();
                if (ListasClientes.Count == 0)
                {
                    File.Delete(nombre);
                }
            }


            nombre = "Distribuidor.json";
            if (!File.Exists(nombre))
            {
                Escritura = File.CreateText(nombre);
                foreach (Distribuidor item in ListasDistribuidor)
                {
                    Escritura.WriteLine("{\"nombre\": \"" + item.GetNombre() + "\", \"apellido\": \"" + item.GeApellido() + "\", \"telefono\": \"" + item.GetTelefono() + "\", \"direccion\": \"" + item.GetDireccion() + "\"}");
                }
                Escritura.Close();
                if (ListasDistribuidor.Count == 0)
                {
                    File.Delete(nombre);
                }
            }
            else
            {
                File.Delete(nombre);
                Escritura = File.AppendText(nombre);
                foreach (Distribuidor item in ListasDistribuidor)
                {
                    Escritura.WriteLine("{\"nombre\": \"" + item.GetNombre() + "\", \"apellido\": \"" + item.GeApellido() + "\", \"telefono\": \"" + item.GetTelefono() + "\", \"direccion\": \"" + item.GetDireccion() + "\"}");
                }
                Escritura.Close();
                if (ListasDistribuidor.Count == 0)
                {
                    File.Delete(nombre);
                }
            }
            MessageBox.Show("Fichero JSON creado");
        }
    }
}
