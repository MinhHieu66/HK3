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
    public class BUS_ChiTietHoaDon
    {

        DAL_ChiTietDonHang dAL_ChiTietDonHang = new DAL_ChiTietDonHang();
        public DataTable LayDanhSachChiTietDonHang()
        {
            return dAL_ChiTietDonHang.LayDanhSachChiTietDonHang();
        }

        //Them 
        public bool ThemChiTietDonHang(ET_ChiTietHoaDon eT_ChiTietHoaDon)
        {
            return dAL_ChiTietDonHang.ThemChiTietDonHang(eT_ChiTietHoaDon);
        }

        //Xoa
        public bool XoaChiTietDonHang(string mahd)
        {
            return dAL_ChiTietDonHang.XoaChiTietDonHang(mahd);
        }

        //Sua
        public bool SuaChiTietDonHang(ET_ChiTietHoaDon eT_ChiTietHoaDon)
        {
            return dAL_ChiTietDonHang.SuaChiTietDonHang(eT_ChiTietHoaDon);
        }
    }
}
