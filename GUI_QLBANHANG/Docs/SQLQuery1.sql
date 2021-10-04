﻿-- DROP DATABASE
CREATE DATABASE QuanLyBanHang
GO

USE QuanLyBanHang
GO

-- DROP TABLE NhanVien
CREATE TABLE NhanVien(
	ID INT IDENTITY(1,1) NOT NULL,
	MANV VARCHAR(20) NOT NULL,
	EMAIL VARCHAR(50) NOT NULL,
	TENNV NVARCHAR(50) NOT NULL,
	DIACHI NVARCHAR(100) NOT NULL,
	VAITRO TINYINT NOT NULL,
	TINHTRANG TINYINT NOT NULL,
	MATKHAU VARCHAR(100) NOT NULL,
	PRIMARY KEY (MANV)
)
GO

ALTER TABLE NHANVIEN ADD CONSTRAINT MATKHAU_DEFAULT DEFAULT('1292201552198220877194054219216496220885') FOR MATKHAU
GO

-- DROP TABLE HANG
CREATE TABLE HANG(
	MAHANG INT IDENTITY(1,1) PRIMARY KEY,
	TENHANG NVARCHAR(50) NOT NULL,
	SOLUONG INT NOT NULL,
	DONGIABAN FLOAT NOT NULL,
	DONGIANHAP FLOAT NOT NULL,
	GHICHU NVARCHAR(20) NOT NULL,
	HINHANH NVARCHAR(400) NOT NULL,
	MANV VARCHAR(20) NOT NULL,
)
GO


-- DROP TABLE KHACHHANG
CREATE TABLE KHACHHANG(
	DIENTHOAI VARCHAR(15)  PRIMARY KEY,
	TENKHACH NVARCHAR(50) NOT NULL, 
	DIACHI NVARCHAR(100) NOT NULL, 
	PHAI NVARCHAR(5) NOT NULL, 
	MANV VARCHAR(20) NOT NULL
)
GO

-- ADD FOREIGN KEY

ALTER TABLE KHACHHANG ADD FOREIGN KEY(MANV) 
REFERENCES NHANVIEN(MANV)
GO

ALTER TABLE HANG ADD FOREIGN KEY(MANV) 
REFERENCES NHANVIEN(MANV)
GO

-- DROP PROC DANGNHAP
CREATE PROCEDURE DANGNHAP @EMAIL VARCHAR(50), @MATKHAU VARCHAR(100)
AS 
BEGIN
	DECLARE @STATUS INT
	IF EXISTS(SELECT * FROM NHANVIEN 
	WHERE EMAIL = @EMAIL AND MATKHAU = @MATKHAU)
	BEGIN
		DECLARE @TINHTRANG INT
		SELECT @TINHTRANG = TINHTRANG FROM NHANVIEN 
		WHERE EMAIL = @EMAIL
		IF @TINHTRANG = 1
			SET @STATUS = 1
		ELSE 
			SET @STATUS = 0
	END
	ELSE 
		SET @STATUS = 0
	SELECT @STATUS
END
GO

SELECT * FROM NhanVien
EXEC INSERTDATAINTONHANVIEN 'tungdz0002@gmail.com',N'tungdz0002',N'quận 2',1,1
exec DANGNHAP 'tungdz0001@gmail.com', '1292201552198220877194054219216496220885'
GO
-- DROP PROC TAOMOIMATKHAU
CREATE PROC TAOMOIMATKHAU 
@EMAIL VARCHAR(50),
@MATKHAU VARCHAR(100)
AS
BEGIN
	UPDATE NHANVIEN SET MATKHAU = @MATKHAU
	WHERE EMAIL = @EMAIL
END
GO

-- DROP PROC QUENMATKHAU

CREATE PROC QUENMATKHAU @EMAIL VARCHAR(50)
AS
BEGIN
	DECLARE @STATUS INT
	IF EXISTS(SELECT MANV FROM NHANVIEN WHERE EMAIL = @EMAIL)
	BEGIN
		DECLARE @TINHTRANG INT
		SELECT @TINHTRANG = TINHTRANG FROM NHANVIEN 
		WHERE EMAIL = @EMAIL
		IF @TINHTRANG = 1
			SET @STATUS = 1
		ELSE 
			SET @STATUS = 0
	END
	ELSE 
		SET @STATUS = 0
	SELECT @STATUS
