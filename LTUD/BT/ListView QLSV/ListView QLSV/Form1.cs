using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView_QLSV
{
    public partial class frmQLSV : Form
    {
        public frmQLSV()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstDSSV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = lstDSSV.SelectedIndices[0];
                lstDSSV.Items[dong].SubItems[0].Text = txtId.Text;
                lstDSSV.Items[dong].SubItems[1].Text = txtFullName.Text;
                lstDSSV.Items[dong].SubItems[2].Text = txtAddress.Text;
                lstDSSV.Items[dong].SubItems[3].Text = dtTime.Value.ToString("dd/MM/yyyy");
                lstDSSV.Items[dong].SubItems[4].Text = txtClass.Text;

                txtId.Clear();
                txtFullName.Clear();
                txtAddress.Clear();
                dtTime.Value = DateTime.Now;
                txtClass.Clear();
                txtId.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ban chua chon sinh vien de can nhat thong tin!");
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            ListViewItem item = new ListViewItem();
            item.Text = txtId.Text;
            item.SubItems.Add(txtFullName.Text);
            item.SubItems.Add(txtAddress.Text);
            item.SubItems.Add(dtTime.Value.ToString("dd/MM/yyyy"));
            item.SubItems.Add(txtClass.Text);

            item.ImageIndex = rd.Next(0, 4);
            lstDSSV.Items.Add(item);
            txtId.Focus();
            txtAddress.Clear();
            txtClass.Clear();
            txtFullName.Clear();
            txtId.Clear();
            dtTime.Value = DateTime.Now;
        }

        private void lstDSSV_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void lstDSSV_Click(object sender, EventArgs e)
        {
            int dong = lstDSSV.SelectedIndices[0];
            txtId.Text = lstDSSV.Items[dong].SubItems[0].Text;
            txtFullName.Text = lstDSSV.Items[dong].SubItems[1].Text;
            txtAddress.Text = lstDSSV.Items[dong].SubItems[2].Text;
            String time = lstDSSV.Items[dong].SubItems[3].Text;
            String[] arrTime = time.Split('/');
            DateTime dateTime = new DateTime(int.Parse(arrTime[2]), int.Parse(arrTime[1]), int.Parse(arrTime[0]));
            dtTime.Value = dateTime;
            txtClass.Text = lstDSSV.Items[dong].SubItems[4].Text;
        }

        private void frmQLSV_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co muon thoat khong?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) e.Cancel = true; 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstDSSV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Ban chua chon item nao het!");
            }
            else
            {
                string s = "Ban co muon xoa cac sinh vien nay khong? \n";
                for (int i = 0; i < lstDSSV.SelectedItems.Count; i++)
                {
                    s += lstDSSV.SelectedItems[i].SubItems[0].Text + "\n";
                }
                DialogResult result = MessageBox.Show(s, "Xoa", MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes)
                {
                    for (int i = 0; i < lstDSSV.SelectedItems.Count; i++)
                    {
                        lstDSSV.Items.Remove(lstDSSV.SelectedItems[i]);
                        i--;
                    }
                }
                
            }
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void largeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            lstDSSV.View = View.LargeIcon;
        }

        private void smallToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            lstDSSV.View = View.SmallIcon;
        }

        private void detailToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            lstDSSV.View = View.Details;
        }

        private void tilteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstDSSV.View = View.Tile;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstDSSV.View = View.List;
        }
    }
}
