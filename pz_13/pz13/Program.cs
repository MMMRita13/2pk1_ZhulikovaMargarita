using System;

namespace pz13
{
    internal class Program
    {
        static string Stroki(string str, string subStr)
        {
            int count = 0; //счетчик
            int index = str.IndexOf(subStr); //первое вхождение подстроки в строку
            while (index > 0) //проверка наличия подстроки в строке
            {
                index = str.IndexOf(subStr, index + subStr.Length);
                count++;
            }
            return count.ToString();
        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string subStr = Console.ReadLine();
            string count = Stroki(str, subStr);
            Console.WriteLine(count);
        }
    }
}