END
GO


-- DROP PROC LAYVAITRONHANVIEN
CREATE PROC LayVaiTroNhanVien @email varchar(50)
AS
BEGIN 
	select vaitro from nhanvien where email = @email
END
GO


-- DROP PROC DOIMK
CREATE PROC DOIMK 
@EMAIL VARCHAR(50),
@ODDPASS VARCHAR(100),
@NEWPASS VARCHAR(100)
AS 
BEGIN
	DECLARE @OP VARCHAR(100)
	SELECT @OP = MATKHAU FROM NHANVIEN WHERE EMAIL = @EMAIL
	IF @OP = @ODDPASS
	BEGIN 
		UPDATE NHANVIEN SET MATKHAU = @NEWPASS WHERE EMAIL = @EMAIL
		RETURN 1
	END
	ELSE
		RETURN -1
END
GO

-- DROP PROC DANHSACHNV
CREATE PROC DANHSACHNV
AS 
BEGIN 
	SELECT EMAIL, TENNV, DIACHI, VAITRO,
	TINHTRANG FROM NHANVIEN
END
GO

-- DROP PROC INSERTDATAINTONHANVIEN 
CREATE PROC INSERTDATAINTONHANVIEN 
@EMAIL VARCHAR(50),
@TENNV NVARCHAR(50),
@DIACHI NVARCHAR(100),
@VAITRO TINYINT,
@TINHTRANG TINYINT
AS 
BEGIN
	IF NOT EXISTS(SELECT EMAIL FROM NhanVien 
	WHERE EMAIL = @EMAIL)
	BEGIN
		DECLARE @MANV VARCHAR(20)
		DECLARE @ID INT;
		SELECT @ID = ISNULL(MAX(ID),0) + 1 FROM NHANVIEN
		SELECT @MANV = 'NV' + RIGHT('0000' + CAST(@ID AS VARCHAR(4)),4)
		INSERT INTO NHANVIEN(MANV, EMAIL, TENNV, DIACHI, VAITRO, TINHTRANG)
		VALUES (@MANV, @EMAIL,@TENNV,@DIACHI,@VAITRO,@TINHTRANG)
	END
END
GO
EXEC INSERTDATAINTONHANVIEN 'tungnh230802@gmail.com','tungnh230802',N'quận 12',1,1
GO

-- DROP PROC UPDATEDATAINTONHANVIEN
CREATE PROC UPDATEDATAINTONHANVIEN
@EMAIL VARCHAR(50),
@TENNV NVARCHAR(50),
@DIACHI NVARCHAR(100),
@VAITRO TINYINT,
@TINHTRANG TINYINT
AS
BEGIN
	UPDATE NHANVIEN SET
	TENNV = @TENNV,DIACHI = @DIACHI,VAITRO = @VAITRO,TINHTRANG = @TINHTRANG
	WHERE EMAIL = @EMAIL
END
GO

-- DROP PROC DELETEDATAFROMNHANVIEN
CREATE PROC DELETEDATAFROMNHANVIEN
@EMAIL VARCHAR(100)
AS
BEGIN
	UPDATE NhanVien SET TINHTRANG = 0
	WHERE EMAIL = @EMAIL
END
GO

-- DROP PROC SEARCHDATAFROMNHANVIEN
CREATE PROC SEARCHDATAFROMNHANVIEN
@TENNV NVARCHAR(100)
AS
BEGIN
	SET NOCOUNT ON
	SELECT EMAIL, TENNV, DIACHI, VAITRO, TINHTRANG 
	FROM NHANVIEN
	WHERE TENNV LIKE '%' + @TENNV + '%'
END
GO



-- DROP PROC DANHSACHKH
CREATE PROC DANHSACHKH
AS 
BEGIN 
	SELECT *
	FROM KHACHHANG
END
GO

-- DROP PROC INSERTDATAINTOKHACHHANG
CREATE PROC INSERTDATAINTOKHACHHANG 
@DIENTHOAI VARCHAR(15),
@TENKHACH NVARCHAR(50),
@DIACHI NVARCHAR(100),
@PHAI NVARCHAR(5),
@EMAIL VARCHAR(50)
AS 
BEGIN
	DECLARE @MANV VARCHAR(20)
	SELECT @MANV = MANV FROM NHANVIEN 
	WHERE EMAIL = @EMAIL
	INSERT INTO KHACHHANG(DIENTHOAI, TENKHACH, DIACHI, PHAI, MANV)
	VALUES (@DIENTHOAI, @TENKHACH,@DIACHI,@PHAI,@MANV)
