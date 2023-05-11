using System;

namespace pz12
{
    internal class Program
    {
        static void S(double a, double b, double h1, double h2)
        {
            double S1 = a * h1;//площадь первого параллелограмма
            double S2 = b * h2;//площадь второго параллелограмма
            //сравнение площадей параллелограмма
            if (S1 > S2)
            {
                Console.WriteLine(S1);
            }
            else if (S2 > S1)
            {
                Console.WriteLine(S2);
            }
            else if (S1 == S2)
            {
                Console.WriteLine("Параллелограммы равны");
            }
        }
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());//сторона первого параллелограмма
            double h1 = Convert.ToDouble(Console.ReadLine());//высота первого параллелограммма
            double b = Convert.ToDouble(Console.ReadLine());//сторона второго параллелограмма
            double h2 = Convert.ToDouble(Console.ReadLine());//высота второго параллелограммма
            S(a, b, h1, h2);
        }
    }
}
