using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLSVDH
{
    internal class NavigationControl
    {
        List<UserControl> userControls;
        Panel panel;

        public NavigationControl(List<UserControl> userControls, Panel panel)
        {
            this.userControls = userControls;
            this.panel = panel;
            AddUserControl();
        }

        private void AddUserControl()
        {
            foreach (UserControl userControl in userControls)
            {
                userControl.Dock = DockStyle.Fill;
                panel.Controls.Add(userControl);
            }
        }

        public void Display(int index)
        {
            if (index < userControls.Count())
            {
                userControls[index].BringToFront();
            }
        }
    }
}
