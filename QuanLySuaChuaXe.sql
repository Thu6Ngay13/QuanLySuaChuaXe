CREATE DATABASE QuanLySuaChuaXe
GO

USE QuanLySuaChuaXe
GO

CREATE TABLE Tho(
	ID_Tho char(5),
	HoTen_Tho nvarchar(30),
	GioiTinh_Tho bit,
	NgaySinh_Tho date,
	DiaChi_Tho nvarchar(10),
	Luong_Tho float,
	ID_NhomTho char(5),
	CONSTRAINT PK_Tho PRIMARY KEY (ID_Tho)
)
GO

CREATE TABLE NhomTho(
	ID_NhomTho char(5),
	Ten_NhomTho nvarchar(100),

	ID_TruongNhom char(5)
	CONSTRAINT PK_NhomTho PRIMARY KEY (ID_NhomTho)
)
GO

CREATE TABLE CongViec(
	ID_CongViec char(5),
	Ten_CongViec nvarchar(100),

	ID_NhomCongViec char(5),
	CONSTRAINT PK_CongViec PRIMARY KEY (ID_CongViec)
)
GO

CREATE TABLE NhomCongViec(
	ID_NhomCongViec char(5),
	Ten_NhomCongViec nvarchar(100),

	CONSTRAINT PK_NhomCongViec PRIMARY KEY (ID_NhomCongViec)
)
GO

CREATE TABLE KhachHang(
	ID_KhachHang char(5),
	HoTen_KhachHang nvarchar(30),
	GioiTinh_KhachHang bit,
	NgaySinh_KhachHang date,
	SoDienThoai_KhachHang char(10),

	CONSTRAINT PK_KhachHang PRIMARY KEY (ID_KhachHang)
)
GO

CREATE TABLE Xe(
	ID_Xe char(5),
	Loai_Xe nvarchar(30),
	Hang_Xe nvarchar(30),

	ID_KhachHang char(5)
	CONSTRAINT PK_Xe PRIMARY KEY (ID_Xe)
)
GO

CREATE TABLE HopDong(
	ID_HopDong char(5),
	Ten_HopDong nvarchar(100),
	NgayBatDau_HopDong date,
	NgayKetThuc_HopDong date,
	GiaTri_HopDong float,

	ID_Xe char(5)
	CONSTRAINT PK_HopDong PRIMARY KEY (ID_HopDong)
)
GO

CREATE TABLE PhieuThu(
	ID_PhieuThu char(5),
	HoTenNguoiThu_PhieuThu nvarchar(30),
	HoTenNguoiNop_PhieuThu nvarchar(30),
	NgayThu_PhieuThu date,
	SoTienThu_PhieuThu float,

	ID_HopDong char(5)
	CONSTRAINT PK_PhieuThu PRIMARY KEY (ID_PhieuThu)
)
GO

CREATE TABLE KhaNang(
	ID_Tho char(5),
	ID_CongViec char(5),

	CONSTRAINT PK_KhaNang PRIMARY KEY (ID_Tho, ID_CongViec)
)

CREATE TABLE ChiTietHopDong(
	ID_Tho char(5),
	ID_CongViec char(5),
	ID_HopDong char(5),

	CONSTRAINT PK_ChiTietHopDong PRIMARY KEY (ID_CongViec, ID_HopDong)
)

CREATE TABLE Users
(
	[User_name] varchar(50),
	[Password] varchar(50) not null,

	CONSTRAINT PK_User PRIMARY KEY ([User_name])
)

ALTER TABLE dbo.Tho
	ADD CONSTRAINT FK_Tho_NhomTho
		FOREIGN KEY (ID_NhomTho) 
		REFERENCES dbo.NhomTho(ID_NhomTho)
GO

ALTER TABLE dbo.CongViec
	ADD CONSTRAINT FK_CongViec_NhomCongViec
		FOREIGN KEY (ID_NhomCongViec)
		REFERENCES dbo.NhomCongViec(ID_NhomCongViec)
GO

