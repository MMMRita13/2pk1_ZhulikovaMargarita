using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_22
{
    class Invoice
    {
        public Guid Id;
        public static DateTime basedate = new DateTime(0001, 01, 01);
        public static int basecount = 0;
        public static int baseprice = 0;
        public DateTime date;
        public string product;
        public int count;
        public int price;
        public float NDS;
        public static int counter = 0;
        public Invoice()
        {
            this.product = product;
            this.count = count;
            this.price = price;
            this.NDS = NDS;
            this.date = date;
            counter++;
        }
        public static void Counter1(int counter)
        {
            Console.WriteLine("Количество накладных " + counter);
        }
    }
    
}
