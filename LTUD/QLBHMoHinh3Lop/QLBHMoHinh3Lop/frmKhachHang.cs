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
    public partial class frmKhachHang : Form
    {
        BUS_KhachHang bUS_KhachHang = new BUS_KhachHang();
        BUS_ThanhPho bUS_ThanhPho = new BUS_ThanhPho();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = bUS_KhachHang.LayDanhSachKhachHang();
            cboThanhPho.DataSource = bUS_ThanhPho.LayDanhSachThanhPho();
            cboThanhPho.DisplayMember = "TenThanhPho";
            cboThanhPho.ValueMember = "ThanhPho";
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dgvKhachHang.SelectedCells[0].RowIndex;
            txtMaKH.Text = dgvKhachHang.Rows[dong].Cells[0].Value.ToString();
            txtTenCty.Text = dgvKhachHang.Rows[dong].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.Rows[dong].Cells[2].Value.ToString();
            cboThanhPho.Text = bUS_ThanhPho.LayTenThanhPhoTheoMa(dgvKhachHang.Rows[dong].Cells[3].Value.ToString());
            txtDienThoai.Text = dgvKhachHang.Rows[dong].Cells[4].Value.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text;
            string tenCty = txtTenCty.Text;
            //MessageBox.Show(tenCty); return;
            string diaChi = txtDiaChi.Text;
            string thanhPho = bUS_ThanhPho.LayMaThanhPhoTheoTen(cboThanhPho.Text);
            string dienThoai = txtDienThoai.Text;

            ET_KhachHang eT_KhachHang = new ET_KhachHang(maKH, tenCty, diaChi, thanhPho, dienThoai);
            if (bUS_KhachHang.ThemKhachHang(eT_KhachHang))
            {
                MessageBox.Show("Them khach hang thanh cong.");
            }
            else
            {
                MessageBox.Show("Them khach hang khong thanh cong.");
            }
            dgvKhachHang.DataSource = bUS_KhachHang.LayDanhSachKhachHang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text;
            string tenCty = txtTenCty.Text;
            //MessageBox.Show(tenCty); return;
            string diaChi = txtDiaChi.Text;
            string thanhPho = bUS_ThanhPho.LayMaThanhPhoTheoTen(cboThanhPho.Text);
            string dienThoai = txtDienThoai.Text;

            ET_KhachHang eT_KhachHang = new ET_KhachHang(maKH, tenCty, diaChi, thanhPho, dienThoai);
            if (bUS_KhachHang.SuaKhachHang(eT_KhachHang))
            {
                MessageBox.Show("Sua khach hang thanh cong.");
            }
            else
            {
                MessageBox.Show("Sua khach hang khong thanh cong.");
            }
            dgvKhachHang.DataSource = bUS_KhachHang.LayDanhSachKhachHang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text;
         
            if (bUS_KhachHang.XoaKhachHang(maKH))
            {
                MessageBox.Show("Xoa khach hang thanh cong.");
            }
            else
            {
                MessageBox.Show("Xoa khach hang khong thanh cong.");
            }
            dgvKhachHang.DataSource = bUS_KhachHang.LayDanhSachKhachHang();
        }
    }
}
