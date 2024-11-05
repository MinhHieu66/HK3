use QLBH
go

--NhanVien
create proc sp_LayDSNV
as
  select * from NhanVien
--exec sp_LayDSNV
ago

create proc sp_ThemNV(@ma char(6), @ho nvarchar(30), @ten nvarchar(15), @gioitinh char(5), @ngaysinh date, @diachi nvarchar(50), @dienthoai char(10), @hinh char(50))
as 
  insert into NhanVien values (@ma, @ho, @ten, @gioitinh, @ngaysinh, @diachi, @dienthoai, @hinh)
--exec sp_ThemNV 'NV11', N'Nguyễn Thành', N'Duy', 'Nam', '2003-05-13', 'Đồng Tháp', '0352448713' , 'C;\images\hinh11.png'
go

create proc sp_SuaNV(@ma char(6), @diachi nvarchar(50), @dienthoai char(10), @hinh char(50))
as
   update NhanVien
   set DiaChi = @diachi, DienThoai = @dienthoai, Hinh = @hinh
   where MaNV = @ma
--exec sp_SuaNV 'NV11', 'Hồ Chí Minh', '0352448733', 'hinhmoi'
go

create proc sp_XoaNV(@ma char(6))
as
   delete NhanVien
   where MaNV = @ma
--exec sp_XoaNV 'NV11'
go

--ThanhPho
create proc sp_LayDSThanhPho
as
   select * from ThanhPho
--exec sp_LayDSThanhPho
go

create proc sp_ThemThanhPho(@ma char(6), @ten nvarchar(30))
as
   insert into ThanhPho values (@ma, @ten)
--exec sp_ThemThanhPho 'AG', 'An Giang'
go

create proc sp_SuaThanhPho(@ma char(6), @ten nvarchar(30))
as
  update ThanhPho
  set TenThanhPho = @ten
  where ThanhPho = @ma
--exec sp_SuaThanhPho 'AG', 'Minh Hieu'
go

create proc sp_XoaThanhPho(@ma char(6))
as
  delete ThanhPho where ThanhPho = @ma
--exec sp_XoaThanhPho 'AG'
go

--SanPham
create proc sp_LayDSSP
as
  select * from SanPham
--exec sp_LayDSSP
go

create proc sp_ThemSP(@ma char(6), @ten nvarchar(50), @donvitinh nvarchar(15), @dongia int, @hinh char(50))
as 
   insert into SanPham values(@ma, @ten, @donvitinh, @dongia, @hinh)
--exec sp_ThemSP 'SP08', 'Pepsi', 'Lon', 11000, 'pepsi'
go

create proc sp_SuaSP(@ma char(6), @ten nvarchar(50), @donvitinh nvarchar(15), @dongia int, @hinh char(50))
as
  update SanPham
  set Ten = @ten, DonViTinh = @donvitinh, DonGia = @dongia, Hinh = @hinh
  where MaSP = @ma
--exec sp_SuaSP 'SP08', 'Pepsi1', 'Chai', 12000, 'pepsi1'
go

create proc sp_XoaSP(@ma char(6))
as
  delete SanPham where MaSP = @ma
--exec sp_XoaSP 'SP08'
go

--KhachHang
create proc sp_LayDSKH
as
  select * from KhachHang
--exec sp_LayDSKH
go

create proc sp_ThemKH(@ma char(6), @tencty nvarchar(50), @diachi nvarchar(50), @thanhpho char(6), @dienthoai char(10))
as
   insert into KhachHang values (@ma, @tencty, @diachi, @thanhpho, @dienthoai)
--exec sp_ThemKH 'KH08', 'CtyH', N'15 Chương Dương', 'HCM', '0123456789'
go

create proc sp_SuaKH(@ma char(6), @tencty nvarchar(50), @diachi nvarchar(50), @thanhpho char(6), @dienthoai char(10))
as
   update KhachHang
   set TenCty = @tencty, DiaChi = @diachi, ThanhPho = @thanhpho, DienThoai = @dienthoai
   where MaKH = @ma
--exec sp_SuaKH 'KH08', 'CtyK', '13 Le Van Viet', 'KG', '1234567890' 
go

create proc sp_XoaKH(@ma char(6))
as
  delete KhachHang
  where MaKH = @Ma
--exec sp_XoaKH 'KH08'
go

--HoaDon
create proc sp_LayDSHD
as
  select * from HoaDon
--exec sp_LayDSHD
go

create proc sp_ThemHoaDon(@mahd char(6), @makh char(6), @manv char(6), @ngaylaphd date, @ngaynhanhang date)
as
   insert into HoaDon values (@mahd, @makh, @manv, @ngaylaphd, @ngaynhanhang)
 --exec sp_ThemHoaDon 'HD07', 'KH01', 'Nv03', '2024-9-10', '2024-09-15'
 go

create proc sp_SuaHoaDon(@mahd char(6), @makh char(6), @manv char(6), @ngaylaphd date, @ngaynhanhang date)
as
   update HoaDon
   set MaKH = @makh, MaNV = @manv, NgayLapHD = @ngaylaphd, NgayNhanHang = @ngaynhanhang
   where MaHD = @mahd
--exec sp_SuaHoaDon 'HD07', 'KH02', 'NV04', '2024-9-12', '2024-9-15'
go

create proc sp_XoaHoaDon(@ma char(6))
as
  delete HoaDon where MaHD = @ma
--exec sp_XoaHoaDon 'HD07'
go

-- ChiTietHoaDon
create proc sp_LayDSChiTietHD
as
  select * from ChiTietHoaDon
--exec sp_LayDSChiTietHD
go

create proc sp_ThemChiTietHD(@mahd char(6), @masp char(6), @sl int)
as
  insert into ChiTietHoaDon values(@mahd, @masp, @sl)
--exec sp_ThemChiTietHD 'HD06', 'SP03', 12
go

create proc sp_SuaChiTietHoaDon(@mahd char(6), @masp char(6), @sl int)
as
  update ChiTietHoaDon
  set SoLuong = @sl
  where MaHD = @mahd and MaSP = @masp
--exec sp_SuaChiTietHoaDon 'HD06', 'SP03', 5
go

create proc sp_XoaChiTietHD(@mahd char(6), @masp char(6))
as
  delete ChiTietHoaDon where MaHD = @mahd and MaSP = @masp
--exec sp_XoaChiTietHD 'HD06', 'SP03'
go

--FUNCTIONS
--NhanVien

--Lấy danh sách nhân viên
create function LayDSNV()
returns table as
return (select * from NhanVien)
--select  * from LayDSNV()
go

--Đếm số lượng danh sách nhân viên theo giới tính
create function DemNVTheoGioiTinh(@gioitinh char(6))
returns int as
begin
return (select count(*) from NhanVien where GioiTinh = @gioitinh);
end
--declare @res int;
--set @res = dbo.DemNVTheoGioiTinh('Nam');
--print @res;
go

--San pham
create function LayDSSP()
returns table as
return (select * from SanPham)
--select * from LayDSSP()
go

--ThanhPho
create function LayDSThanhPho()
returns table as
return (select * from ThanhPho)
--select * from LayDSThanhPho()
go

--KhachHang
create function LayDSKH()
returns table as
return (select * from KhachHang)
--select * from LayDSKH()
go

--HoaDon
create function LayDSHD()
returns table as
return (select * from HoaDon)
--select * from LayDSHD()
go

--ChiTietDonHang
create function LayDSChiTietDH()
returns table as
return (select * from ChiTietHoaDon)
--select * from LayDSChiTietDH()
go
