using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLSV
{
    public class ET_KhachHang
    {
        private string _MaKH;
        private string _TenCty;
        private string _DiaChi;
        private string _ThanhPho;
        private string _DienThoai;

        public ET_KhachHang(string maKH, string tenCty, string diaChi, string thanhPho, string dienThoai)
        {
            _MaKH = maKH;
            _TenCty = tenCty;
            _DiaChi = diaChi;
            _ThanhPho = thanhPho;
            _DienThoai = dienThoai;
        }

        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string TenCty { get => _TenCty; set => _TenCty = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string ThanhPho { get => _ThanhPho; set => _ThanhPho = value; }
        public string DienThoai { get => _DienThoai; set => _DienThoai = value; }
    }
}
