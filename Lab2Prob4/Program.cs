using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2Prob4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * • Ex 4: Scrieti un program care va afisa piramida numerelor
                 1
                 2 2
                 3 3 3
                 4 4 4 4
                 …
                 n n n n n ….. n
            */
            Console.Write("Introduceti  numarul: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i =i+ 2)
            {
                for (int j = 0; j < i / 2; j++)
                    {
                    Console.Write(i + " " );
                }
                Console.WriteLine();
            }
        }
    }
}