ALTER TABLE dbo.Xe
	ADD CONSTRAINT FK_Xe_KhachHang
		FOREIGN KEY (ID_KhachHang) 
		REFERENCES dbo.KhachHang(ID_KhachHang)
Go

ALTER TABLE dbo.HopDong
	ADD CONSTRAINT FK_HopDong_Xe
		FOREIGN KEY (ID_Xe) 
		REFERENCES dbo.Xe(ID_Xe)
GO

ALTER TABLE dbo.PhieuThu
	ADD CONSTRAINT FK_PhieuThu_HopDong
		FOREIGN KEY (ID_HopDong) 
		REFERENCES dbo.HopDong(ID_HopDong)
GO

ALTER TABLE dbo.KhaNang
	ADD CONSTRAINT FK_KhaNang_Tho
		FOREIGN KEY (ID_Tho)
		REFERENCES dbo.Tho(ID_Tho)
GO

ALTER TABLE dbo.KhaNang
	ADD CONSTRAINT FK_KhaNang_CongViec
		FOREIGN KEY (ID_CongViec)
		REFERENCES dbo.CongViec(ID_CongViec)
GO

ALTER TABLE dbo.ChiTietHopDong
	ADD CONSTRAINT FK_ChiTietHopDong_Tho
		FOREIGN KEY (ID_Tho)
		REFERENCES dbo.Tho(ID_Tho)
GO

ALTER TABLE dbo.ChiTietHopDong
	ADD CONSTRAINT FK_ChiTietHopDong_CongViec
		FOREIGN KEY (ID_CongViec)
		REFERENCES dbo.CongViec(ID_CongViec)
GO

ALTER TABLE dbo.ChiTietHopDong
	ADD CONSTRAINT FK_ChiTietHopDong_HopDong
		FOREIGN KEY (ID_HopDong)
		REFERENCES dbo.HopDong(ID_HopDong)
GO

-- Thêm dữ liệu cho bảng NhomTho
INSERT INTO NhomTho (ID_NhomTho, Ten_NhomTho, ID_TruongNhom)
VALUES
	('NT001', N'Nhóm thợ A', 'T001'),
	('NT002', N'Nhóm thợ B', 'T003'),
	('NT003', N'Nhóm thợ C', 'T005')
GO 

-- Thêm dữ liệu cho bảng Tho
INSERT INTO Tho (ID_Tho, HoTen_Tho, GioiTinh_Tho, NgaySinh_Tho, DiaChi_Tho, Luong_Tho, ID_NhomTho)
VALUES
	('T001', N'Nguyễn Văn A', 1, '1990-01-01', N'Địa chỉ A', 1000000, 'NT001'),
	('T002', N'Trần Thị B', 0, '1995-05-10', N'Địa chỉ B', 1500000, 'NT001'),
	('T003', N'Lê Văn C', 1, '1988-12-15', N'Địa chỉ C', 1200000, 'NT002'),
	('T004', N'Phạm Thị D', 0, '1992-07-20', N'Địa chỉ D', 900000, 'NT002'),
	('T005', N'Hoàng Văn E', 1, '1998-03-25', N'Địa chỉ E', 1100000, 'NT003')
GO 

-- Thêm dữ liệu cho bảng NhomCongViec
INSERT INTO NhomCongViec (ID_NhomCongViec, Ten_NhomCongViec)
VALUES
	('NCV01', N'Nhóm công việc 1'),
	('NCV02', N'Nhóm công việc 2'),
	('NCV03', N'Nhóm công việc 3')
GO 

-- Thêm dữ liệu cho bảng CongViec
INSERT INTO CongViec (ID_CongViec, Ten_CongViec, ID_NhomCongViec)
VALUES
	('CV001', N'Công việc A', 'NCV01'),
	('CV002', N'Công việc B', 'NCV01'),
	('CV003', N'Công việc C', 'NCV02'),
	('CV004', N'Công việc D', 'NCV02'),
	('CV005', N'Công việc E', 'NCV03')
GO 

