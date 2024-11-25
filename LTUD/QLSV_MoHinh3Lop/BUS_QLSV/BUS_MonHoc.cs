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
    public class BUS_MonHoc
    {
        DAL_MonHoc dal_MonHoc = new DAL_MonHoc();
        public DataTable LayDSMonHoc()
        {
            return dal_MonHoc.LayDSMonHoc();
        }

        public bool ThemMonHoc(ET_MonHoc eT_MonHoc)
        {
            return dal_MonHoc.ThemMonHoc(eT_MonHoc);
        }

        public bool SuaMonHoc(ET_MonHoc eT_MonHoc)
        {
            return dal_MonHoc.SuaMonHoc(eT_MonHoc);
        }

        public bool XoaMonHoc(string maMonHoc)
        {
            return dal_MonHoc.XoaMonHoc(maMonHoc);
        }
    }
}
