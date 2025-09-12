using System;
using System.Windows.Forms;

namespace QLCN
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            congTrinhControl.CongTrinhSelected += (maCT) =>
    {
        tabControl.SelectedTab = congNhan;
        congNhanControl.SetCongTrinh(maCT);
    };
            congTrinhControl.CongTrinhMoi += (s, e) =>
            {
                congNhanControl.LoadCongTrinh();
                congNhanControl.cboTenCongTrinh.Text = string.Empty;
            };
        }
    }
}
