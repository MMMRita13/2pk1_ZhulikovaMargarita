using System;

namespace pz_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] array = new int[7, 7]; //основной массив
            Random rnd = new Random();
            int[] mainDiag = new int[7]; //вектор главной диагонали
            int count = 0;


            for (i = 0; i < 7; i++)
            {
                for (j = 0; j < 7; j++)
                {
                    array[i, j] = rnd.Next(-10, 10);
                    Console.Write(array[i, j] + " ");

                    if (i == j) //заполнение вектора главной диаг
                    {
                        mainDiag[i] = array[i, j];
                        if (mainDiag[i] > 0)
                        {
                            count++;

                        }
                    }


                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"Количество положительных элементов главной диагонали = {count}");
            Console.WriteLine(); Console.WriteLine();
            foreach (int num in mainDiag) Console.Write(num + " ");
            Console.WriteLine();
        }
    }
}
