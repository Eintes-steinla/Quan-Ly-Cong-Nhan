namespace QLCN
{
    partial class FormBaoCao
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblLoai, lblFrom, lblTo;
        private ComboBox cboLoaiBaoCao;
        private DateTimePicker dtpFrom, dtpTo;
        private Button btnView, btnExport;
        private DataGridView dgvBaoCao;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblLoai = new Label();
            lblFrom = new Label();
            lblTo = new Label();
            cboLoaiBaoCao = new ComboBox();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            btnView = new Button();
            btnExport = new Button();
            dgvBaoCao = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).BeginInit();
            SuspendLayout();
            // 
            // lblLoai
            // 
            lblLoai.Location = new Point(30, 30);
            lblLoai.Name = "lblLoai";
            lblLoai.Size = new Size(121, 31);
            lblLoai.TabIndex = 0;
            lblLoai.Text = "Loại báo cáo:";
            // 
            // lblFrom
            // 
            lblFrom.Location = new Point(30, 72);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(121, 23);
            lblFrom.TabIndex = 2;
            lblFrom.Text = "Từ ngày:";
            // 
            // lblTo
            // 
            lblTo.Location = new Point(30, 112);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(100, 23);
            lblTo.TabIndex = 4;
            lblTo.Text = "Đến ngày:";
            // 
            // cboLoaiBaoCao
            // 
            cboLoaiBaoCao.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiBaoCao.Location = new Point(157, 20);
            cboLoaiBaoCao.Name = "cboLoaiBaoCao";
            cboLoaiBaoCao.Size = new Size(200, 33);
            cboLoaiBaoCao.TabIndex = 1;
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(157, 64);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(200, 31);
            dtpFrom.TabIndex = 3;
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(157, 104);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(200, 31);
            dtpTo.TabIndex = 5;
            // 
            // btnView
            // 
            btnView.Location = new Point(403, 20);
            btnView.Name = "btnView";
            btnView.Size = new Size(129, 33);
            btnView.TabIndex = 6;
            btnView.Text = "Xem báo cáo";
            btnView.Click += btnView_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(403, 64);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(129, 31);
            btnExport.TabIndex = 7;
            btnExport.Text = "Xuất báo cáo";
            btnExport.Click += btnExport_Click;
            // 
            // dgvBaoCao
            // 
            dgvBaoCao.ColumnHeadersHeight = 34;
            dgvBaoCao.Location = new Point(30, 161);
            dgvBaoCao.Name = "dgvBaoCao";
            dgvBaoCao.RowHeadersWidth = 62;
            dgvBaoCao.Size = new Size(502, 277);
            dgvBaoCao.TabIndex = 8;
            // 
            // FormBaoCao
            // 
            ClientSize = new Size(575, 500);
            Controls.Add(lblLoai);
            Controls.Add(cboLoaiBaoCao);
            Controls.Add(lblFrom);
            Controls.Add(dtpFrom);
            Controls.Add(lblTo);
            Controls.Add(dtpTo);
            Controls.Add(btnView);
            Controls.Add(btnExport);
            Controls.Add(dgvBaoCao);
            Name = "FormBaoCao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Báo Cáo Thống Kê";
            Load += FormBaoCao_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).EndInit();
            ResumeLayout(false);
        }
    }
}
