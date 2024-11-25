using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using ET_QLSV;

namespace QLBHMoHinh3Lop
{
    public partial class frmHoaDon : Form
    {
        BUS_KhachHang bUS_KhachHang = new BUS_KhachHang();
        BUS_NhanVien bUS_NhanVien = new BUS_NhanVien();
        BUS_HoaDon bUS_HoaDon = new BUS_HoaDon();
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = bUS_HoaDon.LayDanhSachHoaDon();
            cboMaKH.DataSource = bUS_KhachHang.LayDanhSachKhachHang();
            cboMaKH.DisplayMember = "MaKH";
            cboMaKH.ValueMember = "MaKH";
            cboMaNV.DataSource = bUS_NhanVien.LayDSNhanVien();
            cboMaNV.DisplayMember = "MaNV";
            cboMaNV.ValueMember = "MaNV";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mahd = txtMaHD.Text;
      
            if (bUS_HoaDon.XoaHoaDon(mahd))
            {
                MessageBox.Show("Xoa hoa don thanh cong.");
            }
            else
            {
                MessageBox.Show("Xoa hoa don khong thanh cong.");
            }
            dgvHoaDon.DataSource = bUS_HoaDon.LayDanhSachHoaDon();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mahd = txtMaHD.Text;
            string makh = cboMaKH.Text;
            string manv = cboMaNV.Text;
            DateTime ngayLapHD = dtpNgayLapHD.Value;
            DateTime ngayNhanHang = dtpNgayNhapHang.Value;

            ET_HoaDon eT_HoaDon = new ET_HoaDon(mahd, makh, manv, ngayLapHD, ngayNhanHang);
            if (bUS_HoaDon.ThemHoaDon(eT_HoaDon))
            {
                MessageBox.Show("Them hoa don thanh cong.");
            }
            else
            {
                MessageBox.Show("Them hoa don khong thanh cong.");
            }
            dgvHoaDon.DataSource = bUS_HoaDon.LayDanhSachHoaDon();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mahd = txtMaHD.Text;
            string makh = cboMaKH.Text;
            string manv = cboMaNV.Text;
            DateTime ngayLapHD = dtpNgayLapHD.Value;
            DateTime ngayNhanHang = dtpNgayNhapHang.Value;

            ET_HoaDon eT_HoaDon = new ET_HoaDon(mahd, makh, manv, ngayLapHD, ngayNhanHang);
            if (bUS_HoaDon.SuaHoaDon(eT_HoaDon))
            {
                MessageBox.Show("Sua hoa don thanh cong.");
            }
            else
            {
                MessageBox.Show("Sua hoa don khong thanh cong.");
            }
            dgvHoaDon.DataSource = bUS_HoaDon.LayDanhSachHoaDon();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dgvHoaDon.SelectedCells[0].RowIndex;
            txtMaHD.Text = dgvHoaDon.Rows[dong].Cells[0].Value.ToString();
            cboMaKH.Text = dgvHoaDon.Rows[dong].Cells[1].Value.ToString();
            cboMaNV.Text = dgvHoaDon.Rows[dong].Cells[2].Value.ToString();
            dtpNgayLapHD.Text = dgvHoaDon.Rows[dong].Cells[3].Value.ToString();
            dtpNgayNhapHang.Text = dgvHoaDon.Rows[dong].Cells[4].Value.ToString();
        }
    }
}
