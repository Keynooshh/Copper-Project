namespace Copper_Project_OOP
{
    partial class logInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userName = new TextBox();
            upassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            costumer = new Button();
            worker = new Button();
            SuspendLayout();
            // 
            // userName
            // 
            userName.BorderStyle = BorderStyle.FixedSingle;
            userName.Location = new Point(51, 68);
            userName.Name = "userName";
            userName.Size = new Size(213, 23);
            userName.TabIndex = 0;
            userName.TextAlign = HorizontalAlignment.Center;
            // 
            // upassword
            // 
            upassword.BorderStyle = BorderStyle.FixedSingle;
            upassword.Location = new Point(51, 114);
            upassword.Name = "upassword";
            upassword.Size = new Size(213, 23);
            upassword.TabIndex = 1;
            upassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(270, 70);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 2;
            label1.Text = ":نام کاربر";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 116);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = ":رمز ورود";
            // 
            // costumer
            // 
            costumer.Location = new Point(51, 197);
            costumer.Name = "costumer";
            costumer.Size = new Size(269, 23);
            costumer.TabIndex = 7;
            costumer.Text = "رورد به پنل مشتری";
            costumer.UseVisualStyleBackColor = true;
            costumer.Click += costumer_Click;
            // 
            // worker
            // 
            worker.Location = new Point(51, 236);
            worker.Name = "worker";
            worker.Size = new Size(269, 23);
            worker.TabIndex = 8;
            worker.Text = "رورد به پنل کارمند";
            worker.UseVisualStyleBackColor = true;
            worker.Click += worker_Click;
            // 
            // logInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 318);
            Controls.Add(worker);
            Controls.Add(costumer);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(upassword);
            Controls.Add(userName);
            Name = "logInForm";
            Text = "پنل ورود";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userName;
        private TextBox upassword;
        private Label label1;
        private Label label2;
        private Button costumer;
        private Button worker;
    }
}
