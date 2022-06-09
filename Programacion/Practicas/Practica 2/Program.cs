using System;

namespace practica2
{
    class Program
    {
        //--------------------------------
        // David Piñuel Bosque
        // Curso DAM
        // Modalidad Presencial
        // Practica nº 2
        //--------------------------------
        static void Main(string[] args)
        {
            string palabra;
            int fallos = -1;
            int contador = 0;

            Console.Write("Introduce la palabra a adivinar:  ");
            palabra = Console.ReadLine();
            
            char[] letras = new char[palabra.Length];               //Hago este array para poder saber cuantos guiones hay que poner de la palabra que hemos pedido al usuario

            for (int i = 0; i < letras.Length; i++)           //En este bucle hacemos que escriba los guiones que hay que poner separados por espacios, cada guion es un caracter por eso el char y la i indica n caracteres
            {                                                           
                letras[i] = '_';
                Console.Write(letras[i] + " ");
            }
            Console.WriteLine();

            do {
                Console.Write("Introduce una letra: ");
                char adivinar_letra = Convert.ToChar(Console.ReadLine());      // En este bucle do while lo hacemos por que sabemos cuantas veces se debe ejecutar con los fallos y el contador

                if (palabra.IndexOf(adivinar_letra) >= 0)                   //En este if hacemos q si inserta un caracter que esta en la palabra lo guarde y lo cambie en su posicion en los guiones
                {
                    for (int i = 0; i < palabra.Length; i++)
                    {
                        if (palabra[i] == adivinar_letra)
                        {
                            letras[i] = adivinar_letra;
                            contador++;
                        }
                    }
                }
                else
                {                     //En este else hacemos justo lo contrario al if si no esta el caracter que reste un fallo (intento) y escriba el ahorcado dependiendo de cada intento 
                    fallos++;
                    switch (fallos)
                    {
                        case 0:
                            Console.WriteLine("_______");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     o");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("|____________");
                            break;
                        case 1:
                            Console.WriteLine("_______");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     o");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("|____________");
                            break;
                        case 2:
                            Console.WriteLine("_______");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     o");
                            Console.WriteLine("|    /|");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("|____________");
                            break;
                        case 3:
                            Console.WriteLine("_______");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     o");
                            Console.WriteLine("|    /|\\");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("|____________");
                            break;
                        case 4:
                            Console.WriteLine("_______");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     o");
                            Console.WriteLine("|    /|\\");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("|____________");
                            break;
                        case 5:
                            Console.WriteLine("_______");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     o");
                            Console.WriteLine("|    /|\\");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|    /");
                            Console.WriteLine("|____________");
                            break;
                        case 6:
                            Console.WriteLine("_______");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     o");
                            Console.WriteLine("|    /|\\");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|    / \\");
                            Console.WriteLine("|____________");
                            break;
                    }
                }
                for (int i = 0; i < letras.Length; i++)             // En este bucle muestra como seguimos llendo en el ahorcado pese a fallar, en cada fallo que resta lo muestra
                {
                    Console.Write(letras[i] + " ");
                }
                Console.WriteLine();
            } while (fallos < 6 && contador < palabra.Length);
            if (fallos == 6)                                               // En este if else lo hacemos para que muestre la frase si la has acertado la palabra o si te has quedado sin intentos
                Console.WriteLine($"R.I.P. La palabra era: {palabra}.");   
            else
                Console.WriteLine("¡¡¡ENHORABUENA!!!");
        }
    }   
}
