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
    public partial class Main : Form
    {
        Database database;
        List<Category> categories;
        List<Book> books;
        public static List<Book> booksInCarts = new List<Book>();

        public Main()
        {
            InitializeComponent();
            MaximizeBox = false;

            database = new Database();
            categories = new List<Category>();
            books = new List<Book>();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            loadCategory(e);
            byNameRadioButton.Checked = true;
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            AddBook addBookForm = new AddBook(categories, database);
            addBookForm.Show();
        }

        private void comboBoxCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            if (categories != null && comboBoxCategory.SelectedItem != null)
            {
                var category = categories.Where(item => item.Name.Contains((string)comboBoxCategory.SelectedItem));

                loadBooksWithCategory(category.FirstOrDefault().Id);

                int top = 0;
                int left = 20;
                bookPanel.Controls.Clear();

                foreach (Book book in books)
                {
                    Button button = new Button();
                    button.Left = left;
                    button.Top = top;
                    button.Width = 200;
                    button.Height = 45;
                    button.Text = book.Name + "(" + book.Author + ")";
                    bookPanel.Controls.Add(button);
                    button.Click += new EventHandler(addToCarts_Click);
                    top += button.Height + 2;
                }
            }
        }

        private void addToCarts_Click(object sender, EventArgs e)
        {
            var book = books.Where(item => item.Name.Contains((sender as Button).Text.Split('(')[0]));
            Category category;

            if (comboBoxCategory.SelectedItem != null)
            {
                category = categories.Where(item => item.Name.Contains((string)comboBoxCategory.SelectedItem)).FirstOrDefault();
            }
            else
            {
                category = categories.Where(item => item.Id == book.FirstOrDefault().Category).FirstOrDefault();
            }

            AddToCart addToCartForm = new AddToCart(book.FirstOrDefault(), category);
            addToCartForm.Show();
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            PayBill payBillForm = new PayBill(database);
            payBillForm.Show();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            loadCategory(e);
            loadBooksWithSearch(searchTextBox.Text);
            int top = 0;
            int left = 20;
            bookPanel.Controls.Clear();

            foreach (Book book in books)
            {
                Button button = new Button();
                button.Left = left;
                button.Top = top;
                button.Width = 200;
                button.Height = 45;
                button.Text = book.Name + "(" + book.Author + ")";
                bookPanel.Controls.Add(button);
                button.Click += new EventHandler(addToCarts_Click);
                top += button.Height + 2;
            }
        }

        private void billsButton_Click(object sender, EventArgs e)
        {
            Bills billsForm = new Bills(database);
            billsForm.Show();
        }

        private void loadCategory(EventArgs e)
        {
            try
            {
                database.OpenConnection();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = database.Connection;
                cmd.CommandText = "SELECT * FROM Kategorija";

                OleDbDataReader reader = cmd.ExecuteReader();
                categories.Clear();
                comboBoxCategory.Items.Clear();
                while (reader.Read())
                {
                    Category category = new Category();
                    category.Id = int.Parse(reader["ID_kategorije"].ToString());
                    category.Name = reader["naziv"].ToString();
                    categories.Add(category);
                }

                foreach (Category category in categories)
                {
                    comboBoxCategory.Items.Add(category.Name);
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

        public void loadBooksWithCategory(int categoryId)
        {
            try
            {
                database.OpenConnection();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = database.Connection;
                cmd.CommandText = @"SELECT * FROM Knjiga WHERE id_kategorija = @id_kategorija ORDER BY autor";
                cmd.Parameters.AddWithValue("id_kategorija", categoryId);

                OleDbDataReader reader = cmd.ExecuteReader();
                books.Clear();
                while (reader.Read())
                {
                    Book book = new Book();
                    book.Id = int.Parse(reader["ID_knjiga"].ToString());
                    book.Name = reader["naziv"].ToString();
                    book.Author = reader["autor"].ToString();
                    book.Price = int.Parse(reader["cena"].ToString());
                    book.Discount = int.Parse(reader["popust"].ToString());
                    book.Category = int.Parse(reader["id_kategorija"].ToString());
                    book.Quantity = 0;
                    books.Add(book);
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

        public void loadBooksWithSearch(string keyword)
        {
            try
            {
                database.OpenConnection();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = database.Connection;
                if (byNameRadioButton.Checked)
                {
                    cmd.CommandText = @"SELECT * FROM Knjiga WHERE naziv LIKE @keyword ORDER BY autor";
                }
                else
                {
                    cmd.CommandText = @"SELECT * FROM Knjiga WHERE autor LIKE @keyword ORDER BY autor";
                }
                cmd.Parameters.AddWithValue("keyword", "%" + keyword + "%");

                OleDbDataReader reader = cmd.ExecuteReader();
                books.Clear();
                while (reader.Read())
                {
                    Book book = new Book();
                    book.Id = int.Parse(reader["ID_knjiga"].ToString());
                    book.Name = reader["naziv"].ToString();
                    book.Author = reader["autor"].ToString();
                    book.Price = int.Parse(reader["cena"].ToString());
                    book.Discount = int.Parse(reader["popust"].ToString());
                    book.Category = int.Parse(reader["id_kategorija"].ToString());
                    book.Quantity = 0;
                    books.Add(book);
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
