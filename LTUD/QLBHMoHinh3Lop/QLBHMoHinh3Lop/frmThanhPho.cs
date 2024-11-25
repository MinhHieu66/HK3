using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using ET_QLSV;

namespace QLBHMoHinh3Lop
{
    public partial class frmThanhPho : Form
    {
        BUS_ThanhPho bUS_ThanhPho = new BUS_ThanhPho();
        public frmThanhPho()
        {
            InitializeComponent();
        }

        private void frmThanhPho_Load(object sender, EventArgs e)
        {
            dgvThanhPho.DataSource = bUS_ThanhPho.LayDanhSachThanhPho();
        }

        private void dgvThanhPho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dgvThanhPho.SelectedCells[0].RowIndex;
            txtThanhPho.Text = dgvThanhPho.Rows[dong].Cells[0].Value.ToString();
            txtTenThanhPho.Text = dgvThanhPho.Rows[dong].Cells[1].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string thanhPho = txtThanhPho.Text;
            string tenThanhPho = txtTenThanhPho.Text;
            ET_ThanhPho eT_ThanhPho = new ET_ThanhPho(thanhPho, tenThanhPho);
            if (bUS_ThanhPho.ThemThanhPho(eT_ThanhPho))
            {
                MessageBox.Show("Them thanh pho thanh cong");
            }
            else
            {
                MessageBox.Show("Them thanh pho khong thanh cong");
            }
            dgvThanhPho.DataSource = bUS_ThanhPho.LayDanhSachThanhPho();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string thanhPho = txtThanhPho.Text;
            string tenThanhPho = txtTenThanhPho.Text;
            ET_ThanhPho eT_ThanhPho = new ET_ThanhPho(thanhPho, tenThanhPho);
            if (bUS_ThanhPho.SuaThanhPho(eT_ThanhPho))
            {
                MessageBox.Show("Sua thanh pho thanh cong");
            }
            else
            {
                MessageBox.Show("Sua thanh pho khong thanh cong");
            }
            dgvThanhPho.DataSource = bUS_ThanhPho.LayDanhSachThanhPho();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string thanhPho = txtThanhPho.Text;
            if (bUS_ThanhPho.XoaThanhPho(thanhPho))
            {
                MessageBox.Show("Xoa thanh pho thanh cong");
            }
            else
            {
                MessageBox.Show("Xoa thanh pho khong thanh cong");
            }
            dgvThanhPho.DataSource = bUS_ThanhPho.LayDanhSachThanhPho();
        }
    }
}
