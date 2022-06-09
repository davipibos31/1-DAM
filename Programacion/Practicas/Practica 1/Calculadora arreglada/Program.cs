using System;

namespace Calculadora_arreglada
{
    class Program
    {
        //-----------------------------------------
        //  David Piñuel Bosque
        //  Curso DAM
        //  Modalidad Presencial
        //  Práctica nº 1
        //-----------------------------------------
        static void Main(string[] args)                                                                         //He corregido la práctica pero no he hecho lo adicional.
        {
            int primero = 0, primero1 = 0, resultado = primero1; char operacion = '0'; bool simbolo = true;
            do
            {
                do {
                    try
                    {
                        Console.Write("Introduce un número: ");
                        primero1 = Convert.ToInt32(Console.ReadLine()); resultado = primero1;       //poniendo este resultado a primer numero sale al darle igual en la primera operacion el numero en vez de 0
                        simbolo = false;
                    }                                                                               //En este bucle do while lo que quiero hacer es la restricción marcada de los números enteros
                    catch (FormatException)
                    {
                        Console.WriteLine("---> Número Incorrecto");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("---> Número Incorrecto");
                    }
                    catch (StackOverflowException)
                    {
                        Console.WriteLine("---> Número Incorrecto");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("---> Número Incorrecto");
                    }
                } while (simbolo == true); simbolo = true;

                do
                {
                    do
                    {
                        do
                        {
                            try
                            {
                                Console.Write("Introduce una operación: ");
                                operacion = Convert.ToChar(Console.ReadLine());
                                simbolo = false;
                            }                                                                                   //En este bucle do while lo que quiero hacer es la restricción marcada de los caracteres
                            catch (FormatException)
                            {
                                Console.WriteLine("---> Operación Incorrecta");
                            }
                            catch (OverflowException)
                            {
                                Console.WriteLine("---> Operación Incorrecta");
                            }
                            catch (StackOverflowException)
                            {
                                Console.WriteLine("---> Operación Incorrecta");
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("---> Operación Incorrecta");
                            }
                        } while (simbolo == true); simbolo = true;

                        switch (operacion)                                                                                  //Un switch con cada caso posible de operaciones +,-,*,/
                        {
                            case '+':
                                do {
                                    try
                                    {
                                        Console.Write("Introduce un número: ");
                                        primero = Convert.ToInt32(Console.ReadLine());
                                        simbolo = false;
                                    }                                                                             //En este bucle do while lo que quiero hacer es la restricción marcada de los números enteros
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("---> Número Incorrecto");
                                    }
                                    catch (OverflowException)
                                    {
                                        Console.WriteLine("---> Número Incorrecto");
                                    }
                                    catch (StackOverflowException)
                                    {
                                        Console.WriteLine("---> Número Incorrecto");
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("---> Número Incorrecto");
                                    }
                                } while (simbolo == true); simbolo = true;
                                resultado += primero;
                                break;
                            case '-':
                                do
                                {
                                    try
                                    {
                                        Console.Write("Introduce un número: ");
                                        primero = Convert.ToInt32(Console.ReadLine());
                                        simbolo = false;
                                    }                                                                          //En este bucle do while lo que quiero hacer es la restricción marcada de los números enteros
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("---> Número Incorrecto");
                                    }
                                    catch (OverflowException)
                                    {
                                        Console.WriteLine("---> Número Incorrecto");
                                    }
                                    catch (StackOverflowException)
                                    {
                                        Console.WriteLine("---> Número Incorrecto");
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("---> Número Incorrecto");
                                    }
                                } while (simbolo == true); simbolo = true;
                                resultado = resultado - primero;
                                break;
                            case '*':
                                do
                                {
                                    try
                                    {
                                        
                                        Console.Write("Introduce un número: ");
                                        primero = Convert.ToInt32(Console.ReadLine());
                                        simbolo = false;
                                    }                                                                       //En este bucle do while lo que quiero hacer es la restricción marcada de los números enteros
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("---> Número Incorrecto");
                                    }
                                    catch (OverflowException)
                                    {
                                        Console.WriteLine("---> Número Incorrecto");
                                    }
                                    catch (StackOverflowException)
                                    {
                                        Console.WriteLine("---> Número Incorrecto");
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("---> Número Incorrecto");
                                    }
                                } while (simbolo == true); simbolo = true;
                                
                                resultado = (resultado )* primero;
                                break;
                            case '/':
                                do
                                {
                                    try
                                    {
                                        Console.Write("Introduce un número: ");
                                        primero = Convert.ToInt32(Console.ReadLine());
                                       
                                        if (resultado % primero == 0)
                                        {                                                               //En este bucle do while lo que quiero hacer es la restricción marcada de los números enteros
                                            int division = 1;
                                            if (division != 1)
                                            {
                                                division = division / primero;
                                                resultado = division;
                                            }                                                         //Hago este if else para poder realizar la división utilizando el resto
                                            else
                                            {
                                                division = resultado / primero;
                                                resultado = division;
                                            }
                                        }
                                        simbolo = false;
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("---> Número Incorrecto");
                                    }
                                    catch (OverflowException)
                                    {
                                        Console.WriteLine("---> Número Incorrecto");
                                    }
                                    catch (DivideByZeroException)                                   //La restricción que no se puede dividir entre 0
                                    {
                                        Console.WriteLine("---> Número Incorrecto");
                                    }
                                    catch (StackOverflowException)
                                    {
                                        Console.WriteLine("---> Número Incorrecto");
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("---> Número Incorrecto");
                                    }
                                } while (simbolo == true); simbolo = true;
                                        break;
                            case '=':
                                simbolo = false;
                                break;                  //Para el = uso el booleano false para salir del bucle y entrar al siguiente y poder realziar su funcionde repetir operaciones y mostrar el resultado guardado
                            case 'S':
                                simbolo = false;
                                break;                                                    //Para ela S uso el booleano false para salir del bucle y entrar al siguiente y obtener su siguiente función
                            default:
                                Console.WriteLine("---> Operación Incorrecta");
                                break;
                        }
                    } while (simbolo == true);
                } while (simbolo == true);
                switch (operacion)
                {                                                                         
                    case '=':                                                                 // Para el = uso un nuevo switch con su caso y restablezco las variables para su nueva entrada de datos                      

                        Console.WriteLine($"El resultado es {resultado}"); Console.WriteLine(); simbolo = true; resultado = 0; primero = 0; primero1 = 0;
                        break;                                                                                                            
                    case 'S':
                        Console.WriteLine($"El resultado es {resultado}"); Console.WriteLine();
                        simbolo = false;
                        break;                                                              //Para la S uso un nuevo switch con su caso y salgo del bucle con un booleano para poder mostrar el final del programa
                }
            } while (simbolo == true);
            Console.WriteLine("Fin del Programa");
        }                                                   //Espero que te haya gustado la calculadora y pueda aprobar programación, un saludo carlos :)
    }
}
