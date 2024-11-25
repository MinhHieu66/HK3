using DAL_QLSV;
using ET_QLSV;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLSV
{
    public class BUS_SINHVIEN
    {
        DAL_SinhVien dal_SinhVien = new DAL_SinhVien();
        public DataTable LayDSSinhVien()
        {
            return dal_SinhVien.LayDSSinhVien();
        }

        public bool ThemSinhVien(ET_SinhVien et_SinhVien)
        {
            return dal_SinhVien.ThemSinhVien(et_SinhVien);
        }

        public bool XoaSinhVien(string maSV)
        {
            return dal_SinhVien.XoaSinhVien(maSV);
        }

        public bool SuaSinhVien(ET_SinhVien et_SinhVien)
        {
            return dal_SinhVien.SuaSinhVien(et_SinhVien);
        }

        public string LayTenSinhVienTheoMa(string maSV)
        {
            return dal_SinhVien.LayTenSinhVienTheoMa(maSV);
        }

        public string LayMaSinhVienTheoTen(string tenSSV)
        {
            return dal_SinhVien.LayMaSinhVienTheoTen(tenSSV);
        }

        public DataTable TimSinhVienTheoMa(string maSV)
        {
            return dal_SinhVien.TimSinhVienTheoMa(maSV);
        }

        public DataTable TimSinhVienTheoTen(string tenSV)
        {
            return dal_SinhVien.TimSinhVienTheoTen(tenSV);
        }
    }
}
