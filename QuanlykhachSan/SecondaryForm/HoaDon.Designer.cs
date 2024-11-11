
namespace QuanlykhachSan.SecondaryForm
{
    partial class frmHoaDon
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
            grpThaoTac = new GroupBox();
            btnSua = new Button();
            btnTimKiem = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            txtIDPhong = new TextBox();
            lblIDPhong = new Label();
            grpThongTin = new GroupBox();
            txtNgayLap = new TextBox();
            lblNgayLap = new Label();
            txtIDDatPhong = new TextBox();
            lblIDDatPhong = new Label();
            txtIDHoaDon = new TextBox();
            lblIDHoaDon = new Label();
            dgvNhanVien = new DataGridView();
            lblHoaDon = new Label();
            grpThaoTac.SuspendLayout();
            grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // grpThaoTac
            // 
            grpThaoTac.Controls.Add(btnSua);
            grpThaoTac.Controls.Add(btnTimKiem);
            grpThaoTac.Controls.Add(btnThem);
            grpThaoTac.Controls.Add(btnXoa);
            grpThaoTac.Location = new Point(459, 68);
            grpThaoTac.Name = "grpThaoTac";
            grpThaoTac.Size = new Size(304, 124);
            grpThaoTac.TabIndex = 17;
            grpThaoTac.TabStop = false;
            grpThaoTac.Text = "Thao tác";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(47, 73);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(93, 38);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(162, 72);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(93, 38);
            btnTimKiem.TabIndex = 11;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(47, 28);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(93, 38);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(162, 28);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(93, 38);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // txtIDPhong
            // 
            txtIDPhong.BorderStyle = BorderStyle.FixedSingle;
            txtIDPhong.Location = new Point(305, 67);
            txtIDPhong.Name = "txtIDPhong";
            txtIDPhong.Size = new Size(89, 23);
            txtIDPhong.TabIndex = 9;
            txtIDPhong.TextChanged += txtIDPhong_TextChanged;
            // 
            // lblIDPhong
            // 
            lblIDPhong.AutoSize = true;
            lblIDPhong.Location = new Point(233, 71);
            lblIDPhong.Name = "lblIDPhong";
            lblIDPhong.Size = new Size(70, 15);
            lblIDPhong.TabIndex = 8;
            lblIDPhong.Text = "-Mã phòng:";
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(txtIDPhong);
            grpThongTin.Controls.Add(lblIDPhong);
            grpThongTin.Controls.Add(txtNgayLap);
            grpThongTin.Controls.Add(lblNgayLap);
            grpThongTin.Controls.Add(txtIDDatPhong);
            grpThongTin.Controls.Add(lblIDDatPhong);
            grpThongTin.Controls.Add(txtIDHoaDon);
            grpThongTin.Controls.Add(lblIDHoaDon);
            grpThongTin.Location = new Point(37, 68);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(416, 124);
            grpThongTin.TabIndex = 16;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin";
            // 
            // txtNgayLap
            // 
            txtNgayLap.BorderStyle = BorderStyle.FixedSingle;
            txtNgayLap.Location = new Point(305, 38);
            txtNgayLap.Name = "txtNgayLap";
            txtNgayLap.Size = new Size(89, 23);
            txtNgayLap.TabIndex = 7;
            // 
            // lblNgayLap
            // 
            lblNgayLap.AutoSize = true;
            lblNgayLap.Location = new Point(234, 42);
            lblNgayLap.Name = "lblNgayLap";
            lblNgayLap.Size = new Size(62, 15);
            lblNgayLap.TabIndex = 6;
            lblNgayLap.Text = "-Ngày lập:";
            // 
            // txtIDDatPhong
            // 
            txtIDDatPhong.BorderStyle = BorderStyle.FixedSingle;
            txtIDDatPhong.Location = new Point(124, 67);
            txtIDDatPhong.Name = "txtIDDatPhong";
            txtIDDatPhong.Size = new Size(82, 23);
            txtIDDatPhong.TabIndex = 5;
            // 
            // lblIDDatPhong
            // 
            lblIDDatPhong.AutoSize = true;
            lblIDDatPhong.Location = new Point(28, 71);
            lblIDDatPhong.Name = "lblIDDatPhong";
            lblIDDatPhong.Size = new Size(90, 15);
            lblIDDatPhong.TabIndex = 4;
            lblIDDatPhong.Text = "-Mã đặt phòng:";
            // 
            // txtIDHoaDon
            // 
            txtIDHoaDon.BorderStyle = BorderStyle.FixedSingle;
            txtIDHoaDon.Location = new Point(124, 38);
            txtIDHoaDon.Name = "txtIDHoaDon";
            txtIDHoaDon.Size = new Size(82, 23);
            txtIDHoaDon.TabIndex = 3;
            // 
            // lblIDHoaDon
            // 
            lblIDHoaDon.AutoSize = true;
            lblIDHoaDon.Location = new Point(28, 41);
            lblIDHoaDon.Name = "lblIDHoaDon";
            lblIDHoaDon.Size = new Size(79, 15);
            lblIDHoaDon.TabIndex = 2;
            lblIDHoaDon.Text = "-Mã hóa đơn:";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(37, 198);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.Size = new Size(726, 240);
            dgvNhanVien.TabIndex = 15;
            // 
            // lblHoaDon
            // 
            lblHoaDon.AutoSize = true;
            lblHoaDon.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoaDon.Location = new Point(268, 24);
            lblHoaDon.Name = "lblHoaDon";
            lblHoaDon.Size = new Size(237, 30);
            lblHoaDon.TabIndex = 14;
            lblHoaDon.Text = "DANH MỤC HÓA ĐƠN";
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpThaoTac);
            Controls.Add(grpThongTin);
            Controls.Add(dgvNhanVien);
            Controls.Add(lblHoaDon);
            Name = "frmHoaDon";
            Text = "HoaDon";
            grpThaoTac.ResumeLayout(false);
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtIDPhong_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox grpThaoTac;
        private Button btnSua;
        private Button btnTimKiem;
        private Button btnThem;
        private Button btnXoa;
        private TextBox txtIDPhong;
        private Label lblIDPhong;
        private GroupBox grpThongTin;
        private TextBox txtNgayLap;
        private Label lblNgayLap;
        private TextBox txtIDDatPhong;
        private Label lblIDDatPhong;
        private TextBox txtIDHoaDon;
        private Label lblIDHoaDon;
        private DataGridView dgvNhanVien;
        private Label lblHoaDon;
    }
}