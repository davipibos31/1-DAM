using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen3Evaluacion
{
    public class Cliente
    {
        public string nombre = "";
        public string apellido = "";
        public int telefono;
        public int codigo;
        public string direccion = "";
        public Random generador;


        public Cliente(string nombre, string apellido, int telefono, string direccion)
        {
            this.nombre = nombre; this.apellido = apellido; this.telefono = telefono;
            this.direccion = direccion;
        }

        public string GetNombre() { return nombre; }
        public void SetNombre(string nombre) { this.nombre = nombre; }
        public string GeApellido() { return apellido; }
        public void SetApellido(string apellido) { this.apellido = apellido; }
        public string GetDireccion() { return direccion; }
        public void SetDireccion(string direccion) { this.direccion = direccion; }
        public int GetTelefono() { return telefono; }
        public void SetTelefono(int telefono) { this.telefono = telefono; }
        /* public int GetCodigo() 
         {
             codigo = generador.Next(0000,10000);

             return codigo; 
         }*/
    }
}
