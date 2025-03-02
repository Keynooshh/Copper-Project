namespace Copper_Project_OOP
{
    partial class productManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            schedual = new DataGridView();
            report = new DataGridView();
            state = new Label();
            time = new Label();
            get = new Button();
            add = new Button();
            process = new ComboBox();
            duration = new NumericUpDown();
            compare = new Button();
            label1 = new Label();
            send = new Button();
            ((System.ComponentModel.ISupportInitialize)schedual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)report).BeginInit();
            ((System.ComponentModel.ISupportInitialize)duration).BeginInit();
            SuspendLayout();
            // 
            // schedual
            // 
            schedual.BackgroundColor = SystemColors.Control;
            schedual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            schedual.Location = new Point(12, 29);
            schedual.Name = "schedual";
            schedual.Size = new Size(257, 199);
            schedual.TabIndex = 0;
            // 
            // report
            // 
            report.BackgroundColor = SystemColors.Control;
            report.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            report.Location = new Point(12, 252);
            report.Name = "report";
            report.Size = new Size(257, 199);
            report.TabIndex = 1;
            // 
            // state
            // 
            state.AutoSize = true;
            state.Location = new Point(427, 74);
            state.Name = "state";
            state.Size = new Size(37, 15);
            state.TabIndex = 4;
            state.Text = ":فزآیند";
            // 
            // time
            // 
            time.AutoSize = true;
            time.Location = new Point(427, 105);
            time.Name = "time";
            time.Size = new Size(32, 15);
            time.TabIndex = 5;
            time.Text = ":زمان";
            // 
            // get
            // 
            get.Location = new Point(294, 297);
            get.Name = "get";
            get.Size = new Size(171, 53);
            get.TabIndex = 6;
            get.Text = "دریافت گزارش تولید";
            get.UseVisualStyleBackColor = true;
            get.Click += get_Click;
            // 
            // add
            // 
            add.Location = new Point(293, 145);
            add.Name = "add";
            add.Size = new Size(171, 35);
            add.TabIndex = 7;
            add.Text = "افزودن به برنامه";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // process
            // 
            process.FormattingEnabled = true;
            process.Location = new Point(293, 74);
            process.Name = "process";
            process.Size = new Size(127, 23);
            process.TabIndex = 8;
            // 
            // duration
            // 
            duration.Location = new Point(294, 103);
            duration.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            duration.Name = "duration";
            duration.Size = new Size(127, 23);
            duration.TabIndex = 9;
            duration.TextAlign = HorizontalAlignment.Center;
            // 
            // compare
            // 
            compare.Location = new Point(294, 366);
            compare.Name = "compare";
            compare.Size = new Size(171, 53);
            compare.TabIndex = 10;
            compare.Text = "مقایسه با برنامه";
            compare.UseVisualStyleBackColor = true;
            compare.Click += compare_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(371, 42);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 11;
            label1.Text = ":تهیه برنامه تولید";
            // 
            // send
            // 
            send.Location = new Point(294, 186);
            send.Name = "send";
            send.Size = new Size(171, 35);
            send.TabIndex = 12;
            send.Text = "ارسال و شروع برنامه";
            send.UseVisualStyleBackColor = true;
            send.Click += send_Click;
            // 
            // productManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 475);
            Controls.Add(send);
            Controls.Add(label1);
            Controls.Add(compare);
            Controls.Add(duration);
            Controls.Add(process);
            Controls.Add(add);
            Controls.Add(get);
            Controls.Add(time);
            Controls.Add(state);
            Controls.Add(report);
            Controls.Add(schedual);
            Name = "productManage";
            Text = "پنل مدیر تولید";
            Load += productManage_Load;
            ((System.ComponentModel.ISupportInitialize)schedual).EndInit();
            ((System.ComponentModel.ISupportInitialize)report).EndInit();
            ((System.ComponentModel.ISupportInitialize)duration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView schedual;
        private DataGridView report;
        private Label state;
        private Label time;
        private Button get;
        private Button add;
        private ComboBox process;
        private NumericUpDown duration;
        private Button compare;
        private Label label1;
        private Button send;
    }
}