using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanlykhachSan.SecondaryForm;

namespace QuanlykhachSan
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            LoadForm(new frmNhanVien());
        }

        private void LoadForm(Form form)
        {
            foreach (Control control in pnlChung.Controls)
            {
                {
                    control.Dispose();
                }
            }

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;

            pnlChung.Controls.Add(form);
            form.Show();

            form.Location = new Point(
                (pnlChung.Width - form.Width) / 2,
                (pnlChung.Height - form.Height) / 2
                );
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            LoadForm(new frmKhachHang());
        }

        private void mnuPhong_Click(object sender, EventArgs e)
        {
            LoadForm(new frmPhong());
        }

        private void mnuDatPhong_Click(object sender, EventArgs e)
        {
            LoadForm(new frnDatPhong());
        }

        private void mnuDichVu_Click(object sender, EventArgs e)
        {
            LoadForm(new frmDichVu());
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            LoadForm(new frmHoaDon());
        }

        private void mnuChiTietHoaDon_Click(object sender, EventArgs e)
        {
            LoadForm(new frmChiTietHoaDon());
        }
    }
}
