using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL_QLSV;
using ET_QLSV;

namespace BUS_QLSV
{
    public class BUS_Khoa
    {
        DAL_Khoa dal_khoa = new DAL_Khoa();
        public DataTable LayDSKhoa()
        {
            return dal_khoa.LayDSKhoa();
        }

        public bool ThemKhoa(ET_Khoa et)
        {
            return dal_khoa.ThemKhoa(et);
        }

        public bool XoaKhoa(string maKhoa)
        {
            return dal_khoa.XoaKhoa(maKhoa);
        }

        public bool SuaKhoa(ET_Khoa et)
        {
            return dal_khoa.SuaKhoa(et);
        }

        public string LayTenKhoaTheoMa(string maKhoa)
        {
            return dal_khoa.TimTenKhoaTheoMa(maKhoa);
        }

        public string TimMaKhoaTheoTen(string tenKhoa)
        {
            return dal_khoa.TimMaKhoaTheoTen(tenKhoa);
        }
    }
}
