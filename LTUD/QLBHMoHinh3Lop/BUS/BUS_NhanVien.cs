using DAL;
using ET_QLSV;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
        //Lay danh sach san pham
        public DataTable LayDSNhanVien()
        {
            return dal_NhanVien.LayDSNhanVien();
        }

        //Them
        public bool ThemNhanVien(ET_NhanVien eT_NhanVien)
        {
            return dal_NhanVien.ThemNhanVien(eT_NhanVien);
        }

        //Xoa
        public bool XoaNhanVien(string maNV)
        {
            return dal_NhanVien.XoaNhanVien(maNV);
        }

        //Sua
        public bool SuaNhaVien(ET_NhanVien eT_NhanVien)
        {
            return dal_NhanVien.SuaNhanVien(eT_NhanVien);
        }
    }
}
