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
    public class DAL_SanPham
    {
        SqlConnection conn = new SqlConnection("Data Source=MINHHIEU\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True;TrustServerCertificate=True");

        //Lay danh sach san pham
        public DataTable LayDSSanPham()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayDSSP", conn);
                cmd.CommandText = "sp_LayDSSP";
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
        public bool ThemSanPham(ET_SanPham et_SanPham)
        {
            bool flag = false;
            try
            {
                //@ma, @ten, @donvitinh, @dongia, @hinh
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemSP", conn);
                cmd.CommandText = "sp_ThemSP";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ma", et_SanPham.MaSP));
                cmd.Parameters.Add(new SqlParameter("@ten", et_SanPham.TenSP));
                cmd.Parameters.Add(new SqlParameter("@donvitinh", et_SanPham.DonViTinh));
                cmd.Parameters.Add(new SqlParameter("@dongia", et_SanPham.DonGia));
                cmd.Parameters.Add(new SqlParameter("@hinh", et_SanPham.Hinh));

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
        public bool XoaSanPham(string maSP)
        {
            bool flag = false;
            try
            {
                //@ma, @ten, @donvitinh, @dongia, @hinh
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaSP", conn);
                cmd.CommandText = "sp_XoaSP";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ma", maSP));

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
        public bool SuaSanPham(ET_SanPham et_SanPham)
        {
            bool flag = false;
            try
            {
                //@ma, @ten, @donvitinh, @dongia, @hinh
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaSP", conn);
                cmd.CommandText = "sp_SuaSP";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ma", et_SanPham.MaSP));
                cmd.Parameters.Add(new SqlParameter("@ten", et_SanPham.TenSP));
                cmd.Parameters.Add(new SqlParameter("@donvitinh", et_SanPham.DonViTinh));
                cmd.Parameters.Add(new SqlParameter("@dongia", et_SanPham.DonGia));
                cmd.Parameters.Add(new SqlParameter("@hinh", et_SanPham.Hinh));

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

        //Tim kiem san pham theo ten san pham
        public DataTable TimSanPhamTheoTenSanPham(string tenSP)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_TimSanPhamTheoTenSanPham", conn);
                cmd.CommandText = "sp_TimSanPhamTheoTenSanPham";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@ten", tenSP));

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
