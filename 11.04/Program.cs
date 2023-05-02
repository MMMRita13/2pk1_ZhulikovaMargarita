using _11._04;
using System;

namespace _11._04
{
    //delegate void TestDelegate();
    //namespace DelegateAsArgDemo
    //{
    //    class Student
    //    {
    //        public string group;
    //        public Student(string text)
    //        {
    //            group = text;

    //        }
    //        public void GetGroup()
    //        {
    //            Console.WriteLine(group);
    //        }
    //    }
    //    class Pupil
    //    {
    //        public string class_learn;
    //        public Pupil(string text)
    //        {
    //            class_learn = text;

    //        }
    //        public void GetClass()
    //        {
    //            Console.WriteLine(class_learn);
    //        }
    //    }
    //    internal class Program
    //    {

    //        static void Main(string[] args)
    //        {
    //            Student obj1 = new Student("2пк1");
    //            Pupil obj2 = new Pupil("2f");

    //            TestDelegate meth;
    //            meth = obj1.GetGroup;
    //            meth();

    //            meth = obj2.GetClass;
    //            meth();

    //        }

    //    }
    //}







    //delegate int MyDelegate(int n);
    //namespace DelegateAsArgDemo
    //{
    //    internal class Program
    //    {
    //        //статический метод для вычисления нечетных чисел
    //        static int OddNumber(int n)
    //        { return 2 * n + 1; }
    //        // статический метод для вычисления четных чисел
    //        static int EvenNumber(int n)
    //        { return 2 * n; }
    //        //статический метод для вычисления квадратов чисел
    //        static int SquareNumber(int n)
    //        { return n * n; }
    //    // статический метод, которому аргументом передается ссылка на метод
    //    static void Display(MyDelegate F, int a, int b)
    //        {
    //            Console.WriteLine("{0,-4}|{1,4}", "x", "F(x)");
    //            Console.WriteLine("-----------");
    //            for (int k = a; k <= b; k++)
    //            {
    //                //команда с вызовом экземпляра делегата
    //                Console.WriteLine("{0,-4}|{1,4}", k, F(k));
    //            }
    //            Console.WriteLine();
    //        }
    //        static void Main(string[] args)
    //        {
    //            int a = 0, b = 5;
    //            Console.WriteLine("нечетные числа");
    //            Display(OddNumber, a, b);
    //            Console.WriteLine("четные числа");
    //            Display(EvenNumber, a, b);
    //            Console.WriteLine("число в квадрате");
    //            Display(SquareNumber, a, b);
    //        }
    //}






    //delegate void MyDelegate(string txt);
    //namespace DelegateAsFieldDemo
    //{
    //    class MyClass
    //    { //поле является ссылкой на экземпляр делегата
    //        public MyDelegate apply;
    //        public MyClass(MyDelegate md)
    //        { apply = md; }
    //    }
    //    class Alpha
    //    {
    //        private string name;
    //        public void set(string t)
    //        { name = t; }
    //        public override string ToString()
    //        { return name; }
    //    }
    //internal class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            Alpha A = new Alpha(); //создание объекта
    //                                   //создание объекта (аргумент конструктора - ссылка на метод)
    //            MyClass obj = new MyClass(A.set);
    //            obj.apply("объект А"); // вызов экземпляра делегата
    //            Console.WriteLine(A); // проверка поля объекта
    //            Alpha B = new Alpha(); //создание объекта
    //            obj.apply = B.set; // полю значением присваивается ссылка на метод
    //            obj.apply("объект В"); // вызов экземпляра делегата
    //            Console.WriteLine(B); // проверка поля объекта
    //        //добавление метода в список вызовов экземпляра делегата
    //        obj.apply += A.set;
    //            obj.apply("объект Х"); //вызов экземпляра делегата
    //            Console.WriteLine(A + " и " + B); //проверка полей объектов
    //            obj.apply -= B.set; // удаление метода из списка вызовов экз делегата
    //            obj.apply("объект А"); //вызов экземпляра делегата
    //            Console.WriteLine(A + " и " + B); // проверка полей объектов
    //        }
    //    }
    //}









    //    delegate void MyDelegate(); //объявление делегата
    //    namespace MultipleDelegate
    //    {
    //        class MyClass
    //        {
    //            public string name;
    //            public MyClass(string text)
    //            {
    //                name = text;
    //            }
    //            public void Show()
    //            {
    //                Console.WriteLine(name);
    //            }
    //        }
    //    internal class Program
    //        {
    //            static void MakeLine()
    //            { Console.WriteLine("___________________"); }
    //            static void Main(string[] args)
    //            { //создание объектов
    //                MyClass obj1 = new MyClass("первый объект");
    //                MyClass obj2 = new MyClass("второй объект");
    //                MyClass obj3 = new MyClass("третий объект");
    //                MyDelegate meth; //объявление переменной делегата
    //                meth = obj1.Show; // присваивание переменной делегата ссылки на метод
    //                meth(); // вызов экземпляра делегата
    //                meth = MakeLine; // присваивание переменной делегата нового значения
    //                                 // добавление методов в список вызова
    //                meth += obj1.Show;
    //                meth += obj2.Show;
    //                meth = meth + obj3.Show;
    //            // вызов экземпляра делегата
    //meth();
    //                // удаление метода из списка вызова 1 способ
    //                meth -= obj2.Show;
    //                // вызов экземпляра делегата
    //                meth();
    //                // удаление метода из списка вызова 2 способ
    //                meth = meth - obj1.Show;
    //                // вызов экземпляра делегата
    //                meth();
    //            }
    //        }
    //    }










    //объявление делегата
    delegate char Mydelegate(int k, string txt);
    //класс с главным методом
    internal class Program
    {
        
        //статический метод с двумя аргументами
        static char GetLast(int k, string txt)
        { return txt[txt.Length - 1]; }
        static void Main(string[] args)
        {
            SomeClass obj = new SomeClass(5); //создание объекта
            Mydelegate meth = new Mydelegate(obj.GetChar); //создание экземпляра делегата
            Console.WriteLine($"символ {meth(4, "world")}"); //вызов экземпляра делегата
            obj.code = 1; //присваивание значения полю объекта
            Console.WriteLine($"символ {meth(4, "world")}");//вызов экземпляра делегата
            meth = SomeClass.GetFirst; //присваивание нового значения переменной делегата
            Console.WriteLine($"символ {meth(2, "world")}");//вызов экземпляра делегата
            meth = GetLast; //присваивание нового значения переменной делегата
            Console.WriteLine($"символ {meth(1, "world")}");//вызов экземпляра делегата
        }
    }
}

















