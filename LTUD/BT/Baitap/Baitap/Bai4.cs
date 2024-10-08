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
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        private void frmBai4_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
            txtNhap.Focus();
            txtNhap.ForeColor = Color.Red;
            lblKQ.ForeColor = Color.Red;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            lblKQ.Text = txtNhap.Text;
        }

        private void frmBai4_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Ban co muon thoat khong?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No) e.Cancel = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            lblKQ.ForeColor = Color.Red;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblKQ.ForeColor = Color.Green;
        }

        private void radBule_CheckedChanged(object sender, EventArgs e)
        {
            lblKQ.ForeColor = Color.Blue;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            lblKQ.ForeColor = Color.Black;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            lblKQ.Font = new Font(lblKQ.Font.Name, lblKQ.Font.Size, lblKQ.Font.Style^FontStyle.Bold);
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            lblKQ.Font = new Font(lblKQ.Font.Name, lblKQ.Font.Size, lblKQ.Font.Style ^ FontStyle.Italic);
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            lblKQ.Font = new Font(lblKQ.Font.Name, lblKQ.Font.Size, lblKQ.Font.Style ^ FontStyle.Underline);
        }
    }
}
