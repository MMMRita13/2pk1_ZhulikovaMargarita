using System;

namespace Pz_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] mass = new int[12];
            Console.WriteLine("Начальный массив:");
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(-12, 12);
                Console.Write(mass[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Массив со сдвигом вправо на 4 элемента:");
            for (int i = 0; i < 4; i++)
            {
                int temp = mass[1];
                for (int j = mass.Length - 1; j > 0; j--) mass[j] = mass[j - 1];
                mass[0] = temp;
            }

            foreach (int i in mass) Console.Write(i + " ");
        }
    }
}
