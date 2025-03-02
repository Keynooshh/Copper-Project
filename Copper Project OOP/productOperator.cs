using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.DataFormats;

namespace Copper_Project_OOP
{
    public partial class productOperator : Form
    {

        private Random random = new Random();
        private double valueFromButton1 = 0.0;
        private string optionFromButton2 = "";
        private double valueFromButton3 = 0.0;
        private int randomSixDigitNumber = new Random().Next(100000, 1000000);


        public productOperator()
        {
            InitializeComponent();
            DatabaseHelper.InitializeDatabase();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int weight = 100; 
            double size = 5.00; 
            string state = "Solid"; 

            string targetString = $"وزن: {weight}, اندازه: {size:F2}, حالت: {state}";

            if (txtDisplay.Text.Contains("...در انتظار") || string.IsNullOrWhiteSpace(txtDisplay.Text)) {

                MessageBox.Show("!سنگ معدن برای شروع فرآیند وجود ندارد", "Warning");
            
            }
            else
            {
                valueFromButton1 = GenerateRandomNumber(50.0, 95.0);
                label1.Text = $"اندازه خرده ها: {valueFromButton1:F2}";

                int duration = random.Next(1, 50);

                DatabaseHelper.InsertOrUpdateProcess("خردایش سنگ", duration);

            }
        }


        private void btn2_Click(object sender, EventArgs e)
        {
            if (valueFromButton1 <= 80.0)
            {
                MessageBox.Show("!اندازه خرده ها مناسب شروع فرایند نیست", "Warning");
                return;
            }

            string[] options = { "نیمه محلول", "محلول" };
            optionFromButton2 = options[random.Next(options.Length)];

            label2.Text = $"حالت: {optionFromButton2}";

            int duration = random.Next(1, 50);

            DatabaseHelper.InsertOrUpdateProcess("تانک لیچینگ", duration);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (optionFromButton2 != "محلول")
            {
                MessageBox.Show("!حالت ماده مناسب شروع فرایند نیست", "Warning");
                return;
            }

            valueFromButton3 = GenerateRandomNumber(40.0, 95.0);
            label3.Text = $"درصد خلوص : {valueFromButton3:F2}";

            int duration = random.Next(50, 100);

            DatabaseHelper.InsertOrUpdateProcess("استحصال مس", duration);
        }


        private int? pendingIdentifier = null;
        private double? pendingPurityPercentage = null;

        private void btn4_Click(object sender, EventArgs e)
        {
            if (valueFromButton3 <= 80.0)
            {
                MessageBox.Show("!درصد خلوص مناسب شروع فرایند نیست", "Warning");
                return;
            }

            pendingIdentifier = random.Next(100000, 1000000);
            pendingPurityPercentage = valueFromButton3;
            label5.Text = $"درصد خلوص: {pendingPurityPercentage:F2}, شناسه: {pendingIdentifier}";

            int duration = random.Next(70, 100);

            DatabaseHelper.InsertOrUpdateProcess("الکترووینینگ", duration);

            var qualityForm = new qualityCheck(pendingPurityPercentage.Value, pendingIdentifier.Value);
            qualityForm.Show();
        }


        private double GenerateRandomNumber(double min, double max)
        {
            return Math.Round(random.NextDouble() * (max - min) + min, 2);
        }

        private void send_Click(object sender, EventArgs e)
        {
            if (float.TryParse(inputWeight.Text, out float inputValue))
            {
                storeKeeper keeper = new storeKeeper(inputValue);
                keeper.DataSent += storeKeeper_DataSent;
                keeper.Show();
            }
            else
            {
                MessageBox.Show(".ورودی نامعتبر است", "Invalid Input");
            }
        }

        private void receive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "...در انتظار";
        }

        private void storeKeeper_DataSent(object sender, DataSentEventArgs e)
        {
            string formattedString = $"وزن: {e.Weight}, اندازه: {e.Size:F2}, حالت: {e.State}";
            txtDisplay.Text = formattedString;
        }



        public class DataSentEventArgs : EventArgs
        {
            public int Weight { get; set; }
            public double Size { get; set; }
            public string State { get; set; }

            public string Accept { get; set; }
            public string Reject { get; set; }
        }

        private void sendReciv_Click(object sender, EventArgs e)
        {
            txtBox.Text = "...در انتظار";
            qualityCheck f = new qualityCheck(valueFromButton3, randomSixDigitNumber);
            f.DataSent += quaoity_DataSent;
            f.Show();
        }

        private void quaoity_DataSent(object sender, DataSentEventArgs e)
        {
            string resultMessage = string.Empty;

            if (!string.IsNullOrEmpty(e.Accept))
            {
                resultMessage += $"{e.Accept} ";
            }

            if (!string.IsNullOrEmpty(e.Reject))
            {
                resultMessage += $"{e.Reject}";
            }

            txtBox.Text = resultMessage;
        }

        private void wrap_Click(object sender, EventArgs e)
        {
            if (!pendingIdentifier.HasValue || !pendingPurityPercentage.HasValue)
            {
                MessageBox.Show("کاتد مسی برای ارسال موجود نیست", "Error");
                return;
            }

            if (txtBox.Text.Contains("تایید شد"))
            {
                DatabaseHelper.InsertCopper(pendingIdentifier.Value, pendingPurityPercentage.Value);
                MessageBox.Show("کاتد مس بسته بندی و به انبار ارسال شد", "Success");

                pendingIdentifier = null;
                pendingPurityPercentage = null;

                this.Close();

            }
            else if (txtBox.Text.Contains("رد شد"))
            {
                
                MessageBox.Show("کیفیت کاتد برای ارسال مناسب نیست", "Error");
            }
            else
            {
                
                MessageBox.Show("ورودی نامعتبر است", "Error");
            }
        }
    }
}
