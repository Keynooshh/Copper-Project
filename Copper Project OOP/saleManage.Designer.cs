namespace Copper_Project_OOP
{
    partial class saleManage
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
            orderView = new DataGridView();
            showData = new Button();
            register = new Button();
            ((System.ComponentModel.ISupportInitialize)orderView).BeginInit();
            SuspendLayout();
            // 
            // orderView
            // 
            orderView.BackgroundColor = SystemColors.Control;
            orderView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderView.Location = new Point(23, 24);
            orderView.Name = "orderView";
            orderView.Size = new Size(307, 167);
            orderView.TabIndex = 0;
            // 
            // showData
            // 
            showData.Location = new Point(23, 224);
            showData.Name = "showData";
            showData.Size = new Size(307, 33);
            showData.TabIndex = 1;
            showData.Text = "نمایش سفارشات";
            showData.UseVisualStyleBackColor = true;
            showData.Click += showData_Click;
            // 
            // register
            // 
            register.Location = new Point(23, 274);
            register.Name = "register";
            register.Size = new Size(307, 33);
            register.TabIndex = 2;
            register.Text = "تایید و ارسال";
            register.UseVisualStyleBackColor = true;
            register.Click += register_Click;
            // 
            // saleManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 356);
            Controls.Add(register);
            Controls.Add(showData);
            Controls.Add(orderView);
            Name = "saleManage";
            Text = "پنل مدیر فروش";
            ((System.ComponentModel.ISupportInitialize)orderView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView orderView;
        private Button showData;
        private Button register;
    }
}