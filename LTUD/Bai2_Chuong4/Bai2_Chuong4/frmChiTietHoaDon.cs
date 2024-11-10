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
    public partial class frmChiTietHoaDon : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MINHHIEU\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True;TrustServerCertificate=True");
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            dgvChiTietHoaDon.DataSource = LoadDuLieuChiTietHoaDon();
            cboMaSP.DataSource = LoadDuLieuSanPham();
            cboMaSP.DisplayMember = "MASP";
            cboMaSP.ValueMember = "MASP";

            cboMaHD.DataSource = LoadDuLieuHoaDon();
            cboMaHD.DisplayMember = "MAHD";
            cboMaHD.ValueMember = "MAHD";

        }

        public DataTable LoadDuLieuChiTietHoaDon()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayDSChiTietHD", conn);
                cmd.CommandText = "sp_LayDSChiTietHD";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
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

        public DataTable LoadDuLieuHoaDon()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayDSHD", conn);
                cmd.CommandText = "sp_LayDSHD";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
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

        public DataTable LoadDuLieuSanPham()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayDSSP", conn);
                cmd.CommandText = "sp_LayDSSP";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
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

        private void dgvChiTietHoaDon_Click(object sender, EventArgs e)
        {
            int dong = dgvChiTietHoaDon.SelectedCells[0].RowIndex;
            cboMaHD.Text = dgvChiTietHoaDon.Rows[dong].Cells[0].Value.ToString().Trim();
            cboMaSP.Text = dgvChiTietHoaDon.Rows[dong].Cells[1].Value.ToString().Trim();
            txtSL.Text = dgvChiTietHoaDon.Rows[dong].Cells[2].Value.ToString().Trim();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //@mahd, @masp, @sl
                string mahd = cboMaHD.Text.Trim();
                string masp = cboMaSP.Text.Trim();
                string sl = txtSL.Text.Trim();
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemChiTietHD", conn);
                cmd.CommandText = "sp_ThemChiTietHD";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paMaHD = new SqlParameter("@mahd", mahd);
                SqlParameter paMaSP = new SqlParameter("@masp", masp);
                SqlParameter paSL = new SqlParameter("@sl", sl);
                cmd.Parameters.Add(paMaHD);
                cmd.Parameters.Add(paMaSP);
                cmd.Parameters.Add(paSL);

                if(cmd.ExecuteNonQuery() > 0){
                    MessageBox.Show("Them chi tiet don hang thanh cong!");
                }
                else
                {
                    MessageBox.Show("Them chi tiet don hang khong thanh cong!");
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
            dgvChiTietHoaDon.DataSource = LoadDuLieuChiTietHoaDon();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                //@mahd, @masp, @sl
                string mahd = cboMaHD.Text.Trim();
                string masp = cboMaSP.Text.Trim();
                string sl = txtSL.Text.Trim();
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaChiTietHoaDon", conn);
                cmd.CommandText = "sp_SuaChiTietHoaDon";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paMaHD = new SqlParameter("@mahd", mahd);
                SqlParameter paMaSP = new SqlParameter("@masp", masp);
                SqlParameter paSL = new SqlParameter("@sl", sl);
                cmd.Parameters.Add(paMaHD);
                cmd.Parameters.Add(paMaSP);
                cmd.Parameters.Add(paSL);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sua chi tiet don hang thanh cong!");
                }
                else
                {
                    MessageBox.Show("Sua chi tiet don hang khong thanh cong!");
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
            dgvChiTietHoaDon.DataSource = LoadDuLieuChiTietHoaDon();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                //@mahd, @masp, @sl
                string mahd = cboMaHD.Text.Trim();
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaChiTietHD1", conn);
                cmd.CommandText = "sp_XoaChiTietHD1";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paMaHD = new SqlParameter("@mahd", mahd);  
                cmd.Parameters.Add(paMaHD);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xoa chi tiet don hang thanh cong!");
                }
                else
                {
                    MessageBox.Show("Xoa chi tiet don hang khong thanh cong!");
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
            dgvChiTietHoaDon.DataSource = LoadDuLieuChiTietHoaDon();
        }

        private void frmChiTietHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Ban co muon thoat khong ?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) e.Cancel = true;
        }
    }
}
