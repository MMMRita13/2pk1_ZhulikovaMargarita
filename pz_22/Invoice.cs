using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_22
{
    class Invoice
    {
        private static int totalInvoicesCount; // Статическое поле для подсчета количества всех накладных

        public string ID { get; private set; } // Автосвойство для ID
        public DateTime Date
        {
            get { return date; }
            set
            {
                if (value <= DateTime.Now)
                    date = value;
                else
                    Console.WriteLine("Дата проведения накладной не может быть позже текущего дня.");
            }
        }
        public string Product { get; set; } // Автосвойство для наименования товара
        public int Count { get; set; } // Автосвойство для количества единиц товара
        public decimal Price { get; set; } // Автосвойство для стоимости единицы товара
        public decimal NDS { get; set; } // Автосвойство для значения НДС

        public Invoice(string ID, DateTime date, string product, int count, decimal price, decimal NDS = 0)
        {
            this.ID = ID;
            Date = date;
            Product = product;
            Count = count;
            Price = price;
            this.NDS = NDS;
            totalInvoicesCount++; // Увеличиваем счетчик при создании новой накладной
        }

        public void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Информация о счете в приложении");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Дата проведения накладной: {Date}");
            Console.WriteLine($"Наименование товара: {Product}");
            Console.WriteLine($"Количество единиц товара: {Count}");
            Console.WriteLine($"Стоимость единицы товара (руб): {Price}");

            Console.WriteLine();
        }

        public decimal GetFullPrice()
        {
            decimal totalPrice = Count * Price;
            decimal totalPriceWithNDS = totalPrice + totalPrice * NDS;
            return totalPriceWithNDS;
        }

        public static void PrintTotalInvoicesCount()
        {
            Console.WriteLine($"Стоимость с учетом НДС (руб): {totalInvoicesCount}");
    }
    }
    
}
