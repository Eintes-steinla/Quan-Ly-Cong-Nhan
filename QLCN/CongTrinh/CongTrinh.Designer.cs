using System.Data;
using Microsoft.Data.SqlClient;
using QLCN.DB;
using ClosedXML.Excel;
namespace QLCN.CongTrinh
{
    partial class CongTrinh
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private Label lblName;
        private TextBox txtName;
        private Label lblYear;
        private TextBox txtYear;
        private Label lblLocation;
        private TextBox txtLocation;
        private Label lblMaCT;
        private TextBox txtMaCT;
        private Label lblTenCT;
        private TextBox txtTenCT;
        private Label lblTinhTrang;
        private TextBox txtTinhTrang;
        private Label lblNgayBatDau;
        private TextBox txtNgayBatDau;
        private Label lblNgayKetThuc;
        private TextBox txtNgayKetThuc;
        private Label lblDuToan;
        private TextBox txtDuToan;
        private Label lblChuDauTu;
        private TextBox txtChuDauTu;
        private Label lblGhiChu;
        private TextBox txtGhiChu;
        private Label lblTinh;
        private ComboBox cboTinh;
        private Label lblQuanHuyen;
        private ComboBox cboQuanHuyen;
        private Label lblXaPhuong;
        private ComboBox cboXaPhuong;
        private Label lblMoTaChiTiet;
        private TextBox txtMoTaChiTiet;
        private DateTimePicker dtpNgayBatDau;
        private DateTimePicker dtpNgayKetThuc;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnExport;
        private Panel panelFilter;
        private DataGridView dgvConstruction;
        private Label lblMessage;
        private TextBox txtFilterName;
        private TextBox txtFilterYear;
        private TextBox txtFilterLocation;
        private PictureBox pictureBoxRemoveFilter;
        private ToolTip toolTip;
        private DataGridViewTextBoxColumn dataGridViewColumnSTT;
        private DataGridViewTextBoxColumn dataGridViewColumnName;
        private DataGridViewTextBoxColumn dataGridViewColumnYear;
        private DataGridViewTextBoxColumn dataGridViewColumnLocation;
        private DataGridViewTextBoxColumn dataGridViewColumnID;
        private DataGridViewCheckBoxColumn dataGridViewColumnCheckBox;
        private System.ComponentModel.Container components;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new();
            lblMessage = new();
            btnExport = new();
            btnDelete = new();
            btnEdit = new();
            btnAdd = new();
            txtLocation = new();
            lblLocation = new();
            txtYear = new();
            lblYear = new();
            txtName = new();
            lblName = new();
            txtMaCT = new();
            lblMaCT = new();
            txtTenCT = new();
            lblTenCT = new();
            txtTinhTrang = new();
            lblTinhTrang = new();
            txtNgayBatDau = new();
            lblNgayBatDau = new();
            txtNgayKetThuc = new();
            lblNgayKetThuc = new();
            txtDuToan = new();
            lblDuToan = new();
            txtChuDauTu = new();
            lblChuDauTu = new();
            txtGhiChu = new();
            lblGhiChu = new();
            cboTinh = new();
            lblTinh = new();
            cboQuanHuyen = new();
            lblQuanHuyen = new();
            cboXaPhuong = new();
            lblXaPhuong = new();
            txtMoTaChiTiet = new();
            lblMoTaChiTiet = new();
            dtpNgayBatDau = new();
            dtpNgayKetThuc = new();
            dgvConstruction = new();
            btnRefresh = new();
            panelFilter = new();
            txtFilterName = new();
            txtFilterYear = new();
            txtFilterLocation = new();
            pictureBoxRemoveFilter = new();
            toolTip = new(components);
            dataGridViewColumnSTT = new();
            dataGridViewColumnName = new();
            dataGridViewColumnYear = new();
            dataGridViewColumnLocation = new();
            dataGridViewColumnID = new();
            dataGridViewColumnCheckBox = new();
            ((System.ComponentModel.ISupportInitialize)dgvConstruction).BeginInit();
            panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRemoveFilter).BeginInit();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.ForeColor = Color.Green;
            lblMessage.Location = new(669, 20);
            lblMessage.Margin = new(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new(0, 26);
            lblMessage.TextAlign = ContentAlignment.MiddleLeft;
            lblMessage.MaximumSize = new(500, 0);
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExport.Location = new(1043, 744);
            btnExport.Margin = new(4, 5, 4, 5);
            btnExport.Name = "btnExport";
            btnExport.Size = new(151, 36);
            btnExport.TabIndex = 11;
            btnExport.Text = "Xuất Excel";
            // 
            // btnDelete
            // 
            btnDelete.Location = new(352, 800);
            btnDelete.Margin = new(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new(160, 36);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Xóa";
            // 
            // btnEdit
            // 
            btnEdit.Location = new(192, 800);
            btnEdit.Margin = new(4, 5, 4, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new(160, 36);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Sửa";
            // 
            // btnAdd
            // 
            btnAdd.Location = new(32, 800);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new(160, 36);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Thêm";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new(513, 800);
            btnRefresh.Margin = new(4, 5, 4, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new(130, 36);
            btnRefresh.TabIndex = 18;
            btnRefresh.Text = "Làm mới";
            toolTip.SetToolTip(btnRefresh, "Xóa tất cả các ô nhập dữ liệu");
            // 
            // txtLocation
            // 
            txtLocation.Location = new(195, 70);
            txtLocation.Margin = new(4, 5, 4, 5);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new(448, 33);
            txtLocation.TabIndex = 1;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new(31, 75);
            lblLocation.Margin = new(4, 0, 4, 0);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new(103, 26);
            lblLocation.Text = "Địa điểm:";
            // 
            // txtMaCT
            // 
            txtMaCT.Location = new(195, 170);
            txtMaCT.Margin = new(4, 5, 4, 5);
            txtMaCT.Name = "txtMaCT";
            txtMaCT.Size = new(223, 33);
            txtMaCT.TabIndex = 3;
            // 
            // lblMaCT
            // 
            lblMaCT.AutoSize = true;
            lblMaCT.Location = new(31, 175);
            lblMaCT.Margin = new(4, 0, 4, 0);
            lblMaCT.Name = "lblMaCT";
            lblMaCT.Size = new(155, 26);
            lblMaCT.Text = "Mã công trình:";
            // 
            // txtTenCT
            // 
            txtTenCT.Location = new(195, 220);
            txtTenCT.Margin = new(4, 5, 4, 5);
            txtTenCT.Name = "txtTenCT";
            txtTenCT.Size = new(448, 33);
            txtTenCT.TabIndex = 4;
            // 
            // lblTenCT
            // 
            lblTenCT.AutoSize = true;
            lblTenCT.Location = new(31, 225);
            lblTenCT.Margin = new(4, 0, 4, 0);
            lblTenCT.Name = "lblTenCT";
            lblTenCT.Size = new(155, 26);
            lblTenCT.Text = "Tên công trình:";
            // 
            // txtTinhTrang
            // 
            txtTinhTrang.Location = new(195, 270);
            txtTinhTrang.Margin = new(4, 5, 4, 5);
            txtTinhTrang.Name = "txtTinhTrang";
            txtTinhTrang.Size = new(223, 33);
            txtTinhTrang.TabIndex = 5;
            // 
            // lblTinhTrang
            // 
            lblTinhTrang.AutoSize = true;
            lblTinhTrang.Location = new(31, 275);
            lblTinhTrang.Margin = new(4, 0, 4, 0);
            lblTinhTrang.Name = "lblTinhTrang";
            lblTinhTrang.Size = new(103, 26);
            lblTinhTrang.Text = "Tình trạng:";
            // 
            // lblNgayBatDau
            // 
            lblNgayBatDau.AutoSize = true;
            lblNgayBatDau.Location = new(31, 325);
            lblNgayBatDau.Margin = new(4, 0, 4, 0);
            lblNgayBatDau.Name = "lblNgayBatDau";
            lblNgayBatDau.Size = new(155, 26);
            lblNgayBatDau.Text = "Ngày bắt đầu:";
            // 
            // lblNgayKetThuc
            // 
            lblNgayKetThuc.AutoSize = true;
            lblNgayKetThuc.Location = new(31, 375);
            lblNgayKetThuc.Margin = new(4, 0, 4, 0);
            lblNgayKetThuc.Name = "lblNgayKetThuc";
            lblNgayKetThuc.Size = new(155, 26);
            lblNgayKetThuc.Text = "Ngày kết thúc:";
            // 
            // txtDuToan
            // 
            txtDuToan.Location = new(195, 420);
            txtDuToan.Margin = new(4, 5, 4, 5);
            txtDuToan.Name = "txtDuToan";
            txtDuToan.Size = new(223, 33);
            txtDuToan.TabIndex = 8;
            // 
            // lblDuToan
            // 
            lblDuToan.AutoSize = true;
            lblDuToan.Location = new(31, 425);
            lblDuToan.Margin = new(4, 0, 4, 0);
            lblDuToan.Name = "lblDuToan";
            lblDuToan.Size = new(103, 26);
            lblDuToan.Text = "Dự toán:";
            // 
            // txtChuDauTu
            // 
            txtChuDauTu.Location = new(195, 470);
            txtChuDauTu.Margin = new(4, 5, 4, 5);
            txtChuDauTu.Name = "txtChuDauTu";
            txtChuDauTu.Size = new(448, 33);
            txtChuDauTu.TabIndex = 9;
            // 
            // lblChuDauTu
            // 
            lblChuDauTu.AutoSize = true;
            lblChuDauTu.Location = new(31, 475);
            lblChuDauTu.Margin = new(4, 0, 4, 0);
            lblChuDauTu.Name = "lblChuDauTu";
            lblChuDauTu.Size = new(103, 26);
            lblChuDauTu.Text = "Chủ đầu tư:";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new(195, 520);
            txtGhiChu.Margin = new(4, 5, 4, 5);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new(448, 33);
            txtGhiChu.TabIndex = 10;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new(31, 525);
            lblGhiChu.Margin = new(4, 0, 4, 0);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new(103, 26);
            lblGhiChu.Text = "Ghi chú:";
            // 
            // cboTinh
            // 
            cboTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTinh.Location = new(195, 570);
            cboTinh.Margin = new(4, 5, 4, 5);
            cboTinh.Name = "cboTinh";
            cboTinh.Size = new(223, 33);
            cboTinh.TabIndex = 11;
            // 
            // lblTinh
            // 
            lblTinh.AutoSize = true;
            lblTinh.Location = new(31, 575);
            lblTinh.Margin = new(4, 0, 4, 0);
            lblTinh.Name = "lblTinh";
            lblTinh.Size = new(103, 26);
            lblTinh.Text = "Tỉnh/TP:";
            // 
            // cboQuanHuyen
            // 
            cboQuanHuyen.DropDownStyle = ComboBoxStyle.DropDownList;
            cboQuanHuyen.Location = new(195, 620);
            cboQuanHuyen.Margin = new(4, 5, 4, 5);
            cboQuanHuyen.Name = "cboQuanHuyen";
            cboQuanHuyen.Size = new(223, 33);
            cboQuanHuyen.TabIndex = 12;
            // 
            // lblQuanHuyen
            // 
            lblQuanHuyen.AutoSize = true;
            lblQuanHuyen.Location = new(31, 625);
            lblQuanHuyen.Margin = new(4, 0, 4, 0);
            lblQuanHuyen.Name = "lblQuanHuyen";
            lblQuanHuyen.Size = new(155, 26);
            lblQuanHuyen.Text = "Quận/Huyện:";
            // 
            // cboXaPhuong
            // 
            cboXaPhuong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboXaPhuong.Location = new(195, 670);
            cboXaPhuong.Margin = new(4, 5, 4, 5);
            cboXaPhuong.Name = "cboXaPhuong";
            cboXaPhuong.Size = new(223, 33);
            cboXaPhuong.TabIndex = 13;
            // 
            // lblXaPhuong
            // 
            lblXaPhuong.AutoSize = true;
            lblXaPhuong.Location = new(31, 675);
            lblXaPhuong.Margin = new(4, 0, 4, 0);
            lblXaPhuong.Name = "lblXaPhuong";
            lblXaPhuong.Size = new(155, 26);
            lblXaPhuong.Text = "Xã/Phường:";
            // 
            // txtMoTaChiTiet
            // 
            txtMoTaChiTiet.Location = new(195, 720);
            txtMoTaChiTiet.Margin = new(4, 5, 4, 5);
            txtMoTaChiTiet.Multiline = true;
            txtMoTaChiTiet.Name = "txtMoTaChiTiet";
            txtMoTaChiTiet.ScrollBars = ScrollBars.Vertical;
            txtMoTaChiTiet.Size = new(448, 60);
            txtMoTaChiTiet.TabIndex = 14;
            // 
            // lblMoTaChiTiet
            // 
            lblMoTaChiTiet.AutoSize = true;
            lblMoTaChiTiet.Location = new(31, 725);
            lblMoTaChiTiet.Margin = new(4, 0, 4, 0);
            lblMoTaChiTiet.Name = "lblMoTaChiTiet";
            lblMoTaChiTiet.Size = new(207, 26);
            lblMoTaChiTiet.Text = "Mô tả chi tiết địa điểm:";
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Format = DateTimePickerFormat.Short;
            dtpNgayBatDau.Location = new(195, 320);
            dtpNgayBatDau.Margin = new(4, 5, 4, 5);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new(223, 33);
            dtpNgayBatDau.TabIndex = 6;
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.Format = DateTimePickerFormat.Short;
            dtpNgayKetThuc.Location = new(195, 370);
            dtpNgayKetThuc.Margin = new(4, 5, 4, 5);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new(223, 33);
            dtpNgayKetThuc.TabIndex = 7;
            // 
            // txtYear
            // 
            txtYear.Location = new(195, 120);
            txtYear.Margin = new(4, 5, 4, 5);
            txtYear.Name = "txtYear";
            txtYear.Size = new(223, 33);
            txtYear.TabIndex = 2;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new(31, 125);
            lblYear.Margin = new(4, 0, 4, 0);
            lblYear.Name = "lblYear";
            lblYear.Size = new(154, 26);
            lblYear.Text = "Năm thực hiện:";
            // 
            // txtName
            // 
            txtName.Location = new(195, 20);
            txtName.Margin = new(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new(448, 33);
            txtName.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new(31, 25);
            lblName.Margin = new(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new(155, 26);
            lblName.Text = "Tên công trình:";
            // 
            // dgvConstruction
            // 
            dgvConstruction.AllowUserToAddRows = false;
            dgvConstruction.AllowUserToDeleteRows = false;
            dgvConstruction.AllowUserToOrderColumns = true;
            dgvConstruction.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvConstruction.BackgroundColor = Color.White;
            dgvConstruction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConstruction.Columns.AddRange([dataGridViewColumnSTT, dataGridViewColumnName, dataGridViewColumnLocation, dataGridViewColumnYear, dataGridViewColumnID, dataGridViewColumnCheckBox]);
            dgvConstruction.Location = new(31, 850);
            dgvConstruction.Margin = new(4, 5, 4, 5);
            dgvConstruction.Name = "dgvConstruction";
            dgvConstruction.ReadOnly = true;
            dgvConstruction.Size = new(1163, 449);
            // 
            // dataGridViewColumnSTT
            // 
            dataGridViewColumnSTT.HeaderText = "STT";
            dataGridViewColumnSTT.Name = "dataGridViewColumnSTT";
            dataGridViewColumnSTT.ReadOnly = true;
            dataGridViewColumnSTT.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewColumnSTT.Width = 80;
            // 
            // dataGridViewColumnName
            // 
            dataGridViewColumnName.HeaderText = "Tên công trình";
            dataGridViewColumnName.Name = "dataGridViewColumnName";
            dataGridViewColumnName.ReadOnly = true;
            dataGridViewColumnName.MinimumWidth = 405;
            // 
            // dataGridViewColumnYear
            // 
            dataGridViewColumnYear.HeaderText = "Năm thực hiện";
            dataGridViewColumnYear.Name = "dataGridViewColumnYear";
            dataGridViewColumnYear.ReadOnly = true;
            dataGridViewColumnYear.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewColumnYear.MinimumWidth = 175;
            // 
            // dataGridViewColumnLocation
            // 
            dataGridViewColumnLocation.HeaderText = "Địa điểm";
            dataGridViewColumnLocation.Name = "dataGridViewColumnLocation";
            dataGridViewColumnLocation.ReadOnly = true;
            dataGridViewColumnLocation.MinimumWidth = 405;
            //
            // dataGridViewColumnID
            //
            dataGridViewColumnID.Name = "dataGridViewColumnID";
            dataGridViewColumnID.ReadOnly = true;
            dataGridViewColumnID.Visible = false;
            //
            // dataGridViewColumnCheckBox
            //
            dataGridViewColumnCheckBox.HeaderText = "✅";
            dataGridViewColumnCheckBox.Name = "dataGridViewColumnCheckBox";
            dataGridViewColumnCheckBox.ReadOnly = false;
            dataGridViewColumnCheckBox.Visible = false;
            dataGridViewColumnCheckBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewColumnCheckBox.HeaderCell.ToolTipText = "Chọn tất cả";


            //

            // Giữ lại các cột đã định nghĩa
            dgvConstruction.AutoGenerateColumns = false;
            dgvConstruction.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvConstruction.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConstruction.DefaultCellStyle.SelectionBackColor = Color.AntiqueWhite;
            dgvConstruction.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Ánh xạ các cột đã định nghĩa với dữ liệu
            dataGridViewColumnSTT.DataPropertyName = "STT";
            dataGridViewColumnName.DataPropertyName = "Name";
            dataGridViewColumnYear.DataPropertyName = "Year";
            dataGridViewColumnLocation.DataPropertyName = "Location";
            dataGridViewColumnID.DataPropertyName = "ID";
            dataGridViewColumnCheckBox.DataPropertyName = "";

            // Căn giữa tiêu đề các cột
            dgvConstruction.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 
            // panelFilter
            // 
            panelFilter.BackColor = Color.WhiteSmoke;
            panelFilter.BorderStyle = BorderStyle.FixedSingle;
            panelFilter.Controls.Add(txtFilterName);
            panelFilter.Controls.Add(txtFilterYear);
            panelFilter.Controls.Add(txtFilterLocation);
            panelFilter.Controls.Add(pictureBoxRemoveFilter);
            panelFilter.Location = new(31, 805);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new(1163, 45);
            // 
            // txtFilterName
            // 
            txtFilterName.Font = new("Times New Roman", 13.2000008F);
            txtFilterName.Location = new(130, 5);
            txtFilterName.Name = "txtFilterName";
            txtFilterName.PlaceholderText = "Tìm theo tên công trình...";
            txtFilterName.Size = new(405, 33);
            txtFilterName.TabIndex = 7;
            // 
            // txtFilterYear
            // 
            txtFilterYear.Font = new("Times New Roman", 13.2000008F);
            txtFilterYear.Location = new(943, 5);
            txtFilterYear.Name = "txtFilterYear";
            txtFilterYear.PlaceholderText = "Tìm theo năm...";
            txtFilterYear.Size = new(175, 33);
            txtFilterYear.TabIndex = 9;
            // 
            // txtFilterLocation
            // 
            txtFilterLocation.Font = new("Times New Roman", 13.2000008F);
            txtFilterLocation.Location = new(536, 5);
            txtFilterLocation.Name = "txtFilterLocation";
            txtFilterLocation.PlaceholderText = "Tìm theo địa điểm...";
            txtFilterLocation.Size = new(405, 33);
            txtFilterLocation.TabIndex = 8;
            // 
            // pictureBoxRemoveFilter
            // 
            // pictureBoxRemoveFilter.BackColor = Color.Transparent;
            pictureBoxRemoveFilter.Cursor = Cursors.Hand;
            pictureBoxRemoveFilter.Image = Properties.Resources.images;
            pictureBoxRemoveFilter.Location = new(0, 5);
            pictureBoxRemoveFilter.Name = "pictureBoxRemoveFilter";
            pictureBoxRemoveFilter.Size = new(33, 33);
            pictureBoxRemoveFilter.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxRemoveFilter.TabIndex = 10;
            pictureBoxRemoveFilter.TabStop = false;
            pictureBoxRemoveFilter.BackColor = Color.Transparent;
            pictureBoxRemoveFilter.Visible = true;
            pictureBoxRemoveFilter.BringToFront();
            toolTip.SetToolTip(pictureBoxRemoveFilter, "Xóa tất cả bộ lọc");


            // 
            // ConstructionUserControl
            // 
            AutoScaleDimensions = new(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblMessage);
            Controls.Add(btnExport);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtLocation);
            Controls.Add(lblLocation);
            Controls.Add(txtYear);
            Controls.Add(lblYear);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(txtMaCT);
            Controls.Add(lblMaCT);
            Controls.Add(txtTenCT);
            Controls.Add(lblTenCT);
            Controls.Add(txtTinhTrang);
            Controls.Add(lblTinhTrang);
            Controls.Add(txtNgayBatDau);
            Controls.Add(lblNgayBatDau);
            Controls.Add(txtNgayKetThuc);
            Controls.Add(lblNgayKetThuc);
            Controls.Add(txtDuToan);
            Controls.Add(lblDuToan);
            Controls.Add(txtChuDauTu);
            Controls.Add(lblChuDauTu);
            Controls.Add(txtGhiChu);
            Controls.Add(lblGhiChu);
            Controls.Add(cboTinh);
            Controls.Add(lblTinh);
            Controls.Add(cboQuanHuyen);
            Controls.Add(lblQuanHuyen);
            Controls.Add(cboXaPhuong);
            Controls.Add(lblXaPhuong);
            Controls.Add(txtMoTaChiTiet);
            Controls.Add(lblMoTaChiTiet);
            Controls.Add(dtpNgayBatDau);
            Controls.Add(dtpNgayKetThuc);
            Controls.Add(dgvConstruction);
            Controls.Add(btnRefresh);
            Controls.Add(panelFilter);
            Font = new("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new(4, 5, 4, 5);
            Name = "ConstructionUserControl";
            Size = new(1228, 1320);
            ((System.ComponentModel.ISupportInitialize)dgvConstruction).EndInit();
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRemoveFilter).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
    }
}
