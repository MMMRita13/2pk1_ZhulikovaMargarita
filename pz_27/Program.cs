
using System;

struct AEROFLOT
{
    public string NAZN;
    public int NUMR;
    public string TIP;
}

class Program
{
    static void Main(string[] args)
    {
        AEROFLOT[] AIRPORT = new AEROFLOT[7];

        // Ввод данных в массив AIRPORT и сортировка по возрастанию номера рейса
        for (int i = 0; i < AIRPORT.Length; i++)
        {
            Console.WriteLine($"Введите данные для {i + 1}-го элемента массива AIRPORT:");

            Console.Write("Название пункта назначения: ");
            AIRPORT[i].NAZN = Console.ReadLine();

            Console.Write("Номер рейса: ");
            AIRPORT[i].NUMR = int.Parse(Console.ReadLine());

            Console.Write("Тип самолета: ");
            AIRPORT[i].TIP = Console.ReadLine();

            Console.WriteLine();
        }

        Array.Sort(AIRPORT, (a, b) => a.NUMR.CompareTo(b.NUMR));

        // Вывод номеров рейсов и типов самолетов в пункты назначения,название которых совпадает с названием, введенным с клавиатуры

        Console.Write("Введите название пункта назначения: ");
        string nazn = Console.ReadLine();

        bool found = false;
        for (int i = 0; i < AIRPORT.Length; i++)
        {
            if (AIRPORT[i].NAZN == nazn)
            {
                Console.WriteLine($"Номер рейса: {AIRPORT[i].NUMR}, Тип самолета: {AIRPORT[i].TIP}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Рейсы с таким пунктом назначения не найдены.");
        }
    }
}
