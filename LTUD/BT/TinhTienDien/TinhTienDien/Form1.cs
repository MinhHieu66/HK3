using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTienDien
{
    public partial class FrmTienDien : Form
    {
        private int total = 0;
        public FrmTienDien()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmTienDien_Load(object sender, EventArgs e)
        {
            txtTongTien.Text = total.ToString();
            txtThanhTien.Text = "";
            txtTieuThu.Text = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combKhuVuc.Text == "Khu vuc 1")
                txtDinhMuc.Text = "50";
            else if (combKhuVuc.Text == "Khu vuc 2")
                txtDinhMuc.Text = "100";
            else if (combKhuVuc.Text == "Khu vuc 3")
                txtDinhMuc.Text = "150";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ban chua nhap ten!");
                txtHoTen.Focus();
            }
            else if (combKhuVuc.Text.Length == 0)
            {
                MessageBox.Show("Kiem tra lai du lieu tai combox Khu Vuc!");
            }
            else if (txtSoCu.Text.Trim().Length == 0 || !char.IsDigit(txtSoCu.Text,  txtSoCu.Text.Length - 1))
            {
                MessageBox.Show("Kiem tra lai du lieu tai field So Cu!");
                txtSoCu.Clear();
                txtSoCu.Focus();
            }
            else if(txtSoCu.Text.Trim().Length == 0 || !char.IsDigit(txtSoCu.Text, txtSoCu.Text.Length - 1) || (int.Parse(txtSoMoi.Text) < int.Parse(txtSoCu.Text)))
            {
                MessageBox.Show("Kiem tra lai du lieu tai field So Moi!");
                txtSoMoi.Clear();
                txtSoMoi.Focus();
            }
            else
            {
                int soMoi = int.Parse(txtSoMoi.Text);
                int soCu = int.Parse(txtSoCu.Text);

                int dinhMuc = (soMoi - soCu);
                txtTieuThu.Text = dinhMuc + "";

                int tongTien = 0;
                if (txtDinhMuc.Text == "50")
                {
                    if (dinhMuc <= 50)
                    {
                        tongTien = dinhMuc * 500;
                    }
                    else
                    {
                        tongTien += (50 * 500);
                        int vuot = dinhMuc - 50;
                        tongTien += (vuot * 1000);
                    }

                }
                else if (txtDinhMuc.Text == "100")
                {
                    if (dinhMuc <= 100)
                    {
                        tongTien = dinhMuc * 500;
                    }
                    else
                    {
                        tongTien += (100 * 500);
                        int vuot = dinhMuc - 100;
                        tongTien += (vuot * 1000);
                    }
                }
                else if (txtDinhMuc.Text == "150")
                {
                    if (dinhMuc <= 150)
                    {
                        tongTien = dinhMuc * 500;
                    }
                    else
                    {
                        tongTien += (150 * 500);
                        int vuot = dinhMuc - 150;
                        tongTien += (vuot * 1000);
                    }
                }

                txtThanhTien.Text = tongTien + "";

                ListViewItem item = new ListViewItem();
                item.Text = txtHoTen.Text;
                item.SubItems.Add(combKhuVuc.Text);
                item.SubItems.Add(txtDinhMuc.Text);
                item.SubItems.Add(txtTieuThu.Text);
                item.SubItems.Add(txtThanhTien.Text);
                lstLists.Items.Add(item);

                total += tongTien;
                txtTongTien.Text = total.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            combKhuVuc.Text = "";
            txtDinhMuc.Clear();
            txtSoCu.Clear();
            txtSoMoi.Clear();
            txtTieuThu.Clear();
            txtThanhTien.Clear();
            txtHoTen.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var item = lstLists.SelectedItems[0];
            string s = "Ban co chan muon xoa KH: " + item.SubItems[0].Text;
            DialogResult result = MessageBox.Show(s, "Xoa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                lstLists.Items.Remove(item);
                total -= int.Parse(item.SubItems[4].Text);
                txtTongTien.Text = total.ToString();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void combKhuVuc_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmTienDien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co muon thoat khong?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) e.Cancel = true; 
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog odlg = new OpenFileDialog();
            odlg.Filter = "All file (*.*)|*.*| Text file (*.txt)|*.txt";
            if(odlg.ShowDialog() == DialogResult.OK)
            {
                Stream f = odlg.OpenFile();
                StreamReader reader = new StreamReader(f);

                using (reader)
                {
                    string s = "";
                    int sum = 0;
                    while ((s = reader.ReadLine()) != null)
                    {
                        string[] arrS = s.Split('#');

                        ListViewItem item = new ListViewItem();
                        item.Text = arrS[0];
                        item.SubItems.Add(arrS[1]);
                        item.SubItems.Add(arrS[2]);
                        item.SubItems.Add(arrS[3]);
                        item.SubItems.Add(arrS[4]);
                        lstLists.Items.Add(item);
                        sum += int.Parse(arrS[4]);
                    }
                    total = sum;
                    txtTongTien.Text = total.ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sdlg = new SaveFileDialog();
            sdlg.Filter = "All file (*.*)|*.*| Text file (*.txt)|*.txt";
            if (sdlg.ShowDialog() == DialogResult.OK)
            {
                Stream s = sdlg.OpenFile();
                StreamWriter writer = new StreamWriter(s);

                using (writer)
                {
                    for (int i = 0; i < lstLists.Items.Count; i++) 
                    { 
                        string res = lstLists.Items[i].SubItems[0].Text + "#" + lstLists.Items[i].SubItems[1].Text + "#" + lstLists.Items[i].SubItems[2].Text + "#" + lstLists.Items[i].SubItems[3].Text + "#" + lstLists.Items[i].SubItems[4].Text;
                        writer.WriteLine(res);
                    }
                }
            }

        }
    }
}
