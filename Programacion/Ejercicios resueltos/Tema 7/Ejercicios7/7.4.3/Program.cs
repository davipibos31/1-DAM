using System;

/*
 * Refina el proyecto Libro (ejercicio 7.3.4), para que el método ToString de la clase Libro 
 * se apoye en el de la clase Documento, y también lo haga el de la clase Articulo.
 */

namespace _7._4._3
{
    class Documento
    {
        public string titulo;
        public string autor;
        public string ubicacion;

        //constructor

        public Documento(string titulo, string autor, string ubicacion)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.ubicacion = ubicacion;
        }

        //metodo string
        public virtual new string ToString()
        {
            return this.titulo + "-" + this.autor + "-" + this.ubicacion;
        }

        //getters y setters
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
        public string GetUbicacion()
        {
            return this.ubicacion;
        }
        public void SetUbicacion(string ubicacion)
        {
            this.ubicacion = ubicacion;
        }
    }
    class Libro : Documento
    {
        public int paginas;

        //constructor

        public Libro(string titulo, string autor, string ubicacion, int paginas) : base(titulo, autor, ubicacion)
        {
            this.paginas = paginas;
        }

        //metodo string
        public override string ToString()
        {
            return base.ToString() + "-" + this.paginas;
        }

        //getters y setters
        public int GetPaginas()
        {
            return this.paginas;
        }
        public void SetPaginas(int paginas)
        {
            this.paginas = paginas;
        }
    }
    class Articulo : Documento
    {
        public string procedencia;

        //constructor

        public Articulo(string titulo, string autor, string ubicacion, string procedencia) : base(titulo, autor, ubicacion)
        {
            this.procedencia = procedencia;
        }

        //metodo string
        public override string ToString()
        {
            return base.ToString() + "-" + this.procedencia;
        }

        //getters y setters
        public string GetProcedencia()
        {
            return this.procedencia;
        }
        public void SetProcedencia(string procedencia)
        {
            this.procedencia = procedencia;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = "";
            Documento[] documentos = new Documento[100];
            int contador = 0;

            Console.WriteLine("PULSE \"S\" PARA SALIR");

            do
            {
                Console.WriteLine("Desea añadir un (L)ibro o un (A)rtículo?");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "L":
                    case "l":
                        string LTit, LAut, LUbi;
                        int LPags;
                        Console.Write("Título: ");
                        LTit = Console.ReadLine();
                        Console.Write("Autor: ");
                        LAut = Console.ReadLine();
                        Console.Write("Ubicación: ");
                        LUbi = Console.ReadLine();
                        Console.Write("Número de páginas: ");
                        LPags = Convert.ToInt32(Console.ReadLine());
                        documentos[contador] = new Libro(LTit, LAut, LUbi, LPags);
                        Console.WriteLine("\nHa creado: {0}\n", documentos[contador].ToString());
                        contador++;
                        break;
                    case "A":
                    case "a":
                        string ATit, AAut, AUbi, AProc;
                        Console.Write("Título: ");
                        ATit = Console.ReadLine();
                        Console.Write("Autor: ");
                        AAut = Console.ReadLine();
                        Console.Write("Ubicación: ");
                        AUbi = Console.ReadLine();
                        Console.Write("Número de páginas: ");
                        AProc = Console.ReadLine();
                        documentos[contador] = new Articulo(ATit, AAut, AUbi, AProc);
                        Console.WriteLine("\nHa creado: {0}\n", documentos[contador].ToString());
                        contador++;
                        break;
                    default:
                        Console.WriteLine("");
                        break;

                }
            }
            while (opcion != "S");
        }
    }
}
