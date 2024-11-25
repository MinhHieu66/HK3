using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLSV
{
    public class ET_ChiTietHoaDon
    {
        private string _MaHD;
        private string _MaSP;
        private int _SoLuong;

        public ET_ChiTietHoaDon(string maHD, string maSP, int soLuong)
        {
            _MaHD = maHD;
            _MaSP = maSP;
            _SoLuong = soLuong;
        }

        public string MaHD { get => _MaHD; set => _MaHD = value; }
        public string MaSP { get => _MaSP; set => _MaSP = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
    }
}
