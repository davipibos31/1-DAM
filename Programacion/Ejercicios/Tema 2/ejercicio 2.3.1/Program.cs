using System;

namespace ejercicio_2._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            num = 1;
            if (num == 1)
            { 
                Console.WriteLine("{0} ", num);
                num++;
                if (num == 2)
                {
                    Console.WriteLine("{0} ", num);
                    num++;
                    if (num == 3)
                    {
                        Console.WriteLine("{0} ", num);
                        num++;
                        if (num == 4)
                        {
                            Console.WriteLine("{0} ", num);
                            num++;
                            if (num == 5)
                            {
                                Console.WriteLine("{0} ", num);
                                num++;
                                if (num == 6)
                                {
                                    Console.WriteLine("{0} ", num);
                                    num++;
                                    if (num == 7)
                                    {
                                        Console.WriteLine("{0} ", num);
                                        num++;
                                        if (num == 8)
                                        {
                                            Console.WriteLine("{0} ", num);
                                            num++;
                                            if (num == 9)
                                            {
                                                Console.WriteLine("{0} ", num);
                                                num++;
                                                if (num == 10)
                                                {
                                                    Console.WriteLine("{0} ", num);
                                                    num++;
                                                    if (num == 11)
                                                    {
                                                        goto salida;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            salida:
            Console.Write("Fin del programa");
        }
    }
}
