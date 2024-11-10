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
using System.Globalization;

namespace Bai1_Chuong4
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=MINHHIEU\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;TrustServerCertificate=True");

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public DataTable LoadDuLieuSinhVien()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayDSSV", conn);
                cmd.CommandText = "sp_LayDSSV";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return null;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            dgvSinhVien.DataSource = LoadDuLieuSinhVien();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string maSV = txtMaSV.Text.Trim();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_TimSinhVienById", conn);
                cmd.CommandText = "sp_TimSinhVienById";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ma", maSV);
                cmd.Parameters.Add(sqlParameter);

                
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dt);  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            dgvSinhVien.DataSource = dt;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string fullName = txtTenSV.Text.Trim();
            
            string[] arrS = fullName.Split(' ');
            string ten = arrS[arrS.Length - 1];
            string ho = "";
            for (int i = 0; i < arrS.Length - 1; i++) 
            {
                ho += arrS[i] + " ";
            }
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_TimSinhVienByHoTen", conn);
                cmd.CommandText = "sp_TimSinhVienByHoTen";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paHo = new SqlParameter("@ho", ho.Trim());
                cmd.Parameters.Add(paHo);

                SqlParameter paTen = new SqlParameter("@ten", ten.Trim());
                cmd.Parameters.Add(paTen);



                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            dgvSinhVien.DataSource = dt;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string date = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            //string date = "1977/03/23";
            string[] arrS = date.Split('/');
            int ngay = int.Parse(arrS[2]);
            int thang = int.Parse(arrS[1]);
            int nam = int.Parse(arrS[0]);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("TimSinhVienTheoNgaySinh", conn);
                cmd.CommandText = "TimSinhVienTheoNgaySinh";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paNgay = new SqlParameter("@ngay", ngay);
                cmd.Parameters.Add(paNgay);
                SqlParameter paThang = new SqlParameter("@thang", thang);
                cmd.Parameters.Add(paThang);
                SqlParameter paNam = new SqlParameter("@nam", nam);
                cmd.Parameters.Add(paNam);


                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            dgvSinhVien.DataSource = dt;
        }
    }
}
