using System;
using System.Collections.Generic;
using System.Text;

namespace Formulario
{
    public class Distribuidor
    {
        private string nombre;
        private string primer_apellido;
        private string correo;
        private string direccion;
        private string provincia;
        private string codigo;
        private int telefono1;
        private int telefono2;


        public Distribuidor(string nombre, string primer_apellido, string correo, string direccion, string provincia, int telefono1, int telefono2, string codigo)
        {
            this.nombre = nombre; this.primer_apellido = primer_apellido; this.provincia = provincia; this.telefono1 = telefono1; this.telefono2 = telefono2;
            this.direccion = direccion; this.correo = correo; this.codigo = codigo;
        }
        public Distribuidor(string nombre, string primer_apellido, string correo, string direccion, string provincia, int telefono1, string codigo)
        {
            this.nombre = nombre; this.primer_apellido = primer_apellido; this.provincia = provincia; this.telefono1 = telefono1; this.direccion = direccion;
            this.correo = correo; this.codigo = codigo;
        }

        public string GetNombre()
        {
            return nombre;
        }
        public string GetPrimerApellido()
        {
            return primer_apellido;
        }
        public string GetCorreo()
        {
            return correo;
        }
        public string GetDirrecion()
        {
            return direccion;
        }
        public string GetProvincia()
        {
            return provincia;
        }
        public int GetTelefono1()
        {
            return telefono1;
        }
        public int GetTelefono2()
        {
            return telefono2;
        }
        public string Getcodigo()
        {
            return codigo;
        }
    }
}
