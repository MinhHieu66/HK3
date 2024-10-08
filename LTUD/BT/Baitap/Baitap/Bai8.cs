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
    public partial class frmBai8 : Form
    {
        public frmBai8()
        {
            InitializeComponent();
        }

        private void frmBai8_Load(object sender, EventArgs e)
        {

        }

        private void frmBai8_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to close?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) e.Cancel = true;
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                this.errorProvider1.SetError(txtNhap, "Du lieu sai!");
                txtNhap.BackColor = Color.Red;
                btnNhap.Enabled = false;
            }
            else
            {
                this.errorProvider1.Clear();
                txtNhap.BackColor = Color.White;
                if (ctr.Text.Trim().Length != 0) 
                {
                    btnNhap.Enabled = true;
                }
                else
                {
                    btnNhap.Enabled = false;
                }

            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            int check = listBox1.FindStringExact(txtNhap.Text);
            if (check == -1) 
            {
                listBox1.Items.Add(txtNhap.Text);
            }
            else
            {
                MessageBox.Show("Du lieu bi trung!");
            }
            txtNhap.Clear();
            txtNhap.Focus();

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                sum += int.Parse(listBox1.Items[i].ToString());
            }
            MessageBox.Show("Tong cac phan tu trong List: " + sum);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(0);
            listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                int temp = int.Parse(listBox1.Items[i].ToString());
                listBox1.Items[i] = temp + 2;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int temp = int.Parse(listBox1.Items[i].ToString());
                listBox1.Items[i] = temp * temp;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {

            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                if(int.Parse(listBox1.Items[i].ToString())%2 == 0)
                {
                    listBox1.SetSelected(i, true);
                }
                else
                {
                    listBox1.SetSelected(i, false);
                }
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (int.Parse(listBox1.Items[i].ToString()) % 2 != 0)
                {
                    listBox1.SetSelected(i, true);
                }
                else
                {
                    listBox1.SetSelected(i, false);
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[i]);
                i--;
            }
        }
    }
}
