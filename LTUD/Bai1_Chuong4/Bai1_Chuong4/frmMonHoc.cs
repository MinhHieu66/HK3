using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32.SafeHandles;

namespace Bai1_Chuong4
{
    public partial class frmMonHoc : Form
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=MINHHIEU\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;TrustServerCertificate=True");

        public DataTable LoadDuLieuMonHoc()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayDSMonHoc", conn);
                cmd.CommandText = "sp_LayDSMonHoc";
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
            

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            dgvMonHoc.DataSource = LoadDuLieuMonHoc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaMonHoc");
                cmd.CommandText = "sp_SuaMonHoc";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter paMa = new SqlParameter("@ma", txtMaMon.Text.Trim());
                cmd.Parameters.Add(paMa);

                SqlParameter paTen = new SqlParameter("@ten", txtTenMon.Text.Trim());
                cmd.Parameters.Add(paTen);

                SqlParameter paSoTiet = new SqlParameter("@sotiet", txtSoTiet.Text.Trim());
                cmd.Parameters.Add(paSoTiet);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sua mon hoc thanh cong!");
                }
                else
                {
                    MessageBox.Show("Sua mon hoc khong thanh cong!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            dgvMonHoc.DataSource = LoadDuLieuMonHoc();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaMonHoc");
                cmd.CommandText = "sp_XoaMonHoc";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter paMa = new SqlParameter("@ma", txtMaMon.Text.Trim());
                cmd.Parameters.Add(paMa);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xoa mon hoc thanh cong!");
                }
                else
                {
                    MessageBox.Show("Xoa mon hoc khong thanh cong!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            dgvMonHoc.DataSource = LoadDuLieuMonHoc();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemMonHoc");
                cmd.CommandText = "sp_ThemMonHoc";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter paMa = new SqlParameter("@ma", txtMaMon.Text.Trim());
                cmd.Parameters.Add(paMa);

                SqlParameter paTen = new SqlParameter("@ten", txtTenMon.Text.Trim());
                cmd.Parameters.Add(paTen);

                SqlParameter paSoTiet = new SqlParameter("@sotiet", txtSoTiet.Text.Trim());
                cmd.Parameters.Add(paSoTiet);

                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Them mon hoc thanh cong!");
                }
                else
                {
                    MessageBox.Show("Them mon hoc khong thanh cong!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
            finally
            {
                conn.Close();
            }
            dgvMonHoc.DataSource = LoadDuLieuMonHoc();

        }

        private void frmMonHoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Ban co chac muon thoat", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)  e.Cancel = true;
        }

        private void dgvMonHoc_Click(object sender, EventArgs e)
        {
            int dong = dgvMonHoc.SelectedCells[0].RowIndex;
            txtMaMon.Text = dgvMonHoc.Rows[dong].Cells[0].Value.ToString(); 
            txtTenMon.Text = dgvMonHoc.Rows[dong].Cells[1].Value.ToString(); 
            txtSoTiet.Text = dgvMonHoc.Rows[dong].Cells[2].Value.ToString(); 
        }
    }
}
