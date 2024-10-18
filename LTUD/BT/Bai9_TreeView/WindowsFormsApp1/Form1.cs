using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddItem(string name, string clas)
        {
            ListViewItem item = new ListViewItem();
            item.Text = name;
            item.SubItems.Add(clas);

            lstDS.Items.Add(item);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lstDS.Items.Clear();
            string check = tvKhoa.SelectedNode.Text;
           
            for (int i = 0; i < tvKhoa.Nodes[0].Nodes.Count; i++) //Lop
            {
                for(int j = 0; j < tvKhoa.Nodes[0].Nodes[i].Nodes.Count; j++) // sv
                {
                    if(check == tvKhoa.Nodes[0].Text)
                    {
                        AddItem(tvKhoa.Nodes[0].Nodes[i].Nodes[j].Text.ToString(), tvKhoa.Nodes[0].Nodes[i].Text.ToString());
                    }else if(check == tvKhoa.Nodes[0].Nodes[i].Text)
                    {
                        AddItem(tvKhoa.Nodes[0].Nodes[i].Nodes[j].Text.ToString(), tvKhoa.Nodes[0].Nodes[i].Text.ToString());
                    }
                    else if(check == tvKhoa.Nodes[0].Nodes[i].Nodes[j].Text)
                    {
                        AddItem(tvKhoa.Nodes[0].Nodes[i].Nodes[j].Text.ToString(), tvKhoa.Nodes[0].Nodes[i].Text.ToString());
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTim.Focus();
            tvKhoa.ExpandAll();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            lstDS.Items.Clear();
            string check = tvKhoa.SelectedNode.Text;

            for (int i = 0; i < tvKhoa.Nodes[0].Nodes.Count; i++) //Lop
            {
                for (int j = 0; j < tvKhoa.Nodes[0].Nodes[i].Nodes.Count; j++) // sv
                {
                    if (check == tvKhoa.Nodes[0].Text && txtTim.Text == tvKhoa.Nodes[0].Nodes[i].Nodes[j].Text.ToString())
                    {
                        AddItem(tvKhoa.Nodes[0].Nodes[i].Nodes[j].Text.ToString(), tvKhoa.Nodes[0].Nodes[i].Text.ToString());
                    }
                    else if (check == tvKhoa.Nodes[0].Nodes[i].Text && txtTim.Text == tvKhoa.Nodes[0].Nodes[i].Nodes[j].Text.ToString())
                    {
                        AddItem(tvKhoa.Nodes[0].Nodes[i].Nodes[j].Text.ToString(), tvKhoa.Nodes[0].Nodes[i].Text.ToString());
                    }
                    else if (check == tvKhoa.Nodes[0].Nodes[i].Nodes[j].Text && txtTim.Text == tvKhoa.Nodes[0].Nodes[i].Nodes[j].Text.ToString())
                    {
                        AddItem(tvKhoa.Nodes[0].Nodes[i].Nodes[j].Text.ToString(), tvKhoa.Nodes[0].Nodes[i].Text.ToString());
                    }
                }
            }
        }
    }
}
