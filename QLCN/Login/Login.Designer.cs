namespace QLCN
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTiltle = new Label();
            lblTenDangNhap = new Label();
            txtMatKhau = new TextBox();
            linkLblQuenMK = new LinkLabel();
            btnDangNhap = new Button();
            lblMatKhau = new Label();
            btnThoat = new Button();
            txtTenDangNhap = new TextBox();
            SuspendLayout();
            // 
            // lblTiltle
            // 
            lblTiltle.AutoSize = true;
            lblTiltle.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTiltle.Location = new Point(200, 50);
            lblTiltle.Name = "lblTiltle";
            lblTiltle.Size = new Size(350, 41);
            lblTiltle.TabIndex = 0;
            lblTiltle.Text = "Đăng Nhập Hệ Thống";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenDangNhap.Location = new Point(100, 150);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(160, 27);
            lblTenDangNhap.TabIndex = 1;
            lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(300, 200);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(300, 31);
            txtMatKhau.TabIndex = 4;
            // 
            // linkLblQuenMK
            // 
            linkLblQuenMK.AutoSize = true;
            linkLblQuenMK.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLblQuenMK.Location = new Point(475, 250);
            linkLblQuenMK.Name = "linkLblQuenMK";
            linkLblQuenMK.Size = new Size(125, 22);
            linkLblQuenMK.TabIndex = 5;
            linkLblQuenMK.TabStop = true;
            linkLblQuenMK.Text = "Quên mật khẩu";
            // 
            // btnDangNhap
            // 
            btnDangNhap.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.Location = new Point(300, 300);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(120, 30);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMatKhau.Location = new Point(100, 200);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(110, 27);
            lblMatKhau.TabIndex = 8;
            lblMatKhau.Text = "Mật khẩu:";
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(480, 300);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(120, 30);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(300, 150);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(300, 31);
            txtTenDangNhap.TabIndex = 10;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 423);
            Controls.Add(txtTenDangNhap);
            Controls.Add(btnThoat);
            Controls.Add(lblMatKhau);
            Controls.Add(btnDangNhap);
            Controls.Add(linkLblQuenMK);
            Controls.Add(txtMatKhau);
            Controls.Add(lblTenDangNhap);
            Controls.Add(lblTiltle);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTiltle;
        private Label lblTenDangNhap;
        private Label label3;
        private TextBox textBox1;
        private TextBox txtMatKhau;
        private LinkLabel linkLblQuenMK;
        private Button btnDangNhap;
        private Label lblMatKhau;
        private Button btnThoat;
        private TextBox txtTenDangNhap;
    }
}