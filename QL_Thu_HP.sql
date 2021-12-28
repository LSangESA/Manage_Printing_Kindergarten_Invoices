CREATE DATABASE QL_Thu_HP
GO

USE QL_Thu_HP
GO

CREATE TABLE KHOI
(
	TEN_KHOI NVARCHAR(50) PRIMARY KEY
)
GO

CREATE TABLE LOP
(
	TEN_LOP NVARCHAR(50) PRIMARY KEY,
	TEN_KHOI NVARCHAR(50) REFERENCES dbo.KHOI(TEN_KHOI)
)
GO

CREATE TABLE KHOAN_THU
(
	TEN_KT NVARCHAR(100) PRIMARY KEY,
)
GO

CREATE TABLE NAM
(
	NAM INT PRIMARY KEY
)
GO

CREATE TABLE TRE_EM
(
	MA_TRE CHAR(5) PRIMARY KEY,
	TEN_TRE NVARCHAR(100) NOT NULL,
	TEN_LOP NVARCHAR(50) REFERENCES dbo.LOP(TEN_LOP)
)
GO

CREATE TABLE MUC_THU
(
	MA_MT INT IDENTITY(1,1) PRIMARY KEY,
	GIA_MUC_THU INT,
	NAM_THU INT REFERENCES dbo.NAM(NAM),
	TEN_KT NVARCHAR(100) REFERENCES dbo.KHOAN_THU(TEN_KT),
	TEN_KHOI NVARCHAR(50) REFERENCES dbo.KHOI(TEN_KHOI)
)
GO

CREATE TABLE PHIEU_THU
(
	SO_PT INT IDENTITY(1000,1) PRIMARY KEY,
	NGAY_LAP DATETIME CHECK(NGAY_LAP <= GETDATE()),
	TONG_TIEN INT,
	MA_TRE CHAR(5) REFERENCES dbo.TRE_EM(MA_TRE)
)
GO

/* Insert NAM*/

INSERT INTO dbo.NAM
        ( NAM )
VALUES  ( '2019'  -- NAM - int
          )

INSERT INTO dbo.NAM
        ( NAM )
VALUES  ( '2020'  -- NAM - int
          )

INSERT INTO dbo.NAM
        ( NAM )
VALUES  ( '2021'  -- NAM - int
          )

/* Insert KHOAN_THU*/

INSERT INTO dbo.KHOAN_THU
        ( TEN_KT )
VALUES  ( N'Ăn Uống'  -- TEN_KT - nvarchar(100)
          )

INSERT INTO dbo.KHOAN_THU
        ( TEN_KT )
VALUES  ( N'Vệ Sinh'  -- TEN_KT - nvarchar(100)
          )

INSERT INTO dbo.KHOAN_THU
        ( TEN_KT )
VALUES  ( N'Học Phí'  -- TEN_KT - nvarchar(100)
          )

/* Insert Khoi*/

INSERT INTO dbo.KHOI
        ( TEN_KHOI )
VALUES  ( N'Chồi'  -- TEN_KHOI - nvarchar(50)
          )

INSERT INTO dbo.KHOI
        ( TEN_KHOI )
VALUES  ( N'Lá'  -- TEN_KHOI - nvarchar(50)
          )

INSERT INTO dbo.KHOI
        ( TEN_KHOI )
VALUES  ( N'Mầm'  -- TEN_KHOI - nvarchar(50)
          )

/* Insert LOP*/

INSERT INTO dbo.LOP
        ( TEN_LOP, TEN_KHOI )
VALUES  ( N'Choi1', -- TEN_LOP - nvarchar(50)
          N'Chồi'  -- TEN_KHOI - nvarchar(50)
          )

INSERT INTO dbo.LOP
        ( TEN_LOP, TEN_KHOI )
VALUES  ( N'Choi2', -- TEN_LOP - nvarchar(50)
          N'Chồi'  -- TEN_KHOI - nvarchar(50)
          )

INSERT INTO dbo.LOP
        ( TEN_LOP, TEN_KHOI )
VALUES  ( N'La1', -- TEN_LOP - nvarchar(50)
          N'Lá'  -- TEN_KHOI - nvarchar(50)
          )

INSERT INTO dbo.LOP
        ( TEN_LOP, TEN_KHOI )
VALUES  ( N'La2', -- TEN_LOP - nvarchar(50)
          N'Lá'  -- TEN_KHOI - nvarchar(50)
          )

INSERT INTO dbo.LOP
        ( TEN_LOP, TEN_KHOI )
VALUES  ( N'La3', -- TEN_LOP - nvarchar(50)
          N'Lá'  -- TEN_KHOI - nvarchar(50)
          )

INSERT INTO dbo.LOP
        ( TEN_LOP, TEN_KHOI )
VALUES  ( N'La4', -- TEN_LOP - nvarchar(50)
          N'Lá'  -- TEN_KHOI - nvarchar(50)
          )

INSERT INTO dbo.LOP
        ( TEN_LOP, TEN_KHOI )
VALUES  ( N'Mam1', -- TEN_LOP - nvarchar(50)
          N'Mầm'  -- TEN_KHOI - nvarchar(50)
          )

INSERT INTO dbo.LOP
        ( TEN_LOP, TEN_KHOI )
VALUES  ( N'Mam2', -- TEN_LOP - nvarchar(50)
          N'Mầm'  -- TEN_KHOI - nvarchar(50)
          )

/* Insert TRE_EM được import từ file excel*/

/* SP */

CREATE PROC SP_AddMucThu
@Nam INT, @Khoi NVARCHAR(50), @KhoanThu NVARCHAR(100), @GiaThu INT
AS 
BEGIN
	INSERT INTO dbo.MUC_THU
	        ( GIA_MUC_THU ,
	          NAM_THU ,
	          TEN_KT ,
	          TEN_KHOI
	        )
	VALUES  ( @GiaThu , -- GIA_MUC_THU - int
	          @Nam , -- NAM_THU - int
	          @KhoanThu , -- TEN_KT - nvarchar(100)
	          @Khoi  -- TEN_KHOI - nvarchar(50)
	        )
END 
GO 

CREATE PROC SP_KiemTraKhoanThuTonTai
@Nam INT, @KhoanThu NVARCHAR(100), @Khoi NVARCHAR(50)
AS 
BEGIN
	SELECT COUNT(*) FROM dbo.MUC_THU WHERE NAM_THU = @Nam AND TEN_KT = @KhoanThu AND TEN_KHOI = @Khoi;
END
GO



