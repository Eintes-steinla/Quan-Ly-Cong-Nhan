using System;
using System.Data;
using System.Windows.Forms;

namespace QLCN
{
    public partial class FormNhatKyHeThong : Form
    {
        public FormNhatKyHeThong()
        {
            InitializeComponent();
        }

        private void FormNhatKyHeThong_Load(object sender, EventArgs e)
        {
            LoadLogs();
        }

        private void LoadLogs()
        {
            // TODO: Lấy dữ liệu từ DB, ví dụ: SELECT * FROM NhatKy ORDER BY ThoiGian DESC
            DataTable dt = new DataTable();
            dt.Columns.Add("Thời gian");
            dt.Columns.Add("Người dùng");
            dt.Columns.Add("Hành động");
            dt.Columns.Add("Chi tiết");

            // Dữ liệu demo
            dt.Rows.Add(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), "admin", "Đăng nhập", "Thành công");
            dt.Rows.Add(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), "user01", "Thêm công nhân", "Mã CN: CN001");

            dgvLogs.DataSource = dt;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadLogs();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng xuất file Excel đang phát triển...");
        }

        private void txtFilterUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
