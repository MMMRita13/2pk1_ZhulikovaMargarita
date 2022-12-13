using System;
using System.Reflection;

namespace pr_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
            string a = Console.ReadLine();
            fixed (char *b = a)
                {
                    for (int i = 0; b[i] != 0; i++) //замена точки на пробел
                    {
                        if (b[i] == ',')
                        {
                            b[i] = ' ';
                        }
                        Console.Write(b[i]);
                    }
                }
            }
        }
    }
}
