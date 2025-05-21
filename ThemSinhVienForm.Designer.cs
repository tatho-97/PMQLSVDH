namespace PMQLSVDH
{
    partial class ThemSinhVienForm
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
            tableLayoutPanel = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            textBoxMaSV = new TextBox();
            textBoxTenSV = new TextBox();
            textBoxDiaChi = new TextBox();
            textBoxSDT = new TextBox();
            textBoxEmail = new TextBox();
            dateTimePickerNgaySinh = new DateTimePicker();
            comboBoxLop = new ComboBox();
            buttonXacNhan = new Button();
            buttonHuy = new Button();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Controls.Add(label2, 0, 0);
            tableLayoutPanel.Controls.Add(label3, 2, 0);
            tableLayoutPanel.Controls.Add(label5, 0, 1);
            tableLayoutPanel.Controls.Add(label6, 2, 1);
            tableLayoutPanel.Controls.Add(label8, 0, 2);
            tableLayoutPanel.Controls.Add(label9, 2, 2);
            tableLayoutPanel.Controls.Add(label11, 0, 3);
            tableLayoutPanel.Controls.Add(label12, 2, 3);
            tableLayoutPanel.Controls.Add(textBoxMaSV, 1, 0);
            tableLayoutPanel.Controls.Add(textBoxTenSV, 1, 1);
            tableLayoutPanel.Controls.Add(textBoxDiaChi, 3, 0);
            tableLayoutPanel.Controls.Add(textBoxSDT, 3, 1);
            tableLayoutPanel.Controls.Add(textBoxEmail, 3, 2);
            tableLayoutPanel.Controls.Add(dateTimePickerNgaySinh, 1, 2);
            tableLayoutPanel.Controls.Add(comboBoxLop, 3, 3);
            tableLayoutPanel.Controls.Add(buttonXacNhan, 3, 4);
            tableLayoutPanel.Controls.Add(buttonHuy, 2, 4);
            tableLayoutPanel.Location = new Point(20, 20);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 5;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000019F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000019F));
            tableLayoutPanel.Size = new Size(740, 361);
            tableLayoutPanel.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 0;
            label2.Text = "Mã Sinh viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(388, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 1;
            label3.Text = "Địa chỉ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(3, 72);
            label5.Name = "label5";
            label5.Size = new Size(79, 21);
            label5.TabIndex = 3;
            label5.Text = "Họ và tên:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(388, 72);
            label6.Name = "label6";
            label6.Size = new Size(41, 21);
            label6.TabIndex = 4;
            label6.Text = "SĐT:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(3, 144);
            label8.Name = "label8";
            label8.Size = new Size(83, 21);
            label8.TabIndex = 6;
            label8.Text = "Ngày sinh:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(388, 144);
            label9.Name = "label9";
            label9.Size = new Size(51, 21);
            label9.TabIndex = 7;
            label9.Text = "Email:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(3, 216);
            label11.Name = "label11";
            label11.Size = new Size(73, 21);
            label11.TabIndex = 9;
            label11.Text = "Giới tính:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(388, 216);
            label12.Name = "label12";
            label12.Size = new Size(40, 21);
            label12.TabIndex = 10;
            label12.Text = "Lớp:";
            // 
            // textBoxMaSV
            // 
            textBoxMaSV.BorderStyle = BorderStyle.FixedSingle;
            textBoxMaSV.Dock = DockStyle.Fill;
            textBoxMaSV.Font = new Font("Segoe UI", 12F);
            textBoxMaSV.Location = new Point(133, 3);
            textBoxMaSV.Name = "textBoxMaSV";
            textBoxMaSV.Size = new Size(249, 29);
            textBoxMaSV.TabIndex = 12;
            // 
            // textBoxTenSV
            // 
            textBoxTenSV.BorderStyle = BorderStyle.FixedSingle;
            textBoxTenSV.Dock = DockStyle.Fill;
            textBoxTenSV.Font = new Font("Segoe UI", 12F);
            textBoxTenSV.Location = new Point(133, 75);
            textBoxTenSV.Name = "textBoxTenSV";
            textBoxTenSV.Size = new Size(249, 29);
            textBoxTenSV.TabIndex = 13;
            // 
            // textBoxDiaChi
            // 
            textBoxDiaChi.BorderStyle = BorderStyle.FixedSingle;
            textBoxDiaChi.Dock = DockStyle.Fill;
            textBoxDiaChi.Font = new Font("Segoe UI", 12F);
            textBoxDiaChi.Location = new Point(488, 3);
            textBoxDiaChi.Name = "textBoxDiaChi";
            textBoxDiaChi.Size = new Size(249, 29);
            textBoxDiaChi.TabIndex = 14;
            // 
            // textBoxSDT
            // 
            textBoxSDT.BorderStyle = BorderStyle.FixedSingle;
            textBoxSDT.Dock = DockStyle.Fill;
            textBoxSDT.Font = new Font("Segoe UI", 12F);
            textBoxSDT.Location = new Point(488, 75);
            textBoxSDT.Name = "textBoxSDT";
            textBoxSDT.Size = new Size(249, 29);
            textBoxSDT.TabIndex = 15;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Dock = DockStyle.Fill;
            textBoxEmail.Font = new Font("Segoe UI", 12F);
            textBoxEmail.Location = new Point(488, 147);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(249, 29);
            textBoxEmail.TabIndex = 16;
            // 
            // dateTimePickerNgaySinh
            // 
            dateTimePickerNgaySinh.Dock = DockStyle.Fill;
            dateTimePickerNgaySinh.Font = new Font("Segoe UI", 12F);
            dateTimePickerNgaySinh.Location = new Point(133, 147);
            dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            dateTimePickerNgaySinh.Size = new Size(249, 29);
            dateTimePickerNgaySinh.TabIndex = 23;
            // 
            // comboBoxLop
            // 
            comboBoxLop.Dock = DockStyle.Fill;
            comboBoxLop.Font = new Font("Segoe UI", 12F);
            comboBoxLop.FormattingEnabled = true;
            comboBoxLop.Location = new Point(488, 219);
            comboBoxLop.Name = "comboBoxLop";
            comboBoxLop.Size = new Size(249, 29);
            comboBoxLop.TabIndex = 24;
            // 
            // buttonXacNhan
            // 
            buttonXacNhan.Dock = DockStyle.Right;
            buttonXacNhan.Font = new Font("Segoe UI", 12F);
            buttonXacNhan.Location = new Point(586, 291);
            buttonXacNhan.Name = "buttonXacNhan";
            buttonXacNhan.Size = new Size(151, 67);
            buttonXacNhan.TabIndex = 25;
            buttonXacNhan.Text = "XÁC NHẬN";
            buttonXacNhan.UseVisualStyleBackColor = true;
            buttonXacNhan.Click += buttonXacNhan_Click;
            // 
            // buttonHuy
            // 
            buttonHuy.Dock = DockStyle.Right;
            buttonHuy.Font = new Font("Segoe UI", 12F);
            buttonHuy.Location = new Point(407, 291);
            buttonHuy.Name = "buttonHuy";
            buttonHuy.Size = new Size(75, 67);
            buttonHuy.TabIndex = 26;
            buttonHuy.Text = "HỦY";
            buttonHuy.UseVisualStyleBackColor = true;
            buttonHuy.Click += buttonHuy_Click;
            // 
            // ThemSinhVienForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(tableLayoutPanel);
            Name = "ThemSinhVienForm";
            Text = "ThemSinhVienForm";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label12;
        private TextBox textBoxMaSV;
        private TextBox textBoxTenSV;
        private TextBox textBoxDiaChi;
        private TextBox textBoxSDT;
        private TextBox textBoxEmail;
        private DateTimePicker dateTimePickerNgaySinh;
        private ComboBox comboBoxLop;
        private Button buttonXacNhan;
        private Button buttonHuy;
    }
}