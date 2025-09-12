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

        public void SetCongTrinh(string maCT) => cboFilterTenCT.Text = maCT;

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
            dgvConstruction.CellContentClick += DgvConstruction_CellContentClick;
            dgvConstruction.SelectionChanged += DgvConstruction_SelectionChanged;
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
            cboFilterGioiTinh.SelectedIndex = 0;
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
                    string query = "SELECT MaQH, TenQH FROM QuanHuyen WHERE MaTinh = @MaTinh";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@MaTinh", maTinh);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboQuanHuyen.DataSource = dt;
                    cboQuanHuyen.DisplayMember = "TenQH";
                    cboQuanHuyen.ValueMember = "MaQH";
                    cboQuanHuyen.SelectedIndex = -1;

                    // AutoComplete
                    AutoCompleteStringCollection autoSource = new AutoCompleteStringCollection();
                    foreach (DataRow row in dt.Rows)
                        autoSource.Add(row["TenQH"].ToString());

                    cboQuanHuyen.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    cboQuanHuyen.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    cboQuanHuyen.AutoCompleteCustomSource = autoSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải Quận/Huyện: {ex.Message}");
            }
        }


        private void LoadcboTinh()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT MaTinh, TenTinh FROM Tinh";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Gán DataSource
                    cboTinh.DataSource = dt;
                    cboTinh.DisplayMember = "TenTinh";
                    cboTinh.ValueMember = "MaTinh";
                    cboTinh.SelectedIndex = -1;

                    // Tạo AutoComplete cho ComboBox
                    AutoCompleteStringCollection autoSource = new AutoCompleteStringCollection();
                    foreach (DataRow row in dt.Rows)
                    {
                        autoSource.Add(row["TenTinh"].ToString());
                    }

                    cboTinh.AutoCompleteCustomSource = autoSource;
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
                    da.SelectCommand.Parameters.AddWithValue("@MaHuyen", maHuyen);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboXaPhuong.DataSource = dt;
                    cboXaPhuong.DisplayMember = "TenXP";
                    cboXaPhuong.ValueMember = "MaXP";
                    cboXaPhuong.SelectedIndex = -1;

                    // AutoComplete
                    AutoCompleteStringCollection autoSource = new AutoCompleteStringCollection();
                    foreach (DataRow row in dt.Rows)
                        autoSource.Add(row["TenXP"].ToString());

                    cboXaPhuong.AutoCompleteCustomSource = autoSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải Xã/Phường: {ex.Message}");
            }
        }

        private void cboQuanHuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboQuanHuyen.SelectedValue != null && int.TryParse(cboQuanHuyen.SelectedValue.ToString(), out int maHuyen))
                LoadcboXa(maHuyen);
        }

        private void CongNhan_Load(object? sender, EventArgs e) => LoadCongNhan();

        public void LoadCongTrinh()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT mact, tenct FROM congtrinh where tinhtrang not in (N'Đã hoàn thành', N'Bị hủy')";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboTenCongTrinh.DataSource = dt;
                    cboTenCongTrinh.DisplayMember = "tenct";
                    cboTenCongTrinh.ValueMember = "mact";
                    cboTenCongTrinh.SelectedIndex = 0;
                    AutoCompleteStringCollection autoSource = new AutoCompleteStringCollection();
                    foreach (DataRow row in dt.Rows)
                        autoSource.Add(row["tenct"].ToString());

                    cboTenCongTrinh.AutoCompleteCustomSource = autoSource;
                    cboTenCongTrinh.Text = "";
                }
            }
            catch (Exception ex)
            {
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

                LoadCongNhan();
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

        private void pictureBoxRemoveFilter_Click(object? sender, EventArgs e)
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

                query = "update CongNhan set macn = @macn1, hoten = @hoten, cccd = @cccd, sdt = @sdt, ngaysinh = @ngaysinh, gioitinh = @gioitinh, ghichu = @ghichu, mact = @mact where macn = @macn";

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

                LoadCongNhan();
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

        private bool isDelete = false;
        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvConstruction.RowCount == 0)
            {
                lblMessage.Text = "Không có công trình nào để xóa!";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
                return;
            }
            if (!isDelete)
            {
                // Chuyển sang chế độ xóa
                isDelete = true;

                // Hiển thị cột checkbox
                dgvColCheckBox.Visible = true;

                // Đổi tên nút thành "Hủy xóa"
                btnDelete.Text = "Hủy xóa";
                dgvConstruction.ClearSelection();

                txtTenCN.Enabled = false;
                txtMaCN.Enabled = false;
                cboGioiTinh.Enabled = false;
                dtpNgaySinh.Enabled = false;
                txtSDT.Enabled = false;
                txtCCCD.Enabled = false;
                txtGhiChu.Enabled = false;
                cboTinh.Enabled = false;
                cboQuanHuyen.Enabled = false;
                cboXaPhuong.Enabled = false;
                txtMoTaChiTiet.Enabled = false;
                cboTenCongTrinh.Enabled = false;
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnRefresh.Enabled = false;
                btnExport.Enabled = false;
                btnImport.Enabled = false;

                dgvConstruction.CellClick -= DgvConstruction_CellClick;

            }
            else
            {
                // Kiểm tra xem có dòng nào được chọn không
                bool hasCheckedRows = false;
                foreach (DataGridViewRow row in dgvConstruction.Rows)
                {
                    if (row.Cells["dgvColCheckBox"].Value != null &&
                        Convert.ToBoolean(row.Cells["dgvColCheckBox"].Value))
                    {
                        hasCheckedRows = true;
                        break;
                    }
                }

                if (hasCheckedRows)
                {
                    // Nếu có dòng được chọn và nút đang hiển thị "Hủy xóa"
                    if (btnDelete.Text == "Hủy xóa")
                        // Đổi tên nút thành "Xác nhận xóa"
                        btnDelete.Text = "Xác nhận xóa";
                    else if (btnDelete.Text == "Xác nhận xóa")
                    {
                        // Thực hiện xóa các dòng đã chọn
                        DeleteSelectedRows();

                        // Trở về trạng thái ban đầu
                        ResetDeleteMode();
                    }
                }
                else
                    // Không có dòng nào được chọn, trở về trạng thái ban đầu
                    ResetDeleteMode();
            }
        }
        private void DeleteSelectedRows()
        {
            try
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa các công nhân đã chọn?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using SqlConnection connection = DatabaseHelper.GetConnection();
                    connection.Open();

                    // Tạo danh sách các mã cồng trình cần xóa
                    List<string> dsmacn = [];
                    foreach (DataGridViewRow row in dgvConstruction.Rows)
                    {
                        if (row.Cells["dgvColCheckBox"].Value != null &&
                            Convert.ToBoolean(row.Cells["dgvColCheckBox"].Value))
                        {
                            string? macn = row.Cells["dgvColMaCN"].Value?.ToString();
                            dsmacn.Add(macn);
                        }
                    }

                    // Xóa từng công trình
                    int deletedCount = 0;
                    foreach (string macn in dsmacn)
                    {
                        string query = "delete from congnhan where macn = @macn";
                        using SqlCommand command = new(query, connection);
                        command.Parameters.AddWithValue("@macn", macn);
                        deletedCount += command.ExecuteNonQuery();
                    }

                    // Hiển thị thông báo thành công
                    lblMessage.Text = $"Đã xóa {deletedCount} công nhân thành công!";
                    lblMessage.ForeColor = Color.Green;
                    TimeIntervalMessage();
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = $"Lỗi: {ex.Message}";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
            }
        }
        private void ResetDeleteMode()
        {
            // Ẩn cột checkbox
            dgvColCheckBox.Visible = false;

            // Đổi tên nút trở lại thành Xóa
            btnDelete.Text = "Xóa";

            // Đặt lại trạng thái
            isDelete = false;
            dgvConstruction.CellClick += DgvConstruction_CellClick;
            txtTenCN.Enabled = true;
            txtMaCN.Enabled = true;
            cboGioiTinh.Enabled = true;
            dtpNgaySinh.Enabled = true;
            txtSDT.Enabled = true;
            txtCCCD.Enabled = true;
            txtGhiChu.Enabled = true;
            cboTinh.Enabled = true;
            cboQuanHuyen.Enabled = true;
            cboXaPhuong.Enabled = true;
            txtMoTaChiTiet.Enabled = true;
            cboTenCongTrinh.Enabled = true;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnRefresh.Enabled = true;
            btnExport.Enabled = true;
            btnImport.Enabled = true;
            txtMaCN.Focus(); // Đặt focus vào ô nhập mã công trình

            int maxp = -1, maqh = -1, matinh = -1;
            // Kiểm tra combobox Xã phường có giá trị không
            if (cboXaPhuong.SelectedIndex != -1)
            {
                maxp = Convert.ToInt32(cboXaPhuong.SelectedValue);
                maqh = Convert.ToInt32(cboQuanHuyen.SelectedValue);
                matinh = Convert.ToInt32(cboTinh.SelectedValue);
            }
            // Làm mới datagridview để xóa các lựa chọn
            LoadCongNhan();

            if (maxp != -1)
            {
                cboTinh.SelectedValue = matinh;
                LoadcboHuyen(matinh);
                cboQuanHuyen.SelectedValue = maqh;
                LoadcboXa(maqh);
                cboXaPhuong.SelectedValue = maxp;
            }
            if (!string.IsNullOrWhiteSpace(txtMaCN.Text))
            {
                macn = txtMaCN.Text;
                SelectRowById();
            }
            else txtMaCN.Focus();
        }
        private void DgvConstruction_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấp vào cột checkbox không
            if (e.ColumnIndex == dgvColCheckBox.Index && e.RowIndex >= 0)
            {
                // Đảo ngược giá trị của ô checkbox
                bool currentValue = false;
                if (dgvConstruction.Rows[e.RowIndex].Cells["dgvColCheckBox"].Value != null)
                    currentValue = Convert.ToBoolean(dgvConstruction.Rows[e.RowIndex].Cells["dgvColCheckBox"].Value);
                dgvConstruction.Rows[e.RowIndex].Cells["dgvColCheckBox"].Value = !currentValue;

                // Kiểm tra xem có dòng nào được chọn không
                bool hasCheckedRows = false;
                foreach (DataGridViewRow row in dgvConstruction.Rows)
                {
                    if (row.Cells["dgvColCheckbox"].Value != null &&
                        Convert.ToBoolean(row.Cells["dgvColCheckbox"].Value))
                    {
                        hasCheckedRows = true;
                        break;
                    }
                }

                // Nếu có dòng được chọn và nút đang hiển thị "Hủy xóa"
                if (hasCheckedRows && btnDelete.Text == "Hủy xóa")
                // Đổi tên nút thành "Xác nhận xóa"
                {
                    btnDelete.Text = "Xác nhận xóa";
                    dgvColCheckBox.HeaderText = "❎";
                    dgvColCheckBox.HeaderCell.ToolTipText = "Bỏ chọn tất cả";
                }
                else if (!hasCheckedRows && btnDelete.Text == "Xác nhận xóa")
                // Không còn dòng nào được chọn, đổi tên nút trở lại thành "Hủy xóa"
                {
                    btnDelete.Text = "Hủy xóa";
                    dgvColCheckBox.HeaderText = "✅";
                    dgvColCheckBox.HeaderCell.ToolTipText = "Chọn tất cả";
                }
            }

            // Kiểm tra xem người dùng có nhấp vào header của cột checkbox không
            if (e.RowIndex == -1 && e.ColumnIndex == dgvColCheckBox.Index)
            {
                // Kiểm tra xem có dòng nào đã được chọn chưa
                bool anyChecked = false;
                foreach (DataGridViewRow row in dgvConstruction.Rows)
                {
                    if (row.Cells["dgvColCheckBox"].Value != null &&
                        Convert.ToBoolean(row.Cells["dgvColCheckBox"].Value))
                    {
                        anyChecked = true;
                        break;
                    }
                }

                // Chọn hoặc bỏ chọn tất cả các dòng
                bool checkValue = !anyChecked;
                foreach (DataGridViewRow row in dgvConstruction.Rows)
                    row.Cells["dgvColCheckBox"].Value = checkValue;

                // Cập nhật tên nút
                if (checkValue)
                {
                    dgvColCheckBox.HeaderText = "❎";
                    dgvColCheckBox.HeaderCell.ToolTipText = "Bỏ chọn tất cả";
                    btnDelete.Text = "Xác nhận xóa";
                }
                else
                {
                    dgvColCheckBox.HeaderText = "✅";
                    dgvColCheckBox.HeaderCell.ToolTipText = "Chọn tất cả";
                    btnDelete.Text = "Hủy xóa";
                }
            }
        }
        private void DgvConstruction_SelectionChanged(object? sender, EventArgs e)
        {
            // Nếu cột checkbox đang hiển thị (đang ở chế độ xóa), không cho phép chọn dòng
            if (dgvColCheckBox.Visible)
                dgvConstruction.ClearSelection();
            // dgvConstruction.CurrentCell = null;
        }

        private void btnRefresh_Click(object? sender, EventArgs e)
        {
            // Xóa nội dung của tất cả các ô nhập liệu
            txtMaCN.Clear();
            txtTenCN.Clear();
            cboGioiTinh.SelectedIndex = -1;
            dtpNgaySinh.Value = DateTime.Now;
            txtSDT.Clear();
            txtCCCD.Clear();
            txtGhiChu.Clear();
            cboTenCongTrinh.SelectedIndex = -1;

            cboTinh.SelectedIndex = -1;
            cboQuanHuyen.SelectedIndex = -1;
            cboXaPhuong.SelectedIndex = -1;
            txtMoTaChiTiet.Clear();

            txtMaCN.Focus();
        }


        private void btnExport_Click(object? sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có dữ liệu để xuất không
                if (dgvConstruction.Rows.Count == 0)
                {
                    lblMessage.Text = "Không có dữ liệu để xuất!";
                    lblMessage.ForeColor = Color.Red;
                    TimeIntervalMessage();
                    return;
                }

                // Tạo SaveFileDialog để chọn vị trí lưu file
                SaveFileDialog saveFileDialog = new()
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Lưu file Excel",
                    FileName = $"DanhSachCongTrinh_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Tạo workbook mới
                    using var workbook = new XLWorkbook();

                    // Thêm worksheet
                    var worksheet = workbook.Worksheets.Add("Danh sách công trình");

                    // Đặt tiêu đề cho file Excel
                    worksheet.Cell(1, 1).Value = "DANH SÁCH CÔNG TRÌNH";
                    worksheet.Range(1, 1, 1, 10).Merge();
                    worksheet.Cell(1, 1).Style.Font.Bold = true;
                    worksheet.Cell(1, 1).Style.Font.FontSize = 16;
                    worksheet.Cell(1, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    // Thêm tiêu đề các cột
                    worksheet.Cell(3, 1).Value = "STT";
                    worksheet.Cell(3, 2).Value = "Mã công trình";
                    worksheet.Cell(3, 3).Value = "Tên công trình";
                    worksheet.Cell(3, 4).Value = "Tình trạng";
                    worksheet.Cell(3, 5).Value = "Chủ đầu tư";
                    worksheet.Cell(3, 6).Value = "Địa điểm";
                    worksheet.Cell(3, 7).Value = "Dự toán (VNĐ)";
                    worksheet.Cell(3, 8).Value = "Ngày bắt đầu";
                    worksheet.Cell(3, 9).Value = "Ngày kết thúc";
                    worksheet.Cell(3, 10).Value = "Ghi chú";

                    // Định dạng tiêu đề cột
                    var headerRange = worksheet.Range(3, 1, 3, 10);
                    headerRange.Style.Font.Bold = true;
                    headerRange.Style.Fill.BackgroundColor = XLColor.LightGray;
                    headerRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    headerRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                    headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    // Đổ dữ liệu từ DataGridView vào Excel
                    int rowCount = dgvConstruction.Rows.Count;
                    for (int i = 0; i < rowCount; i++)
                    {
                        worksheet.Cell(i + 4, 1).Value = i + 1;
                        worksheet.Cell(i + 4, 2).Value = dgvConstruction.Rows[i].Cells["dgvColMaCT"].Value.ToString();
                        worksheet.Cell(i + 4, 3).Value = dgvConstruction.Rows[i].Cells["dgvColTenCT"].Value.ToString();
                        worksheet.Cell(i + 4, 4).Value = dgvConstruction.Rows[i].Cells["dgvColTinhTrang"].Value.ToString();
                        worksheet.Cell(i + 4, 5).Value = dgvConstruction.Rows[i].Cells["dgvColChuDauTu"].Value.ToString();
                        worksheet.Cell(i + 4, 6).Value = dgvConstruction.Rows[i].Cells["dgvColDiaDiem"].Value.ToString();
                        worksheet.Cell(i + 4, 7).Value = dgvConstruction.Rows[i].Cells["dgvColDuToan"].Value != DBNull.Value ? Convert.ToDecimal(dgvConstruction.Rows[i].Cells["dgvColDuToan"].Value) : (decimal?)null;
                        worksheet.Cell(i + 4, 8).Value = Convert.ToDateTime(dgvConstruction.Rows[i].Cells["dgvColNgayBatDau"].Value);
                        worksheet.Cell(i + 4, 9).Value = dgvConstruction.Rows[i].Cells["dgvColNgayKetThuc"].Value != DBNull.Value ? Convert.ToDateTime(dgvConstruction.Rows[i].Cells["dgvColNgayKetThuc"].Value) : (DateTime?)null;
                        worksheet.Cell(i + 4, 10).Value = dgvConstruction.Rows[i].Cells["dgvColGhiChu"].Value.ToString();
                    }

                    // Định dạng dữ liệu
                    var dataRange = worksheet.Range(4, 1, dgvConstruction.Rows.Count + 3, 10);
                    dataRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    dataRange.Style.Alignment.WrapText = true;
                    dataRange.Style.Font.FontSize = 12;
                    dataRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    dataRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                    // Căn giữa cột STT và Năm thực hiện
                    worksheet.Column(1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    // Tự động điều chỉnh độ rộng các cột
                    worksheet.Columns().AdjustToContents();

                    // Lưu file Excel
                    workbook.SaveAs(saveFileDialog.FileName);

                    lblMessage.Text = "Xuất Excel thành công!";
                    lblMessage.ForeColor = Color.Green;
                    TimeIntervalMessage();
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = $"Lỗi khi xuất Excel: {ex.Message}";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
            }
        }

        private void btnXemHD_Click(object? sender, EventArgs e)
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

        private void btnXemChamCong_Click(object? sender, EventArgs e)
        {
            LichSuChamCong lscc = new LichSuChamCong();
            lscc.Show();
        }
    }
}
