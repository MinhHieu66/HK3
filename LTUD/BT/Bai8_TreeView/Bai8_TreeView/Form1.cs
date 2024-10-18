using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8_TreeView
{
    public partial class frmBai8_TV : Form
    {
        public frmBai8_TV()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLN_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmBai8_TV_Load(object sender, EventArgs e)
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                tvDemo.Nodes.Add(c.ToString());
            }
        }

        private void frmBai8_TV_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = MessageBox.Show("Ban co muon thoat khong?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.No) e.Cancel = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string s = txtFN.Text + ", " + txtLN.Text;
            int index = 0;
            for(int i = 0; i < tvDemo.Nodes.Count; i++)// A - Z
            {
                if (tvDemo.Nodes[i].Text == s[0].ToString())
                {
                    ThemNodeMoi(tvDemo.Nodes[i], s);
                    index = i;
                    break;
                }
            }

            for(int i = 0; i < tvDemo.Nodes[index].Nodes.Count; i++)
            {
                tvDemo.Nodes[index].Nodes[i].ImageIndex = 1;
            }
        }

        void ThemNodeMoi(TreeNode treeNode, string s)
        {
            treeNode.Nodes.Add(s);
        }
    }
}
