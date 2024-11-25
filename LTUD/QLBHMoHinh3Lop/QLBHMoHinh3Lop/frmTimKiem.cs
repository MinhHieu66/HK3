using BUS;
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
    public partial class frmTimKiem : Form
    {
        BUS_KhachHang bUS_KhachHang = new BUS_KhachHang();
        BUS_SanPham bUS_SanPham = new BUS_SanPham();
        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if(radMaKH.Checked == true)
            {
                dgvTimKiem.DataSource = bUS_KhachHang.TimKhachHangTheoMa(txtNhap.Text);
            }else if(radTenSP.Checked == true)
            {
                dgvTimKiem.DataSource = bUS_SanPham.TimSanPhamTheoTenSanPham(txtNhap.Text);
            }
            else
            {
                MessageBox.Show("Ban chua chon option tim kiem.");
            }
        }
    }
}
