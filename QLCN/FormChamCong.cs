using System;
using System.Windows.Forms;

namespace QLCN
{
    public partial class FormChamCong : Form
    {
        public FormChamCong()
        {
            InitializeComponent();
        }

        private void FormChamCong_Load(object sender, EventArgs e)
        {
            // TODO: Load dữ liệu chấm công từ DB vào DataGridView
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // TODO: Thêm bản ghi chấm công
            MessageBox.Show("Đã thêm chấm công!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // TODO: Sửa thông tin chấm công
            MessageBox.Show("Đã sửa chấm công!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // TODO: Xóa bản ghi chấm công
            MessageBox.Show("Đã xóa chấm công!");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // TODO: Làm mới dữ liệu
            MessageBox.Show("Đã làm mới danh sách chấm công!");
        }

        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
