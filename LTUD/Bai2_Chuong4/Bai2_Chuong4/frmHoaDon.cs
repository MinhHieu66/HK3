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
    public partial class frmHoaDon : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MINHHIEU\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True;TrustServerCertificate=True");
        public frmHoaDon()
        {
            InitializeComponent();
        }

        public DataTable LoadDuLieuNV()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayDSNV", conn);
                cmd.CommandText = "sp_LayDSNV";
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

        public DataTable LoadDuLieuKH()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayDSKH", conn);
                cmd.CommandText = "sp_LayDSKH";
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

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = LoadDuLieuHoaDon();
            cboMaKH.DataSource = LoadDuLieuKH();
            cboMaKH.DisplayMember = "MAKH";
            cboMaKH.ValueMember = "MAKH";

            cboMaNV.DataSource = LoadDuLieuNV();
            cboMaNV.DisplayMember = "MANV";
            cboMaNV.ValueMember = "MANV";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Ban co muon thoat khong ?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) e.Cancel = true;
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHoaDon_Click(object sender, EventArgs e)
        {
            int dong = dgvHoaDon.SelectedCells[0].RowIndex;
            txtMaHD.Text = dgvHoaDon.Rows[dong].Cells[0].Value.ToString().Trim();
            cboMaKH.Text = dgvHoaDon.Rows[dong].Cells[1].Value.ToString().Trim();
            cboMaNV.Text = dgvHoaDon.Rows[dong].Cells[2].Value.ToString().Trim();
            dtpLapHD.Value = Convert.ToDateTime(dgvHoaDon.Rows[dong].Cells[3].Value.ToString().Trim());
            dtpNhanHang.Value = Convert.ToDateTime(dgvHoaDon.Rows[dong].Cells[4].Value.ToString().Trim());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //@mahd, @makh, @manv, @ngaylaphd, @ngaynhanhang
                string mahd = txtMaHD.Text.Trim();
                string makh = cboMaKH.Text.Trim();
                string manv  = cboMaNV.Text.Trim();
                string ngaylaphd = dtpLapHD.Value.ToString("yyyy-MM-dd");
                string ngaynhanhang = dtpNhanHang.Value.ToString("yyyy-MM-dd");
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemHoaDon", conn);
                cmd.CommandText = "sp_ThemHoaDon";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter daMaHD = new SqlParameter("@mahd", mahd);
                SqlParameter daMaKH = new SqlParameter("@makh", makh);
                SqlParameter daMaNV = new SqlParameter("@manv", manv);
                SqlParameter daNgayLapHoaDon = new SqlParameter("@ngaylaphd", ngaylaphd);
                SqlParameter daNhanHang = new SqlParameter("@ngaynhanhang", ngaynhanhang);
                cmd.Parameters.Add(daMaHD);
                cmd.Parameters.Add(daMaKH);
                cmd.Parameters.Add(daMaNV);
                cmd.Parameters.Add(daNgayLapHoaDon);
                cmd.Parameters.Add(daNhanHang);

                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Them hoa don thanh cong!");
                }
                else
                {
                    MessageBox.Show("Them hoa don khong thanh cong!");
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
            dgvHoaDon.DataSource = LoadDuLieuHoaDon();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string mahd = txtMaHD.Text.Trim();
         
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaHoaDon", conn);
                cmd.CommandText = "sp_XoaHoaDon";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter daMaHD = new SqlParameter("@ma", mahd);
                cmd.Parameters.Add(daMaHD);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xoa hoa don thanh cong!");
                }
                else
                {
                    MessageBox.Show("Xoa hoa don khong thanh cong!");
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
            dgvHoaDon.DataSource = LoadDuLieuHoaDon();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                //@mahd, @makh, @manv, @ngaylaphd, @ngaynhanhang
                string mahd = txtMaHD.Text.Trim();
                string makh = cboMaKH.Text.Trim();
                string manv = cboMaNV.Text.Trim();
                string ngaylaphd = dtpLapHD.Value.ToString("yyyy-MM-dd");
                string ngaynhanhang = dtpNhanHang.Value.ToString("yyyy-MM-dd");
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaHoaDon", conn);
                cmd.CommandText = "sp_SuaHoaDon";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter daMaHD = new SqlParameter("@mahd", mahd);
                SqlParameter daMaKH = new SqlParameter("@makh", makh);
                SqlParameter daMaNV = new SqlParameter("@manv", manv);
                SqlParameter daNgayLapHoaDon = new SqlParameter("@ngaylaphd", ngaylaphd);
                SqlParameter daNhanHang = new SqlParameter("@ngaynhanhang", ngaynhanhang);
                cmd.Parameters.Add(daMaHD);
                cmd.Parameters.Add(daMaKH);
                cmd.Parameters.Add(daMaNV);
                cmd.Parameters.Add(daNgayLapHoaDon);
                cmd.Parameters.Add(daNhanHang);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Them hoa don thanh cong!");
                }
                else
                {
                    MessageBox.Show("Them hoa don khong thanh cong!");
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
            dgvHoaDon.DataSource = LoadDuLieuHoaDon();
        }
    }
}
