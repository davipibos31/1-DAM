using System;
using System.IO;

namespace ejercicio_8._1._2
{
    class Program
    {
        struct tipoFicha
        {
            public string nombreFich; // Nombre del fichero
            public long tamanyo; // El tamaño en KB
        };
        public static void Main()
        {
            dowhile();
        }
        static void Menu()
        {
            // Menu principal, repetitivo
            Console.WriteLine(frase = "\n");
            fichero.WriteLine(frase);
            Console.WriteLine(frase = "Escoja una opción:");
            fichero.WriteLine(frase);
            Console.WriteLine(frase = "1.- Añadir datos de un nuevo fichero");
            fichero.WriteLine(frase);
            Console.WriteLine(frase = "2.- Mostrar los nombres de todos los ficheros");
            fichero.WriteLine(frase);
            Console.WriteLine(frase = "3.- Mostrar ficheros por encima de un cierto tamaño");
            fichero.WriteLine(frase);

            Console.WriteLine(frase = "4.- Ver datos de un fichero");
            fichero.WriteLine(frase);
            Console.WriteLine(frase = "5.- Salir");
            fichero.WriteLine(frase);
        }
        public static string frase = "";
        public static StreamWriter fichero = new StreamWriter("Resultado.txt");
        static void dowhile()
        {
            tipoFicha[] fichas // Los datos en si
            = new tipoFicha[1000];
            int numeroFichas = 0; // Número de fichas que ya tenemos
            int i; // Para bucles
            int opcion; // La opcion del menu que elija el usuario
            string textoBuscar; // Para cuando preguntemos al usuario
            long tamanyoBuscar; // Para buscar por tamaño
            
            
            do
            {
                Menu();
                opcion = Convert.ToInt32(frase = Console.ReadLine());
                fichero.WriteLine(frase);
                // Hacemos una cosa u otra según la opción escogida
                switch (opcion)
                {

                    case 1: // Añadir un dato nuevo
                        if (numeroFichas < 1000)
                        { // Si queda hueco
                            Console.WriteLine(frase = "Introduce el nombre del fichero: ");
                            fichero.WriteLine(frase);
                            fichas[numeroFichas].nombreFich = frase = Console.ReadLine();
                            fichero.WriteLine(frase);
                            Console.WriteLine(frase = "Introduce el tamaño en KB: ");
                            fichero.WriteLine(frase);
                            fichas[numeroFichas].tamanyo = Convert.ToInt32(frase = Console.ReadLine());
                            fichero.WriteLine(frase);
                            // Y ya tenemos una ficha más
                            numeroFichas++;
                        }
                        else // Si no hay hueco para más fichas, avisamos
                        {
                            Console.WriteLine(frase = "Máximo de fichas alcanzado (1000)!");
                            fichero.WriteLine(frase);
                        }
                        break;

                    case 2: // Mostrar todos
                        for (i = 0; i < numeroFichas; i++)
                        {
                            Console.WriteLine(frase = $"Nombre: {fichas[i].nombreFich}; Tamaño: {fichas[i].tamanyo} KB");
                            fichero.WriteLine(frase);
                        }
                        break;

                    case 3: // Mostrar según el tamaño
                        Console.WriteLine(frase = "¿A partir de que tamaño quieres ver?");
                        fichero.WriteLine(frase);
                        tamanyoBuscar = Convert.ToInt64(frase = Console.ReadLine());
                        fichero.WriteLine(frase);
                        for (i = 0; i < numeroFichas; i++)
                            if (fichas[i].tamanyo >= tamanyoBuscar)
                            {
                                Console.WriteLine( frase = $"Nombre: {fichas[i].nombreFich}; Tamaño: {fichas[i].tamanyo} KB");
                                fichero.WriteLine(frase);
                            }
                        break;

                    case 4: // Ver todos los datos (pocos) de un fichero
                        Console.WriteLine(frase = "¿De qué fichero quieres ver todos los datos?");
                        fichero.WriteLine(frase);
                        textoBuscar = frase = Console.ReadLine();
                        fichero.WriteLine(frase);
                        for (i = 0; i < numeroFichas; i++)
                            if (fichas[i].nombreFich == textoBuscar)
                                Console.WriteLine( frase = $"Nombre: {fichas[i].nombreFich}; Tamaño: {fichas[i].tamanyo} KB");
                        fichero.WriteLine(frase);
                        break;

                    case 5: // Salir: avisamos de que salimos */
                        Console.WriteLine(frase = "Fin del programa");
                        fichero.WriteLine(frase);
                        break;

                    default: // Otra opcion: no válida
                        Console.WriteLine(frase = "Opción desconocida!");
                        fichero.WriteLine(frase);
                        break;
                }
            } while (opcion != 5); // Si la opcion es 5, terminamos
            fichero.Close();
        }
    }
}
