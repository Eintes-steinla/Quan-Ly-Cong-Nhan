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
        string query;
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

            return false;
        }

        private void TxtDuToan_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Allow control characters (like backspace) and digits
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
                // Lấy kết nối từ DatabaseHelper
                using SqlConnection connection = DatabaseHelper.GetConnection();
                connection.Open();
                query = "insert into CongTrinh (MaCT, TenCT, TinhTrang, NgayBatDau, NgayKetThuc, DuToan, ChuDauTu, GhiChu) values (@MaCT, @TenCT, @TinhTrang, @NgayBatDau, @NgayKetThuc, @DuToan, @ChuDauTu, @GhiChu)";

                using SqlCommand command = new(query, connection);

                command.Parameters.AddWithValue("@MaCT", txtMaCT.Text);
                command.Parameters.AddWithValue("@TenCT", txtTenCT.Text);
                command.Parameters.AddWithValue("@TinhTrang", txtTinhTrang.Text);
                DateTime ngayBatDau = dtpNgayBatDau.Checked ? dtpNgayBatDau.Value : DateTime.Now;

                command.Parameters.AddWithValue("@NgayBatDau", ngayBatDau.ToString("yyyy-MM-dd"));
                if (dtpNgayKetThuc.Checked && dtpNgayKetThuc.Value != DateTime.MinValue)
                    command.Parameters.AddWithValue("@NgayKetThuc", dtpNgayKetThuc.Value.ToString("yyyy-MM-dd"));
                else
                    command.Parameters.AddWithValue("@NgayKetThuc", DBNull.Value);
                command.Parameters.AddWithValue("@DuToan", txtDuToan.Text);
                command.Parameters.AddWithValue("@ChuDauTu", txtChuDauTu.Text);
                command.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
                command.ExecuteNonQuery();

                query = @"insert into DiaChiCongTrinh (MaCT, MaXP, MoTaChiTiet) values (@MaCT, @MaXP, @MoTaChiTiet)";
                using SqlCommand command2 = new(query, connection);
                command2.Parameters.AddWithValue("@MaCT", txtMaCT.Text);
                command2.Parameters.AddWithValue("@MaXP", cboXaPhuong.SelectedValue);
                command2.Parameters.AddWithValue("@MoTaChiTiet", txtMoTaChiTiet.Text);

                // Hiển thị thông báo thành công
                lblMessage.Text = "Đã thêm công trình thành công!";
                lblMessage.ForeColor = Color.Green;
                TimeIntervalMessage();

                // Làm mới các trường nhập liệu
                txtMaCT.Clear();
                txtTenCT.Clear();
                txtTinhTrang.Clear();
                dtpNgayBatDau.Value = DateTime.Now;
                dtpNgayKetThuc.Value = DateTime.Now;
                txtDuToan.Clear();
                txtChuDauTu.Clear();
                txtGhiChu.Clear();
                cboTinh.SelectedIndex = -1;
                cboQuanHuyen.SelectedIndex = -1;
                cboXaPhuong.SelectedIndex = -1;
                txtMoTaChiTiet.Clear();
                this.ActiveControl = null;

                // Làm mới datagridview
                LoadConstructionData();
            }
            catch (Exception ex)
            {
                lblMessage.Text = $"Lỗi: {ex.Message}";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
            }
        }
        private DataTable? constructionData;
        private void LoadConstructionData()
        {
            try
            {
                using SqlConnection connection = DatabaseHelper.GetConnection();
                connection.Open();
                query = @"select ct.mact, tenct, MoTaChiTiet + ', ' + TenXP + ', ' + TenQH + ', ' + TenTinh as diachi , tinhtrang, ngaybatdau, ngayketthuc, dutoan, chudautu, ct.ghichu
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

        }

        private void ApplyFilter()
        {
            try
            {
                if (constructionData == null) return;

                string nameFilter = txtFilterName.Text.Trim();
                string locationFilter = txtFilterLocation.Text.Trim();
                string yearFilter = txtFilterYear.Text.Trim();

                // Xây dựng biểu thức lọc
                string filterExpression = "";

                if (!string.IsNullOrEmpty(nameFilter))
                    filterExpression += $"Name like '%{nameFilter}%'";

                if (!string.IsNullOrEmpty(locationFilter))
                {
                    if (!string.IsNullOrEmpty(filterExpression))
                        filterExpression += " and ";
                    filterExpression += $"Location like '%{locationFilter}%'";
                }

                if (!string.IsNullOrEmpty(yearFilter))
                {
                    if (!string.IsNullOrEmpty(filterExpression))
                        filterExpression += " and ";
                    filterExpression += $"Year like '%{yearFilter}%'";
                }

                // Áp dụng bộ lọc
                var dv = new DataView(constructionData)
                {
                    RowFilter = filterExpression
                };
                dgvConstruction.DataSource = dv;
            }
            catch (Exception)
            {
                dgvConstruction.DataSource = null; // Nếu có lỗi, xóa DataSource
            }
        }

        private void TxtFilter_TextChanged(object? sender, EventArgs e) => ApplyFilter();

        // Xóa nội dung của tất cả các ô tìm kiếm
        private void pictureBoxRemoveFilter_Click(object? sender, EventArgs e)
        {
            txtFilterName.Clear();
            txtFilterYear.Clear();
            txtFilterLocation.Clear();
            txtFilterName.Focus(); // Đặt focus vào ô tìm kiếm tên công trình

            // Áp dụng lại bộ lọc (sẽ hiển thị tất cả dữ liệu vì các ô tìm kiếm đã được xóa)
            ApplyFilter();
        }

        private void Event()
        {
            txtDuToan.KeyPress += TxtDuToan_KeyPress;
            pictureBoxRemoveFilter.Click += pictureBoxRemoveFilter_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            Load += ConstructionUserControl_Load;


            // Thêm sự kiện TextChanged cho các ô tìm kiếm
            txtFilterName.TextChanged += TxtFilter_TextChanged;
            txtFilterYear.TextChanged += TxtFilter_TextChanged;
            txtFilterLocation.TextChanged += TxtFilter_TextChanged;
            // Đăng ký sự kiện KeyDown cho các TextBox
            /* txtName.KeyDown += TextBox_KeyDown;
            txtLocation.KeyDown += TextBox_KeyDown;
            txtYear.KeyDown += TextBox_KeyDown; */
            dgvConstruction.CellClick += DgvConstruction_CellClick;
            dgvConstruction.DataBindingComplete += DgvConstruction_DataBindingComplete;
            dgvConstruction.Sorted += DgvConstruction_Sorted;
            btnDelete.Click += btnDelete_Click;
            dgvConstruction.CellContentClick += DgvConstruction_CellContentClick;
            dgvConstruction.SelectionChanged += DgvConstruction_SelectionChanged;
            btnExport.Click += btnExport_Click;
        }
        /* private void TextBox_KeyDown(object? sender, KeyEventArgs e)
        {
           // Kiểm tra nếu phím Enter được nhấn
           if (e.KeyCode == Keys.Enter)
           {
              // Ngăn không cho phím Enter tạo ra tiếng "beep"
              e.SuppressKeyPress = true;

              // Kích hoạt sự kiện Click của nút Thêm
              btnAdd.PerformClick();
           }
        } */


        private void btnRefresh_Click(object? sender, EventArgs e)
        {
            // Xóa nội dung của tất cả các ô nhập liệu
            txtMaCT.Clear();
            txtTenCT.Clear();
            txtTinhTrang.Clear();
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;
            txtDuToan.Clear();
            txtChuDauTu.Clear();
            txtGhiChu.Clear();
            cboTinh.SelectedIndex = -1;
            cboQuanHuyen.SelectedIndex = -1;
            cboXaPhuong.SelectedIndex = -1;
            txtMoTaChiTiet.Clear();

            txtMaCT.Focus(); // Đặt focus vào ô nhập mã công trình
        }

        private void ConstructionUserControl_Load(object? sender, EventArgs e) => LoadConstructionData();

        private int constructionID = -1;
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
                txtTenCT.Text = row.Cells["dataGridViewColumnName"].Value.ToString();
                constructionID = Convert.ToInt32(row.Cells["dataGridViewColumnID"].Value); // Lưu ID công trình để sử dụng cho việc sửa hoặc xóa

                // TODO: Cần cập nhật để hiển thị dữ liệu từ database cho các trường mới
                // Hiện tại chỉ có dữ liệu từ các cột cũ
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
                if (Convert.ToInt32(row.Cells["dataGridViewColumnID"].Value) == constructionID)
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
            if (constructionID == -1)
            {
                lblMessage.Text = "Chọn một công trình để sửa!";
                lblMessage.ForeColor = Color.Red;
                TimeIntervalMessage();
                return;
            }

            if (CheckRequiredFields()) return;
            try
            {

                // Cập nhật dữ liệu vào database
                using SqlConnection connection = DatabaseHelper.GetConnection();
                connection.Open();

                query = "update CongTrinh set Name = @Name, Location = @Location, Year = @Year where ID = @ID";

                using SqlCommand command = new(query, connection);

                command.Parameters.AddWithValue("@Name", txtTenCT.Text);
                command.Parameters.AddWithValue("@Year", string.IsNullOrEmpty(txtTenCT.Text) ? DBNull.Value : Convert.ToInt32(txtTenCT.Text));
                command.Parameters.AddWithValue("@ID", constructionID);

                // Thực thi câu lệnh
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    lblMessage.Text = "Cập nhật công trình thành công!";
                    lblMessage.ForeColor = Color.Green;
                    TimeIntervalMessage();

                    txtTenCT.Clear();
                    txtMaCT.Clear();
                    txtTenCT.Clear();
                    txtTinhTrang.Clear();
                    dtpNgayBatDau.Value = DateTime.Now;
                    dtpNgayKetThuc.Value = DateTime.Now;
                    txtDuToan.Clear();
                    txtChuDauTu.Clear();
                    txtGhiChu.Clear();
                    cboTinh.SelectedIndex = -1;
                    cboQuanHuyen.SelectedIndex = -1;
                    cboXaPhuong.SelectedIndex = -1;
                    txtMoTaChiTiet.Clear();
                    ActiveControl = null;

                    LoadConstructionData();
                    SelectRowById();
                }
                else
                {
                    lblMessage.Text = "Không thể cập nhật công trình. Vui lòng thử lại!";
                    lblMessage.ForeColor = Color.Red;
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
            if (!isDelete)
            {
                // Chuyển sang chế độ xóa
                isDelete = true;

                // Hiển thị cột checkbox
                dataGridViewColumnCheckBox.Visible = true;

                // Đổi tên nút thành "Hủy xóa"
                btnDelete.Text = "Hủy xóa";
                dgvConstruction.ClearSelection();

                txtMaCT.Clear();
                txtTenCT.Clear();
                txtTinhTrang.Clear();
                dtpNgayBatDau.Value = DateTime.Now;
                dtpNgayKetThuc.Value = DateTime.Now;
                txtDuToan.Clear();
                txtChuDauTu.Clear();
                txtGhiChu.Clear();
                cboTinh.SelectedIndex = -1;
                cboQuanHuyen.SelectedIndex = -1;
                cboXaPhuong.SelectedIndex = -1;
                txtMoTaChiTiet.Clear();
                txtTenCT.Enabled = false;
                txtMaCT.Enabled = false;
                txtTenCT.Enabled = false;
                txtTinhTrang.Enabled = false;
                dtpNgayBatDau.Enabled = false;
                dtpNgayKetThuc.Enabled = false;
                txtDuToan.Enabled = false;
                txtChuDauTu.Enabled = false;
                txtGhiChu.Enabled = false;
                cboTinh.Enabled = false;
                cboQuanHuyen.Enabled = false;
                cboXaPhuong.Enabled = false;
                txtMoTaChiTiet.Enabled = false;

                btnAdd.Click -= btnAdd_Click;
                btnEdit.Click -= btnEdit_Click;
                dgvConstruction.CellClick -= DgvConstruction_CellClick;

            }
            else
            {
                // Kiểm tra xem có dòng nào được chọn không
                bool hasCheckedRows = false;
                foreach (DataGridViewRow row in dgvConstruction.Rows)
                {
                    if (row.Cells["dataGridViewColumnCheckBox"].Value != null &&
                        Convert.ToBoolean(row.Cells["dataGridViewColumnCheckBox"].Value))
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

                    // Tạo danh sách các ID cần xóa
                    List<int> idsToDelete = [];
                    foreach (DataGridViewRow row in dgvConstruction.Rows)
                    {
                        if (row.Cells["dataGridViewColumnCheckBox"].Value != null &&
                            Convert.ToBoolean(row.Cells["dataGridViewColumnCheckBox"].Value))
                        {
                            int id = Convert.ToInt32(row.Cells["dataGridViewColumnID"].Value);
                            idsToDelete.Add(id);
                        }
                    }

                    // Xóa từng công trình
                    int deletedCount = 0;
                    foreach (int id in idsToDelete)
                    {
                        string query = "delete from CongTrinh where ID = @ID";
                        using SqlCommand command = new(query, connection);
                        command.Parameters.AddWithValue("@ID", id);
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
            dataGridViewColumnCheckBox.Visible = false;

            // Đổi tên nút trở lại thành Xóa
            btnDelete.Text = "Xóa";

            // Đặt lại trạng thái
            isDelete = false;
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            dgvConstruction.CellClick += DgvConstruction_CellClick;
            txtTenCT.Enabled = true;
            txtMaCT.Enabled = true;
            txtTenCT.Enabled = true;
            txtTinhTrang.Enabled = true;
            dtpNgayBatDau.Enabled = true;
            dtpNgayKetThuc.Enabled = true;
            txtDuToan.Enabled = true;
            txtChuDauTu.Enabled = true;
            txtGhiChu.Enabled = true;
            cboTinh.Enabled = true;
            cboQuanHuyen.Enabled = true;
            cboXaPhuong.Enabled = true;
            txtMoTaChiTiet.Enabled = true;
            txtMaCT.Focus(); // Đặt focus vào ô nhập mã công trình

            // Làm mới datagridview để xóa các lựa chọn
            LoadConstructionData();
        }
        private void DgvConstruction_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấp vào cột checkbox không
            if (e.ColumnIndex == dataGridViewColumnCheckBox.Index && e.RowIndex >= 0)
            {
                // Đảo ngược giá trị của ô checkbox
                bool currentValue = false;
                if (dgvConstruction.Rows[e.RowIndex].Cells["dataGridViewColumnCheckBox"].Value != null)
                    currentValue = Convert.ToBoolean(dgvConstruction.Rows[e.RowIndex].Cells["dataGridViewColumnCheckBox"].Value);
                dgvConstruction.Rows[e.RowIndex].Cells["dataGridViewColumnCheckBox"].Value = !currentValue;

                // Kiểm tra xem có dòng nào được chọn không
                bool hasCheckedRows = false;
                foreach (DataGridViewRow row in dgvConstruction.Rows)
                {
                    if (row.Cells["dataGridViewColumnCheckBox"].Value != null &&
                        Convert.ToBoolean(row.Cells["dataGridViewColumnCheckBox"].Value))
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
                    dataGridViewColumnCheckBox.HeaderText = "❎";
                    dataGridViewColumnCheckBox.HeaderCell.ToolTipText = "Bỏ chọn tất cả";
                }
                else if (!hasCheckedRows && btnDelete.Text == "Xác nhận xóa")
                // Không còn dòng nào được chọn, đổi tên nút trở lại thành "Hủy xóa"
                {
                    btnDelete.Text = "Hủy xóa";
                    dataGridViewColumnCheckBox.HeaderText = "✅";
                    dataGridViewColumnCheckBox.HeaderCell.ToolTipText = "Chọn tất cả";
                }
            }

            // Kiểm tra xem người dùng có nhấp vào header của cột checkbox không
            if (e.RowIndex == -1 && e.ColumnIndex == dataGridViewColumnCheckBox.Index)
            {
                // Kiểm tra xem có dòng nào đã được chọn chưa
                bool anyChecked = false;
                foreach (DataGridViewRow row in dgvConstruction.Rows)
                {
                    if (row.Cells["dataGridViewColumnCheckBox"].Value != null &&
                        Convert.ToBoolean(row.Cells["dataGridViewColumnCheckBox"].Value))
                    {
                        anyChecked = true;
                        break;
                    }
                }

                // Chọn hoặc bỏ chọn tất cả các dòng
                bool checkValue = !anyChecked;
                foreach (DataGridViewRow row in dgvConstruction.Rows)
                    row.Cells["dataGridViewColumnCheckBox"].Value = checkValue;

                // Cập nhật tên nút
                if (checkValue)
                {
                    dataGridViewColumnCheckBox.HeaderText = "❎";
                    dataGridViewColumnCheckBox.HeaderCell.ToolTipText = "Bỏ chọn tất cả";
                    btnDelete.Text = "Xác nhận xóa";
                }
                else
                {
                    dataGridViewColumnCheckBox.HeaderText = "✅";
                    dataGridViewColumnCheckBox.HeaderCell.ToolTipText = "Chọn tất cả";
                    btnDelete.Text = "Hủy xóa";
                }
            }
        }
        private void DgvConstruction_SelectionChanged(object? sender, EventArgs e)
        {
            // Nếu cột checkbox đang hiển thị (đang ở chế độ xóa), không cho phép chọn dòng
            if (dataGridViewColumnCheckBox.Visible)
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
                    worksheet.Range(1, 1, 1, 4).Merge();
                    worksheet.Cell(1, 1).Style.Font.Bold = true;
                    worksheet.Cell(1, 1).Style.Font.FontSize = 16;
                    worksheet.Cell(1, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    // Thêm tiêu đề các cột
                    worksheet.Cell(3, 1).Value = "STT";
                    worksheet.Cell(3, 2).Value = "Tên công trình";
                    worksheet.Cell(3, 3).Value = "Địa điểm";
                    worksheet.Cell(3, 4).Value = "Năm thực hiện";

                    // Định dạng tiêu đề cột
                    var headerRange = worksheet.Range(3, 1, 3, 4);
                    headerRange.Style.Font.Bold = true;
                    headerRange.Style.Fill.BackgroundColor = XLColor.LightGray;
                    headerRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    headerRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                    headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    // Đổ dữ liệu từ DataGridView vào Excel
                    int rowCount = dgvConstruction.Rows.Count;
                    for (int i = 0; i < rowCount; i++)
                    {
                        worksheet.Cell(i + 4, 1).Value = i + 1; // STT
                        worksheet.Cell(i + 4, 2).Value = dgvConstruction.Rows[i].Cells["dataGridViewColumnName"].Value.ToString();
                        worksheet.Cell(i + 4, 3).Value = dgvConstruction.Rows[i].Cells["dataGridViewColumnLocation"].Value.ToString();
                        worksheet.Cell(i + 4, 4).Value = Convert.ToInt32(dgvConstruction.Rows[i].Cells["dataGridViewColumnYear"].Value);
                    }

                    // Định dạng dữ liệu
                    var dataRange = worksheet.Range(4, 1, dgvConstruction.Rows.Count + 3, 4);
                    dataRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    dataRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                    // Căn giữa cột STT và Năm thực hiện
                    worksheet.Column(1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    worksheet.Column(4).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

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
                    cboTinh.DisplayMember = "TenTinh";  // cột hiển thị
                    cboTinh.ValueMember = "MaTinh";     // cột giá trị 
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
    }
}
