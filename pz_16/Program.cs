using System;
using System.IO;

namespace pz_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "text.txt"; //созаем путь файла
            FileInfo text = new FileInfo(path);//создаем объект файл
            FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite); //поток файла
            StreamReader read = new StreamReader(file); //поток чтения
           
            string maxString = "", c;
            while ((c = read.ReadLine()) != null)//сравнение
            {
                if (c.Length > maxString.Length)
                    maxString = c;
            }

            Console.WriteLine( maxString);
            read.Close();
        }
    }
}
