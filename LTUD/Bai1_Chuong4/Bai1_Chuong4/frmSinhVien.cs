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
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=MINHHIEU\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;TrustServerCertificate=True");

        public DataTable LoadDuLieuSinhVien()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayDSSV", conn);
                cmd.CommandText = "sp_LayDSSV";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dtSinhVien = new SqlDataAdapter(cmd);

                dtSinhVien.Fill(dt);
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
                SqlCommand cmd = new SqlCommand("sp_LayDSKhoa", conn);
                cmd.CommandText = "sp_LayDSKhoa";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dtSinhVien = new SqlDataAdapter(cmd);
                

                dtSinhVien.Fill(dt);
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



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private string LayMaKhoa()
        {
            try
            {
                //conn.Open();
                SqlCommand cmd1 = new SqlCommand("sp_LayIdByTenKhoa", conn);
                cmd1.CommandText = "sp_LayIdByTenKhoa";
                cmd1.CommandType = CommandType.StoredProcedure;

                SqlParameter paTenKhoa = new SqlParameter("@tenkhoa", cboMaKhoa.Text);
                cmd1.Parameters.Add(paTenKhoa);

                string res = cmd1.ExecuteScalar().ToString();
                return res;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { //conn.Close();
                      }
            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaSinhhVien");
                cmd.CommandText = "sp_SuaSinhhVien";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paMa = new SqlParameter("@ma", txtMaSV1.Text.Trim());
                cmd.Parameters.Add(paMa);

                SqlParameter paDiaChi = new SqlParameter("@diachi", txtDiaChi.Text.Trim());
                cmd.Parameters.Add(paDiaChi);

                string maKhoa = LayMaKhoa();

                SqlParameter paMaKhoa = new SqlParameter("@makhoa", maKhoa.Trim());
                cmd.Parameters.Add(paMaKhoa);

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
            dgvSinhVien.DataSource = LoadDuLieuSinhVien();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            dgvSinhVien.DataSource = LoadDuLieuSinhVien();
            cboMaKhoa.DataSource = LoadDuLieuKhoa();
            cboMaKhoa.DisplayMember = "TenKhoa";
            cboMaKhoa.ValueMember = "MaKhoa";
            radNam.Checked = true;
        }

        private void dgvSinhVien_Click(object sender, EventArgs e)
        {
            int dong = dgvSinhVien.SelectedCells[0].RowIndex;
            txtMaSV1.Text = dgvSinhVien.Rows[dong].Cells[0].Value.ToString().Trim();
            txtHoSV.Text = dgvSinhVien.Rows[dong].Cells[1].Value.ToString();
            txtTenSV.Text = dgvSinhVien.Rows[dong].Cells[2].Value.ToString();
            if(dgvSinhVien.Rows[dong].Cells[3].Value.ToString() == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            dateTimePicker1.Value = Convert.ToDateTime(dgvSinhVien.Rows[dong].Cells[4].Value.ToString());

            txtNoiSinh.Text = dgvSinhVien.Rows[dong].Cells[5].Value.ToString();
            txtDiaChi.Text = dgvSinhVien.Rows[dong].Cells[6].Value.ToString();
            txtQuan.Text = dgvSinhVien.Rows[dong].Cells[7].Value.ToString();
            txtHocBong.Text = dgvSinhVien.Rows[dong].Cells[9].Value.ToString();
            string maKhoa = dgvSinhVien.Rows[dong].Cells[8].Value.ToString();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LaySVById", conn);
                cmd.CommandText = "sp_LaySVById";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paMa = new SqlParameter("@ma", maKhoa);
                cmd.Parameters.Add(paMa);

                string tenKhoa = cmd.ExecuteScalar().ToString();
                cboMaKhoa.Text = tenKhoa;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            
        }

        private void frmSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Ban co chac muon thoat?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) e.Cancel = true;
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaSinhVien");
                cmd.CommandText = "sp_XoaSinhVien";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paMa = new SqlParameter("@ma", txtMaSV1.Text.Trim());
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
            dgvSinhVien.DataSource = LoadDuLieuSinhVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemSinhVien");
                cmd.CommandText = "sp_ThemSinhVien";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                string gioiTinh = "Nam";
                if (radNu.Checked) gioiTinh = "Nu";
                SqlParameter paMa = new SqlParameter("@ma", txtMaSV1.Text.Trim());
                cmd.Parameters.Add(paMa);
                SqlParameter paHo = new SqlParameter("@ho", txtHoSV.Text.Trim());
                cmd.Parameters.Add(paHo);
                SqlParameter paTen = new SqlParameter("@ten", txtTenSV.Text.Trim());
                cmd.Parameters.Add(paTen);
                SqlParameter paGioiTinh = new SqlParameter("@gioitinh", gioiTinh);
                cmd.Parameters.Add(paGioiTinh);
                SqlParameter paNgaySinh = new SqlParameter("@ngaysinh", dateTimePicker1.Value);
                cmd.Parameters.Add(paNgaySinh);
                SqlParameter paNoiSinh = new SqlParameter("@noisinh", txtNoiSinh.Text.Trim());
                cmd.Parameters.Add(paNoiSinh);
                SqlParameter paDiaChi = new SqlParameter("@diachi", txtDiaChi.Text.Trim());
                cmd.Parameters.Add(paDiaChi);
                SqlParameter paQuan = new SqlParameter("@quan", txtQuan.Text.Trim());
                cmd.Parameters.Add(paQuan);
                string maKhoa = LayMaKhoa();
                SqlParameter paMaKhoa = new SqlParameter("@makhoa", maKhoa);
                cmd.Parameters.Add(paMaKhoa);
                SqlParameter paHocBong = new SqlParameter("@hocbong", txtHocBong.Text.Trim());
                cmd.Parameters.Add(paHocBong);

                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Them sinh vien thanh cong!");
                }
                else
                {
                    MessageBox.Show("Them sinh vien khong thanh cong!");
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);

            }finally {
                conn.Close();
            }
            dgvSinhVien.DataSource = LoadDuLieuSinhVien();
        }
    }
}
