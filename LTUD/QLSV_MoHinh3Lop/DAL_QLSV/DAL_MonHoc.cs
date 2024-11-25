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
    public class DAL_MonHoc
    {
        SqlConnection conn = new SqlConnection("Data Source=MINHHIEU\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;TrustServerCertificate=True");

        public DataTable LayDSMonHoc()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayDSMonHoc", conn);
                cmd.CommandText = "sp_LayDSMonHoc";
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

        public bool ThemMonHoc(ET_MonHoc eT_MonHoc)
        {
            bool flag = false;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemMonHoc", conn);
                cmd.CommandText = "sp_ThemMonHoc";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ma", eT_MonHoc.MaMH));
                cmd.Parameters.Add(new SqlParameter("@ten", eT_MonHoc.TenMH));
                cmd.Parameters.Add(new SqlParameter("@sotiet", eT_MonHoc.SoTiet));

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

        public bool XoaMonHoc(string maMH)
        {
            bool flag = false;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaMonHoc", conn);
                cmd.CommandText = "sp_XoaMonHoc";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ma", maMH));
                
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

        public bool SuaMonHoc(ET_MonHoc eT_MonHoc)
        {
            bool flag = false;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaMonHoc", conn);
                cmd.CommandText = "sp_SuaMonHoc";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ma", eT_MonHoc.MaMH));
                cmd.Parameters.Add(new SqlParameter("@ten", eT_MonHoc.TenMH));
                cmd.Parameters.Add(new SqlParameter("@sotiet", eT_MonHoc.SoTiet));

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
