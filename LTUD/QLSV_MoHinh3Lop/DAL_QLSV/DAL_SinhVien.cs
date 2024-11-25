using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ET_QLSV;

namespace DAL_QLSV
{
    public class DAL_SinhVien
    {
        SqlConnection conn = new SqlConnection("Data Source=MINHHIEU\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;TrustServerCertificate=True");

        public DataTable LayDSSinhVien()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayDSSV", conn);
                cmd.CommandText = "sp_LayDSSV";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public bool ThemSinhVien(ET_SinhVien sv) 
        {
            bool flag = false;
            try
            {
                //@ma, @ho, @ten, @gioitinh, @ngaysinh, @noisinh, @diachi, @quan, @makhoa, @hocbong
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemSinhVien", conn);
                cmd.CommandText = "sp_ThemSinhVien";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ma", sv.MaSV));
                cmd.Parameters.Add(new SqlParameter("@ho", sv.HoSV));
                cmd.Parameters.Add(new SqlParameter("@ten", sv.TenSV));
                cmd.Parameters.Add(new SqlParameter("@gioitinh", sv.GioiTinh));
                cmd.Parameters.Add(new SqlParameter("@ngaysinh", sv.NgaySinh.ToString("yyyy-MM-dd")));
                cmd.Parameters.Add(new SqlParameter("@noisinh", sv.NoiSinh));
                cmd.Parameters.Add(new SqlParameter("@diachi", sv.DiaChi));
                cmd.Parameters.Add(new SqlParameter("@quan", sv.Quan));
                cmd.Parameters.Add(new SqlParameter("@makhoa", sv.MaKhoa));
                cmd.Parameters.Add(new SqlParameter("@hocbong", sv.HocBong));

                if(cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return flag;
        }

        public bool XoaSinhVien(string maSV)
        {
            bool flag = false;
            try
            {
                //@ma, @ho, @ten, @gioitinh, @ngaysinh, @noisinh, @diachi, @quan, @makhoa, @hocbong
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaSinhVien", conn);
                cmd.CommandText = "sp_XoaSinhVien";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ma", maSV));
               
                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return flag;
        }

        public bool SuaSinhVien(ET_SinhVien sv)
        {
            bool flag = false;
            try
            {
                //@ma, @ho, @ten, @gioitinh, @ngaysinh, @noisinh, @diachi, @quan, @makhoa, @hocbong
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaSinhhVien", conn);
                cmd.CommandText = "sp_SuaSinhhVien";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ma", sv.MaSV));
                //cmd.Parameters.Add(new SqlParameter("@ho", sv.HoSV));
                //cmd.Parameters.Add(new SqlParameter("@ten", sv.TenSV));
                //cmd.Parameters.Add(new SqlParameter("@gioitinh", sv.GioiTinh));
                //cmd.Parameters.Add(new SqlParameter("@ngaysinh", sv.NgaySinh.ToString("yyyy-MM-dd")));
                //cmd.Parameters.Add(new SqlParameter("@noisinh", sv.NoiSinh));
                cmd.Parameters.Add(new SqlParameter("@diachi", sv.DiaChi));
                //cmd.Parameters.Add(new SqlParameter("@quan", sv.Quan));
                cmd.Parameters.Add(new SqlParameter("@makhoa", sv.MaKhoa));
                //cmd.Parameters.Add(new SqlParameter("@hocbong", sv.HocBong));

                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return flag;
        }

        public string LayTenSinhVienTheoMa(string maSV)
        {
            string result = "";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayTenSinhVienTheoMa", conn);
                cmd.CommandText = "sp_LayTenSinhVienTheoMa";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ma", maSV));

                result = (string)cmd.ExecuteScalar();


            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public string LayMaSinhVienTheoTen(string tenSV)
        {
            string result = "";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayMaSinhVienTheoTen", conn);
                cmd.CommandText = "sp_LayMaSinhVienTheoTen";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ten", tenSV));

                result = (string)cmd.ExecuteScalar();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public DataTable TimSinhVienTheoMa(string maSV)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_TimSinhVienTheoMa", conn);
                cmd.CommandText = "sp_TimSinhVienTheoMa";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ma", maSV));

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable TimSinhVienTheoTen(string tenSV)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_TimSinhVienTheoTen", conn);
                cmd.CommandText = "sp_TimSinhVienTheoTen";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ten", tenSV));

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}
