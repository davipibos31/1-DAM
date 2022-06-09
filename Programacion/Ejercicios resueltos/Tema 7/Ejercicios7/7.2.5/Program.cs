using System;
/*
 * Amplía el proyecto Libro (ejercicio 7.2.2), de modo que permita guardar 1000 documentos de cualquier tipo. 
 * A la hora de añadir un documento, se preguntará al usuario si desea guardar un documento genérico o un libro, 
 * para usar el constructor adecuado.
 */
namespace _7._2._5
{
    class Libro : Documento
    {
        string ubicacion;

        public Libro(string titulo, string autor, string ubicacion) : base(titulo, autor)
        {
            this.ubicacion = ubicacion;
        }
        public string GetUbicacion()
        {
            return this.ubicacion;
        }
        public void SetUbicacion(string ubicacion)
        {
            this.ubicacion = ubicacion;
        }
    }
    class Documento
    {
        string titulo;
        string autor;

        public Documento(string titulo, string autor)
        {
            this.titulo = titulo;
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
        public string GetAutor()
        {
            return this.autor;
        }
        public void SetAutor(string autor)
        {
            this.autor = autor;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Documento[] documentos = new Documento[1000];
            string opcion;
            int contador = 0;
			string t, a, u;
			
            do
            {
                Console.WriteLine("¿Desea guardar un (N)uevo documento, (V)er los documentos o (S)alir");
                opcion = Console.ReadLine();

                if (opcion == "N")
                {
                    Console.WriteLine("Desea guardar un (L)ibro o un (D)ocumento?");
                    opcion = Console.ReadLine();

                    if (opcion == "L")
                    {
                        
                        Console.Write("Título: ");
                        t = Console.ReadLine();
                        Console.Write("Autor: ");
                        a = Console.ReadLine();
                        Console.Write("Ubicación: ");
                        u = Console.ReadLine();
                        documentos[contador]=new Libro(t, a, u);
                        contador++;

                    }
                    else if (opcion == "D")
                    {
                        Console.Write("Título: ");
                        t = Console.ReadLine();
                        Console.Write("Autor: ");
                        a = Console.ReadLine();
                        documentos[contador] = new Documento(t, a);
                        contador++;

                    }
                    else if (opcion != "S")
                        Console.WriteLine("Comando no reconocido");
                }
                else if (opcion == "V")
                {
                    Console.WriteLine("Listado de documentos:");
                    if (contador == 0) 
                        Console.WriteLine("No hay ningún documento");
                    else
                    {
                        for (int i = 0; i < contador; i++)
                        {
                            Console.WriteLine("Documento {0}: {1}\n", i+1, documentos[i].GetTitulo());
                        }
                    }
                }
            }
            while (opcion != "S");

            Console.WriteLine("Salió del programa");
        }
    }
}
