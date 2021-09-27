-- CREATE DATABASE
CREATE DATABASE QUANLYBANHANG
GO

USE QUANLYBANHANG
GO

-- CREATE TABLE NHANVIEN
CREATE TABLE NHANVIEN(
	ID INT IDENTITY(1,1) NOT NULL,
	MANV NVARCHAR(20) PRIMARY KEY NOT NULL,
	EMAIL VARCHAR(50) NOT NULL,
	TENNV VARCHAR(50) NOT NULL,
	DIACHI VARCHAR(100) NOT NULL,
	VAITRO TINYINT NOT NULL,
	TINHTRANG TINYINT NOT NULL,
	MATKHAU NVARCHAR(50) NOT NULL
)
GO

-- CREATE TABLE HANG
CREATE TABLE HANG(
	MAHANG INT IDENTITY(1,1),
	TENHANG NVARCHAR(50) NOT NULL,
	SOLUONG INT NOT NULL,
	DONGIABAN FLOAT NOT NULL,
	DONGIANHAP FLOAT NOT NULL,
	GIACHU NVARCHAR(20) NOT NULL,
	MANV NVARCHAR(20) NOT NULL,
	PRIMARY KEY (MAHANG, TENHANG)
)
GO


-- CREATE TABLE KHACHHANG
CREATE TABLE KHACHHANG(
	DIENTHOAI VARCHAR(15)  PRIMARY KEY,
	TENKHACH NVARCHAR(50) NOT NULL, 
	DIACHI NVARCHAR(100) NOT NULL, 
	PHAI NVARCHAR(5) NOT NULL, 
	MANV NVARCHAR(20) NOT NULL
)
GO

-- ADD FOREIGN KEY

ALTER TABLE KHACHHANG ADD FOREIGN KEY(MANV) 
REFERENCES NHANVIEN(MANV)
GO

ALTER TABLE HANG ADD FOREIGN KEY(MANV) 
REFERENCES NHANVIEN(MANV)
GO


-- CREATE SP DANG NHAP

CREATE PROCEDURE DANGNHAP @EMAIL VARCHAR(50), @MATKHAU NVARCHAR(50)
AS 
BEGIN
	DECLARE @STATUS INT
	IF EXISTS(SELECT * FROM NHANVIEN 
	WHERE EMAIL = @EMAIL AND MATKHAU = @MATKHAU)
		SET @STATUS = 1
	ELSE 
		SET @STATUS = 0
	SELECT @STATUS
END
GO

-- CREATE SP DANHSACHSV
-- DROP PROC DANHSACHSV
CREATE PROC DANHSACHSV
AS 
BEGIN 
	IF OBJECT_ID(N'dbo.NHANVIEN', N'U') IS NOT NULL
		SELECT * FROM NHANVIEN
END
GO



-- CREATE SP DANHSACHKH
-- DROP PROC DANHSACHKH
CREATE PROC DANHSACHKH
AS 
BEGIN 
	IF OBJECT_ID(N'dbo.KHACHHANG', N'U') IS NOT NULL
		SELECT * FROM KHACHHANG
END
GO



-- CREATE PROC DANHSACHHANG
-- DROP PROC DANHSACHHANG
CREATE PROC DANHSACHHANG
AS 
BEGIN 
	IF OBJECT_ID(N'dbo.HANG', N'U') IS NOT NULL
		SELECT * FROM HANG
END
GO

-- CREATE PROC TAOMOIMATKHAU
-- DROP PROC TAOMOIMATKHAU
CREATE PROC TAOMOIMATKHAU 
@EMAIL NVARCHAR(50),
@MATKHAU NVARCHAR(200)
AS
BEGIN
	UPDATE NHANVIEN SET MATKHAU = @MATKHAU
	WHERE EMAIL = @EMAIL
END


-- CREATE PROC QUANMATKHAU
-- DROP PROC QUANMATKHAU

CREATE PROC QUANMATKHAU @EMAIL VARCHAR(50)
AS
BEGIN
	DECLARE @STATUS INT
	IF EXISTS(SELECT MANV FROM NHANVIEN WHERE EMAIL = @EMAIL)
		SET @STATUS = 1
	ELSE 
		SET @STATUS = 0
	SELECT @STATUS
END


-- CREATE PROC LAYVAITRONHANVIEN
CREATE PROC LayVaiTroNhanVien @email varchar(50)
AS
BEGIN 
	select vaitro from nhanvien where email = @email
END


-- CREATE PROC DOIMK
CREATE PROC DOIMK 
@EMAIL VARCHAR(50),
@ODDPASS VARCHAR(100),
@NEWPASS VARCHAR(100)
AS 
BEGIN
	DECLARE @OP VARCHAR(100)
	SELECT @OP = MATKHAU FROM NHANVIEN WHERE EMAIL = EMAIL
	IF @OP = @ODDPASS
	BEGIN 
		UPDATE NHANVIEN SET MATKHAU = @NEWPASS WHERE EMAIL = @EMAIL
		RETURN 1
	END
	ELSE
		RETURN -1
END