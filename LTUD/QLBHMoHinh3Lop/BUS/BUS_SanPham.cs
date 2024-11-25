using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ET_QLSV;

namespace BUS
{
    public class BUS_SanPham
    {
        DAL_SanPham dal_SanPham = new DAL_SanPham();
        //Lay danh sach san pham
        public DataTable LayDSSanPham()
        {
            return dal_SanPham.LayDSSanPham();
        }

        //Them
        public bool ThemSanPham(ET_SanPham et_SanPham)
        {
            return dal_SanPham.ThemSanPham(et_SanPham);
        }

        //Xoa
        public bool XoaSanPham(string maSP)
        {
            return dal_SanPham.XoaSanPham(maSP);
        }

        //Sua
        public bool SuaSanPham(ET_SanPham et_SanPham)
        {
            return dal_SanPham.SuaSanPham(et_SanPham);
        }

        public DataTable TimSanPhamTheoTenSanPham(string tenSP)
        {
            return dal_SanPham.TimSanPhamTheoTenSanPham(tenSP);
        }
    }
}
