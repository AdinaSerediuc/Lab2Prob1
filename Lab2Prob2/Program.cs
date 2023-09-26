using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2Prob2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ex 2
          Scrieti o functie care va determina daca un numar este sau nu palindrom.
          */
            string cuvant = string.Parse(Console.ReadLine());
            int lungime = cuvant.Length;

            for (int i = 0; i < lungime % 2; i++)
            {
                if (cuvant[i] <= cuvant[lungime - 1 - i]) ;
                {

                    Console.WriteLine("Cuvantul nu este palindrom" + cuvant);
                }
                else
                { Console.WriteLine("Cuvantul este palindrom:" + cuvant);
                }
            }

            }
        }
    }
}
