namespace Copper_Project_OOP
{
    partial class qualityCheck
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
            ReceivedValues = new Label();
            accept = new Button();
            reject = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // ReceivedValues
            // 
            ReceivedValues.AutoSize = true;
            ReceivedValues.Location = new Point(21, 125);
            ReceivedValues.Name = "ReceivedValues";
            ReceivedValues.Size = new Size(198, 15);
            ReceivedValues.TabIndex = 0;
            ReceivedValues.Text = ".اطلاعاتی از کاتد مس ارسال نشده است";
            // 
            // accept
            // 
            accept.Location = new Point(207, 172);
            accept.Name = "accept";
            accept.Size = new Size(157, 58);
            accept.TabIndex = 1;
            accept.Text = "تایید کیفیت";
            accept.UseVisualStyleBackColor = true;
            accept.Click += accept_Click;
            // 
            // reject
            // 
            reject.Location = new Point(21, 172);
            reject.Name = "reject";
            reject.Size = new Size(157, 58);
            reject.TabIndex = 2;
            reject.Text = "رد کیفیت";
            reject.UseVisualStyleBackColor = true;
            reject.Click += reject_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(267, 125);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 3;
            label1.Text = ":اطلاعات کاتد مس";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(55, 29);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(288, 65);
            textBox1.TabIndex = 4;
            textBox1.Text = "استاندارد های بررسی کیفیت:\r\nحداقل درصد خلوص ۸۳.۵٪ بوده\r\nشناسه کاتد باید متشکل از ۶ رقم باشد";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // qualityCheck
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 270);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(reject);
            Controls.Add(accept);
            Controls.Add(ReceivedValues);
            Name = "qualityCheck";
            Text = "پنل مهندس کیفیت";
            Load += qualityCheck_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ReceivedValues;
        private Button accept;
        private Button reject;
        private Label label1;
        private TextBox textBox1;
    }
}