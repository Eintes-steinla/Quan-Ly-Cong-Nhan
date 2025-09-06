using System;
using System.Windows.Forms;

namespace QLCN
{
    public partial class FormBaoCao : Form
    {
        public FormBaoCao()
        {
            InitializeComponent();
        }

        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            cboLoaiBaoCao.Items.Add("Báo cáo chấm công");
            cboLoaiBaoCao.Items.Add("Báo cáo tăng ca");
            cboLoaiBaoCao.Items.Add("Báo cáo nghỉ phép");
            cboLoaiBaoCao.Items.Add("Báo cáo phân ca");
            cboLoaiBaoCao.SelectedIndex = 0;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string loai = cboLoaiBaoCao.SelectedItem.ToString();
            DateTime tuNgay = dtpFrom.Value;
            DateTime denNgay = dtpTo.Value;

            // TODO: gọi đến database để lấy dữ liệu theo loại và khoảng thời gian
            MessageBox.Show($"Đang xem {loai} từ {tuNgay.ToShortDateString()} đến {denNgay.ToShortDateString()}");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // TODO: xuất dữ liệu từ dgvBaoCao ra Excel hoặc PDF
            MessageBox.Show("Xuất báo cáo thành công!");
        }
    }
}
