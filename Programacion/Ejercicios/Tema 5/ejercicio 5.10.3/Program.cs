using System;

namespace ejercicio_5._10._3
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 12;

            Console.WriteLine(Fibonacci(num)); ;
        }

        static long Fibonacci(int num)
        {
            
            if (num == 0)
                return 0;
            if (num == 1)
                return 1;
            else
                return Fibonacci(num -2) + Fibonacci(num-1);
            }
        }
    }

