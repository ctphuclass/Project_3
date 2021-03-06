USE [QLBanHangCaFe]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 05/12/2017 1:32:59 CH ******/
DROP TABLE [dbo].[NhanVien]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 05/12/2017 1:32:59 CH ******/
DROP TABLE [dbo].[NhaCungCap]
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 05/12/2017 1:32:59 CH ******/
DROP TABLE [dbo].[DangNhap]
GO
/****** Object:  StoredProcedure [dbo].[usp_USER_GetUserListPermision]    Script Date: 05/12/2017 1:32:59 CH ******/
DROP PROCEDURE [dbo].[usp_USER_GetUserListPermision]
GO
/****** Object:  StoredProcedure [dbo].[usp_USER_CheckUser]    Script Date: 05/12/2017 1:32:59 CH ******/
DROP PROCEDURE [dbo].[usp_USER_CheckUser]
GO
/****** Object:  StoredProcedure [dbo].[usp_USER_CreateUser]    Script Date: 05/12/2017 1:32:59 CH ******/
DROP PROCEDURE [dbo].[usp_USER_CreateUser]
GO
/****** Object:  StoredProcedure [dbo].[proc_UpdateNV]    Script Date: 05/12/2017 1:32:59 CH ******/
DROP PROCEDURE [dbo].[proc_UpdateNV]
GO
/****** Object:  StoredProcedure [dbo].[proc_UpdateNCC]    Script Date: 05/12/2017 1:32:59 CH ******/
DROP PROCEDURE [dbo].[proc_UpdateNCC]
GO
/****** Object:  StoredProcedure [dbo].[proc_SearchNCC]    Script Date: 05/12/2017 1:32:59 CH ******/
DROP PROCEDURE [dbo].[proc_SearchNCC]
GO
/****** Object:  StoredProcedure [dbo].[proc_NewNCC]    Script Date: 05/12/2017 1:32:59 CH ******/
DROP PROCEDURE [dbo].[proc_NewNCC]
GO
/****** Object:  StoredProcedure [dbo].[proc_InsertNewNV]    Script Date: 05/12/2017 1:32:59 CH ******/
DROP PROCEDURE [dbo].[proc_InsertNewNV]
GO
/****** Object:  StoredProcedure [dbo].[proc_GetListNV]    Script Date: 05/12/2017 1:32:59 CH ******/
DROP PROCEDURE [dbo].[proc_GetListNV]
GO
/****** Object:  StoredProcedure [dbo].[proc_DeleteNV]    Script Date: 05/12/2017 1:32:59 CH ******/
DROP PROCEDURE [dbo].[proc_DeleteNV]
GO
/****** Object:  StoredProcedure [dbo].[proc_DeleteNCC]    Script Date: 05/12/2017 1:32:59 CH ******/
DROP PROCEDURE [dbo].[proc_DeleteNCC]
GO
/****** Object:  StoredProcedure [dbo].[proc_ChangePassword]    Script Date: 05/12/2017 1:32:59 CH ******/
DROP PROCEDURE [dbo].[proc_ChangePassword]
GO
/****** Object:  StoredProcedure [dbo].[ds_NCC_GetNccList]    Script Date: 05/12/2017 1:32:59 CH ******/
DROP PROCEDURE [dbo].[ds_NCC_GetNccList]
GO
USE [master]
GO
/****** Object:  Database [QLBanHangCaFe]    Script Date: 05/12/2017 1:32:59 CH ******/
DROP DATABASE [QLBanHangCaFe]
GO
/****** Object:  Database [QLBanHangCaFe]    Script Date: 05/12/2017 1:32:59 CH ******/
CREATE DATABASE [QLBanHangCaFe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLBanHangCaFe', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QLBanHangCaFe.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLBanHangCaFe_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QLBanHangCaFe_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLBanHangCaFe] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLBanHangCaFe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLBanHangCaFe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLBanHangCaFe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLBanHangCaFe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLBanHangCaFe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLBanHangCaFe] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLBanHangCaFe] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLBanHangCaFe] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QLBanHangCaFe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLBanHangCaFe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLBanHangCaFe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLBanHangCaFe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLBanHangCaFe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLBanHangCaFe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLBanHangCaFe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLBanHangCaFe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLBanHangCaFe] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLBanHangCaFe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLBanHangCaFe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLBanHangCaFe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLBanHangCaFe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLBanHangCaFe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLBanHangCaFe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLBanHangCaFe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLBanHangCaFe] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLBanHangCaFe] SET  MULTI_USER 
GO
ALTER DATABASE [QLBanHangCaFe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLBanHangCaFe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLBanHangCaFe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLBanHangCaFe] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QLBanHangCaFe]
GO
/****** Object:  StoredProcedure [dbo].[ds_NCC_GetNccList]    Script Date: 05/12/2017 1:32:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ds_NCC_GetNccList]
AS
BEGIN
	SELECT * FROM [NhaCungCap]
END

GO
/****** Object:  StoredProcedure [dbo].[proc_ChangePassword]    Script Date: 05/12/2017 1:32:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_ChangePassword]
@psUsername varchar(50),
@psPassword varchar(50),
@psChangePasword varchar(50),
@pResultCode int output,
@pResultMessage varchar(50) output
AS
BEGIN
	--Chuyen Password Ma Hoa
	DECLARE @lPasswordHash varchar(32)
	DECLARE @lChangePasswordHash varchar(32)
	SET @lPasswordHash = HASHBYTES('SHA2_256', @psPassword)
	SET @lChangePasswordHash = HASHBYTES('SHA2_256', @psChangePasword)
	--KT User, Pass
	IF Exists(Select ID from DangNhap where UserName = @psUsername and PassWord = @lPasswordHash)
	--Neu Ton Tai
	BEGIN
		--Doi MK
		Update DangNhap SET PassWord = @lChangePasswordHash WHERE UserName = @psUsername 
		SELECT @pResultCode = ID, @pResultMessage = 'CHANGEPASSWORDOK' from DangNhap where UserName = @psUsername and PassWord = @lChangePasswordHash
		RETURN
	END
	--Khong Ton Tai
	ELSE
	BEGIN
		SELECT @pResultCode = -1 , @pResultMessage = 'CHANGEPASSWORDFAILED' 
		RETURN
	END
END

GO
/****** Object:  StoredProcedure [dbo].[proc_DeleteNCC]    Script Date: 05/12/2017 1:32:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*Stored procedure Delete Nha Cung Cap*/
CREATE PROCEDURE [dbo].[proc_DeleteNCC] @MaNCC varchar(50), @TenNCC nvarchar(50), @DiaChi nvarchar(50), @SDT varchar(50)
AS
BEGIN
	DELETE FROM NhaCungCap WHERE MaNCC = @MaNCC
