namespace Copper_Project_OOP
{
    partial class storeKeeper
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
            ReceivedValue = new TextBox();
            send = new Button();
            txtWeight = new TextBox();
            label1 = new Label();
            seeRequest = new Button();
            button2 = new Button();
            label2 = new Label();
            number = new TextBox();
            copper = new Button();
            stone = new Button();
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // ReceivedValue
            // 
            ReceivedValue.BorderStyle = BorderStyle.None;
            ReceivedValue.Location = new Point(278, 232);
            ReceivedValue.Name = "ReceivedValue";
            ReceivedValue.ReadOnly = true;
            ReceivedValue.Size = new Size(132, 16);
            ReceivedValue.TabIndex = 0;
            // 
            // send
            // 
            send.Location = new Point(227, 313);
            send.Name = "send";
            send.Size = new Size(234, 40);
            send.TabIndex = 1;
            send.Text = "ارسال سنگ";
            send.UseVisualStyleBackColor = true;
            send.Click += send_Click;
            // 
            // txtWeight
            // 
            txtWeight.BorderStyle = BorderStyle.FixedSingle;
            txtWeight.Location = new Point(227, 275);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(134, 23);
            txtWeight.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(367, 277);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 3;
            label1.Text = ":وزن سنگ ارسالی";
            // 
            // seeRequest
            // 
            seeRequest.Location = new Point(12, 269);
            seeRequest.Name = "seeRequest";
            seeRequest.Size = new Size(190, 84);
            seeRequest.TabIndex = 4;
            seeRequest.Text = "مشاهده درخواست ها";
            seeRequest.UseVisualStyleBackColor = true;
            seeRequest.Click += seeRequest_Click;
            // 
            // button2
            // 
            button2.Location = new Point(223, 163);
            button2.Name = "button2";
            button2.Size = new Size(234, 40);
            button2.TabIndex = 5;
            button2.Text = "ارسال ورقه";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(363, 136);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 6;
            label2.Text = ":تعداد ورقه ارسالی";
            // 
            // number
            // 
            number.BorderStyle = BorderStyle.FixedSingle;
            number.Location = new Point(223, 134);
            number.Name = "number";
            number.Size = new Size(134, 23);
            number.TabIndex = 7;
            // 
            // copper
            // 
            copper.Location = new Point(223, 67);
            copper.Name = "copper";
            copper.Size = new Size(238, 23);
            copper.TabIndex = 8;
            copper.Text = "کاتد مس";
            copper.UseVisualStyleBackColor = true;
            copper.Click += copper_Click;
            // 
            // stone
            // 
            stone.Location = new Point(227, 38);
            stone.Name = "stone";
            stone.Size = new Size(234, 23);
            stone.TabIndex = 9;
            stone.Text = "سنگ معدن";
            stone.UseVisualStyleBackColor = true;
            stone.Click += stone_Click;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = SystemColors.Control;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 38);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(190, 210);
            dataGridView.TabIndex = 10;
            // 
            // storeKeeper
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 389);
            Controls.Add(dataGridView);
            Controls.Add(stone);
            Controls.Add(copper);
            Controls.Add(number);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(seeRequest);
            Controls.Add(label1);
            Controls.Add(txtWeight);
            Controls.Add(send);
            Controls.Add(ReceivedValue);
            Name = "storeKeeper";
            Text = "پنل کارمند انبار";
            Load += storeKeeper_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ReceivedValue;
        private Button send;
        private TextBox txtWeight;
        private Label label1;
        private Button seeRequest;
        private Button button2;
        private Label label2;
        private TextBox number;
        private Button copper;
        private Button stone;
        private DataGridView dataGridView;
    }
}