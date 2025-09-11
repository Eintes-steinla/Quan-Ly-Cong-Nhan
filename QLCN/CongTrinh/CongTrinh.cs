using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QLCN.DB;
using Microsoft.Data.SqlClient;
using ClosedXML.Excel;

namespace QLCN.CongTrinh
{
    public partial class CongTrinh : UserControl
    {
        string? query;
        public CongTrinh()
        {
            InitializeComponent();
            Event();
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
            // Kiểm tra mã công trình không được bỏ trống
            if (string.IsNullOrWhiteSpace(txtMaCT.Text))
            {
                lblMessage.Text = "Vui lòng nhập mã công trình!";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
                txtMaCT.Focus();
                return true;
            }

            // Kiểm tra tên công trình không được bỏ trống
            if (string.IsNullOrWhiteSpace(txtTenCT.Text))
            {
                lblMessage.Text = "Vui lòng nhập tên công trình!";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
                txtTenCT.Focus();
                return true;
            }

            // Kiểm tra xã phuơng không được bỏ trống
            if (cboXaPhuong.SelectedIndex == -1)
            {
                lblMessage.Text = "Vui lòng chọn địa chỉ!";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
                cboXaPhuong.Focus();
                return true;
            }
            // Kiểm tra tình trạng không được bỏ trống
            if (cboTinhTrang.SelectedIndex == -1)
            {
                lblMessage.Text = "Vui lòng chọn tình trạng công trình!";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
                cboTinhTrang.Focus();
                return true;
            }

            return false;
        }

