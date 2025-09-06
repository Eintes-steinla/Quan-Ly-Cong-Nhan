using System;
using System.Windows.Forms;

namespace QLCN
{
    public partial class FormCaLam : Form
    {
        public FormCaLam()
        {
            InitializeComponent();
        }

        private void FormCaLam_Load(object sender, EventArgs e)
        {
            // TODO: Load danh sách ca làm từ DB
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // TODO: Thêm ca làm
            MessageBox.Show("Đã thêm ca làm!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // TODO: Sửa ca làm
            MessageBox.Show("Đã sửa ca làm!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // TODO: Xóa ca làm
            MessageBox.Show("Đã xóa ca làm!");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // TODO: Làm mới danh sách
            MessageBox.Show("Đã làm mới danh sách ca làm!");
        }

        private void txtTenCa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
