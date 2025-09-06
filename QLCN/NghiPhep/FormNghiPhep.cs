using System;
using System.Windows.Forms;

namespace QLCN
{
    public partial class FormNghiPhep : Form
    {
        public FormNghiPhep()
        {
            InitializeComponent();
        }

        private void FormNghiPhep_Load(object sender, EventArgs e)
        {
            // TODO: Load dữ liệu từ DB vào DataGridView
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // TODO: Thêm đơn nghỉ phép
            MessageBox.Show("Đã thêm đơn nghỉ phép!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // TODO: Sửa đơn nghỉ phép
            MessageBox.Show("Đã sửa đơn nghỉ phép!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // TODO: Xóa đơn nghỉ phép
            MessageBox.Show("Đã xóa đơn nghỉ phép!");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // TODO: Làm mới danh sách
            MessageBox.Show("Đã làm mới danh sách nghỉ phép!");
        }

        private void txtLyDo_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
