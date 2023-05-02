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
                Console.WriteLine("\n1. Add order");
                Console.WriteLine("2. Edit order");
                Console.WriteLine("3. Delete order");
                Console.WriteLine("4. View all orders");
                Console.WriteLine("5. Save and exit");

                Console.Write("\nEnter your choice: ");
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
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        private static void AddOrder()
        {
            Console.WriteLine("\nEnter order details:");

            TourOrder order = new TourOrder();
            order.CustomerName = GetStringInput("Customer name");
            order.Passport = GetStringInput("Passport");
            order.StartPoint = GetStringInput("Start point");
            order.EndPoint = GetStringInput("End point");
            order.AdditionalParticipants = GetAdditionalParticipants();
            order.Price = GetDecimalInput("Price");

            orders.Add(order);

            Console.WriteLine("Order added successfully");
        }

        private static void EditOrder()
        {
            Console.Write("\nEnter order ID to edit: ");
            int id = int.Parse(Console.ReadLine());

            if (id >= 1 && id <= orders.Count)
            {
                Console.WriteLine("\nEnter new order details:");

                TourOrder order = orders[id - 1];
                order.CustomerName = GetStringInput("Customer name", order.CustomerName);
                order.Passport = GetStringInput("Passport", order.Passport);
                order.StartPoint = GetStringInput("Start point", order.StartPoint);
                order.EndPoint = GetStringInput("End point", order.EndPoint);
                order.AdditionalParticipants = GetAdditionalParticipants(order.AdditionalParticipants);
                order.Price = GetDecimalInput("Price", order.Price);

                Console.WriteLine("Order updated successfully");
            }
            else
            {
                Console.WriteLine("Invalid order ID");
            }
        }

        private static void DeleteOrder()
        {
            Console.Write("\nEnter order ID to delete: ");
            int id = int.Parse(Console.ReadLine());

            if (id >= 1 && id <= orders.Count)
            {
                orders.RemoveAt(id - 1);
                Console.WriteLine("Order deleted successfully");
            }
            else
            {
                Console.WriteLine("Invalid order ID");
            }
        }

        private static void ViewOrders()
        {
            Console.WriteLine("\nAll orders:");

            for (int i = 0; i < orders.Count; i++)
            {
                Console.WriteLine($"\nOrder ID: {i + 1}");
                Console.WriteLine($"Customer name: {orders[i].CustomerName}");
                Console.WriteLine($"Passport: {orders[i].Passport}");
                Console.WriteLine($"Start point: {orders[i].StartPoint}");
                Console.WriteLine($"End point: {orders[i].EndPoint}");

                if (orders[i].AdditionalParticipants != null && orders[i].AdditionalParticipants.Count > 0)
                {
                    Console.WriteLine($"Additional participants: {string.Join(", ", orders[i].AdditionalParticipants)}");
                }

                Console.WriteLine($"Price: {orders[i].Price}");
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
                Console.WriteLine("Invalid input. Enter a valid decimal value.");
                result = GetDecimalInput(fieldName, defaultValue);
            }

            return result;
        }

        private static List<string> GetAdditionalParticipants(List<string> defaultValue = null)
        {
            Console.Write("Additional participants (comma-separated): ");

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
                // Ignore errors and start with an empty list
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
            Console.WriteLine("\nOrders saved successfully. Press any key to exit...");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}