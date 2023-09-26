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
            string cuvant = "radar";
            int lungime = cuvant.Length;
            bool estePalindrom;

            for (int i = 0; i < lungime / 2; i++)
            {
                if (cuvant[i] != cuvant[lungime - 1 - i]);
                {
                    estePalindrom = false;
                    //break;
                }
                 if (estePalindrom == true)
                {
                    Console.WriteLine("Cuvantul este palindrom:" + cuvant);
                }
                else
                {
                    Console.WriteLine(cuvant + " nu este un cuvânt palindrom.");
                }

            }
        }
    }
}
