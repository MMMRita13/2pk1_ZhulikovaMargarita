namespace pz_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice("001", DateTime.Now, "Product 1", 5, 10.5m);
            Invoice invoice2 = new Invoice("002", DateTime.Now, "Product 2", 10, 20.75m, 0.2m);
            Invoice invoice3 = new Invoice("003", DateTime.Now, "Product 3", 3, 15.0m);

            invoice1.PrintInfo();
            invoice2.PrintInfo();
            invoice3.PrintInfo();

            Invoice.PrintTotalInvoicesCount();

            Console.ReadLine();
        }
    }
    
}
   