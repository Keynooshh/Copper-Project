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
    public partial class productManage : Form
    {
        public productManage()
        {
            InitializeComponent();
        }

        private void productManage_Load(object sender, EventArgs e)
        {
            schedual.Columns.Add("ProcessName", "ProcessName");
            schedual.Columns.Add("Duration", "Duration");
            process.Items.AddRange(new string[] { "خردایش سنگ", "تانک لیچینگ", "استحصال مس", "الکترووینینگ" });
            process.SelectedIndex = 0;

        }

        private void PopulateDataGrid(Dictionary<string, int> durations)
        {

            foreach (var entry in durations)
            {
                report.Rows.Add(entry.Key, entry.Value);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            string processName = process.SelectedItem.ToString();
            int durat = (int)duration.Value;


            if (durat <= 0)
            {
                MessageBox.Show("زمان نمی تواند کمتر از 0 باشد", "Validation Error");
                return;
            }

            foreach (DataGridViewRow row in schedual.Rows)
            {
                if (row.Cells["ProcessName"].Value != null &&
                    row.Cells["ProcessName"].Value.ToString() == processName)
                {
                    row.Cells["Duration"].Value = durat;
                    MessageBox.Show($"فرآینده {processName} به {durat} بروزرسانی شد", "Update Successful");
                    return;
                }
            }


            schedual.Rows.Add(processName, durat);


        }

        private void get_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable processDurations = DatabaseHelper.GetProcessDurations();
                report.DataSource = processDurations;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"گزارشی وجود ندارد", "Error");
            }
        }

        private void compare_Click(object sender, EventArgs e)
        {
            
            var schedualData = new Dictionary<string, int>();
            foreach (DataGridViewRow row in schedual.Rows)
            {
                if (row.Cells["ProcessName"].Value != null && row.Cells["Duration"].Value != null)
                {
                    string processName = row.Cells["ProcessName"].Value.ToString();
                    int duration = Convert.ToInt32(row.Cells["Duration"].Value);
                    schedualData[processName] = duration;
                }
            }

            
            var reportData = new Dictionary<string, int>();
            foreach (DataGridViewRow row in report.Rows)
            {
                if (row.Cells["ProcessName"].Value != null && row.Cells["Duration"].Value != null)
                {
                    string processName = row.Cells["ProcessName"].Value.ToString();
                    int duration = Convert.ToInt32(row.Cells["Duration"].Value);
                    reportData[processName] = duration;
                }
            }

            
            var differences = new List<string>();

            foreach (var entry in schedualData)
            {
                if (reportData.TryGetValue(entry.Key, out int reportDuration))
                {
                    if (entry.Value != reportDuration)
                    {
                        differences.Add($"Process: {entry.Key}, Schedule Duration: {entry.Value}, Report Duration: {reportDuration}");
                    }
                }
                else
                {
                    differences.Add($"Process: {entry.Key} is missing in the Report grid.");
                }
            }

            foreach (var entry in reportData)
            {
                if (!schedualData.ContainsKey(entry.Key))
                {
                    differences.Add($"Process: {entry.Key} is missing in the Schedule grid.");
                }
            }

            
            if (differences.Count > 0)
            {
                MessageBox.Show(string.Join("\n", differences), "Comparison Results");
            }
            else
            {
                MessageBox.Show("Both grids have matching data!", "Comparison Results");
            }
        }


        private void send_Click(object sender, EventArgs e)
        {
            productOperator f = new productOperator();
            var report = f;
            report.FormClosed += (s, args) => this.Show();
            f.Show();
            this.Hide();
        }
    }
}
