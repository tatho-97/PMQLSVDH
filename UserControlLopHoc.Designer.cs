namespace PMQLSVDH
{
    partial class UserControlLopHoc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label12 = new Label();
            comboBoxLop = new ComboBox();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            label1 = new Label();
            dataGridView = new DataGridView();
            LopHoc = new DataGridViewTextBoxColumn();
            MaSV = new DataGridViewTextBoxColumn();
            TenSV = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            Diem_CC = new DataGridViewTextBoxColumn();
            Diem_TX = new DataGridViewTextBoxColumn();
            Diem_THI = new DataGridViewTextBoxColumn();
            Diem_HP = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            tableLayoutPanel = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label13 = new Label();
            textBoxMaSV = new TextBox();
            textBoxTenSV = new TextBox();
            textBoxDiaChi = new TextBox();
            textBoxSDT = new TextBox();
            textBoxEmail = new TextBox();
            textBoxDiemCC = new TextBox();
            textBoxDiemTX = new TextBox();
            textBoxDiemTHI = new TextBox();
            textBoxDiemHP = new TextBox();
            buttonXoa = new Button();
            buttonSua = new Button();
            dateTimePickerNgaySinh = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(comboBoxLop);
            panel1.Controls.Add(buttonSearch);
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView);
            panel1.Location = new Point(23, 27);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1536, 533);
            panel1.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(46, 67);
            label12.Name = "label12";
            label12.Size = new Size(49, 28);
            label12.TabIndex = 5;
            label12.Text = "Lớp:";
            // 
            // comboBoxLop
            // 
            comboBoxLop.Font = new Font("Segoe UI", 12F);
            comboBoxLop.FormattingEnabled = true;
            comboBoxLop.Location = new Point(46, 107);
            comboBoxLop.Margin = new Padding(3, 4, 3, 4);
            comboBoxLop.Name = "comboBoxLop";
            comboBoxLop.Size = new Size(262, 36);
            comboBoxLop.TabIndex = 4;
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Segoe UI", 12F);
            buttonSearch.Location = new Point(194, 267);
            buttonSearch.Margin = new Padding(3, 4, 3, 4);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(114, 40);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "TIMKIEM";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.Font = new Font("Segoe UI", 12F);
            textBoxSearch.Location = new Point(46, 213);
            textBoxSearch.Margin = new Padding(3, 4, 3, 4);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(263, 34);
            textBoxSearch.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(46, 160);
            label1.Name = "label1";
            label1.Size = new Size(95, 28);
            label1.TabIndex = 1;
            label1.Text = "Tìm kiếm:";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.BackgroundColor = SystemColors.Control;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { LopHoc, MaSV, TenSV, NgaySinh, GioiTinh, Diem_CC, Diem_TX, Diem_THI, Diem_HP });
            dataGridView.Location = new Point(343, 27);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ShowCellErrors = false;
            dataGridView.ShowRowErrors = false;
            dataGridView.Size = new Size(1170, 480);
            dataGridView.TabIndex = 0;
            // 
            // LopHoc
            // 
            LopHoc.HeaderText = "Lớp";
            LopHoc.MinimumWidth = 6;
            LopHoc.Name = "LopHoc";
            LopHoc.ReadOnly = true;
            LopHoc.Width = 125;
            // 
            // MaSV
            // 
            MaSV.HeaderText = "Mã SV";
            MaSV.MinimumWidth = 6;
            MaSV.Name = "MaSV";
            MaSV.ReadOnly = true;
            MaSV.Width = 125;
            // 
            // TenSV
            // 
            TenSV.HeaderText = "Họ và tên";
            TenSV.MinimumWidth = 6;
            TenSV.Name = "TenSV";
            TenSV.ReadOnly = true;
            TenSV.Width = 125;
            // 
            // NgaySinh
            // 
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.ReadOnly = true;
            NgaySinh.Width = 125;
            // 
            // GioiTinh
            // 
            GioiTinh.HeaderText = "Giới tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.ReadOnly = true;
            GioiTinh.Width = 125;
            // 
            // Diem_CC
            // 
            Diem_CC.HeaderText = "Điểm CC";
            Diem_CC.MinimumWidth = 6;
            Diem_CC.Name = "Diem_CC";
            Diem_CC.ReadOnly = true;
            Diem_CC.Width = 125;
            // 
            // Diem_TX
            // 
            Diem_TX.HeaderText = "Điểm TX";
            Diem_TX.MinimumWidth = 6;
            Diem_TX.Name = "Diem_TX";
            Diem_TX.ReadOnly = true;
            Diem_TX.Width = 125;
            // 
            // Diem_THI
            // 
            Diem_THI.HeaderText = "Điểm THI";
            Diem_THI.MinimumWidth = 6;
            Diem_THI.Name = "Diem_THI";
            Diem_THI.ReadOnly = true;
            Diem_THI.Width = 125;
            // 
            // Diem_HP
            // 
            Diem_HP.HeaderText = "Điểm HP";
            Diem_HP.MinimumWidth = 6;
            Diem_HP.Name = "Diem_HP";
            Diem_HP.ReadOnly = true;
            Diem_HP.Width = 125;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(tableLayoutPanel);
            panel2.Location = new Point(23, 587);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1536, 535);
            panel2.TabIndex = 5;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 6;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 149F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 189F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.Controls.Add(label2, 0, 0);
            tableLayoutPanel.Controls.Add(label3, 2, 0);
            tableLayoutPanel.Controls.Add(label4, 4, 0);
            tableLayoutPanel.Controls.Add(label5, 0, 1);
            tableLayoutPanel.Controls.Add(label6, 2, 1);
            tableLayoutPanel.Controls.Add(label7, 4, 1);
            tableLayoutPanel.Controls.Add(label8, 0, 2);
            tableLayoutPanel.Controls.Add(label9, 2, 2);
            tableLayoutPanel.Controls.Add(label10, 4, 2);
            tableLayoutPanel.Controls.Add(label11, 0, 3);
            tableLayoutPanel.Controls.Add(label13, 4, 3);
            tableLayoutPanel.Controls.Add(textBoxMaSV, 1, 0);
            tableLayoutPanel.Controls.Add(textBoxTenSV, 1, 1);
            tableLayoutPanel.Controls.Add(textBoxDiaChi, 3, 0);
            tableLayoutPanel.Controls.Add(textBoxSDT, 3, 1);
            tableLayoutPanel.Controls.Add(textBoxEmail, 3, 2);
            tableLayoutPanel.Controls.Add(textBoxDiemCC, 5, 0);
            tableLayoutPanel.Controls.Add(textBoxDiemTX, 5, 1);
            tableLayoutPanel.Controls.Add(textBoxDiemTHI, 5, 2);
            tableLayoutPanel.Controls.Add(textBoxDiemHP, 5, 3);
            tableLayoutPanel.Controls.Add(buttonXoa, 5, 4);
            tableLayoutPanel.Controls.Add(buttonSua, 4, 4);
            tableLayoutPanel.Controls.Add(dateTimePickerNgaySinh, 1, 2);
            tableLayoutPanel.Location = new Point(23, 27);
            tableLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 5;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000019F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000019F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel.Size = new Size(1490, 481);
            tableLayoutPanel.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 0;
            label2.Text = "Mã Sinh viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(498, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 28);
            label3.TabIndex = 1;
            label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(958, 0);
            label4.Name = "label4";
            label4.Size = new Size(164, 28);
            label4.TabIndex = 2;
            label4.Text = "Điểm chuyên cần:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(3, 96);
            label5.Name = "label5";
            label5.Size = new Size(100, 28);
            label5.TabIndex = 3;
            label5.Text = "Họ và tên:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(498, 96);
            label6.Name = "label6";
            label6.Size = new Size(51, 28);
            label6.TabIndex = 4;
            label6.Text = "SĐT:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(958, 96);
            label7.Name = "label7";
            label7.Size = new Size(133, 56);
            label7.TabIndex = 5;
            label7.Text = "Điểm thường xuyên:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(3, 192);
            label8.Name = "label8";
            label8.Size = new Size(103, 28);
            label8.TabIndex = 6;
            label8.Text = "Ngày sinh:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(498, 192);
            label9.Name = "label9";
            label9.Size = new Size(63, 28);
            label9.TabIndex = 7;
            label9.Text = "Email:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(958, 192);
            label10.Name = "label10";
            label10.Size = new Size(90, 28);
            label10.TabIndex = 8;
            label10.Text = "Điểm thi:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(3, 288);
            label11.Name = "label11";
            label11.Size = new Size(91, 28);
            label11.TabIndex = 9;
            label11.Text = "Giới tính:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(958, 288);
            label13.Name = "label13";
            label13.Size = new Size(148, 28);
            label13.TabIndex = 11;
            label13.Text = "Điểm học phần:";
            // 
            // textBoxMaSV
            // 
            textBoxMaSV.BorderStyle = BorderStyle.FixedSingle;
            textBoxMaSV.Dock = DockStyle.Fill;
            textBoxMaSV.Enabled = false;
            textBoxMaSV.Font = new Font("Segoe UI", 12F);
            textBoxMaSV.Location = new Point(152, 4);
            textBoxMaSV.Margin = new Padding(3, 4, 3, 4);
            textBoxMaSV.Name = "textBoxMaSV";
            textBoxMaSV.Size = new Size(340, 34);
            textBoxMaSV.TabIndex = 12;
            // 
            // textBoxTenSV
            // 
            textBoxTenSV.BorderStyle = BorderStyle.FixedSingle;
            textBoxTenSV.Dock = DockStyle.Fill;
            textBoxTenSV.Enabled = false;
            textBoxTenSV.Font = new Font("Segoe UI", 12F);
            textBoxTenSV.Location = new Point(152, 100);
            textBoxTenSV.Margin = new Padding(3, 4, 3, 4);
            textBoxTenSV.Name = "textBoxTenSV";
            textBoxTenSV.Size = new Size(340, 34);
            textBoxTenSV.TabIndex = 13;
            // 
            // textBoxDiaChi
            // 
            textBoxDiaChi.BorderStyle = BorderStyle.FixedSingle;
            textBoxDiaChi.Dock = DockStyle.Fill;
            textBoxDiaChi.Enabled = false;
            textBoxDiaChi.Font = new Font("Segoe UI", 12F);
            textBoxDiaChi.Location = new Point(612, 4);
            textBoxDiaChi.Margin = new Padding(3, 4, 3, 4);
            textBoxDiaChi.Name = "textBoxDiaChi";
            textBoxDiaChi.Size = new Size(340, 34);
            textBoxDiaChi.TabIndex = 14;
            // 
            // textBoxSDT
            // 
            textBoxSDT.BorderStyle = BorderStyle.FixedSingle;
            textBoxSDT.Dock = DockStyle.Fill;
            textBoxSDT.Enabled = false;
            textBoxSDT.Font = new Font("Segoe UI", 12F);
            textBoxSDT.Location = new Point(612, 100);
            textBoxSDT.Margin = new Padding(3, 4, 3, 4);
            textBoxSDT.Name = "textBoxSDT";
            textBoxSDT.Size = new Size(340, 34);
            textBoxSDT.TabIndex = 15;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Dock = DockStyle.Fill;
            textBoxEmail.Enabled = false;
            textBoxEmail.Font = new Font("Segoe UI", 12F);
            textBoxEmail.Location = new Point(612, 196);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(340, 34);
            textBoxEmail.TabIndex = 16;
            // 
            // textBoxDiemCC
            // 
            textBoxDiemCC.BorderStyle = BorderStyle.FixedSingle;
            textBoxDiemCC.Dock = DockStyle.Fill;
            textBoxDiemCC.Enabled = false;
            textBoxDiemCC.Font = new Font("Segoe UI", 12F);
            textBoxDiemCC.Location = new Point(1147, 4);
            textBoxDiemCC.Margin = new Padding(3, 4, 3, 4);
            textBoxDiemCC.Name = "textBoxDiemCC";
            textBoxDiemCC.Size = new Size(340, 34);
            textBoxDiemCC.TabIndex = 17;
            // 
            // textBoxDiemTX
            // 
            textBoxDiemTX.BorderStyle = BorderStyle.FixedSingle;
            textBoxDiemTX.Dock = DockStyle.Fill;
            textBoxDiemTX.Enabled = false;
            textBoxDiemTX.Font = new Font("Segoe UI", 12F);
            textBoxDiemTX.Location = new Point(1147, 100);
            textBoxDiemTX.Margin = new Padding(3, 4, 3, 4);
            textBoxDiemTX.Name = "textBoxDiemTX";
            textBoxDiemTX.Size = new Size(340, 34);
            textBoxDiemTX.TabIndex = 18;
            // 
            // textBoxDiemTHI
            // 
            textBoxDiemTHI.BorderStyle = BorderStyle.FixedSingle;
            textBoxDiemTHI.Dock = DockStyle.Fill;
            textBoxDiemTHI.Enabled = false;
            textBoxDiemTHI.Font = new Font("Segoe UI", 12F);
            textBoxDiemTHI.Location = new Point(1147, 196);
            textBoxDiemTHI.Margin = new Padding(3, 4, 3, 4);
            textBoxDiemTHI.Name = "textBoxDiemTHI";
            textBoxDiemTHI.Size = new Size(340, 34);
            textBoxDiemTHI.TabIndex = 19;
            // 
            // textBoxDiemHP
            // 
            textBoxDiemHP.BorderStyle = BorderStyle.FixedSingle;
            textBoxDiemHP.Dock = DockStyle.Fill;
            textBoxDiemHP.Enabled = false;
            textBoxDiemHP.Font = new Font("Segoe UI", 12F);
            textBoxDiemHP.Location = new Point(1147, 292);
            textBoxDiemHP.Margin = new Padding(3, 4, 3, 4);
            textBoxDiemHP.Name = "textBoxDiemHP";
            textBoxDiemHP.Size = new Size(340, 34);
            textBoxDiemHP.TabIndex = 20;
            // 
            // buttonXoa
            // 
            buttonXoa.Font = new Font("Segoe UI", 12F);
            buttonXoa.Location = new Point(1147, 388);
            buttonXoa.Margin = new Padding(3, 4, 3, 4);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(86, 40);
            buttonXoa.TabIndex = 21;
            buttonXoa.Text = "XÓA";
            buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonSua
            // 
            buttonSua.Font = new Font("Segoe UI", 12F);
            buttonSua.Location = new Point(958, 388);
            buttonSua.Margin = new Padding(3, 4, 3, 4);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(86, 40);
            buttonSua.TabIndex = 22;
            buttonSua.Text = "SỬA";
            buttonSua.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerNgaySinh
            // 
            dateTimePickerNgaySinh.Dock = DockStyle.Fill;
            dateTimePickerNgaySinh.Enabled = false;
            dateTimePickerNgaySinh.Font = new Font("Segoe UI", 12F);
            dateTimePickerNgaySinh.Location = new Point(152, 196);
            dateTimePickerNgaySinh.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            dateTimePickerNgaySinh.Size = new Size(340, 34);
            dateTimePickerNgaySinh.TabIndex = 23;
            // 
            // UserControlLopHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlLopHoc";
            Size = new Size(1582, 1148);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                textBoxMaSV.Text = row.Cells["MaSV"].Value?.ToString();
                textBoxTenSV.Text = row.Cells["TenSV"].Value?.ToString();
                textBoxDiaChi.Text = row.Cells["textBoxDiaChi"] != null ? row.Cells["textBoxDiaChi"].Value?.ToString() : "";
                textBoxSDT.Text = row.Cells["textBoxSDT"] != null ? row.Cells["textBoxSDT"].Value?.ToString() : "";
                textBoxEmail.Text = row.Cells["textBoxEmail"] != null ? row.Cells["textBoxEmail"].Value?.ToString() : "";
                textBoxDiemCC.Text = row.Cells["Diem_CC"].Value?.ToString();
                textBoxDiemTX.Text = row.Cells["Diem_TX"].Value?.ToString();
                textBoxDiemTHI.Text = row.Cells["Diem_THI"].Value?.ToString();
                textBoxDiemHP.Text = row.Cells["Diem_HP"].Value?.ToString();

                // Ngày sinh
                if (DateTime.TryParse(row.Cells["NgaySinh"].Value?.ToString(), out var ngaySinh))
                    dateTimePickerNgaySinh.Value = ngaySinh;
                else
                    dateTimePickerNgaySinh.Value = DateTime.Now;
            }
        }

        #endregion
        private Panel panel1;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private Label label1;
        public DataGridView dataGridView;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label13;
        private TextBox textBoxMaSV;
        private TextBox textBoxTenSV;
        private TextBox textBoxDiaChi;
        private TextBox textBoxSDT;
        private TextBox textBoxEmail;
        private TextBox textBoxDiemCC;
        private TextBox textBoxDiemTX;
        private TextBox textBoxDiemTHI;
        private TextBox textBoxDiemHP;
        private Button buttonXoa;
        private Button buttonSua;
        private DateTimePicker dateTimePickerNgaySinh;
        private Label label12;
        private ComboBox comboBoxLop;
        private DataGridViewTextBoxColumn LopHoc;
        private DataGridViewTextBoxColumn MaSV;
        private DataGridViewTextBoxColumn TenSV;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn Diem_CC;
        private DataGridViewTextBoxColumn Diem_TX;
        private DataGridViewTextBoxColumn Diem_THI;
        private DataGridViewTextBoxColumn Diem_HP;
    }
}
