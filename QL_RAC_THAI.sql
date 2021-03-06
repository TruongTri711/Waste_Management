CREATE DATABASE QL_RAC_THAI
GO

USE QL_RAC_THAI
GO

-- tao bang thong tin quan huyen
CREATE TABLE ThongTinQH
(
	MaQH INT PRIMARY KEY IDENTITY,
	TenQH NVARCHAR(50),
	DienTich FLOAT,
	SoPhuongXa INT,
	DanSo FLOAT
)
GO

-- tao bang chi so rac
CREATE TABLE ChiSoRac
(
	ID INT PRIMARY KEY IDENTITY,
	Nam INT,
	RacSinhHoat INT,
	RacCongNghiep INT,
	RacYte INT,
	RacKhac INT,
	Tong INT,
	MaQH INT
	FOREIGN KEY(MaQH) REFERENCES dbo.ThongTinQH(MaQH)
)
GO

-- insert data THongTinQH
INSERT dbo.ThongTinQH VALUES  (N'Quận 1', 7.73,10 ,142.000)
INSERT dbo.ThongTinQH VALUES  (N'Quận 2', 49.74,11 ,180.000)
INSERT dbo.ThongTinQH VALUES  (N'Quận 3', 4.92,14 ,190.000)
INSERT dbo.ThongTinQH VALUES  (N'Quận 4', 4.18,15 ,175.000)
INSERT dbo.ThongTinQH VALUES  (N'Quận 5', 4.27,15 ,159.000)
INSERT dbo.ThongTinQH VALUES  (N'Quận 6', 7.19,14 ,233.000)
INSERT dbo.ThongTinQH VALUES  (N'Quận 7', 35.69,10 ,360.000)
INSERT dbo.ThongTinQH VALUES  (N'Quận 8', 19.18,18 ,424.000)
INSERT dbo.ThongTinQH VALUES  (N'Quận 9', 114,13 ,397.000)
INSERT dbo.ThongTinQH VALUES  (N'Quận 10', 5.72,15 ,234.000)
INSERT dbo.ThongTinQH VALUES  (N'Quận 11', 5.14,16 ,209.000)
INSERT dbo.ThongTinQH VALUES  (N'Quận 12', 52.78,11 ,620.000)
INSERT dbo.ThongTinQH VALUES  (N'Quận Bình Thạnh', 20.76,20 ,499.000)
INSERT dbo.ThongTinQH VALUES  (N'Quận Thủ Đức', 48,12 ,592.000)
INSERT dbo.ThongTinQH VALUES  (N'Quận Gò Vấp', 19.74,16 ,676.000)
INSERT dbo.ThongTinQH VALUES  (N'Quận Phú Nhuận', 4.88,15 ,163.000)
INSERT dbo.ThongTinQH VALUES  (N'Quận Tân Bình', 22.38,15 ,474.000)
INSERT dbo.ThongTinQH VALUES  (N'Quận Tân Phú', 16.06,11 ,485.000)
INSERT dbo.ThongTinQH VALUES  (N'Quận Bình Tân', 51.89,10 ,784.000)
INSERT dbo.ThongTinQH VALUES  (N'Huyện Nhà Bè', 100,7 ,206.000)
INSERT dbo.ThongTinQH VALUES  (N'Huyện Hóc Môn', 109,12 ,542.000)
INSERT dbo.ThongTinQH VALUES  (N'Huyện Bình Chánh', 253,16 ,705.000)
INSERT dbo.ThongTinQH VALUES  (N'Huyện Củ Chi', 435,21 ,462.000)
INSERT dbo.ThongTinQH VALUES  (N'Huyện Cần Giờ', 704,7 ,71.000)
GO

