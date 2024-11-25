using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLSV;
using ET_QLSV;

namespace QLSV_MoHinh3Lop
{
    public partial class frmKhoa : Form
    {
        BUS_Khoa bus_khoa = new BUS_Khoa();
        public frmKhoa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvKhoa.DataSource = bus_khoa.LayDSKhoa();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ET_Khoa et_khoa = new ET_Khoa();
            et_khoa.Makhoa = txtMaKhoa.Text.Trim();
            et_khoa.Tenkhoa = txtTenKhoa.Text.Trim();

            if (bus_khoa.ThemKhoa(et_khoa))
            {
                MessageBox.Show("Them khoa thanh cong!");
            }
            else
            {
                MessageBox.Show("Them khoa khong thanh cong!");
            }
            dgvKhoa.DataSource = bus_khoa.LayDSKhoa();
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dgvKhoa.SelectedCells[0].RowIndex;
            txtMaKhoa.Text = dgvKhoa.Rows[dong].Cells[0].Value.ToString().Trim();
            txtTenKhoa.Text = dgvKhoa.Rows[dong].Cells[1].Value.ToString().Trim();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bus_khoa.XoaKhoa(txtMaKhoa.Text.Trim()))
            {
                MessageBox.Show("Xoa khoa thanh cong!");
            }
            else
            {
                MessageBox.Show("Them khoa khong thanh cong!");
            }
            dgvKhoa.DataSource = bus_khoa.LayDSKhoa();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ET_Khoa et_khoa = new ET_Khoa();
            et_khoa.Makhoa = txtMaKhoa.Text.Trim();
            et_khoa.Tenkhoa = txtTenKhoa.Text.Trim();

            if (bus_khoa.SuaKhoa(et_khoa))
            {
                MessageBox.Show("Sua khoa thanh cong!");
            }
            else
            {
                MessageBox.Show("Sua khoa khong thanh cong!");
            }
            dgvKhoa.DataSource = bus_khoa.LayDSKhoa();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
