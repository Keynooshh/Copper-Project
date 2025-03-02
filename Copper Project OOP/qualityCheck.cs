using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Copper_Project_OOP.productOperator;
using static System.Windows.Forms.AxHost;

namespace Copper_Project_OOP
{
    public partial class qualityCheck : Form
    {
        private double valueFromButton3;
        private int randomSixDigitNumber;

        public event EventHandler<DataSentEventArgs> DataSent;
        public qualityCheck(double value, int randomSixDigit)
        {
            InitializeComponent();
            valueFromButton3 = value;
            randomSixDigitNumber = randomSixDigit;
        }

        private void qualityCheck_Load(object sender, EventArgs e)
        {
            ReceivedValues.Text = $"درصد خلوص: {valueFromButton3:F2}, شناسه: {randomSixDigitNumber}";
        }

        private void accept_Click(object sender, EventArgs e)
        {

            string accept = "تایید شد";
            DataSent?.Invoke(this, new DataSentEventArgs { Accept = accept, });
            this.Close();

        }

        private void reject_Click(object sender, EventArgs e)
        {

            string reject = "رد شد";
            DataSent?.Invoke(this, new DataSentEventArgs {  Reject = reject, });
            this.Close();
        }

        
    }
}
