using System;
using System.Collections.Generic;
using System.Text;

namespace Practica5
{
    //----------------------------------------
    // David Piñuel Bosque
    // Curso DAM
    // Modalidad Presencial
    // Práctica nº 5
    // ---------------------------------------
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string provincia;

        public Cliente(string nombre, string apellido, string provincia)
        {
            this.nombre = nombre; this.apellido = apellido; this.provincia = provincia;
        }

        public Cliente(string nombre)
        {
            this.nombre = nombre;
        }
        public string GetNombre() { return nombre; }
        public string GetApellido() { return apellido; }
        public string GetProvincia() { return provincia; }
    }
}
