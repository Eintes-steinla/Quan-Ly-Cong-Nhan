using System;
using System.Windows.Forms;

namespace QLCN
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        }

        private void mnuCongNhan_Click(object sender, EventArgs e)
        {
            FormCongNhan f = new FormCongNhan();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuChamCong_Click(object sender, EventArgs e)
        {
            FormChamCong f = new FormChamCong();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuNghiPhep_Click(object sender, EventArgs e)
        {
            FormNghiPhep f = new FormNghiPhep();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuTangCa_Click(object sender, EventArgs e)
        {
            FormTangCa f = new FormTangCa();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuCaLam_Click(object sender, EventArgs e)
        {
            FormCaLam f = new FormCaLam();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuPhanCa_Click(object sender, EventArgs e)
        {
            FormPhanCa f = new FormPhanCa();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuBaoCao_Click(object sender, EventArgs e)
        {
            FormBaoCao f = new FormBaoCao();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuUser_Click(object sender, EventArgs e)
        {
            FormUser f = new FormUser();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuSettings_Click(object sender, EventArgs e)
        {
            FormSettings f = new FormSettings();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuNhatKy_Click(object sender, EventArgs e)
        {
            FormNhatKyHeThong f = new FormNhatKyHeThong();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
