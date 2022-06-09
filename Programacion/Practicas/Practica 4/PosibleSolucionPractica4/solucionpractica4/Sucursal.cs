using System;
using System.Collections.Generic;
using System.Text;

namespace Practica4Solucion
{
    public class Sucursal
    {
        public static Sucursal[] sucursales = new Sucursal[2];
        public static int indice = 0;
        
        private static int[] codigos = new int[2];
        private static int posicion = 0;
        
        private int codigo;
        private string ciudad;
        private string ubicacion;
        private int postal;
        private Cliente[] clientes;

        public Sucursal() { }
        
        public Sucursal(string ciudad, string ubicacion, int postal)
        {
            Random random = new Random();
            int codigo;

            do
            {
                codigo = random.Next(1000, 10000);
            }
            while (ExisteSucursal(codigo));

            codigos[posicion] = codigo;
            this.codigo = codigo;
            this.ciudad = ciudad;
            this.ubicacion = ubicacion;
            this.postal = postal;
            clientes = new Cliente[2];
        }

        public int GetCodigo()
        {
            return codigo;
        }

        public string GetCiudad()
        {
            return ciudad;
        }

        public string GetUbicacion()
        {
            return ubicacion;
        }

        public int GetPostal()
        {
            return postal;
        }

        public Cliente[] GetClientes()
        {
            return clientes;
        }

        public bool isComplete()
        {
            if (clientes[0] != null && clientes[1] != null)
                return true;
            else
                return false;
        }
        
        public void AñadirCliente(Cliente c)
        {
            if (clientes[0] == null)
                clientes[0] = c;
            else
                clientes[1] = c;
        }
        
        public int GetNumCuentas()
        {
            int contador = 0;

            foreach (Cliente c in clientes)
                if (c != null)
                    contador++;
            return contador;
        }

        private bool ExisteSucursal(int codigo)
        {
            bool existe = false;

            foreach (int cod in codigos)
                if (cod == codigo)
                    existe = true;

            return existe;
        }

        public static Sucursal GetSucursal(int codigo)
        {
            foreach (Sucursal s in sucursales)
                if (s.codigo == codigo)
                    return s;

            return new Sucursal();
        }

        public Cuenta[] GetCuentas()
        {
            Cuenta[] cuentas = new Cuenta[GetNumCuentas()];

            for (int i = 0; i < clientes.Length; i++)
                if (clientes[i] != null)
                    cuentas[i] = clientes[i].GetCuenta();

            return cuentas;
        }
    }
}