-- Thêm dữ liệu cho bảng KhachHang
INSERT INTO KhachHang (ID_KhachHang, HoTen_KhachHang, GioiTinh_KhachHang, NgaySinh_KhachHang, SoDienThoai_KhachHang)
VALUES
	('KH001', N'Nguyễn Thị X', 0, '1985-08-12', '0123456789'),
	('KH002', N'Trần Văn Y', 1, '1993-02-25', '0987654321'),
	('KH003', N'Lê Thị Z', 0, '1990-06-30', '0912345678'),
	('KH004', N'Phạm Văn K', 1, '1988-11-05', '0898765432'),
	('KH005', N'Huỳnh Thị T', 0, '1995-04-15', '0932145678')
GO 

-- Thêm dữ liệu cho bảng Xe
INSERT INTO Xe (ID_Xe, Loai_Xe, Hang_Xe, ID_KhachHang)
VALUES
	('X001', N'Xe A', N'Hãng A', 'KH001'),
	('X002', N'Xe B', N'Hãng B', 'KH002'),
	('X003', N'Xe C', N'Hãng C', 'KH003'),
	('X004', N'Xe D', N'Hãng D', 'KH004'),
	('X005', N'Xe E', N'Hãng E', 'KH005')
GO 

-- Thêm dữ liệu cho bảng HopDong
INSERT INTO HopDong (ID_HopDong, Ten_HopDong, NgayBatDau_HopDong, NgayKetThuc_HopDong, GiaTri_HopDong, ID_Xe)
VALUES
	('HD001', N'Hợp đồng A', '2022-01-01', '2022-12-31', 20000000, 'X001'),
	('HD002', N'Hợp đồng B', '2023-03-15', '2024-03-14', 15000000, 'X002'),
	('HD003', N'Hợp đồng C', '2023-05-01', '2024-04-30', 18000000, 'X003'),
	('HD004', N'Hợp đồng D', '2022-06-10', '2023-06-09', 22000000, 'X004'),
	('HD005', N'Hợp đồng E', '2023-02-20', '2024-02-19', 19000000, 'X005')
GO 

-- Thêm dữ liệu cho bảng PhieuThu
INSERT INTO PhieuThu (ID_PhieuThu, HoTenNguoiThu_PhieuThu, HoTenNguoiNop_PhieuThu, NgayThu_PhieuThu, SoTienThu_PhieuThu, ID_HopDong)
VALUES
	('PT001', N'Nguyễn Văn P', N'Nguyễn Thị X', '2023-01-05', 5000000, 'HD001'),
	('PT002', N'Trần Thị Q', N'Trần Văn Y', '2023-06-20', 3000000, 'HD002'),
	('PT003', N'Lê Văn R', N'Lê Thị Z', '2023-05-10', 4000000, 'HD003'),
	('PT004', N'Phạm Thị S', N'Phạm Văn K', '2022-07-01', 6000000, 'HD004'),
	('PT005', N'Huỳnh Thị U', N'Huỳnh Thị T', '2023-07-15', 3500000, 'HD005')
GO 

-- Thêm dữ liệu cho bảng KhaNang
INSERT INTO KhaNang (ID_Tho, ID_CongViec)
VALUES
	('T001', 'CV001'),
	('T001', 'CV002'),
	('T001', 'CV003'),

	('T002', 'CV001'),
	('T002', 'CV004'),
	('T002', 'CV003'),

	('T003', 'CV002'),
	('T003', 'CV005')
GO 

-- Thêm dữ liệu cho bảng ChiTietHopDong
INSERT INTO ChiTietHopDong (ID_Tho, ID_CongViec, ID_HopDong)
VALUES
	('T001', 'CV001', 'HD001'),
	('T003', 'CV002', 'HD001'),
	('T002', 'CV003', 'HD001'),

	('T002', 'CV004', 'HD002'),
	('T003', 'CV005', 'HD002')
GO 

INSERT INTO Users ([User_name], [Password]) 
VALUES 
	('admin1', '111'),
	('admin2', '222'),
	('admin3', '333');
GO