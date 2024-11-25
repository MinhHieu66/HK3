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
    public class DAL_KetQua
    {
        SqlConnection conn = new SqlConnection("Data Source=MINHHIEU\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;TrustServerCertificate=True");

        public DataTable LayDSKetQua()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayDSKQ", conn);
                cmd.CommandText = "sp_LayDSKQ";
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

        public bool ThemKetQua(ET_KetQua eT_KetQua)
        {
            bool flag = true;
            try
            {
                //@masv, @mamh, @diem
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemKetQua", conn);
                cmd.CommandText = "sp_ThemKetQua";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@masv", eT_KetQua.MaSV));
                cmd.Parameters.Add(new SqlParameter("@mamh", eT_KetQua.MaMH));
                cmd.Parameters.Add(new SqlParameter("@diem", eT_KetQua.DiemThi));

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

        public bool XoaKetQua(string maSV)
        {
            bool flag = true;
            try
            {
                //@masv, @mamh, @diem
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaKetQua", conn);
                cmd.CommandText = "sp_XoaKetQua";
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

        public bool SuaKetQua(ET_KetQua eT_KetQua)
        {
            bool flag = true;
            try
            {
                //@masv, @mamh, @diem
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaKetQua", conn);
                cmd.CommandText = "sp_SuaKetQua";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@masv", eT_KetQua.MaSV));
                cmd.Parameters.Add(new SqlParameter("@mamh", eT_KetQua.MaMH));
                cmd.Parameters.Add(new SqlParameter("@diem", eT_KetQua.DiemThi));

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
