using BUS;
using ET_QLSV;
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
    public partial class frmNhanVien : Form
    {
        BUS_NhanVien bus_NhanVien = new BUS_NhanVien();
        public frmNhanVien()
        {
            InitializeComponent();
        }
        
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = bus_NhanVien.LayDSNhanVien();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dgvNhanVien.SelectedCells[0].RowIndex;
            txtMaNV.Text = dgvNhanVien.Rows[dong].Cells[0].Value.ToString();
            txtHo.Text = dgvNhanVien.Rows[dong].Cells[1].Value.ToString();
            txtTen.Text = dgvNhanVien.Rows[dong].Cells[2].Value.ToString();
            //MessageBox.Show(dgvNhanVien.Rows[dong].Cells[3].Value.ToString());
            if (dgvNhanVien.Rows[dong].Cells[3].Value.ToString() == "Nam  ")
            {

                //MessageBox.Show("1");
                radNam.Checked = true;
            }
            else 
            {
                //MessageBox.Show("12");
                radNu.Checked = true;
            }
            dtpNgaySinh.Value = Convert.ToDateTime(dgvNhanVien.Rows[dong].Cells[4].Value.ToString());
            txtDiaChi.Text = dgvNhanVien.Rows[dong].Cells[5].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[dong].Cells[6].Value.ToString();
            txtHinh.Text = dgvNhanVien.Rows[dong].Cells[7].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text;
            string ho = txtHo.Text;
            string ten = txtTen.Text;
            string gioiTinh = "Nam";
            if(radNu.Checked == true)
            {
                gioiTinh = "Nu";
            }
            DateTime ngaySinh = dtpNgaySinh.Value;
            string diaChi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string hinh = txtHinh.Text;
            
            ET_NhanVien eT_NhanVien = new ET_NhanVien(ma, ho, ten, gioiTinh, ngaySinh, diaChi, sdt, hinh);
            //MessageBox.Show(bus_NhanVien.ThemNhanVien(eT_NhanVien).ToString()); return;
            if (bus_NhanVien.ThemNhanVien(eT_NhanVien) == true)
            {
                MessageBox.Show("Them nhan vien thanh cong");
            }
            else
            {
                MessageBox.Show("Them nhan vien khong thanh cong");
            }
            dgvNhanVien.DataSource = bus_NhanVien.LayDSNhanVien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text;
            string ho = txtHo.Text;
            string ten = txtTen.Text;
            string gioiTinh = "Nam";
            if (radNu.Checked == true)
            {
                gioiTinh = "Nu";
            }
            DateTime ngaySinh = dtpNgaySinh.Value;
            string diaChi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string hinh = txtHinh.Text;

            ET_NhanVien eT_NhanVien = new ET_NhanVien(ma, ho, ten, gioiTinh, ngaySinh, diaChi, sdt, hinh);
            if (bus_NhanVien.SuaNhaVien(eT_NhanVien))
            {
                MessageBox.Show("Sua nhan vien thanh cong");
            }
            else
            {
                MessageBox.Show("Sua nhan vien khong thanh cong");
            }
            dgvNhanVien.DataSource = bus_NhanVien.LayDSNhanVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text;
            
            if (bus_NhanVien.XoaNhanVien(ma))
            {
                MessageBox.Show("Xoa nhan vien thanh cong");
            }
            else
            {
                MessageBox.Show("Xoa nhan vien khong thanh cong");
            }
            dgvNhanVien.DataSource = bus_NhanVien.LayDSNhanVien();
        }
    }
}
