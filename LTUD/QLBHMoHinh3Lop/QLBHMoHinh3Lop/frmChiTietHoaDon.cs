using BUS;
using ET_QLSV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBHMoHinh3Lop
{
    public partial class frmChiTietHoaDon : Form
    {
        BUS_HoaDon bUS_HoaDon = new BUS_HoaDon();
        BUS_SanPham bUS_SanPham = new BUS_SanPham();
        BUS_ChiTietHoaDon bUS_ChiTietHoaDon = new BUS_ChiTietHoaDon();
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            dgvChiTietHoaDon.DataSource = bUS_ChiTietHoaDon.LayDanhSachChiTietDonHang();
            cboMaHD.DataSource = bUS_HoaDon.LayDanhSachHoaDon();
            cboMaHD.DisplayMember = "MaHD";
            cboMaHD.ValueMember = "MaHD";
            cboMaSP.DataSource = bUS_SanPham.LayDSSanPham();
            cboMaSP.DisplayMember = "MaSP";
            cboMaSP.ValueMember = "MaSP";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dgvChiTietHoaDon.SelectedCells[0].RowIndex;
            cboMaHD.Text = dgvChiTietHoaDon.Rows[dong].Cells[0].Value.ToString();
            cboMaSP.Text = dgvChiTietHoaDon.Rows[dong].Cells[1].Value.ToString();
            txtSL.Text = dgvChiTietHoaDon.Rows[dong].Cells[2].Value.ToString();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mHD = cboMaHD.Text;
            string mSP = cboMaSP.Text;
            int sl = int.Parse(txtSL.Text);
            ET_ChiTietHoaDon eT_ChiTietHoaDon = new ET_ChiTietHoaDon(mHD, mSP, sl);
            if (bUS_ChiTietHoaDon.ThemChiTietDonHang(eT_ChiTietHoaDon))
            {
                MessageBox.Show("Them chi tiet don hang thanh cong.");
            }
            else
            {
                MessageBox.Show("Them chi tiet don hang khong thanh cong.");
            }
            dgvChiTietHoaDon.DataSource = bUS_ChiTietHoaDon.LayDanhSachChiTietDonHang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mHD = cboMaHD.Text;
            string mSP = cboMaSP.Text;
            int sl = int.Parse(txtSL.Text);
            ET_ChiTietHoaDon eT_ChiTietHoaDon = new ET_ChiTietHoaDon(mHD, mSP, sl);
            if (bUS_ChiTietHoaDon.SuaChiTietDonHang(eT_ChiTietHoaDon))
            {
                MessageBox.Show("Sua chi tiet don hang thanh cong.");
            }
            else
            {
                MessageBox.Show("Sua chi tiet don hang khong thanh cong.");
            }
            dgvChiTietHoaDon.DataSource = bUS_ChiTietHoaDon.LayDanhSachChiTietDonHang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mHD = cboMaHD.Text;
           
            if (bUS_ChiTietHoaDon.XoaChiTietDonHang(mHD))
            {
                MessageBox.Show("Xoa chi tiet don hang thanh cong.");
            }
            else
            {
                MessageBox.Show("Xoa chi tiet don hang khong thanh cong.");
            }
            dgvChiTietHoaDon.DataSource = bUS_ChiTietHoaDon.LayDanhSachChiTietDonHang();
        }
    }
}
