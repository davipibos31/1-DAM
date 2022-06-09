using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Practica_4
{
    public class Cuenta_Bancaria
    {
        private double dinero_disponible = 0;

        public Cuenta_Bancaria()                        // un constructor 
        { 
            
        }
        public int Aleatorio()
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

        public void SetDinero_disponible(double dinero_disponible)
        {
            this.dinero_disponible = dinero_disponible;
        }
        public double GetDinero_disponible()                            //Cada metodo Get de las variables
        {
            return dinero_disponible;
        }
    }
}
