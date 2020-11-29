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
    public partial class Bills : Form
    {
        Database database;
        List<Bill> bills;

        public Bills()
        {
            InitializeComponent();
            MaximizeBox = false;
            bills = new List<Bill>();
        }

        public Bills(Database database) : this()
        {
            this.database = database;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            loadBills();
        }

        private void loadBills()
        {
            try
            {
                database.OpenConnection();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = database.Connection;
                cmd.CommandText = @"SELECT * FROM Racun WHERE datum = @datum";
                cmd.Parameters.AddWithValue("datum", dateTimePicker.Value.ToShortDateString());

                OleDbDataReader reader = cmd.ExecuteReader();
                bills.Clear();
                while (reader.Read())
                {
                    Bill bill = new Bill();
                    bill.Id = int.Parse(reader["ID_racun"].ToString());
                    bill.Price = double.Parse(reader["cena"].ToString());
                    bill.Date = Convert.ToDateTime(reader["datum"]);
                    bill.Time = reader["vreme"].ToString();
                    bills.Add(bill);
                }

                billPanel.Controls.Clear();
                if (bills.Count > 0)
                {
                    int top = 0;
                    int left = 0;

                    foreach (Bill bill in bills)
                    {
                        Label label = new Label();
                        label.Left = left;
                        label.Top = top;
                        label.Width = 250;
                        label.Height = 25;
                        label.Text = "Price: " + bill.Price.ToString() + " (" + bill.Date.ToString("MMMM dd, yyyy") + " " + bill.Time + ")";
                        billPanel.Controls.Add(label);
                        top += 30;
                    }
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
