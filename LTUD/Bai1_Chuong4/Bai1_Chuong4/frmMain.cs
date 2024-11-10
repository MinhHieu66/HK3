using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_Chuong4
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhoa frmKhoa = new frmKhoa();
            frmKhoa.Show();
        }

        private void monHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMonHoc frmMonHoc = new frmMonHoc();
            frmMonHoc.Show();
        }

        private void sinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSinhVien frmSinhVien = new frmSinhVien();
            frmSinhVien.Show();
        }

        private void ketQuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKetQua frmKetQua = new frmKetQua();
            frmKetQua.Show();
        }

        private void timKiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiem frmTimKiem = new frmTimKiem();
            frmTimKiem.Show();
        }
    }
}
