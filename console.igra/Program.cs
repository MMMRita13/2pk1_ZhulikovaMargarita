using System;

namespace console.igra
{
    internal class Program
    {
        public static void GenerateMap(ref string[,] carta, string aptechka, string vrag, string buffer, string igrok)
        {//генерация карта
            Random rdm = new Random();
            for (int i = 0; i < 5; i++)
            {
                carta[rdm.Next(0, 25), rdm.Next(0, 25)] = aptechka;
            }
            for (int i = 0; i < 10; i++)
            {
                carta[rdm.Next(0, 25), rdm.Next(0, 25)] = vrag;
            }
            for (int i = 0; i < 3; i++)
            {
                carta[rdm.Next(0, 25), rdm.Next(0, 25)] = buffer;
            }
            for (int i = 0; i < 3; i++)
            {
                carta[13, 13] = igrok;
            }

            }
        }
            static void Main(string[] args)
        {
            int HP = 30;
            int power = 5;
            Console.WriteLine("Здоровье = " + HP + " " + "Сила = " + power);
            
            string[,] carta = new string[25, 25];
            string igrok = "@";
            string aptechka = "A";
            string vrag = "V";
            string buffer = "B";
            for (int x = 0; x < carta.GetLength(0); x++)
            {
                for (int y = 0; y < carta.GetLength(1); y++)
                {
                    Console.Write(carta[x, y] + " * ");
                }
            }
        GenerateMap(ref carta, aptechka, vrag, buffer, igrok);
            for (int x = 0; x < carta.GetLength(0); x++)
            {
                for (int y = 0; y < carta.GetLength(1); y++)
                {
                    Console.Write(" " + carta[x, y] + "  ");
                }
                Console.WriteLine("");
            }

            UpdateMap();
            Move();
            Fight();
            Healing();
            Buff();
            SaveState();
        }
        public static void UpdateMap()
        {//обновление карты после действий}
        }
        public static void Move()
        {//реализация перемещения на нужную ячейку в связи с выбранным направлением direction, подсчет шагов}
            string napravlenie = "→";
            string napravlenie2 = "←";
            string napravlenie3 = "↑";
            string napravlenie4 = "↓";
            switch (napravlenie, napravlenie2, napravlenie3, napravlenie4)
            {
                

            }
        }
        public static void Fight()
        {//обмен ударами игрока и врага до полной потери здоровья одним из них}
        }
        public static void Healing()
        {// лечение}
        }
        public static void Buff()
        {//увеличение силы}
        }
        public static void SaveState()
        {//сохранение в файл}
        }
    }
}

