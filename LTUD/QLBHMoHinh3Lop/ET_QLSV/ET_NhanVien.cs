using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLSV
{
    public class ET_NhanVien
    {
        private string _MaNV;
        private string _Ho;
        private string _Ten;
        private string _GioiTinh;
        private DateTime _NgaySinh;
        private string _DiaChi;
        private string _DienThoai;
        private string _Hinh;

        public ET_NhanVien(string maNV, string ho, string ten, string gioiTinh, DateTime ngaySinh, string diaChi, string dienThoai, string hinh)
        {
            _MaNV = maNV;
            _Ho = ho;
            _Ten = ten;
            _GioiTinh = gioiTinh;
            _NgaySinh = ngaySinh;
            _DiaChi = diaChi;
            _DienThoai = dienThoai;
            _Hinh = hinh;
        }

        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string Ho { get => _Ho; set => _Ho = value; }
        public string Ten { get => _Ten; set => _Ten = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string DienThoai { get => _DienThoai; set => _DienThoai = value; }
        public string Hinh { get => _Hinh; set => _Hinh = value; }
    }
}
