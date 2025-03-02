using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Copper_Project_OOP.productOperator;

namespace Copper_Project_OOP
{
    public partial class storeKeeper : Form
    {
        private float receivedValue;
        public event EventHandler<DataSentEventArgs> DataSent;


        public storeKeeper(float value)
        {
            InitializeComponent();
            receivedValue = value;
        }

        private void storeKeeper_Load(object sender, EventArgs e)
        {
            ReceivedValue.Text = $"kg درخواست: {receivedValue:F2}";
        }

        private void send_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtWeight.Text, out int weight) || weight < 0 || weight > 1000)
            {
                MessageBox.Show("ورودی نامعتبر", "Invalid Input");
            }

            double size = 5.0;
            string state = "Solid";


            DataSent?.Invoke(this, new DataSentEventArgs
            {
                Weight = weight,
                Size = size,
                State = state
            });

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string num = number.Text;

            if (num == "")
            {
                MessageBox.Show("ورودی نامعتبر", "Invalid Input");
            }
            else
            {
                MessageBox.Show($"{num}ورقه کاتد مس برای مشتری ارسال شد");
            }


        }

        private void stone_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable stones = DatabaseHelper.GetAllStones();
                dataGridView.DataSource = stones;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در بارگیری داده ها: {ex.Message}", "Error");
            }
        }

        private void copper_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable stones = DatabaseHelper.GetAllCoppers();
                dataGridView.DataSource = stones;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در بارگیری داده ها: {ex.Message}", "Error");
            }
        }

        private void seeRequest_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable stones = DatabaseHelper.GetAllOrders();
                dataGridView.DataSource = stones;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در بارگیری داده ها: {ex.Message}", "Error");
            }
        }
    }
}
