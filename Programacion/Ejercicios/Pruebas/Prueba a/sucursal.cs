using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Practica_4
{
    public class sucursal
    {
        private string ubicacion;
        private string ciudad;
        private int codigo_postal;
        private int codigo_aleatorio;
        int[] vector = new int[25];

        public sucursal(string ubicacion, int codigo_aleatorio, string ciudad, int codigo_postal)
        {
            
            this.ubicacion = ubicacion;
            this.codigo_aleatorio = codigo_aleatorio;                   //Un contructor con los datos 
            this.ciudad = ciudad;
            this.codigo_postal = codigo_postal;
        }
        public sucursal()
        {   

        }
        public int GetCodigo2()
        {
            List<int> list = new List<int>();

            Random rnd = new Random();
            int valor = 1;
            for (int i = 0; i <= 10; i++)
            {

                valor = rnd.Next(1000, 9999);

                if (!list.Contains(valor))                          //Bucle para no repetir los numeros del ramdom
                {
                    list.Add(valor);
                }
                return valor;
            }
            return valor;
        }

        public string GetUbicacion()
        {
            return ubicacion;
        }
        public int GetCodigo()
        {
            return codigo_aleatorio;                        //Cada metodo Get de las variables
        }
        public string GetCiudad()
        {
            return ciudad;
        }
        public int GetCodigo_postal()
        {
            return codigo_postal;
        }
    }
}
