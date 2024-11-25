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
    public partial class frmSinhVien : Form
    {
        BUS_SINHVIEN bus_SinhVien = new BUS_SINHVIEN();
        BUS_Khoa bus_Khoa = new BUS_Khoa(); 
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bus_SinhVien.XoaSinhVien(txtMaSV1.Text))
            {
                MessageBox.Show("Xoa sinh vien thanh cong!");
            }
            else
            {
                MessageBox.Show("Xoa sinh vien khong thanh cong!");
            }
            dgvSinhVien.DataSource = bus_SinhVien.LayDSSinhVien();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            dgvSinhVien.DataSource = bus_SinhVien.LayDSSinhVien();
            cboMaKhoa.DataSource = bus_Khoa.LayDSKhoa();
            cboMaKhoa.DisplayMember = "TENKHOA";
            cboMaKhoa.ValueMember = "MAKHOA";
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dgvSinhVien.SelectedCells[0].RowIndex;
            txtMaSV1.Text = dgvSinhVien.Rows[dong].Cells[0].Value.ToString().Trim();
            txtHoSV.Text = dgvSinhVien.Rows[dong].Cells[1].Value.ToString().Trim();
            txtTenSV.Text = dgvSinhVien.Rows[dong].Cells[2].Value.ToString().Trim();
            if(dgvSinhVien.Rows[dong].Cells[3].Value.ToString().Trim() == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            if(dgvSinhVien.Rows[dong].Cells[4].Value.ToString().Trim() != "")
            {
                dtpNgaySinh.Value = Convert.ToDateTime(dgvSinhVien.Rows[dong].Cells[4].Value.ToString().Trim());
            }
            
            txtNoiSinh.Text = dgvSinhVien.Rows[dong].Cells[5].Value.ToString().Trim();
            txtDiaChi.Text = dgvSinhVien.Rows[dong].Cells[6].Value.ToString().Trim();
            txtQuan.Text = dgvSinhVien.Rows[dong].Cells[7].Value.ToString().Trim();
            string maKhoa = dgvSinhVien.Rows[dong].Cells[8].Value.ToString().Trim();
            cboMaKhoa.Text = bus_Khoa.LayTenKhoaTheoMa(maKhoa);
            //cboMaKhoa.Text = dgvSinhVien.Rows[dong].Cells[8].Value.ToString().Trim();
            txtHocBong.Text = dgvSinhVien.Rows[dong].Cells[9].Value.ToString().Trim();
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string gioiTinh = "Nam";
            if (radNu.Checked == true) gioiTinh = "Nu";
            DateTime ngaySinh = Convert.ToDateTime(dtpNgaySinh.Value.ToString("yyyy-MM-dd"));

            ET_SinhVien et_SinhVien = new ET_SinhVien(txtMaSV1.Text, txtHoSV.Text, txtTenSV.Text, gioiTinh, ngaySinh, txtNoiSinh.Text, txtDiaChi.Text, txtQuan.Text, bus_Khoa.TimMaKhoaTheoTen(cboMaKhoa.Text), int.Parse(txtHocBong.Text));
            
            if(bus_SinhVien.ThemSinhVien(et_SinhVien) == true)
            {
                MessageBox.Show("Them sinh vien thanh cong!");
            }
            else
            {
                MessageBox.Show("Them sinh vien khong thanh cong!");
            }
            dgvSinhVien.DataSource = bus_SinhVien.LayDSSinhVien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string gioiTinh = "Nam";
            if (radNu.Checked == true) gioiTinh = "Nu";
            DateTime ngaySinh = Convert.ToDateTime(dtpNgaySinh.Value.ToString("yyyy-MM-dd"));

            ET_SinhVien et_SinhVien = new ET_SinhVien(txtMaSV1.Text, txtHoSV.Text, txtTenSV.Text, gioiTinh, ngaySinh, txtNoiSinh.Text, txtDiaChi.Text, txtQuan.Text, bus_Khoa.TimMaKhoaTheoTen(cboMaKhoa.Text), int.Parse(txtHocBong.Text));

            if (bus_SinhVien.SuaSinhVien(et_SinhVien) == true)
            {
                MessageBox.Show("Sua sinh vien thanh cong!");
            }
            else
            {
                MessageBox.Show("Sua sinh vien khong thanh cong!");
            }
            dgvSinhVien.DataSource = bus_SinhVien.LayDSSinhVien();
        }
    }
}
