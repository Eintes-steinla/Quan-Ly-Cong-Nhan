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
            components = new System.ComponentModel.Container();
            lblMessage = new Label();
            btnExport = new Button();
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
            lblNgayBatDau = new Label();
            lblNgayKetThuc = new Label();
            dgvConstruction = new DataGridView();
            btnRefresh = new Button();
            panelFilter = new Panel();
            txtFilterName = new TextBox();
            txtFilterYear = new TextBox();
            txtFilterLocation = new TextBox();
            pictureBoxRemoveFilter = new PictureBox();
            toolTip = new ToolTip(components);
            dataGridViewColumnSTT = new DataGridViewTextBoxColumn();
            dataGridViewColumnName = new DataGridViewTextBoxColumn();
            dataGridViewColumnYear = new DataGridViewTextBoxColumn();
            dataGridViewColumnLocation = new DataGridViewTextBoxColumn();
            dataGridViewColumnID = new DataGridViewTextBoxColumn();
            dataGridViewColumnCheckBox = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvConstruction).BeginInit();
            panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRemoveFilter).BeginInit();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.ForeColor = Color.Green;
            lblMessage.Location = new Point(669, 20);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 26);
            lblMessage.TextAlign = ContentAlignment.MiddleLeft;
            lblMessage.MaximumSize = new Size(500, 0);
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExport.Location = new Point(1043, 744);
            btnExport.Margin = new Padding(4, 5, 4, 5);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(151, 36);
            btnExport.TabIndex = 11;
            btnExport.Text = "Xuất Excel";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(352, 800);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(160, 36);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Xóa";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(192, 800);
            btnEdit.Margin = new Padding(4, 5, 4, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(160, 36);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Sửa";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(32, 800);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(160, 36);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Thêm";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(513, 800);
            btnRefresh.Margin = new Padding(4, 5, 4, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(130, 36);
            btnRefresh.TabIndex = 18;
            btnRefresh.Text = "Làm mới";
            toolTip.SetToolTip(btnRefresh, "Xóa tất cả các ô nhập dữ liệu");

            // 
            txtMaCT.Location = new Point(195, 170);
            txtMaCT.Margin = new Padding(4, 5, 4, 5);
            txtMaCT.Name = "txtMaCT";
            txtMaCT.Size = new Size(223, 33);
            txtMaCT.TabIndex = 3;
            // 
            // lblMaCT
            // 
            lblMaCT.AutoSize = true;
            lblMaCT.Location = new Point(31, 175);
            lblMaCT.Margin = new Padding(4, 0, 4, 0);
            lblMaCT.Name = "lblMaCT";
            lblMaCT.Size = new Size(155, 26);
            lblMaCT.Text = "Mã công trình:";
            // 
            // txtTenCT
            // 
            txtTenCT.Location = new Point(195, 220);
            txtTenCT.Margin = new Padding(4, 5, 4, 5);
            txtTenCT.Name = "txtTenCT";
            txtTenCT.Size = new Size(448, 33);
            txtTenCT.TabIndex = 4;
            // 
            // lblTenCT
            // 
            lblTenCT.AutoSize = true;
            lblTenCT.Location = new Point(31, 225);
            lblTenCT.Margin = new Padding(4, 0, 4, 0);
            lblTenCT.Name = "lblTenCT";
            lblTenCT.Size = new Size(155, 26);
            lblTenCT.Text = "Tên công trình:";
            // 
            // txtTinhTrang
            // 
            txtTinhTrang.Location = new Point(195, 270);
            txtTinhTrang.Margin = new Padding(4, 5, 4, 5);
            txtTinhTrang.Name = "txtTinhTrang";
            txtTinhTrang.Size = new Size(223, 33);
            txtTinhTrang.TabIndex = 5;
            // 
            // lblTinhTrang
            // 
            lblTinhTrang.AutoSize = true;
            lblTinhTrang.Location = new Point(31, 275);
            lblTinhTrang.Margin = new Padding(4, 0, 4, 0);
            lblTinhTrang.Name = "lblTinhTrang";
            lblTinhTrang.Size = new Size(103, 26);
            lblTinhTrang.Text = "Tình trạng:";
            // 
            // lblNgayBatDau
            // 
            lblNgayBatDau.AutoSize = true;
            lblNgayBatDau.Location = new Point(31, 325);
            lblNgayBatDau.Margin = new Padding(4, 0, 4, 0);
            lblNgayBatDau.Name = "lblNgayBatDau";
            lblNgayBatDau.Size = new Size(155, 26);
            lblNgayBatDau.Text = "Ngày bắt đầu:";
            // 
            // lblNgayKetThuc
            // 
            lblNgayKetThuc.AutoSize = true;
            lblNgayKetThuc.Location = new Point(31, 375);
            lblNgayKetThuc.Margin = new Padding(4, 0, 4, 0);
            lblNgayKetThuc.Name = "lblNgayKetThuc";
            lblNgayKetThuc.Size = new Size(155, 26);
            lblNgayKetThuc.Text = "Ngày kết thúc:";
            // 
            // txtDuToan
            // 
            txtDuToan.Location = new Point(195, 420);
            txtDuToan.Margin = new Padding(4, 5, 4, 5);
            txtDuToan.Name = "txtDuToan";
            txtDuToan.Size = new Size(223, 33);
            txtDuToan.TabIndex = 8;
            // 
            // lblDuToan
            // 
            lblDuToan.AutoSize = true;
            lblDuToan.Location = new Point(31, 425);
            lblDuToan.Margin = new Padding(4, 0, 4, 0);
            lblDuToan.Name = "lblDuToan";
            lblDuToan.Size = new Size(103, 26);
            lblDuToan.Text = "Dự toán:";
            // 
            // txtChuDauTu
            // 
            txtChuDauTu.Location = new Point(195, 470);
            txtChuDauTu.Margin = new Padding(4, 5, 4, 5);
            txtChuDauTu.Name = "txtChuDauTu";
            txtChuDauTu.Size = new Size(448, 33);
            txtChuDauTu.TabIndex = 9;
            // 
            // lblChuDauTu
            // 
            lblChuDauTu.AutoSize = true;
            lblChuDauTu.Location = new Point(31, 475);
            lblChuDauTu.Margin = new Padding(4, 0, 4, 0);
            lblChuDauTu.Name = "lblChuDauTu";
            lblChuDauTu.Size = new Size(103, 26);
            lblChuDauTu.Text = "Chủ đầu tư:";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(195, 520);
            txtGhiChu.Margin = new Padding(4, 5, 4, 5);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(448, 33);
            txtGhiChu.TabIndex = 10;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(31, 525);
            lblGhiChu.Margin = new Padding(4, 0, 4, 0);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(103, 26);
            lblGhiChu.Text = "Ghi chú:";
            // 
            // cboTinh
            // 
            cboTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTinh.Location = new Point(195, 570);
            cboTinh.Margin = new Padding(4, 5, 4, 5);
            cboTinh.Name = "cboTinh";
            cboTinh.Size = new Size(223, 33);
            cboTinh.TabIndex = 11;
            // 
            // lblTinh
            // 
            lblTinh.AutoSize = true;
            lblTinh.Location = new Point(31, 575);
            lblTinh.Margin = new Padding(4, 0, 4, 0);
            lblTinh.Name = "lblTinh";
            lblTinh.Size = new Size(103, 26);
            lblTinh.Text = "Tỉnh/TP:";
            // 
            // cboQuanHuyen
            // 
            cboQuanHuyen.DropDownStyle = ComboBoxStyle.DropDownList;
            cboQuanHuyen.Location = new Point(195, 620);
            cboQuanHuyen.Margin = new Padding(4, 5, 4, 5);
            cboQuanHuyen.Name = "cboQuanHuyen";
            cboQuanHuyen.Size = new Size(223, 33);
            cboQuanHuyen.TabIndex = 12;
            // 
            // lblQuanHuyen
            // 
            lblQuanHuyen.AutoSize = true;
            lblQuanHuyen.Location = new Point(31, 625);
            lblQuanHuyen.Margin = new Padding(4, 0, 4, 0);
            lblQuanHuyen.Name = "lblQuanHuyen";
            lblQuanHuyen.Size = new Size(155, 26);
            lblQuanHuyen.Text = "Quận/Huyện:";
            // 
            // cboXaPhuong
            // 
            cboXaPhuong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboXaPhuong.Location = new Point(195, 670);
            cboXaPhuong.Margin = new Padding(4, 5, 4, 5);
            cboXaPhuong.Name = "cboXaPhuong";
            cboXaPhuong.Size = new Size(223, 33);
            cboXaPhuong.TabIndex = 13;
            // 
            // lblXaPhuong
            // 
            lblXaPhuong.AutoSize = true;
            lblXaPhuong.Location = new Point(31, 675);
            lblXaPhuong.Margin = new Padding(4, 0, 4, 0);
            lblXaPhuong.Name = "lblXaPhuong";
            lblXaPhuong.Size = new Size(155, 26);
            lblXaPhuong.Text = "Xã/Phường:";
            // 
            // txtMoTaChiTiet
            // 
            txtMoTaChiTiet.Location = new Point(195, 720);
            txtMoTaChiTiet.Margin = new Padding(4, 5, 4, 5);
            txtMoTaChiTiet.Multiline = true;
            txtMoTaChiTiet.Name = "txtMoTaChiTiet";
            txtMoTaChiTiet.ScrollBars = ScrollBars.Vertical;
            txtMoTaChiTiet.Size = new Size(448, 60);
            txtMoTaChiTiet.TabIndex = 14;
            // 
            // lblMoTaChiTiet
            // 
            lblMoTaChiTiet.AutoSize = true;
            lblMoTaChiTiet.Location = new Point(31, 725);
            lblMoTaChiTiet.Margin = new Padding(4, 0, 4, 0);
            lblMoTaChiTiet.Name = "lblMoTaChiTiet";
            lblMoTaChiTiet.Size = new Size(207, 26);
            lblMoTaChiTiet.Text = "Mô tả chi tiết địa điểm:";
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Format = DateTimePickerFormat.Short;
            dtpNgayBatDau.Location = new Point(195, 320);
            dtpNgayBatDau.Margin = new Padding(4, 5, 4, 5);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(223, 33);
            dtpNgayBatDau.TabIndex = 6;
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.Format = DateTimePickerFormat.Short;
            dtpNgayKetThuc.Location = new Point(195, 370);
            dtpNgayKetThuc.Margin = new Padding(4, 5, 4, 5);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(223, 33);
            dtpNgayKetThuc.TabIndex = 7;
            // dgvConstruction
            // 
            dgvConstruction.AllowUserToAddRows = false;
            dgvConstruction.AllowUserToDeleteRows = false;
            dgvConstruction.AllowUserToOrderColumns = true;
            dgvConstruction.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvConstruction.BackgroundColor = Color.White;
            dgvConstruction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConstruction.Columns.AddRange([dataGridViewColumnSTT, dataGridViewColumnName, dataGridViewColumnLocation, dataGridViewColumnYear, dataGridViewColumnID, dataGridViewColumnCheckBox]);
            dgvConstruction.Location = new Point(31, 850);
            dgvConstruction.Margin = new Padding(4, 5, 4, 5);
            dgvConstruction.Name = "dgvConstruction";
            dgvConstruction.ReadOnly = true;
            dgvConstruction.Size = new Size(1163, 449);
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
            panelFilter.Location = new Point(31, 805);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(1163, 45);
            // 
            // txtFilterName
            // 
            txtFilterName.Font = new Font("Times New Roman", 13.2000008F);
            txtFilterName.Location = new Point(130, 5);
            txtFilterName.Name = "txtFilterName";
            txtFilterName.PlaceholderText = "Tìm theo tên công trình...";
            txtFilterName.Size = new Size(405, 33);
            txtFilterName.TabIndex = 7;
            // 
            // txtFilterYear
            // 
            txtFilterYear.Font = new Font("Times New Roman", 13.2000008F);
            txtFilterYear.Location = new Point(943, 5);
            txtFilterYear.Name = "txtFilterYear";
            txtFilterYear.PlaceholderText = "Tìm theo năm...";
            txtFilterYear.Size = new Size(175, 33);
            txtFilterYear.TabIndex = 9;
            // 
            // txtFilterLocation
            // 
            txtFilterLocation.Font = new Font("Times New Roman", 13.2000008F);
            txtFilterLocation.Location = new Point(536, 5);
            txtFilterLocation.Name = "txtFilterLocation";
            txtFilterLocation.PlaceholderText = "Tìm theo địa điểm...";
            txtFilterLocation.Size = new Size(405, 33);
            txtFilterLocation.TabIndex = 8;
            // 
            // pictureBoxRemoveFilter
            // 
            // pictureBoxRemoveFilter.BackColor = Color.Transparent;
            pictureBoxRemoveFilter.Cursor = Cursors.Hand;
            pictureBoxRemoveFilter.Image = Properties.Resources.images;
            pictureBoxRemoveFilter.Location = new Point(0, 5);
            pictureBoxRemoveFilter.Name = "pictureBoxRemoveFilter";
            pictureBoxRemoveFilter.Size = new Size(33, 33);
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
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblMessage);
            Controls.Add(btnExport);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtMaCT);
            Controls.Add(lblMaCT);
            Controls.Add(txtTenCT);
            Controls.Add(lblTenCT);
            Controls.Add(txtTinhTrang);
            Controls.Add(lblTinhTrang);
            Controls.Add(dtpNgayBatDau);
            Controls.Add(lblNgayBatDau);
            Controls.Add(dtpNgayKetThuc);
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
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ConstructionUserControl";
            Size = new Size(1228, 1320);
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
