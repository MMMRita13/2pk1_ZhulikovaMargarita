using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_23
{
    internal class LandingInvoice : Invoice
    {
        public string DeliveryPerson { get; set; }
        public string VehicleNumber { get; set; }
        public LandingInvoice(string id, DateTime ddate, string product, int count, decimal price, decimal NDS, string deliveryPerson, string vehicleNumber) 
        {
            this.ID = id;
            this.Date = ddate;
            this.Product = product;
            this.Count = count;
            this.Price = price;
            this.NDS = NDS;
            this.DeliveryPerson = deliveryPerson;
            this.VehicleNumber = vehicleNumber;
        }
        public void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("ФИО Доставщика: " + DeliveryPerson);
            Console.WriteLine("Гос.номер транспортного средства: " + VehicleNumber);
        }
    }
}
