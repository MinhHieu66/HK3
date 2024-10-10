using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lstLV.SelectedItems.Count; i++)
            {
                lstLV.Items.Remove(lstLV.SelectedItems[i]);
                i--;
            }
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            if(txtFirstName.Text.Trim().Length == 0 || txtLastName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ban bo trong FirstName hoac LastName hoac ca hai!");
                txtFirstName.Clear();
                txtLastName.Clear();
                txtLastName.Focus();
            } else if( txtPhone.Text.Trim().Length > 0 && !char.IsDigit(txtPhone.Text, txtPhone.Text.Length - 1))
            {
                MessageBox.Show("So dien thoai khong dung quy dinh!");
                txtPhone.Clear();
                txtPhone.Focus();
            }
            else
            {
                Random rd = new Random();
                ListViewItem item = new ListViewItem();
                item.Text = txtLastName.Text; //cot dau tien
                item.SubItems.Add(txtFirstName.Text);
                item.SubItems.Add(txtPhone.Text);

                item.ImageIndex = rd.Next(1, 5);
                lstLV.Items.Add(item);
                txtFirstName.Clear();
                txtLastName.Clear();
                txtPhone.Clear();
                txtLastName.Focus();
            }
            
        }

        private void lstLV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstLV.View = View.SmallIcon;
        }

        private void lagreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstLV.View = View.LargeIcon;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lstLV.View = View.Details;
        }

        private void lstLV_Click(object sender, EventArgs e)
        {
            int dong = lstLV.SelectedIndices[0];
            txtFirstName.Text = lstLV.Items[dong].SubItems[1].Text;
            txtLastName.Text = lstLV.Items[dong].SubItems[0].Text;
            txtPhone.Text = lstLV.Items[dong].SubItems[2].Text;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = lstLV.SelectedIndices[0];
                lstLV.Items[dong].SubItems[0].Text = txtLastName.Text;
                lstLV.Items[dong].SubItems[1].Text = txtFirstName.Text;
                lstLV.Items[dong].SubItems[2].Text = txtPhone.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ban chua chon ten cap nhat");
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co muon thoat khong?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) e.Cancel = true; 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
