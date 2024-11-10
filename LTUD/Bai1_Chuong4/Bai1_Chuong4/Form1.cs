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

namespace Bai1_Chuong4
{
    public partial class frmKhoa : Form
    {
        public frmKhoa()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=MINHHIEU\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;TrustServerCertificate=True");
        
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvKhoa.DataSource = LoadDuLieuKhoa();
        }

        public DataTable LoadDuLieuKhoa()
        {
            DataTable dt = new DataTable();
            try
            {
                //Mo
                conn.Open();
                //Command
                SqlCommand cmd = new SqlCommand("sp_LayDSKhoa", conn);
                cmd.CommandText = "sp_LayDSKhoa";
                cmd.CommandType = CommandType.StoredProcedure;

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemKhoa");
                cmd.CommandText = "sp_ThemKhoa";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter paMa = new SqlParameter("@ma", txtMaKhoa.Text.Trim());
                cmd.Parameters.Add(paMa);

                SqlParameter paTen = new SqlParameter("ten", txtTenKhoa.Text.Trim());
                cmd.Parameters.Add(paTen);

                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Them khoa thanh cong!");
                }
                else
                {
                    MessageBox.Show("Them khoa khong thanh cong!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            dgvKhoa.DataSource = LoadDuLieuKhoa();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaKhoa");
                cmd.CommandText = "sp_SuaKhoa";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter paMa = new SqlParameter("@ma", txtMaKhoa.Text.Trim());
                cmd.Parameters.Add(paMa);
                SqlParameter paTen = new SqlParameter("@ten", txtTenKhoa.Text.Trim());
                cmd.Parameters.Add(paTen);

                if( cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sua khoa thanh cong!");
                }
                else
                {
                    MessageBox.Show("Sua khoa khong thanh cong!");
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
            dgvKhoa.DataSource = LoadDuLieuKhoa();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaKhoa");
                cmd.CommandText = "sp_XoaKhoa";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter paMa = new SqlParameter("@ma", txtMaKhoa.Text.Trim());
                cmd.Parameters.Add(paMa);

                if( cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xoa khoa thanh cong!");
                }
                else
                {
                    MessageBox.Show("Xoa khoa khong thanh cong!");
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
            dgvKhoa.DataSource = LoadDuLieuKhoa();
        }

        private void dgvKhoa_Click(object sender, EventArgs e)
        {
            int dong = dgvKhoa.SelectedCells[0].RowIndex;
            txtMaKhoa.Text = dgvKhoa.Rows[dong].Cells[0].Value.ToString();
            txtTenKhoa.Text = dgvKhoa.Rows[dong].Cells[1].Value.ToString();
        }

        private void frmKhoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Ban co chac muon thoat?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) e.Cancel = true;
        }
    }
}
