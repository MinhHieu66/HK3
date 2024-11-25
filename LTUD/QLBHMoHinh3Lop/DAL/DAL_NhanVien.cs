using ET_QLSV;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhanVien
    {
        SqlConnection conn = new SqlConnection("Data Source=MINHHIEU\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True;TrustServerCertificate=True");

        //Lay danh sach san pham
        public DataTable LayDSNhanVien()
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

        //Them
        public bool ThemNhanVien(ET_NhanVien eT_NhanVien)
        {
            bool flag = false;
            try
            {
                //@ma, @ho, @ten, @gioitinh, @ngaysinh, @diachi, @dienthoai, @hinh
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemNV", conn);
                cmd.CommandText = "sp_ThemNV";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ma", eT_NhanVien.MaNV));
                cmd.Parameters.Add(new SqlParameter("@ho", eT_NhanVien.Ho));
                cmd.Parameters.Add(new SqlParameter("@ten", eT_NhanVien.Ten));
                cmd.Parameters.Add(new SqlParameter("@gioitinh", eT_NhanVien.GioiTinh));
                cmd.Parameters.Add(new SqlParameter("@ngaysinh", eT_NhanVien.NgaySinh.ToString("yyyy-MM-dd")));
                cmd.Parameters.Add(new SqlParameter("@diachi", eT_NhanVien.DiaChi));
                cmd.Parameters.Add(new SqlParameter("@dienthoai", eT_NhanVien.DienThoai));
                cmd.Parameters.Add(new SqlParameter("@hinh", eT_NhanVien.Hinh));

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


        //Xoa
        public bool XoaNhanVien(string maNV)
        {
            bool flag = false;
            try
            {
                //@ma, @ten, @donvitinh, @dongia, @hinh
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaNV", conn);
                cmd.CommandText = "sp_XoaNV";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ma", maNV));

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

        //Sua
        public bool SuaNhanVien(ET_NhanVien eT_NhanVien)
        {
            bool flag = false;
            try
            {
                //@ma, @ho, @ten, @gioitinh, @ngaysinh, @diachi, @dienthoai, @hinh
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaNV", conn);
                cmd.CommandText = "sp_SuaNV";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ma", eT_NhanVien.MaNV));
                //cmd.Parameters.Add(new SqlParameter("@ho", eT_NhanVien.Ho));
                //cmd.Parameters.Add(new SqlParameter("@ten", eT_NhanVien.Ten));
                //cmd.Parameters.Add(new SqlParameter("@gioitinh", eT_NhanVien.GioiTinh));
                //cmd.Parameters.Add(new SqlParameter("@ngaysinh", eT_NhanVien.NgaySinh.ToString("yyyy-MM-dd")));
                cmd.Parameters.Add(new SqlParameter("@diachi", eT_NhanVien.DiaChi));
                cmd.Parameters.Add(new SqlParameter("@dienthoai", eT_NhanVien.DienThoai));
                cmd.Parameters.Add(new SqlParameter("@hinh", eT_NhanVien.Hinh));

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
    }
}
