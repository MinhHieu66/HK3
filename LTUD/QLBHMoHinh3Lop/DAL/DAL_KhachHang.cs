using ET_QLSV;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhachHang
    {
        SqlConnection conn = new SqlConnection("Data Source=MINHHIEU\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True;TrustServerCertificate=True");

        //List
        public DataTable LayDanhSachKhachHang()
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
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //Add
        public bool ThemKhachHang(ET_KhachHang eT_KhachHang)
        {
            bool flag = false;
            try
            {
                //@ma, @tencty, @diachi, @thanhpho, @dienthoai
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemKH", conn);
                cmd.CommandText = "sp_ThemKH";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@ma", eT_KhachHang.MaKH));
                cmd.Parameters.Add(new SqlParameter("@tencty", eT_KhachHang.TenCty));
                cmd.Parameters.Add(new SqlParameter("@diachi", eT_KhachHang.DiaChi));
                cmd.Parameters.Add(new SqlParameter("@thanhpho", eT_KhachHang.ThanhPho));
                cmd.Parameters.Add(new SqlParameter("@dienthoai", eT_KhachHang.DienThoai));

                if(cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return flag;
        }

        //Update
        public bool SuaKhachHang(ET_KhachHang eT_KhachHang)
        {
            bool flag = false;
            try
            {
                //@ma, @tencty, @diachi, @thanhpho, @dienthoai
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaKH", conn);
                cmd.CommandText = "sp_SuaKH";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@ma", eT_KhachHang.MaKH));
                cmd.Parameters.Add(new SqlParameter("@tencty", eT_KhachHang.TenCty));
                cmd.Parameters.Add(new SqlParameter("@diachi", eT_KhachHang.DiaChi));
                cmd.Parameters.Add(new SqlParameter("@thanhpho", eT_KhachHang.ThanhPho));
                cmd.Parameters.Add(new SqlParameter("@dienthoai", eT_KhachHang.DienThoai));

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

        //Delete
        public bool XoaKhachHang(string maKH)
        {
            bool flag = false;
            try
            {
                //@ma, @tencty, @diachi, @thanhpho, @dienthoai
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaKH", conn);
                cmd.CommandText = "sp_XoaKH";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@ma", maKH));
                

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

        //Tim khach hang theo ma
        public DataTable TimKhachHangTheoMa(string maKH)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_TimKhachHangTheoMa", conn);
                cmd.CommandText = "sp_TimKhachHangTheoMa";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ma", maKH));

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                
            }
            catch(Exception ex)
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
