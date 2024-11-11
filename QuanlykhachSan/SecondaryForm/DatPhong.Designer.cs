namespace QuanlykhachSan.SecondaryForm
{
    partial class frnDatPhong
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
            dgvKhachHang = new DataGridView();
            lblDatPhong = new Label();
            txtIDPhong = new TextBox();
            lblTinhTrangPhong = new Label();
            grpThongTin = new GroupBox();
            txtTinhTrangPhong = new TextBox();
            lblIDPhong = new Label();
            txtNgayTraPhong = new TextBox();
            lblNgayTraPhong = new Label();
            txtNgayNhanPhong = new TextBox();
            lblNgayNhanPhong = new Label();
            txtNgayDatPhong = new TextBox();
            lblNgayDatPhong = new Label();
            txtIDKhangHang = new TextBox();
            lblIDKhachHang = new Label();
            txtIDDatPhong = new TextBox();
            lblIDDatPhong = new Label();
            btnSua = new Button();
            btnTimKiem = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            grpThaoTac = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            grpThongTin.SuspendLayout();
            grpThaoTac.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(37, 229);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.Size = new Size(726, 209);
            dgvKhachHang.TabIndex = 19;
            // 
            // lblDatPhong
            // 
            lblDatPhong.AutoSize = true;
            lblDatPhong.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatPhong.Location = new Point(259, 24);
            lblDatPhong.Name = "lblDatPhong";
            lblDatPhong.Size = new Size(261, 30);
            lblDatPhong.TabIndex = 18;
            lblDatPhong.Text = "DANH MỤC ĐẶT PHÒNG";
            // 
            // txtIDPhong
            // 
            txtIDPhong.BorderStyle = BorderStyle.FixedSingle;
            txtIDPhong.Location = new Point(130, 82);
            txtIDPhong.Name = "txtIDPhong";
            txtIDPhong.Size = new Size(85, 23);
            txtIDPhong.TabIndex = 11;
            // 
            // lblTinhTrangPhong
            // 
            lblTinhTrangPhong.AutoSize = true;
            lblTinhTrangPhong.Location = new Point(18, 114);
            lblTinhTrangPhong.Name = "lblTinhTrangPhong";
            lblTinhTrangPhong.Size = new Size(107, 15);
            lblTinhTrangPhong.TabIndex = 10;
            lblTinhTrangPhong.Text = "-Tình trạng phòng:";
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(txtTinhTrangPhong);
            grpThongTin.Controls.Add(lblIDPhong);
            grpThongTin.Controls.Add(txtNgayTraPhong);
            grpThongTin.Controls.Add(lblNgayTraPhong);
            grpThongTin.Controls.Add(txtIDPhong);
            grpThongTin.Controls.Add(lblTinhTrangPhong);
            grpThongTin.Controls.Add(txtNgayNhanPhong);
            grpThongTin.Controls.Add(lblNgayNhanPhong);
            grpThongTin.Controls.Add(txtNgayDatPhong);
            grpThongTin.Controls.Add(lblNgayDatPhong);
            grpThongTin.Controls.Add(txtIDKhangHang);
            grpThongTin.Controls.Add(lblIDKhachHang);
            grpThongTin.Controls.Add(txtIDDatPhong);
            grpThongTin.Controls.Add(lblIDDatPhong);
            grpThongTin.Location = new Point(37, 69);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(453, 154);
            grpThongTin.TabIndex = 20;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin";
            // 
            // txtTinhTrangPhong
            // 
            txtTinhTrangPhong.BorderStyle = BorderStyle.FixedSingle;
            txtTinhTrangPhong.Location = new Point(130, 111);
            txtTinhTrangPhong.Name = "txtTinhTrangPhong";
            txtTinhTrangPhong.Size = new Size(86, 23);
            txtTinhTrangPhong.TabIndex = 15;
            // 
            // lblIDPhong
            // 
            lblIDPhong.AutoSize = true;
            lblIDPhong.Location = new Point(18, 86);
            lblIDPhong.Name = "lblIDPhong";
            lblIDPhong.Size = new Size(70, 15);
            lblIDPhong.TabIndex = 14;
            lblIDPhong.Text = "-Mã phòng:";
            // 
            // txtNgayTraPhong
            // 
            txtNgayTraPhong.BorderStyle = BorderStyle.FixedSingle;
            txtNgayTraPhong.Location = new Point(336, 82);
            txtNgayTraPhong.Name = "txtNgayTraPhong";
            txtNgayTraPhong.Size = new Size(101, 23);
            txtNgayTraPhong.TabIndex = 13;
            txtNgayTraPhong.TextChanged += textBox1_TextChanged;
            // 
            // lblNgayTraPhong
            // 
            lblNgayTraPhong.AutoSize = true;
            lblNgayTraPhong.Location = new Point(221, 86);
            lblNgayTraPhong.Name = "lblNgayTraPhong";
            lblNgayTraPhong.Size = new Size(98, 15);
            lblNgayTraPhong.TabIndex = 12;
            lblNgayTraPhong.Text = "-Ngày trả phòng:";
            // 
            // txtNgayNhanPhong
            // 
            txtNgayNhanPhong.BorderStyle = BorderStyle.FixedSingle;
            txtNgayNhanPhong.Location = new Point(336, 53);
            txtNgayNhanPhong.Name = "txtNgayNhanPhong";
            txtNgayNhanPhong.Size = new Size(101, 23);
            txtNgayNhanPhong.TabIndex = 9;
            // 
            // lblNgayNhanPhong
            // 
            lblNgayNhanPhong.AutoSize = true;
            lblNgayNhanPhong.Location = new Point(222, 56);
            lblNgayNhanPhong.Name = "lblNgayNhanPhong";
            lblNgayNhanPhong.Size = new Size(111, 15);
            lblNgayNhanPhong.TabIndex = 8;
            lblNgayNhanPhong.Text = "-Ngày nhận phòng:";
            // 
            // txtNgayDatPhong
            // 
            txtNgayDatPhong.BorderStyle = BorderStyle.FixedSingle;
            txtNgayDatPhong.Location = new Point(336, 24);
            txtNgayDatPhong.Name = "txtNgayDatPhong";
            txtNgayDatPhong.Size = new Size(101, 23);
            txtNgayDatPhong.TabIndex = 7;
            // 
            // lblNgayDatPhong
            // 
            lblNgayDatPhong.AutoSize = true;
            lblNgayDatPhong.Location = new Point(222, 28);
            lblNgayDatPhong.Name = "lblNgayDatPhong";
            lblNgayDatPhong.Size = new Size(101, 15);
            lblNgayDatPhong.TabIndex = 6;
            lblNgayDatPhong.Text = "-Ngày đặt phòng:";
            // 
            // txtIDKhangHang
            // 
            txtIDKhangHang.BorderStyle = BorderStyle.FixedSingle;
            txtIDKhangHang.Location = new Point(130, 53);
            txtIDKhangHang.Name = "txtIDKhangHang";
            txtIDKhangHang.Size = new Size(86, 23);
            txtIDKhangHang.TabIndex = 5;
            // 
            // lblIDKhachHang
            // 
            lblIDKhachHang.AutoSize = true;
            lblIDKhachHang.Location = new Point(18, 57);
            lblIDKhachHang.Name = "lblIDKhachHang";
            lblIDKhachHang.Size = new Size(97, 15);
            lblIDKhachHang.TabIndex = 4;
            lblIDKhachHang.Text = "-Mã khách hàng:";
            // 
            // txtIDDatPhong
            // 
            txtIDDatPhong.BorderStyle = BorderStyle.FixedSingle;
            txtIDDatPhong.Location = new Point(130, 24);
            txtIDDatPhong.Name = "txtIDDatPhong";
            txtIDDatPhong.Size = new Size(86, 23);
            txtIDDatPhong.TabIndex = 3;
            // 
            // lblIDDatPhong
            // 
            lblIDDatPhong.AutoSize = true;
            lblIDDatPhong.Location = new Point(18, 28);
            lblIDDatPhong.Name = "lblIDDatPhong";
            lblIDDatPhong.Size = new Size(90, 15);
            lblIDDatPhong.TabIndex = 2;
            lblIDDatPhong.Text = "-Mã đặt phòng:";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(39, 87);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(93, 38);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(138, 87);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(93, 38);
            btnTimKiem.TabIndex = 11;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(39, 43);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(93, 38);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(138, 43);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(93, 38);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // grpThaoTac
            // 
            grpThaoTac.Controls.Add(btnSua);
            grpThaoTac.Controls.Add(btnTimKiem);
            grpThaoTac.Controls.Add(btnThem);
            grpThaoTac.Controls.Add(btnXoa);
            grpThaoTac.Location = new Point(496, 69);
            grpThaoTac.Name = "grpThaoTac";
            grpThaoTac.Size = new Size(267, 154);
            grpThaoTac.TabIndex = 21;
            grpThaoTac.TabStop = false;
            grpThaoTac.Text = "Thao tác";
            // 
            // frnDatPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvKhachHang);
            Controls.Add(lblDatPhong);
            Controls.Add(grpThongTin);
            Controls.Add(grpThaoTac);
            Name = "frnDatPhong";
            Text = "DatPhong";
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            grpThaoTac.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKhachHang;
        private Label lblDatPhong;
        private TextBox txtIDPhong;
        private Label lblTinhTrangPhong;
        private GroupBox grpThongTin;
        private TextBox txtNgayNhanPhong;
        private Label lblNgayNhanPhong;
        private TextBox txtNgayDatPhong;
        private Label lblNgayDatPhong;
        private TextBox txtIDKhangHang;
        private Label lblIDKhachHang;
        private TextBox txtIDDatPhong;
        private Label lblIDDatPhong;
        private Button btnSua;
        private Button btnTimKiem;
        private Button btnThem;
        private Button btnXoa;
        private GroupBox grpThaoTac;
        private TextBox txtNgayTraPhong;
        private Label lblNgayTraPhong;
        private TextBox txtTinhTrangPhong;
        private Label lblIDPhong;
    }
}