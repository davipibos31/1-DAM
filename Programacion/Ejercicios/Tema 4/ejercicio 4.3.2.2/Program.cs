using System;

namespace ejercicio_4._3._2._2
{
    class Program
    {
        struct imagenes
        {
            public string nombre;
            public int ancho;
            public int alto;
            public int tamaño;
        }
        static void Main(string[] args)
        {
            imagenes[] tipoimagen = new imagenes[700];
            for (int i = 0; i < 700; i++)
            {
                Console.Write("Introduce el nombre de la imagen: ");
                tipoimagen[i].nombre = Console.ReadLine();
                Console.Write("Introduce el ancho en pixeles de la imagen: ");
                tipoimagen[i].ancho = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduce el alto en pixeles de la imagen: ");
                tipoimagen[i].alto = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduce el tamáño en kb: ");
                tipoimagen[i].tamaño = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"La imagen {tipoimagen[i].nombre} tiene un ancho de {tipoimagen[i].ancho} px y tiene un alto de {tipoimagen[i].alto} px y pesa {tipoimagen[i].tamaño} kb");
                Console.WriteLine();
            }
        }
    }
}
