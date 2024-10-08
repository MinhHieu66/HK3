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
    public partial class frmBai7 : Form
    {
        private long tongUoc = 0;
        private int soLuongUocChan = 0;
        private int soLuongUocNguyenTo = 0;

        private bool IsPimre(int n)
        {
            if (n < 2) return false;
            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public frmBai7()
        {
            InitializeComponent();
        }

        private void frmBai7_Load(object sender, EventArgs e)
        {
            
        }

        private void txtNhap_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if(ctr.Text.Trim().Length == 0 || !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                //this.errorProvider1.SetError(txtNhap, "Du lieu sai!");
                //txtNhap.BackColor = Color.Red;
                btnCapNhat.Enabled = false;
            }
            else
            {
                //this.errorProvider1.Clear();
                //txtNhap.BackColor = Color.White;
                btnCapNhat.Enabled = true;
            }
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0 || !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                btnCapNhat.Enabled = false;
            }
            else
            {
                btnCapNhat.Enabled = true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string item = txtNhap.Text;
            int check = comboBox1.FindString(item);
            if (check == -1) {
                comboBox1.Items.Add(txtNhap.Text);
                MessageBox.Show("Cap nhat thanh cong!");
            }
            else
            {
                MessageBox.Show("Du lieu bi trung!");
            }
            txtNhap.Clear();
            txtNhap.Focus();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listDanhSach.Items.Clear();
            int number = int.Parse(comboBox1.Text);
            for(int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    listDanhSach.Items.Add(i.ToString());
                    tongUoc += i;
                    if (i % 2 == 0) soLuongUocChan++;
                    if (IsPimre(i)) soLuongUocNguyenTo++;
                } 
            }
        }

        private void btnTongUoc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tong uoc: " + tongUoc);
        }

        private void btnSoUocChan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("So luong uoc chan: " + soLuongUocChan);
        }

        private void btnSoUocSoNguyenTo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("So luong uoc so nguyen to: " +soLuongUocNguyenTo);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBai7_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult reslut = MessageBox.Show("Do you want to close?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reslut == DialogResult.No)
                e.Cancel = true;
        }
    }
}
