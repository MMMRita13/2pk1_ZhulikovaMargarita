using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace pz_21
{
    class Invoice
    {
        public Guid Id;
        public DateTime date
            {
            get { return DateTime.Now; }
            set
            {
                if (value > DateTime.Now)
                {
                    Console.WriteLine("Ошибка");
                }
                else date = value;
            }
        }
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
        public static  void Counter1(int counter)
        {
            Console.WriteLine(counter);
        }
    }
}