using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QLCN.DB;
using Microsoft.Data.SqlClient;
using ClosedXML.Excel;

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
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnExport.Click += btnExport_Click;
            pictureBoxRemoveFilter.Click += pictureBoxRemoveFilter_Click;
            btnXemHD.Click += btnXemHD_Click;
            btnXemChamCong.Click += btnXemChamCong_Click;
            dgvConstruction.CellClick += DgvConstruction_CellClick;
            dgvConstruction.DataBindingComplete += DgvConstruction_DataBindingComplete;
            dgvConstruction.Sorted += DgvConstruction_Sorted;
            // dgvConstruction.CellContentClick += DgvConstruction_CellContentClick;
            // dgvConstruction.SelectionChanged += DgvConstruction_SelectionChanged;
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
                lblMessage.Text = "Vui lòng nhập mã công nhân!";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
                txtMaCN.Focus();
                return true;
            }

            // Kiểm tra tên công nhân không được bỏ trống
            if (string.IsNullOrWhiteSpace(txtTenCN.Text))
            {
                lblMessage.Text = "Vui lòng nhập tên công nhân!";
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
            if (cboGioiTinh.SelectedItem == null)
            {
                lblMessage.Text = "Vui lòng chọn giới tính!";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
                cboFilterGioiTinh.Focus();
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
                query = @"SELECT cn.macn MaCN, HoTen as TenCN, LTRIM(RTRIM(RIGHT(HoTen, CHARINDEX(' ', REVERSE(HoTen) + ' ') - 1))) AS Ten,
                CASE 
                    WHEN CHARINDEX(' ', HoTen) = 0 THEN NULL
                    ELSE LTRIM(RTRIM(LEFT(HoTen, CHARINDEX(' ', HoTen + ' ') - 1)))
                    END AS Ho,
                CASE 
                    WHEN (LEN(HoTen) - LEN(REPLACE(HoTen, ' ', ''))) < 2 THEN NULL
                    ELSE LTRIM(RTRIM(SUBSTRING(HoTen,CHARINDEX(' ', HoTen + ' ') + 1,LEN(HoTen) - CHARINDEX(' ', HoTen + ' ') - CHARINDEX(' ', REVERSE(HoTen) + ' '))))
                END AS TenDem,
                GioiTinh, NgaySinh, SDT, CCCD, trim(iif(MoTaChiTiet is null, '', motachitiet + ', ') + TenXP + ', ' + TenQH + ', ' + TenTinh) as DiaChi, TenCT, cn.ghichu GhiChu
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
            dtpFilterNgaySinh1.Checked = false;
            dtpFilterNgaySinh2.Checked = false;
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

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (CheckRequiredFields()) return;
            try
            {
                using SqlConnection connection = DatabaseHelper.GetConnection();
                connection.Open();
                query = "insert into CongNhan (macn, hoten, ngaysinh, gioitinh, sdt, cccd, mact, ghichu) values (@MaCN, @HoTen, @NgaySinh, @GioiTinh, @SDT, @CCCD, @MaCT, @GhiChu)";

                using SqlCommand command = new(query, connection);

                command.Parameters.AddWithValue("@MaCN", txtMaCN.Text);
                command.Parameters.AddWithValue("@HoTen", txtTenCN.Text);
                command.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                command.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.SelectedItem?.ToString());
                command.Parameters.AddWithValue("@SDT", txtSDT.Text);
                command.Parameters.AddWithValue("@CCCD", txtCCCD.Text);
                command.Parameters.AddWithValue("@MaCT", cboTenCongTrinh.SelectedValue);
                command.Parameters.AddWithValue("@GhiChu", string.IsNullOrWhiteSpace(txtGhiChu.Text) ? DBNull.Value : txtGhiChu.Text);

                command.ExecuteNonQuery();

                query = "insert into DiaChiCongNhan (MaCN, MaXP, MoTaChiTiet) values (@MaCN, @MaXP, @MoTaChiTiet)";
                using SqlCommand command2 = new(query, connection);
                command2.Parameters.AddWithValue("@MaCN", txtMaCN.Text);
                command2.Parameters.AddWithValue("@MaXP", cboXaPhuong.SelectedValue);
                command2.Parameters.AddWithValue("@MoTaChiTiet", string.IsNullOrWhiteSpace(txtMoTaChiTiet.Text) ? DBNull.Value : txtMoTaChiTiet.Text);
                command2.ExecuteNonQuery();

                lblMessage.Text = "Đã thêm công trình thành công!";
                lblMessage.ForeColor = Color.Green;
                TimeIntervalMessage();

                txtMaCN.Clear();
                txtTenCN.Clear();
                dtpNgaySinh.Value = DateTime.Now;
                dtpNgaySinh.Checked = false;
                cboFilterGioiTinh.SelectedIndex = 0;
                txtSDT.Clear();
                txtCCCD.Clear();
                cboTinh.SelectedIndex = -1;
                cboTenCongTrinh.SelectedIndex = 0;
                txtGhiChu.Clear();
                txtMoTaChiTiet.Clear();
                this.ActiveControl = null;

                LoadCongTrinh();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    if (ex.Message.Contains("PK_")) // Tên constraint khóa chính
                        lblMessage.Text = "Mã công nhân đã tồn tại";
                    else if (ex.Message.Contains("UQ_")) // Tên constraint unique
                        lblMessage.Text = "Đã có công nhân có CCCD/CMND/Số điện thoại này";
                    else
                        lblMessage.Text = "Trùng dữ liệu";
                }
                else
                    lblMessage.Text = $"Lỗi SQL: {ex.Message}";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
            }
            catch (Exception ex)
            {
                lblMessage.Text = $"Lỗi: {ex.Message}";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
            }
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object? sender, EventArgs e)
        {

        }

        private void btnExport_Click(object? sender, EventArgs e)
        {

        }

        private void pictureBoxRemoveFilter_Click(object? sender, EventArgs e)
        {

        }

        private void btnXemHD_Click(object? sender, EventArgs e)
        {

        }

        private void btnXemChamCong_Click(object? sender, EventArgs e)
        {

        }

        private string? macn;
        private void DgvConstruction_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấp vào tiêu đề cột không
            if (e.RowIndex < 0)
                return;

            try
            {
                // Lấy dữ liệu từ dòng được chọn
                DataGridViewRow row = dgvConstruction.Rows[e.RowIndex];

                // Hiển thị dữ liệu vào các ô nhập tương ứng
                txtMaCN.Text = row.Cells["dgvColMaCN"].Value.ToString();
                txtTenCN.Text = row.Cells["dgvColTenCN"].Value.ToString();
                cboGioiTinh.Text = row.Cells["dgvColGioiTinh"].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["dgvColNgaySinh"].Value);
                txtSDT.Text = row.Cells["dgvColSDT"].Value.ToString();
                txtCCCD.Text = row.Cells["dgvColCCCD"].Value.ToString();
                cboTenCongTrinh.SelectedIndex = cboTenCongTrinh.FindStringExact(row.Cells["dgvColTenCT"].Value.ToString());
                txtGhiChu.Text = row.Cells["dgvColGhiChu"].Value.ToString();

                string diaChi = row.Cells["dgvColDiaDiem"].Value?.ToString() ?? "";
                cboTenCongTrinh.SelectedIndex = cboTenCongTrinh.FindStringExact(row.Cells["dgvColTenCT"].Value.ToString());
                string[] parts = diaChi.Split(',');


                string tenTinh = parts[^1].Trim();
                string tenHuyen = parts[^2].Trim();
                string tenXa = parts[^3].Trim();

                string moTaChiTiet = string.Join(",", parts.Take(parts.Length - 3)).Trim();

                txtMoTaChiTiet.Text = moTaChiTiet;

                cboTinh.SelectedIndex = cboTinh.FindStringExact(tenTinh);
                if (cboTinh.SelectedIndex != -1)
                {
                    LoadcboHuyen(Convert.ToInt32(cboTinh.SelectedValue));
                    cboQuanHuyen.SelectedIndex = cboQuanHuyen.FindStringExact(tenHuyen);
                }
                if (cboQuanHuyen.SelectedIndex != -1)
                {
                    LoadcboXa(Convert.ToInt32(cboQuanHuyen.SelectedValue));
                    cboXaPhuong.SelectedIndex = cboXaPhuong.FindStringExact(tenXa);
                }


                macn = txtMaCN.Text;

                txtMaCN.Focus();

            }
            catch (Exception ex)
            {
                lblMessage.Text = $"Lỗi khi lấy dữ liệu: {ex.Message}";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
            }
        }
        private void SelectRowById()
        {
            foreach (DataGridViewRow row in dgvConstruction.Rows)
            {
                if (row.Cells["dgvColMaCN"].Value.ToString() == macn)
                {
                    // Chọn dòng
                    dgvConstruction.ClearSelection();
                    row.Selected = true;
                    dgvConstruction.CurrentCell = row.Cells[0];

                    // Cuộn đến dòng được chọn để đảm bảo nó hiển thị
                    dgvConstruction.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        private void btnEdit_Click(object? sender, EventArgs e)
        {
            if (dgvConstruction.RowCount == 0)
            {
                lblMessage.Text = "Không có công nhân nào để sửa!";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
                return;
            }
            // Kiểm tra xem đã chọn công trình nào chưa
            if (macn == null)
            {
                lblMessage.Text = "Chọn công nhân để sửa!";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
                return;
            }

            if (CheckRequiredFields()) return;
            try
            {

                using SqlConnection connection = DatabaseHelper.GetConnection();
                connection.Open();

                query = "update CongNhan set macn = @macn1, hoten = @hoten, cccd = @cccd, sdt = @sdt, ngaysinh = @ngaysinh, gioitinh = @gioitinh ghichu = @ghichu, mact = @mact where macn = @macn";

                using SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@macn1", txtMaCN.Text);
                command.Parameters.AddWithValue("@hoten", txtTenCN.Text);
                command.Parameters.AddWithValue("@gioitinh", cboGioiTinh.SelectedItem);
                command.Parameters.AddWithValue("@sdt", txtSDT.Text);
                command.Parameters.AddWithValue("@cccd", txtCCCD.Text);
                command.Parameters.AddWithValue("@mact", cboTenCongTrinh.SelectedValue);
                command.Parameters.AddWithValue("@ghichu", string.IsNullOrWhiteSpace(txtGhiChu.Text) ? DBNull.Value : txtGhiChu.Text);
                command.Parameters.AddWithValue("@ngaysinh", dtpNgaySinh.Value);
                command.Parameters.AddWithValue("@macn", macn);
                command.ExecuteNonQuery();

                query = "update DiaChiCongNhan set MaXP = @MaXP, MoTaChiTiet = @MoTaChiTiet where MaCN = @macn";
                using SqlCommand command2 = new(query, connection);
                command2.Parameters.AddWithValue("@MaXP", cboXaPhuong.SelectedValue);
                command2.Parameters.AddWithValue("@MoTaChiTiet", string.IsNullOrWhiteSpace(txtMoTaChiTiet.Text) ? DBNull.Value : txtMoTaChiTiet.Text);
                command2.Parameters.AddWithValue("@macn", txtMaCN.Text);
                command2.ExecuteNonQuery();


                lblMessage.Text = "Cập nhật công trình thành công!";
                lblMessage.ForeColor = Color.Green;
                TimeIntervalMessage();

                txtTenCN.Clear();
                txtMaCN.Clear();
                cboGioiTinh.SelectedIndex = 0;
                dtpNgaySinh.Value = DateTime.Now;
                txtSDT.Clear();
                txtCCCD.Clear();
                txtGhiChu.Clear();
                cboTenCongTrinh.SelectedIndex = 0;
                txtMoTaChiTiet.Clear();
                ActiveControl = null;
                macn = null;

                LoadCongTrinh();
                SelectRowById();


            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    if (ex.Message.Contains("PK_")) // Tên constraint khóa chính
                        lblMessage.Text = "Mã công nhân đã tồn tại";
                    else if (ex.Message.Contains("UQ_")) // Tên constraint unique
                        lblMessage.Text = "Đã có công nhân có CCCD/CMND/Số điện thoại này";
                    else
                        lblMessage.Text = "Trùng dữ liệu";
                }
                else
                    lblMessage.Text = $"Lỗi SQL: {ex.Message}";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
            }
            catch (Exception ex)
            {
                lblMessage.Text = $"Lỗi: {ex.Message}";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
            }

        }
        private void DgvConstruction_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Đảm bảo không có dòng nào được chọn sau khi binding dữ liệu
            dgvConstruction.ClearSelection();
            if (dgvConstruction.Rows.Count > 0)
                dgvConstruction.CurrentCell = null;
        }
        private void DgvConstruction_Sorted(object? sender, EventArgs e)
        {
            // Xóa lựa chọn sau khi sắp xếp
            dgvConstruction.ClearSelection();

            // Đặt CurrentCell thành null để không có ô nào được chọn
            if (dgvConstruction.Rows.Count > 0)
            {
                dgvConstruction.CurrentCell = null;
            }
        }
    }
}
