using System.Data;
using Microsoft.Data.SqlClient;
using QLCN.DB;
using ClosedXML.Excel;
namespace QLCN.HopDong
{
    partial class HopDong
    {
        private Panel panelFilter;
        private DataGridView dgvConstruction;
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
            panelFilter = new Panel();
            comboBox1 = new ComboBox();
            dtpFilterNgayBatDau = new DateTimePicker();
            dtpFilterNgayKetThuc = new DateTimePicker();
            txtFilterMaCN = new TextBox();
            txtFilterTenCN = new TextBox();
            pictureBoxRemoveFilter = new PictureBox();
            toolTip = new ToolTip(components);
            btnExport = new Button();
            panel3 = new Panel();
            cboXaPhuong = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvConstruction).BeginInit();
            panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRemoveFilter).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
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
            dgvConstruction.Size = new Size(1884, 788);
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
            // panelFilter
            // 
            panelFilter.BackColor = Color.WhiteSmoke;
            panelFilter.BorderStyle = BorderStyle.FixedSingle;
            panelFilter.Controls.Add(comboBox1);
            panelFilter.Controls.Add(dtpFilterNgayBatDau);
            panelFilter.Controls.Add(dtpFilterNgayKetThuc);
            panelFilter.Controls.Add(txtFilterMaCN);
            panelFilter.Controls.Add(txtFilterTenCN);
            panelFilter.Controls.Add(pictureBoxRemoveFilter);
            panelFilter.Location = new Point(0, 0);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(1884, 38);
            panelFilter.TabIndex = 20;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new object[] { "Chính thức", "Thời vụ" });
            comboBox1.Location = new Point(900, 0);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(270, 37);
            comboBox1.TabIndex = 22;
            // 
            // dtpFilterNgayBatDau
            // 
            dtpFilterNgayBatDau.CustomFormat = " dd/MM/yy";
            dtpFilterNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtpFilterNgayBatDau.Location = new Point(400, 0);
            dtpFilterNgayBatDau.Name = "dtpFilterNgayBatDau";
            dtpFilterNgayBatDau.Size = new Size(250, 38);
            dtpFilterNgayBatDau.TabIndex = 18;
            dtpFilterNgayBatDau.Value = new DateTime(2025, 9, 9, 22, 20, 12, 0);
            // 
            // dtpFilterNgayKetThuc
            // 
            dtpFilterNgayKetThuc.CustomFormat = " dd/MM/yy";
            dtpFilterNgayKetThuc.Format = DateTimePickerFormat.Custom;
            dtpFilterNgayKetThuc.Location = new Point(650, 0);
            dtpFilterNgayKetThuc.Name = "dtpFilterNgayKetThuc";
            dtpFilterNgayKetThuc.Size = new Size(250, 38);
            dtpFilterNgayKetThuc.TabIndex = 17;
            dtpFilterNgayKetThuc.Value = new DateTime(2025, 9, 9, 22, 20, 12, 0);
            // 
            // txtFilterMaCN
            // 
            txtFilterMaCN.Font = new Font("Times New Roman", 13.2F);
            txtFilterMaCN.Location = new Point(110, 0);
            txtFilterMaCN.Name = "txtFilterMaCN";
            txtFilterMaCN.PlaceholderText = "Tìm mã CN";
            txtFilterMaCN.Size = new Size(150, 38);
            txtFilterMaCN.TabIndex = 7;
            txtFilterMaCN.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFilterTenCN
            // 
            txtFilterTenCN.Font = new Font("Times New Roman", 13.2F);
            txtFilterTenCN.Location = new Point(260, 0);
            txtFilterTenCN.Name = "txtFilterTenCN";
            txtFilterTenCN.PlaceholderText = "Tìm tên CN";
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
            // btnExport
            // 
            btnExport.Location = new Point(50, 850);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(150, 50);
            btnExport.TabIndex = 19;
            btnExport.Text = "Xuất Excel";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(cboXaPhuong);
            panel3.Controls.Add(btnExport);
            panel3.Controls.Add(dgvConstruction);
            panel3.Controls.Add(panelFilter);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1884, 926);
            panel3.TabIndex = 23;
            // 
            // cboXaPhuong
            // 
            cboXaPhuong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboXaPhuong.Items.AddRange(new object[] { "5.600", "7.200", "10.200", "15.300" });
            cboXaPhuong.Location = new Point(1170, 0);
            cboXaPhuong.Margin = new Padding(4, 5, 4, 5);
            cboXaPhuong.Name = "cboXaPhuong";
            cboXaPhuong.Size = new Size(270, 37);
            cboXaPhuong.TabIndex = 21;
            // 
            // HopDong
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Font = new Font("Times New Roman", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "HopDong";
            Size = new Size(1884, 981);
            ((System.ComponentModel.ISupportInitialize)dgvConstruction).EndInit();
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRemoveFilter).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.IContainer components;
        private Panel panel3;
        private Button btnExport;
        private DateTimePicker dtpFilterNgayKetThuc;
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
        private ComboBox comboBox1;
        private ComboBox cboXaPhuong;
    }
}