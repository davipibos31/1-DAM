using System;

namespace r
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
            salida: int suma = 0; int resta = 0; int multiplicacion = 1; int division = 1; int num = 0; bool mensaje = true;
            do                                                 // Una vez creadas las variables realizamos que pida al usuario el primer número para realizar la operación
            {                                                  // En este do while lo que hacemos es que pida un número sino salte un error y vuelva a repetir el número; 
                try                                            //dando asi a la restricción marcada también si es overflow o si es otro formato
                {
                    Console.Write("Introduce un número: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    mensaje = false;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("--->Número Incorrecto"); Console.WriteLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("--->Número Incorrecto"); Console.WriteLine();
                }
            } while (mensaje);
            mensaje = true; char operacion = '0';                  // Una vez ya esta el primer número creamos las operaciones para ello hacemos que el usuario indique la operación 
            do                                                    // En este do while lo que hacemos es que mientras sea verdadera pueda entrar y se repita, sino salte un error  
            {                                                    // y vuelva a repetir la operación; dando asi a la restricción marcada también si hace overflow o si es otro formato
                try
                {
                    Console.Write("Introduce una operación: ");
                    operacion = Convert.ToChar(Console.ReadLine()); mensaje = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("--->Número Incorrecto"); Console.WriteLine();
                }
            } while (mensaje);
            while ((operacion != '+') || (operacion != '-') || (operacion != '*') || (operacion != '/') || (operacion != '=') || (operacion != 'S'))
            {                                                  // En este bucle lo que hace es que todo caracter que no sea +,-,*,/,=,S de error y tenga que volver a repetir
                while ( operacion == '+')                     // Una vez dentro del While usamos dos for anidados para cada signo, el primero lo usamos para que pueda seguir operando
                {
                    while ( operacion == '+')                // Y el segundo para poder realizar y mostrar dichas operaciones; creando dentro de este for un segundo número 
                    {                                       // que le pedimos al usuario con las mismas restricciones que el primero y se repita tantas veces como opere hasta que 
                        mensaje = true;                    // o bien no quiera seguir más operando y quiera el resultado entonces tendrá que poner en la operacion S o quiera seguir operando
                        do                                // pero quiera saber el resultado entonces pondrá =
                        {                                // Cuando el usuario escribe = salta al principio del programa para que pueda volver a realizar las operaciones
                            try                         // Cuando el usuario escribe S salte al final del codigo para que muestre el final del programa y finalice totalmente
                            {
                                int num1 = 0; Console.Write("Introduce un número: ");
                                num1 = Convert.ToInt32(Console.ReadLine());
                                suma = suma + num + num1; mensaje = false;
                            }
                            catch (OverflowException)
                            {
                                Console.WriteLine("--->Número Incorrecto"); Console.WriteLine();
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("--->Número Incorrecto"); Console.WriteLine();
                            }
                        } while (mensaje);
                        num = 0; mensaje = true;
                        do                                                                          //En este do while lo hacemos para que pueda realizar más operaciones o con esta pueda 
                        {                                                                           // sacar el resultado por que si solo se inserta un numero el = y S no deberian de poder
                            try                                                                     //operar; tambien marcando sus restricciones
                            {
                                Console.Write("Introduce una operación: ");
                                operacion = Convert.ToChar(Console.ReadLine()); mensaje = false;
                                /*for (; operacion == '-';)
                                {
                                    for (; operacion == '-';)
                                    {
                                        mensaje = true;
                                        do
                                        {
                                            try
                                            {
                                                int num1 = 0; Console.Write("Introduce un número: ");
                                                num1 = Convert.ToInt32(Console.ReadLine());
                                                resta = suma - resta - (num1 - num); suma = resta; mensaje = false;
                                            }
                                            catch (OverflowException)
                                            {
                                                Console.WriteLine("--->Número Incorrecto"); Console.WriteLine();
                                            }
                                            catch (FormatException)
                                            {
                                                Console.WriteLine("--->Número Incorrecto"); Console.WriteLine();
                                            }
                                        } while (mensaje);
                                        num = 0; mensaje = true;
                                        do
                                        {
                                            try
                                            {
                                                Console.Write("Introduce una operación: ");
                                                operacion = Convert.ToChar(Console.ReadLine()); mensaje = false;
                                            }
                                            catch (FormatException)
                                            {
                                                Console.WriteLine("--->Operación Incorrecta"); Console.WriteLine();
                                            }
                                        } while (mensaje);
                                    }
                                    for (; operacion == '=';)
                                    {
                                        Console.WriteLine("El resultado es {0}", suma); Console.WriteLine();
                                        goto salida;
                                    }
                                    for (; operacion == 'S';)
                                    {
                                        Console.WriteLine("El resultado es {0}", suma); Console.WriteLine();
                                        goto final;
                                    }
                                }
                                for (; operacion == '*';)
                                {
                                    for (; operacion == '*';)
                                    {
                                        mensaje = true;
                                        do
                                        {
                                            try
                                            {
                                                int num1 = 0; Console.Write("Introduce un número: ");
                                                num1 = Convert.ToInt32(Console.ReadLine());
                                                multiplicacion = suma * multiplicacion * num1; mensaje = false;
                                            }
                                            catch (OverflowException)
                                            {
                                                Console.WriteLine("--->Número Incorrecto"); Console.WriteLine();
                                            }
                                            catch (FormatException)
                                            {
                                                Console.WriteLine("--->Número Incorrecto"); Console.WriteLine();
                                            }
                                        } while (mensaje);
                                        num = 1; mensaje = true;
                                        do
                                        {
                                            try
                                            {
                                                Console.Write("Introduce una operación: ");
                                                operacion = Convert.ToChar(Console.ReadLine()); mensaje = false;
                                            }
                                            catch (FormatException)
                                            {
                                                Console.WriteLine("--->Operación Incorrecta"); Console.WriteLine();
                                            }
                                        } while (mensaje);
                                    }
                                    for (; operacion == '=';)
                                    {
                                        Console.WriteLine("El resultado es {0}", multiplicacion); Console.WriteLine();
                                        goto salida;
                                    }
                                    for (; operacion == 'S';)
                                    {
                                        Console.WriteLine("El resultado es {0}", multiplicacion); Console.WriteLine();
                                        goto final;
                                    }
                                }
                                for (; operacion == '/';)
                                {
                                    for (; operacion == '/';)
                                    {
                                        mensaje = true;
                                        do
                                        {
                                            try
                                            {
                                                int num1 = 0; Console.Write("Introduce un número: ");
                                                num1 = Convert.ToInt32(Console.ReadLine());
                                                if (num % num1 == 0)
                                                {
                                                    if (division != 1)
                                                        division = division / num1;
                                                    else
                                                        division = num / num1;
                                                }
                                                mensaje = false;
                                            }
                                            catch (OverflowException)
                                            {
                                                Console.WriteLine("--->Número Incorrecto"); Console.WriteLine();
                                            }
                                            catch (FormatException)
                                            {
                                                Console.WriteLine("--->Número Incorrecto"); Console.WriteLine();
                                            }
                                            catch (DivideByZeroException)                                              //Ésta restrinción es por no se puede dividir entre 0 matemáticamente y de error
                                            {
                                                Console.WriteLine("--->Operación Incorrecta"); Console.WriteLine();
                                            }
                                        } while (mensaje);
                                        mensaje = true;
                                        do
                                        {
                                            try
                                            {
                                                Console.Write("Introduce una operación: ");
                                                operacion = Convert.ToChar(Console.ReadLine()); mensaje = false;
                                            }
                                            catch (FormatException)
                                            {
                                                Console.WriteLine("--->Operación Incorrecta"); Console.WriteLine();
                                            }
                                        } while (mensaje);
                                    }
                                    for (; operacion == '=';)
                                    {
                                        Console.WriteLine("El resultado es {0}", division); Console.WriteLine();
                                        goto salida;
                                    }
                                    for (; operacion == 'S';)
                                    {
                                        Console.WriteLine("El resultado es {0}", division); Console.WriteLine();
                                        goto final;
                                    }
                                }*/
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("--->Operación Incorrecta");
                            }
                        } while (mensaje);break;
                    }
                    for (; operacion == '=';)                                                     // mostraria la suma y salta al principio
                    {
                        Console.WriteLine("El resultado es {0}", suma); Console.WriteLine();
                        goto salida;
                    }
                    for (; operacion == 'S';)                                                      // mostraria la suma y salta al final
                    {
                        Console.WriteLine("El resultado es {0}", suma); Console.WriteLine();
                        goto final;
                    }
                    break;
                }                                                                                  //apartir de aqui ya es todo igual con la resta, multiplicación y división
                for (; operacion == '-';)
                {
                    for (; operacion == '-';)
                    {
                        mensaje = true;
                        do
                        {
                            try
                            {
                                int num1 = 0; Console.Write("Introduce un número: ");
                                num1 = Convert.ToInt32(Console.ReadLine());
                                resta = resta - (num1 - num); mensaje = false;
                            }
                            catch (OverflowException)
                            {
                                Console.WriteLine("--->Número Incorrecto"); Console.WriteLine();
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("--->Número Incorrecto"); Console.WriteLine();
                            }
                        } while (mensaje);
                        num = 0; mensaje = true;
                        do
                        {
                            try
                            {
                                Console.Write("Introduce una operación: ");
                                operacion = Convert.ToChar(Console.ReadLine()); mensaje = false;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("--->Operación Incorrecta"); Console.WriteLine();
                            }
                        } while (mensaje);
                    }
                    for (; operacion == '=';)
                    {
                        Console.WriteLine("El resultado es {0}", resta); Console.WriteLine();
                        goto salida;
                    }
                    for (; operacion == 'S';)
                    {
                        Console.WriteLine("El resultado es {0}", resta); Console.WriteLine();
                        goto final;
                    }
                }
                for (; operacion == '*';)
                {
                    for (; operacion == '*';)
                    {
                        mensaje = true;
                        do
                        {
                            try
                            {
                                int num1 = 0; Console.Write("Introduce un número: ");
                                num1 = Convert.ToInt32(Console.ReadLine());
                                multiplicacion = multiplicacion * num * num1; mensaje = false;
                            }
                            catch (OverflowException)
                            {
                                Console.WriteLine("--->Número Incorrecto"); Console.WriteLine();
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("--->Número Incorrecto"); Console.WriteLine();
                            }
                        } while (mensaje);
                        num = 1; mensaje = true;
                        do
                        {
                            try
                            {
                                Console.Write("Introduce una operación: ");
                                operacion = Convert.ToChar(Console.ReadLine()); mensaje = false;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("--->Operación Incorrecta"); Console.WriteLine();
                            }
                        } while (mensaje);
                    }
                    for (; operacion == '=';)
                    {
                        Console.WriteLine("El resultado es {0}", multiplicacion); Console.WriteLine();
                        goto salida;
                    }
                    for (; operacion == 'S';)
                    {
                        Console.WriteLine("El resultado es {0}", multiplicacion); Console.WriteLine();
                        goto final;
                    }
                }
                for (; operacion == '/';)
                {
                    for (; operacion == '/';)
                    {
                        mensaje = true;
                        do
                        {
                            try
                            {
                                int num1 = 0; Console.Write("Introduce un número: ");
                                num1 = Convert.ToInt32(Console.ReadLine());
                                if (num % num1 == 0)
                                {
                                    if (division != 1)
                                        division = division / num1;
                                    else
                                        division = num / num1;
                                }
                                mensaje = false;
                            }
                            catch (OverflowException)
                            {
                                Console.WriteLine("--->Número Incorrecto"); Console.WriteLine();
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("--->Número Incorrecto"); Console.WriteLine();
                            }
                            catch (DivideByZeroException)                                              //Ésta restrinción es por no se puede dividir entre 0 matemáticamente y de error
                            {
                                Console.WriteLine("--->Operación Incorrecta"); Console.WriteLine();
                            }
                        } while (mensaje);
                        mensaje = true;
                        do
                        {
                            try
                            {
                                Console.Write("Introduce una operación: ");
                                operacion = Convert.ToChar(Console.ReadLine()); mensaje = false;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("--->Operación Incorrecta"); Console.WriteLine();
                            }
                        } while (mensaje);
                    }
                    for (; operacion == '=';)
                    {
                        Console.WriteLine("El resultado es {0}", division); Console.WriteLine();
                        goto salida;
                    }
                    for (; operacion == 'S';)
                    {
                        Console.WriteLine("El resultado es {0}", division); Console.WriteLine();
                        goto final;
                    }
                }
                mensaje = true;
                do
                {
                    try
                    {
                        Console.WriteLine("--->Operación Incorrecta"); Console.Write("Introduce una operación: ");
                        operacion = Convert.ToChar(Console.ReadLine()); mensaje = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("--->Operación Incorrecta"); Console.WriteLine();
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("--->Operación Incorrecta"); Console.WriteLine();
                    }
                } while (mensaje);
            }
            final: Console.WriteLine("Final de Programa");                          //Final del programa
        }                                                                          //Saludos espero que este bien y lo más importante le haya gustado
    }
}
