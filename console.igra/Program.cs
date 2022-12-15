using System;


namespace console.igra
{
    internal class Program
    {
        static string[,] carta = new string[25, 25];
        static string igrok = "@";
        static string aptechka = "A";
        static string vrag = "V";
        static string buffer = "B";
        static int buffer_B = 5;
        static int x = 12;
        static int y = 12;
        static int go = 0;
        static int igrok_HP = 30;
        static int igrok_power = 5;
        static int vrag_HP = 15;
        static int vrag_power = 5;
        static int kolvo_vrag = 10;
        public static Array GenerateMap(ref string[,] carta, string aptechka, string vrag, string buffer, string igrok)
        {//генерация карта
            Random rdm = new Random();
            carta[x, y] = igrok;
            for (int i = 0; i < 5; i++)
            {
                int a = rdm.Next(0, 25);
                int b = rdm.Next(0, 25);
                if (carta[a,b] == "*")
                {
                    carta[a,b] = aptechka;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                int a = rdm.Next(0, 25);
                int b = rdm.Next(0, 25);
                if (carta[a, b] == "*")
                {
                    carta[a, b] = vrag;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                int a = rdm.Next(0, 25);
                int b = rdm.Next(0, 25);
                if (carta[a, b] == "*")
                {
                    carta[a, b] = buffer;
                }
            }
            for (int i = 0; i < carta.GetLength(0); i++)
            {
                for (int j = 0; j < carta.GetLength(1); j++)
                {
                    Console.Write(carta[i, j] + "  ");
                }
                Console.WriteLine();
            }
            return (carta);
        }
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Здоровье игрока = " + igrok_HP + " " + "Сила = " + igrok_power);
            Console.WriteLine("Здоровье врага = " + vrag_HP + " " + "Сила = " + vrag_power);

            for (int i = 0; i < carta.GetLength(0); i++)
            {
                for (int j = 0; j < carta.GetLength(1); j++)
                {
                    carta[i, j] = "*";
                }
            }
            GenerateMap(ref carta, aptechka, vrag, buffer, igrok);
            
            for(int i = 0; igrok_HP > 0; i++)
            {
                if (kolvo_vrag>0)
                {
                    carta[x, y] = "*";
                    Move(ref x, ref y);
                    if (carta[x, y] == vrag)
                    {
                        Fight();
                    }
                    if (carta[x, y] == aptechka)
                    {
                        Healing();
                    }
                    if (carta[x, y] == buffer)
                    {
                         Buff();
                    }
                    UpdateMap();
                    
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Игра окончена за {go} шагов");
                    Console.WriteLine("Вы выиграли!");
                }
            }
            SaveState();
        }
        public static Array UpdateMap()
        {//обновление карты после действий
            Console.Clear();
            carta[x, y] = igrok;
            Console.WriteLine("Здоровье игрока = "+igrok_HP + " " + "Сила = " + igrok_power);

            Console.WriteLine("Общее количество шагов:" + go);
            if (buffer_B < 5)
            {
                Console.WriteLine($"Осталось {(5 - buffer_B)} шагов до конца баффа");
            }
            for (int i = 0; i < carta.GetLength(0); i++)
            {
                for (int j = 0; j < carta.GetLength(1); j++)
                {
                    Console.Write(carta[i, j] + "  ");
                }
                Console.WriteLine("");
            }
            return (carta);

        }
        public static Array Move(ref int x, ref int y)
        {//реализация перемещения на нужную ячейку в связи с выбранным направлением direction, подсчет шагов
            ConsoleKeyInfo direction = Console.ReadKey();
            go = go + 1;
            buffer_B= buffer_B + 1; 
            switch(direction.Key)
            {
                case ConsoleKey.W:
                    {
                        x = x - 1;
                        break;
                    }
                case ConsoleKey.D:
                    {
                        y = y + 1;
                        break;
                    }
                case ConsoleKey.A:
                    {
                        y = y - 1;
                        break;
                    }
                case ConsoleKey.S:
                    {
                        x = x + 1;
                        break;
                    }
            }
            return (carta);
        }
        public static Array Fight()
        {//обмен ударами игрока и врага до полной потери здоровья одним из них
            vrag_HP = 15;
            for(int i = 0; igrok_HP !=0 & vrag_HP!=0; i++)
            {
                vrag_HP = vrag_HP - igrok_power;
                if(vrag_HP <= 0)
                {
                    Console.WriteLine("Враг побежден!");
                    break;
                }
                igrok_HP = igrok_HP - vrag_power;
                if (igrok_HP <= 0)
                {
                    Console.WriteLine("Вы умерли!");
                }
            }
            kolvo_vrag = kolvo_vrag - 1;
            return (carta);
            
        }
        public static void Healing()
        {// лечение
            igrok_HP = 30;
        }
        public static void Buff()
        {//увеличение силы
            buffer_B = 0;
            igrok_power = 10;
        }
        public static void SaveState(/*string igrok, int igrok_HP = 30*/)
        {//сохранение в файл
            //FileStream file = new FileStream(@"D:\work\file.txt", FileMode.Create);
            //StreamWriter write = new StreamWriter(file);
            //write.WriteLine("HP игрока = " + igrok_HP);
            //write.Close();
        }
    }
}
    


