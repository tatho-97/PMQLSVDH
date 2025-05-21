namespace PMQLSVDH
{
    partial class UserControlLopHocAdmin
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
            buttonThem = new Button();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            label1 = new Label();
            dataGridView = new DataGridView();
            panel2 = new Panel();
            buttonThemMH = new Button();
            buttonThemSV = new Button();
            dataGridViewSinhVien = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dataGridViewMonHoc = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSinhVien).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMonHoc).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(buttonThem);
            panel1.Controls.Add(buttonSearch);
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView);
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(1344, 400);
            panel1.TabIndex = 1;
            // 
            // buttonThem
            // 
            buttonThem.Font = new Font("Segoe UI", 12F);
            buttonThem.Location = new Point(1250, 10);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(75, 30);
            buttonThem.TabIndex = 4;
            buttonThem.Text = "THÊM";
            buttonThem.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Segoe UI", 12F);
            buttonSearch.Location = new Point(170, 120);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(100, 30);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "TIMKIEM";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.Font = new Font("Segoe UI", 12F);
            textBoxSearch.Location = new Point(40, 80);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(230, 29);
            textBoxSearch.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(40, 50);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 1;
            label1.Text = "Tìm kiếm:";
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(300, 50);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(1024, 330);
            dataGridView.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(buttonThemMH);
            panel2.Controls.Add(buttonThemSV);
            panel2.Controls.Add(dataGridViewSinhVien);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(dataGridViewMonHoc);
            panel2.Font = new Font("Segoe UI", 12F);
            panel2.Location = new Point(20, 440);
            panel2.Name = "panel2";
            panel2.Size = new Size(1344, 400);
            panel2.TabIndex = 2;
            // 
            // buttonThemMH
            // 
            buttonThemMH.Font = new Font("Segoe UI", 12F);
            buttonThemMH.Location = new Point(1249, 10);
            buttonThemMH.Name = "buttonThemMH";
            buttonThemMH.Size = new Size(75, 30);
            buttonThemMH.TabIndex = 6;
            buttonThemMH.Text = "THÊM";
            buttonThemMH.UseVisualStyleBackColor = true;
            // 
            // buttonThemSV
            // 
            buttonThemSV.Font = new Font("Segoe UI", 12F);
            buttonThemSV.Location = new Point(780, 10);
            buttonThemSV.Name = "buttonThemSV";
            buttonThemSV.Size = new Size(75, 30);
            buttonThemSV.TabIndex = 5;
            buttonThemSV.Text = "THÊM";
            buttonThemSV.UseVisualStyleBackColor = true;
            buttonThemSV.Click += buttonThemSV_Click;
            // 
            // dataGridViewSinhVien
            // 
            dataGridViewSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSinhVien.Location = new Point(405, 50);
            dataGridViewSinhVien.Name = "dataGridViewSinhVien";
            dataGridViewSinhVien.Size = new Size(450, 330);
            dataGridViewSinhVien.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox3, 1, 2);
            tableLayoutPanel1.Location = new Point(20, 20);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(340, 288);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 0;
            label2.Text = "Mã Lớp:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 96);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 1;
            label3.Text = "Tên Lớp:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(3, 192);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 2;
            label4.Text = "Khóa học:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(103, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 29);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Dock = DockStyle.Fill;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(103, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(234, 29);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Dock = DockStyle.Fill;
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(103, 195);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(234, 29);
            textBox3.TabIndex = 5;
            // 
            // dataGridViewMonHoc
            // 
            dataGridViewMonHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMonHoc.Location = new Point(875, 50);
            dataGridViewMonHoc.Name = "dataGridViewMonHoc";
            dataGridViewMonHoc.Size = new Size(450, 330);
            dataGridViewMonHoc.TabIndex = 0;
            // 
            // UserControlLopHocAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserControlLopHocAdmin";
            Size = new Size(1384, 861);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSinhVien).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMonHoc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonThem;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private Label label1;
        private DataGridView dataGridView;
        private Panel panel2;
        private DataGridView dataGridViewMonHoc;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DataGridView dataGridViewSinhVien;
        private Button buttonThemMH;
        private Button buttonThemSV;
    }
}
