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
    public partial class UserControlLopHocAdmin : UserControl
    {
        public UserControlLopHocAdmin()
        {
            InitializeComponent();
        }

        private void buttonThemSV_Click(object sender, EventArgs e)
        {
            ThemSinhVienForm themSV = new ThemSinhVienForm();
            themSV.ShowDialog();
        }
    }
}