-- insert bang ChiSoRac năm 2019
INSERT dbo.ChiSoRac VALUES  ( 2019 ,  12 ,  5 ,  30 , 2, 49 , 1 ) -- 49.5
INSERT dbo.ChiSoRac VALUES  ( 2019 ,  2 ,  5 ,  3 , 40, 50 , 2 ) -- 50
INSERT dbo.ChiSoRac VALUES  ( 2019 ,  12 ,  50 ,  10 , 3, 75 , 3 ) -- 76.1
INSERT dbo.ChiSoRac VALUES  ( 2019 ,  2 ,  3 ,  7 , 9, 21 , 4 )
INSERT dbo.ChiSoRac VALUES  ( 2019 ,  10 ,  18 ,  2 , 1, 31 , 5 )
INSERT dbo.ChiSoRac VALUES  ( 2019 ,  5 ,  23 ,  10 , 4, 42 , 6 )
INSERT dbo.ChiSoRac VALUES  ( 2019 ,  38 ,  12 ,  20 , 12, 82 , 7 )
INSERT dbo.ChiSoRac VALUES  ( 2019 ,  10 ,  3 ,  47 , 10, 70 ,  8)
INSERT dbo.ChiSoRac VALUES  ( 2019 ,  2 ,  5 ,  8 , 2, 17 , 9 )
INSERT dbo.ChiSoRac VALUES  ( 2019 ,  45 ,  12 ,  8 , 2, 67 , 10 )
INSERT dbo.ChiSoRac VALUES  ( 2019 ,  9 ,  2 ,  40 , 1, 52 , 11 )
INSERT dbo.ChiSoRac VALUES  ( 2019 ,  3 ,  5 ,  2 , 1, 11 , 12 )
INSERT dbo.ChiSoRac VALUES  ( 2019 ,  22 ,  21 ,  2 , 5, 50 , 13 )
INSERT dbo.ChiSoRac VALUES  ( 2019 ,  10 ,  19 ,  5 , 8, 42 , 14 )
INSERT dbo.ChiSoRac VALUES  ( 2019 ,  9 ,  40 ,  17 , 1, 67 , 15 )
INSERT dbo.ChiSoRac VALUES  ( 2019 ,  22 ,  22 ,  2 , 3, 49 , 16 )
INSERT dbo.ChiSoRac VALUES  ( 2019 ,  5 ,  19 ,  50 , 19, 93 , 17 )
INSERT dbo.ChiSoRac VALUES  ( 2019 ,  5 ,  8 ,  1 , 2, 16 , 18 )
INSERT dbo.ChiSoRac VALUES  ( 2019 ,  6 ,  2 ,  3 , 2, 13 , 19 )
INSERT dbo.ChiSoRac VALUES  ( 2019 ,  19 ,  1 ,  3 , 1, 24 , 20 )
INSERT dbo.ChiSoRac VALUES  ( 2019 ,  7 ,  20 ,  13 , 5, 45 , 21 )
INSERT dbo.ChiSoRac VALUES  ( 2019 ,  8 ,  2 ,  1 , 2, 13 , 22 )
INSERT dbo.ChiSoRac VALUES  ( 2019 ,  40 ,  5 ,  15 , 2, 62 , 23 )
INSERT dbo.ChiSoRac VALUES  ( 2019 ,  4 ,  30 ,  6 , 1, 41 , 24 )
GO

