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
    public class BUS_KetQua
    {
        DAL_KetQua dal_KetQua = new DAL_KetQua();
        public DataTable LayDSKetQua()
        {
            return dal_KetQua.LayDSKetQua();
        }

        public bool ThemKetQua(ET_KetQua et_KetQua)
        {
            return dal_KetQua.ThemKetQua(et_KetQua);
        }

        public bool SuaKetQua(ET_KetQua et_KetQua)
        {
            return dal_KetQua.SuaKetQua(et_KetQua);
        }

        public bool XoaKetQua(string maSV)
        {
            return dal_KetQua.XoaKetQua(maSV);
        }
    }
}
