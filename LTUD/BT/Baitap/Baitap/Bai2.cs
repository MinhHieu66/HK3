using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void frmBai2_Load(object sender, EventArgs e)
        {
          
        }

        private void txtA_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            
            if (ctr.Text.Trim().Length == 0 || !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                this.errorProvider1.SetError(txtA, "Du lieu sai!");
                txtA.Focus();
                txtA.BackColor = Color.Red;
                txtA.Text = "";
            }
            else
            {
                this.errorProvider1.Clear();
                txtA.BackColor = Color.White;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            
            if(ctr.Text.Trim().Length == 0 || !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                this.errorProvider1.SetError(txtB, "Du lieu sai!");
                txtB.BackColor = Color.Red;
                btnGiai.Enabled = false;
            }
            else
            {
                this.errorProvider1.Clear();
                txtB.BackColor = Color.White;
                btnGiai.Enabled = true;
            }
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length > 0)
            {
                btnXoa.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a = int.Parse(txtA.Text);
            double b = int.Parse(txtB.Text);
            string s = "";

            if (a == 0)
            {
                if (b == 0)
                {
                    s = "VSV";
                }
            }
            else
            {
                if (b == 0)
                {
                    s = "VN";
                }
                else
                {
                    s = (-b / a).ToString();
                }
            }
            txtKQ.Text = s;
            btnGiai.Enabled = false;
            btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtA.Focus();
            txtKQ.Clear();
            this.errorProvider1.Clear();
            txtB.BackColor = Color.White;
            btnXoa.Enabled = false;
        }

        private void frmBai2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Ban co muon thoat khong?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No) e.Cancel = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
