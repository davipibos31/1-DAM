using System;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1cuadrante1 = 3, num2cuadrante1 = 2, num3cuadrante1 = 1;
            int num1cuadrante2 = 4; 
            int num1cuadrante3 = 3;
            int num1cuadrante4 = 1, num2cuadrante4 = 3, num3cuadrante4 = 2;
            bool correcto = true;
            int num2cuadrante2 = 0, num3cuadrante2 = 0, num4cuadrante2 = 0, num4cuadrante1 = 0, num2cuadrante3 = 0, num3cuadrante3 = 0, num4cuadrante3 = 0, num4cuadrante4 = 0;
            
            Console.Write("------------------"); Console.WriteLine("                           <---- Cuadrante 1 y 3");
            Console.WriteLine("|   |   ||   |   |");
            Console.WriteLine($"| {num1cuadrante1} | {num2cuadrante1} || - | - |");
            Console.WriteLine("--------  --------");
            Console.WriteLine("|   |   ||   |   |");
            Console.WriteLine($"| {num3cuadrante1} | - || - | {num1cuadrante3} |");
            Console.WriteLine("--------  --------");
            Console.Write("------------------"); Console.WriteLine("                           <---- Cuadrante 2 y 4");
            Console.WriteLine("|   |   ||   |   |");
            Console.WriteLine($"| - | - || {num1cuadrante4} | - |");
            Console.WriteLine("--------  --------");
            Console.WriteLine("|   |   ||   |   |");
            Console.WriteLine($"| {num1cuadrante2} | - || {num2cuadrante4} | {num3cuadrante4} |");
            Console.WriteLine("------------------");

            Console.WriteLine("¿Podrá lograr el Sudoku?: Presione una tecla para continuar");
            Console.ReadKey();
            Console.WriteLine("");

            try
            {
                Console.Write("¿Cuál es el número de la primera columna del segundo cuadrante? --> ");

                 num2cuadrante2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("--> Introduce un Número");
            }

            do
            {
                while (num2cuadrante2 != 2)
                {
                    Console.WriteLine("--> Número Incorrecto"); Console.WriteLine("");
                    Console.Write("¿Cuál es el número de la primera columna del segundo cuadrante? --> ");
                    num2cuadrante2 = Convert.ToInt32(Console.ReadLine());
                    correcto = false;
                }
                if (num2cuadrante2 == 2)
                {
                    Console.WriteLine("Número Correcto");
                    correcto = false;
                }
            } while (correcto != false && num2cuadrante2 != 2);

                Console.Clear();
                Console.WriteLine("");
                Console.Write("------------------"); Console.WriteLine("                           <---- Cuadrante 1 y 3");
                Console.WriteLine("|   |   ||   |   |");
                Console.WriteLine($"| {num1cuadrante1} | {num2cuadrante1} || - | - |");
                Console.WriteLine("--------  --------");
                Console.WriteLine("|   |   ||   |   |");
                Console.WriteLine($"| {num3cuadrante1} | - || - | {num1cuadrante3} |");
                Console.WriteLine("--------  --------");
                Console.Write("------------------"); Console.WriteLine("                           <---- Cuadrante 2 y 4");
                Console.WriteLine("|   |   ||   |   |");
                Console.WriteLine($"| {num2cuadrante2} | - || {num1cuadrante4} | - |");
                Console.WriteLine("--------  --------");
                Console.WriteLine("|   |   ||   |   |");
                Console.WriteLine($"| {num1cuadrante2} | - || {num2cuadrante4} | {num3cuadrante4} |");
                Console.WriteLine("------------------");

            try
            {
                Console.Write("¿Cuál es el número de la segunda fila del segundo cuadrante? --> ");
                correcto = true;
                num4cuadrante2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("--> Introduce un Número");
            }
            do
                {
                    while (num4cuadrante2 != 1)
                    {
                        Console.WriteLine("--> Número Incorrecto"); Console.WriteLine("");
                        Console.Write("¿Cuál es el número de la segunda fila del segundo cuadrante? --> ");
                        num4cuadrante2 = Convert.ToInt32(Console.ReadLine());
                        correcto = false;
                    }
                    if (num4cuadrante2 == 1)
                    {
                        Console.WriteLine("Número Correcto");
                        correcto = false;
                    }
                } while (correcto != false && num4cuadrante2 != 1);

                Console.Clear();
                Console.WriteLine("");
                Console.Write("------------------"); Console.WriteLine("                           <---- Cuadrante 1 y 3");
                Console.WriteLine("|   |   ||   |   |");
                Console.WriteLine($"| {num1cuadrante1} | {num2cuadrante1} || - | - |");
                Console.WriteLine("--------  --------");
                Console.WriteLine("|   |   ||   |   |");
                Console.WriteLine($"| {num3cuadrante1} | - || - | {num1cuadrante3} |");
                Console.WriteLine("--------  --------");
                Console.Write("------------------"); Console.WriteLine("                           <---- Cuadrante 2 y 4");
                Console.WriteLine("|   |   ||   |   |");
                Console.WriteLine($"| {num2cuadrante2} | - || {num1cuadrante4} | - |");
                Console.WriteLine("--------  --------");
                Console.WriteLine("|   |   ||   |   |");
                Console.WriteLine($"| {num1cuadrante2} | {num4cuadrante2} || {num2cuadrante4} | {num3cuadrante4} |");
                Console.WriteLine("------------------");

            try
            {
                Console.Write("¿Cuál es el número de la primera fila del segundo cuadrante? --> ");
                correcto = true;
                num3cuadrante2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("--> Introduce un Número");
            }
            do
            {
                while (num3cuadrante2 != 3)
                {
                    Console.WriteLine("--> Número Incorrecto"); Console.WriteLine("");
                    Console.Write("¿Cuál es el número de la primera fila del segundo cuadrante? --> ");
                    num3cuadrante2 = Convert.ToInt32(Console.ReadLine());
                    correcto = false;
                }
                if (num3cuadrante2 == 3)
                {
                    Console.WriteLine("Número Correcto");
                    correcto = false;
                }
            } while (correcto != false && num3cuadrante2 != 3);

            Console.Clear();
            Console.WriteLine("");
            Console.Write("------------------"); Console.WriteLine("                           <---- Cuadrante 1 y 3");
            Console.WriteLine("|   |   ||   |   |");
            Console.WriteLine($"| {num1cuadrante1} | {num2cuadrante1} || - | - |");
            Console.WriteLine("--------  --------");
            Console.WriteLine("|   |   ||   |   |");
            Console.WriteLine($"| {num3cuadrante1} | - || - | {num1cuadrante3} |");
            Console.WriteLine("--------  --------");
            Console.Write("------------------"); Console.WriteLine("                           <---- Cuadrante 2 y 4");
            Console.WriteLine("|   |   ||   |   |");
            Console.WriteLine($"| {num2cuadrante2} | {num3cuadrante2} || {num1cuadrante4} | - |");
            Console.WriteLine("--------  --------");
            Console.WriteLine("|   |   ||   |   |");
            Console.WriteLine($"| {num1cuadrante2} | {num4cuadrante2} || {num2cuadrante4} | {num3cuadrante4} |");
            Console.WriteLine("------------------");

            try
            {
                Console.Write("¿Cuál es el número de la primera fila del cuarto cuadrante? --> ");
                correcto = true;
                num4cuadrante4 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("--> Introduce un Número");
            }
            do
            {
                while (num4cuadrante4 != 4)
                {
                    Console.WriteLine("--> Número Incorrecto"); Console.WriteLine("");
                    Console.Write("¿Cuál es el número de la primera fila del cuarto cuadrante? --> ");
                    num4cuadrante4 = Convert.ToInt32(Console.ReadLine());
                    correcto = false;
                }
                if (num4cuadrante4 == 4)
                {
                    Console.WriteLine("Número Correcto");
                    correcto = false;
                }
            } while (correcto != false && num4cuadrante4 != 4);

            Console.Clear();
            Console.WriteLine("");
            Console.Write("------------------"); Console.WriteLine("                           <---- Cuadrante 1 y 3");
            Console.WriteLine("|   |   ||   |   |");
            Console.WriteLine($"| {num1cuadrante1} | {num2cuadrante1} || - | - |");
            Console.WriteLine("--------  --------");
            Console.WriteLine("|   |   ||   |   |");
            Console.WriteLine($"| {num3cuadrante1} | - || - | {num1cuadrante3} |");
            Console.WriteLine("--------  --------");
            Console.Write("------------------"); Console.WriteLine("                           <---- Cuadrante 2 y 4");
            Console.WriteLine("|   |   ||   |   |");
            Console.WriteLine($"| {num2cuadrante2} | {num3cuadrante2} || {num1cuadrante4} | {num4cuadrante4} |");
            Console.WriteLine("--------  --------");
            Console.WriteLine("|   |   ||   |   |");
            Console.WriteLine($"| {num1cuadrante2} | {num4cuadrante2} || {num2cuadrante4} | {num3cuadrante4} |");
            Console.WriteLine("------------------");

            try
            {
                Console.Write("¿Cuál es el número de la segunda fila del primer cuadrante? --> ");
                correcto = true;
                num4cuadrante1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("--> Introduce un Número");
            }
            do
            {
                while (num4cuadrante1 != 4)
                {
                    Console.WriteLine("--> Número Incorrecto"); Console.WriteLine("");
                    Console.Write("¿Cuál es el número de la segunda fila del primer cuadrante? --> ");
                    num4cuadrante1 = Convert.ToInt32(Console.ReadLine());
                    correcto = false;
                }
                if (num4cuadrante1 == 4)
                {
                    Console.WriteLine("Número Correcto");
                    correcto = false;
                }
            } while (correcto != false && num4cuadrante1 != 4);

            Console.Clear();
            Console.WriteLine("");
            Console.Write("------------------"); Console.WriteLine("                           <---- Cuadrante 1 y 3");
            Console.WriteLine("|   |   ||   |   |");
            Console.WriteLine($"| {num1cuadrante1} | {num2cuadrante1} || - | - |");
            Console.WriteLine("--------  --------");
            Console.WriteLine("|   |   ||   |   |");
            Console.WriteLine($"| {num3cuadrante1} | {num4cuadrante1} || - | {num1cuadrante3} |");
            Console.WriteLine("--------  --------");
            Console.Write("------------------"); Console.WriteLine("                           <---- Cuadrante 2 y 4");
            Console.WriteLine("|   |   ||   |   |");
            Console.WriteLine($"| {num2cuadrante2} | {num3cuadrante2} || {num1cuadrante4} | {num4cuadrante4} |");
            Console.WriteLine("--------  --------");
            Console.WriteLine("|   |   ||   |   |");
            Console.WriteLine($"| {num1cuadrante2} | {num4cuadrante2} || {num2cuadrante4} | {num3cuadrante4} |");
            Console.WriteLine("------------------");

            try
            {
                Console.Write("¿Cuál es el número de la segunda fila del tercer cuadrante? --> ");
                correcto = true;
                num4cuadrante3 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("--> Introduce un Número");
            }
            do
            {
                while (num4cuadrante3 != 2)
                {
                    Console.WriteLine("--> Número Incorrecto"); Console.WriteLine("");
                    Console.Write("¿Cuál es el número de la segunda fila del tercer cuadrante? --> ");
                    num4cuadrante3 = Convert.ToInt32(Console.ReadLine());
                    correcto = false;
                }
                if (num4cuadrante3 == 2)
                {
                    Console.WriteLine("Número Correcto");
                    correcto = false;
                }
            } while (correcto != false && num4cuadrante3 != 2);

            Console.Clear();
            Console.WriteLine("");
            Console.Write("------------------"); Console.WriteLine("                           <---- Cuadrante 1 y 3");
            Console.WriteLine("|   |   ||   |   |");
            Console.WriteLine($"| {num1cuadrante1} | {num2cuadrante1} || - | - |");
            Console.WriteLine("--------  --------");
            Console.WriteLine("|   |   ||   |   |");
            Console.WriteLine($"| {num3cuadrante1} | {num4cuadrante1} || {num4cuadrante3} | {num1cuadrante3} |");
            Console.WriteLine("--------  --------");
            Console.Write("------------------"); Console.WriteLine("                           <---- Cuadrante 2 y 4");
            Console.WriteLine("|   |   ||   |   |");
            Console.WriteLine($"| {num2cuadrante2} | {num3cuadrante2} || {num1cuadrante4} | {num4cuadrante4} |");
            Console.WriteLine("--------  --------");
            Console.WriteLine("|   |   ||   |   |");
            Console.WriteLine($"| {num1cuadrante2} | {num4cuadrante2} || {num2cuadrante4} | {num3cuadrante4} |");
            Console.WriteLine("------------------");

            try
            {
                Console.Write("¿Cuál es el número de la primera columna del tercer cuadrante? --> ");
                correcto = true;
                num2cuadrante3 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("--> Introduce un Número");
            }
            do
            {
                while (num2cuadrante3 != 4)
                {
                    Console.WriteLine("--> Número Incorrecto"); Console.WriteLine("");
                    Console.Write("¿Cuál es el número de la primera columna del tercer cuadrante? --> ");
                    num2cuadrante3 = Convert.ToInt32(Console.ReadLine());
                    correcto = false;
                }
                if (num2cuadrante3 == 4)
                {
                    Console.WriteLine("Número Correcto");
                    correcto = false;
                }
            } while (correcto != false && num2cuadrante3 != 4);

            Console.Clear();
            Console.WriteLine("");
            Console.Write("------------------"); Console.WriteLine("                           <---- Cuadrante 1 y 3");
            Console.WriteLine("|   |   ||   |   |");
            Console.WriteLine($"| {num1cuadrante1} | {num2cuadrante1} || {num2cuadrante3} | - |");
            Console.WriteLine("--------  --------");
            Console.WriteLine("|   |   ||   |   |");
            Console.WriteLine($"| {num3cuadrante1} | {num4cuadrante1} || {num4cuadrante3} | {num1cuadrante3} |");
            Console.WriteLine("--------  --------");
            Console.Write("------------------"); Console.WriteLine("                           <---- Cuadrante 2 y 4");
            Console.WriteLine("|   |   ||   |   |");
            Console.WriteLine($"| {num2cuadrante2} | {num3cuadrante2} || {num1cuadrante4} | {num4cuadrante4} |");
            Console.WriteLine("--------  --------");
            Console.WriteLine("|   |   ||   |   |");
            Console.WriteLine($"| {num1cuadrante2} | {num4cuadrante2} || {num2cuadrante4} | {num3cuadrante4} |");
            Console.WriteLine("------------------");

            try
            {
                Console.Write("¿Cuál es el número de la segunda columna del tercer cuadrante? --> ");
                correcto = true;
                num3cuadrante3 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("--> Introduce un Número");
            }
            do
            {
                while (num3cuadrante3 != 1)
                {
                    Console.WriteLine("--> Número Incorrecto"); Console.WriteLine("");
                    Console.Write("¿Cuál es el número de la segunda columna del tercer cuadrante? --> ");
                    num3cuadrante3 = Convert.ToInt32(Console.ReadLine());
                    correcto = false;
                }
                if (num3cuadrante3 == 1)
                {
                    Console.WriteLine("Número Correcto");
                    correcto = false;
                }
            } while (correcto != false && num3cuadrante3 != 1);

            Console.Clear();
            Console.WriteLine("");
            Console.Write("------------------"); Console.WriteLine("                           <---- Cuadrante 1 y 3");
            Console.WriteLine("|   |   ||   |   |");
            Console.WriteLine($"| {num1cuadrante1} | {num2cuadrante1} || {num2cuadrante3} | {num3cuadrante3} |");
            Console.WriteLine("--------  --------");
            Console.WriteLine("|   |   ||   |   |");
            Console.WriteLine($"| {num3cuadrante1} | {num4cuadrante1} || {num4cuadrante3} | {num1cuadrante3} |");
            Console.WriteLine("--------  --------");
            Console.Write("------------------"); Console.WriteLine("                           <---- Cuadrante 2 y 4");
            Console.WriteLine("|   |   ||   |   |");
            Console.WriteLine($"| {num2cuadrante2} | {num3cuadrante2} || {num1cuadrante4} | {num4cuadrante4} |");
            Console.WriteLine("--------  --------");
            Console.WriteLine("|   |   ||   |   |");
            Console.WriteLine($"| {num1cuadrante2} | {num4cuadrante2} || {num2cuadrante4} | {num3cuadrante4} |");
            Console.WriteLine("------------------");

            Console.Clear();
            Console.WriteLine("Increible, lo conseguiste.");
            Console.WriteLine("¡¡Has Ganado!!");
        }
    }
}
