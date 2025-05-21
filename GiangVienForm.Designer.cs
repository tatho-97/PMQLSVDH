namespace PMQLSVDH
{
    partial class GiangVienForm
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
            panelMenu = new Panel();
            pictureBoxLogo = new PictureBox();
            buttonDangXuat = new Button();
            tableLayoutPanel = new TableLayoutPanel();
            buttonTrangChu = new Button();
            buttonLopHoc = new Button();
            buttonCaiDat = new Button();
            panel = new Panel();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.ControlDark;
            panelMenu.Controls.Add(pictureBoxLogo);
            panelMenu.Controls.Add(buttonDangXuat);
            panelMenu.Controls.Add(tableLayoutPanel);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 861);
            panelMenu.TabIndex = 0;
            panelMenu.TabStop = true;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = SystemColors.Control;
            pictureBoxLogo.Dock = DockStyle.Top;
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(200, 200);
            pictureBoxLogo.TabIndex = 2;
            pictureBoxLogo.TabStop = false;
            // 
            // buttonDangXuat
            // 
            buttonDangXuat.Dock = DockStyle.Bottom;
            buttonDangXuat.Location = new Point(0, 816);
            buttonDangXuat.Name = "buttonDangXuat";
            buttonDangXuat.Size = new Size(200, 45);
            buttonDangXuat.TabIndex = 1;
            buttonDangXuat.Text = "DangXuat";
            buttonDangXuat.UseVisualStyleBackColor = true;
            buttonDangXuat.Click += buttonDangXuat_Click;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel.Controls.Add(buttonTrangChu, 0, 0);
            tableLayoutPanel.Controls.Add(buttonLopHoc, 0, 1);
            tableLayoutPanel.Controls.Add(buttonCaiDat, 0, 2);
            tableLayoutPanel.Location = new Point(0, 200);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.Size = new Size(200, 200);
            tableLayoutPanel.TabIndex = 0;
            // 
            // buttonTrangChu
            // 
            buttonTrangChu.Dock = DockStyle.Fill;
            buttonTrangChu.Location = new Point(3, 3);
            buttonTrangChu.Name = "buttonTrangChu";
            buttonTrangChu.Size = new Size(194, 60);
            buttonTrangChu.TabIndex = 0;
            buttonTrangChu.Text = "TrangChu";
            buttonTrangChu.UseVisualStyleBackColor = true;
            buttonTrangChu.Click += buttonTrangChu_Click;
            // 
            // buttonLopHoc
            // 
            buttonLopHoc.Dock = DockStyle.Fill;
            buttonLopHoc.Location = new Point(3, 69);
            buttonLopHoc.Name = "buttonLopHoc";
            buttonLopHoc.Size = new Size(194, 60);
            buttonLopHoc.TabIndex = 1;
            buttonLopHoc.Text = "LopHoc";
            buttonLopHoc.UseVisualStyleBackColor = true;
            buttonLopHoc.Click += buttonLopHoc_Click;
            // 
            // buttonCaiDat
            // 
            buttonCaiDat.Dock = DockStyle.Fill;
            buttonCaiDat.Location = new Point(3, 135);
            buttonCaiDat.Name = "buttonCaiDat";
            buttonCaiDat.Size = new Size(194, 62);
            buttonCaiDat.TabIndex = 2;
            buttonCaiDat.Text = "CaiDat";
            buttonCaiDat.UseVisualStyleBackColor = true;
            buttonCaiDat.Click += buttonCaiDat_Click;
            // 
            // panel
            // 
            panel.BackColor = SystemColors.ControlLight;
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(200, 0);
            panel.Name = "panel";
            panel.Size = new Size(1384, 861);
            panel.TabIndex = 1;
            // 
            // GiangVienForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 861);
            Controls.Add(panel);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "GiangVienForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PMQLSV";
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            tableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private TableLayoutPanel tableLayoutPanel;
        private Button buttonTrangChu;
        private Button buttonLopHoc;
        private Panel panel;
        private Button buttonDangXuat;
        private Button buttonCaiDat;
        private PictureBox pictureBoxLogo;
    }
}
