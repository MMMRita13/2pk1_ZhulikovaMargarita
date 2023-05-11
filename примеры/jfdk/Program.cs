namespace jfdk
{
    internal class Program
    {
        public class Vector
        {
            public double X { get; set; } // координата вектора по оси x
            public double Y { get; set; } // координата вектора по оси y

            // конструктор класса
            public Vector(double x, double y)
            {
                X = x;
                Y = y;
            }

            // метод для получения длины вектора
            public double Length()
            {
                return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            }

            // перегрузка оператора умножения на число
            public static Vector operator *(Vector vector, double num)
            {
                return new Vector(vector.X * num, vector.Y * num);
            }

            // переопределение метода ToString()
            public override string ToString()
            {
                return $"({X}, {Y})";
            }

        }
    }
}