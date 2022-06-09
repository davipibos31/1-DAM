using System;
using System.Collections.Generic;
using System.Text;

namespace Practica4Solucion
{
    public class Cliente
    {
        private string dni;
        private string nombre;
        private string apellido;
        private Cuenta cuenta;

        public Cliente() { }

        public Cliente(string dni, string nombre, string apellido)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            cuenta = new Cuenta();
        }

        public string GetDni()
        {
            return dni;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string GetApellido()
        {
            return apellido;
        }

        public Cuenta GetCuenta()
        {
            return cuenta;
        }

        public int GetCodigoCuenta()
        {
            return cuenta.GetCodigo();
        }

        public int GetCodigoSucursal()
        {
            foreach (Sucursal s in Sucursal.sucursales)
                    foreach (Cliente c in s.GetClientes())
                        if (Equals(c))
                            return s.GetCodigo();
            return 0;
        }
        
        public static string GetIban(string dni)
        {
            foreach (Sucursal s in Sucursal.sucursales)
                    foreach (Cliente c in s.GetClientes())
                        if (c != null)
                            if (c.dni == dni)
                                return s.GetCodigo().ToString() + " " + c.cuenta.GetCodigo().ToString() + " " + c.dni.Substring(0, c.dni.Length - 1);
            return "";
        }

        public static Cliente GetCliente(string dni)
        {
            foreach (Sucursal s in Sucursal.sucursales)
                foreach (Cliente c in s.GetClientes())
                    if (c != null)
                        if (c.dni == dni)
                            return c;
            return new Cliente();
        }
    }
}
