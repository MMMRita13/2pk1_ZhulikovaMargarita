namespace перегрузка_операторов
{
        public class Vector
            {
            public double X1 { get; set; } // координата начала вектора по оси x
            public double Y1 { get; set; } // координата начала вектора по оси y
            public double X2 { get; set; } // координата конца вектора по оси x
            public double Y2 { get; set; } // координата конца вектора по оси y

            // конструктор класса
            public Vector(double x1, double y1, double x2, double y2)
            {
                X1 = x1;
                Y1 = y1;
                X2 = x2;
                Y2 = y2;
            }

            // метод для получения длины вектора
            public double Length()
            {
                return Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            }

            // перегрузка оператора умножения на число
            public static Vector operator *(Vector vector, double num)
            {
                return new Vector(vector.X1, vector.Y1, vector.X1 + (vector.X2 - vector.X1) * num, vector.Y1 + (vector.Y2 - vector.Y1) * num);
            }
            }
     }


