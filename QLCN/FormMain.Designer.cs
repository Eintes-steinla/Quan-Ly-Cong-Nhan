namespace QLCN
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuCongNhan, mnuChamCong, mnuNghiPhep, mnuTangCa;
        private ToolStripMenuItem mnuCaLam, mnuPhanCa, mnuBaoCao;
        private ToolStripMenuItem mnuUser, mnuSettings, mnuNhatKy, mnuExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mnuCongNhan = new ToolStripMenuItem();
            mnuChamCong = new ToolStripMenuItem();
            mnuNghiPhep = new ToolStripMenuItem();
            mnuTangCa = new ToolStripMenuItem();
            mnuCaLam = new ToolStripMenuItem();
            mnuPhanCa = new ToolStripMenuItem();
            mnuProfile = new ToolStripMenuItem();
            mnuBaoCao = new ToolStripMenuItem();
            mnuUser = new ToolStripMenuItem();
            mnuSettings = new ToolStripMenuItem();
            mnuNhatKy = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuCongNhan, mnuChamCong, mnuNghiPhep, mnuTangCa, mnuCaLam, mnuPhanCa, mnuProfile, mnuBaoCao, mnuUser, mnuSettings, mnuNhatKy, mnuExit });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1227, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // mnuCongNhan
            // 
            mnuCongNhan.Name = "mnuCongNhan";
            mnuCongNhan.Size = new Size(115, 29);
            mnuCongNhan.Text = "Công nhân";
            mnuCongNhan.Click += mnuCongNhan_Click;
            // 
            // mnuChamCong
            // 
            mnuChamCong.Name = "mnuChamCong";
            mnuChamCong.Size = new Size(119, 29);
            mnuChamCong.Text = "Chấm công";
            mnuChamCong.Click += mnuChamCong_Click;
            // 
            // mnuNghiPhep
            // 
            mnuNghiPhep.Name = "mnuNghiPhep";
            mnuNghiPhep.Size = new Size(112, 29);
            mnuNghiPhep.Text = "Nghỉ phép";
            mnuNghiPhep.Click += mnuNghiPhep_Click;
            // 
            // mnuTangCa
            // 
            mnuTangCa.Name = "mnuTangCa";
            mnuTangCa.Size = new Size(87, 29);
            mnuTangCa.Text = "Tăng ca";
            mnuTangCa.Click += mnuTangCa_Click;
            // 
            // mnuCaLam
            // 
            mnuCaLam.Name = "mnuCaLam";
            mnuCaLam.Size = new Size(82, 29);
            mnuCaLam.Text = "Ca làm";
            mnuCaLam.Click += mnuCaLam_Click;
            // 
            // mnuPhanCa
            // 
            mnuPhanCa.Name = "mnuPhanCa";
            mnuPhanCa.Size = new Size(89, 29);
            mnuPhanCa.Text = "Phân ca";
            mnuPhanCa.Click += mnuPhanCa_Click;
            // 
            // mnuProfile
            // 
            mnuProfile.Name = "mnuProfile";
            mnuProfile.Size = new Size(78, 29);
            mnuProfile.Text = "Hồ Sơ";
            mnuProfile.Click += mnuProfile_Click;
            // 
            // mnuBaoCao
            // 
            mnuBaoCao.Name = "mnuBaoCao";
            mnuBaoCao.Size = new Size(91, 29);
            mnuBaoCao.Text = "Báo cáo";
            mnuBaoCao.Click += mnuBaoCao_Click;
            // 
            // mnuUser
            // 
            mnuUser.Name = "mnuUser";
            mnuUser.Size = new Size(125, 29);
            mnuUser.Text = "Người dùng";
            mnuUser.Click += mnuUser_Click;
            // 
            // mnuSettings
            // 
            mnuSettings.Name = "mnuSettings";
            mnuSettings.Size = new Size(83, 29);
            mnuSettings.Text = "Cài đặt";
            mnuSettings.Click += mnuSettings_Click;
            // 
            // mnuNhatKy
            // 
            mnuNhatKy.Name = "mnuNhatKy";
            mnuNhatKy.Size = new Size(166, 29);
            mnuNhatKy.Text = "Nhật ký hệ thống";
            mnuNhatKy.Click += mnuNhatKy_Click;
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(73, 29);
            mnuExit.Text = "Thoát";
            mnuExit.Click += mnuExit_Click;
            // 
            // FormMain
            // 
            ClientSize = new Size(1227, 600);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý công nhân";
            Load += FormMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        private ToolStripMenuItem mnuProfile;
    }
}
