using System;
using System.Text.RegularExpressions;

namespace pz_18
{
    internal class Program
    {
        public enum Ozenka {one = 1, two = 2, three = 3, four = 4, five = 5};
        public enum Seasons { winter = 1, spring = 2, summer = 3, autmn = 4};
        static void Main(string[] args)
        {
            Console.WriteLine("Введите оценку: ");
           int d = Convert.ToInt32(Console.ReadLine());
            if (d == 1)
                writetext(Ozenka.one);
            if (d == 2)
                writetext(Ozenka.two);
            if (d == 3)
                writetext(Ozenka.three);
            if (d == 4)
                writetext(Ozenka.four);
            if (d == 5)
                writetext(Ozenka.five);
            Console.WriteLine("Введите время года: ");

            string s = Convert.ToString(Console.Read());
            if (s == "winter")
                writetext2(Seasons.winter);
            if (s == "spring")
                writetext2(Seasons.spring);
            if (s == "summer")
                writetext2(Seasons.summer);
            if (s == "autmn")
                writetext2(Seasons.autmn);

        }
        static void writetext(Ozenka a)
        { 
            switch(a)
            {
                case Ozenka.one:
                    Console.WriteLine("Характеристики оценки 1: очень плохо");
                    break;
                case Ozenka.two:
                    Console.WriteLine("Характеристики оценки 2: неудовлетворительно");
                    break;
                case Ozenka.three:
                    Console.WriteLine("Характеристики оценки 3: удовлетворительно");
                    break;
                case Ozenka.four:
                    Console.WriteLine("Характеристики оценки 4: хорошо");
                    break;
                case Ozenka.five:
                    Console.WriteLine("Характеристики оценки 5: отлично");
                    break;
            }
        }
        static void writetext2(Seasons a)
        {
            switch (a)
            {
                case Seasons.winter:
                    Console.WriteLine("Международный день защиты детей — 01 июня\r\n" +
                        "День Святой Троицы — 12 июня\r\n" +
                        "День начала Великой Отечественной войны (Памятная дата России) — 22 июня\r\n" +
                        "День молодежи России — 27 июня\r\n" +
                        "Иван Купала — 7 июля\r\n" +
                        "Всероссийский день семьи, любви и верности — 8 июля\r\n" +
                        "День Крещения Руси (Памятная дата России) — 28 июля\r\n" +
                        "День Военно-Морского Флота России — 31 июля (в 2022 году)\r\n" +
                        "День Воздушно-десантных войск России — 2 августа\r\n" +
                        "Международный день молодежи — 12 августа\r\n" +
                        "День Государственного флага Российской Федерации — 22 августа\r\n");
                    break;
                case Seasons.spring:
                    Console.WriteLine("Международный женский день — 8 марта\r\n" +
                        "День труда — 1 мая\r\n" +
                        "День Победы — 9 мая\r\n" +
                        "Масленица — 28.02.-06.03. (в 2022 году)\r\n" +
                        "Час Земли (экологическая акция) — 26 марта (в 2022 году)\r\n" +
                        "День смеха (День дурака) — 1 апреля\r\n" +
                        "Всемирный день космонавтики и авиации (Памятная дата России) — 12 апреля\r\n" +
                        "Вербное воскресенье — 17 апреля (в 2022 году)\r\n" +
                        "Пасха — 24 апреля (в 2022 году)\r\n");
                    break;
                case Seasons.summer:
                    Console.WriteLine("Новый год — 1 января\r\n" +
                        "Рождество Христово — 7 января\r\n" +
                        "День защитника отечества — 23 февраля\r\n" +
                        "День Героев Отечества — 9 декабря\r\n" +
                        "День Конституции Российской Федерации  — 12 декабря\r\n" +
                        "Старый Новый год — 14 января\r\n" +
                        "День студента  — 25 января\r\n" +
                        "День всех влюбленных — 14 февраля\r\n");
                    break;
                case Seasons.autmn:
                    Console.WriteLine("День знаний —  1 сентября\r\n" +
                       "Всемирный день учителя — 5 октября\r\n" +
                       "День матери в России — 27 ноября (в 2022 году)");
                    break;         
            }
        }
    }
}
