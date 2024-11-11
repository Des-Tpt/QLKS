namespace QuanlykhachSan.SecondaryForm
{
    partial class frmChiTietHoaDon
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
            grpThongTin = new GroupBox();
            textBox1 = new TextBox();
            lblSoLanSuDungDichVuDo = new Label();
            txtTongTien = new TextBox();
            lblIDHoaDon = new Label();
            lblNgayLap = new Label();
            txtIDHoaDon = new TextBox();
            lblIDChiTietHoaDon = new Label();
            dgvNhanVien = new DataGridView();
            lblChiTietHoaDon = new Label();
            btnSua = new Button();
            btnTimKiem = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            grpThaoTac = new GroupBox();
            txtNgayLap = new TextBox();
            grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            grpThaoTac.SuspendLayout();
            SuspendLayout();
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(textBox1);
            grpThongTin.Controls.Add(lblSoLanSuDungDichVuDo);
            grpThongTin.Controls.Add(txtTongTien);
            grpThongTin.Controls.Add(lblIDHoaDon);
            grpThongTin.Controls.Add(txtNgayLap);
            grpThongTin.Controls.Add(lblNgayLap);
            grpThongTin.Controls.Add(txtIDHoaDon);
            grpThongTin.Controls.Add(lblIDChiTietHoaDon);
            grpThongTin.Location = new Point(37, 68);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(416, 123);
            grpThongTin.TabIndex = 20;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(204, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(62, 23);
            textBox1.TabIndex = 13;
            // 
            // lblSoLanSuDungDichVuDo
            // 
            lblSoLanSuDungDichVuDo.AutoSize = true;
            lblSoLanSuDungDichVuDo.Location = new Point(23, 89);
            lblSoLanSuDungDichVuDo.Name = "lblSoLanSuDungDichVuDo";
            lblSoLanSuDungDichVuDo.Size = new Size(175, 15);
            lblSoLanSuDungDichVuDo.TabIndex = 12;
            lblSoLanSuDungDichVuDo.Text = "-Số lần đã sử dụng dịch vụ trên:";
            // 
            // txtTongTien
            // 
            txtTongTien.BorderStyle = BorderStyle.FixedSingle;
            txtTongTien.Location = new Point(314, 28);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(81, 23);
            txtTongTien.TabIndex = 11;
            // 
            // lblIDHoaDon
            // 
            lblIDHoaDon.AutoSize = true;
            lblIDHoaDon.Location = new Point(229, 32);
            lblIDHoaDon.Name = "lblIDHoaDon";
            lblIDHoaDon.Size = new Size(79, 15);
            lblIDHoaDon.TabIndex = 8;
            lblIDHoaDon.Text = "-Mã hóa đơn:";
            // 
            // lblNgayLap
            // 
            lblNgayLap.AutoSize = true;
            lblNgayLap.Location = new Point(23, 60);
            lblNgayLap.Name = "lblNgayLap";
            lblNgayLap.Size = new Size(136, 15);
            lblNgayLap.TabIndex = 6;
            lblNgayLap.Text = "-Mã dịch vụ đã sử dụng:";
            // 
            // txtIDHoaDon
            // 
            txtIDHoaDon.BorderStyle = BorderStyle.FixedSingle;
            txtIDHoaDon.Location = new Point(147, 27);
            txtIDHoaDon.Name = "txtIDHoaDon";
            txtIDHoaDon.Size = new Size(76, 23);
            txtIDHoaDon.TabIndex = 3;
            // 
            // lblIDChiTietHoaDon
            // 
            lblIDChiTietHoaDon.AutoSize = true;
            lblIDChiTietHoaDon.Location = new Point(23, 31);
            lblIDChiTietHoaDon.Name = "lblIDChiTietHoaDon";
            lblIDChiTietHoaDon.Size = new Size(118, 15);
            lblIDChiTietHoaDon.TabIndex = 2;
            lblIDChiTietHoaDon.Text = "-Mã hóa đơn chi tiết:";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(37, 197);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.Size = new Size(726, 241);
            dgvNhanVien.TabIndex = 19;
            // 
            // lblChiTietHoaDon
            // 
            lblChiTietHoaDon.AutoSize = true;
            lblChiTietHoaDon.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChiTietHoaDon.Location = new Point(228, 23);
            lblChiTietHoaDon.Name = "lblChiTietHoaDon";
            lblChiTietHoaDon.Size = new Size(327, 30);
            lblChiTietHoaDon.TabIndex = 18;
            lblChiTietHoaDon.Text = "DANH MỤC CHI TIẾT HÓA ĐƠN";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(52, 72);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(93, 38);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(167, 71);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(93, 38);
            btnTimKiem.TabIndex = 11;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(52, 27);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(93, 38);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(167, 27);
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
            grpThaoTac.Location = new Point(459, 68);
            grpThaoTac.Name = "grpThaoTac";
            grpThaoTac.Size = new Size(304, 123);
            grpThaoTac.TabIndex = 21;
            grpThaoTac.TabStop = false;
            grpThaoTac.Text = "Thao tác";
            // 
            // txtNgayLap
            // 
            txtNgayLap.BorderStyle = BorderStyle.FixedSingle;
            txtNgayLap.Location = new Point(204, 85);
            txtNgayLap.Name = "txtNgayLap";
            txtNgayLap.Size = new Size(62, 23);
            txtNgayLap.TabIndex = 7;
            // 
            // frmChiTietHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpThongTin);
            Controls.Add(dgvNhanVien);
            Controls.Add(lblChiTietHoaDon);
            Controls.Add(grpThaoTac);
            Name = "frmChiTietHoaDon";
            Text = "ChiTietHoaDon";
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            grpThaoTac.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpThongTin;
        private TextBox txtTongTien;
        private Label lblIDHoaDon;
        private Label lblNgayLap;
        private TextBox txtIDHoaDon;
        private Label lblIDChiTietHoaDon;
        private DataGridView dgvNhanVien;
        private Label lblChiTietHoaDon;
        private Button btnSua;
        private Button btnTimKiem;
        private Button btnThem;
        private Button btnXoa;
        private GroupBox grpThaoTac;
        private TextBox textBox1;
        private Label lblSoLanSuDungDichVuDo;
        private TextBox txtNgayLap;
    }
}