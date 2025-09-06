using System;
using System.Windows.Forms;

namespace QLCN
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            // TODO: Load cài đặt hiện tại từ file config hoặc DB
            txtCompanyName.Text = "Công ty ABC";
            txtAddress.Text = "123 Đường A, Quận B, TP.HCM";
            txtPhone.Text = "0123456789";

            txtServer.Text = ".\\SQLEXPRESS";
            txtDatabase.Text = "QLCN";
            txtDbUser.Text = "sa";
            txtDbPassword.Text = "123";

            cboLanguage.SelectedIndex = 0; // mặc định Tiếng Việt
            cboTheme.SelectedIndex = 0;    // mặc định Sáng
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // TODO: Lưu cài đặt vào file config hoặc DB
            MessageBox.Show("Đã lưu cài đặt hệ thống!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
