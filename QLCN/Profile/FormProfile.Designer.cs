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
            lblPosition = new Label();
            txtPosition = new TextBox();
            btnSave = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Location = new Point(30, 30);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 23);
            lblName.TabIndex = 0;
            lblName.Text = "Họ và Tên:";
            // 
            // txtName
            // 
            txtName.Location = new Point(150, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(318, 31);
            txtName.TabIndex = 1;
            // 
            // lblGender
            // 
            lblGender.Location = new Point(30, 70);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(100, 23);
            lblGender.TabIndex = 2;
            lblGender.Text = "Giới tính:";
            // 
            // cbGender
            // 
            cbGender.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cbGender.Location = new Point(150, 70);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(318, 33);
            cbGender.TabIndex = 3;
            // 
            // lblDob
            // 
            lblDob.Location = new Point(30, 110);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(100, 23);
            lblDob.TabIndex = 4;
            lblDob.Text = "Ngày sinh:";
            // 
            // dtpDob
            // 
            dtpDob.Location = new Point(150, 110);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(318, 31);
            dtpDob.TabIndex = 5;
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(30, 150);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 23);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Số điện thoại:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(150, 150);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(318, 31);
            txtPhone.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(30, 190);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 190);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(318, 31);
            txtEmail.TabIndex = 9;
            // 
            // lblAddress
            // 
            lblAddress.Location = new Point(30, 230);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(100, 23);
            lblAddress.TabIndex = 10;
            lblAddress.Text = "Địa chỉ:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(150, 230);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(318, 31);
            txtAddress.TabIndex = 11;
            // 
            // lblPosition
            // 
            lblPosition.Location = new Point(30, 270);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(100, 23);
            lblPosition.TabIndex = 12;
            lblPosition.Text = "Chức vụ:";
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(150, 270);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(318, 31);
            txtPosition.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(150, 320);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 37);
            btnSave.TabIndex = 14;
            btnSave.Text = "Lưu";
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(393, 320);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 37);
            btnClose.TabIndex = 15;
            btnClose.Text = "Đóng";
            btnClose.Click += btnClose_Click;
            // 
            // FormProfile
            // 
            ClientSize = new Size(541, 400);
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
            Controls.Add(lblPosition);
            Controls.Add(txtPosition);
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
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}
