namespace OOP_Buoi1
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMSV = new TextBox();
            txtTSV = new TextBox();
            btnNhap = new Button();
            txtSDT = new TextBox();
            lsbSV = new ListBox();
            dtNS = new DateTimePicker();
            rdbNam = new RadioButton();
            rdbNu = new RadioButton();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 82);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Masv";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 113);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 0;
            label2.Text = "Ten SV";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 137);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 0;
            label4.Text = "Ngay sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 167);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 0;
            label5.Text = "SDT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 198);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 0;
            label6.Text = "Gioi tinh";
            // 
            // txtMSV
            // 
            txtMSV.Location = new Point(150, 76);
            txtMSV.Name = "txtMSV";
            txtMSV.Size = new Size(199, 23);
            txtMSV.TabIndex = 1;
            // 
            // txtTSV
            // 
            txtTSV.Location = new Point(150, 105);
            txtTSV.Name = "txtTSV";
            txtTSV.Size = new Size(199, 23);
            txtTSV.TabIndex = 1;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(255, 248);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(75, 23);
            btnNhap.TabIndex = 2;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(150, 164);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(199, 23);
            txtSDT.TabIndex = 3;
            // 
            // lsbSV
            // 
            lsbSV.FormattingEnabled = true;
            lsbSV.ItemHeight = 15;
            lsbSV.Location = new Point(403, 76);
            lsbSV.Name = "lsbSV";
            lsbSV.Size = new Size(212, 139);
            lsbSV.TabIndex = 4;
            // 
            // dtNS
            // 
            dtNS.Location = new Point(150, 134);
            dtNS.Name = "dtNS";
            dtNS.Size = new Size(199, 23);
            dtNS.TabIndex = 5;
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.Location = new Point(150, 206);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(51, 19);
            rdbNam.TabIndex = 7;
            rdbNam.TabStop = true;
            rdbNam.Text = "Nam";
            rdbNam.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            rdbNu.AutoSize = true;
            rdbNu.Location = new Point(207, 206);
            rdbNu.Name = "rdbNu";
            rdbNu.Size = new Size(41, 19);
            rdbNu.TabIndex = 7;
            rdbNu.TabStop = true;
            rdbNu.Text = "Nữ";
            rdbNu.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(237, 30);
            label7.Name = "label7";
            label7.Size = new Size(272, 21);
            label7.TabIndex = 8;
            label7.Text = "Form đăng ký thông tinh sinh viên";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 339);
            Controls.Add(label7);
            Controls.Add(rdbNu);
            Controls.Add(rdbNam);
            Controls.Add(dtNS);
            Controls.Add(lsbSV);
            Controls.Add(txtSDT);
            Controls.Add(btnNhap);
            Controls.Add(txtTSV);
            Controls.Add(txtMSV);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMSV;
        private TextBox txtTSV;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button btnNhap;
        private TextBox txtSDT;
        private ListBox lsbSV;
        private DateTimePicker dtNS;
        private RadioButton rdbNam;
        private RadioButton rdbNu;
        private Label label7;
    }
}
