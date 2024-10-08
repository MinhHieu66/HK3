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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmBai3_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0 || !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                this.errorProvider1.SetError(txtSo2, "Du lieu sai!");
                txtSo2.BackColor = Color.Red;
                radChia.Enabled = false;
                radCong.Enabled = false;
                radTru.Enabled = false;
                radNhan.Enabled = false;
            }
            else
            {
                this.errorProvider1.Clear();
                txtSo2.BackColor = Color.White;
                
                radChia.Enabled = true;
                radCong.Enabled = true;
                radTru.Enabled = true;
                radNhan.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if(ctr.Text.Trim().Length == 0 || !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                this.errorProvider1.SetError(txtSo1, "Du lieu sai!");
                txtSo1.BackColor = Color.Red;
                txtSo1.Focus();
                txtSo1.Clear();
                //radChia.Enabled = false;
                //radCong.Enabled = false;
                //radTru.Enabled = false;
                //radNhan.Enabled = false;
            }
            else
            {
                this.errorProvider1.Clear();
                txtSo1.BackColor= Color.White;
                //radChia.Enabled = true;
                //radCong.Enabled = true;
                //radTru.Enabled = true;
                //radNhan.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtKQ.Text = (int.Parse(txtSo1.Text) - int.Parse(txtSo2.Text)).ToString();
        }

        private void radCong_CheckedChanged(object sender, EventArgs e)
        {
            txtKQ.Text = (int.Parse(txtSo1.Text) + int.Parse(txtSo2.Text)).ToString();
        }

        private void radNhan_CheckedChanged(object sender, EventArgs e)
        {
            txtKQ.Text = (int.Parse(txtSo1.Text) * int.Parse(txtSo2.Text)).ToString();
        }

        private void radChia_CheckedChanged(object sender, EventArgs e)
        {
            txtKQ.Text = (double.Parse(txtSo1.Text) / int.Parse(txtSo2.Text)).ToString();
        }
    }
}
