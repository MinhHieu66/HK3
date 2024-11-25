using BUS_QLSV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_MoHinh3Lop
{
    public partial class frmTimKiem : Form
    {
        BUS_SINHVIEN bus_SinhVien = new BUS_SINHVIEN();
        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            dgvKQ.DataSource = bus_SinhVien.LayDSSinhVien();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if(radMa.Checked == true)
            {
                dgvKQ.DataSource = bus_SinhVien.TimSinhVienTheoMa(txtNhap.Text.Trim());
            }
            else if(radTen.Checked == true)
            {
                dgvKQ.DataSource = bus_SinhVien.TimSinhVienTheoTen(txtNhap.Text.Trim());
            }
            else
            {
                MessageBox.Show("Ban chua chon option tim kiem!");
            }
        }
    }
}
