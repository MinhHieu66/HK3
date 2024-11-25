using ET_QLSV;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET_QLSV;

namespace DAL
{
    public class DAL_ChiTietDonHang
    {
        SqlConnection conn = new SqlConnection("Data Source=MINHHIEU\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True;TrustServerCertificate=True");

        public DataTable LayDanhSachChiTietDonHang()
        {
            DataTable dt = new DataTable();
            try 
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayDSChiTietHD", conn);
                cmd.CommandText = "sp_LayDSChiTietHD";
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

        //Them 
        public bool ThemChiTietDonHang(ET_ChiTietHoaDon eT_ChiTietHoaDon)
        {
            bool flag = false;
            try
            {
                //@mahd, @masp, @sl
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemChiTietHD", conn);
                cmd.CommandText = "sp_ThemChiTietHD";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@mahd", eT_ChiTietHoaDon.MaHD));
                cmd.Parameters.Add(new SqlParameter("@masp", eT_ChiTietHoaDon.MaSP));
                cmd.Parameters.Add(new SqlParameter("@sl", eT_ChiTietHoaDon.SoLuong));

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

        //Xoa
        public bool XoaChiTietDonHang(string mahd)
        {
            bool flag = false;
            try
            {
                //@mahd, @masp, @sl
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaChiTietHD", conn);
                cmd.CommandText = "sp_XoaChiTietHD";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@mahd", mahd));
                

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
        public bool SuaChiTietDonHang(ET_ChiTietHoaDon eT_ChiTietHoaDon)
        {
            bool flag = false;
            try
            {
                //@mahd, @masp, @sl
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaChiTietHoaDon", conn);
                cmd.CommandText = "sp_SuaChiTietHoaDon";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@mahd", eT_ChiTietHoaDon.MaHD));
                cmd.Parameters.Add(new SqlParameter("@masp", eT_ChiTietHoaDon.MaSP));
                cmd.Parameters.Add(new SqlParameter("@sl", eT_ChiTietHoaDon.SoLuong));

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
