using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_Chuong4
{
    public partial class frmThanhPho : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MINHHIEU\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True;TrustServerCertificate=True");
        public frmThanhPho()
        {
            InitializeComponent();
        }

        public DataTable LoadDuLieuThanhPho()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayDSThanhPho", conn);
                cmd.CommandText = "sp_LayDSThanhPho";
                cmd.CommandType = CommandType.StoredProcedure;
                
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtThanhPho.Text.Trim();
                string ten = txtTenThanhPho.Text.Trim();
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemThanhPho", conn);
                cmd.CommandText = "sp_ThemThanhPho";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paMa = new SqlParameter("@ma", ma);
                SqlParameter paTen = new SqlParameter("@ten", ten);
                cmd.Parameters.Add(paMa);
                cmd.Parameters.Add(paTen);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Them thanh pho thanh cong!");
                }
                else
                {
                    MessageBox.Show("Them thanh pho khong thanh cong!");
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
            dgvThanhPho.DataSource = LoadDuLieuThanhPho();
        }

        private void frmThanhPho_Load(object sender, EventArgs e)
        {
            dgvThanhPho.DataSource = LoadDuLieuThanhPho();
        }

        private void frmThanhPho_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Ban co muon thoat khong ?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) e.Cancel = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvThanhPho_Click(object sender, EventArgs e)
        {
            int dong = dgvThanhPho.SelectedCells[0].RowIndex;
            txtThanhPho.Text = dgvThanhPho.Rows[dong].Cells[0].Value.ToString().Trim();
            txtTenThanhPho.Text = dgvThanhPho.Rows[dong].Cells[1].Value.ToString().Trim();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtThanhPho.Text.Trim();
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaThanhPho", conn);
                cmd.CommandText = "sp_XoaThanhPho";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paMa = new SqlParameter("@ma", ma);
                cmd.Parameters.Add(paMa);
               

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xoa thanh pho thanh cong!");
                }
                else
                {
                    MessageBox.Show("Xoa thanh pho khong thanh cong!");
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
            dgvThanhPho.DataSource = LoadDuLieuThanhPho();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtThanhPho.Text.Trim();
                string ten = txtTenThanhPho.Text.Trim();
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaThanhPho", conn);
                cmd.CommandText = "sp_SuaThanhPho";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paMa = new SqlParameter("@ma", ma);
                SqlParameter paTen = new SqlParameter("@ten", ten);
                cmd.Parameters.Add(paMa);
                cmd.Parameters.Add(paTen);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sua thanh pho thanh cong!");
                }
                else
                {
                    MessageBox.Show("Sua thanh pho khong thanh cong!");
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
            dgvThanhPho.DataSource = LoadDuLieuThanhPho();
        }
    }
}
