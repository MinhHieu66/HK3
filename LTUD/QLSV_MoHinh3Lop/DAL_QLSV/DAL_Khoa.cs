using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ET_QLSV;

namespace DAL_QLSV
{
    public class DAL_Khoa
    {
        SqlConnection conn = new SqlConnection("Data Source=MINHHIEU\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;TrustServerCertificate=True");

        public DataTable LayDSKhoa()
        {
            DataTable dt = new DataTable(); 
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayDSKhoa", conn);
                cmd.CommandText = "sp_LayDSKhoa";
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

        public bool SuaKhoa(ET_Khoa et)
        {
            bool flag = false;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaKhoa", conn);
                cmd.CommandText = "sp_SuaKhoa";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ma", et.Makhoa));
                cmd.Parameters.Add(new SqlParameter("@ten", et.Tenkhoa));

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

        public bool XoaKhoa(string maKhoa)
        {
            bool flag = false;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaKhoa", conn);
                cmd.CommandText = "sp_XoaKhoa";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ma", maKhoa));

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

        public bool ThemKhoa(ET_Khoa et)
        {
            bool flag = false;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemKhoa", conn);
                cmd.CommandText = "sp_ThemKhoa";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ma", et.Makhoa));
                cmd.Parameters.Add(new SqlParameter("@ten", et.Tenkhoa));

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

        public string TimTenKhoaTheoMa(string maKhoa)
        {
            string result = "";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayTenKhoaTheMa", conn);
                cmd.CommandText = "sp_LayTenKhoaTheMa";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@ma", maKhoa));
                result = (string)cmd.ExecuteScalar();
                //return result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public string TimMaKhoaTheoTen(string tenKhoa)
        {
            string result = "";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayMaKhoaTheTen", conn);
                cmd.CommandText = "sp_LayMaKhoaTheTen";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@ten", tenKhoa));
                result = (string)cmd.ExecuteScalar();
                //return result;
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
    }
}
