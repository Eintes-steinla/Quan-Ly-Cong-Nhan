using System;
using System.Windows.Forms;

namespace QLCN
{
    public partial class FormRole : Form
    {
        public FormRole()
        {
            InitializeComponent();
        }

        private void FormRole_Load(object sender, EventArgs e)
        {
            // TODO: Load danh sách vai trò từ DB vào dgvRole
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // TODO: Thêm vai trò
            MessageBox.Show("Đã thêm vai trò!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // TODO: Sửa vai trò
            MessageBox.Show("Đã sửa vai trò!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // TODO: Xóa vai trò
            MessageBox.Show("Đã xóa vai trò!");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // TODO: Làm mới danh sách
            MessageBox.Show("Đã làm mới danh sách vai trò!");
        }

        private void txtRoleName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
