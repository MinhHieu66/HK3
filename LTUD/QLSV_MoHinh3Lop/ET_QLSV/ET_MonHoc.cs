using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLSV
{
    public class ET_MonHoc
    {
        private string _MaMH;
        private string _TenMH;
        private string _SoTiet;

        public string MaMH { get => _MaMH; set => _MaMH = value; }
        public string TenMH { get => _TenMH; set => _TenMH = value; }
        public string SoTiet { get => _SoTiet; set => _SoTiet = value; }
    }
}
