using ET_QLSV;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dAL_KhachHang = new DAL_KhachHang();
        public DataTable LayDanhSachKhachHang()
        {
            return dAL_KhachHang.LayDanhSachKhachHang();
        }

        //Add
        public bool ThemKhachHang(ET_KhachHang eT_KhachHang)
        {
            return dAL_KhachHang.ThemKhachHang(eT_KhachHang);
        }

        //Update
        public bool SuaKhachHang(ET_KhachHang eT_KhachHang)
        {
            return dAL_KhachHang.SuaKhachHang(eT_KhachHang);
        }

        //Delete
        public bool XoaKhachHang(string maKH)
        {
            return dAL_KhachHang.XoaKhachHang(maKH);
        }

        public DataTable TimKhachHangTheoMa(string maKH)
        {
            return dAL_KhachHang.TimKhachHangTheoMa(maKH);
        }
    }
}
