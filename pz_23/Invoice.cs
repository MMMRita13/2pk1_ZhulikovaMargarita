using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_23
{
    internal class Invoice
    {
        private static int totalInvoicesCount;

        public string ID { get; set; }
        public DateTime Date { get; set; }
        public string Product { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public decimal NDS { get; set; }

        public Invoice(string ID, DateTime ddate, string product, int count, decimal price, decimal NDS = 0)
        {
            this.ID = ID;
            Date = ddate;
            Product = product;
            Count = count;
            Price = price;
            this.NDS = NDS;
            totalInvoicesCount++;
        }
        

        public void PrintInfo()
        {
            Console.WriteLine("Информация о счете в приложении");
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Дата: " + Date);
            Console.WriteLine($"Наименование товара: {Product}");
            Console.WriteLine($"Количество единиц товара: {Count}");
            Console.WriteLine($"Стоимость единицы товара (руб): {Price}");
            Console.WriteLine("NDS: " + NDS);          
        }
        public Invoice()
        {
            totalInvoicesCount++;
        }

        public decimal GetFullPrice()
        {
            decimal totalPrice = Count * Price;
            decimal totalPriceWithNDS = totalPrice + totalPrice * NDS;
            return totalPriceWithNDS;
        }
        public static void PrintTotalInvoicesCount()
        {
            Console.WriteLine("Всего: " + totalInvoicesCount);
        }
        


    }
}
