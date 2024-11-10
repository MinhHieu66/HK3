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
    public partial class frmKetQua : Form
    {
        public frmKetQua()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=MINHHIEU\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;TrustServerCertificate=True");

        public DataTable LoadDuLieuDiemThi()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayDSKQ");
                cmd.CommandText = "sp_LayDSKQ";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

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

        public DataTable LoadDuLieuKhoa()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayDSMonHoc");
                cmd.CommandText = "sp_LayDSMonHoc";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

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

        public DataTable LoadDuLieuSinhVien()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayDSSV");
                cmd.CommandText = "sp_LayDSSV";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmKetQua_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Ban co muon thoat khong?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) e.Cancel = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKetQua_Load(object sender, EventArgs e)
        {
            dgvKetQua.DataSource = LoadDuLieuDiemThi();

            cboMaMH.DataSource = LoadDuLieuKhoa();
            cboMaMH.ValueMember = "MAMH";
            cboMaMH.DisplayMember = "TENMH";

            cboMaSV.DataSource = LoadDuLieuSinhVien();
            cboMaSV.ValueMember = "MASV";
            cboMaSV.DisplayMember = "MASV";

        }

        public string LayIdTheoTenMonHoc()
        {
            SqlCommand cmd1 = new SqlCommand("sp_LayIdTheoTenMonHoc");
            cmd1.CommandText = "sp_LayIdTheoTenMonHoc";
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Connection = conn;

            SqlParameter paTenKhoa = new SqlParameter("@ten", cboMaMH.Text.Trim());
            cmd1.Parameters.Add(paTenKhoa);

            string maKhoa = cmd1.ExecuteScalar().ToString();

            return maKhoa;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemKetQua");
                cmd.CommandText = "sp_ThemKetQua";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                //@masv, @mamh, @diem
                SqlParameter paMaSV = new SqlParameter("@masv", cboMaSV.Text);
                cmd.Parameters.Add(paMaSV);


                string maKhoa = LayIdTheoTenMonHoc();
                SqlParameter paMaMH = new SqlParameter("@mamh", maKhoa.Trim());
                cmd.Parameters.Add(paMaMH);

                SqlParameter diem = new SqlParameter("@diem", txtDiemThi.Text.Trim());
                cmd.Parameters.Add(diem);

                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Them diem thanh cong!");
                }
                else
                {
                    MessageBox.Show("Them diem khong thanh cong!");
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
            dgvKetQua.DataSource = LoadDuLieuDiemThi();
        }



        private void dgvKetQua_Click(object sender, EventArgs e)
        {
            int dong = dgvKetQua.SelectedCells[0].RowIndex;
            txtDiemThi.Text = dgvKetQua.Rows[dong].Cells[2].Value.ToString();
            cboMaSV.Text = dgvKetQua.Rows[dong].Cells[0].Value.ToString();

            string maMH = dgvKetQua.Rows[dong].Cells[1].Value.ToString();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayTenMHBById", conn);
                cmd.CommandText = "sp_LayTenMHBById";
                cmd.CommandType = CommandType.StoredProcedure;

                if (maMH.Length != 0)
                {
                    SqlParameter paTenMH = new SqlParameter("@ma", maMH);
                    cmd.Parameters.Add(paTenMH);
                    cboMaMH.Text = cmd.ExecuteScalar().ToString();
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
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaKetQua");
                cmd.CommandText = "sp_XoaKetQua";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                
                SqlParameter paMaSV = new SqlParameter("@ma", cboMaSV.Text);
                cmd.Parameters.Add(paMaSV);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xoa diem thanh cong!");
                }
                else
                {
                    MessageBox.Show("Xoa diem khong thanh cong!");
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
            dgvKetQua.DataSource = LoadDuLieuDiemThi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaKetQua");
                cmd.CommandText = "sp_SuaKetQua";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                //@masv, @mamh, @diem
                SqlParameter paMaSV = new SqlParameter("@masv", cboMaSV.Text);
                cmd.Parameters.Add(paMaSV);


                string maKhoa = LayIdTheoTenMonHoc();
                SqlParameter paMaMH = new SqlParameter("@mamh", maKhoa.Trim());
                cmd.Parameters.Add(paMaMH);

                SqlParameter diem = new SqlParameter("@diem", txtDiemThi.Text.Trim());
                cmd.Parameters.Add(diem);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sua diem thanh cong!");
                }
                else
                {
                    MessageBox.Show("Sua diem khong thanh cong!");
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
            dgvKetQua.DataSource = LoadDuLieuDiemThi();
        }

        private void dgvKetQua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
