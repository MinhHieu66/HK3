using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap
{
    public partial class frmBai5 : Form
    {
        public frmBai5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtKQ.Font = new Font("Courier New", 14, FontStyle.Regular);
        }

        private void frmBai5_Load(object sender, EventArgs e)
        {
            rad1.Checked = true;
        }

        private void frmBai5_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Ban co muon thoat khong?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.No) e.Cancel = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rad1_CheckedChanged(object sender, EventArgs e)
        {
            txtKQ.Font = new Font("Times New Roman", 14, FontStyle.Regular);
        }

        private void rad2_CheckedChanged(object sender, EventArgs e)
        {
            txtKQ.Font = new Font("Arial", 14, FontStyle.Regular);
        }

        private void rad3_CheckedChanged(object sender, EventArgs e)
        {
            txtKQ.Font = new Font("Tahoma", 14, FontStyle.Regular);
        }
    }
}
