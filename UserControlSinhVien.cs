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
    public partial class UserControlSinhVien : UserControl
    {
        public UserControlSinhVien()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            ThemSinhVienForm themSV = new ThemSinhVienForm();
            themSV.ShowDialog();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            buttonSua.Visible = false;
            buttonXoa.Visible = false;
            buttonHuy.Visible = true;
            buttonXacNhan.Visible = true;
            textBoxMaSV.Enabled = true;
            textBoxTenSV.Enabled = true;
            dateTimePickerNgaySinh.Enabled = true;
            textBoxDiaChi.Enabled = true;
            textBoxSDT.Enabled = true;
            textBoxEmail.Enabled = true;
            comboBoxLop.Enabled = true;
            textBoxDiemCC.Enabled = true;
            textBoxDiemTX.Enabled = true;
            textBoxDiemTHI.Enabled = true;
            
        }
    }
}
