using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen3Evaluacion
{
    public class Distribuidor
    {
        public string nombre = "";
        public string apellido = "";
        public int telefono;
        public int codigo;
        public string email = "";
        public Random generador;


        public Distribuidor(string nombre, string apellido, int telefono, string email)
        { 
            this.nombre = nombre; this.apellido = apellido; this.telefono = telefono; 
            this.email = email; 
        }

        public string GetNombre() { return nombre; }
        public void SetNombre(string nombre) { this.nombre = nombre; }
        public string GeApellido() { return apellido; }
        public void SetApellido(string apellido) { this.apellido = apellido; }
        public string GetDireccion() { return email; }
        public void SetDireccion(string email) { this.email = email; }
        public int GetTelefono() { return telefono; }
        public void SetTelefono(int telefono) { this.telefono = telefono; }
        /*public int GetCodigo()
        {
            codigo = generador.Next(000, 1000);

            return codigo;
        }*/
    }
}
