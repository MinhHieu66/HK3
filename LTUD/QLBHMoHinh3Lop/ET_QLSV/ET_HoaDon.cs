using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLSV
{
    public class ET_HoaDon
    {
        private string _MaHD;
        private string _MaKH;
        private string _MaNV;
        private DateTime _NgayLapHD;
        private DateTime _NgayNhanHang;

        public ET_HoaDon(string maHD, string maKH, string maNV, DateTime ngayLapHD, DateTime ngayNhanHang)
        {
            _MaHD = maHD;
            _MaKH = maKH;
            _MaNV = maNV;
            _NgayLapHD = ngayLapHD;
            _NgayNhanHang = ngayNhanHang;
        }

        public string MaHD { get => _MaHD; set => _MaHD = value; }
        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public DateTime NgayLapHD { get => _NgayLapHD; set => _NgayLapHD = value; }
        public DateTime NgayNhanHang { get => _NgayNhanHang; set => _NgayNhanHang = value; }
    }
}
