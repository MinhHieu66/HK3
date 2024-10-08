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
    public partial class frmBai9 : Form
    {
        public frmBai9()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmBai9_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co chac muon thoat khong?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) e.Cancel = true;
        }

        private void frmBai9_Load(object sender, EventArgs e)
        {

        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length != 0)
                btnCapNhat.Enabled = true;
            else btnCapNhat.Enabled = false;
            
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Lớp A")
            {
                lstA.Items.Add(txtNhap.Text);
            }
            else if(comboBox1.Text == "Lớp B")
            {
                lstB.Items.Add(txtNhap.Text);
            }
            else
            {
                MessageBox.Show("Ban chua chon lop");
            }
            txtNhap.Clear();
            txtNhap.Focus();

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lstA.SelectedItems.Count; i++)
            {
                lstB.Items.Add(lstA.SelectedItems[i]);
                lstA.Items.Remove(lstA.SelectedItems[i]);
                i--;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstB.SelectedItems.Count; i++)
            {
                lstA.Items.Add(lstB.SelectedItems[i]);
                lstB.Items.Remove(lstB.SelectedItems[i]);
                i--;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            foreach(var i in lstA.Items)
            {
                lstB.Items.Add((string)i);
            }
            lstA.Items.Clear();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            foreach (var i in lstB.Items)
            {
                lstA.Items.Add((string)i);
            }
            lstB.Items.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lstA.SelectedItems.Count; i++)
            {
                lstA.Items.Remove(lstA.SelectedItems[i]);
                i--;
            }
        }
    }
}
