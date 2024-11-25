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
    public class BUS_HoaDon
    {
        DAL_HoaDon dal_HoaDon = new DAL_HoaDon();
        public DataTable LayDanhSachHoaDon()
        {
            return dal_HoaDon.LayDanhSachHoaDon();
        }

        public bool ThemHoaDon(ET_HoaDon eT_HoaDon)
        {
            return dal_HoaDon.ThemHoaDon(eT_HoaDon);
        }

        public bool SuaHoaDon(ET_HoaDon eT_HoaDon)
        {
            return dal_HoaDon.SuaHoaDon(eT_HoaDon);
        }

        public bool XoaHoaDon(string mahd)
        {
            return dal_HoaDon.XoaHoaDon(mahd);
        }
    }
}
