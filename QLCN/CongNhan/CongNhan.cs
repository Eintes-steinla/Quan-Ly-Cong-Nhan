using ClosedXML.Excel;
using Microsoft.Data.SqlClient;
using QLCN.DB;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Xceed.Words.NET;

namespace QLCN.CongNhan
{
    public partial class CongNhan : UserControl
    {
        public CongNhan()
        {
            InitializeComponent();
            Event();
        }

        private void Event()
        {
            txtCCCD.KeyPress += (s, e) =>
            {
                // Chỉ cho phép nhập số và phím điều khiển (như Backspace)
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true; // Ngăn chặn ký tự không hợp lệ
            };
            txtSDT.KeyPress += (s, e) =>
            {
                // Chỉ cho phép nhập số và phím điều khiển (như Backspace)
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true; // Ngăn chặn ký tự không hợp lệ
            };
        }

        public void TimeIntervalMessage()
        {
            System.Windows.Forms.Timer timer = new()
            {
                Interval = 7000,
            };
            timer.Tick += (s, args) =>
               {
                   lblMessage.Text = "";
                   timer.Stop();
                   timer.Dispose();
               };
            timer.Start();
        }

        private bool CheckRequiredFields()
        {
            // Kiểm tra mã công nhân không được bỏ trống
            if (string.IsNullOrWhiteSpace(txtMaCN.Text))
            {
                lblMessage.Text = "Vui lòng nhập mã công trình!";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
                txtMaCN.Focus();
                return true;
            }

            // Kiểm tra tên công nhân không được bỏ trống
            if (string.IsNullOrWhiteSpace(txtTenCN.Text))
            {
                lblMessage.Text = "Vui lòng nhập tên công trình!";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
                txtTenCN.Focus();
                return true;
            }

            if (cboXaPhuong.SelectedIndex == -1)
            {
                lblMessage.Text = "Vui lòng chọn địa chỉ!";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
                cboXaPhuong.Focus();
                return true;
            }
            // Kiểm tra giới tính không được bỏ trống
            if (cboGioiTinh.SelectedIndex == -1)
            {
                lblMessage.Text = "Vui lòng chọn tình trạng công trình!";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
                cboGioiTinh.Focus();
                return true;
            }

            // Kiểm tra số điện thoại không được bỏ trống
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                lblMessage.Text = "Vui lòng nhập số điện thoại!";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
                txtSDT.Focus();
                return true;
            }

