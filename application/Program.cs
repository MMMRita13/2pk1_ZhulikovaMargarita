using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace pplication
{
    public class TourOrder
    {
        public string CustomerName { get; set; }
        public string Passport { get; set; }
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public List<string> AdditionalParticipants { get; set; }
        public decimal Price { get; set; }
    }

    class Program
    {
        private static List<TourOrder> orders = new List<TourOrder>();

        static void Main(string[] args)
        {
            LoadOrders();

            while (true)
            {
                Console.WriteLine("\n1. Добавить заявку");
                Console.WriteLine("2. Редактировать заявку");
                Console.WriteLine("3. Удалить заявку");
                Console.WriteLine("4. Посмотреть все заявки");
                Console.WriteLine("5. Сохранить и выйти");

                Console.Write("\nВведите свой выбор: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddOrder();
                        break;
                    case 2:
                        EditOrder();
                        break;
                    case 3:
                        DeleteOrder();
                        break;
                    case 4:
                        ViewOrders();
                        break;
                    case 5:
                        SaveAndExit();
                        break;
                    default:
                        Console.WriteLine("\nОшибка, введите цифру из заданного списка");
                        break;
                }
            }
        }

        private static void AddOrder()
        {
            Console.WriteLine("\nВведите данные заказа:");

            TourOrder order = new TourOrder();
            order.CustomerName = GetStringInput("ФИО заказчика");
            order.Passport = GetStringInput("Паспортные данные заказчика");
            order.StartPoint = GetStringInput("Исходная точка назначения маршрута");
            order.EndPoint = GetStringInput("Конечная точка назначения маршрута");
            order.AdditionalParticipants = GetAdditionalParticipants();
            order.Price = GetDecimalInput("Стоимость тура");

            orders.Add(order);

            Console.WriteLine("Заказ добавлен успешно");
        }

        private static void EditOrder()
        {
            Console.Write("\nВведите идентификатор заказа для редактирования: ");
            int id = int.Parse(Console.ReadLine());

            if (id >= 1 && id <= orders.Count)
            {
                Console.WriteLine("\nВведите новые данные заказа: ");

                TourOrder order = orders[id - 1];
                order.CustomerName = GetStringInput("ФИО заказчика", order.CustomerName);
                order.Passport = GetStringInput("Паспортные данные заказчика", order.Passport);
                order.StartPoint = GetStringInput("Исходная точка назначения маршрута", order.StartPoint);
                order.EndPoint = GetStringInput("Конечная точка назначения маршрута", order.EndPoint);
                order.AdditionalParticipants = GetAdditionalParticipants(order.AdditionalParticipants);
                order.Price = GetDecimalInput("Стоимость тура", order.Price);

                Console.WriteLine("Заказ успешно обновлен");
            }
            else
            {
                Console.WriteLine("Неверный идентификатор заказа");
            }
        }

        private static void DeleteOrder()
        {
            Console.Write("\nВведите идентификатор заказа для удаления: ");
            int id = int.Parse(Console.ReadLine());

            if (id >= 1 && id <= orders.Count)
            {
                orders.RemoveAt(id - 1);
                Console.WriteLine("Заказ успешно удален");
            }
            else
            {
                Console.WriteLine("Неверный идентификатор заказа");
            }
        }

        private static void ViewOrders()
        {
            Console.WriteLine("\nВсе заказы:");

            for (int i = 0; i < orders.Count; i++)
            {
                Console.WriteLine($"\nИдентификатор заказа: {i + 1}");
                Console.WriteLine($"ФИО заказчика: {orders[i].CustomerName}");
                Console.WriteLine($"Паспортные данные заказчика: {orders[i].Passport}");
                Console.WriteLine($"Исходная точка назначения маршрута: {orders[i].StartPoint}");
                Console.WriteLine($"Конечная точка назначения маршрута: {orders[i].EndPoint}");

                if (orders[i].AdditionalParticipants != null && orders[i].AdditionalParticipants.Count > 0)
                {
                    Console.WriteLine($"Дополнительные участники тура: {string.Join(", ", orders[i].AdditionalParticipants)}");
                }

                Console.WriteLine($"Стоимость тура: {orders[i].Price}");
            }
        }

        private static string GetStringInput(string fieldName, string defaultValue = null)
        {
            Console.Write($"{fieldName}: ");

            string input = Console.ReadLine();

            return string.IsNullOrEmpty(input) ? defaultValue : input;
        }

        private static decimal GetDecimalInput(string fieldName, decimal defaultValue = 0)
        {
            Console.Write($"{fieldName}: ");

            string input = Console.ReadLine();

            decimal result;

            if (string.IsNullOrEmpty(input))
            {
                result = defaultValue;
            }
            else if (!decimal.TryParse(input, out result))
            {
                Console.WriteLine("Неверный ввод. Введите допустимое десятичное значение.");
                result = GetDecimalInput(fieldName, defaultValue);
            }

            return result;
        }

        private static List<string> GetAdditionalParticipants(List<string> defaultValue = null)
        {
            Console.Write("Дополнительные участники (через запятую): ");

            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                return defaultValue;
            }
            else
            {
                return new List<string>(input.Split(','));
            }
        }

        private static void LoadOrders()
        {
            try
            {
                string json = File.ReadAllText("orders.json");

                orders = JsonSerializer.Deserialize<List<TourOrder>>(json);
            }
            catch (Exception)
            {
                // Игнорируйте ошибки и начинайте с пустого списка
            }
        }

        private static void SaveOrders()
        {
            string json = JsonSerializer.Serialize(orders);
            File.WriteAllText("E:\\orders.json", json);
        }

        private static void SaveAndExit()
        {
            SaveOrders();
            Console.WriteLine("\nЗаказы успешно сохранены. Нажмите любую клавишу для выхода...");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}