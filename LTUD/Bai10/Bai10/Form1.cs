using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai10
{
    public partial class frmLV : Form
    {
        public frmLV()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lstLV.View = View.Details;
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            ListViewItem item = new ListViewItem();
            item.Text = txtFirstName.Text;
            item.SubItems.Add(txtLastName.Text);
            item.SubItems.Add(txtPhone.Text);
            item.ImageIndex = rd.Next(1, 5);
            lstLV.Items.Add(item);
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtLastName.Focus();
        }

        private void lstLV_Click(object sender, EventArgs e)
        {
            int dong = lstLV.SelectedIndices[0];
            txtLastName.Text = lstLV.Items[dong].SubItems[1].Text;
            txtFirstName.Text = lstLV.Items[dong].SubItems[0].Text;
            txtPhone.Text = lstLV.Items[dong].SubItems[2].Text;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = lstLV.SelectedIndices[0];
                lstLV.Items[dong].SubItems[1].Text = txtLastName.Text;
                lstLV.Items[dong].SubItems[0].Text = txtFirstName.Text;
                lstLV.Items[dong].SubItems[2].Text = txtPhone.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             
            for(int i = 0; i < lstLV.SelectedItems.Count; i++)
            {
                lstLV.Items.Remove(lstLV.SelectedItems[i]);
                i--;
            }

            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtLastName.Focus();
        }

        private void frmLV_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co muon thoat khong!", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) e.Cancel = true; 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstLV.View = View.SmallIcon;
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstLV.View = View.LargeIcon;
        }
    }
}