        private void TxtDuToan_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (CheckRequiredFields()) return;
            try
            {
                using SqlConnection connection = DatabaseHelper.GetConnection();
                connection.Open();
                query = "insert into CongTrinh (MaCT, TenCT, TinhTrang, NgayBatDau, NgayKetThuc, DuToan, ChuDauTu, GhiChu) values (@MaCT, @TenCT, @TinhTrang, @NgayBatDau, @NgayKetThuc, @DuToan, @ChuDauTu, @GhiChu)";

                using SqlCommand command = new(query, connection);

                command.Parameters.AddWithValue("@MaCT", txtMaCT.Text);
                command.Parameters.AddWithValue("@TenCT", txtTenCT.Text);
                command.Parameters.AddWithValue("@TinhTrang", cboTinhTrang.SelectedItem);
                DateTime ngayBatDau = dtpNgayBatDau.Checked ? dtpNgayBatDau.Value : DateTime.Now;

                command.Parameters.AddWithValue("@NgayBatDau", ngayBatDau.ToString("yyyy-MM-dd HH:mm:ss"));
                if (dtpNgayKetThuc.Checked)
                {
                    if (dtpNgayKetThuc.Value.Date <= dtpNgayBatDau.Value.Date)
                        command.Parameters.AddWithValue("@NgayKetThuc", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@NgayKetThuc", dtpNgayKetThuc.Value);
                }
                else
                    command.Parameters.AddWithValue("@NgayKetThuc", DBNull.Value);

                command.Parameters.AddWithValue("@DuToan",
    string.IsNullOrWhiteSpace(txtDuToan.Text)
        ? DBNull.Value
        : Convert.ToDecimal(txtDuToan.Text));
                command.Parameters.AddWithValue("@ChuDauTu", string.IsNullOrWhiteSpace(txtChuDauTu.Text) ? DBNull.Value : txtChuDauTu.Text);
                command.Parameters.AddWithValue("@GhiChu", string.IsNullOrWhiteSpace(txtGhiChu.Text) ? DBNull.Value : txtGhiChu.Text);
                command.ExecuteNonQuery();

                query = "insert into DiaChiCongTrinh (MaCT, MaXP, MoTaChiTiet) values (@MaCT, @MaXP, @MoTaChiTiet)";
                using SqlCommand command2 = new(query, connection);
                command2.Parameters.AddWithValue("@MaCT", txtMaCT.Text);
                command2.Parameters.AddWithValue("@MaXP", cboXaPhuong.SelectedValue);
                command2.Parameters.AddWithValue("@MoTaChiTiet", string.IsNullOrWhiteSpace(txtMoTaChiTiet.Text) ? DBNull.Value : txtMoTaChiTiet.Text);
                command2.ExecuteNonQuery();

                lblMessage.Text = "Đã thêm công trình thành công!";
                lblMessage.ForeColor = Color.Green;
                TimeIntervalMessage();

                txtMaCT.Clear();
                txtTenCT.Clear();
                cboTinhTrang.SelectedIndex = -1;
                dtpNgayBatDau.Value = DateTime.Now;
                dtpNgayKetThuc.Value = DateTime.Now;
                txtDuToan.Clear();
                txtChuDauTu.Clear();
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
        private DataTable? constructionData;
        private void LoadCongTrinh()
        {
            try
            {
                using SqlConnection connection = DatabaseHelper.GetConnection();
                connection.Open();
                query = @"select ct.mact, tenct, tinhtrang, chudautu, trim(iif(MoTaChiTiet is null, '', motachitiet + ', ') + TenXP + ', ' + TenQH + ', ' + TenTinh) as diachi, dutoan, ngaybatdau , ngayketthuc , ct.ghichu
from congtrinh ct
join diachicongtrinh dt on ct.mact = dt.mact
join XaPhuong xp on xp.MaXP = dt.MaXP
join QuanHuyen qh on qh.MaQH = xp.MaQH
join Tinh t on t.MaTinh = qh.MaTinh";

                using SqlCommand command = new(query, connection);

                // Sử dụng SqlDataAdapter để lấy dữ liệu
                SqlDataAdapter adapter = new(command);

                // Tạo DataTable để lưu trữ dữ liệu
                constructionData = new();

                // Đổ dữ liệu vào DataTable
                adapter.Fill(constructionData);

                // Thêm cột STT
                if (!constructionData.Columns.Contains("STT"))
                {
                    DataColumn sttColumn = new("STT", typeof(int));
                    constructionData.Columns.Add(sttColumn);
                }

                // Đánh số STT
                int rowNumber = constructionData.Rows.Count;
                for (int i = 0; i < rowNumber; i++)
                    constructionData.Rows[i]["STT"] = i + 1;

                // Sắp xếp lại thứ tự cột
                if (constructionData.Columns.Contains("STT"))
                    constructionData.Columns?["STT"]?.SetOrdinal(0);
                // Gán DataSource
                dgvConstruction.DataSource = constructionData;
            }
            catch (Exception ex)
            {
                lblMessage.Text = $"Lỗi khi tải dữ liệu: {ex.Message}";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
            }

            LoadcboTinh();
            dtpFilterNgayBatDau.Checked = false;
            dtpFilterNgayKetThuc.Checked = false;
            cboFilterTinhTrang.SelectedIndex = 0;
            cboFilterDuToan.SelectedIndex = 0;

        }

        private void ApplyFilter()
        {
            try
            {
                if (constructionData == null) return;
                var filters = new List<string>();

                string mact = txtFilterMaCT.Text.Trim().Replace("'", "''");
                string tenct = txtFilterTenCT.Text.Trim().Replace("'", "''");
                string chudautu = txtFilterChuDauTu.Text.Trim().Replace("'", "''");
                string diadiem = txtFilterDiaDiem.Text.Trim().Replace("'", "''");
                DateTime? ngaybatdau = dtpFilterNgayBatDau.Checked ? dtpFilterNgayBatDau.Value.Date : (DateTime?)null;
                DateTime? ngayketthuc = dtpFilterNgayKetThuc.Checked ? dtpFilterNgayKetThuc.Value.Date : (DateTime?)null;

                string tinhtrang = cboFilterTinhTrang.Text;
                string duToan = cboFilterDuToan.Text;

                if (!string.IsNullOrEmpty(mact))
                    filters.Add($"mact LIKE '%{mact}%'");

                if (!string.IsNullOrEmpty(tenct))
                    filters.Add($"tenct LIKE '%{tenct}%'");

                if (!string.IsNullOrEmpty(chudautu))
                    filters.Add($"chudautu LIKE '%{chudautu}%'");

                if (!string.IsNullOrEmpty(diadiem))
                    filters.Add($"diachi LIKE '%{diadiem}%'");

                if (ngaybatdau.HasValue)
                    filters.Add($"ngaybatdau >= #{ngaybatdau.Value:MM/dd/yyyy}#");

                if (ngayketthuc.HasValue)
                    filters.Add($"ngayketthuc <= #{ngayketthuc.Value:MM/dd/yyyy}#");

                if (!string.IsNullOrEmpty(tinhtrang) && tinhtrang != "Tất cả")
                    filters.Add($"tinhtrang = '{tinhtrang}'");

                if (!string.IsNullOrEmpty(duToan) && duToan != "Tất cả")
                {
                    switch (duToan)
                    {
                        case "Trên 1 tỉ":
                            filters.Add("dutoan >= 1000000000");
                            break;
                        case "Trên 2 tỉ":
                            filters.Add("dutoan >= 2000000000");
                            break;
                        case "Trên 5 tỉ":
                            filters.Add("dutoan >= 5000000000");
                            break;
                        case "Trên 10 tỉ":
                            filters.Add("dutoan >= 10000000000");
                            break;
                        case "Trên 20 tỉ":
                            filters.Add("dutoan >= 20000000000");
                            break;
                    }
                }

                string filterExpression = string.Join(" AND ", filters);

                var dv = new DataView(constructionData)
                {
                    RowFilter = filterExpression
                };
                dgvConstruction.DataSource = dv;
            }
            catch (Exception)
            {
                dgvConstruction.DataSource = null; // Nếu có lỗi, clear DataSource
            }
        }


        private void TxtFilter_TextChanged(object? sender, EventArgs e) => ApplyFilter();

        // Xóa nội dung của tất cả các ô tìm kiếm
        private void pictureBoxRemoveFilter_Click(object? sender, EventArgs e)
        {
            txtFilterMaCT.Clear();
            txtFilterTenCT.Clear();
            txtFilterChuDauTu.Clear();
            txtFilterDiaDiem.Clear();
            dtpFilterNgayBatDau.Value = DateTime.Now;
            dtpFilterNgayBatDau.Checked = false;
            dtpFilterNgayKetThuc.Value = DateTime.Now;
            dtpFilterNgayKetThuc.Checked = false;
            cboFilterTinhTrang.SelectedIndex = 0;
            cboFilterDuToan.SelectedIndex = 0;
            txtFilterMaCT.Focus();
            ApplyFilter();
        }

        private void Event()
        {
            txtDuToan.KeyPress += TxtDuToan_KeyPress;
            pictureBoxRemoveFilter.Click += pictureBoxRemoveFilter_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;


            // Thêm sự kiện TextChanged cho các ô tìm kiếm
            txtFilterMaCT.TextChanged += TxtFilter_TextChanged;
            txtFilterTenCT.TextChanged += TxtFilter_TextChanged;
            txtFilterChuDauTu.TextChanged += TxtFilter_TextChanged;
            txtFilterDiaDiem.TextChanged += TxtFilter_TextChanged;
            dtpFilterNgayBatDau.ValueChanged += (s, e) => ApplyFilter();
            dtpFilterNgayKetThuc.ValueChanged += (s, e) => ApplyFilter();
            cboFilterTinhTrang.SelectedIndexChanged += (s, e) => ApplyFilter();
            cboFilterDuToan.SelectedIndexChanged += (s, e) => ApplyFilter();


            dgvConstruction.CellClick += DgvConstruction_CellClick;
            dgvConstruction.DataBindingComplete += DgvConstruction_DataBindingComplete;
            dgvConstruction.Sorted += DgvConstruction_Sorted;
            btnDelete.Click += btnDelete_Click;
            dgvConstruction.CellContentClick += DgvConstruction_CellContentClick;
            dgvConstruction.SelectionChanged += DgvConstruction_SelectionChanged;
            btnExport.Click += btnExport_Click;
        }


        private void btnRefresh_Click(object? sender, EventArgs e)
        {
            // Xóa nội dung của tất cả các ô nhập liệu
            txtMaCT.Clear();
            txtTenCT.Clear();
            cboTinhTrang.SelectedIndex = -1;
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;
            txtDuToan.Clear();
            txtChuDauTu.Clear();
            txtGhiChu.Clear();
            cboTinh.SelectedIndex = -1;
            cboQuanHuyen.SelectedIndex = -1;
            cboXaPhuong.SelectedIndex = -1;
            txtMoTaChiTiet.Clear();

            txtMaCT.Focus();
        }

        private void CongTrinh_Load(object? sender, EventArgs e) => LoadCongTrinh();

        private string? mact;
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
                txtMaCT.Text = row.Cells["dgvColMaCT"].Value.ToString();
                txtTenCT.Text = row.Cells["dgvColTenCT"].Value.ToString();
                cboTinhTrang.Text = row.Cells["dgvColTinhTrang"].Value.ToString();
                txtDuToan.Text = row.Cells["dgvColDuToan"].Value.ToString();
                txtChuDauTu.Text = row.Cells["dgvColChuDauTu"].Value.ToString();
                txtGhiChu.Text = row.Cells["dgvColGhiChu"].Value.ToString();
                dtpNgayBatDau.Value = Convert.ToDateTime(row.Cells["dgvColNgayBatDau"].Value);
                if (row.Cells["dgvColNgayKetThuc"].Value != DBNull.Value)
                    dtpNgayKetThuc.Value = Convert.ToDateTime(row.Cells["dgvColNgayKetThuc"].Value);
                else
                    dtpNgayKetThuc.Value = DateTime.Now;

                string diaChi = row.Cells["dgvColDiaDiem"].Value?.ToString() ?? "";
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


                mact = txtMaCT.Text;

                txtMaCT.Focus();

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
                if (row.Cells["dgvColMaCT"].Value.ToString() == mact)
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
                lblMessage.Text = "Không có công trình nào để sửa!";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
                return;
            }
            // Kiểm tra xem đã chọn công trình nào chưa
            if (mact == null)
            {
                lblMessage.Text = "Chọn một công trình để sửa!";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
                return;
            }

            if (CheckRequiredFields()) return;
            try
            {

                using SqlConnection connection = DatabaseHelper.GetConnection();
                connection.Open();

                query = "update CongTrinh set mact = @mact1, tenct = @tenct, tinhtrang = @tinhtrang, chudautu = @chudautu, dutoan = @dutoan, ngaybatdau = @ngaybatdau, ngayketthuc = @ngayketthuc, ghichu = @ghichu where mact = @mact";

                using SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@mact1", txtMaCT.Text);
                command.Parameters.AddWithValue("@tenct", txtTenCT.Text);
                command.Parameters.AddWithValue("@TinhTrang", cboTinhTrang.SelectedItem);
                DateTime ngayBatDau = dtpNgayBatDau.Checked ? dtpNgayBatDau.Value : DateTime.Now;

                command.Parameters.AddWithValue("@ngaybatdau", ngayBatDau.ToString("yyyy-MM-dd HH:mm:ss"));
                if (dtpNgayKetThuc.Checked)
                {
                    if (dtpNgayKetThuc.Value.Date <= dtpNgayBatDau.Value.Date)
                        command.Parameters.AddWithValue("@NgayKetThuc", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@NgayKetThuc", dtpNgayKetThuc.Value);
                }
                else
                    command.Parameters.AddWithValue("@NgayKetThuc", DBNull.Value);

                command.Parameters.AddWithValue("@dutoan",
    string.IsNullOrWhiteSpace(txtDuToan.Text)
        ? DBNull.Value
        : Convert.ToDecimal(txtDuToan.Text));
                command.Parameters.AddWithValue("@chudautu", string.IsNullOrWhiteSpace(txtChuDauTu.Text) ? DBNull.Value : txtChuDauTu.Text);
                command.Parameters.AddWithValue("@ghichu", string.IsNullOrWhiteSpace(txtGhiChu.Text) ? DBNull.Value : txtGhiChu.Text);
                command.Parameters.AddWithValue("@mact", mact);
                command.ExecuteNonQuery();

                query = "update DiaChiCongTrinh set MaXP = @MaXP, MoTaChiTiet = @MoTaChiTiet where MaCT = @MaCT";
                using SqlCommand command2 = new(query, connection);
                command2.Parameters.AddWithValue("@MaCT", txtMaCT.Text);
                command2.Parameters.AddWithValue("@MaXP", cboXaPhuong.SelectedValue);
                command2.Parameters.AddWithValue("@MoTaChiTiet", string.IsNullOrWhiteSpace(txtMoTaChiTiet.Text) ? DBNull.Value : txtMoTaChiTiet.Text);
                command2.ExecuteNonQuery();


                lblMessage.Text = "Cập nhật công trình thành công!";
                lblMessage.ForeColor = Color.Green;
                TimeIntervalMessage();

                txtTenCT.Clear();
                txtMaCT.Clear();
                txtTenCT.Clear();
                cboTinhTrang.SelectedIndex = -1;
                dtpNgayBatDau.Value = DateTime.Now;
                dtpNgayKetThuc.Value = DateTime.Now;
                txtDuToan.Clear();
                txtChuDauTu.Clear();
                txtGhiChu.Clear();
                txtMoTaChiTiet.Clear();
                ActiveControl = null;
                mact = null;

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

                txtTenCT.Enabled = false;
                txtMaCT.Enabled = false;
                cboTinhTrang.Enabled = false;
                dtpNgayBatDau.Enabled = false;
                dtpNgayKetThuc.Enabled = false;
                txtDuToan.Enabled = false;
                txtChuDauTu.Enabled = false;
                txtGhiChu.Enabled = false;
                cboTinh.Enabled = false;
                cboQuanHuyen.Enabled = false;
                cboXaPhuong.Enabled = false;
                txtMoTaChiTiet.Enabled = false;
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
                    "Bạn có chắc chắn muốn xóa các công trình đã chọn?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using SqlConnection connection = DatabaseHelper.GetConnection();
                    connection.Open();

                    // Tạo danh sách các mã cồng trình cần xóa
                    List<string> dsmact = [];
                    foreach (DataGridViewRow row in dgvConstruction.Rows)
                    {
                        if (row.Cells["dgvColCheckBox"].Value != null &&
                            Convert.ToBoolean(row.Cells["dgvColCheckBox"].Value))
                        {
                            string? mact = row.Cells["dgvColMaCT"].Value?.ToString();
                            dsmact.Add(mact);
                        }
                    }

                    // Xóa từng công trình
                    int deletedCount = 0;
                    foreach (string mact in dsmact)
                    {
                        string query = "delete from CongTrinh where mact = @mact";
                        using SqlCommand command = new(query, connection);
                        command.Parameters.AddWithValue("@mact", mact);
                        deletedCount += command.ExecuteNonQuery();
                    }

                    // Hiển thị thông báo thành công
                    lblMessage.Text = $"Đã xóa {deletedCount} công trình thành công!";
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
            txtTenCT.Enabled = true;
            txtMaCT.Enabled = true;
            cboTinhTrang.Enabled = true;
            dtpNgayBatDau.Enabled = true;
            dtpNgayKetThuc.Enabled = true;
            txtDuToan.Enabled = true;
            txtChuDauTu.Enabled = true;
            txtGhiChu.Enabled = true;
            cboTinh.Enabled = true;
            cboQuanHuyen.Enabled = true;
            cboXaPhuong.Enabled = true;
            txtMoTaChiTiet.Enabled = true;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnRefresh.Enabled = true;
            btnExport.Enabled = true;
            btnImport.Enabled = true;
            txtMaCT.Focus(); // Đặt focus vào ô nhập mã công trình

            int maxp = -1, maqh = -1, matinh = -1;
            // Kiểm tra combobox Xã phường có giá trị không
            if (cboXaPhuong.SelectedIndex != -1)
            {
                maxp = Convert.ToInt32(cboXaPhuong.SelectedValue);
                maqh = Convert.ToInt32(cboQuanHuyen.SelectedValue);
                matinh = Convert.ToInt32(cboTinh.SelectedValue);
            }
            // Làm mới datagridview để xóa các lựa chọn
            LoadCongTrinh();

            if (maxp != -1)
            {
                cboTinh.SelectedValue = matinh;
                LoadcboHuyen(matinh);
                cboQuanHuyen.SelectedValue = maqh;
                LoadcboXa(maqh);
                cboXaPhuong.SelectedValue = maxp;
            }

            if (!string.IsNullOrWhiteSpace(txtMaCT.Text))
            {
                mact = txtMaCT.Text;
                SelectRowById();
            }
            else txtMaCT.Focus();

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

        private void btnImport_Click(object sender, EventArgs e)
        {

        }
    }
}
