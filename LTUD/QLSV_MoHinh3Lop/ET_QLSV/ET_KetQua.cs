using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLSV
{
    public class ET_KetQua
    {
        private string _MaSV;
        private string _MaMH;
        private double _DiemThi;

        public ET_KetQua(string maSV, string maMH, double diemThi)
        {
            _MaSV = maSV;
            _MaMH = maMH;
            _DiemThi = diemThi;
        }

        public string MaSV { get => _MaSV; set => _MaSV = value; }
        public string MaMH { get => _MaMH; set => _MaMH = value; }
        public double DiemThi { get => _DiemThi; set => _DiemThi = value; }
    }
}
