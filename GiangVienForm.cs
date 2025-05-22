namespace PMQLSVDH
{
    public partial class GiangVienForm : Form
    {
        private NavigationControl navigationControl;
        private NavigationButton navigationButton;
        private UserControlTrangChu trangChu;
        private UserControlLopHoc lopHoc;
        private UserControlCaiDat caiDat;

        private readonly Color btnDefaultColor = Color.FromKnownColor(KnownColor.ControlLight);
        private readonly Color btnSelectedColor = Color.FromKnownColor(KnownColor.ControlDark);
        public GiangVienForm()
        {
            InitializeComponent();
            InitializeNavigationButton();
            InitializeNavigationControl();
        }

        private void InitializeNavigationControl()
        {
            trangChu = new UserControlTrangChu();
            lopHoc = new UserControlLopHoc();
            caiDat = new UserControlCaiDat();
            var userControls = new List<UserControl> { trangChu, lopHoc, caiDat };
            navigationControl = new NavigationControl(userControls, panel);
            navigationControl.Display(0);
        }

        private void InitializeNavigationButton()
        {
            var buttons = new List<Button> { buttonTrangChu, buttonLopHoc, buttonCaiDat };
            navigationButton = new NavigationButton(buttons, btnDefaultColor, btnSelectedColor);
            navigationButton.Highlight(buttonTrangChu);
        }

        private void buttonTrangChu_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
            navigationButton.Highlight(buttonTrangChu);
        }

        private void buttonLopHoc_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
            navigationButton.Highlight(buttonLopHoc);
            DatabaseHelper.LoadDataGV("GV002", lopHoc.dataGridView);
        }

        private void buttonCaiDat_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
            navigationButton.Highlight(buttonCaiDat);
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }
    }
}
