using System;

namespace Ejercicio_clase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaramos variables
            int aux1 = 2;
            int aux2 = 10;
            int resta = aux2 - aux1; 
            int suma = aux2 + aux1;
            int multi = aux2 * aux1;
            int divi = aux2 / aux1;
            int resto = aux2 % aux1;
            int X;
            int Y;
            int Z;
            int primero;
            int segundo;
            

            // Realizamos los claculos

            Console.WriteLine(aux2 + aux1);
            Console.WriteLine(aux2 - aux1);
            Console.WriteLine(aux2 * aux1);
            Console.WriteLine(aux2 / aux1);
            Console.WriteLine(aux2 % aux1);
            Console.WriteLine(suma);
            Console.WriteLine(resta);
            Console.WriteLine(multi);
            Console.WriteLine(divi);
            Console.WriteLine(resto);

            // Realizamos calculos teniendo strings

            Console.WriteLine("El resultado de X + Y es igual a Z", X = aux2, Y= aux1, Z = suma );
            Console.WriteLine("El resultado de X - Y es igual a Z", X = aux2, Y = aux1, Z = resta);
            Console.WriteLine("El resultado de X * Y es igual a Z", X = aux2, Y = aux1, Z = multi);
            Console.WriteLine("El resultado de X / Y es igual a Z", X = aux2, Y = aux1, Z = divi);
            Console.WriteLine("El resultado de X % Y es igual a Z", X = aux2, Y = aux1, Z = resto);

            // Realizamos calculos teniendo strings con corchetes

            Console.WriteLine("El resultado de {0} + {1} es igual a {2}", aux2, aux1, suma);
            Console.WriteLine("El resultado de {0} - {1} es igual a {2}", aux2, aux1, resta);
            Console.WriteLine("El resultado de {0} * {1} es igual a {2}", aux2, aux1, multi);
            Console.WriteLine("El resultado de {0} / {1} es igual a {2}", aux2, aux1, divi);
            Console.WriteLine("El resultado de {0} % {1} es igual a {2}", aux2, aux1, resto);

            //conversiones
            Console.WriteLine("Escribe el primer numero");
            primero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escribe el segundo numero");
            segundo = Convert.ToInt32(Console.ReadLine());

            //calculos con las conversiones
            //creamos nuevas variables

/*
            int suma1 = primero + segundo;
            int resta1 = primero - segundo;
            int multi1 = primero * segundo;
            int divi1 = primero / segundo;
            int resto1 = primero % segundo;
*/
/*
            Console.WriteLine(suma);
            Console.WriteLine(resta);
            Console.WriteLine(multi);
            Console.WriteLine(divi);
            Console.WriteLine(resto);
            /*

            //calculos con las conversiones conteniendo strings

            Console.WriteLine("El resultado de {0} + {1} es igual a {2}", primero, segundo, suma);
            Console.WriteLine("El resultado de {0} - {1} es igual a {2}", primero, segundo, resta);
            Console.WriteLine("El resultado de {0} * {1} es igual a {2}", primero, segundo, multi);
            Console.WriteLine("El resultado de {0} / {1} es igual a {2}", primero, segundo, divi);
            Console.WriteLine("El resultado de {0} % {1} es igual a {2}", primero, segundo, resto);
*/
        }
    }
}
