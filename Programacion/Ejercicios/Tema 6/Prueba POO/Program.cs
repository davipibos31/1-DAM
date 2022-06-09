using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();

            p1.SetDni(12345678);
            p1.SetNombre("Carlos");
            p1.SetEdad(27);

            Persona p2 = new Persona(12345678, "Pepe", 27);

            Console.WriteLine(p1.GetNombre());
            Console.WriteLine(p2.GetNombre());

            p1 = p2;

            Console.WriteLine(p1.GetNombre());
            Console.WriteLine(p2.GetNombre());

            p1.SetNombre("JUAN");

            Console.WriteLine(p1.GetNombre());
            Console.WriteLine(p2.GetNombre());

            if (p1.Equals(p2))
                Console.WriteLine("SI");

            Cliente c1 = new Cliente();
            Empleado e1 = new Empleado();

            c1.GetDni();
            e1.GetDni();
            c1.GetCuenta();
            e1.GetCodigo();

            Console.WriteLine(c1.GetType());

        }
    }


    public class Persona
    {
        private int dni;
        private string nombre;
        private int edad;
        private Coche coche;

        public Persona()
        {
            dni = 1234;
            nombre = "";
            edad = 0;
            coche = new Coche();
        }

        public Persona(int dni, string nombre, int edad)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.edad = edad;
            coche = new Coche();
        }

        public Persona(int dni, string nombre, int edad, Coche coche)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.edad = edad;
            this.coche = coche;
        }


        public void Mostrar()
        {
            Console.WriteLine(dni);
            Console.WriteLine(nombre);
            Console.WriteLine(edad);
        }

        public int GetDni()
        {
            return dni;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public int GetEdad()
        {
            return edad;
        }

        public Coche GetCoche()
        {
            return coche;
        }

        public void SetDni(int dni)
        {
            this.dni = dni;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        public void SetCoche(Coche coche)
        {
            this.coche = coche;
        }

        public bool Equals(Persona persona)
        {
            if (dni == persona.dni
                && nombre == persona.nombre
                && edad == persona.edad)
                return true;
            return false;
        }
    }

    public class Coche
    {
        private string matricula;
        private int potencia;

        public Coche()
        {
            matricula = "1234 ABC";
            potencia = 3000;
        }


        public string GetMatricula()
        {
            return matricula;
        }

        public void SetMatricula(string matricula)
        {
            this.matricula = matricula;
        }
    }

    public class Cliente : Persona
    {
        private string cuenta;

        ~Cliente()
        { 
            
        }

        public void SetCuenta(string cuenta)
        {
            this.cuenta = cuenta;
        }

        public string GetCuenta()
        {
            return cuenta;
        }
    }

    public class Empleado : Persona
    {
        private int codigo;

        ~Empleado()
        { 
        
        }

        public void SetCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public int GetCodigo()
        {
            return codigo;
        }
    }
}
