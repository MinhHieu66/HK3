using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLSV
{
    public class ET_SinhVien
    {
        private string _MaSV;
        private string _HoSV;
        private string _TenSV;
        private string _GioiTinh;
        private DateTime _NgaySinh;
        private string _NoiSinh;
        private string _DiaChi;
        private string _Quan;
        private string _MaKhoa;
        private int _HocBong;

        public ET_SinhVien(string maSV, string hoSV, string tenSV, string gioiTinh, DateTime ngaySinh, string noiSinh, string diaChi, string quan, string maKhoa, int hocBong)
        {
            _MaSV = maSV;
            _HoSV = hoSV;
            _TenSV = tenSV;
            _GioiTinh = gioiTinh;
            _NgaySinh = ngaySinh;
            _NoiSinh = noiSinh;
            _DiaChi = diaChi;
            _Quan = quan;
            _MaKhoa = maKhoa;
            _HocBong = hocBong;
        }

        public string MaSV { get => _MaSV; set => _MaSV = value; }
        public string HoSV { get => _HoSV; set => _HoSV = value; }
        public string TenSV { get => _TenSV; set => _TenSV = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string NoiSinh { get => _NoiSinh; set => _NoiSinh = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string Quan { get => _Quan; set => _Quan = value; }
        public string MaKhoa { get => _MaKhoa; set => _MaKhoa = value; }
        public int HocBong { get => _HocBong; set => _HocBong = value; }
    }
}
