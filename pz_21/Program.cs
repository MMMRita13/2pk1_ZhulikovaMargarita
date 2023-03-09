using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_21
{
    
 
    class Program
    {
        static Invoice PrintInfo() //Выводит общее описание накладной со всеми значениями
        {
            Invoice invoice = new Invoice();

            invoice.Id = Guid.NewGuid();
            invoice.date = new DateTime(2015, 7, 20); 
            invoice.product = "Гречка";
            invoice.count = 40;
            invoice.price = 100;
            invoice.NDS= 0.1f;

            return invoice;
        }

        static void GetFullPrice(Invoice invoice)// Возвращает полную стоимость всего товара по накладной с учетом НДС
        {
            Console.WriteLine("Информация о счете в приложении");
            Console.WriteLine($"ID: {invoice.Id}");
            Console.WriteLine($"Дата проведения накладной: {invoice.date}");
            Console.WriteLine($"Наименование товара: {invoice.product}");
            Console.WriteLine($"Количество единиц товара: {invoice.count}");
            Console.WriteLine($"Стоимость единицы товара: {invoice.price}");
            Console.WriteLine($"Стоимость с учетом НДС: {invoice.price*(1+invoice.NDS)}");

        }
        static void Main(string[] args)
        {

            int product = PrintInfo();
            GetFullPrice(product);
        }
    }
}