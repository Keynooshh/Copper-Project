using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Copper_Project_OOP
{
    public partial class costumer : Form
    {
        private string _loggedInUser;
        public costumer(string loggedInUser)
        {
            InitializeComponent();
            _loggedInUser = loggedInUser;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int orderAmount = (int)order.Value;

            if (orderAmount <= 0)
            {
                MessageBox.Show(".ورودی نامعتبر است", "Validation Error");
                return;
            }

            UpdateOrderAmount(_loggedInUser, orderAmount);

        }

        private void UpdateOrderAmount(string userName, int orderAmount)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();
                    string updateQuery = @"
                UPDATE Customers
                SET OrderAmount = @OrderAmount
                WHERE Name = @Name;";
                    using (var command = new SQLiteCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Name", userName);
                        command.Parameters.AddWithValue("@OrderAmount", orderAmount);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("سفارش شما با موفقیت ثبت شد", "Success");
                
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(".ورودی نامعتبر است", "Validation Error");
                return;
            }
        }
    }
}
