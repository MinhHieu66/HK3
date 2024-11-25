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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void sinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Ban co muon thoat khong?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.No) e.Cancel = true;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSinhVien frmSinhVien = new frmSinhVien();
            frmSinhVien.MdiParent = this;
            frmSinhVien.Show();
        }

        private void kếtQuảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKetQua frmKetQua = new frmKetQua();
            frmKetQua.MdiParent = this;
            frmKetQua.Show();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMonHoc frmMonHoc = new frmMonHoc();
            frmMonHoc.MdiParent = this;
            frmMonHoc.Show();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhoa frmKhoa = new frmKhoa();
            frmKhoa.MdiParent = this;
            frmKhoa.Show();
        }

        private void tìmKiếmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiem frmTimKiem = new frmTimKiem(); 
            frmTimKiem.MdiParent = this;
            frmTimKiem.Show();
        }
    }
}
