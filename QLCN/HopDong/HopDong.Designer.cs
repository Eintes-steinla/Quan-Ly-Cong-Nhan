using System.Data;
using Microsoft.Data.SqlClient;
using QLCN.DB;
using ClosedXML.Excel;
namespace QLCN.HopDong
{
    partial class HopDong
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private Label lblMaCN;
        private TextBox txtMaCN;
        private Label lblTenCN;
        private TextBox txtTenCN;
        private TextBox txtLoaiHD;
        private TextBox txtLuongCB;
        private Label lblGhiChu;
        private TextBox txtGhiChu;
        private Label lblLoaiHD;
        private Label lblLuongCB;
        private Label lblPhuCap;
        private Label lblNgayKetThuc;
        private DateTimePicker dtpNgayKetThuc;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private Panel panelFilter;
        private DataGridView dgvConstruction;
        private Label lblMessage;
        private TextBox txtFilterMaCN;
        private TextBox txtFilterTenCN;
        private PictureBox pictureBoxRemoveFilter;
        private ToolTip toolTip;
        private DataGridViewTextBoxColumn dataGridViewColumnSTT;
        private DataGridViewTextBoxColumn dataGridViewColumnName;
        private DataGridViewTextBoxColumn dataGridViewColumnYear;
        private DataGridViewTextBoxColumn dataGridViewColumnLocation;
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblMessage = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            txtMaCN = new TextBox();
            lblMaCN = new Label();
            txtTenCN = new TextBox();
            lblTenCN = new Label();
            dtpNgayKetThuc = new DateTimePicker();
            lblNgayKetThuc = new Label();
            txtLoaiHD = new TextBox();
            txtLuongCB = new TextBox();
            txtGhiChu = new TextBox();
            lblGhiChu = new Label();
            lblLoaiHD = new Label();
            lblLuongCB = new Label();
            lblPhuCap = new Label();
            dgvConstruction = new DataGridView();
            dgvColSTT = new DataGridViewTextBoxColumn();
            dgvColMaCN = new DataGridViewTextBoxColumn();
            dgvColTenCN = new DataGridViewTextBoxColumn();
            dgvColNgayBatDau = new DataGridViewTextBoxColumn();
            dgvColNgayKetThuc = new DataGridViewTextBoxColumn();
            dgvColLoaiHD = new DataGridViewTextBoxColumn();
            dgvColLuongCB = new DataGridViewTextBoxColumn();
            dgvColPhuCap = new DataGridViewTextBoxColumn();
            dgvColGhiChu = new DataGridViewTextBoxColumn();
            dataGridViewColumnCheckBox = new DataGridViewCheckBoxColumn();
            btnRefresh = new Button();
            panelFilter = new Panel();
            dtpFilterNgayBatDau = new DateTimePicker();
            dtpFilterNgayKetThuc = new DateTimePicker();
            txtFilterGhiChu = new TextBox();
            txtFilterPhuCap = new TextBox();
            txtFilterLuongCB = new TextBox();
            txtFilterLoaiHD = new TextBox();
            txtFilterMaCN = new TextBox();
            txtFilterTenCN = new TextBox();
            pictureBoxRemoveFilter = new PictureBox();
            toolTip = new ToolTip(components);
            panel1 = new Panel();
            dtpNgayBatDau = new DateTimePicker();
            txtPhuCap = new TextBox();
            lblNgayBatDau = new Label();
            panel2 = new Panel();
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
            lblMessage.Text = "test";
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
            // txtMaCN
            // 
            txtMaCN.Location = new Point(300, 23);
            txtMaCN.Margin = new Padding(4, 5, 4, 5);
            txtMaCN.Name = "txtMaCN";
            txtMaCN.Size = new Size(300, 38);
            txtMaCN.TabIndex = 3;
            // 
            // lblMaCN
            // 
            lblMaCN.AutoSize = true;
            lblMaCN.Location = new Point(50, 23);
            lblMaCN.Margin = new Padding(4, 0, 4, 0);
            lblMaCN.Name = "lblMaCN";
            lblMaCN.Size = new Size(176, 31);
            lblMaCN.TabIndex = 1;
            lblMaCN.Text = "Mã công nhân:";
            // 
            // txtTenCN
            // 
            txtTenCN.Location = new Point(300, 73);
            txtTenCN.Margin = new Padding(4, 5, 4, 5);
            txtTenCN.Name = "txtTenCN";
            txtTenCN.Size = new Size(300, 38);
            txtTenCN.TabIndex = 4;
            // 
            // lblTenCN
            // 
            lblTenCN.AutoSize = true;
            lblTenCN.Location = new Point(50, 73);
            lblTenCN.Margin = new Padding(4, 0, 4, 0);
            lblTenCN.Name = "lblTenCN";
            lblTenCN.Size = new Size(182, 31);
            lblTenCN.TabIndex = 2;
            lblTenCN.Text = "Tên công nhân:";
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.Format = DateTimePickerFormat.Short;
            dtpNgayKetThuc.Location = new Point(300, 173);
            dtpNgayKetThuc.Margin = new Padding(4, 5, 4, 5);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(300, 38);
            dtpNgayKetThuc.TabIndex = 6;
            // 
            // lblNgayKetThuc
            // 
            lblNgayKetThuc.AutoSize = true;
            lblNgayKetThuc.Location = new Point(50, 173);
            lblNgayKetThuc.Margin = new Padding(4, 0, 4, 0);
            lblNgayKetThuc.Name = "lblNgayKetThuc";
            lblNgayKetThuc.Size = new Size(171, 31);
            lblNgayKetThuc.TabIndex = 4;
            lblNgayKetThuc.Text = "Ngày kết thúc:";
            // 
            // txtLoaiHD
            // 
            txtLoaiHD.Location = new Point(900, 23);
            txtLoaiHD.Margin = new Padding(4, 5, 4, 5);
            txtLoaiHD.Name = "txtLoaiHD";
            txtLoaiHD.Size = new Size(300, 38);
            txtLoaiHD.TabIndex = 8;
            // 
            // txtLuongCB
            // 
            txtLuongCB.Location = new Point(900, 73);
            txtLuongCB.Margin = new Padding(4, 5, 4, 5);
            txtLuongCB.Name = "txtLuongCB";
            txtLuongCB.Size = new Size(300, 38);
            txtLuongCB.TabIndex = 9;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(900, 173);
            txtGhiChu.Margin = new Padding(4, 5, 4, 5);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(300, 38);
            txtGhiChu.TabIndex = 10;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(700, 173);
            lblGhiChu.Margin = new Padding(4, 0, 4, 0);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(107, 31);
            lblGhiChu.TabIndex = 8;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // lblLoaiHD
            // 
            lblLoaiHD.AutoSize = true;
            lblLoaiHD.Location = new Point(700, 23);
            lblLoaiHD.Margin = new Padding(4, 0, 4, 0);
            lblLoaiHD.Name = "lblLoaiHD";
            lblLoaiHD.Size = new Size(179, 31);
            lblLoaiHD.TabIndex = 9;
            lblLoaiHD.Text = "Loại hợp đồng:";
            // 
            // lblLuongCB
            // 
            lblLuongCB.AutoSize = true;
            lblLuongCB.Location = new Point(700, 73);
            lblLuongCB.Margin = new Padding(4, 0, 4, 0);
            lblLuongCB.Name = "lblLuongCB";
            lblLuongCB.Size = new Size(171, 31);
            lblLuongCB.TabIndex = 10;
            lblLuongCB.Text = "Lương cơ bản:";
            // 
            // lblPhuCap
            // 
            lblPhuCap.AutoSize = true;
            lblPhuCap.Location = new Point(700, 123);
            lblPhuCap.Margin = new Padding(4, 0, 4, 0);
            lblPhuCap.Name = "lblPhuCap";
            lblPhuCap.Size = new Size(108, 31);
            lblPhuCap.TabIndex = 11;
            lblPhuCap.Text = "Phụ cấp:";
            // 
            // dgvConstruction
            // 
            dgvConstruction.AllowUserToAddRows = false;
            dgvConstruction.AllowUserToDeleteRows = false;
            dgvConstruction.AllowUserToOrderColumns = true;
            dgvConstruction.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvConstruction.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvConstruction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvConstruction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConstruction.Columns.AddRange(new DataGridViewColumn[] { dgvColSTT, dgvColMaCN, dgvColTenCN, dgvColNgayBatDau, dgvColNgayKetThuc, dgvColLoaiHD, dgvColLuongCB, dgvColPhuCap, dgvColGhiChu, dataGridViewColumnCheckBox });
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
            dgvColSTT.Name = "dgvColSTT";
            dgvColSTT.ReadOnly = true;
            dgvColSTT.Width = 60;
            // 
            // dgvColMaCN
            // 
            dgvColMaCN.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColMaCN.HeaderText = "Mã CN";
            dgvColMaCN.MinimumWidth = 8;
            dgvColMaCN.Name = "dgvColMaCN";
            dgvColMaCN.ReadOnly = true;
            dgvColMaCN.Width = 150;
            // 
            // dgvColTenCN
            // 
            dgvColTenCN.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColTenCN.HeaderText = "Tên CN";
            dgvColTenCN.MinimumWidth = 8;
            dgvColTenCN.Name = "dgvColTenCN";
            dgvColTenCN.ReadOnly = true;
            dgvColTenCN.Width = 140;
            // 
            // dgvColNgayBatDau
            // 
            dgvColNgayBatDau.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColNgayBatDau.HeaderText = "Ngày bắt đầu";
            dgvColNgayBatDau.MinimumWidth = 8;
            dgvColNgayBatDau.Name = "dgvColNgayBatDau";
            dgvColNgayBatDau.ReadOnly = true;
            dgvColNgayBatDau.Width = 250;
            // 
            // dgvColNgayKetThuc
            // 
            dgvColNgayKetThuc.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColNgayKetThuc.HeaderText = "Ngày kết thúc";
            dgvColNgayKetThuc.MinimumWidth = 8;
            dgvColNgayKetThuc.Name = "dgvColNgayKetThuc";
            dgvColNgayKetThuc.ReadOnly = true;
            dgvColNgayKetThuc.Width = 250;
            // 
            // dgvColLoaiHD
            // 
            dgvColLoaiHD.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColLoaiHD.HeaderText = "Loại hợp đồng";
            dgvColLoaiHD.MinimumWidth = 8;
            dgvColLoaiHD.Name = "dgvColLoaiHD";
            dgvColLoaiHD.ReadOnly = true;
            dgvColLoaiHD.Width = 270;
            // 
            // dgvColLuongCB
            // 
            dgvColLuongCB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColLuongCB.HeaderText = "Lương cơ bản";
            dgvColLuongCB.MinimumWidth = 8;
            dgvColLuongCB.Name = "dgvColLuongCB";
            dgvColLuongCB.ReadOnly = true;
            dgvColLuongCB.Width = 270;
            // 
            // dgvColPhuCap
            // 
            dgvColPhuCap.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColPhuCap.HeaderText = "Phụ cấp";
            dgvColPhuCap.MinimumWidth = 8;
            dgvColPhuCap.Name = "dgvColPhuCap";
            dgvColPhuCap.ReadOnly = true;
            dgvColPhuCap.Width = 240;
            // 
            // dgvColGhiChu
            // 
            dgvColGhiChu.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvColGhiChu.HeaderText = "Ghi chú";
            dgvColGhiChu.MinimumWidth = 8;
            dgvColGhiChu.Name = "dgvColGhiChu";
            dgvColGhiChu.ReadOnly = true;
            dgvColGhiChu.Width = 150;
            // 
            // dataGridViewColumnCheckBox
            // 
            dataGridViewColumnCheckBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewColumnCheckBox.HeaderText = "✅";
            dataGridViewColumnCheckBox.MinimumWidth = 6;
            dataGridViewColumnCheckBox.Name = "dataGridViewColumnCheckBox";
            dataGridViewColumnCheckBox.ReadOnly = true;
            dataGridViewColumnCheckBox.Width = 52;
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
            panelFilter.Controls.Add(dtpFilterNgayBatDau);
            panelFilter.Controls.Add(dtpFilterNgayKetThuc);
            panelFilter.Controls.Add(txtFilterGhiChu);
            panelFilter.Controls.Add(txtFilterPhuCap);
            panelFilter.Controls.Add(txtFilterLuongCB);
            panelFilter.Controls.Add(txtFilterLoaiHD);
            panelFilter.Controls.Add(txtFilterMaCN);
            panelFilter.Controls.Add(txtFilterTenCN);
            panelFilter.Controls.Add(pictureBoxRemoveFilter);
            panelFilter.Location = new Point(0, 0);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(1884, 38);
            panelFilter.TabIndex = 20;
            // 
            // dtpFilterNgayBatDau
            // 
            dtpFilterNgayBatDau.CustomFormat = " ";
            dtpFilterNgayBatDau.Format = DateTimePickerFormat.Short;
            dtpFilterNgayBatDau.Location = new Point(400, 0);
            dtpFilterNgayBatDau.Name = "dtpFilterNgayBatDau";
            dtpFilterNgayBatDau.Size = new Size(250, 38);
            dtpFilterNgayBatDau.TabIndex = 18;
            dtpFilterNgayBatDau.Value = new DateTime(2025, 9, 9, 22, 20, 12, 0);
            // 
            // dtpFilterNgayKetThuc
            // 
            dtpFilterNgayKetThuc.CustomFormat = " ";
            dtpFilterNgayKetThuc.Format = DateTimePickerFormat.Short;
            dtpFilterNgayKetThuc.Location = new Point(650, 0);
            dtpFilterNgayKetThuc.Name = "dtpFilterNgayKetThuc";
            dtpFilterNgayKetThuc.Size = new Size(250, 38);
            dtpFilterNgayKetThuc.TabIndex = 17;
            dtpFilterNgayKetThuc.Value = new DateTime(2025, 9, 9, 22, 20, 12, 0);
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
            // txtFilterPhuCap
            // 
            txtFilterPhuCap.Location = new Point(1440, 0);
            txtFilterPhuCap.Name = "txtFilterPhuCap";
            txtFilterPhuCap.PlaceholderText = "PhuCap";
            txtFilterPhuCap.Size = new Size(240, 38);
            txtFilterPhuCap.TabIndex = 14;
            txtFilterPhuCap.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFilterLuongCB
            // 
            txtFilterLuongCB.Location = new Point(1170, 0);
            txtFilterLuongCB.Name = "txtFilterLuongCB";
            txtFilterLuongCB.PlaceholderText = "LuongCB";
            txtFilterLuongCB.Size = new Size(270, 38);
            txtFilterLuongCB.TabIndex = 13;
            txtFilterLuongCB.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFilterLoaiHD
            // 
            txtFilterLoaiHD.Location = new Point(900, 0);
            txtFilterLoaiHD.Name = "txtFilterLoaiHD";
            txtFilterLoaiHD.PlaceholderText = "LoaiHD";
            txtFilterLoaiHD.Size = new Size(270, 38);
            txtFilterLoaiHD.TabIndex = 12;
            txtFilterLoaiHD.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFilterMaCN
            // 
            txtFilterMaCN.Font = new Font("Times New Roman", 13.2F);
            txtFilterMaCN.Location = new Point(110, 0);
            txtFilterMaCN.Name = "txtFilterMaCN";
            txtFilterMaCN.PlaceholderText = "MaCN";
            txtFilterMaCN.Size = new Size(150, 38);
            txtFilterMaCN.TabIndex = 7;
            txtFilterMaCN.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFilterTenCN
            // 
            txtFilterTenCN.Font = new Font("Times New Roman", 13.2F);
            txtFilterTenCN.Location = new Point(260, 0);
            txtFilterTenCN.Name = "txtFilterTenCN";
            txtFilterTenCN.PlaceholderText = "TenCN";
            txtFilterTenCN.Size = new Size(140, 38);
            txtFilterTenCN.TabIndex = 8;
            txtFilterTenCN.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBoxRemoveFilter
            // 
            pictureBoxRemoveFilter.BackColor = Color.Transparent;
            pictureBoxRemoveFilter.Cursor = Cursors.Hand;
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
            panel1.Controls.Add(dtpNgayBatDau);
            panel1.Controls.Add(txtPhuCap);
            panel1.Controls.Add(lblPhuCap);
            panel1.Controls.Add(lblLuongCB);
            panel1.Controls.Add(txtMaCN);
            panel1.Controls.Add(lblLoaiHD);
            panel1.Controls.Add(lblMaCN);
            panel1.Controls.Add(txtTenCN);
            panel1.Controls.Add(lblGhiChu);
            panel1.Controls.Add(lblTenCN);
            panel1.Controls.Add(txtGhiChu);
            panel1.Controls.Add(lblNgayBatDau);
            panel1.Controls.Add(txtLuongCB);
            panel1.Controls.Add(dtpNgayKetThuc);
            panel1.Controls.Add(lblNgayKetThuc);
            panel1.Controls.Add(txtLoaiHD);
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(1881, 260);
            panel1.TabIndex = 21;
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Format = DateTimePickerFormat.Short;
            dtpNgayBatDau.Location = new Point(300, 123);
            dtpNgayBatDau.Margin = new Padding(4, 5, 4, 5);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(300, 38);
            dtpNgayBatDau.TabIndex = 16;
            // 
            // txtPhuCap
            // 
            txtPhuCap.Location = new Point(900, 123);
            txtPhuCap.Margin = new Padding(4, 5, 4, 5);
            txtPhuCap.Name = "txtPhuCap";
            txtPhuCap.Size = new Size(300, 38);
            txtPhuCap.TabIndex = 15;
            // 
            // lblNgayBatDau
            // 
            lblNgayBatDau.AutoSize = true;
            lblNgayBatDau.Location = new Point(50, 123);
            lblNgayBatDau.Margin = new Padding(4, 0, 4, 0);
            lblNgayBatDau.Name = "lblNgayBatDau";
            lblNgayBatDau.Size = new Size(164, 31);
            lblNgayBatDau.TabIndex = 3;
            lblNgayBatDau.Text = "Ngày bắt đầu:";
            // 
            // panel2
            // 
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
            // HopDong
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "HopDong";
            Size = new Size(1884, 981);
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
        private TextBox txtFilterGhiChu;
        private TextBox txtFilterPhuCap;
        private TextBox txtFilterLuongCB;
        private TextBox txtFilterLoaiHD;
        private Label lblNgayBatDau;
        private TextBox txtPhuCap;
        private DateTimePicker dtpFilterNgayKetThuc;
        private DateTimePicker dtpNgayBatDau;
        private DateTimePicker dtpFilterNgayBatDau;
        private DataGridViewTextBoxColumn dgvColSTT;
        private DataGridViewTextBoxColumn dgvColMaCN;
        private DataGridViewTextBoxColumn dgvColTenCN;
        private DataGridViewTextBoxColumn dgvColNgayBatDau;
        private DataGridViewTextBoxColumn dgvColNgayKetThuc;
        private DataGridViewTextBoxColumn dgvColLoaiHD;
        private DataGridViewTextBoxColumn dgvColLuongCB;
        private DataGridViewTextBoxColumn dgvColPhuCap;
        private DataGridViewTextBoxColumn dgvColGhiChu;
        private DataGridViewCheckBoxColumn dataGridViewColumnCheckBox;
    }
}