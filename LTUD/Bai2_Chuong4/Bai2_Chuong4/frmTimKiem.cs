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
    public partial class frmTimKiem : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MINHHIEU\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True;TrustServerCertificate=True");
        
        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTimKiem_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Ban co chac muon thoat?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) e.Cancel = true; 
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_TimSPTheoMa", conn);
                cmd.CommandText = "sp_TimSPTheoMa";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paMa = new SqlParameter("@ma", txtMaSP.Text.Trim());
                cmd.Parameters.Add(paMa);

                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(dt);

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            dgvKQ.DataSource = dt;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_TimSPTheoTen", conn);
                cmd.CommandText = "sp_TimSPTheoTen";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paMa = new SqlParameter("@ten", txtTenSP.Text.Trim());
                cmd.Parameters.Add(paMa);

                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            dgvKQ.DataSource = dt;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_TimKHTheoMa", conn);
                cmd.CommandText = "sp_TimKHTheoMa";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paMa = new SqlParameter("@ma", txtMaKH.Text.Trim());
                cmd.Parameters.Add(paMa);

                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            dgvKQ.DataSource = dt;
        }
    }
}
