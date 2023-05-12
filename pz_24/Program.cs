namespace pz_24
{
    class Invoice : ICloneable
    {
        private static int totalInvoicesCount;

        public string ID { get; private set; }
        public DateTime Date { get; set; }
        public string Product { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public decimal NDS { get; set; }

        public Invoice(string ID, DateTime date, string product, int count, decimal price, decimal NDS = 0)
        {
            this.ID = ID;
            Date = date;
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

        public object Clone()
        {
            return MemberwiseClone();
        }
    }

    class LandingInvoice : Invoice, ICloneable
    {
        public string DeliveryPerson { get; set; }
        public string VehicleNumber { get; set; }

        public LandingInvoice(string ID, DateTime date, string product, int count, decimal price, decimal NDS,
                              string deliveryPerson, string vehicleNumber)
            : base(ID, date, product, count, price, NDS)
        {
            DeliveryPerson = deliveryPerson;
            VehicleNumber = vehicleNumber;
        }

        public void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("ФИО Доставщика: " + DeliveryPerson);
            Console.WriteLine("Гос.номер транспортного средства: " + VehicleNumber);
        }

        public new object Clone()
        {
            return MemberwiseClone();
        }
        class Program
        {
            static void Main()
            {
                LandingInvoice landingInvoice1 = new LandingInvoice("001", DateTime.Now, "Product 1", 5, 10.5m, 0,
                                                                    "John Doe", "ABC123");
                LandingInvoice landingInvoice2 = new LandingInvoice("002", DateTime.Now, "Product 2", 10, 20.75m, 0.2m,
                                                                    "Jane Smith", "XYZ789");
                LandingInvoice landingInvoice3 = new LandingInvoice("003", DateTime.Now, "Product 3", 3, 15.0m, 0.1m,
                                                                    "Mike Johnson", "DEF456");

                landingInvoice1.PrintInfo();
                Console.WriteLine();
                landingInvoice2.PrintInfo();
                Console.WriteLine();
                landingInvoice3.PrintInfo();
                Console.WriteLine();
                PrintTotalInvoicesCount();
                Console.WriteLine();

                Console.ReadLine();
            }
        }
    }
}