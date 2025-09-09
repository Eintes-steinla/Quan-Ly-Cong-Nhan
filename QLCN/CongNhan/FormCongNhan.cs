namespace QLCN.CongNhan
{
    public partial class CongNhan : UserControl
    {
        public CongNhan()
        {
            InitializeComponent();
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            // Ví dụ: kiểm tra chỉ cho nhập số
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtSDT.Text, "^[0-9]*$"))
            {
                lblMessage.Text = "Chỉ được nhập số!";
                lblMessage.ForeColor = Color.Red;
            }
            else
            {
                lblMessage.Text = "";
            }
        }


    }
}