-- insert bang ChiSoRac năm 2020
INSERT dbo.ChiSoRac VALUES  ( 2020 ,  30 ,  15 ,  10 , 2, 57 , 1 )
INSERT dbo.ChiSoRac VALUES  ( 2020 ,  10 ,  55 ,  3 , 3, 71 , 2 )
INSERT dbo.ChiSoRac VALUES  ( 2020 ,  3 ,  4 ,  5 , 6, 18 , 3 )
INSERT dbo.ChiSoRac VALUES  ( 2020 ,  2 ,  3 ,  7 , 9, 21 , 4 )
INSERT dbo.ChiSoRac VALUES  ( 2020 ,  9 ,  40 ,  8 , 1, 58 , 5 )
INSERT dbo.ChiSoRac VALUES  ( 2020 ,  30 ,  15 ,  2 , 1, 48 , 6 )
INSERT dbo.ChiSoRac VALUES  ( 2020 ,  10 ,  13 ,  5 , 7, 35 , 7 )
INSERT dbo.ChiSoRac VALUES  ( 2020 ,  20 ,  13 ,  5 , 3, 41 ,  8)
INSERT dbo.ChiSoRac VALUES  ( 2020 ,  35 ,  15 ,  8 , 2, 60 , 9 )
INSERT dbo.ChiSoRac VALUES  ( 2020 ,  45 ,  12 ,  8 , 2, 67 , 10 )
INSERT dbo.ChiSoRac VALUES  ( 2020 ,  9 ,  3 ,  2 , 1, 15 , 11 )
INSERT dbo.ChiSoRac VALUES  ( 2020 ,  3 ,  5 ,  2 , 1, 11 , 12 )
INSERT dbo.ChiSoRac VALUES  ( 2020 ,  10 ,  21 ,  2 , 5, 28 , 13 )
INSERT dbo.ChiSoRac VALUES  ( 2020 ,  10 ,  19 ,  5 , 8, 42 , 14 )
INSERT dbo.ChiSoRac VALUES  ( 2020 ,  40 ,  10 ,  3 , 1, 54 , 15 )
INSERT dbo.ChiSoRac VALUES  ( 2020 ,  22 ,  25 ,  2 , 3, 52 , 16 )
INSERT dbo.ChiSoRac VALUES  ( 2020 ,  5 ,  19 ,  50 , 19, 73 , 17 )
INSERT dbo.ChiSoRac VALUES  ( 2020 ,  9 ,  15 ,  10 , 2, 36 , 18 )
INSERT dbo.ChiSoRac VALUES  ( 2020 ,  16 ,  12 ,  3 , 4, 35 , 19 )
INSERT dbo.ChiSoRac VALUES  ( 2020 ,  3 ,  2 ,  5 , 7, 17 , 20 )
INSERT dbo.ChiSoRac VALUES  ( 2020 ,  7 ,  20 ,  13 , 5, 45 , 21 )
INSERT dbo.ChiSoRac VALUES  ( 2020 ,  48 ,  12 ,  1 , 2, 63 , 22 )
INSERT dbo.ChiSoRac VALUES  ( 2020 ,  40 ,  5 ,  15 , 2, 62 , 23 )
INSERT dbo.ChiSoRac VALUES  ( 2020 ,  40 ,  30 ,  6 , 1, 77 , 24 )
GO

-- tạo PROC tìm QH
CREATE PROC InfoQH @find NVARCHAR(50) AS
BEGIN
	SELECT * FROM dbo.ThongTinQH WHERE TenQH = @find
END
GO

-- tạo PROC thông tin QH
CREATE PROC getallQH  AS
BEGIN
	SELECT * FROM dbo.ThongTinQH
END
GO

--  tao PROC lay ra nam
CREATE PROC LayNam AS
BEGIN
	SELECT DISTINCT Nam FROM dbo.ChiSoRac
END
GO

--  tao PROC lay ra cac QH
CREATE PROC LayQH AS
BEGIN
	SELECT TenQH FROM dbo.ThongTinQH
END
GO

--  tao PROC lay ra cac chi tiet rac cua QH do
CREATE PROC LayChiTietRac @TenQH NVARCHAR(50),@Nam INT AS
BEGIN
	SELECT * FROM dbo.ChiSoRac csr,dbo.ThongTinQH info WHERE csr.MaQH = info.MaQH AND info.TenQH = @TenQH AND csr.Nam = @Nam
END
GO

--  tao PROC lay ra cac chi tiet rac cua QH do
CREATE PROC LayTongRac @TenQH NVARCHAR(50),@Nam INT AS
BEGIN
	SELECT csr.Tong FROM dbo.ChiSoRac csr,dbo.ThongTinQH info WHERE csr.MaQH = info.MaQH AND info.TenQH = @TenQH AND csr.Nam = @Nam
END
GO

--  tao PROC lay ra tong cac loai rac cua cac nam
CREATE PROC TongCacChiSo @Nam INT AS
BEGIN
	SELECT SUM(RacSinhHoat) AS RacSinhHoat,SUM(RacCongNghiep) AS RacCongNghiep,SUM(RacYte) AS RacYTe,SUM(RacKhac) AS RacKhac, Nam FROM dbo.ChiSoRac WHERE Nam = @Nam
	GROUP BY Nam
END
GO

