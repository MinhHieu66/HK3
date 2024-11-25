using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLSV
{
    public class ET_SanPham
    {
        private string _MaSP;
        private string _TenSP;
        private string _DonViTinh;
        private int _DonGia;
        private string _Hinh;

        public ET_SanPham(string maSP, string tenSP, string donViTinh, int donGia, string hinh)
        {
            _MaSP = maSP;
            _TenSP = tenSP;
            _DonViTinh = donViTinh;
            _DonGia = donGia;
            _Hinh = hinh;
        }

        public string MaSP { get => _MaSP; set => _MaSP = value; }
        public string TenSP { get => _TenSP; set => _TenSP = value; }
        public string DonViTinh { get => _DonViTinh; set => _DonViTinh = value; }
        public int DonGia { get => _DonGia; set => _DonGia = value; }
        public string Hinh { get => _Hinh; set => _Hinh = value; }
    }
}
