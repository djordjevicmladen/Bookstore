using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore
{
    public partial class PayBill : Form
    {
        Database database;
        List<Book> books;
        double price;

        public PayBill()
        {
            InitializeComponent();
            MaximizeBox = false;
            this.books = Main.booksInCarts;
            price = 0;
            priceLabel.Text = price.ToString();
        }

        public PayBill(Database database) : this()
        {
            this.database = database;
            loadBooks();
        }

        private void payBillButton_Click(object sender, EventArgs e)
        {
            if (books.Count < 1)
            {
                MessageBox.Show("You have no books in the payment cart!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                saveBill();
                this.Close();
            }
        }

        private void NumericUpDown_ValueChanged(Object sender, EventArgs e)
        {
            int bookId = int.Parse((sender as NumericUpDown).Name.Replace("numericUpDownBook_", ""));
            var book = books.Where(item => item.Id == bookId).FirstOrDefault();
            book.Quantity = int.Parse((sender as NumericUpDown).Value.ToString());
            loadBooks();
            Main.booksInCarts = books;
            bill();
            priceLabel.Text = price.ToString();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse((sender as Button).Name.Replace("buttonBook_", ""));
            var book = books.Where(item => item.Id == bookId).FirstOrDefault();
            books.Remove(book);
            loadBooks();
            Main.booksInCarts = books;
            bill();
            priceLabel.Text = price.ToString();
        }

        private void loadBooks()
        {
            booksPanel.Controls.Clear();
            if (books.Count > 0)
            {
                int top = 0;
                int left = 0;

                foreach (Book book in books)
                {
                    Label label = new Label();
                    label.Left = left;
                    label.Top = top;
                    label.Width = 250;
                    label.Height = 25;
                    label.Text = book.Name + " (" + book.Author + ")";
                    booksPanel.Controls.Add(label);
                    top += 30;

                    NumericUpDown numericUpDown = new NumericUpDown();
                    numericUpDown.Left = left;
                    numericUpDown.Top = top;
                    numericUpDown.Width = 125;
                    numericUpDown.Height = 25;
                    numericUpDown.Minimum = 1;
                    numericUpDown.Maximum = 100;
                    numericUpDown.Value = book.Quantity;
                    numericUpDown.Name = "numericUpDownBook_" + book.Id.ToString();
                    booksPanel.Controls.Add(numericUpDown);
                    numericUpDown.ValueChanged += new EventHandler(NumericUpDown_ValueChanged);
                    top += 30;

                    Button button = new Button();
                    button.Left = left;
                    button.Top = top;
                    button.Width = 125;
                    button.Height = 25;
                    button.Name = "buttonBook_" + book.Id.ToString();
                    button.Text = "Remove from bill";
                    booksPanel.Controls.Add(button);
                    button.Click += new EventHandler(Button_Click);
                    top += 60;
                }

                bill();
                priceLabel.Text = price.ToString();
            }
        }

        private void bill()
        {
            price = 0;
            foreach (Book book in books)
            {
                price += (Convert.ToDouble(book.Price) - (Convert.ToDouble(book.Price) * (Convert.ToDouble(book.Discount) / 100))) * Convert.ToDouble(book.Quantity);
            }
        }

        private void saveBill()
        {
            try
            {
                DateTime now = DateTime.Now;

                database.OpenConnection();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = database.Connection;
                cmd.CommandText = @"INSERT INTO Racun(cena,datum,vreme) VALUES (@cena,@datum,@vreme)";
                cmd.Parameters.AddWithValue("cena", price);
                cmd.Parameters.AddWithValue("datum", now.ToShortDateString());
                cmd.Parameters.AddWithValue("vreme", now.ToShortTimeString());

                int rezultat = cmd.ExecuteNonQuery();

                if (rezultat > 0)
                {
                    books.Clear();
                    Main.booksInCarts.Clear();
                    loadBooks();
                    MessageBox.Show("Successfully paid bill!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    price = 0;
                    priceLabel.Text = price.ToString();
                }
                else
                {
                    MessageBox.Show("Payment for computer not made!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.CloseConnection();
            }
        }
    }
}
