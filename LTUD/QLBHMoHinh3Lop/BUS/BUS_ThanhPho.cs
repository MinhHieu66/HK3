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
    public class BUS_ThanhPho
    {
        DAL_ThanhPho dAL_ThanhPho = new DAL_ThanhPho();
        public DataTable LayDanhSachThanhPho()
        {
            return dAL_ThanhPho.LayDanhSachThanhPho();
        }

        //Add
        public bool ThemThanhPho(ET_ThanhPho eT_ThanhPho)
        {
            return dAL_ThanhPho.ThemThanhPho(eT_ThanhPho);
        }

        //Delete
        public bool XoaThanhPho(string maThanhPho)
        {
            return dAL_ThanhPho.XoaThanhPho(maThanhPho);
        }

        //Update
        public bool SuaThanhPho(ET_ThanhPho eT_ThanhPho)
        {
            return dAL_ThanhPho.SuaThanhPho(eT_ThanhPho);
        }

        public string LayTenThanhPhoTheoMa(string ma)
        {
            return dAL_ThanhPho.LayTenThanhPhoTheoMa(ma);
        }

        public string LayMaThanhPhoTheoTen(string ten)
        {
            return dAL_ThanhPho.LayMaThanhPhoTheoTen(ten);
        }
    }
}
