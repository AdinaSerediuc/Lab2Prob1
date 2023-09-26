using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ex 1
               Scrieti o functie care citeşte de la tastatură un şir de n numere naturale şi
               determină media aritmetică a celor pare, n fiind citit de la tastatra
            */
            int n = int.Parse(Console.ReadLine());
            int[] SirDeNumere = new int[n];
            double Suma = 0;
            int numar = 0;
            double MediaAritmetica = 0;

            for (int i = 0; i < SirDeNumere.Length; i++)
            {
                if (i % 2 == 0)
                {                   
                    numar = numar + 1;
                    Suma = Suma + i;
                    Console.WriteLine("Numar par " + i);                 
                }
            }
            Console.WriteLine(numar);
            Console.WriteLine("Suma numerelor pare este:" + Suma);
            MediaAritmetica = Suma / numar;
            Console.WriteLine("Media aritmetica este:" + MediaAritmetica);




        }
    }
}
