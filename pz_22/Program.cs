namespace pz_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice();

            invoice.Id = Guid.NewGuid();
            Console.WriteLine("Введите дату");
            invoice.date = DateTime.Parse(Console.ReadLine());
            if (invoice.date > DateTime.Now)
            {
                Console.WriteLine("Ошибка");
                invoice.date = Invoice.basedate;
            }

            Console.WriteLine("Введите название товара");
            invoice.product = Console.ReadLine();

            Console.WriteLine("Введите количество товара");
            invoice.count = int.Parse(Console.ReadLine());
            if (invoice.count <= 0)
            {
                Console.WriteLine("Неправильно введено количество. Значение установлено 0");
                invoice.count = Invoice.basecount;
            }

            Console.WriteLine("Введите цену товара (1шт)");
            invoice.price = int.Parse(Console.ReadLine());
            if (invoice.price <= 0)
            {
                Console.WriteLine("Неправильно введена цена. Значение установлено 0");
                invoice.price = Invoice.baseprice;
            }
            invoice.NDS = 0.1f;

            Invoice invoice1 = new Invoice();

            invoice1.Id = Guid.NewGuid();
            Console.WriteLine("Введите дату");
            invoice1.date = DateTime.Parse(Console.ReadLine());
            if (invoice1.date > DateTime.Now)
            {
                Console.WriteLine("Ошибка");
                invoice1.date = Invoice.basedate;
            }
            Console.WriteLine("Введите название товара");
            invoice1.product = Console.ReadLine();
            Console.WriteLine("Введите количество товара");
            invoice1.count = int.Parse(Console.ReadLine());
            if (invoice1.count <= 0)
            {
                Console.WriteLine("Неправильно введено количество. Значение установлено 0");
                invoice1.count = Invoice.basecount;
            }
            Console.WriteLine("Введите цену товара (1шт)");
            invoice1.price = int.Parse(Console.ReadLine());
            if (invoice1.price <= 0)
            {
                Console.WriteLine("Неправильно введена цена. Значение установлено 0");
                invoice1.price = Invoice.baseprice;
            }
            invoice1.NDS = 0.1f;

            static Invoice PrintInfo(Invoice invoice)
            {
                Console.WriteLine();
                Console.WriteLine("Информация о счете в приложении");
                Console.WriteLine($"ID: {invoice.Id}");
                Console.WriteLine($"Дата проведения накладной: {invoice.date}");
                Console.WriteLine($"Наименование товара: {invoice.product}");
                Console.WriteLine($"Количество единиц товара: {invoice.count}");
                Console.WriteLine($"Стоимость единицы товара (руб): {invoice.price}");
                Console.WriteLine();
                return invoice;
            }

            static void GetFullPrice(Invoice invoice)
            {
                Console.WriteLine($"Стоимость с учетом НДС (руб): {invoice.price * (1 + invoice.NDS) * invoice.count}");
            }
            PrintInfo(invoice);
            GetFullPrice(invoice);
            PrintInfo(invoice1);
            GetFullPrice(invoice1);
            Console.WriteLine();
            Invoice.Counter1(Invoice.counter);
        }
    }
    
}
   