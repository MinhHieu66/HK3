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
    public partial class frmKhachHang : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MINHHIEU\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True;TrustServerCertificate=True");

        public frmKhachHang()
        {
            InitializeComponent();
        }

        public DataTable LoadDuLieuKhachHang()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayDSKH", conn);
                cmd.CommandText = "sp_LayDSKH";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = LoadDuLieuKhachHang();
        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            int dong = dgvKhachHang.SelectedCells[0].RowIndex;

            txtMaKH1.Text = dgvKhachHang.Rows[dong].Cells[0].Value.ToString().Trim();
            txtTenCty.Text = dgvKhachHang.Rows[dong].Cells[1].Value.ToString().Trim();
            txtDiaChi.Text = dgvKhachHang.Rows[dong].Cells[2].Value.ToString().Trim();
            txtThanhPho.Text = dgvKhachHang.Rows[dong].Cells[3].Value.ToString().Trim();
            txtDienThoai.Text = dgvKhachHang.Rows[dong].Cells[4].Value.ToString().Trim();
        }

        private void txtTenCty_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //@ma, @tencty, @diachi, @thanhpho, @dienthoai
                string ma = txtMaKH1.Text.Trim();
                string tenCty = txtTenCty.Text.Trim();  
                string diaChi = txtDiaChi.Text.Trim();
                string thanhPho = txtThanhPho.Text.Trim();
                string dienThoai = txtDienThoai.Text.Trim();
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemKH", conn);
                cmd.CommandText = "sp_ThemKH";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paMa = new SqlParameter("@ma", ma);
                SqlParameter paTenCty = new SqlParameter("@tencty", tenCty);
                SqlParameter paDiaChi = new SqlParameter("@diachi", diaChi);
                SqlParameter paThanhPho = new SqlParameter("@thanhpho", thanhPho);
                SqlParameter paDienThoai = new SqlParameter("@dienthoai", dienThoai);
                cmd.Parameters.Add(paMa);
                cmd.Parameters.Add(paTenCty);
                cmd.Parameters.Add(paDiaChi);
                cmd.Parameters.Add(paThanhPho);
                cmd.Parameters.Add(paDienThoai);

                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Them khach hang thanh cong!");
                }
                else
                {
                    MessageBox.Show("Them khach hang khong thanh cong!");
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
            dgvKhachHang.DataSource = LoadDuLieuKhachHang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                //@ma
                string ma = txtMaKH1.Text.Trim();
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaKH", conn);
                cmd.CommandText = "sp_XoaKH";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paMa = new SqlParameter("@ma", ma);
                cmd.Parameters.Add(paMa);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xoa khach hang thanh cong!");
                }
                else
                {
                    MessageBox.Show("Xoa khach hang khong thanh cong!");
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
            dgvKhachHang.DataSource = LoadDuLieuKhachHang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                //@ma, @tencty, @diachi, @thanhpho, @dienthoai
                string ma = txtMaKH1.Text.Trim();
                string tenCty = txtTenCty.Text.Trim();
                string diaChi = txtDiaChi.Text.Trim();
                string thanhPho = txtThanhPho.Text.Trim();
                string dienThoai = txtDienThoai.Text.Trim();
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaKH", conn);
                cmd.CommandText = "sp_SuaKH";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paMa = new SqlParameter("@ma", ma);
                SqlParameter paTenCty = new SqlParameter("@tencty", tenCty);
                SqlParameter paDiaChi = new SqlParameter("@diachi", diaChi);
                SqlParameter paThanhPho = new SqlParameter("@thanhpho", thanhPho);
                SqlParameter paDienThoai = new SqlParameter("@dienthoai", dienThoai);
                cmd.Parameters.Add(paMa);
                cmd.Parameters.Add(paTenCty);
                cmd.Parameters.Add(paDiaChi);
                cmd.Parameters.Add(paThanhPho);
                cmd.Parameters.Add(paDienThoai);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sua khach hang thanh cong!");
                }
                else
                {
                    MessageBox.Show("Sua khach hang khong thanh cong!");
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
            dgvKhachHang.DataSource = LoadDuLieuKhachHang();
        }

        private void frmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Ban co muon thoat khong ?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) e.Cancel = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
