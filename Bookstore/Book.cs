using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    public class Book
    {
        private int id;
        private string name;
        private string author;
        private int price;
        private int discount;
        private int category;
        private int quantity;

        public Book() { }

        public Book(int id, string name, string author, int price, int discount, int category, int quantity = 0)
        {
            this.id = id;
            this.name = name;
            this.author = author;
            this.price = price;
            this.discount = discount;
            this.category = category;
            this.quantity = quantity;
        }

        public int Id { get; set; }
        public string Name{ get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public int Category { get; set; }      
        public int Quantity { get; set; }
    }
}
