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
    public partial class frmSanPham : Form
    {
        BUS_SanPham bus_SanPham = new BUS_SanPham();
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = bus_SanPham.LayDSSanPham();
            txtMaSP.Focus();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dgvSanPham.SelectedCells[0].RowIndex;
            txtMaSP.Text = dgvSanPham.Rows[dong].Cells[0].Value.ToString();
            txtTenSP.Text = dgvSanPham.Rows[dong].Cells[1].Value.ToString();
            txtDonViTinh.Text = dgvSanPham.Rows[dong].Cells[2].Value.ToString();
            txtDonGia.Text = dgvSanPham.Rows[dong].Cells[3].Value.ToString();
            txtHinh.Text = dgvSanPham.Rows[dong].Cells[4].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text;
            string tenSP = txtTenSP.Text;
            string donViTinh = txtMaSP.Text;
            int donGia = int.Parse(txtDonGia.Text);
            string hinh = txtHinh.Text;
            ET_SanPham eT_SanPham = new ET_SanPham(maSP, tenSP, donViTinh, donGia, hinh);

            if(bus_SanPham.ThemSanPham(eT_SanPham) == true)
            {
                MessageBox.Show("Them san pham thanh cong!");
            }
            else
            {
                MessageBox.Show("Them san pham khong thanh cong!");
            }
            dgvSanPham.DataSource = bus_SanPham.LayDSSanPham();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text;
            string tenSP = txtTenSP.Text;
            string donViTinh = txtMaSP.Text;
            int donGia = int.Parse(txtDonGia.Text);
            string hinh = txtHinh.Text;
            ET_SanPham eT_SanPham = new ET_SanPham(maSP, tenSP, donViTinh, donGia, hinh);

            if (bus_SanPham.SuaSanPham(eT_SanPham) == true)
            {
                MessageBox.Show("Sua san pham thanh cong!");
            }
            else
            {
                MessageBox.Show("Sua san pham khong thanh cong!");
            }
            dgvSanPham.DataSource = bus_SanPham.LayDSSanPham();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text;
        
            if (bus_SanPham.XoaSanPham(maSP) == true)
            {
                MessageBox.Show("Xoa san pham thanh cong!");
            }
            else
            {
                MessageBox.Show("Xoa san pham khong thanh cong!");
            }
            dgvSanPham.DataSource = bus_SanPham.LayDSSanPham();
        }
    }
}
