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

namespace Bai2_Chuong4
{
    public partial class frmNhanVien : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MINHHIEU\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True;TrustServerCertificate=True");
        public frmNhanVien()
        {
            InitializeComponent();
        }

        public DataTable LoadDuLieuNhanVien()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayDSNV", conn);
                cmd.CommandText = "sp_LayDSNV";
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

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            radNam.Checked = true;
            dgvNhanVien.DataSource = LoadDuLieuNhanVien();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //@ma
                string ma = txtNV.Text.Trim();
                //string decodeMa = ma.Normalize(NormalizationForm.FormC);

                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaNV", conn);
                cmd.CommandText = "sp_XoaNV";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paMa = new SqlParameter("@ma", ma);
                cmd.Parameters.Add(paMa);
                

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xoa sinh vien thanh cong!");
                }
                else
                {
                    MessageBox.Show("Xoa sinh vien khong thanh cong!");
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
            dgvNhanVien.DataSource = LoadDuLieuNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //@ma, @ho, @ten, @gioitinh, @ngaysinh, @diachi, @dienthoai, @hinh
                string ma = txtNV.Text.Trim();
                //string decodeMa = ma.Normalize(NormalizationForm.FormC);
                
                string ho = txtHo.Text.Trim();
                string ten = txtTen.Text.Trim();
                string gioiTinh = "Nam";
                if (radNu.Checked)
                {
                    gioiTinh = "Nu";
                }
                string ngaSinh = dateTimePicker1.Value.ToString("yyyy-MM-dd");//2003-09-13
                string diaChi = txtDiaChi.Text.Trim();
                string dienThoai = txtDienThoai.Text.Trim();
                string hinh = txtHinh.Text.Trim();
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemNV", conn);
                cmd.CommandText = "sp_ThemNV";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paMa = new SqlParameter("@ma", ma);
                SqlParameter paHo = new SqlParameter("@ho", ho);
                SqlParameter paTen = new SqlParameter("@ten", ten);
                SqlParameter paGioiTinh = new SqlParameter("@gioitinh", gioiTinh);
                SqlParameter paNgaySinh = new SqlParameter("@ngaysinh", ngaSinh);
                SqlParameter paDiaChi = new SqlParameter("@diachi", diaChi);
                SqlParameter paDienThoai = new SqlParameter("@dienthoai", dienThoai);
                SqlParameter paHinh = new SqlParameter("@hinh", hinh);
                cmd.Parameters.Add(paMa);
                cmd.Parameters.Add(paHo);
                cmd.Parameters.Add(paTen);
                cmd.Parameters.Add(paGioiTinh);
                cmd.Parameters.Add(paNgaySinh);
                cmd.Parameters.Add(paDiaChi);
                cmd.Parameters.Add(paDienThoai);
                cmd.Parameters.Add(paHinh);

                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Them sinh vien thanh cong!");
                }
                else
                {
                    MessageBox.Show("Them sinh vien khong thanh cong!");
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
            dgvNhanVien.DataSource = LoadDuLieuNhanVien();
        }

        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Ban co muon thoat khong ?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.No) e.Cancel = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            //@ma, @ho, @ten, @gioitinh, @ngaysinh, @diachi, @dienthoai, @hinh
            int dong = dgvNhanVien.SelectedCells[0].RowIndex;
            txtNV.Text = dgvNhanVien.Rows[dong].Cells[0].Value.ToString();
            txtHo.Text = dgvNhanVien.Rows[dong].Cells[1].Value.ToString();
            txtTen.Text = dgvNhanVien.Rows[dong].Cells[2].Value.ToString();
           // MessageBox.Show(dgvNhanVien.Rows[dong].Cells[3].Value.ToString()); return;
            if(dgvNhanVien.Rows[dong].Cells[3].Value.ToString() == "Nam  ")
            {
                radNam.Checked = true;
            }
            else{
                radNu.Checked = true;
            }
            dateTimePicker1.Value = Convert.ToDateTime(dgvNhanVien.Rows[dong].Cells[4].Value.ToString());
            txtDiaChi.Text = dgvNhanVien.Rows[dong].Cells[5].Value.ToString();
            txtDienThoai.Text = dgvNhanVien.Rows[dong].Cells[6].Value.ToString();
            txtHinh.Text = dgvNhanVien.Rows[dong].Cells[7].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //@ma char(6), @diachi nvarchar(50), @dienthoai char(10), @hinh char(50)
            try
            {

                string ma = txtNV.Text.Trim();
                //string decodeMa = ma.Normalize(NormalizationForm.FormC);
                string diaChi = txtDiaChi.Text.Trim();
                string dienThoai = txtDienThoai.Text.Trim();
                string hinh = txtHinh.Text.Trim();
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaNV", conn);
                cmd.CommandText = "sp_SuaNV";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paMa = new SqlParameter("@ma", ma);
                SqlParameter paDiaChi = new SqlParameter("@diachi", diaChi);
                SqlParameter paDienThoai = new SqlParameter("@dienthoai", dienThoai);
                SqlParameter paHinh = new SqlParameter("@hinh", hinh);
                cmd.Parameters.Add(paMa);
                cmd.Parameters.Add(paDiaChi);
                cmd.Parameters.Add(paDienThoai);
                cmd.Parameters.Add(paHinh);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sua sinh vien thanh cong!");
                }
                else
                {
                    MessageBox.Show("Sua sinh vien khong thanh cong!");
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
            dgvNhanVien.DataSource = LoadDuLieuNhanVien();
        }
    }
}
