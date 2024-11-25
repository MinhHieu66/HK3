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
    public class DAL_HoaDon
    {
        SqlConnection conn = new SqlConnection("Data Source=MINHHIEU\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True;TrustServerCertificate=True");

        public DataTable LayDanhSachHoaDon()
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

        public bool ThemHoaDon(ET_HoaDon eT_HoaDon)
        {
            bool flag = false;
            try
            {
                //@mahd, @makh, @manv, @ngaylaphd, @ngaynhanhang
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemHoaDon", conn);
                cmd.CommandText = "sp_ThemHoaDon";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@mahd", eT_HoaDon.MaHD));
                cmd.Parameters.Add(new SqlParameter("@makh", eT_HoaDon.MaKH));
                cmd.Parameters.Add(new SqlParameter("@manv", eT_HoaDon.MaNV));
                cmd.Parameters.Add(new SqlParameter("@ngaylaphd", eT_HoaDon.NgayLapHD));
                cmd.Parameters.Add(new SqlParameter("@ngaynhanhang", eT_HoaDon.NgayNhanHang));
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

        public bool SuaHoaDon(ET_HoaDon eT_HoaDon)
        {
            bool flag = false;
            try
            {
                //@mahd, @makh, @manv, @ngaylaphd, @ngaynhanhang
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaHoaDon", conn);
                cmd.CommandText = "sp_SuaHoaDon";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@mahd", eT_HoaDon.MaHD));
                cmd.Parameters.Add(new SqlParameter("@makh", eT_HoaDon.MaKH));
                cmd.Parameters.Add(new SqlParameter("@manv", eT_HoaDon.MaNV));
                cmd.Parameters.Add(new SqlParameter("@ngaylaphd", eT_HoaDon.NgayLapHD));
                cmd.Parameters.Add(new SqlParameter("@ngaynhanhang", eT_HoaDon.NgayNhanHang));
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

        public bool XoaHoaDon(string mahd)
        {
            bool flag = false;
            try
            {
                //@mahd, @makh, @manv, @ngaylaphd, @ngaynhanhang
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaHoaDon", conn);
                cmd.CommandText = "sp_XoaHoaDon";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ma", mahd));
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
