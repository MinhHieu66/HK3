using BUS_QLSV;
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

namespace QLSV_MoHinh3Lop
{
    public partial class frmMonHoc : Form
    {
        BUS_MonHoc bus_MonHoc = new BUS_MonHoc();
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            dgvMonHoc.DataSource = bus_MonHoc.LayDSMonHoc();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ET_MonHoc eT_MonHoc = new ET_MonHoc();
            eT_MonHoc.MaMH = txtMaMH.Text.Trim();
            eT_MonHoc.TenMH = txtTenMH.Text.Trim();
            eT_MonHoc.SoTiet = txtSoTiet.Text.Trim();

            if (bus_MonHoc.ThemMonHoc(eT_MonHoc))
            {
                MessageBox.Show("Them mon hoc thanh cong!");
            }
            else
            {
                MessageBox.Show("Them mon hoc khong thanh cong!");
            }
            dgvMonHoc.DataSource = bus_MonHoc.LayDSMonHoc();

        }

        
        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dgvMonHoc.SelectedCells[0].RowIndex;
            txtMaMH.Text = dgvMonHoc.Rows[dong].Cells[0].Value.ToString();
            txtTenMH.Text = dgvMonHoc.Rows[dong].Cells[1].Value.ToString();
            txtSoTiet.Text = dgvMonHoc.Rows[dong].Cells[2].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
            if (bus_MonHoc.XoaMonHoc(txtMaMH.Text.Trim()))
            {
                MessageBox.Show("Xoa mon hoc thanh cong!");
            }
            else
            {
                MessageBox.Show("Xoa mon hoc khong thanh cong!");
            }
            dgvMonHoc.DataSource = bus_MonHoc.LayDSMonHoc();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ET_MonHoc eT_MonHoc = new ET_MonHoc();
            eT_MonHoc.MaMH = txtMaMH.Text.Trim();
            eT_MonHoc.TenMH = txtTenMH.Text.Trim();
            eT_MonHoc.SoTiet = txtSoTiet.Text.Trim();

            if (bus_MonHoc.SuaMonHoc(eT_MonHoc))
            {
                MessageBox.Show("Sua mon hoc thanh cong!");
            }
            else
            {
                MessageBox.Show("Sua mon hoc khong thanh cong!");
            }
            dgvMonHoc.DataSource = bus_MonHoc.LayDSMonHoc();
        }
    }
}
