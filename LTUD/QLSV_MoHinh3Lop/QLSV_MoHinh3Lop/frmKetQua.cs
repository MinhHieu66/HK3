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
    public partial class frmKetQua : Form
    {
        BUS_SINHVIEN bus_SinhVien = new BUS_SINHVIEN();
        BUS_MonHoc bus_MonHoc = new BUS_MonHoc();
        BUS_KetQua bus_KetQua = new BUS_KetQua();
        
        public frmKetQua()
        {
            InitializeComponent();
        }

        private void frmKetQua_Load(object sender, EventArgs e)
        {
            dgvKetQua.DataSource = bus_KetQua.LayDSKetQua();
            cboMaSV.DataSource = bus_SinhVien.LayDSSinhVien();
            cboMaSV.DisplayMember = "MASV";
            cboMaSV.ValueMember = "MASV";
            cboMaMH.DataSource = bus_MonHoc.LayDSMonHoc();
            cboMaMH.DisplayMember = "MAMH";
            cboMaMH.ValueMember = "MAMH";
        }

        private void dgvKetQua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dgvKetQua.SelectedCells[0].RowIndex;
            cboMaSV.Text = dgvKetQua.Rows[dong].Cells[0].Value.ToString();
            cboMaMH.Text = dgvKetQua.Rows[dong].Cells[1].Value.ToString();
            txtDiemThi.Text = dgvKetQua.Rows[dong].Cells[2].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ET_KetQua eT_KetQua = new ET_KetQua(cboMaSV.Text, cboMaMH.Text, double.Parse(txtDiemThi.Text));
            if(bus_KetQua.ThemKetQua(eT_KetQua) == true)
            {
                MessageBox.Show("Them ket qua thanh cong!");
            }
            else
            {
                MessageBox.Show("Them ket qua khong thanh cong!");
            }
            dgvKetQua.DataSource = bus_KetQua.LayDSKetQua();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ET_KetQua eT_KetQua = new ET_KetQua(cboMaSV.Text, cboMaMH.Text, double.Parse(txtDiemThi.Text));
            if (bus_KetQua.SuaKetQua(eT_KetQua) == true)
            {
                MessageBox.Show("Sua ket qua thanh cong!");
            }
            else
            {
                MessageBox.Show("Sua ket qua khong thanh cong!");
            }
            dgvKetQua.DataSource = bus_KetQua.LayDSKetQua();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //ET_KetQua eT_KetQua = new ET_KetQua(cboMaSV.Text, cboMaMH.Text, double.Parse(txtDiemThi.Text));
            if (bus_KetQua.XoaKetQua(cboMaSV.Text) == true)
            {
                MessageBox.Show("Xoa ket qua thanh cong!");
            }
            else
            {
                MessageBox.Show("Xoa ket qua khong thanh cong!");
            }
            dgvKetQua.DataSource = bus_KetQua.LayDSKetQua();
        }

        private void dgvKetQua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
