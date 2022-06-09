using System;

namespace ejercicio_4._3._3._1
{
    class Program
    {
        struct cancion
        {
            public string Artista;
            public string Titulo;
            public int Tamaño;
            public duraciones duracion;
        }
        struct duraciones
        {
            public int minutos;
            public int segundos;
        }
        static void Main(string[] args)
        {
            cancion[] tipocancion = new cancion[100];
            for (int i = 0; i < 100; i++)
            {
                Console.Write("Introduce el nombre del artista: ");
                tipocancion[i].Artista = Console.ReadLine();
                Console.Write("Introduce el nombre de la canción: ");
                tipocancion[i].Titulo = Console.ReadLine();
                Console.Write("Introduce la duracion en minutos: ");
                tipocancion[i].duracion.minutos = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduce la duracion en segundos: ");
                tipocancion[i].duracion.segundos = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduce el tamáño en kb: ");
                tipocancion[i].Tamaño = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"La canción {tipocancion[i].Titulo} del artista {tipocancion[i].Artista} dura {tipocancion[i].duracion.minutos} minutos y {tipocancion[i].duracion.segundos} segundos y pesa {tipocancion[i].Tamaño} kb");
                Console.WriteLine();
            }
        }
    }
}
