using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    public class Bill
    {
        private int id;
        private double price;
        private DateTime date;
        private string time;

        public Bill() { }

        public Bill(int id, double price, DateTime date, string time)
        {
            this.id = id;
            this.price = price;
            this.date = date;
            this.time = time;
        }

        public int Id { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
    }
}
