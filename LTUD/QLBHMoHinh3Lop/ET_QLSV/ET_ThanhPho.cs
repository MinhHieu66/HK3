using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLSV
{
    public class ET_ThanhPho
    {
        private string _ThanhPho;
        private string _TenThanhPho;

        public ET_ThanhPho(string thanhPho, string tenThanhPho)
        {
            _ThanhPho = thanhPho;
            _TenThanhPho = tenThanhPho;
        }

        public string ThanhPho { get => _ThanhPho; set => _ThanhPho = value; }
        public string TenThanhPho { get => _TenThanhPho; set => _TenThanhPho = value; }
    }
}
