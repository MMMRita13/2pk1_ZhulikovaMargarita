using System;
using System.IO;

namespace pz_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\text.txt"; //созаем путь файла
            FileInfo text = new FileInfo(path);//создаем файл
            int[,] file = new int[5, 8];//двумерный массив
            FileStream file1 = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write); //поток файла
            StreamWriter zapic = new StreamWriter(file1); //поток записи
            for (int i = 0; i < 5; i++)//заполняем массив и записываем в файл
            {
                for (int j = 0; j < 8; j++)
                {
                    file[i, j] = i * j;
                    zapic.Write(file[i, j] + " ");
                    Console.Write(file[i, j] + " ");
                }
                Console.WriteLine();
                zapic.WriteLine();
            }
            zapic.Close();
        }
    }
}
