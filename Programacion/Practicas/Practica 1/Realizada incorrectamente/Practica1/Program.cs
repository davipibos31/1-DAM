using System;

namespace Practica1
{
    class numero
    {
        //-----------------------------------------
        //  David Piñuel Bosque
        //  Curso DAM
        //  Modalidad Presencial
        //  Práctica nº 1
        //-----------------------------------------


        
        
        static void Main(string[] args)
        {
            salida:

            // Creamos y iniciamos las variables

            int suma = 0;
            int resta = 0;
            int multiplicacion = 1;
            int division = 1;
            int num = 0;

            // Una vez creadas las variables realizamos que pida al usuario el primer número para realizar la operación

            Console.Write("Introduce un número: ");
            num = Convert.ToInt32(Console.ReadLine());

            // En este while lo que hacemos es que solo sea un dígito del 0 al 9, sino salte un error y vuelva a repetir el número; dando asi a la restricción marcada

            while ((num < 0) || (num > 9))
            {
                if ((num < 0) || (num > 9))
                {
                    Console.WriteLine("--->Número Incorrecto");
                    Console.Write("Introduce un número: ");
                    num = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Una vez ya esta el primer número creamos las operaciones para ello hacemos que el usuario indique la operación que quiere

            char operacion;
            Console.Write("Introduce una operación: ");
            operacion = Convert.ToChar(Console.ReadLine());

            /*
             En este bucle lo que hace es que todo caracter que no sea +,-,*,/,= de error y tenga que volver a repetir
             Una vez dentro del While usamos dos for anidados para cada signo, el primero lo usamos para que pueda seguir operando
             Y el segundo para poder realizar y mostrar dichas operaciones; creando dentro de este for un segundo número que le pedimos al usuario
             Con las mismas restricciones que el primero y se repita tantas veces como opere hasta que o bien no quiera seguir más operando y quiera el resultado
             Entonces tendrá que poner en la operacion S o quiera seguir operando pero quiera saber el resultado entonces pondrá =
             Cuando el usuario escribe = salta al principio del programa para que pueda volver a realizar las operaciones
             Cuando el usuario escribe S salte al final del codigo para que muestre el final del programa y finalice totalmente
            */

            while ((operacion != '+') || (operacion != '-') || (operacion != '*') || (operacion != '/') || (operacion != '='))
            {
                for (; operacion == '+';)
                {
                    for (; operacion == '+';)
                    {
                        int num1;
                        Console.Write("Introduce un número: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        while ((num1 < 0) || (num1 > 9))
                        {
                            if ((num1 < 0) || (num1 > 9))
                            {
                                Console.WriteLine("--->Número Incorrecto");
                                Console.Write("Introduce un número: ");
                                num1 = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        suma = suma + num + num1;
                        //Console.WriteLine("El resultado es {0}", suma);
                        num = 0;
                        Console.Write("Introduce una operación: ");
                        operacion = Convert.ToChar(Console.ReadLine());
                    }
                    for (; operacion == '=';)
                    {
                        Console.WriteLine("El resultado es {0}", suma);
                        Console.WriteLine();
                        goto salida;
                    }
                    for (; operacion == 'S';)
                    {
                        Console.WriteLine("El resultado es {0}", suma);
                        Console.WriteLine();
                        goto final;
                    }
                }
                for (; operacion == '-';)
                {
                    for (; operacion == '-';)
                    {
                        int num1;
                        Console.Write("Introduce un número: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        while ((num1 < 0) || (num1 > 9))
                        {
                            if ((num1 < 0) || (num1 > 9))
                            {
                                Console.WriteLine("--->Número Incorrecto");
                                Console.Write("Introduce un número: ");
                                num1 = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        resta = resta - (num1 - num);
                        num = 0;
                        
                        Console.Write("Introduce una operación: ");
                        operacion = Convert.ToChar(Console.ReadLine());
                    }
                    for (; operacion == '=';)
                    {
                        Console.WriteLine("El resultado es {0}", resta);
                        Console.WriteLine();
                        goto salida;
                    }
                    for (; operacion == 'S';)
                    {
                        Console.WriteLine("El resultado es {0}", resta);
                        Console.WriteLine();
                        goto final;
                    }
                }
                for (; operacion == '*';)
                {
                    for (; operacion == '*';)
                    {
                        int num1;
                        Console.Write("Introduce un número: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        while ((num1 < 0) || (num1 > 9))
                        {
                            if ((num1 < 0) || (num1 > 9))
                            {
                                Console.WriteLine("--->Número Incorrecto");
                                Console.Write("Introduce un número: ");
                                num1 = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        multiplicacion = multiplicacion * num * num1;
                        num = 1;
                        Console.Write("Introduce una operación: ");
                        operacion = Convert.ToChar(Console.ReadLine());
                    }
                    for (; operacion == '=';)
                    {
                        Console.WriteLine("El resultado es {0}", multiplicacion);
                        Console.WriteLine();
                        goto salida;
                    }
                    for (; operacion == 'S';)
                    {
                        Console.WriteLine("El resultado es {0}", multiplicacion);
                        Console.WriteLine();
                        goto final;
                    }
                }
                for (; operacion == '/';)
                {
                    for (; operacion == '/';)
                    {
                        int num1;
                        Console.Write("Introduce un número: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        while ((num1 < 0) || (num1 > 9))
                        {
                            if ((num1 < 0) || (num1 > 9))
                            {
                                Console.WriteLine("--->Número Incorrecto");
                                Console.Write("Introduce un número: ");
                                num1 = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        if (num % num1 == 0)
                        {
                            if (division != 1)
                            {
                                division = division  / num1;
                                
                            }
                            else
                                division = num / num1;
                        }
                        else if (num % num1 != 0)
                        {
                            Console.WriteLine("--->Error División");
                            Console.WriteLine();
                            goto salida;
                        }
                        
                        Console.Write("Introduce una operación: ");
                        operacion = Convert.ToChar(Console.ReadLine()); 
                    }
                    for (; operacion == '=';)
                    {
                       Console.WriteLine("El resultado es {0}", division);
                       Console.WriteLine();
                       goto salida; 
                    }
                    for (; operacion == 'S';)
                    {
                        Console.WriteLine("El resultado es {0}", division);
                        Console.WriteLine();
                        goto final;
                    }
                }
                Console.WriteLine("--->Operación Incorrecta");
                Console.Write("Introduce una operación: ");
                operacion = Convert.ToChar(Console.ReadLine());
                
            }
            final:
            Console.WriteLine("Final de Programa");
        }
    }
}
    
