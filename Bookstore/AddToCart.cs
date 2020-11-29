using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore
{
    public partial class AddToCart : Form
    {
        Book book;

        public AddToCart()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        public AddToCart(Book book, Category category) : this()
        {
            this.book = book;
            bookNameTextBox.Text = book.Name;
            bookAuthorTextBox.Text = book.Author;
            bookPriceTextBox.Text = book.Price.ToString();
            bookDiscountTextBox.Text = book.Discount.ToString();
            bookCategoryTextBox.Text = category.Name;
        }

        private void addToCarts_Click(object sender, EventArgs e)
        {
            addBook();
            this.Close();
        }

        private void addBook()
        {
            var bookFromCarts = Main.booksInCarts.Where(item => item.Id == book.Id).FirstOrDefault();
            if (bookFromCarts != null)
            {
                bookFromCarts.Quantity += int.Parse(bookQuantityNumericUpDown.Text);
                Main.booksInCarts.Remove(bookFromCarts);
                Main.booksInCarts.Add(bookFromCarts);
            }
            else
            {
                book.Quantity = int.Parse(bookQuantityNumericUpDown.Text);
                Main.booksInCarts.Add(book);
            }
        }
    }
}
