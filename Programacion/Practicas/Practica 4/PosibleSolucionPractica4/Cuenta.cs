using System;
using System.Collections.Generic;
using System.Text;

namespace Practica4Solucion
{
    public class Cuenta
    {
        private static int[] codigos = new int[4];
        private static int posicion = 0;
        
        private int codigo;
        private int dinero;

        public Cuenta()
        {
            Random random = new Random();
            int codigo;
            
            do
            {
                codigo = random.Next(1000, 10000);
            }
            while (ExisteCuenta(codigo));

            codigos[posicion] = codigo;
            this.codigo = codigo;
            dinero = 0;
        }
        
        public int GetCodigo()
        {
            return codigo;
        }

        public int GetDinero()
        {
            return dinero;
        }

        public int IngresarDinero(int cantidad)
        {
            return dinero += cantidad;
        }
        
        public int RetirarDinero(int cantidad)
        {
            if (dinero >= cantidad)
                return dinero -= cantidad;
            else
                return -1;
        }

        private bool ExisteCuenta(int codigo)
        {
            bool existe = false;
            
            foreach (int cod in codigos)
                if (cod == codigo)
                    existe = true;

            return existe;
        }

        public Cliente GetCliente()
        {
            foreach (Sucursal s in Sucursal.sucursales)
                foreach (Cliente c in s.GetClientes())
                    if (c.GetCuenta().codigo == codigo)
                        return c;

            return new Cliente();
        }

        public string GetDniCliente()
        {
            return GetCliente().GetDni();
        }

        public Sucursal GetSucursal()
        {
            foreach (Sucursal s in Sucursal.sucursales)
                foreach (Cliente c in s.GetClientes())
                    if (c != null)
                        if (c.GetCuenta().codigo == codigo)
                            return s;

            return new Sucursal();
        }

        public int GetCodigoSucursal()
        {
            return GetSucursal().GetCodigo();
        }

        public static Cuenta GetCuenta(int codigo)
        {
            foreach (Sucursal s in Sucursal.sucursales)
                foreach (Cliente c in s.GetClientes())
                    if (c != null)
                        if (c.GetCuenta().codigo == codigo)
                            return c.GetCuenta();
            return new Cuenta();
        }
    }
}
