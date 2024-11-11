namespace QuanlykhachSan
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "as" && password == "123")
            {
                lblThongTin.Text = "Đăng nhập thành công!";
                this.Hide();
                frmMain mainForm = new frmMain();
                mainForm.Show();
            }
            else
            {
                lblThongTin.Text = "Sai mật khẩu hoặc tên đăng nhập!";
                lblThongTin.ForeColor = System.Drawing.Color.FromArgb(255, 153, 153);
            }
        }
    }
}
