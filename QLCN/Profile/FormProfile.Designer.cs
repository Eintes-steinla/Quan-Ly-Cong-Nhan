namespace QLCN
{
    partial class FormProfile
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblName = new Label();
            txtName = new TextBox();
            lblGender = new Label();
            cbGender = new ComboBox();
            lblDob = new Label();
            dtpDob = new DateTimePicker();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            txtCCCD = new TextBox();
            btnSave = new Button();
            btnClose = new Button();
            title = new Label();
            lblCCCD = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Location = new Point(50, 90);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 23);
            lblName.TabIndex = 0;
            lblName.Text = "Họ và Tên:";
            // 
            // txtName
            // 
            txtName.Location = new Point(170, 90);
            txtName.Name = "txtName";
            txtName.Size = new Size(318, 31);
            txtName.TabIndex = 1;
            // 
            // lblGender
            // 
            lblGender.Location = new Point(50, 130);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(100, 23);
            lblGender.TabIndex = 2;
            lblGender.Text = "Giới tính:";
            // 
            // cbGender
            // 
            cbGender.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cbGender.Location = new Point(170, 130);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(318, 33);
            cbGender.TabIndex = 3;
            // 
            // lblDob
            // 
            lblDob.Location = new Point(50, 170);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(100, 23);
            lblDob.TabIndex = 4;
            lblDob.Text = "Ngày sinh:";
            // 
            // dtpDob
            // 
            dtpDob.Format = DateTimePickerFormat.Custom;
            dtpDob.Location = new Point(170, 170);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(318, 31);
            dtpDob.TabIndex = 5;
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(50, 210);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 23);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Số điện thoại:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(170, 210);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(318, 31);
            txtPhone.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(50, 250);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(170, 250);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(318, 31);
            txtEmail.TabIndex = 9;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // lblAddress
            // 
            lblAddress.Location = new Point(50, 290);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(100, 23);
            lblAddress.TabIndex = 10;
            lblAddress.Text = "Địa chỉ:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(170, 290);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(318, 31);
            txtAddress.TabIndex = 11;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(170, 330);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(318, 31);
            txtCCCD.TabIndex = 13;
            txtCCCD.TextChanged += txtCCCD_TextChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(170, 380);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 37);
            btnSave.TabIndex = 14;
            btnSave.Text = "Lưu";
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(413, 380);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 37);
            btnClose.TabIndex = 15;
            btnClose.Text = "Đóng";
            btnClose.Click += btnClose_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            title.Location = new Point(136, 25);
            title.Name = "title";
            title.Size = new Size(274, 45);
            title.TabIndex = 16;
            title.Text = "Hồ sơ công nhân";
            title.Click += label1_Click;
            // 
            // lblCCCD
            // 
            lblCCCD.Location = new Point(50, 330);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(100, 23);
            lblCCCD.TabIndex = 12;
            lblCCCD.Text = "Số CCCD:";
            lblCCCD.Click += lblCCCD_Click;
            // 
            // FormProfile
            // 
            ClientSize = new Size(545, 487);
            Controls.Add(title);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblGender);
            Controls.Add(cbGender);
            Controls.Add(lblDob);
            Controls.Add(dtpDob);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblCCCD);
            Controls.Add(txtCCCD);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Name = "FormProfile";
            Text = "Thông tin cá nhân";
            Load += FormProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private Label title;
        protected DateTimePicker dtpDob;
        private Label lblCCCD;
    }
}
