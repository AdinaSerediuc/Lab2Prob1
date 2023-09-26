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

            if (NrPrim(numar))
            {
                Console.WriteLine(numar + " este un număr prim. ");
            }
            else
            {
                Console.WriteLine(numar + " nu este un număr prim. ");
            }
        }
        static bool NrPrim(int num)
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
