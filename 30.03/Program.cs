using System.Diagnostics;

//Вывод программы:
//Время создания 10000 объектов структуры: 10810 мс
//Время создания 10000 объектов класса: 10800 мс
//Время изменения полей 10000 объектов структуры: 10799 мс
//Время изменения полей 10000 объектов класса: 10807 мс

namespace _30._03
{
    public struct MyStruct
    {
        public int a;
        public int b;
        public double c;

        public MyStruct(int a, int b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }

    public class MyClass
    {
        public int a;
        public int b;
        public double c;

        public MyClass(int a, int b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 10000;

            // Создаем массивы объектов структуры и класса
            MyStruct[] structArray = new MyStruct[arraySize];
            MyClass[] classArray = new MyClass[arraySize];

            // Замеряем время создания объектов структуры
            Stopwatch structStopwatch = new Stopwatch();
            structStopwatch.Start();

            int[] arr = new int[100];

            Random random= new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
                Thread.Sleep(100);
            }

            structStopwatch.Stop();
            Console.WriteLine($"Время создания {arraySize} объектов структуры: {structStopwatch.ElapsedMilliseconds} мс");

            // Замеряем время создания объектов класса
            Stopwatch classStopwatch = new Stopwatch();
            classStopwatch.Start();

            int[] arr2 = new int[100];

            Random random1 = new Random();
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = random1.Next();
                Thread.Sleep(100);
            }

            classStopwatch.Stop();
            Console.WriteLine($"Время создания {arraySize} объектов класса: {classStopwatch.ElapsedMilliseconds} мс");

            // Замеряем время изменения полей объектов структуры
            Stopwatch structUpdateStopwatch = new Stopwatch();
            structUpdateStopwatch.Start();

            

            for (int i = 0; i < arr.Length; i++)
            {
                structArray[i].a += 1;
                structArray[i].b += 1;
                structArray[i].c += 1.5;
                Thread.Sleep(100);
            }
              
            

            structUpdateStopwatch.Stop();
            Console.WriteLine($"Время изменения полей {arraySize} объектов структуры: {structUpdateStopwatch.ElapsedMilliseconds} мс");

            //Замеряем время изменения полей объектов класса
            Stopwatch classUpdateStopwatch = new Stopwatch();
            classUpdateStopwatch.Start();

            for (int i = 0; i < arr2.Length; i++)
            {
                classArray[i].a += 1;
                classArray[i].b += 1;
                classArray[i].c += 1.5;
                Thread.Sleep(100);
            }

            classUpdateStopwatch.Stop();
            Console.WriteLine($"Время изменения полей {arraySize} объектов класса: {classUpdateStopwatch.ElapsedMilliseconds} мс");

            Console.ReadLine();
        }
    }
}    


