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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(txtName, "Ten khong duoc de trong!");
                //txtName.BackColor = Color.Red;
                txtName.Focus();
            }
            else
            {
                this.errorProvider1.Clear();
                //txtName.BackColor = Color.White;
            }
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if(ctr.Text.Trim().Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                this.errorProvider1.SetError(txtYear, "Du lieu khong hop le!");
                //txtYear.BackColor = Color.Red;
                btnShow.Enabled = false;
            }
            else
            {
                this.errorProvider1.Clear();
                //txtYear.BackColor = Color.White;
                if (ctr.Text.Trim().Length == 0)
                    btnShow.Enabled = false;
                else
                    btnShow.Enabled = true;

            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year - int.Parse(txtYear.Text);
            string s = txtName.Text + " - " + age + " tuoi";
            MessageBox.Show(s);
            btnShow.Enabled = false;
            btnClear.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           
            txtName.Clear();
            txtName.Focus();
            txtYear.Clear();
            btnClear.Enabled = true;
        }

        private void frmBai1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Ban co muon thoat khong?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No) e.Cancel = true;
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {

        }
    }
}
