namespace Copper_Project_OOP
{
    partial class productOperator
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            inputWeight = new TextBox();
            send = new Button();
            receive = new Button();
            txtDisplay = new TextBox();
            sendReciv = new Button();
            txtBox = new TextBox();
            wrap = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(275, 210);
            btn1.Name = "btn1";
            btn1.Size = new Size(208, 33);
            btn1.TabIndex = 0;
            btn1.Text = "شروع خردایش ";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(275, 277);
            btn2.Name = "btn2";
            btn2.Size = new Size(208, 33);
            btn2.TabIndex = 1;
            btn2.Text = "شروع تانک لیچینگ";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(275, 344);
            btn3.Name = "btn3";
            btn3.Size = new Size(208, 33);
            btn3.TabIndex = 2;
            btn3.Text = "شروع استحصال";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(275, 412);
            btn4.Name = "btn4";
            btn4.Size = new Size(208, 33);
            btn4.TabIndex = 3;
            btn4.Text = "شروع الکترووینینگ";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 219);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 286);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 353);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 421);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(371, 64);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 9;
            label4.Text = ":وزن مورد نیاز از سنگ";
            // 
            // inputWeight
            // 
            inputWeight.BorderStyle = BorderStyle.FixedSingle;
            inputWeight.Location = new Point(231, 62);
            inputWeight.Name = "inputWeight";
            inputWeight.Size = new Size(134, 23);
            inputWeight.TabIndex = 10;
            // 
            // send
            // 
            send.Location = new Point(36, 62);
            send.Name = "send";
            send.Size = new Size(136, 23);
            send.TabIndex = 11;
            send.Text = "ارسال درخواست";
            send.UseVisualStyleBackColor = true;
            send.Click += send_Click;
            // 
            // receive
            // 
            receive.Location = new Point(231, 124);
            receive.Name = "receive";
            receive.Size = new Size(252, 52);
            receive.TabIndex = 12;
            receive.Text = "تحویل سنگ";
            receive.UseVisualStyleBackColor = true;
            receive.Click += receive_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.BorderStyle = BorderStyle.FixedSingle;
            txtDisplay.Location = new Point(36, 124);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(136, 52);
            txtDisplay.TabIndex = 13;
            // 
            // sendReciv
            // 
            sendReciv.Location = new Point(231, 495);
            sendReciv.Name = "sendReciv";
            sendReciv.Size = new Size(252, 52);
            sendReciv.TabIndex = 14;
            sendReciv.Text = "نمایش کاتد های تاییدی";
            sendReciv.UseVisualStyleBackColor = true;
            sendReciv.Click += sendReciv_Click;
            // 
            // txtBox
            // 
            txtBox.BorderStyle = BorderStyle.FixedSingle;
            txtBox.Location = new Point(36, 495);
            txtBox.Multiline = true;
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(136, 52);
            txtBox.TabIndex = 15;
            // 
            // wrap
            // 
            wrap.Location = new Point(36, 596);
            wrap.Name = "wrap";
            wrap.Size = new Size(447, 38);
            wrap.TabIndex = 16;
            wrap.Text = "بسته بندی و ارسال";
            wrap.UseVisualStyleBackColor = true;
            wrap.Click += wrap_Click;
            // 
            // productOperator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 667);
            Controls.Add(wrap);
            Controls.Add(txtBox);
            Controls.Add(sendReciv);
            Controls.Add(txtDisplay);
            Controls.Add(receive);
            Controls.Add(send);
            Controls.Add(inputWeight);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "productOperator";
            Text = "پنل اپراتور تولید";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private TextBox inputWeight;
        private Button send;
        private Button receive;
        private TextBox txtDisplay;
        private Button sendReciv;
        private TextBox txtBox;
        private Button wrap;
    }
}