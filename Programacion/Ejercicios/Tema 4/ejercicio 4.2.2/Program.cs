using System;

namespace ejercicio_4._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] cadena;
            cadena = new string[2][];
            cadena[0] = new string[6];
            cadena[1] = new string[6];
            int z = 0;
            for (int i = 0; i < cadena.Length; i++)
            {
                for (int j = 0; j < cadena[i].Length; j++)
                {
                    Console.WriteLine($"Introduze la cadena número {z++}");
                    cadena[i][j] = Console.ReadLine();
                }
            }

            for (int i = 0; i < cadena.Length; i++)
            {
                for (int j = 0; j < cadena[i].Length; j++)
                {
                    Console.WriteLine($"{cadena[i][j]}");
                }
                Console.WriteLine();
            }

            string[] segunda_cadena;
            segunda_cadena = new string[2];

             z = 0;
            for (int i = 0; i < segunda_cadena.Length; i++)
            {
                
                    Console.WriteLine($"Introduze la cadena número {z++}");
                    segunda_cadena[i] = Console.ReadLine();
            }

            for (int i = 0; i < cadena.Length; i++)
            {
                for (int j = 0; j < cadena[i].Length; j++)
                {
                        if (segunda_cadena[i] == cadena[i][j])
                            Console.WriteLine($"Esta palabra esta \"{segunda_cadena[i]}\"");
                }
            }
        }
    }
}
