using System;
using System.Security.Cryptography.X509Certificates;

namespace pz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int x = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i < x)
            {
                Console.WriteLine(i);
                i *= 2;            
            }
        }
    }
}
