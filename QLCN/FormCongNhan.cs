using System;
using System.Windows.Forms;

namespace QLCN
{
    public partial class FormCongNhan : Form
    {
        public FormCongNhan()
        {
            InitializeComponent();
        }

        private void FormCongNhan_Load(object sender, EventArgs e)
        {
            // TODO: Load dữ liệu từ DB vào DataGridView
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // TODO: Code thêm công nhân
            MessageBox.Show("Đã thêm công nhân mới!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // TODO: Code sửa công nhân
            MessageBox.Show("Đã cập nhật thông tin công nhân!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // TODO: Code xóa công nhân
            MessageBox.Show("Đã xóa công nhân!");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // TODO: Refresh dữ liệu
            MessageBox.Show("Làm mới danh sách!");
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
