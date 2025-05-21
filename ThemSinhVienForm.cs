using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMQLSVDH
{
    public partial class ThemSinhVienForm : Form
    {
        public ThemSinhVienForm()
        {
            InitializeComponent();
        }

        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            // Corrected the MessageBox usage to use MessageBox.Show method
            DialogResult result = MessageBox.Show("Xác nhận thêm Sinh Viên vào?????", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // TaTho
            }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
