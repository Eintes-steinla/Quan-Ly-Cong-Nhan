using System;
using System.Windows.Forms;

namespace QLCN
{
    public partial class FormTangCa : Form
    {
        public FormTangCa()
        {
            InitializeComponent();
        }

        private void FormTangCa_Load(object sender, EventArgs e)
        {
            // TODO: Load dữ liệu từ DB vào DataGridView
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // TODO: Thêm dữ liệu tăng ca
            MessageBox.Show("Đã thêm tăng ca!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // TODO: Sửa dữ liệu tăng ca
            MessageBox.Show("Đã sửa tăng ca!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // TODO: Xóa dữ liệu tăng ca
            MessageBox.Show("Đã xóa tăng ca!");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // TODO: Làm mới danh sách
            MessageBox.Show("Đã làm mới danh sách tăng ca!");
        }
    }
}