END

GO
/****** Object:  StoredProcedure [dbo].[proc_DeleteNV]    Script Date: 05/12/2017 1:32:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_DeleteNV]
@Ma_NV varchar(50),
@HoTen_NV	nvarchar(50),
@NgaySinh	date ,
@GioiTinh	nvarchar(10),
@QueQuan	nvarchar(50),
@DiaChi	nvarchar(50),
@Email	varchar(50),
@SoDienThoai varchar(50)
AS
	BEGIN
		DELETE FROM NhanVien WHERE Ma_NV = @Ma_NV
	END

GO
/****** Object:  StoredProcedure [dbo].[proc_GetListNV]    Script Date: 05/12/2017 1:32:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_GetListNV]
AS
BEGIN
	SELECT * FROM NhanVien
END

GO
/****** Object:  StoredProcedure [dbo].[proc_InsertNewNV]    Script Date: 05/12/2017 1:32:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_InsertNewNV]
@Ma_NV varchar(50),
@HoTen_NV	nvarchar(50),
@NgaySinh	dateTIME ,
@GioiTinh	nvarchar(10),
@QueQuan	nvarchar(50),
@DiaChi	nvarchar(50),
@Email	varchar(50),
@SoDienThoai	varchar(50)
AS
BEGIN
	Insert into NhanVien(Ma_NV,HoTen_NV,NgaySinh,GioiTinh,QueQuan,DiaChi,Email,SoDienThoai)
	Values (@Ma_NV,@HoTen_NV,@NgaySinh,@GioiTinh,@QueQuan,@DiaChi,@Email,@SoDienThoai)
END

GO
/****** Object:  StoredProcedure [dbo].[proc_NewNCC]    Script Date: 05/12/2017 1:32:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_NewNCC] @MaNCC varchar(50), @TenNCC nvarchar(50), @DiaChi nvarchar(50), @SDT varchar(50)
AS
BEGIN
	INSERT INTO NhaCungCap(MaNCC, TenNCC, DiaChi, SoDienThoai)
	VALUES (@MaNCC,@TenNCC,@DiaChi,@SDT)
END

GO
/****** Object:  StoredProcedure [dbo].[proc_SearchNCC]    Script Date: 05/12/2017 1:32:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_SearchNCC] @MaNCC varchar(50), @TenNCC nvarchar(50)
AS
BEGIN
	SELECT * FROM NhaCungCap
	Where MaNCC = @MaNCC or TenNCC = @TenNCC
END

GO
/****** Object:  StoredProcedure [dbo].[proc_UpdateNCC]    Script Date: 05/12/2017 1:32:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*Stored procedure Update Nha Cung Cap*/
CREATE PROCEDURE [dbo].[proc_UpdateNCC] @MaNCC varchar(50), @TenNCC nvarchar(50), @DiaChi nvarchar(50), @SDT varchar(50)
AS
BEGIN
	UPDATE NhaCungCap SET TenNCC=@TenNCC,DiaChi = @DiaChi,SoDienThoai=@SDT WHERE MaNCC=@MaNCC
