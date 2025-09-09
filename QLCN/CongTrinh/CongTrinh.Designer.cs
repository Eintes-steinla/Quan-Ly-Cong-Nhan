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
        private Label? lblName;
        private TextBox txtName;
        private Label? lblYear;
        private TextBox txtYear;
        private Label? lblLocation;
        private TextBox txtLocation;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnExport;
        private Panel? panelFilter;
        private DataGridView dgvConstruction;
        private Label lblMessage;
        private TextBox txtFilterName;
        private TextBox txtFilterYear;
        private TextBox txtFilterLocation;
        private PictureBox pictureBoxRemoveFilter;
        private ToolTip? toolTip;
        private DataGridViewTextBoxColumn? dataGridViewColumnSTT;
        private DataGridViewTextBoxColumn? dataGridViewColumnName;
        private DataGridViewTextBoxColumn? dataGridViewColumnYear;
        private DataGridViewTextBoxColumn? dataGridViewColumnLocation;
        private DataGridViewTextBoxColumn? dataGridViewColumnID;
        private DataGridViewCheckBoxColumn dataGridViewColumnCheckBox;
        private System.ComponentModel.Container? components;

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
            btnDelete.Location = new(352, 175);
            btnDelete.Margin = new(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new(160, 36);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Xóa";
            // 
            // btnEdit
            // 
            btnEdit.Location = new(192, 175);
            btnEdit.Margin = new(4, 5, 4, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new(160, 36);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Sửa";
            // 
            // btnAdd
            // 
            btnAdd.Location = new(32, 175);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new(160, 36);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new(513, 175);
            btnRefresh.Margin = new(4, 5, 4, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new(130, 36);
            btnRefresh.TabIndex = 6;
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
            dgvConstruction.Location = new(31, 275);
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
            panelFilter.Location = new(31, 230);
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
            Controls.Add(dgvConstruction);
            Controls.Add(btnRefresh);
            Controls.Add(panelFilter);
            Font = new("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new(4, 5, 4, 5);
            Name = "ConstructionUserControl";
            Size = new(1228, 780);
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
