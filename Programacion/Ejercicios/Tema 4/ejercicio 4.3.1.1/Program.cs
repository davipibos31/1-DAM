using System;

namespace ejercicio_4._3._1._1
{
    class Program
    {
        struct cancion
        {
            public string Artista;
            public string Titulo;
            public int Duracion;
            public int Tamaño;
        }
        static void Main(string[] args)
        {
            cancion tipocancion;
            Console.Write("Introduce el nombre del artista: ");
            tipocancion.Artista = Console.ReadLine();
            Console.Write("Introduce el nombre de la canción: ");
            tipocancion.Titulo = Console.ReadLine();
            Console.Write("Introduce la duracion en segundos: ");
            tipocancion.Duracion = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el tamáño en kb: ");
            tipocancion.Tamaño = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"La canción {tipocancion.Titulo} del artista {tipocancion.Artista} tiene {tipocancion.Duracion} segundos y pesa {tipocancion.Tamaño} kb");
        }
    }
}
