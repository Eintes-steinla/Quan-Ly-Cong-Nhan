using System;
using System.Windows.Forms;

namespace QLCN
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            cboRole.Items.Add("Admin");
            cboRole.Items.Add("Quản lý");
            cboRole.Items.Add("Nhân viên");
            cboRole.SelectedIndex = 0;

            // TODO: Load danh sách user từ database vào dgvUser
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // TODO: Thêm user
            MessageBox.Show("Đã thêm user!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // TODO: Sửa user
            MessageBox.Show("Đã sửa user!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // TODO: Xóa user
            MessageBox.Show("Đã xóa user!");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // TODO: Làm mới danh sách
            MessageBox.Show("Đã làm mới danh sách!");
        }
    }
}