END
GO

-- DROP PROC UPDATEDATAINTOKHACHHANG
CREATE PROC UPDATEDATAINTOKHACHHANG
@DIENTHOAI VARCHAR(15),
@TENKHACH NVARCHAR(50),
@DIACHI NVARCHAR(100),
@PHAI NVARCHAR(5)
AS
BEGIN
	UPDATE KHACHHANG SET
	TENKHACH = @TENKHACH,DIACHI = @DIACHI
	,PHAI = @PHAI
	WHERE DIENTHOAI = @DIENTHOAI
END
GO
select * from KHACHHANG
exec UPDATEDATAINTOKHACHHANG '0849690585','fsdfsd','sfsdf','Nam'

-- DROP PROC DELETEDATAFROMKHACHHANG
CREATE PROC DELETEDATAFROMKHACHHANG
@DIENTHOAI VARCHAR(15)
AS
BEGIN
	DELETE FROM KHACHHANG
	WHERE DIENTHOAI = @DIENTHOAI
END
GO

-- DROP PROC SEARCHDATAFROMKHACHHANG
CREATE PROC SEARCHDATAFROMKHACHHANG
@DIENTHOAI VARCHAR(15)
AS
BEGIN
	SET NOCOUNT ON
	SELECT *
	FROM KHACHHANG
	WHERE DIENTHOAI LIKE '%' + @DIENTHOAI + '%'
END
GO



-- DROP PROC DachSachHang
CREATE PROC DachSachHang
AS 
BEGIN 
	SELECT *
	FROM HANG
END
GO

-- DROP PROC InsertDataIntoHang
CREATE PROC InsertDataIntoHang 
@tenHang NVARCHAR(50),
@soLuong int,
@donGiaNhap float,
@donGiaBan float,
@hinhAnh NVARCHAR(400),
@GhiChu NVARCHAR(50),
@Email NVARCHAR(50)
AS 
BEGIN
	DECLARE @MANV VARCHAR(20)
	SELECT @MANV = MANV FROM NHANVIEN 
	WHERE EMAIL = @EMAIL
	INSERT INTO HANG(TENHANG, SOLUONG, DONGIABAN, DONGIANHAP, GHICHU, HINHANH,MANV)
	VALUES (@tenHang,@soLuong, @donGiaBan, @donGiaNhap, @GhiChu, @hinhAnh,@MANV )
END
GO
-- DROP PROC UpdateDataIntoHang
CREATE PROC UpdateDataIntoHang
@maHang int,
@tenHang NVARCHAR(50),
@soLuong int,
@donGiaNhap float,
@donGiaBan float,
@hinhAnh NVARCHAR(400),
@GhiChu NVARCHAR(50)
AS
BEGIN
	UPDATE HANG SET
	TENHANG = @tenHang, SOLUONG = @soLuong, DONGIANHAP = @donGiaNhap,
	donGiaBan = @donGiaBan, HINHANH = @hinhAnh, GHICHU = @GhiChu
	WHERE MAHANG = @maHang
END
GO

-- DROP PROC DeleteDataFromHang
CREATE PROC DeleteDataFromHang
@maHang int
AS
BEGIN
	DELETE FROM HANG
	WHERE MAHANG = @maHang
END
GO

-- DROP PROC SearchDataFromHang
CREATE PROC SearchDataFromHang
@tenHang nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON
	SELECT *
	FROM HANG
	WHERE TENHANG LIKE '%' + @tenHang + '%'
END
GO

-- DROP PROC ThongKeSP
CREATE PROC ThongKeSP
AS 
BEGIN 
	SELECT HANG.MANV,TENNV, COUNT(MAHANG)
	FROM HANG INNER JOIN NHANVIEN 
	ON HANG.MANV = NHANVIEN.MANV
	GROUP BY HANG.MANV, TENNV
END
GO

-- DROP PROC ThongKeTonKho
CREATE PROC ThongKeTonKho
AS 
BEGIN 
	SELECT TENHANG, SUM(SOLUONG)
	FROM HANG 
	GROUP BY TENHANG
END-- DROP DATABASE
CREATE DATABASE QUANLYBANHANG
GO