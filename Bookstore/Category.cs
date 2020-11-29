using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    public class Category
    {
        private int id;
        private string name;

        public Category() { }

        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
