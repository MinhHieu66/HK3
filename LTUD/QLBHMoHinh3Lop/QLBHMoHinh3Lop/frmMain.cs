using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBHMoHinh3Lop
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanPham frmSanPham = new frmSanPham();
            frmSanPham.MdiParent = this;
            frmSanPham.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNhanVien = new frmNhanVien();
            frmNhanVien.MdiParent = this;
            frmNhanVien.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon frmHoaDon = new frmHoaDon();
            frmHoaDon.MdiParent = this;
            frmHoaDon.Show();
        }

        private void thànhPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThanhPho frmThanhPho = new frmThanhPho();
            frmThanhPho.MdiParent = this;
            frmThanhPho.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKhachHang = new frmKhachHang();
            frmKhachHang.MdiParent = this;
            frmKhachHang.Show();
        }

        private void chiTiếtĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChiTietHoaDon frmChiTietHoaDon = new frmChiTietHoaDon();
            frmChiTietHoaDon.MdiParent = this;
            frmChiTietHoaDon.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Ban co chac muon thoat khong?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.No) e.Cancel = true;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiem frmTimKiem = new frmTimKiem();
            frmTimKiem.MdiParent = this;
            frmTimKiem.Show();
        }
    }
}
