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
    public class DAL_ThanhPho
    {
        SqlConnection conn = new SqlConnection("Data Source=MINHHIEU\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True;TrustServerCertificate=True");

        //List
        public DataTable LayDanhSachThanhPho()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayDSThanhPho", conn);
                cmd.CommandText = "sp_LayDSThanhPho";
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
        public bool ThemThanhPho(ET_ThanhPho eT_ThanhPho)
        {
            bool flag = false;
            try
            {
                //@ma, @ten
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemThanhPho", conn);
                cmd.CommandText = "sp_ThemThanhPho";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@ma", eT_ThanhPho.ThanhPho));
                cmd.Parameters.Add(new SqlParameter("@ten", eT_ThanhPho.TenThanhPho));

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

        //Delete
        public bool XoaThanhPho(string maThanhPho)
        {
            bool flag = false;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaThanhPho", conn);
                cmd.CommandText = "sp_XoaThanhPho";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@ma", maThanhPho));
               
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

        //Update
        public bool SuaThanhPho(ET_ThanhPho eT_ThanhPho)
        {
            bool flag = false;
            try
            {
                //@ma, @ten
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaThanhPho", conn);
                cmd.CommandText = "sp_SuaThanhPho";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@ma", eT_ThanhPho.ThanhPho));
                cmd.Parameters.Add(new SqlParameter("@ten", eT_ThanhPho.TenThanhPho));

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

        //Lay ten thanh pho theo ma
        public string LayTenThanhPhoTheoMa(string ma)
        {
            string s = "";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayTenThanhPhoTheoMa", conn);
                cmd.CommandText = "sp_LayTenThanhPhoTheoMa";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@ma", ma));

                s = cmd.ExecuteScalar().ToString();
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                 conn.Close();
            }
            return s;
        }


        //Lay ma thanh pho theo ten
        public string LayMaThanhPhoTheoTen(string ten)
        {
            string s = "";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayMaThanhPhoTheoTen", conn);
                cmd.CommandText = "sp_LayMaThanhPhoTheoTen";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@ten", ten));

                //s = cmd.ExecuteScalar().ToString();
                object result = cmd.ExecuteScalar();
                s = result != null ? result.ToString() : string.Empty;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return s;
        }
    }
}
