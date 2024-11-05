use QLBH
go

--Chen du lieu cho bảng Nhan Vien
insert into NhanVien values
('NV01', N'Phạm Minh', N'Hiếu', 'Nam', '2003-09-13', N'Đồng Tháp', '0352448746', 'C:\images\hinh1.png'),
('NV02', N'Trần Thị Trúc', N'Giang', 'Nu', '2004-05-12', N'Vĩnh Long', '0352448747', 'C:\images\hinh2.png'),
('NV03', N'Trần Thị Thu', N'Hiền', 'Nu', '2005-05-12', N'Kiên Giang', '0352448748', 'C:\images\hinh3.png'),
('NV04', N'Nguyễn Ngọc', N'Thảo', 'Nu', '2006-01-01', N'Đồng Tháp', '0352448749', 'C:\images\hinh4.png'),
('NV05', N'Nguyễn Tuấn', N'Kiệt', 'Nam', '2004-09-12', N'Đồng Tháp', '0352448750', 'C:\images\hinh5.png'),
('NV06', N'Đặng Thanh', N'Phong', 'Nam', '2005-05-12', N'Hồ Chí Minh', '0352448751', 'C:\images\hinh6.png'),
('NV07', N'Nguyễn Văn', N'Linh', 'Nam', '2005-06-12', N'Đồng Nai', '0352448752', 'C:\images\hinh7.png'),
('NV08', N'Đỗ Thành', N'Đạt', 'Nam', '2005-01-15', N'Bình Dương', '0352448753', 'C:\images\hinh8.png'),
('NV09', N'Trần Thị Kiều', N'Anh', 'Nu', '2005-05-13', N'Đồng Tháp', '0352448754', 'C:\images\hinh9.png'),
('NV10', N'Thái Thành', N'Thương', 'Nam', '2005-10-19', N'Đồng Tháp', '0352448755', 'C:\images\hinh10.png')
go

--Chen du lieu cho bảng Sản Phẩm
insert into SanPham values
('SP01', N'Cà phê đá', 'Ly', 15000, 'C:\images\sp1.png'),
('SP02', N'Tiger', 'Lon', 20000, 'C:\images\sp2.png'),
('SP03', N'Sting', 'Chai', 10000, 'C:\images\sp3.png'),
('SP04', N'C2', 'Chai', 10000, 'C:\images\sp4.png'),
('SP05', N'Mirinda', 'Lon', 12000, 'C:\images\sp5.png'),
('SP06', N'Ô long', 'Chai', 10000, 'C:\images\sp6.png'),
('SP07', N'7 up', 'Lon', 10000, 'C:\images\sp7.png')
go

--Chen du lieu co bang ThanhPho
insert into ThanhPho values
('HCM', N'Hồ Chí Minh'),
('ĐT', N'Đồng Tháp'),
('KG', N'Kiên Giang'),
('VL', N'Vĩnh Long'),
('ĐN', N'Đồng Nai'),
('BD', N'Bình Dương'),
('VT', N'Vũng Tàu')
go

--chen du lieu cho bang KhachHang
insert into KhachHang values
('KH01', 'CtyA', N'12 Lê Thị Hoa', N'HCM', '0352448755'),
('KH02', 'CtyB', N'15 Điện Biên Phủ', N'ĐT', '0352448756'),
('KH03', 'CtyC', N'13 Nam Kỳ Khởi Nghĩa', N'KG', '0352448757'),
('KH04', 'CtyD', N'53 Võ Văn Ngân', N'VL', '0352448758'),
('KH05', 'CtyE', N'89 Kha Vạn Cân', N'ĐN', '0352448759'),
('KH06', 'CtyF', N'45 Phạm Văn Đồng', N'BD', '0352448760'),
('KH07', 'CtyG', N'14 Trường Chinh', N'VT', '0352448761')
go

--Chen du lieu cho bang HoaDon
insert into HoaDon values
('HD01', 'KH01', 'NV02', '2023-09-12', '2023-09-19'),
('HD02', 'KH03', 'NV04', '2024-09-05', '2024-09-15'),
('HD03', 'KH04', 'NV06', '2024-04-15', '2024-04-20'),
('HD04', 'KH06', 'NV07', '2024-05-10', '2024-05-15'),
('HD05', 'KH07', 'NV05', '2024-06-15', '2024-06-21'),
('HD06', 'KH05', 'NV01', '2023-08-20', '2024-08-25')
go

--chen du lieu cho ban hoa don
insert into ChiTietHoaDon values
('HD01', 'SP02', 2),
('HD02', 'SP01', 3),
('HD03', 'SP04', 10),
('HD04', 'SP05', 7),
('HD05', 'SP02', 6),
('HD06', 'SP01', 12)
go


select * from NhanVien
select * from SanPham
select * from ThanhPho
select * from KhachHang
select * from HoaDon
select * from ChiTietHoaDon