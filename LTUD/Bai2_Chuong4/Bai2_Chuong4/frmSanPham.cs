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
    public partial class frmSanPham : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MINHHIEU\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True;TrustServerCertificate=True");
        public frmSanPham()
        {
            InitializeComponent();
        }

        public DataTable LoadDuLieuSannPham()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayDSSP", conn);
                cmd.CommandText = "sp_LayDSSP";
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

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = LoadDuLieuSannPham();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Ban co muon thoat khong ?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) e.Cancel = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSanPham_Click(object sender, EventArgs e)
        {
            int dong = dgvSanPham.SelectedCells[0].RowIndex;
            txtMaSP.Text = dgvSanPham.Rows[dong].Cells[0].Value.ToString().Trim();
            txtTenSP.Text = dgvSanPham.Rows[dong].Cells[1].Value.ToString().Trim();
            txtDonViTinh.Text = dgvSanPham.Rows[dong].Cells[2].Value.ToString().Trim();
            txtDonGia.Text = dgvSanPham.Rows[dong].Cells[3].Value.ToString().Trim();
            txtHinh.Text = dgvSanPham.Rows[dong].Cells[4].Value.ToString().Trim();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //@ma, @ten, @donvitinh, @dongia, @hinh
            try
            {
                string ma = txtMaSP.Text.Trim();
                string ten = txtTenSP.Text.Trim();  
                string donViTinh = txtDonViTinh.Text.Trim();
                string donGia = txtDonGia.Text.Trim();
                string hinh = txtHinh.Text.Trim();
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemSP", conn);
                cmd.CommandText = "sp_ThemSP";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paMa = new SqlParameter("@ma", ma);
                SqlParameter paTen = new SqlParameter("@ten", ten);
                SqlParameter paDonViTinh = new SqlParameter("@donvitinh", donViTinh);
                SqlParameter paDonGia = new SqlParameter("@dongia", donGia);
                SqlParameter paHinh = new SqlParameter("@hinh", hinh);
                cmd.Parameters.Add(paMa);
                cmd.Parameters.Add(paTen);
                cmd.Parameters.Add(paDonViTinh);
                cmd.Parameters.Add(paDonGia);
                cmd.Parameters.Add(paHinh);

                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Them san pham thanh cong!");
                }
                else
                {
                    MessageBox.Show("Them san pham khong thanh cong!");
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

            dgvSanPham.DataSource = LoadDuLieuSannPham();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //@ma
            try
            {
                string ma = txtMaSP.Text.Trim();
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaSP", conn);
                cmd.CommandText = "sp_XoaSP";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paMa = new SqlParameter("@ma", ma);
                cmd.Parameters.Add(paMa);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xoa san pham thanh cong!");
                }
                else
                {
                    MessageBox.Show("Xoa san pham khong thanh cong!");
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

            dgvSanPham.DataSource = LoadDuLieuSannPham();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //@ma, @ten, @donvitinh, @dongia, @hinh
            try
            {
                string ma = txtMaSP.Text.Trim();
                string ten = txtTenSP.Text.Trim();
                string donViTinh = txtDonViTinh.Text.Trim();
                string donGia = txtDonGia.Text.Trim();
                string hinh = txtHinh.Text.Trim();
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaSP", conn);
                cmd.CommandText = "sp_SuaSP";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paMa = new SqlParameter("@ma", ma);
                SqlParameter paTen = new SqlParameter("@ten", ten);
                SqlParameter paDonViTinh = new SqlParameter("@donvitinh", donViTinh);
                SqlParameter paDonGia = new SqlParameter("@dongia", donGia);
                SqlParameter paHinh = new SqlParameter("@hinh", hinh);
                cmd.Parameters.Add(paMa);
                cmd.Parameters.Add(paTen);
                cmd.Parameters.Add(paDonViTinh);
                cmd.Parameters.Add(paDonGia);
                cmd.Parameters.Add(paHinh);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sua san pham thanh cong!");
                }
                else
                {
                    MessageBox.Show("Sua san pham khong thanh cong!");
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

            dgvSanPham.DataSource = LoadDuLieuSannPham();
        }
    }
}
