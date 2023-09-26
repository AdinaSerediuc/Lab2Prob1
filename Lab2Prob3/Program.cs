using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2Prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ex 3
             Scrieti o functie care va determina daca un numar este sau nu numar prim.
             Apelati-o si afisati-i rezultatul
            */
            int numar = int.Parse(Console.ReadLine());

            if (IsPrime(numar))
            {
                Console.WriteLine("este un număr prim."+ numar);
            }
            else
            {
                Console.WriteLine("nu este un număr prim."+ numar);
            }
        }
        static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            else if (num == 2)
            {
                return true;
            }
            else if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                for (int i = 3; i * i <= num; i += 2)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

        }
    }
}
