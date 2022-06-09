using System;

namespace ejercicio_2._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dime una frase: ");
            string frase = Console.ReadLine();
            int cont;
            foreach (char letra in frase)
            {
                cont = 0;
                while (cont <= letra)
                {
                    if (letra == 'a')
                    {
                        cont++;
                        
                    }
                    if (cont == 1)
                    {
                        Console.WriteLine("{0} ", cont);
                    }
                    else
                        cont++;
                    break;
                }
            }
        }
    }
}
