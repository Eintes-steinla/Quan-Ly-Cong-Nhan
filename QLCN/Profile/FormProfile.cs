using System;
using System.Windows.Forms;

namespace QLCN
{
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // TODO: Code cập nhật thông tin vào DB
            MessageBox.Show("Thông tin đã được lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCCCD_Click(object sender, EventArgs e)
        {

        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
