namespace pz_23
{
    class Program
    {
        static void Main()
        {
            LandingInvoice landingInvoice1 = new LandingInvoice("001", DateTime.Now, "Product 1", 5, 10.5m, 0, "Серов Антон", "ABC123");
            LandingInvoice landingInvoice2 = new LandingInvoice("002", DateTime.Now, "Product 2", 10, 20.75m, 0.2m, "Иванов Дмитрий", "XYZ789");
            LandingInvoice landingInvoice3 = new LandingInvoice("003", DateTime.Now, "Product 3", 3, 15.0m, 0.1m,"Сидоров Максим", "DEF456");

            landingInvoice1.PrintInfo();
            Console.WriteLine();
            landingInvoice2.PrintInfo();
            Console.WriteLine();
            landingInvoice3.PrintInfo();
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}