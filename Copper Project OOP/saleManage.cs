using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Copper_Project_OOP
{
    public partial class saleManage : Form
    {
        public saleManage()
        {
            InitializeComponent();
        }

        private void showData_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable stones = DatabaseHelper.GetAllOrders();
                orderView.DataSource = stones;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در بارگیری داده ها: {ex.Message}", "Error");
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            productManage f = new productManage();
            f.Show();
            this.Close();
        }
    }
}
