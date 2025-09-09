using System;
using System.Windows.Forms;

namespace QLCN
{
    public partial class FormPhanCa : UserControl
    {
        public FormPhanCa()
        {
            InitializeComponent();
        }

        private void FormPhanCa_Load(object sender, EventArgs e)
        {
            // TODO: Load công nhân vào cboCongNhan
            // TODO: Load ca làm vào cboCaLam
            // TODO: Load danh sách phân ca vào dgvPhanCa
            this.Dock = DockStyle.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // TODO: Thêm phân ca
            MessageBox.Show("Đã phân ca cho công nhân!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // TODO: Sửa phân ca
            MessageBox.Show("Đã sửa phân ca!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // TODO: Xóa phân ca
            MessageBox.Show("Đã xóa phân ca!");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // TODO: Làm mới danh sách
            MessageBox.Show("Đã làm mới danh sách phân ca!");
        }

        private void cboCongNhan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
