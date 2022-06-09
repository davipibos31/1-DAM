using System;
/*
 * Amplía el proyecto Libro (ejercicio 6.7.2), de modo que permita guardar hasta 1.000 libros. 
 * Main mostrará un menú que permita añadir un nuevo libro o ver los datos de los ya existentes.
 */
namespace _7._2._2
{
    class Libro
    {
        string autor;
        string titulo;

        public string GetAutor()
        {
            return this.autor;
        }
        public void SetAutor(string autor)
        {
            this.autor = autor;
        }
        public string GetTitulo()
        {
            return this.titulo;
        }
        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Libro[] libro = new Libro[1000];
            int contador = 0;
			string opcion = "0";
            

            while (opcion != "3")
            {
				Console.WriteLine("Menú:\n( 1 ) - Añadir nuevo libro\n( 2 ) - Ver libros\n( 3 ) - Salir");
				opcion = Console.ReadLine();
				
                switch (opcion)
                {
                    case "1":
						if (contador < 1000)
						{
							Console.WriteLine("---AÑADIR NUEVO LIBRO---");
							libro[contador] = new Libro();
							Console.Write("Autor: ");
							libro[contador].SetAutor(Console.ReadLine());
							Console.Write("Título: ");
							libro[contador].SetTitulo(Console.ReadLine());
							Console.WriteLine("Libro añadido!");
							contador++;
						}
						else
							Console.WriteLine("Librería llena.");
                        break;

                    case "2":
                        Console.WriteLine("---LISTADO DE LIBROS---");
                        if (contador == 0)
                            Console.WriteLine("No hay libros");
                        else
                        {
                            for(int i = 0; i < contador; i++)
                            {
                                Console.WriteLine("Libro {0}:\nAutor: {1}\nTítulo: {2}\n", i+1, libro[i].GetAutor(), libro[i].GetTitulo());
                            }
                        }

                        break;

                    default:
                        Console.WriteLine("Opción incorrecta.");
                        break;
                }
            }
			
            Console.WriteLine("Ha salido del programa");
        }
    }
}
