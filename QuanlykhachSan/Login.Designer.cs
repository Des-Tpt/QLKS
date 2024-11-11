namespace QuanlykhachSan
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTenDangNhap = new Label();
            lblMatKhau = new Label();
            lblTitle = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            grpDangNhap = new GroupBox();
            lblThongTin = new Label();
            btnDangNhap = new Button();
            grpDangNhap.SuspendLayout();
            SuspendLayout();
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Location = new Point(71, 46);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(88, 15);
            lblTenDangNhap.TabIndex = 0;
            lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(71, 82);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(60, 15);
            lblMatKhau.TabIndex = 1;
            lblMatKhau.Text = "Mật khẩu:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(117, 63);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(413, 26);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "PHẦN MỀM QUẢN LÝ KHÁCH SẠN";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(165, 43);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(249, 23);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(165, 79);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(249, 23);
            txtPassword.TabIndex = 3;
            // 
            // grpDangNhap
            // 
            grpDangNhap.Controls.Add(lblThongTin);
            grpDangNhap.Controls.Add(btnDangNhap);
            grpDangNhap.Controls.Add(txtUsername);
            grpDangNhap.Controls.Add(txtPassword);
            grpDangNhap.Controls.Add(lblTenDangNhap);
            grpDangNhap.Controls.Add(lblMatKhau);
            grpDangNhap.Location = new Point(71, 113);
            grpDangNhap.Name = "grpDangNhap";
            grpDangNhap.Size = new Size(489, 226);
            grpDangNhap.TabIndex = 4;
            grpDangNhap.TabStop = false;
            grpDangNhap.Text = "Đăng nhập";
            // 
            // lblThongTin
            // 
            lblThongTin.AutoSize = true;
            lblThongTin.Location = new Point(176, 126);
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Size = new Size(142, 15);
            lblThongTin.TabIndex = 5;
            lblThongTin.Text = "Vui lòng nhập thông tin...";
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.PaleGreen;
            btnDangNhap.Location = new Point(185, 159);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(124, 34);
            btnDangNhap.TabIndex = 5;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(639, 370);
            Controls.Add(grpDangNhap);
            Controls.Add(lblTitle);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            Text = "Đăng nhập";
            grpDangNhap.ResumeLayout(false);
            grpDangNhap.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTenDangNhap;
        private Label lblMatKhau;
        private Label lblTitle;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private GroupBox grpDangNhap;
        private Label lblThongTin;
        private Button btnDangNhap;
    }
}
