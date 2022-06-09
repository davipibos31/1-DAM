using System;

namespace ejercicio_5._10._4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            SumaVector();
        }

        static int SumaVector()
        {
            int[] Vec = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Introduze un número: ");
                Vec[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                if (Vec[i] == 0)
                    return 0;
                if (Vec[i] == 1)
                    return 1;
               
                return vec[i] 
            }
            return 0;
        }
           
    }
}
