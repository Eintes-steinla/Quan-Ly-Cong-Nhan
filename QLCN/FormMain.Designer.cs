namespace QLCN
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip;
        private ToolStripMenuItem mnuCongNhan, mnuUser, mnuSettings, mnuNhatKy, mnuExit, mnuBaoCao;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            mnuCongNhan = new ToolStripMenuItem();
            mnuChamCongQR = new ToolStripMenuItem();
            mnuQLCN = new ToolStripMenuItem();
            mnuChamCongDropDown = new ToolStripMenuItem();
            mnuNghiPhepDropDown = new ToolStripMenuItem();
            mnuTangCaDropDown = new ToolStripMenuItem();
            mnuPhanCaDropDown = new ToolStripMenuItem();
            mnuProfile = new ToolStripMenuItem();
            mnuBaoCao = new ToolStripMenuItem();
            mnuUser = new ToolStripMenuItem();
            mnuSettings = new ToolStripMenuItem();
            mnuNhatKy = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { mnuCongNhan, mnuChamCongQR, mnuQLCN, mnuProfile, mnuBaoCao, mnuUser, mnuSettings, mnuNhatKy, mnuExit });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1221, 33);
            menuStrip.TabIndex = 0;
            menuStrip.ItemClicked += menuStrip1_ItemClicked;
            // 
            // mnuCongNhan
            // 
            mnuCongNhan.Image = Properties.Resources.icons8_people_3d_fluency_32;
            mnuCongNhan.Name = "mnuCongNhan";
            mnuCongNhan.Size = new Size(139, 29);
            mnuCongNhan.Text = "Công nhân";
            mnuCongNhan.ToolTipText = "Công Nhân";
            mnuCongNhan.Click += mnuCongNhan_Click;
            // 
            // mnuChamCongQR
            // 
            mnuChamCongQR.Image = Properties.Resources.icons8_qr_321;
            mnuChamCongQR.Name = "mnuChamCongQR";
            mnuChamCongQR.Size = new Size(173, 29);
            mnuChamCongQR.Text = "Chấm công QR";
            mnuChamCongQR.Click += mnuChamCongQR_Click;
            // 
            // mnuQLCN
            // 
            mnuQLCN.DropDownItems.AddRange(new ToolStripItem[] { mnuChamCongDropDown, mnuNghiPhepDropDown, mnuTangCaDropDown, mnuPhanCaDropDown });
            mnuQLCN.Image = Properties.Resources.icons8_defend_family_32;
            mnuQLCN.Name = "mnuQLCN";
            mnuQLCN.Size = new Size(97, 29);
            mnuQLCN.Text = "QLCN";
            // 
            // mnuChamCongDropDown
            // 
            mnuChamCongDropDown.Image = Properties.Resources.icons8_stopwatch_32;
            mnuChamCongDropDown.Name = "mnuChamCongDropDown";
            mnuChamCongDropDown.Size = new Size(205, 34);
            mnuChamCongDropDown.Text = "Chấm công";
            mnuChamCongDropDown.Click += mnuChamCongDropDown_Click;
            // 
            // mnuNghiPhepDropDown
            // 
            mnuNghiPhepDropDown.Image = Properties.Resources.icons8_hotel_bed_32;
            mnuNghiPhepDropDown.Name = "mnuNghiPhepDropDown";
            mnuNghiPhepDropDown.Size = new Size(205, 34);
            mnuNghiPhepDropDown.Text = "Nghỉ phép";
            mnuNghiPhepDropDown.Click += mnuNghiPhepDropDown_Click;
            // 
            // mnuTangCaDropDown
            // 
            mnuTangCaDropDown.Image = Properties.Resources.icons8_countdown_clock_32;
            mnuTangCaDropDown.Name = "mnuTangCaDropDown";
            mnuTangCaDropDown.Size = new Size(205, 34);
            mnuTangCaDropDown.Text = "Tăng ca";
            mnuTangCaDropDown.Click += mnuTangCaDropDown_Click;
            // 
            // mnuPhanCaDropDown
            // 
            mnuPhanCaDropDown.Image = Properties.Resources.icons8_time_321;
            mnuPhanCaDropDown.Name = "mnuPhanCaDropDown";
            mnuPhanCaDropDown.Size = new Size(205, 34);
            mnuPhanCaDropDown.Text = "Phân ca";
            mnuPhanCaDropDown.Click += mnuPhanCaDropDown_Click;
            // 
            // mnuProfile
            // 
            mnuProfile.Image = Properties.Resources.icons8_user_menu_male_32;
            mnuProfile.Name = "mnuProfile";
            mnuProfile.Size = new Size(102, 29);
            mnuProfile.Text = "Hồ Sơ";
            mnuProfile.Click += mnuProfile_Click;
            // 
            // mnuBaoCao
            // 
            mnuBaoCao.Image = Properties.Resources.icons8_report_32;
            mnuBaoCao.Name = "mnuBaoCao";
            mnuBaoCao.Size = new Size(115, 29);
            mnuBaoCao.Text = "Báo cáo";
            mnuBaoCao.Click += mnuBaoCao_Click;
            // 
            // mnuUser
            // 
            mnuUser.Image = Properties.Resources.icons8_user_32;
            mnuUser.Name = "mnuUser";
            mnuUser.Size = new Size(149, 29);
            mnuUser.Text = "Người dùng";
            mnuUser.Click += mnuUser_Click;
            // 
            // mnuSettings
            // 
            mnuSettings.Image = Properties.Resources.icons8_setting_undefined_32;
            mnuSettings.Name = "mnuSettings";
            mnuSettings.Size = new Size(107, 29);
            mnuSettings.Text = "Cài đặt";
            mnuSettings.Click += mnuSettings_Click;
            // 
            // mnuNhatKy
            // 
            mnuNhatKy.Image = Properties.Resources.icons8_copybook_32;
            mnuNhatKy.Name = "mnuNhatKy";
            mnuNhatKy.Size = new Size(190, 29);
            mnuNhatKy.Text = "Nhật ký hệ thống";
            mnuNhatKy.Click += mnuNhatKy_Click;
            // 
            // mnuExit
            // 
            mnuExit.Image = Properties.Resources.icons8_exit_32;
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(97, 29);
            mnuExit.Text = "Thoát";
            mnuExit.Click += mnuExit_Click;
            // 
            // FormMain
            // 
            ClientSize = new Size(1221, 600);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý công nhân";
            Load += FormMain_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        private ToolStripMenuItem mnuProfile;
        private ToolStripMenuItem mnuQLCN;
        private ToolStripMenuItem mnuChamCongDropDown;
        private ToolStripMenuItem mnuNghiPhepDropDown;
        private ToolStripMenuItem mnuTangCaDropDown;
        private ToolStripMenuItem mnuPhanCaDropDown;
        private ToolStripMenuItem mnuChamCongQR;
    }
}