            // Kiểm tra định dạng số điện thoại
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtSDT.Text, @"^(0|\+84)(3[2-9]|5[6|8|9]|7[0|6-9]|8[1-5]|9[0-4|6-9])[0-9]{7}$"))
            {
                lblMessage.Text = "Định dạng số điện thoại không hợp lệ!";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
                txtSDT.Focus();
                return true;
            }

            // Kiểm tra số CMND/CCCD không được bỏ trống
            if (string.IsNullOrWhiteSpace(txtCCCD.Text))
            {
                lblMessage.Text = "Vui lòng nhập CMND/CCCD!";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
                txtCCCD.Focus();
                return true;
            }

            // Kiểm tra định dạng CMND/CCCD
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCCCD.Text, @"^(\d{9}|\d{12})$"))
            {
                lblMessage.Text = "Định dạng CMND/CCCD không hợp lệ!";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
                txtCCCD.Focus();
                return true;
            }

            if (!dtpNgaySinh.Checked)
            {
                lblMessage.Text = "Vui lòng chọn ngày sinh!";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
                dtpNgaySinh.Focus();
                return true;
            }

            // Kiểm tra công nhân phải từ 18 tuổi trở lên
            if (dtpNgaySinh.Value > DateTime.Now.AddYears(-18))
            {
                lblMessage.Text = "Công nhân phải từ 18 tuổi trở lên!";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
                dtpNgaySinh.Focus();
                return true;
            }

            return false;
        }

        private DataTable congNhanData;
        private string query;

        private void LoadCongNhan()
        {
            try
            {
                using SqlConnection connection = DatabaseHelper.GetConnection();
                connection.Open();
                query = @"SELECT cn.macn MaCN, HoTen as TenCN, LTRIM(RTRIM(RIGHT(HoTen, CHARINDEX(' ', REVERSE(HoTen) + ' ') - 1))) AS Ten, LTRIM(RTRIM(LEFT(HoTen, CHARINDEX(' ', HoTen + ' ') - 1))) AS Ho, LTRIM(RTRIM(SUBSTRING(HoTen,CHARINDEX(' ', HoTen + ' ') + 1,LEN(HoTen)- CHARINDEX(' ', HoTen + ' ')- CHARINDEX(' ', REVERSE(HoTen) + ' ')))) AS TenDem, GioiTinh, NgaySinh, SDT, CCCD, trim(iif(MoTaChiTiet is null, '', motachitiet + ', ') + TenXP + ', ' + TenQH + ', ' + TenTinh) as DiaChi, TenCT, cn.ghichu GhiChu
                    FROM congnhan cn
					join DiaChiCongNhan dc on dc.MaCN = cn.MaCN
					join xaphuong xp on xp.MaXP = dc.maxp
					join quanhuyen qh on qh.maqh = xp.maqh
					join tinh t on t.matinh = qh.matinh
					join congtrinh ct on ct.mact = cn.mact
                    ORDER BY Ten, TenDem, Ho";

                using SqlCommand command = new(query, connection);

                // Sử dụng SqlDataAdapter để lấy dữ liệu
                SqlDataAdapter adapter = new(command);

                // Tạo DataTable để lưu trữ dữ liệu
                congNhanData = new();

                // Đổ dữ liệu vào DataTable
                adapter.Fill(congNhanData);

                // Thêm cột STT
                if (!congNhanData.Columns.Contains("STT"))
                {
                    DataColumn sttColumn = new("STT", typeof(int));
                    congNhanData.Columns.Add(sttColumn);
                }

                // Đánh số STT
                int rowNumber = congNhanData.Rows.Count;
                for (int i = 0; i < rowNumber; i++)
                    congNhanData.Rows[i]["STT"] = i + 1;

                // Sắp xếp lại thứ tự cột
                if (congNhanData.Columns.Contains("STT"))
                    congNhanData.Columns?["STT"]?.SetOrdinal(0);
                // Gán DataSource
                dgvConstruction.DataSource = congNhanData;
            }
            catch (Exception ex)
            {
                lblMessage.Text = $"Lỗi khi tải dữ liệu: {ex.Message}";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
            }

            LoadcboTinh();
            LoadCongTrinh();
            dtpNgaySinh.Checked = false;
            // dtpFilterNgayBatDau.Checked = false;
            // dtpFilterNgayKetThuc.Checked = false;
            // cboFilterTinhTrang.SelectedIndex = 0;
            // cboFilterDuToan.SelectedIndex = 0;

        }

        private void cboTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTinh.SelectedValue != null && int.TryParse(cboTinh.SelectedValue.ToString(), out int maTinh))
                LoadcboHuyen(maTinh);
        }

        private void LoadcboHuyen(int maTinh)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    query = "SELECT MaQH, TenQH FROM QuanHuyen WHERE MaTinh = @MaTinh";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@MaTinh", SqlDbType.Int).Value = maTinh;
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboQuanHuyen.DataSource = dt;
                    cboQuanHuyen.DisplayMember = "TenQH";
                    cboQuanHuyen.ValueMember = "MaQH";
                    cboQuanHuyen.SelectedIndex = -1;

                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = $"Lỗi khi tải dữ liệu: {ex.Message}";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
            }
        }

        private void LoadcboTinh()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    query = "SELECT MaTinh, TenTinh FROM Tinh";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cboTinh.DataSource = dt;
                    cboTinh.DisplayMember = "TenTinh";
                    cboTinh.ValueMember = "MaTinh";
                    cboTinh.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = $"Lỗi khi tải dữ liệu: {ex.Message}";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
            }
        }

        private void LoadcboXa(int maHuyen)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT MaXP, TenXP FROM XaPhuong WHERE MaQH = @MaHuyen";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@MaHuyen", SqlDbType.Int).Value = maHuyen;

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboXaPhuong.DataSource = dt;
                    cboXaPhuong.DisplayMember = "TenXP";
                    cboXaPhuong.ValueMember = "MaXP";
                    cboXaPhuong.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load Xã: " + ex.Message);
            }
        }

        private void cboQuanHuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboQuanHuyen.SelectedValue != null && int.TryParse(cboQuanHuyen.SelectedValue.ToString(), out int maHuyen))
                LoadcboXa(maHuyen);
        }

        private void CongNhan_Load(object? sender, EventArgs e) => LoadCongNhan();

        private void LoadCongTrinh()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT mact, tenct FROM congtrinh";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboTenCongTrinh.DataSource = dt;
                    cboTenCongTrinh.DisplayMember = "tenct";
                    cboTenCongTrinh.ValueMember = "mact";
                    cboTenCongTrinh.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnXemHD_Click(object sender, EventArgs e)
        {
            try
            {
                string tenCN = txtTenCN.Text.Trim();
                string ngaySinh = dtpNgaySinh.Text.Trim();
                string diaChi = cboXaPhuong.Text.Trim() + ", " + cboQuanHuyen.Text.Trim() + ", " + cboQuanHuyen.Text.Trim();
                string sdt = txtSDT.Text.Trim();
                string CCCD = txtCCCD.Text.Trim();
                //loaiHD // lay tu csdl
                string diaDiemLamViec = cboTenCongTrinh.Text.Trim();
                DateTime homNay = DateTime.Now;
                string ngayLamHD = homNay.ToString("dd/MM/yyyy");
                DateTime sauMotNam = homNay.AddYears(1);
                string ngayKetThucHD = sauMotNam.ToString("dd/MM/yyyy");
                // luong // lay tu csdl

                string templatePath = "HopDongLaoDong.docx"; // file mẫu
                if (!File.Exists(templatePath))
                {
                    MessageBox.Show("Không tìm thấy file mẫu HopDongLaoDong.docx", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string filePath = $"HopDongLaoDong_{CCCD}_{DateTime.Now:yyyyMMddHHmmss}.docx";

                using (var doc = DocX.Load(templatePath))
                {
                    doc.ReplaceText("{{ten}}", tenCN);
                    doc.ReplaceText("{{ngaysinh}}", ngaySinh);
                    doc.ReplaceText("{{diachi}}", diaChi);
                    doc.ReplaceText("{{SDT}}", sdt);
                    doc.ReplaceText("{{CCCD}}", CCCD);
                    //loaiHD // lay tu csdl
                    doc.ReplaceText("{{tenCongTrinh}}", diaDiemLamViec);
                    doc.ReplaceText("{{ngayLamHD}}", ngayLamHD);
                    doc.ReplaceText("{{ngayHetHD}}", ngayKetThucHD);
                    // luong // lay tu csdl

                    doc.SaveAs(filePath);
                }

                //MessageBox.Show($"Xuất báo cáo thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Kiểm tra xem tệp có tồn tại không trước khi mở
                if (File.Exists(filePath))
                {
                    try
                    {
                        //Process.Start(filePath);
                        Process.Start(new ProcessStartInfo()
                        {
                            FileName = filePath,
                            UseShellExecute = true
                        });
                    }
                    catch (Exception ex)
                    {
                        // Xử lý lỗi nếu không thể mở tệp
                        MessageBox.Show("Không thể mở tệp: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất báo cáo: " + ex.Message);
            }

        }
    }
}
