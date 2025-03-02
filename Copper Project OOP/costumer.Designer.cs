namespace Copper_Project_OOP
{
    partial class costumer
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
            button1 = new Button();
            label1 = new Label();
            order = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)order).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(31, 106);
            button1.Name = "button1";
            button1.Size = new Size(167, 82);
            button1.TabIndex = 0;
            button1.Text = "ثبت سفارش";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 59);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 2;
            label1.Text = ":تعداد ورقه";
            // 
            // order
            // 
            order.Location = new Point(31, 57);
            order.Name = "order";
            order.Size = new Size(96, 23);
            order.TabIndex = 3;
            order.TextAlign = HorizontalAlignment.Center;
            // 
            // costumer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(227, 220);
            Controls.Add(order);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "costumer";
            Text = "پنل مشتری";
            ((System.ComponentModel.ISupportInitialize)order).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private NumericUpDown order;
    }
}