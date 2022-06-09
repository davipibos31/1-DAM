using System;

namespace Tarea1
{
    class Program
    {
        // --------------------------------------------
        // Carlos Martínez
        // Curso DAM/DAW
        // Modalidad Presencial/SemiPresencial
        // Práctica nº 1
        // --------------------------------------------
        static void Main(string[] args)
        {
            int resultado = 0;
            int numero = 0;
            char operacion = ' ';
            bool incorrecto = true, incorrecta = true;

            do
            {
                do
                {
                    incorrecto = true;
                    do
                    {
                        try
                        {
                            Console.Write("Introduce un número: ");
                            numero = Convert.ToInt32(Console.ReadLine());
                            incorrecto = false;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("--> Número incorrecto");
                        }
                    } while (incorrecto);
                    

                    if (operacion != ' ')
                    {
                        switch (operacion)
                        {
                            case '+': resultado += numero; break;
                            case '-': resultado -= numero; break;
                            case '/':
                                try
                                {
                                    resultado /= numero;
                                }
                                catch (DivideByZeroException)
                                {
                                    Console.WriteLine("--> No se puede dividir entre 0");
                                }
                                break;
                            case '*': resultado *= numero; break;
                        }
                    } else
                    {
                        resultado = numero;
                    }

                    do
                    {
                        try
                        {
                            Console.Write("Introduce una operación: ");
                            operacion = Convert.ToChar(Console.ReadLine());

                            switch (operacion)
                            {
                                case '+': case '-': case '/': case '*': case '=': case 's': incorrecta = false; break;
                                default: throw new Exception();
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("--> Operación incorrecta");
                        }
                    } while (incorrecta);
                    incorrecta = true;
                } while (operacion != '=' && operacion != 's');
                
                Console.WriteLine("El resultado es {0}\n", resultado);
                if (operacion != 's')
                    operacion = ' ';
            } while (operacion != 's'); // operacion == 's' --> SALIR
            Console.WriteLine("FIN PROGRAMA");
        }
    }
}
