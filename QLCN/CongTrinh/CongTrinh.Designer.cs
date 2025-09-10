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
        private Label lblMaCT;
        private TextBox txtMaCT;
        private Label lblTenCT;
        private TextBox txtTenCT;
        private Label lblTinhTrang;
        private TextBox txtTinhTrang;
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
        private Label lblNgayBatDau;
        private Label lblNgayKetThuc;
        private DateTimePicker dtpNgayBatDau;
        private DateTimePicker dtpNgayKetThuc;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private Panel panelFilter;
        private DataGridView dgvConstruction;
        private Label lblMessage;
        private TextBox txtFilterMaCT;
        private TextBox txtFilterTinhTrang;
        private TextBox txtFilterTenCT;
        private PictureBox pictureBoxRemoveFilter;
        private ToolTip toolTip;
        private DataGridViewTextBoxColumn dataGridViewColumnID;


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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CongTrinh));
            lblMessage = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            txtMaCT = new TextBox();
            lblMaCT = new Label();
            txtTenCT = new TextBox();
            lblTenCT = new Label();
            txtTinhTrang = new TextBox();
            lblTinhTrang = new Label();
            dtpNgayBatDau = new DateTimePicker();
            lblNgayBatDau = new Label();
            dtpNgayKetThuc = new DateTimePicker();
            lblNgayKetThuc = new Label();
            txtDuToan = new TextBox();
            lblDuToan = new Label();
            txtChuDauTu = new TextBox();
            lblChuDauTu = new Label();
            txtGhiChu = new TextBox();
            lblGhiChu = new Label();
            cboTinh = new ComboBox();
            lblTinh = new Label();
            cboQuanHuyen = new ComboBox();
            lblQuanHuyen = new Label();
            cboXaPhuong = new ComboBox();
            lblXaPhuong = new Label();
            txtMoTaChiTiet = new TextBox();
            lblMoTaChiTiet = new Label();
            dgvConstruction = new DataGridView();
            dgvColSTT = new DataGridViewTextBoxColumn();
            dgvColMaCT = new DataGridViewTextBoxColumn();
            dgvColTenCongTrinh = new DataGridViewTextBoxColumn();
            dgvColTinhTrang = new DataGridViewTextBoxColumn();
            dgvColChuDauTu = new DataGridViewTextBoxColumn();
            dgvColDiaDiem = new DataGridViewTextBoxColumn();
            dgvColDuToan = new DataGridViewTextBoxColumn();
            dgvColNgayBatDau = new DataGridViewTextBoxColumn();
            dgvColNgayKetThuc = new DataGridViewTextBoxColumn();
            dgvColGhiChu = new DataGridViewTextBoxColumn();
            dgvColCheckBox = new DataGridViewCheckBoxColumn();
            btnRefresh = new Button();
            panelFilter = new Panel();
            txtFilterGhiChu = new TextBox();
            txtFilterDuToan = new TextBox();
            txtFilterDiaDiem = new TextBox();
            txtFilterChuDauTu = new TextBox();
            txtFilterMaCT = new TextBox();
            txtFilterTinhTrang = new TextBox();
            txtFilterTenCT = new TextBox();
            pictureBoxRemoveFilter = new PictureBox();
            toolTip = new ToolTip(components);
            panel1 = new Panel();
            panel2 = new Panel();
            btnExport = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            dtpFilterNgayBatDau = new DateTimePicker();
            dtpFilterNgayKetThuc = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvConstruction).BeginInit();
            panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRemoveFilter).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.ForeColor = Color.Green;
            lblMessage.Location = new Point(50, 10);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.MaximumSize = new Size(1800, 30);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(1800, 30);
            lblMessage.TabIndex = 0;
            lblMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(550, 23);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 50);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(300, 23);
            btnEdit.Margin = new Padding(4, 5, 4, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 50);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(50, 23);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 50);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtMaCT
            // 
            txtMaCT.Location = new Point(300, 23);
            txtMaCT.Margin = new Padding(4, 5, 4, 5);
            txtMaCT.Name = "txtMaCT";
            txtMaCT.Size = new Size(300, 33);
            txtMaCT.TabIndex = 3;
            // 
            // lblMaCT
            // 
            lblMaCT.AutoSize = true;
            lblMaCT.Location = new Point(50, 23);
            lblMaCT.Margin = new Padding(4, 0, 4, 0);
            lblMaCT.Name = "lblMaCT";
            lblMaCT.Size = new Size(139, 25);
            lblMaCT.TabIndex = 1;
            lblMaCT.Text = "Mã công trình:";
            // 
            // txtTenCT
            // 
            txtTenCT.Location = new Point(300, 73);
            txtTenCT.Margin = new Padding(4, 5, 4, 5);
            txtTenCT.Name = "txtTenCT";
            txtTenCT.Size = new Size(300, 33);
            txtTenCT.TabIndex = 4;
            // 
            // lblTenCT
            // 
            lblTenCT.AutoSize = true;
            lblTenCT.Location = new Point(50, 73);
            lblTenCT.Margin = new Padding(4, 0, 4, 0);
            lblTenCT.Name = "lblTenCT";
            lblTenCT.Size = new Size(144, 25);
            lblTenCT.TabIndex = 2;
            lblTenCT.Text = "Tên công trình:";
            // 
            // txtTinhTrang
            // 
            txtTinhTrang.Location = new Point(300, 123);
            txtTinhTrang.Margin = new Padding(4, 5, 4, 5);
            txtTinhTrang.Name = "txtTinhTrang";
            txtTinhTrang.Size = new Size(300, 33);
            txtTinhTrang.TabIndex = 5;
            // 
            // lblTinhTrang
            // 
            lblTinhTrang.AutoSize = true;
            lblTinhTrang.Location = new Point(50, 123);
            lblTinhTrang.Margin = new Padding(4, 0, 4, 0);
            lblTinhTrang.Name = "lblTinhTrang";
            lblTinhTrang.Size = new Size(107, 25);
            lblTinhTrang.TabIndex = 3;
            lblTinhTrang.Text = "Tình trạng:";
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Format = DateTimePickerFormat.Short;
            dtpNgayBatDau.Location = new Point(1550, 23);
            dtpNgayBatDau.Margin = new Padding(4, 5, 4, 5);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(300, 33);
            dtpNgayBatDau.TabIndex = 6;
            // 
            // lblNgayBatDau
            // 
            lblNgayBatDau.AutoSize = true;
            lblNgayBatDau.Location = new Point(1300, 23);
            lblNgayBatDau.Margin = new Padding(4, 0, 4, 0);
            lblNgayBatDau.Name = "lblNgayBatDau";
            lblNgayBatDau.Size = new Size(136, 25);
            lblNgayBatDau.TabIndex = 4;
            lblNgayBatDau.Text = "Ngày bắt đầu:";
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.Format = DateTimePickerFormat.Short;
            dtpNgayKetThuc.Location = new Point(1550, 73);
            dtpNgayKetThuc.Margin = new Padding(4, 5, 4, 5);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(300, 33);
            dtpNgayKetThuc.TabIndex = 7;
            // 
            // lblNgayKetThuc
            // 
            lblNgayKetThuc.AutoSize = true;
            lblNgayKetThuc.Location = new Point(1300, 73);
            lblNgayKetThuc.Margin = new Padding(4, 0, 4, 0);
            lblNgayKetThuc.Name = "lblNgayKetThuc";
            lblNgayKetThuc.Size = new Size(141, 25);
            lblNgayKetThuc.TabIndex = 5;
            lblNgayKetThuc.Text = "Ngày kết thúc:";
            // 
            // txtDuToan
            // 
            txtDuToan.Location = new Point(1550, 123);
            txtDuToan.Margin = new Padding(4, 5, 4, 5);
            txtDuToan.Name = "txtDuToan";
            txtDuToan.Size = new Size(300, 33);
            txtDuToan.TabIndex = 8;
            // 
            // lblDuToan
            // 
            lblDuToan.AutoSize = true;
            lblDuToan.Location = new Point(1300, 123);
            lblDuToan.Margin = new Padding(4, 0, 4, 0);
            lblDuToan.Name = "lblDuToan";
            lblDuToan.Size = new Size(89, 25);
            lblDuToan.TabIndex = 6;
            lblDuToan.Text = "Dự toán:";
            // 
            // txtChuDauTu
            // 
            txtChuDauTu.Location = new Point(300, 173);
            txtChuDauTu.Margin = new Padding(4, 5, 4, 5);
            txtChuDauTu.Name = "txtChuDauTu";
            txtChuDauTu.Size = new Size(300, 33);
            txtChuDauTu.TabIndex = 9;
            // 
            // lblChuDauTu
            // 
            lblChuDauTu.AutoSize = true;
            lblChuDauTu.Location = new Point(50, 173);
            lblChuDauTu.Margin = new Padding(4, 0, 4, 0);
            lblChuDauTu.Name = "lblChuDauTu";
            lblChuDauTu.Size = new Size(116, 25);
            lblChuDauTu.TabIndex = 7;
            lblChuDauTu.Text = "Chủ đầu tư:";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(1550, 173);
            txtGhiChu.Margin = new Padding(4, 5, 4, 5);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(300, 33);
            txtGhiChu.TabIndex = 10;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(1300, 173);
            lblGhiChu.Margin = new Padding(4, 0, 4, 0);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(87, 25);
            lblGhiChu.TabIndex = 8;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // cboTinh
            // 
            cboTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTinh.Location = new Point(900, 23);
            cboTinh.Margin = new Padding(4, 5, 4, 5);
            cboTinh.Name = "cboTinh";
            cboTinh.Size = new Size(300, 33);
            cboTinh.TabIndex = 11;
            cboTinh.SelectedIndexChanged += cboTinh_SelectedIndexChanged;
            // 
            // lblTinh
            // 
            lblTinh.AutoSize = true;
            lblTinh.Location = new Point(700, 23);
            lblTinh.Margin = new Padding(4, 0, 4, 0);
            lblTinh.Name = "lblTinh";
            lblTinh.Size = new Size(90, 25);
            lblTinh.TabIndex = 9;
            lblTinh.Text = "Tỉnh/TP:";
            // 
            // cboQuanHuyen
            // 
            cboQuanHuyen.DropDownStyle = ComboBoxStyle.DropDownList;
            cboQuanHuyen.Location = new Point(900, 73);
            cboQuanHuyen.Margin = new Padding(4, 5, 4, 5);
            cboQuanHuyen.Name = "cboQuanHuyen";
            cboQuanHuyen.Size = new Size(300, 33);
            cboQuanHuyen.TabIndex = 12;
            cboQuanHuyen.SelectedIndexChanged += cboQuanHuyen_SelectedIndexChanged;
            // 
            // lblQuanHuyen
            // 
            lblQuanHuyen.AutoSize = true;
            lblQuanHuyen.Location = new Point(700, 73);
            lblQuanHuyen.Margin = new Padding(4, 0, 4, 0);
            lblQuanHuyen.Name = "lblQuanHuyen";
            lblQuanHuyen.Size = new Size(128, 25);
            lblQuanHuyen.TabIndex = 10;
            lblQuanHuyen.Text = "Quận/Huyện:";
            // 
            // cboXaPhuong
            // 
            cboXaPhuong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboXaPhuong.Location = new Point(900, 123);
            cboXaPhuong.Margin = new Padding(4, 5, 4, 5);
            cboXaPhuong.Name = "cboXaPhuong";
            cboXaPhuong.Size = new Size(300, 33);
            cboXaPhuong.TabIndex = 13;
            // 
            // lblXaPhuong
            // 
            lblXaPhuong.AutoSize = true;
            lblXaPhuong.Location = new Point(700, 123);
            lblXaPhuong.Margin = new Padding(4, 0, 4, 0);
            lblXaPhuong.Name = "lblXaPhuong";
            lblXaPhuong.Size = new Size(115, 25);
            lblXaPhuong.TabIndex = 11;
            lblXaPhuong.Text = "Xã/Phường:";
            // 
            // txtMoTaChiTiet
            // 
            txtMoTaChiTiet.Location = new Point(900, 173);
            txtMoTaChiTiet.Margin = new Padding(4, 5, 4, 5);
            txtMoTaChiTiet.Multiline = true;
            txtMoTaChiTiet.Name = "txtMoTaChiTiet";
            txtMoTaChiTiet.ScrollBars = ScrollBars.Vertical;
            txtMoTaChiTiet.Size = new Size(300, 70);
            txtMoTaChiTiet.TabIndex = 14;
            // 
            // lblMoTaChiTiet
            // 
            lblMoTaChiTiet.AutoSize = true;
            lblMoTaChiTiet.Location = new Point(700, 173);
            lblMoTaChiTiet.Margin = new Padding(4, 0, 4, 0);
            lblMoTaChiTiet.Name = "lblMoTaChiTiet";
            lblMoTaChiTiet.Size = new Size(152, 25);
            lblMoTaChiTiet.TabIndex = 12;
            lblMoTaChiTiet.Text = "Mô tả địa điểm:";
            // 
            // dgvConstruction
            // 
            dgvConstruction.AllowUserToAddRows = false;
            dgvConstruction.AllowUserToDeleteRows = false;
            dgvConstruction.AllowUserToOrderColumns = true;
            dgvConstruction.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvConstruction.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvConstruction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvConstruction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConstruction.Columns.AddRange(new DataGridViewColumn[] { dgvColSTT, dgvColMaCT, dgvColTenCongTrinh, dgvColTinhTrang, dgvColChuDauTu, dgvColDiaDiem, dgvColDuToan, dgvColNgayBatDau, dgvColNgayKetThuc, dgvColGhiChu, dataGridViewColumnCheckBox });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.AntiqueWhite;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvConstruction.DefaultCellStyle = dataGridViewCellStyle2;
            dgvConstruction.Location = new Point(0, 38);
            dgvConstruction.Margin = new Padding(4, 5, 4, 5);
            dgvConstruction.Name = "dgvConstruction";
            dgvConstruction.ReadOnly = true;
            dgvConstruction.RowHeadersWidth = 51;
            dgvConstruction.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConstruction.Size = new Size(1884, 463);
            dgvConstruction.TabIndex = 19;
            // 
            // dgvColSTT
            // 
            dgvColSTT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColSTT.HeaderText = "STT";
            dgvColSTT.MinimumWidth = 8;
            dgvColSTT.Name = "STT";
            dgvColSTT.ReadOnly = true;
            dgvColSTT.Width = 60;
            dgvColSTT.DataPropertyName = "STT";
            // 
            // dgvColMaCT
            // 
            dgvColMaCT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColMaCT.HeaderText = "Mã CT";
            dgvColMaCT.MinimumWidth = 8;
            dgvColMaCT.Name = "mact";
            dgvColMaCT.ReadOnly = true;
            dgvColMaCT.Width = 150;
            dgvColMaCT.DataPropertyName = "mact";
            // 
            // dgvColTenCongTrinh
            // 
            dgvColTenCongTrinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColTenCongTrinh.HeaderText = "Tên CT";
            dgvColTenCongTrinh.MinimumWidth = 8;
            dgvColTenCongTrinh.Name = "tenct";
            dgvColTenCongTrinh.ReadOnly = true;
            dgvColTenCongTrinh.Width = 140;
            dgvColTenCongTrinh.DataPropertyName = "tenct";
            // 
            // dgvColTinhTrang
            // 
            dgvColTinhTrang.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColTinhTrang.HeaderText = "Tình trạng";
            dgvColTinhTrang.MinimumWidth = 8;
            dgvColTinhTrang.Name = "tinhtrang";
            dgvColTinhTrang.ReadOnly = true;
            dgvColTinhTrang.Width = 180;
            dgvColTinhTrang.DataPropertyName = "tinhtrang";
            // 
            // dgvColChuDauTu
            // 
            dgvColChuDauTu.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColChuDauTu.HeaderText = "Chủ đầu tư";
            dgvColChuDauTu.MinimumWidth = 8;
            dgvColChuDauTu.Name = "chudautu";
            dgvColChuDauTu.ReadOnly = true;
            dgvColChuDauTu.Width = 270;
            dgvColChuDauTu.DataPropertyName = "chudautu";
            // 
            // dgvColDiaDiem
            // 
            dgvColDiaDiem.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColDiaDiem.HeaderText = "Địa điểm";
            dgvColDiaDiem.MinimumWidth = 8;
            dgvColDiaDiem.Name = "diadiem";
            dgvColDiaDiem.ReadOnly = true;
            dgvColDiaDiem.Width = 270;
            dgvColDiaDiem.DataPropertyName = "diadiem";
            // 
            // dgvColDuToan
            // 
            dgvColDuToan.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColDuToan.HeaderText = "Dự toán";
            dgvColDuToan.MinimumWidth = 8;
            dgvColDuToan.Name = "dutoan";
            dgvColDuToan.ReadOnly = true;
            dgvColDuToan.Width = 160;
            dgvColDuToan.DataPropertyName = "dutoan";
            // 
            // dgvColNgayBatDau
            // 
            dgvColNgayBatDau.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColNgayBatDau.HeaderText = "Ngày bắt đầu";
            dgvColNgayBatDau.MinimumWidth = 8;
            dgvColNgayBatDau.Name = "ngaybatdau";
            dgvColNgayBatDau.ReadOnly = true;
            dgvColNgayBatDau.Width = 200;
            dgvColNgayBatDau.DataPropertyName = "ngaybatdau";
            // 
            // dgvColNgayKetThuc
            // 
            dgvColNgayKetThuc.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColNgayKetThuc.HeaderText = "Ngày kết thúc";
            dgvColNgayKetThuc.MinimumWidth = 8;
            dgvColNgayKetThuc.Name = "ngayketthuc";
            dgvColNgayKetThuc.ReadOnly = true;
            dgvColNgayKetThuc.Width = 200;
            dgvColNgayKetThuc.DataPropertyName = "ngayketthuc";
            // 
            // dgvColGhiChu
            // 
            dgvColGhiChu.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColGhiChu.HeaderText = "Ghi chú";
            dgvColGhiChu.MinimumWidth = 8;
            dgvColGhiChu.Name = "ghichu";
            dgvColGhiChu.ReadOnly = true;
            dgvColGhiChu.Width = 150;
            dgvColGhiChu.DataPropertyName = "ghichu";
            // 
            // dgvColCheckBox
            // 
            dgvColCheckBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvColCheckBox.HeaderText = "✅";
            dgvColCheckBox.MinimumWidth = 6;
            dgvColCheckBox.Name = "checkbox";
            dgvColCheckBox.ReadOnly = true;
            dgvColCheckBox.Width = 43;
            dgvColCheckBox.Visible = false;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(800, 23);
            btnRefresh.Margin = new Padding(4, 5, 4, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(150, 50);
            btnRefresh.TabIndex = 18;
            btnRefresh.Text = "Làm mới";
            toolTip.SetToolTip(btnRefresh, "Xóa tất cả các ô nhập dữ liệu");
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // panelFilter
            // 
            panelFilter.BackColor = Color.WhiteSmoke;
            panelFilter.BorderStyle = BorderStyle.FixedSingle;
            panelFilter.Controls.Add(dtpFilterNgayKetThuc);
            panelFilter.Controls.Add(dtpFilterNgayBatDau);
            panelFilter.Controls.Add(txtFilterGhiChu);
            panelFilter.Controls.Add(txtFilterDuToan);
            panelFilter.Controls.Add(txtFilterDiaDiem);
            panelFilter.Controls.Add(txtFilterChuDauTu);
            panelFilter.Controls.Add(txtFilterMaCT);
            panelFilter.Controls.Add(txtFilterTinhTrang);
            panelFilter.Controls.Add(txtFilterTenCT);
            panelFilter.Controls.Add(pictureBoxRemoveFilter);
            panelFilter.Location = new Point(0, 0);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(1884, 38);
            panelFilter.TabIndex = 20;
            // 
            // txtFilterGhiChu
            // 
            txtFilterGhiChu.Location = new Point(1680, 0);
            txtFilterGhiChu.Name = "txtFilterGhiChu";
            txtFilterGhiChu.PlaceholderText = "GhiChu";
            txtFilterGhiChu.Size = new Size(150, 38);
            txtFilterGhiChu.TabIndex = 16;
            txtFilterGhiChu.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFilterDuToan
            // 
            txtFilterDuToan.Location = new Point(1120, 0);
            txtFilterDuToan.Name = "txtFilterDuToan";
            txtFilterDuToan.PlaceholderText = "DuToan";
            txtFilterDuToan.Size = new Size(160, 38);
            txtFilterDuToan.TabIndex = 13;
            txtFilterDuToan.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFilterDiaDiem
            // 
            txtFilterDiaDiem.Location = new Point(850, 0);
            txtFilterDiaDiem.Name = "txtFilterDiaDiem";
            txtFilterDiaDiem.PlaceholderText = "DiaDiem";
            txtFilterDiaDiem.Size = new Size(270, 38);
            txtFilterDiaDiem.TabIndex = 12;
            txtFilterDiaDiem.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFilterChuDauTu
            // 
            txtFilterChuDauTu.Location = new Point(580, 0);
            txtFilterChuDauTu.Name = "txtFilterChuDauTu";
            txtFilterChuDauTu.PlaceholderText = "ChuDauTu";
            txtFilterChuDauTu.Size = new Size(270, 38);
            txtFilterChuDauTu.TabIndex = 11;
            txtFilterChuDauTu.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFilterMaCT
            // 
            txtFilterMaCT.Font = new Font("Times New Roman", 13.2F);
            txtFilterMaCT.Location = new Point(110, 0);
            txtFilterMaCT.Name = "txtFilterMaCT";
            txtFilterMaCT.PlaceholderText = "MaCT";
            txtFilterMaCT.Size = new Size(150, 38);
            txtFilterMaCT.TabIndex = 7;
            txtFilterMaCT.TextAlign = HorizontalAlignment.Center;
            txtFilterMaCT.TextChanged += txtFilterName_TextChanged;
            // 
            // txtFilterTinhTrang
            // 
            txtFilterTinhTrang.Font = new Font("Times New Roman", 13.2F);
            txtFilterTinhTrang.Location = new Point(400, 0);
            txtFilterTinhTrang.Name = "txtFilterTinhTrang";
            txtFilterTinhTrang.PlaceholderText = "TinhTrang";
            txtFilterTinhTrang.Size = new Size(180, 38);
            txtFilterTinhTrang.TabIndex = 9;
            txtFilterTinhTrang.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFilterTenCT
            // 
            txtFilterTenCT.Font = new Font("Times New Roman", 13.2F);
            txtFilterTenCT.Location = new Point(260, 0);
            txtFilterTenCT.Name = "txtFilterTenCT";
            txtFilterTenCT.PlaceholderText = "TenCT";
            txtFilterTenCT.Size = new Size(140, 38);
            txtFilterTenCT.TabIndex = 8;
            txtFilterTenCT.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBoxRemoveFilter
            // 
            pictureBoxRemoveFilter.BackColor = Color.Transparent;
            pictureBoxRemoveFilter.Cursor = Cursors.Hand;
            pictureBoxRemoveFilter.Image = (Image)resources.GetObject("pictureBoxRemoveFilter.Image");
            pictureBoxRemoveFilter.Location = new Point(0, 0);
            pictureBoxRemoveFilter.Name = "pictureBoxRemoveFilter";
            pictureBoxRemoveFilter.Size = new Size(38, 38);
            pictureBoxRemoveFilter.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxRemoveFilter.TabIndex = 10;
            pictureBoxRemoveFilter.TabStop = false;
            toolTip.SetToolTip(pictureBoxRemoveFilter, "Xóa tất cả bộ lọc");
            // 
            // panel1
            // 
            panel1.Controls.Add(txtMoTaChiTiet);
            panel1.Controls.Add(lblMoTaChiTiet);
            panel1.Controls.Add(lblXaPhuong);
            panel1.Controls.Add(cboXaPhuong);
            panel1.Controls.Add(lblQuanHuyen);
            panel1.Controls.Add(cboQuanHuyen);
            panel1.Controls.Add(txtMaCT);
            panel1.Controls.Add(lblTinh);
            panel1.Controls.Add(lblMaCT);
            panel1.Controls.Add(cboTinh);
            panel1.Controls.Add(txtTenCT);
            panel1.Controls.Add(lblGhiChu);
            panel1.Controls.Add(lblTenCT);
            panel1.Controls.Add(txtGhiChu);
            panel1.Controls.Add(txtTinhTrang);
            panel1.Controls.Add(lblChuDauTu);
            panel1.Controls.Add(lblTinhTrang);
            panel1.Controls.Add(txtChuDauTu);
            panel1.Controls.Add(dtpNgayBatDau);
            panel1.Controls.Add(lblDuToan);
            panel1.Controls.Add(lblNgayBatDau);
            panel1.Controls.Add(txtDuToan);
            panel1.Controls.Add(dtpNgayKetThuc);
            panel1.Controls.Add(lblNgayKetThuc);
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(1900, 260);
            panel1.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnExport);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnRefresh);
            panel2.Location = new Point(3, 316);
            panel2.Name = "panel2";
            panel2.Size = new Size(1900, 88);
            panel2.TabIndex = 22;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(1050, 23);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(150, 50);
            btnExport.TabIndex = 19;
            btnExport.Text = "Xuất Excel";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvConstruction);
            panel3.Controls.Add(panelFilter);
            panel3.Location = new Point(0, 410);
            panel3.Name = "panel3";
            panel3.Size = new Size(1884, 540);
            panel3.TabIndex = 23;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblMessage);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1900, 50);
            panel4.TabIndex = 24;
            // 
            // dtpFilterNgayBatDau
            // 
            dtpFilterNgayBatDau.Format = DateTimePickerFormat.Short;
            dtpFilterNgayBatDau.Location = new Point(1280, 0);
            dtpFilterNgayBatDau.Name = "dtpFilterNgayBatDau";
            dtpFilterNgayBatDau.Size = new Size(200, 38);
            dtpFilterNgayBatDau.TabIndex = 17;
            // 
            // dtpFilterNgayKetThuc
            // 
            dtpFilterNgayKetThuc.Format = DateTimePickerFormat.Short;
            dtpFilterNgayKetThuc.Location = new Point(1480, 0);
            dtpFilterNgayKetThuc.Name = "dtpFilterNgayKetThuc";
            dtpFilterNgayKetThuc.Size = new Size(200, 38);
            dtpFilterNgayKetThuc.TabIndex = 20;
            // 
            // CongTrinh
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CongTrinh";
            Size = new Size(1884, 981);
            Load += CongTrinh_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConstruction).EndInit();
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRemoveFilter).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.IContainer components;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnExport;
        private Panel panel4;
        private DataGridViewTextBoxColumn dgvColSTT;
        private DataGridViewTextBoxColumn dgvColMaCT;
        private DataGridViewTextBoxColumn dgvColTenCongTrinh;
        private DataGridViewTextBoxColumn dgvColTinhTrang;
        private DataGridViewTextBoxColumn dgvColChuDauTu;
        private DataGridViewTextBoxColumn dgvColDiaDiem;
        private DataGridViewTextBoxColumn dgvColDuToan;
        private DataGridViewTextBoxColumn dgvColNgayBatDau;
        private DataGridViewTextBoxColumn dgvColNgayKetThuc;
        private DataGridViewTextBoxColumn dgvColGhiChu;
        private DataGridViewCheckBoxColumn dgvColCheckBox;
        private TextBox txtFilterGhiChu;
        private TextBox txtFilterDuToan;
        private TextBox txtFilterDiaDiem;
        private TextBox txtFilterChuDauTu;
        private DateTimePicker dtpFilterNgayBatDau;
        private DateTimePicker dtpFilterNgayKetThuc;
    }
}