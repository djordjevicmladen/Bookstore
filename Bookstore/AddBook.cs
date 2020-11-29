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
    public partial class AddBook : Form
    {
        Database database;
        List<Category> categories;

        public AddBook()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        public AddBook(List<Category> categories, Database database) : this()
        {
            this.categories = categories;
            this.database = database;
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            loadCategory();
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            try
            {
                database.OpenConnection();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = database.Connection;
                cmd.CommandText = @"INSERT INTO Knjiga(naziv,autor,cena,popust,id_kategorija) VALUES (@naziv,@autor,@cena,@popust,@kategorija)";
                cmd.Parameters.AddWithValue("naziv", bookNameTextBox.Text);
                cmd.Parameters.AddWithValue("autor", bookAuthorTextBox.Text);
                cmd.Parameters.AddWithValue("cena", bookPriceNumericUpDown.Value);
                cmd.Parameters.AddWithValue("popust", bookDiscountNumericUpDown.Value);
                cmd.Parameters.AddWithValue("kategorija", int.Parse(bookCategoryComboBox.SelectedValue.ToString()));

                int rezultat = cmd.ExecuteNonQuery();

                if (rezultat > 0)
                {
                    bookNameTextBox.Text = "";
                    bookAuthorTextBox.Text = "";
                    bookPriceNumericUpDown.Value = 1;
                    bookDiscountNumericUpDown.Value = 0;
                    bookCategoryComboBox.SelectedIndex = 0;

                    MessageBox.Show("Successfully added book!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Adding books failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void loadCategory()
        {
            try
            {
                bookCategoryComboBox.DataSource = categories;
                bookCategoryComboBox.DisplayMember = "Name";
                bookCategoryComboBox.ValueMember = "Id";
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
