using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmQLSV : Form
    {
        public frmQLSV()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tvDS.ExpandAll(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maSinhVien = txtMSV.Text;
            string ten = txtTen.Text;
            string diaChi = txtDiaChi.Text;
            string lopChecked = tvDS.SelectedNode.Text;
            bool check = true; //khong co loi
            string error = "";
            if(maSinhVien.Trim().Length == 0)
            {
                check = false;
                error += "Ma sinh vien khong duoc de trong! \n";
            }

            if(ten.Trim().Length == 0)
            {
                check = false;
                error += "Ten sinh vien khong duoc de trong! \n";
            }

            if (diaChi.Trim().Length == 0)
            {
                check = false;
                error += "Dia chi khong duoc bo trong! \n";
            }
            else
            {
                //string id = txtMSV.Text;
                int oke = 0;
                for (int i = 0; i < tvDS.Nodes[0].Nodes.Count; i++) //Duyet qua cac lop
                {
                    for(int j = 0; j < tvDS.Nodes[0].Nodes[i].Nodes.Count; j++)
                    {
                        if(maSinhVien == (tvDS.Nodes[0].Nodes[i].Nodes[j].Text.ToString().Split('-')[0]))
                        {
                            check = false;
                            oke = 1;
                            error += "Ma sinh vien khong duoc trung! \n";
                            break;
                        }
                    }
                    if (oke == 1) break;
                }
            }

            if (!check)
            {
                MessageBox.Show(error);
            }
            else
            {
                int oke = 0;
                for(int i = 0; i < tvDS.Nodes[0].Nodes.Count; i++) // duyet lop
                {
                    if(lopChecked == tvDS.Nodes[0].Nodes[i].Text)
                    {
                        string s = maSinhVien + "-" + ten;
                        tvDS.Nodes[0].Nodes[i].Nodes.Add(s);
                       for(int j = 0; j < tvDS.Nodes[0].Nodes[i].Nodes.Count; j++) //duyet thong tin sinh vien
                       {
                            if(s == tvDS.Nodes[0].Nodes[i].Nodes[j].Text)
                            {
                                oke = 1;
                                tvDS.Nodes[0].Nodes[i].Nodes[j].Nodes.Add(diaChi);
                            }
                       }
                    }
                }

                if(oke == 0)
                {
                    MessageBox.Show("Ban chua chon lop");
                }
            }
            txtDiaChi.Clear();
            txtMSV.Clear();
            txtTen.Clear();
            txtMSV.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string nodeChecked = tvDS.SelectedNode.Text;
            string ma = nodeChecked.Split('-')[0];
            if (char.IsDigit(ma, ma.Length - 1)) {
                for(int i = 0; i < tvDS.Nodes[0].Nodes.Count; i++)
                {
                    for(int j = 0; j < tvDS.Nodes[0].Nodes[i].Nodes.Count; j++)
                    {
                        if(nodeChecked == tvDS.Nodes[0].Nodes[i].Nodes[j].Text)
                        {
                            tvDS.Nodes.Remove(tvDS.Nodes[0].Nodes[i].Nodes[j]);
                        }
                    }
                }
                txtDiaChi.Clear();
                txtMSV.Clear();
                txtTen.Clear();
                txtMSV.Focus();
            }
            else
            {
                MessageBox.Show("Vui long chon chinh xac thong tin sinh vien can xoa!");
            }
            
        }

        private void tvDS_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string info = tvDS.SelectedNode.Text;
            for(int i = 0; i < tvDS.Nodes[0].Nodes.Count; i++) //duyet lop
            {
                for (int j = 0; j < tvDS.Nodes[0].Nodes[i].Nodes.Count; j++) //duyet ma sinh vien + ten sinh vien
                {
                    if(info == tvDS.Nodes[0].Nodes[i].Nodes[j].Text || info == tvDS.Nodes[0].Nodes[i].Nodes[j].Nodes[0].Text)
                    {
                        string thongTin = tvDS.Nodes[0].Nodes[i].Nodes[j].Text;
                        txtMSV.Text = thongTin.Split('-')[0];
                        txtTen.Text = thongTin.Split('-')[1];
                        txtDiaChi.Text = tvDS.Nodes[0].Nodes[i].Nodes[j].Nodes[0].Text;
                    }
                }
            }
        }
    }
}
