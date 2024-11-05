create database QLBH
go

use QLBH
go

create table NhanVien(
   MaNV char(6) primary key,
   Ho nvarchar(30) not null,
   Ten nvarchar(15) not null,
   GioiTinh char(5) check (GioiTinh in ('Nam', 'Nu')),
   NgaySinh date,
   DiaChi nvarchar(50),
   DienThoai char(10),
   Hinh char(50)
)
go

create table SanPham(
    MaSP char(6) primary key,
	Ten nvarchar(50) not null,
	DonViTinh nvarchar(15),
	DonGia int,
	Hinh char(50)
)
go 

create table ThanhPho(
    ThanhPho char(6) primary key,
	TenThanhPho nvarchar(30)
)
go

create table KhachHang(
    MaKH char(6) primary key,
	TenCty nvarchar(50) not null,
	DiaChi nvarchar(50),
	ThanhPho char(6),
	DienThoai char(10),
	constraint FK_KH_Tp foreign key (ThanhPho) references ThanhPho(ThanhPho)
)
go

create table HoaDon(
    MaHD char(6) primary key,
	MaKH char(6),
	MaNV char(6),
	NgayLapHD date,
	NgayNhanHang date,
	constraint FK_HD_KH foreign key (MaKH) references KhachHang(MaKH),
	constraint FK_HD_NV foreign key (MaNV) references NhanVien(MaNV)
)
go

create table ChiTietHoaDon(
    MaHD char(6) not null,
	MaSP char(6) not null,
    SoLuong int,
	constraint PK_ChiTietHoaDon primary key(MaHD, MaSP),
	constraint FK_CTDH_HD foreign key (MaHD) references HoaDon(MaHD),
	constraint FK_CTDH_SP foreign key (MaSP) references SanPham(MaSP)
)
go


