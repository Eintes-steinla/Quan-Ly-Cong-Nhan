using System.Data;
using Microsoft.Data.SqlClient;
using QLCN.DB;
using ClosedXML.Excel;
using System.Diagnostics;
namespace QLCN.CongNhan
{
    partial class CongNhan
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private Label lblMaCN;
        private TextBox txtMaCN;
        private Label lblTenCN;
        private TextBox txtTenCN;
        private Label lblSDT;
        private TextBox txtSDT;
        private Label lblCCCD;
        private TextBox txtCCCD;
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
        private Label lblNgaySinh;
        private DateTimePicker dtpNgaySinh;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private Panel panelFilter;
        private DataGridView dgvConstruction;
        private Label lblMessage;
        private TextBox txtFilterMaCN;
        private TextBox txtFilterTenCN;
        private ToolTip toolTip;
        

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CongNhan));
            lblMessage = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            txtMaCN = new TextBox();
            lblMaCN = new Label();
            txtTenCN = new TextBox();
            lblTenCN = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblNgaySinh = new Label();
            txtSDT = new TextBox();
            lblSDT = new Label();
            txtCCCD = new TextBox();
            lblCCCD = new Label();
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
            dgvColCheckBox = new DataGridViewCheckBoxColumn();
            btnRefresh = new Button();
            panelFilter = new Panel();
            pictureBoxRemoveFilter = new PictureBox();
            cboFilterGioiTinh = new ComboBox();
            dtpFilterNgaySinh2 = new DateTimePicker();
            dtpFilterNgaySinh1 = new DateTimePicker();
            txtFilterTenCT = new TextBox();
            txtFilterDiaDiem = new TextBox();
            txtFilterMaCN = new TextBox();
            txtFilterTenCN = new TextBox();
            toolTip = new ToolTip(components);
            panel1 = new Panel();
            cboGioiTinh = new ComboBox();
            cboTenCongTrinh = new ComboBox();
            lblGioiTinh = new Label();
            lblTenCT = new Label();
            panel2 = new Panel();
            btnImport = new Button();
            btnXemChamCong = new Button();
            btnXemHD = new Button();
            btnExport = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
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
            btnDelete.Location = new Point(474, 23);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 50);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(261, 23);
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
            // txtMaCN
            // 
            txtMaCN.Location = new Point(300, 23);
            txtMaCN.Margin = new Padding(4, 5, 4, 5);
            txtMaCN.Name = "txtMaCN";
            txtMaCN.Size = new Size(300, 33);
            txtMaCN.TabIndex = 3;
            // 
            // lblMaCN
            // 
            lblMaCN.AutoSize = true;
            lblMaCN.Location = new Point(50, 23);
            lblMaCN.Margin = new Padding(4, 0, 4, 0);
            lblMaCN.Name = "lblMaCN";
            lblMaCN.Size = new Size(140, 25);
            lblMaCN.TabIndex = 1;
            lblMaCN.Text = "Mã công nhân:";
            // 
            // txtTenCN
            // 
            txtTenCN.Location = new Point(300, 73);
            txtTenCN.Margin = new Padding(4, 5, 4, 5);
            txtTenCN.Name = "txtTenCN";
            txtTenCN.Size = new Size(300, 33);
            txtTenCN.TabIndex = 4;
            // 
            // lblTenCN
            // 
            lblTenCN.AutoSize = true;
            lblTenCN.Location = new Point(50, 73);
            lblTenCN.Margin = new Padding(4, 0, 4, 0);
            lblTenCN.Name = "lblTenCN";
            lblTenCN.Size = new Size(145, 25);
            lblTenCN.TabIndex = 2;
            lblTenCN.Text = "Tên công nhân:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(300, 173);
            dtpNgaySinh.Margin = new Padding(4, 5, 4, 5);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.ShowCheckBox = true;
            dtpNgaySinh.Size = new Size(300, 33);
            dtpNgaySinh.TabIndex = 6;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(50, 173);
            lblNgaySinh.Margin = new Padding(4, 0, 4, 0);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(106, 25);
            lblNgaySinh.TabIndex = 4;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(1550, 23);
            txtSDT.Margin = new Padding(4, 5, 4, 5);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(300, 33);
            txtSDT.TabIndex = 8;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(1300, 23);
            lblSDT.Margin = new Padding(4, 0, 4, 0);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(59, 25);
            lblSDT.TabIndex = 6;
            lblSDT.Text = "SDT:";
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(1550, 73);
            txtCCCD.Margin = new Padding(4, 5, 4, 5);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(300, 33);
            txtCCCD.TabIndex = 9;
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Location = new Point(1300, 73);
            lblCCCD.Margin = new Padding(4, 0, 4, 0);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(79, 25);
            lblCCCD.TabIndex = 7;
            lblCCCD.Text = "CCCD:";
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

            dgvColSTT = new DataGridViewTextBoxColumn();
            dgvColMaCN = new DataGridViewTextBoxColumn();
            dgvColTenCN = new DataGridViewTextBoxColumn();
            dgvColGioiTinh = new DataGridViewTextBoxColumn();
            dgvColNgaySinh = new DataGridViewTextBoxColumn();
            dgvColSDT = new DataGridViewTextBoxColumn();
            dgvColCCCD = new DataGridViewTextBoxColumn();
            dgvColDiaDiem = new DataGridViewTextBoxColumn();
            dgvColTenCT = new DataGridViewTextBoxColumn();
            dgvColGhiChu = new DataGridViewTextBoxColumn();
            dgvColCheckBox = new DataGridViewCheckBoxColumn();


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
            dgvConstruction.Columns.AddRange(new DataGridViewColumn[] { dgvColSTT, dgvColMaCN, dgvColTenCN, dgvColGioiTinh, dgvColNgaySinh, dgvColSDT, dgvColCCCD, dgvColDiaDiem,dgvColTenCT, dgvColGhiChu, dgvColCheckBox });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.AntiqueWhite;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvConstruction.DefaultCellStyle = dataGridViewCellStyle4;
            dgvConstruction.Dock = DockStyle.Bottom;
            dgvConstruction.Location = new Point(0, 36);
            dgvConstruction.Margin = new Padding(4, 5, 4, 5);
            dgvConstruction.Name = "dgvConstruction";
            dgvConstruction.ReadOnly = true;
            dgvConstruction.RowHeadersWidth = 51;
            dgvConstruction.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConstruction.Size = new Size(1884, 504);
            dgvConstruction.TabIndex = 19;
            dgvConstruction.AutoGenerateColumns = false;

            dgvColGhiChu.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColGhiChu.DataPropertyName = "GhiChu";
            dgvColGhiChu.HeaderText = "Ghi chú";
            dgvColGhiChu.MinimumWidth = 8;
            dgvColGhiChu.Name = "dgvColGhiChu";
            dgvColGhiChu.ReadOnly = true;
            dgvColGhiChu.Width = 200;

            dgvColTenCT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColTenCT.DataPropertyName = "TenCT";
            dgvColTenCT.HeaderText = "Tên CT";
            dgvColTenCT.MinimumWidth = 8;
            dgvColTenCT.Name = "dgvColTenCT";
            dgvColTenCT.ReadOnly = true;
            dgvColTenCT.Width = 200;

            dgvColDiaDiem.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColDiaDiem.DataPropertyName = "DiaChi";
            dgvColDiaDiem.HeaderText = "Địa chỉ";
            dgvColDiaDiem.MinimumWidth = 8;
            dgvColDiaDiem.Name = "dgvColDiaDiem";
            dgvColDiaDiem.ReadOnly = true;
            dgvColDiaDiem.Width = 250;

            dgvColCCCD.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColCCCD.DataPropertyName = "CCCD";
            dgvColCCCD.HeaderText = "CCCD/CMND";
            dgvColCCCD.MinimumWidth = 8;
            dgvColCCCD.Name = "dgvColCCCD";
            dgvColCCCD.ReadOnly = true;
            dgvColCCCD.Width = 150;

            dgvColSDT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColSDT.DataPropertyName = "SDT";
            dgvColSDT.HeaderText = "SDT";
            dgvColSDT.MinimumWidth = 8;
            dgvColSDT.Name = "dgvColSDT";
            dgvColSDT.ReadOnly = true;
            dgvColSDT.Width = 150;

            dgvColNgaySinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColNgaySinh.DataPropertyName = "NgaySinh";
            dgvColNgaySinh.HeaderText = "Ngày sinh";
            dgvColNgaySinh.MinimumWidth = 8;
            dgvColNgaySinh.Name = "dgvColNgaySinh";
            dgvColNgaySinh.ReadOnly = true;
            dgvColNgaySinh.Width = 310;

            dgvColGioiTinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColGioiTinh.DataPropertyName = "GioiTinh";
            dgvColGioiTinh.HeaderText = "Giới tinh";
            dgvColGioiTinh.MinimumWidth = 8;
            dgvColGioiTinh.Name = "dgvColGioiTinh";
            dgvColGioiTinh.ReadOnly = true;
            dgvColGioiTinh.Width = 180;

            dgvColTenCN.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColTenCN.DataPropertyName = "TenCN";
            dgvColTenCN.HeaderText = "Họ và tên";
            dgvColTenCN.MinimumWidth = 8;
            dgvColTenCN.Name = "dgvColTenCN";
            dgvColTenCN.ReadOnly = true;
            dgvColTenCN.Width = 140;

            dgvColMaCN.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColMaCN.DataPropertyName = "MaCN";
            dgvColMaCN.HeaderText = "Mã CN";
            dgvColMaCN.MinimumWidth = 8;
            dgvColMaCN.Name = "dgvColMaCN";
            dgvColMaCN.ReadOnly = true;
            dgvColMaCN.Width = 150;
            // 
            // dgvColCheckBox
            // 
            dgvColCheckBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvColCheckBox.HeaderText = "✅";
            dgvColCheckBox.MinimumWidth = 6;
            dgvColCheckBox.Name = "dgvColCheckBox";
            dgvColCheckBox.ReadOnly = true;
            dgvColCheckBox.Visible = false;
            dgvColCheckBox.Width = 125;

            dgvColSTT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColSTT.DataPropertyName = "STT";
            dgvColSTT.HeaderText = "STT";
            dgvColSTT.MinimumWidth = 8;
            dgvColSTT.Name = "STT";
            dgvColSTT.ReadOnly = true;
            dgvColSTT.Width = 60;
            
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(693, 23);
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
            panelFilter.Controls.Add(pictureBoxRemoveFilter);
            panelFilter.Controls.Add(cboFilterGioiTinh);
            panelFilter.Controls.Add(dtpFilterNgaySinh2);
            panelFilter.Controls.Add(dtpFilterNgaySinh1);
            panelFilter.Controls.Add(txtFilterTenCT);
            panelFilter.Controls.Add(txtFilterDiaDiem);
            panelFilter.Controls.Add(txtFilterMaCN);
            panelFilter.Controls.Add(txtFilterTenCN);
            panelFilter.Dock = DockStyle.Top;
            panelFilter.Location = new Point(0, 0);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(1884, 38);
            panelFilter.TabIndex = 20;
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
            pictureBoxRemoveFilter.TabIndex = 20;
            pictureBoxRemoveFilter.TabStop = false;
            toolTip.SetToolTip(pictureBoxRemoveFilter, "Xóa tất cả bộ lọc");
            // 
            // cboFilterGioiTinh
            // 
            cboFilterGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterGioiTinh.Items.AddRange(new object[] { "Tất cả", "Nam", "Nữ", "Khác" });
            cboFilterGioiTinh.Location = new Point(400, 0);
            cboFilterGioiTinh.Margin = new Padding(4, 5, 4, 5);
            cboFilterGioiTinh.Name = "cboFilterGioiTinh";
            cboFilterGioiTinh.Size = new Size(180, 33);
            cboFilterGioiTinh.TabIndex = 16;
            // 
            // dtpFilterNgaySinh2
            // 
            dtpFilterNgaySinh2.CustomFormat = "";
            dtpFilterNgaySinh2.Format = DateTimePickerFormat.Custom;
            dtpFilterNgaySinh2.ImeMode = ImeMode.NoControl;
            dtpFilterNgaySinh2.Location = new Point(735, 0);
            dtpFilterNgaySinh2.Name = "dtpFilterNgaySinh2";
            dtpFilterNgaySinh2.ShowCheckBox = true;
            dtpFilterNgaySinh2.Size = new Size(155, 33);
            dtpFilterNgaySinh2.TabIndex = 19;
            dtpFilterNgaySinh2.Value = new DateTime(2025, 10, 1, 0, 0, 0, 0);
            // 
            // dtpFilterNgaySinh1
            // 
            dtpFilterNgaySinh1.CustomFormat = "";
            dtpFilterNgaySinh1.Format = DateTimePickerFormat.Custom;
            dtpFilterNgaySinh1.Location = new Point(580, 0);
            dtpFilterNgaySinh1.Name = "dtpFilterNgaySinh1";
            dtpFilterNgaySinh1.ShowCheckBox = true;
            dtpFilterNgaySinh1.Size = new Size(155, 33);
            dtpFilterNgaySinh1.TabIndex = 17;
            dtpFilterNgaySinh1.Value = new DateTime(2025, 9, 24, 0, 0, 0, 0);
            // 
            // txtFilterTenCT
            // 
            txtFilterTenCT.Location = new Point(1480, 0);
            txtFilterTenCT.Name = "txtFilterTenCT";
            txtFilterTenCT.PlaceholderText = "Tìm tên CT";
            txtFilterTenCT.Size = new Size(200, 33);
            txtFilterTenCT.TabIndex = 15;
            txtFilterTenCT.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFilterDiaDiem
            // 
            txtFilterDiaDiem.Location = new Point(1230, 0);
            txtFilterDiaDiem.Name = "txtFilterDiaDiem";
            txtFilterDiaDiem.PlaceholderText = "Tìm địa điểm";
            txtFilterDiaDiem.Size = new Size(250, 33);
            txtFilterDiaDiem.TabIndex = 14;
            txtFilterDiaDiem.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFilterMaCN
            // 
            txtFilterMaCN.Font = new Font("Times New Roman", 13.2F);
            txtFilterMaCN.Location = new Point(110, 0);
            txtFilterMaCN.Name = "txtFilterMaCN";
            txtFilterMaCN.PlaceholderText = "Tìm mã CN";
            txtFilterMaCN.Size = new Size(150, 33);
            txtFilterMaCN.TabIndex = 7;
            txtFilterMaCN.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFilterTenCN
            // 
            txtFilterTenCN.Font = new Font("Times New Roman", 13.2F);
            txtFilterTenCN.Location = new Point(260, 0);
            txtFilterTenCN.Name = "txtFilterTenCN";
            txtFilterTenCN.PlaceholderText = "Tìm tên CN";
            txtFilterTenCN.Size = new Size(140, 33);
            txtFilterTenCN.TabIndex = 8;
            txtFilterTenCN.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.Controls.Add(cboGioiTinh);
            panel1.Controls.Add(cboTenCongTrinh);
            panel1.Controls.Add(txtMoTaChiTiet);
            panel1.Controls.Add(lblMoTaChiTiet);
            panel1.Controls.Add(lblXaPhuong);
            panel1.Controls.Add(cboXaPhuong);
            panel1.Controls.Add(lblQuanHuyen);
            panel1.Controls.Add(cboQuanHuyen);
            panel1.Controls.Add(txtMaCN);
            panel1.Controls.Add(lblTinh);
            panel1.Controls.Add(lblMaCN);
            panel1.Controls.Add(cboTinh);
            panel1.Controls.Add(txtTenCN);
            panel1.Controls.Add(lblGhiChu);
            panel1.Controls.Add(lblTenCN);
            panel1.Controls.Add(txtGhiChu);
            panel1.Controls.Add(lblCCCD);
            panel1.Controls.Add(lblGioiTinh);
            panel1.Controls.Add(txtCCCD);
            panel1.Controls.Add(dtpNgaySinh);
            panel1.Controls.Add(lblSDT);
            panel1.Controls.Add(lblNgaySinh);
            panel1.Controls.Add(txtSDT);
            panel1.Controls.Add(lblTenCT);
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(1881, 260);
            panel1.TabIndex = 21;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cboGioiTinh.Location = new Point(300, 123);
            cboGioiTinh.Margin = new Padding(4, 5, 4, 5);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(300, 33);
            cboGioiTinh.TabIndex = 17;
            // 
            // cboTenCongTrinh
            // 
            cboTenCongTrinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTenCongTrinh.Location = new Point(1550, 123);
            cboTenCongTrinh.Margin = new Padding(4, 5, 4, 5);
            cboTenCongTrinh.Name = "cboTenCongTrinh";
            cboTenCongTrinh.Size = new Size(300, 33);
            cboTenCongTrinh.TabIndex = 16;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(50, 123);
            lblGioiTinh.Margin = new Padding(4, 0, 4, 0);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(96, 25);
            lblGioiTinh.TabIndex = 3;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // lblTenCT
            // 
            lblTenCT.AutoSize = true;
            lblTenCT.Location = new Point(1300, 123);
            lblTenCT.Margin = new Padding(4, 0, 4, 0);
            lblTenCT.Name = "lblTenCT";
            lblTenCT.Size = new Size(156, 25);
            lblTenCT.TabIndex = 5;
            lblTenCT.Text = "Tên Công Trình:";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnImport);
            panel2.Controls.Add(btnXemChamCong);
            panel2.Controls.Add(btnXemHD);
            panel2.Controls.Add(btnExport);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnRefresh);
            panel2.Location = new Point(0, 310);
            panel2.Name = "panel2";
            panel2.Size = new Size(1881, 100);
            panel2.TabIndex = 22;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(1142, 23);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(150, 50);
            btnImport.TabIndex = 23;
            btnImport.Text = "Nhập Excel";
            btnImport.UseVisualStyleBackColor = true;
            // 
            // btnXemChamCong
            // 
            btnXemChamCong.Location = new Point(1632, 23);
            btnXemChamCong.Name = "btnXemChamCong";
            btnXemChamCong.Size = new Size(203, 50);
            btnXemChamCong.TabIndex = 22;
            btnXemChamCong.Text = "Xem chấm công";
            btnXemChamCong.UseVisualStyleBackColor = true;
            // 
            // btnXemHD
            // 
            btnXemHD.Location = new Point(1362, 23);
            btnXemHD.Name = "btnXemHD";
            btnXemHD.Size = new Size(203, 50);
            btnXemHD.TabIndex = 21;
            btnXemHD.Text = "Xem hợp đồng";
            btnXemHD.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(915, 23);
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
            // CongNhan
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CongNhan";
            Size = new Size(1884, 981);
            Load += CongNhan_Load;
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
        private TextBox txtFilterTenCT;
        private TextBox txtFilterDiaDiem;
        private Label lblGioiTinh;
        private Label lblTenCT;
        private DateTimePicker dtpFilterNgaySinh1;
        private DateTimePicker dtpFilterNgaySinh2;
        private ComboBox cboFilterGioiTinh;
        private DataGridViewTextBoxColumn dgvColSTT;
        private DataGridViewTextBoxColumn dgvColMaCN;
        private DataGridViewTextBoxColumn dgvColTenCN;
        private DataGridViewTextBoxColumn dgvColGioiTinh;
        private DataGridViewTextBoxColumn dgvColNgaySinh;
        private DataGridViewTextBoxColumn dgvColSDT;
        private DataGridViewTextBoxColumn dgvColCCCD;
        private DataGridViewTextBoxColumn dgvColDiaDiem;
        private DataGridViewTextBoxColumn dgvColTenCT;
        private DataGridViewTextBoxColumn dgvColGhiChu;
        private DataGridViewCheckBoxColumn dgvColCheckBox;
        private ComboBox cboTenCongTrinh;
        private ComboBox cboGioiTinh;
        private PictureBox pictureBoxRemoveFilter;
        private Button btnXemHD;
        private Button btnXemChamCong;
        private Button btnImport;
    }
}