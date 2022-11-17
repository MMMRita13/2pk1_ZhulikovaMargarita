using System;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp18
{
    internal class Program
    {
        static double Math(int an, double d, double a1)
        {
            if (an == 0)
            {
                return a1;
            }
            else// алгоритм нахождения n-го члена ариф прогрессии
            {
                Console.WriteLine(a1);
                a1 = a1 + d;
                an = an - 1;
                Math(an, d, a1);
                return a1;
            }
        }
        static double Geom(int bn, double q, double b1)
        {
            if (bn == 0)
            {
                return b1;
            }
            else// алгоритм нахождения n-го члена ариф прогрессии
            {
                Console.WriteLine(b1);
                b1 = b1 * q;
                bn = bn - 1;
                Geom(bn, q, b1);
                return b1;
            }
        }
        static void Invert(int A, int B)
        {
            if (A < B)
            {
                A++;
                Console.WriteLine(A);
                Invert(A, B);
            }
            if (A > B)
            {
                A--;
                Console.WriteLine(A);
                Invert(A, B);
            }
        }
        static void Palindrom(string S)
        {
            char[] obrtext = S.ToCharArray();// символьный массив
            Array.Reverse(obrtext);// переворачивает символы
            string finaltext = new string(obrtext);
            if (S == finaltext)
            {
                Console.WriteLine("Является палиндромом");
            }
            else
            {
                Console.WriteLine("Не является палиндромом");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Арифметическая прогрессия");
            Console.WriteLine();

            double a1 = 9.0;// первый член ариф прогрессии
            double d = 0.5;// разность ариф прогрессии
            Console.WriteLine("Введите номер члена арифметической прогрессии");
            int an = Convert.ToInt32(Console.ReadLine());
            Math(an, d, a1);

            Console.WriteLine();
            Console.WriteLine("Геометрическая прогрессия");
            Console.WriteLine();

            double b1 = 5.0;// первый член ариф прогрессии
            double q = -0.1;// разность ариф прогрессии
            Console.WriteLine("Введите номер члена арифметической прогрессии");
            int bn = Convert.ToInt32(Console.ReadLine());
            Geom(bn, q, b1);

            Console.WriteLine();
            Console.WriteLine("Последовательность");
            Console.WriteLine();

            int A = 6;// первое число
            int B = 78;// последнее число
            Invert(A, B);

            Console.WriteLine();
            Console.WriteLine("Проверка на палиндром");
            Console.WriteLine();

            string S = Convert.ToString(Console.ReadLine());
            Palindrom(S);
        }
    }
}
