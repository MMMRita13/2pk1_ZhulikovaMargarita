using System;

namespace pz_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 60; i += 5)
            {
                Console.WriteLine(i);
            }


            for (char a = 'e'; a <= 'j'; a++)
            {
                Console.Write(a);
            }


            int n = 3;
            int m = 6;
            for (int i = 0; i < m; i++)
            {
                for (int x = 0; x < n; x++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }


            for (int i = 0; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i + " ");
                }
            }


            for (int i = 2, j = 40; i - j <= 18; i++, j--)
            {
                Console.WriteLine(i - j);
            }
        }   

    }
}