END

GO
/****** Object:  StoredProcedure [dbo].[proc_UpdateNV]    Script Date: 05/12/2017 1:32:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_UpdateNV]
@Ma_NV varchar(50) ,
@HoTen_NV	nvarchar(50),
@NgaySinh	date ,
@GioiTinh	nvarchar(10),
@QueQuan	nvarchar(50),
@DiaChi	nvarchar(50),
@Email	varchar(50),
@SoDienThoai varchar(50)
AS
	BEGIN
		IF @Ma_NV NOT IN (SELECT Ma_NV from NhanVien)
			PRINT 'ABC' 
		ELSE
			UPDATE NhanVien 
			SET HoTen_NV = @HoTen_NV,NgaySinh = @NgaySinh,GioiTinh = @GioiTinh,
			QueQuan=@QueQuan, DiaChi = @DiaChi, Email = @Email,SoDienThoai = @SoDienThoai
			WHERE Ma_NV = @Ma_NV
	END

GO
/****** Object:  StoredProcedure [dbo].[usp_USER_CreateUser]    Script Date: 05/12/2017 1:32:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_USER_CreateUser]
	@psUsername varchar(50)
	,@psPassword varchar(255)
	,@pResultCode int output
	,@pResultMessage varchar(50) output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @lPasswordHash varchar(32)

	IF Exists(Select ID from DangNhap WHERE Username = @psUsername)
	BEGIN
		SELECT @pResultCode = -1, @pResultMessage = 'USEREXISTED'
		RETURN
	END

	SET @lPasswordHash = HASHBYTES('SHA2_256', @psPassword)

	INSERT INTO DangNhap(UserName, PassWord) Values(@psUsername, @lPasswordHash)
	
	SELECT @pResultCode = SCOPE_IDENTITY(), @pResultMessage = 'USERCREATEDOK'
	RETURN
END

GO
/****** Object:  StoredProcedure [dbo].[usp_USER_CheckUser]    Script Date: 05/12/2017 1:32:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_USER_CheckUser]
@psUsername varchar(50),
@psPassword varchar(50),
@pResultCode int output,
@pResultMessage nvarchar(50) output
AS
BEGIN
	DECLARE @lPasswordHash varchar(32)
	SET @lPasswordHash = HASHBYTES('SHA2_256', @psPassword)
	IF Not Exists(Select ID from DangNhap where UserName = @psUsername and PassWord = @lPasswordHash)
	BEGIN
		SELECT @pResultCode = -1, @pResultMessage = N'Đăng Nhập Thất Bại! Xin Vui Lòng Thử Lại'
		RETURN
	END
	ELSE
	BEGIN
		SELECT @pResultCode = ID , @pResultMessage = N'Đăng Nhập Thành Công'  from DangNhap where UserName = @psUsername and PassWord = @lPasswordHash
		RETURN
	END
END
GO
/****** Object:  StoredProcedure [dbo].[usp_USER_GetUserListPermision]    Script Date: 05/12/2017 1:32:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*Stored Procedure phân quyền*/
CREATE PROCEDURE [dbo].[usp_USER_GetUserListPermision]
@UserName varchar(50)
AS
BEGIN
	SELECT UserName,Quyen FROM DangNhap WHERE  UserName = @UserName 
END

GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 05/12/2017 1:32:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DangNhap](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ma_NV] [varchar](50) NULL,
	[UserName] [varchar](50) NULL,
	[PassWord] [varchar](50) NULL,
	[Quyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 05/12/2017 1:32:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [varchar](50) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDienThoai] [varchar](50) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 05/12/2017 1:32:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[Ma_NV] [varchar](50) NOT NULL,
	[HoTen_NV] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[QueQuan] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Email] [varchar](50) NULL,
	[SoDienThoai] [varchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[Ma_NV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[DangNhap] ON 

INSERT [dbo].[DangNhap] ([ID], [Ma_NV], [UserName], [PassWord], [Quyen]) VALUES (10, N'300', N'admin', N'ŒivåµA½é½Mîß±g©ÈsüK¸¨o*´H©', N'admin')
INSERT [dbo].[DangNhap] ([ID], [Ma_NV], [UserName], [PassWord], [Quyen]) VALUES (11, N'2', N'nhanvien1', N'°¦ç®7œÑåh4œˆçe}ñ­…÷
™Rx oƠ', N'nhanvien')
SET IDENTITY_INSERT [dbo].[DangNhap] OFF
INSERT [dbo].[NhanVien] ([Ma_NV], [HoTen_NV], [NgaySinh], [GioiTinh], [QueQuan], [DiaChi], [Email], [SoDienThoai]) VALUES (N'1', N'Trần Đức Sơn', CAST(0xCF210B00 AS Date), N'Nam', N'Thái Bình', N'254 Đường Bùi Văn Ngữ, Quận 12, Phường Hiệp Thành', N'tranducson1998tb@gmail.com', N'01672493107')
INSERT [dbo].[NhanVien] ([Ma_NV], [HoTen_NV], [NgaySinh], [GioiTinh], [QueQuan], [DiaChi], [Email], [SoDienThoai]) VALUES (N'2', N'Trần Văn Thanh', CAST(0x1F220B00 AS Date), N'Nam', N'Hà Nội', N'271 Phan Văn Trị ,Quận Gò Vấp ', N'abc@123.com', N'0934243332')
INSERT [dbo].[NhanVien] ([Ma_NV], [HoTen_NV], [NgaySinh], [GioiTinh], [QueQuan], [DiaChi], [Email], [SoDienThoai]) VALUES (N'3', N'Nguyễn Thành Đat', CAST(0x1F220B00 AS Date), N'Nam', N'TP Hồ Chí Minh', N'123 Nguyễn Ảnh Thủ, Quận 12', N'datgaghe@123.co', N'01267638120')
INSERT [dbo].[NhanVien] ([Ma_NV], [HoTen_NV], [NgaySinh], [GioiTinh], [QueQuan], [DiaChi], [Email], [SoDienThoai]) VALUES (N'4', N'Lê Xuân Hoài Thanh', CAST(0x21220B00 AS Date), N'Nam', N'TP Đồng Nai', N'456 Gần Trường Đại Học Quốc Gia Thành Phố HCM', N'lxht@gmail.com', N'09876543211')
USE [master]
GO
ALTER DATABASE [QLBanHangCaFe] SET  READ_WRITE 
GO
USE [QLBanHangCaFe]
GO

/****** Object:  StoredProcedure [dbo].[usp_USER_CreateUser]    Script Date: 12/5/2017 1:43:06 PM ******/
DROP PROCEDURE [dbo].[usp_USER_CreateUser]
GO

/****** Object:  StoredProcedure [dbo].[usp_USER_CreateUser]    Script Date: 12/5/2017 1:43:06 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_USER_CreateUser]
	@psUsername varchar(50)
	,@psPassword varchar(255)
	,@pResultCode int output
	,@pResultMessage varchar(50) output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @lPasswordHash varchar(32)

	IF Exists(Select ID from DangNhap WHERE Username = @psUsername)
	BEGIN
		SELECT @pResultCode = -1, @pResultMessage = 'USEREXISTED'
		RETURN
	END

	SET @lPasswordHash = HASHBYTES('SHA2_256', @psPassword)

	INSERT INTO DangNhap(UserName, PassWord) Values(@psUsername, @lPasswordHash)
	
	SELECT @pResultCode = SCOPE_IDENTITY(), @pResultMessage = 'USERCREATEDOK'
	RETURN
END


GO


USE [QLBanHangCaFe]
GO
/****** Object:  StoredProcedure [dbo].[proc_UpdateNV]    Script Date: 12/5/2017 1:38:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[proc_UpdateNV]
@Ma_NV varchar(50) ,
@HoTen_NV	nvarchar(50),
@NgaySinh	date ,
@GioiTinh	nvarchar(10),
@QueQuan	nvarchar(50),
@DiaChi	nvarchar(50),
@Email	varchar(50),
@SoDienThoai varchar(50)
,@pResultCode int output
,@pResultMessage varchar(50) output

AS
BEGIN
	IF NOT EXISTS(SELECT Ma_NV from NhanVien WHERE Ma_NV = @Ma_NV)
	BEGIN
		SELECT @pResultCode = -1, @pResultMessage = 'NOT_EXISTS_NV'
	END
	ELSE
	BEGIN
		UPDATE NhanVien 
		SET HoTen_NV = @HoTen_NV,NgaySinh = @NgaySinh,GioiTinh = @GioiTinh,
		QueQuan=@QueQuan, DiaChi = @DiaChi, Email = @Email,SoDienThoai = @SoDienThoai
		WHERE Ma_NV = @Ma_NV
		SELECT @pResultCode = 0, @pResultMessage = 'UPDATE_NV_OK'
	END
END

