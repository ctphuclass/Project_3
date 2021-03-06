USE [QLBanHangCaFe]
GO
ALTER TABLE [dbo].[HoaDonNhapHang] DROP CONSTRAINT [FK_HoaDonNhapHang_NhaCungCap]
GO
ALTER TABLE [dbo].[HoaDonBanHang] DROP CONSTRAINT [FK_HoaDonBanHang_NhanVien]
GO
ALTER TABLE [dbo].[HoaDonBanHang] DROP CONSTRAINT [FK_HoaDonBanHang_Ban]
GO
ALTER TABLE [dbo].[DangNhap] DROP CONSTRAINT [FK_DangNhap_NhanVien]
GO
ALTER TABLE [dbo].[CTHD_Nhap] DROP CONSTRAINT [FK_CTHD_Nhap_NguyenLieu]
GO
ALTER TABLE [dbo].[CTHD_Nhap] DROP CONSTRAINT [FK_CTHD_Nhap_HoaDonNhapHang]
GO
ALTER TABLE [dbo].[CTHD_BanHang] DROP CONSTRAINT [FK_CTHD_BanHang_Menu]
GO
ALTER TABLE [dbo].[CTHD_BanHang] DROP CONSTRAINT [FK_CTHD_BanHang_HoaDonBanHang]
GO
ALTER TABLE [dbo].[CongThuc] DROP CONSTRAINT [FK_CongThuc_NguyenLieu]
GO
ALTER TABLE [dbo].[CongThuc] DROP CONSTRAINT [FK_CongThuc_Menu]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP TABLE [dbo].[NhanVien]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP TABLE [dbo].[NhaCungCap]
GO
/****** Object:  Table [dbo].[NguyenLieu]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP TABLE [dbo].[NguyenLieu]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP TABLE [dbo].[Menu]
GO
/****** Object:  Table [dbo].[HoaDonNhapHang]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP TABLE [dbo].[HoaDonNhapHang]
GO
/****** Object:  Table [dbo].[HoaDonBanHang]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP TABLE [dbo].[HoaDonBanHang]
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP TABLE [dbo].[DangNhap]
GO
/****** Object:  Table [dbo].[CTHD_Nhap]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP TABLE [dbo].[CTHD_Nhap]
GO
/****** Object:  Table [dbo].[CTHD_BanHang]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP TABLE [dbo].[CTHD_BanHang]
GO
/****** Object:  Table [dbo].[CongThuc]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP TABLE [dbo].[CongThuc]
GO
/****** Object:  Table [dbo].[Ban]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP TABLE [dbo].[Ban]
GO
/****** Object:  StoredProcedure [dbo].[usp_USER_GetUserListPermision]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[usp_USER_GetUserListPermision]
GO
/****** Object:  StoredProcedure [dbo].[usp_USER_CheckUser]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[usp_USER_CheckUser]
GO
/****** Object:  StoredProcedure [dbo].[usp_USER_CreateUser]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[usp_USER_CreateUser]
GO
/****** Object:  StoredProcedure [dbo].[proc_UpdateNV]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_UpdateNV]
GO
/****** Object:  StoredProcedure [dbo].[proc_UpdateNL]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_UpdateNL]
GO
/****** Object:  StoredProcedure [dbo].[proc_UpdateNCC]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_UpdateNCC]
GO
/****** Object:  StoredProcedure [dbo].[proc_UpdateMenu]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_UpdateMenu]
GO
/****** Object:  StoredProcedure [dbo].[proc_TongHDNhapHang]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_TongHDNhapHang]
GO
/****** Object:  StoredProcedure [dbo].[proc_TongDoanhThu]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_TongDoanhThu]
GO
/****** Object:  StoredProcedure [dbo].[proc_TonKho]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_TonKho]
GO
/****** Object:  StoredProcedure [dbo].[proc_TinhTongHDNhapHang]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_TinhTongHDNhapHang]
GO
/****** Object:  StoredProcedure [dbo].[proc_ShowHDNhapHang]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_ShowHDNhapHang]
GO
/****** Object:  StoredProcedure [dbo].[proc_SearchNV]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_SearchNV]
GO
/****** Object:  StoredProcedure [dbo].[proc_SearchNL]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_SearchNL]
GO
/****** Object:  StoredProcedure [dbo].[proc_SearchNCC]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_SearchNCC]
GO
/****** Object:  StoredProcedure [dbo].[proc_SearchMenu]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_SearchMenu]
GO
/****** Object:  StoredProcedure [dbo].[proc_SearchHDNhapHang]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_SearchHDNhapHang]
GO
/****** Object:  StoredProcedure [dbo].[proc_SearchHDBH]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_SearchHDBH]
GO
/****** Object:  StoredProcedure [dbo].[proc_SearchCongThuc]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_SearchCongThuc]
GO
/****** Object:  StoredProcedure [dbo].[proc_NewNL]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_NewNL]
GO
/****** Object:  StoredProcedure [dbo].[proc_NewNCC]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_NewNCC]
GO
/****** Object:  StoredProcedure [dbo].[proc_NewMenu]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_NewMenu]
GO
/****** Object:  StoredProcedure [dbo].[proc_LoadTonKho]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_LoadTonKho]
GO
/****** Object:  StoredProcedure [dbo].[proc_LoadCongThuc]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_LoadCongThuc]
GO
/****** Object:  StoredProcedure [dbo].[proc_InsertNewNV]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_InsertNewNV]
GO
/****** Object:  StoredProcedure [dbo].[proc_GetListNV]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_GetListNV]
GO
/****** Object:  StoredProcedure [dbo].[proc_GetListNL]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_GetListNL]
GO
/****** Object:  StoredProcedure [dbo].[proc_GetListMenu]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_GetListMenu]
GO
/****** Object:  StoredProcedure [dbo].[proc_GetListHDNhapHang]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_GetListHDNhapHang]
GO
/****** Object:  StoredProcedure [dbo].[proc_GetListHDBH]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_GetListHDBH]
GO
/****** Object:  StoredProcedure [dbo].[proc_DoanhThu]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_DoanhThu]
GO
/****** Object:  StoredProcedure [dbo].[proc_DeleteNV]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_DeleteNV]
GO
/****** Object:  StoredProcedure [dbo].[proc_DeleteNL]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_DeleteNL]
GO
/****** Object:  StoredProcedure [dbo].[proc_DeleteNCC]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_DeleteNCC]
GO
/****** Object:  StoredProcedure [dbo].[proc_DeleteMenu]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_DeleteMenu]
GO
/****** Object:  StoredProcedure [dbo].[proc_ChangePassword]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_ChangePassword]
GO
/****** Object:  StoredProcedure [dbo].[proc_CTHD3]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_CTHD3]
GO
/****** Object:  StoredProcedure [dbo].[proc_CTHD2]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_CTHD2]
GO
/****** Object:  StoredProcedure [dbo].[proc_CTHD]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_CTHD]
GO
/****** Object:  StoredProcedure [dbo].[proc_CTCT]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[proc_CTCT]
GO
/****** Object:  StoredProcedure [dbo].[ds_NCC_GetNccList]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP PROCEDURE [dbo].[ds_NCC_GetNccList]
GO
USE [master]
GO
/****** Object:  Database [QLBanHangCaFe]    Script Date: 19/12/2017 11:29:30 SA ******/
DROP DATABASE [QLBanHangCaFe]
GO
/****** Object:  Database [QLBanHangCaFe]    Script Date: 19/12/2017 11:29:30 SA ******/
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
/****** Object:  StoredProcedure [dbo].[ds_NCC_GetNccList]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------------------------------------------------------------------------------------------------------------------------------
/*Các Stored Procedure dành cho Quản Lý Nhà Cung Cấp*/
--------------------------------------------------------------------------------------------------------------------------------------
/*Stored procedure load danh sach Nha Cung Cap*/
CREATE PROCEDURE [dbo].[ds_NCC_GetNccList]
AS
BEGIN
	SELECT * FROM [NhaCungCap]
END

GO
/****** Object:  StoredProcedure [dbo].[proc_CTCT]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_CTCT]
@MaMon varchar(50)
AS
BEGIN
	SELECT NL.MaNL,NL.TenNL,CT.MaMon,CT.HamLuong,CT.DVT 
	FROM CongThuc CT JOIN NguyenLieu NL ON CT.MaNL = NL.MaNL
	WHERE CT.MaMon = @MaMon
	GROUP BY NL.MaNL,NL.TenNL,CT.MaMon,CT.HamLuong,CT.DVT
END

GO
/****** Object:  StoredProcedure [dbo].[proc_CTHD]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_CTHD]
AS
BEGIN
	SELECT HD.MaHoaDon,B.MaBan,B.TenBan,HD.Ma_NV,HD.NgayLap
	From Ban  B join HoaDonBanHang HD on B.MaBan = HD.MaBan
	group by HD.MaHoaDon,B.MaBan,B.TenBan,HD.Ma_NV,HD.NgayLap
END

GO
/****** Object:  StoredProcedure [dbo].[proc_CTHD2]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_CTHD2]
@MaHD varchar(50)
AS
BEGIN
	SELECT Menu.TenMon,CTHD.SoLuong,Menu.DonGia,CTHD.SoLuong*Menu.DonGia AS 'ThanhTien'
	FROM CTHD_BanHang CTHD  JOIN HoaDonBanHang HD ON CTHD.MaHoaDon = HD.MaHoaDon
							JOIN Menu ON Menu.MaMon = CTHD.MaMon
							JOIN Ban B ON HD.MaBan = B.MaBan
							JOIN NhanVien NV ON HD.Ma_NV = NV.Ma_NV
	WHERE HD.MaHoaDon = @MaHD
END

GO
/****** Object:  StoredProcedure [dbo].[proc_CTHD3]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_CTHD3]
@MaHD varchar(50)
AS
BEGIN
	SELECT CTHD.MaHoaDon,SUM(CTHD.SoLuong*Menu.DonGia) AS 'TongTien'
	FROM CTHD_BanHang CTHD  JOIN Menu ON CTHD.MaMon = Menu.MaMon
	WHERE CTHD.MaHoaDon = @MaHD
	GROUP BY CTHD.MaHoaDon
END

GO
/****** Object:  StoredProcedure [dbo].[proc_ChangePassword]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------------------------------------------------------------------------------------------------------------------------------
/*Stored Procedure dành cho Login và Phân Quyền*/
--------------------------------------------------------------------------------------------------------------------------------------
/*Stored procedure [usp_USER_ChangePassword] dùng để thay đổi Password cho từng User*/
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
/****** Object:  StoredProcedure [dbo].[proc_DeleteMenu]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_DeleteMenu]
@MaMon	varchar(50),
@TenMon	nvarchar(50),
@Loai	nvarchar(50),
@DonGia	int,
@DVT	nvarchar(50),
@pResultCode_Menu varchar(50) output,
@pResultMessage_Menu nvarchar(100) output
AS
BEGIN
	IF NOT EXISTS(SELECT MaMon from Menu WHERE MaMon = @MaMon)
	BEGIN
		SELECT @pResultCode_Menu = '-1', @pResultMessage_Menu = N'Không tồn tại Mã Món!'
	END
	ELSE
	BEGIN
		DELETE FROM Menu WHERE MaMon = @MaMon
		SELECT @pResultCode_Menu = '1', @pResultMessage_Menu = N'Xóa thành công!'
	END
END

GO
/****** Object:  StoredProcedure [dbo].[proc_DeleteNCC]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_DeleteNCC] 
@MaNCC varchar(50), 
@TenNCC nvarchar(50), 
@DiaChi nvarchar(50), 
@SDT varchar(50),
@pResultCode_NCC varchar(50) output,
@pResultMessage_NCC nvarchar(100) output
AS
	IF NOT EXISTS(SELECT MaNCC FROM NhaCungCap WHERE MaNCC=@MaNCC)
	BEGIN
		SELECT @pResultCode_NCC = '-1', @pResultMessage_NCC = N'Không tồn tại Mã Nhà Cung Cấp!'
	END
	ELSE
	BEGIN
		DELETE FROM NhaCungCap WHERE MaNCC = @MaNCC
		SELECT @pResultCode_NCC = '1', @pResultMessage_NCC = N'Xóa thành công!'
	END

GO
/****** Object:  StoredProcedure [dbo].[proc_DeleteNL]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_DeleteNL]
@MaNL	varchar(50),
@TenNL	nvarchar(50),
@SoLuongNhap int,
@DVT	nvarchar(50),
@pResultCode_NL int output,
@pResultMessage_NL nvarchar(100) output
AS
BEGIN
	IF NOT EXISTS(SELECT MaNL from NguyenLieu WHERE MaNL = @MaNL)
	BEGIN
		SELECT @pResultCode_NL = -1, @pResultMessage_NL = N'Không tồn tại Mã Nguyên Liệu!'
	END
	ELSE
	BEGIN
		DELETE FROM NguyenLieu WHERE MaNL = @MaNL
		SELECT @pResultCode_NL = 1, @pResultMessage_NL = N'Xóa thành công!'
	END
END

GO
/****** Object:  StoredProcedure [dbo].[proc_DeleteNV]    Script Date: 19/12/2017 11:29:31 SA ******/
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
@SoDienThoai varchar(50),
@pResultCode_NV varchar(50) output,
@pResultMessage_NV nvarchar(100) output
AS
BEGIN
	IF NOT EXISTS(SELECT Ma_NV from NhanVien WHERE Ma_NV = @Ma_NV)
	BEGIN
		SELECT @pResultCode_NV = '-1', @pResultMessage_NV = N'Không tồn tại Mã Nhân Viên!'
	END
	ELSE
	BEGIN
		DELETE FROM NhanVien WHERE Ma_NV = @Ma_NV
		SELECT @pResultCode_NV = '1', @pResultMessage_NV = N'Xóa thành công!'
	END
END

GO
/****** Object:  StoredProcedure [dbo].[proc_DoanhThu]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_DoanhThu]
@NgayDau datetime,
@NgayCuoi datetime
AS
BEGIN 
	SELECT A.MaHoaDon,HD.MaBan,SUM(A.TongTien) AS 'TongTien'
	FROM HoaDonBanHang HD JOIN  (	
								SELECT CTHD.MaHoaDon,SUM(CTHD.SoLuong*Menu.DonGia) AS 'TongTien'
								FROM CTHD_BanHang CTHD  JOIN Menu ON CTHD.MaMon = Menu.MaMon
								GROUP BY CTHD.MaHoaDon
								) AS A ON HD.MaHoaDon = A.MaHoaDon
	WHERE (HD.NgayLap>= @NgayDau) AND (HD.NgayLap<=@NgayCuoi)
	GROUP BY A.MaHoaDon,HD.MaBan
END
GO
/****** Object:  StoredProcedure [dbo].[proc_GetListHDBH]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_GetListHDBH]
AS
BEGIN
	SELECT * FROM HoaDonBanHang
END

GO
/****** Object:  StoredProcedure [dbo].[proc_GetListHDNhapHang]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_GetListHDNhapHang]
AS
BEGIN
	SELECT * FROM HoaDonNhapHang
END
GO
/****** Object:  StoredProcedure [dbo].[proc_GetListMenu]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_GetListMenu]
AS
BEGIN
	SELECT * FROM Menu
END

GO
/****** Object:  StoredProcedure [dbo].[proc_GetListNL]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_GetListNL]
AS
BEGIN
	SELECT * FROM NguyenLieu
END

GO
/****** Object:  StoredProcedure [dbo].[proc_GetListNV]    Script Date: 19/12/2017 11:29:31 SA ******/
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
/****** Object:  StoredProcedure [dbo].[proc_InsertNewNV]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_InsertNewNV]
@Ma_NV varchar(50),
@HoTen_NV	nvarchar(50),
@NgaySinh	datetime,
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
/****** Object:  StoredProcedure [dbo].[proc_LoadCongThuc]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_LoadCongThuc]
AS
BEGIN
	SELECT NL.MaNL,NL.TenNL,CT.MaMon,CT.HamLuong,CT.DVT 
	FROM CongThuc CT JOIN NguyenLieu NL ON CT.MaNL = NL.MaNL
	GROUP BY NL.MaNL,NL.TenNL,CT.MaMon,CT.HamLuong,CT.DVT 
END

GO
/****** Object:  StoredProcedure [dbo].[proc_LoadTonKho]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_LoadTonKho]
AS
BEGIN
	select C.MaMon,C.MaNL,NL.TenNL,NL.SoLuongNhap,SUM(NL.SoLuongNhap - C.SoLuongBan) AS 'SoLuongTon'
	from NguyenLieu NL JOIN (select B.MaMon,CT.MaNL,SUM(B.SoLuong*CT.HamLuong) AS 'SoLuongBan'
							 from CongThuc CT JOIN	(SELECT CTHD.MaMon,SUM(CTHD.SoLuong) AS 'SoLuong'
													 FROM CTHD_BanHang CTHD 
													 GROUP BY CTHD.MaMon) AS B 
							 ON CT.MaMon = B.MaMon
							 GROUP BY B.MaMon,CT.MaNL) AS C ON NL.MaNL = C.MaNL
	GROUP BY C.MaMon,C.MaNL,NL.TenNL,NL.SoLuongNhap
END

GO
/****** Object:  StoredProcedure [dbo].[proc_NewMenu]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_NewMenu]
@MaMon	varchar(50),
@TenMon	nvarchar(50),
@Loai	nvarchar(50),
@DonGia	int,
@DVT	nvarchar(50)
AS
BEGIN
	INSERT INTO Menu(MaMon,TenMon,Loai,DonGia,DVT)
	VALUES (@MaMon,@TenMon,@Loai,@DonGia,@DVT)
END
GO
/****** Object:  StoredProcedure [dbo].[proc_NewNCC]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*Stored procedure New Nha Cung Cap*/
CREATE PROCEDURE [dbo].[proc_NewNCC] @MaNCC varchar(50), @TenNCC nvarchar(50), @DiaChi nvarchar(50), @SDT varchar(50)
AS
BEGIN
	INSERT INTO NhaCungCap(MaNCC, TenNCC, DiaChi, SoDienThoai)
	VALUES (@MaNCC,@TenNCC,@DiaChi,@SDT)
END

GO
/****** Object:  StoredProcedure [dbo].[proc_NewNL]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_NewNL]
@MaNL	varchar(50),
@TenNL	nvarchar(50),
@SoLuongNhap int,
@DVT	nvarchar(50)
AS
BEGIN
	INSERT INTO NguyenLieu(MaNL,TenNL,SoLuongNhap,DVT)
	VALUES (@MaNL,@TenNL,@SoLuongNhap,@DVT)
END

GO
/****** Object:  StoredProcedure [dbo].[proc_SearchCongThuc]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_SearchCongThuc]
@SearchCongThuc nvarchar(50)
AS
BEGIN
	 IF	EXISTS (SELECT * FROM	(SELECT NL.MaNL,NL.TenNL,CT.MaMon,CT.HamLuong,CT.DVT 
	 							FROM CongThuc CT JOIN NguyenLieu NL ON CT.MaNL = NL.MaNL
	 							GROUP BY NL.MaNL,NL.TenNL,CT.MaMon,CT.HamLuong,CT.DVT) AS A
	 			WHERE A.MaNL like @SearchCongThuc) 
	 BEGIN
	 		SELECT * FROM	(SELECT NL.MaNL,NL.TenNL,CT.MaMon,CT.HamLuong,CT.DVT 
								FROM CongThuc CT JOIN NguyenLieu NL ON CT.MaNL = NL.MaNL
								GROUP BY NL.MaNL,NL.TenNL,CT.MaMon,CT.HamLuong,CT.DVT) AS X
	 			WHERE X.MaNL like @SearchCongThuc
	 END
	 ELSE
	 BEGIN
		IF	EXISTS (SELECT * FROM	(SELECT NL.MaNL,NL.TenNL,CT.MaMon,CT.HamLuong,CT.DVT 
	 							FROM CongThuc CT JOIN NguyenLieu NL ON CT.MaNL = NL.MaNL
	 							GROUP BY NL.MaNL,NL.TenNL,CT.MaMon,CT.HamLuong,CT.DVT) AS B
	 			WHERE B.MaMon like @SearchCongThuc)
		BEGIN
			SELECT * FROM	(SELECT NL.MaNL,NL.TenNL,CT.MaMon,CT.HamLuong,CT.DVT 
	 							FROM CongThuc CT JOIN NguyenLieu NL ON CT.MaNL = NL.MaNL
	 							GROUP BY NL.MaNL,NL.TenNL,CT.MaMon,CT.HamLuong,CT.DVT) AS Y
	 			WHERE Y.MaMon like @SearchCongThuc
		END
		ELSE
		BEGIN 
			SELECT * FROM	(SELECT NL.MaNL,NL.TenNL,CT.MaMon,CT.HamLuong,CT.DVT 
	 							FROM CongThuc CT JOIN NguyenLieu NL ON CT.MaNL = NL.MaNL
	 							GROUP BY NL.MaNL,NL.TenNL,CT.MaMon,CT.HamLuong,CT.DVT) AS C
	 			WHERE C.TenNL like @SearchCongThuc
		END
	 END
END

GO
/****** Object:  StoredProcedure [dbo].[proc_SearchHDBH]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_SearchHDBH] 
@SearchHDBH nvarchar(50) 
AS
BEGIN
	if exists( select * from (	SELECT HD.MaHoaDon,B.MaBan,B.TenBan,HD.Ma_NV,HD.NgayLap
								From Ban  B join HoaDonBanHang HD on B.MaBan = HD.MaBan
								group by HD.MaHoaDon,B.MaBan,B.TenBan,HD.Ma_NV,HD.NgayLap) as t
				where t.MaHoaDon like @SearchHDBH )
	begin
				select * from (SELECT HD.MaHoaDon,B.MaBan,B.TenBan,HD.Ma_NV,HD.NgayLap
								From Ban  B join HoaDonBanHang HD on B.MaBan = HD.MaBan
								group by HD.MaHoaDon,B.MaBan,B.TenBan,HD.Ma_NV,HD.NgayLap) as a
				where a.MaHoaDon like @SearchHDBH
	end
	else
	begin
	if exists( select * from (	SELECT HD.MaHoaDon,B.MaBan,B.TenBan,HD.Ma_NV,HD.NgayLap
								From Ban  B join HoaDonBanHang HD on B.MaBan = HD.MaBan
								group by HD.MaHoaDon,B.MaBan,B.TenBan,HD.Ma_NV,HD.NgayLap) as b
				where b.MaBan like @SearchHDBH)
	begin
				select * from  (	SELECT HD.MaHoaDon,B.MaBan,B.TenBan,HD.Ma_NV,HD.NgayLap
									From Ban  B join HoaDonBanHang HD on B.MaBan = HD.MaBan
									group by HD.MaHoaDon,B.MaBan,B.TenBan,HD.Ma_NV,HD.NgayLap) as c
				where c.MaBan like @SearchHDBH
	end
	else
	begin
				select * from  (	SELECT HD.MaHoaDon,B.MaBan,B.TenBan,HD.Ma_NV,HD.NgayLap
									From Ban  B join HoaDonBanHang HD on B.MaBan = HD.MaBan
									group by HD.MaHoaDon,B.MaBan,B.TenBan,HD.Ma_NV,HD.NgayLap) as d
				where d.Ma_NV like @SearchHDBH
	end
	end
END

GO
/****** Object:  StoredProcedure [dbo].[proc_SearchHDNhapHang]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_SearchHDNhapHang]
@SearchHDNH varchar(50)
AS
BEGIN	
	IF(EXISTS(SELECT MaHD_Nhap FROM HoaDonNhapHang WHERE MaHD_Nhap like @SearchHDNH))
		BEGIN
			SELECT * FROM HoaDonNhapHang WHERE MaHD_Nhap like @SearchHDNH
		END
	ELSE
		BEGIN
		IF(EXISTS(SELECT MaNCC FROM HoaDonNhapHang WHERE MaNCC like @SearchHDNH))
			SELECT * FROM HoaDonNhapHang WHERE MaNCC like @SearchHDNH
		END
END
GO
/****** Object:  StoredProcedure [dbo].[proc_SearchMenu]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_SearchMenu] 
@SearchMenu nvarchar(50) 
AS
BEGIN
	IF NOT EXISTS(SELECT * FROM Menu WHERE TenMon like @SearchMenu)
	BEGIN
		Select * from Menu where MaMon like @SearchMenu
	END
	ELSE
	BEGIN
		select * from Menu where TenMon like @SearchMenu
	END
END

GO
/****** Object:  StoredProcedure [dbo].[proc_SearchNCC]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_SearchNCC] 
@SearchNCC nvarchar(50) 
AS
BEGIN
	IF NOT EXISTS(SELECT * FROM NhaCungCap WHERE TenNCC like @SearchNCC)
	BEGIN
		Select * from NhaCungCap where MaNCC like @SearchNCC
	END
	ELSE
	BEGIN
		select * from NhaCungCap where TenNCC like @SearchNCC
	END
END

GO
/****** Object:  StoredProcedure [dbo].[proc_SearchNL]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_SearchNL]
@SearchNL nvarchar(50) 
AS
BEGIN
	IF NOT EXISTS(SELECT * FROM NguyenLieu WHERE TenNL like @SearchNL)
	BEGIN
		Select * from NguyenLieu where MaNL like @SearchNL
	END
	ELSE
	BEGIN
		select * from NguyenLieu where TenNL like @SearchNL
	END
END
GO
/****** Object:  StoredProcedure [dbo].[proc_SearchNV]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_SearchNV] 
@SearchNV nvarchar(50) 
AS
BEGIN
	IF NOT EXISTS(SELECT * FROM NhanVien WHERE HoTen_NV like @SearchNV)
	BEGIN
		Select * from NhanVien where Ma_NV like @SearchNV
	END
	ELSE
	BEGIN
		select * from NhanVien where HoTen_NV like '%'+@SearchNV+'%'
	END
END

GO
/****** Object:  StoredProcedure [dbo].[proc_ShowHDNhapHang]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_ShowHDNhapHang]
--@MaHDNH varchar(50),
@NgayNhap datetime
AS
BEGIN	
	SELECT HDNH.MaNL,NL.TenNL,HDNH.SoLuong,Menu.DonGia,HDNH.DVT,HD.NgayNhap,SUM(HDNH.SoLuong*Menu.DonGia) AS 'TongTien'
	FROM CTHD_Nhap HDNH JOIN CongThuc CT ON HDNH.MaNL = CT.MaNL
						JOIN Menu ON CT.MaMon = Menu.MaMon
						JOIN NguyenLieu NL ON NL.MaNL =  HDNH.MaNL
						JOIN HoaDonNhapHang HD ON HD.MaHD_Nhap = HDNH.MaHD_Nhap 
	WHERE HD.NgayNhap = @NgayNhap
	GROUP BY HDNH.MaNL,NL.TenNL,HDNH.SoLuong,Menu.DonGia,HDNH.DVT,HD.NgayNhap
END

GO
/****** Object:  StoredProcedure [dbo].[proc_TinhTongHDNhapHang]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_TinhTongHDNhapHang]
@NgayNhap datetime
AS
BEGIN	
	SELECT HD.NgayNhap,SUM(HDNH.SoLuong*Menu.DonGia) AS 'TongTien'
	FROM CTHD_Nhap HDNH JOIN CongThuc CT ON HDNH.MaNL = CT.MaNL
						JOIN Menu ON CT.MaMon = Menu.MaMon
						JOIN HoaDonNhapHang HD ON HD.MaHD_Nhap = HDNH.MaHD_Nhap
	WHERE HD.NgayNhap = @NgayNhap
	GROUP BY HD.NgayNhap
END

GO
/****** Object:  StoredProcedure [dbo].[proc_TonKho]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_TonKho]
@TenNL nvarchar(50)
AS
BEGIN
	select C.MaNL,NL.TenNL,C.MaMon,NL.SoLuongNhap,C.SoLuongBan,SUM(NL.SoLuongNhap - C.SoLuongBan) AS 'SoLuongTon'
	from NguyenLieu NL JOIN (select B.MaMon,CT.MaNL,SUM(B.SoLuong*CT.HamLuong) AS 'SoLuongBan'
							 from CongThuc CT JOIN	(SELECT CTHD.MaMon,SUM(CTHD.SoLuong) AS 'SoLuong'
													 FROM CTHD_BanHang CTHD 
													 GROUP BY CTHD.MaMon) AS B 
							 ON CT.MaMon = B.MaMon
							 GROUP BY B.MaMon,CT.MaNL) AS C ON NL.MaNL = C.MaNL
	WHERE NL.TenNL = @TenNL
	GROUP BY C.MaNL,NL.TenNL,C.MaMon,NL.SoLuongNhap,C.SoLuongBan
END

GO
/****** Object:  StoredProcedure [dbo].[proc_TongDoanhThu]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_TongDoanhThu]
@NgayDau datetime,
@NgayCuoi datetime
AS
BEGIN
	SELECT SUM(A.TongTien) AS 'TongDoanhThu'
	FROM HoaDonBanHang HD JOIN  (	
								SELECT CTHD.MaHoaDon,SUM(CTHD.SoLuong*Menu.DonGia) AS 'TongTien'
								FROM CTHD_BanHang CTHD  JOIN Menu ON CTHD.MaMon = Menu.MaMon
								GROUP BY CTHD.MaHoaDon
								) AS A ON HD.MaHoaDon = A.MaHoaDon
	WHERE (HD.NgayLap>= @NgayDau) AND (HD.NgayLap<=@NgayCuoi)
END

GO
/****** Object:  StoredProcedure [dbo].[proc_TongHDNhapHang]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_TongHDNhapHang]
AS
BEGIN	
	SELECT SUM(HDNH.SoLuong*Menu.DonGia) AS 'TongTien'
	FROM CTHD_Nhap HDNH JOIN CongThuc CT ON HDNH.MaNL = CT.MaNL
						JOIN Menu ON CT.MaMon = Menu.MaMon
						JOIN HoaDonNhapHang HD ON HD.MaHD_Nhap = HDNH.MaHD_Nhap
END

GO
/****** Object:  StoredProcedure [dbo].[proc_UpdateMenu]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_UpdateMenu]
@MaMon	varchar(50),
@TenMon	nvarchar(50),
@Loai	nvarchar(50),
@DonGia	int,
@DVT	nvarchar(50),
@pResultCode_Menu varchar(50) output,
@pResultMessage_Menu nvarchar(100) output
AS
BEGIN
	IF NOT EXISTS(SELECT MaMon from Menu WHERE MaMon = @MaMon)
	BEGIN
		SELECT @pResultCode_Menu = '-1', @pResultMessage_Menu = N'Không tồn tại Mã Món! 
Vui lòng thêm mới Món Ăn trước khi sửa thông tin Món!'
	END
	ELSE
	BEGIN
		UPDATE Menu
		SET TenMon=@TenMon,Loai= @Loai,DonGia=@DonGia,DVT=@DVT
		WHERE MaMon = @MaMon
		SELECT  @pResultCode_Menu = '1', @pResultMessage_Menu = N'Sửa thông tin món thành công!'
		FROM Menu
		WHERE MaMon = @MaMon
	END
END

GO
/****** Object:  StoredProcedure [dbo].[proc_UpdateNCC]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_UpdateNCC] 
@MaNCC varchar(50),
@TenNCC nvarchar(50),
@DiaChi nvarchar(50),
@SDT varchar(50),
@pResultCode_NCC varchar(50) output,
@pResultMessage_NCC nvarchar(100) output
AS
	IF NOT EXISTS(SELECT MaNCC FROM NhaCungCap WHERE MaNCC=@MaNCC)
	BEGIN
		SELECT @pResultCode_NCC = '-1', @pResultMessage_NCC = N'Không tồn tại Mã Nhà Cung Cấp! 
Vui lòng thêm mới Nhà Cung Cấp trước khi sửa thông tin của Nhà Cung Cấp!'
	END
	ELSE
	BEGIN
		UPDATE NhaCungCap 
		SET TenNCC=@TenNCC,DiaChi = @DiaChi,SoDienThoai=@SDT 
		WHERE MaNCC=@MaNCC
		SELECT @pResultCode_NCC = '1', @pResultMessage_NCC = N'Sửa thành công!'
		FROM NhaCungCap
		WHERE MaNCC = @MaNCC
	END

GO
/****** Object:  StoredProcedure [dbo].[proc_UpdateNL]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_UpdateNL]
@MaNL	varchar(50),
@TenNL	nvarchar(50),
@SoLuongNhap int,
@DVT	nvarchar(50),
@pResultCode_NL int output,
@pResultMessage_NL nvarchar(100) output
AS
BEGIN
	IF NOT EXISTS(SELECT MaNL FROM NguyenLieu WHERE MaNL=@MaNL)
	BEGIN
		SELECT @pResultCode_NL = -1, @pResultMessage_NL = N'Không tồn tại Nguyên Liệu! 
Vui lòng thêm mới Nguyên Liệu trước khi sửa thông tin Nguyên Liệu!'
	END
	ELSE
	BEGIN
		UPDATE NguyenLieu
		SET TenNL=@TenNL,SoLuongNhap=@SoLuongNhap,DVT=@DVT
		WHERE MaNL=@MaNL
		SELECT  @pResultCode_NL = 1, @pResultMessage_NL = N'Sửa thông tin nguyên liệu thành công!'
		FROM NguyenLieu
		WHERE MaNL = @MaNL
	END
END

GO
/****** Object:  StoredProcedure [dbo].[proc_UpdateNV]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_UpdateNV]
@Ma_NV varchar(50) ,
@HoTen_NV	nvarchar(50),
@NgaySinh	date,
@GioiTinh	nvarchar(10),
@QueQuan	nvarchar(50),
@DiaChi	nvarchar(50),
@Email	varchar(50),
@SoDienThoai varchar(50)
,@pResultCode_NV varchar(50) output
,@pResultMessage_NV nvarchar(100) output
AS
BEGIN
	IF NOT EXISTS(SELECT Ma_NV from NhanVien WHERE Ma_NV = @Ma_NV)
	BEGIN
		SELECT @pResultCode_NV = '-1', @pResultMessage_NV = N'Không tồn tại Mã Nhân Viên! 
Vui lòng thêm mới Nhân Viên trước khi sửa thông tin của Nhân Viên!'
	END
	ELSE
	BEGIN
		UPDATE NhanVien 
		SET HoTen_NV = @HoTen_NV,NgaySinh = @NgaySinh,GioiTinh = @GioiTinh,
		QueQuan=@QueQuan, DiaChi = @DiaChi, Email = @Email,SoDienThoai = @SoDienThoai
		WHERE Ma_NV = @Ma_NV
		SELECT @pResultCode_NV = '1' , @pResultMessage_NV = N'Sửa thông tin thành công' FROM NhanVien WHERE Ma_NV = @Ma_NV
	END
END
GO
/****** Object:  StoredProcedure [dbo].[usp_USER_CreateUser]    Script Date: 19/12/2017 11:29:31 SA ******/
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
/****** Object:  StoredProcedure [dbo].[usp_USER_CheckUser]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*Stored Procedure Kiểm tra User có tồn tại hay ko. Nếu tồn tại thì thông báo đăng nhập thành công, ngược lại thông báo đăng nhập thất bại*/
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
/****** Object:  StoredProcedure [dbo].[usp_USER_GetUserListPermision]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_USER_GetUserListPermision]
@UserName varchar(50)
AS
BEGIN
	SELECT UserName,Quyen FROM DangNhap WHERE  UserName = @UserName 
END

GO
/****** Object:  Table [dbo].[Ban]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ban](
	[MaBan] [varchar](50) NOT NULL,
	[TenBan] [nvarchar](50) NULL,
 CONSTRAINT [PK_Ban] PRIMARY KEY CLUSTERED 
(
	[MaBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CongThuc]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CongThuc](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[MaMon] [varchar](50) NULL,
	[MaNL] [varchar](50) NULL,
	[HamLuong] [float] NULL,
	[DVT] [nvarchar](50) NULL,
 CONSTRAINT [PK_CongThuc] PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CTHD_BanHang]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CTHD_BanHang](
	[MaCTHD] [varchar](50) NOT NULL,
	[MaHoaDon] [varchar](50) NULL,
	[MaMon] [varchar](50) NULL,
	[SoLuong] [int] NULL,
	[ThanhToan] [varchar](50) NULL,
 CONSTRAINT [PK_CTHD_BanHang] PRIMARY KEY CLUSTERED 
(
	[MaCTHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CTHD_Nhap]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CTHD_Nhap](
	[MaCTHD_Nhap] [varchar](50) NOT NULL,
	[MaHD_Nhap] [varchar](50) NULL,
	[MaNL] [varchar](50) NULL,
	[SoLuong] [float] NULL,
	[DVT] [nvarchar](50) NULL,
 CONSTRAINT [PK_CTHD_Nhap] PRIMARY KEY CLUSTERED 
(
	[MaCTHD_Nhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 19/12/2017 11:29:31 SA ******/
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
/****** Object:  Table [dbo].[HoaDonBanHang]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDonBanHang](
	[MaHoaDon] [varchar](50) NOT NULL,
	[MaBan] [varchar](50) NULL,
	[Ma_NV] [varchar](50) NULL,
	[NgayLap] [datetime] NULL,
 CONSTRAINT [PK_HoaDonBanHang] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDonNhapHang]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDonNhapHang](
	[MaHD_Nhap] [varchar](50) NOT NULL,
	[MaNCC] [varchar](50) NULL,
	[NgayNhap] [datetime] NULL,
 CONSTRAINT [PK_HoaDonNhapHang] PRIMARY KEY CLUSTERED 
(
	[MaHD_Nhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Menu](
	[MaMon] [varchar](50) NOT NULL,
	[TenMon] [nvarchar](50) NULL,
	[Loai] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
	[DVT] [nvarchar](50) NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NguyenLieu]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NguyenLieu](
	[MaNL] [varchar](50) NOT NULL,
	[TenNL] [nvarchar](50) NULL,
	[SoLuongNhap] [int] NULL,
	[DVT] [nvarchar](50) NULL,
 CONSTRAINT [PK_NguyenLieu] PRIMARY KEY CLUSTERED 
(
	[MaNL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 19/12/2017 11:29:31 SA ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 19/12/2017 11:29:31 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[Ma_NV] [varchar](50) NOT NULL,
	[HoTen_NV] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
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
INSERT [dbo].[Ban] ([MaBan], [TenBan]) VALUES (N'ALPHA', N'Bàn 7')
INSERT [dbo].[Ban] ([MaBan], [TenBan]) VALUES (N'BETA', N'Bàn 6')
INSERT [dbo].[Ban] ([MaBan], [TenBan]) VALUES (N'DELTA', N'Bàn 8')
SET IDENTITY_INSERT [dbo].[CongThuc] ON 

INSERT [dbo].[CongThuc] ([STT], [MaMon], [MaNL], [HamLuong], [DVT]) VALUES (1, N'01', N'NL1', 1, N'Gói')
INSERT [dbo].[CongThuc] ([STT], [MaMon], [MaNL], [HamLuong], [DVT]) VALUES (2, N'02', N'NL2', 1, N'Gói')
INSERT [dbo].[CongThuc] ([STT], [MaMon], [MaNL], [HamLuong], [DVT]) VALUES (3, N'02', N'NL3', 0.02, N'Kg')
INSERT [dbo].[CongThuc] ([STT], [MaMon], [MaNL], [HamLuong], [DVT]) VALUES (4, N'03', N'NL4', 1, N'Gói')
INSERT [dbo].[CongThuc] ([STT], [MaMon], [MaNL], [HamLuong], [DVT]) VALUES (5, N'04', N'NL5', 1, N'Gói')
SET IDENTITY_INSERT [dbo].[CongThuc] OFF
INSERT [dbo].[CTHD_BanHang] ([MaCTHD], [MaHoaDon], [MaMon], [SoLuong], [ThanhToan]) VALUES (N'01', N'5', N'01', 1, NULL)
INSERT [dbo].[CTHD_BanHang] ([MaCTHD], [MaHoaDon], [MaMon], [SoLuong], [ThanhToan]) VALUES (N'02', N'5', N'02', 2, NULL)
INSERT [dbo].[CTHD_BanHang] ([MaCTHD], [MaHoaDon], [MaMon], [SoLuong], [ThanhToan]) VALUES (N'03', N'5', N'03', 4, NULL)
INSERT [dbo].[CTHD_BanHang] ([MaCTHD], [MaHoaDon], [MaMon], [SoLuong], [ThanhToan]) VALUES (N'04', N'6', N'01', 3, NULL)
INSERT [dbo].[CTHD_BanHang] ([MaCTHD], [MaHoaDon], [MaMon], [SoLuong], [ThanhToan]) VALUES (N'05', N'7', N'03', 2, NULL)
INSERT [dbo].[CTHD_BanHang] ([MaCTHD], [MaHoaDon], [MaMon], [SoLuong], [ThanhToan]) VALUES (N'06', N'7', N'04', 3, NULL)
INSERT [dbo].[CTHD_BanHang] ([MaCTHD], [MaHoaDon], [MaMon], [SoLuong], [ThanhToan]) VALUES (N'07', N'8', N'01', 4, NULL)
INSERT [dbo].[CTHD_BanHang] ([MaCTHD], [MaHoaDon], [MaMon], [SoLuong], [ThanhToan]) VALUES (N'08', N'8', N'02', 3, NULL)
INSERT [dbo].[CTHD_BanHang] ([MaCTHD], [MaHoaDon], [MaMon], [SoLuong], [ThanhToan]) VALUES (N'09', N'8', N'03', 2, NULL)
INSERT [dbo].[CTHD_BanHang] ([MaCTHD], [MaHoaDon], [MaMon], [SoLuong], [ThanhToan]) VALUES (N'10', N'1', N'01', 2, NULL)
INSERT [dbo].[CTHD_BanHang] ([MaCTHD], [MaHoaDon], [MaMon], [SoLuong], [ThanhToan]) VALUES (N'11', N'2', N'02', 5, NULL)
INSERT [dbo].[CTHD_BanHang] ([MaCTHD], [MaHoaDon], [MaMon], [SoLuong], [ThanhToan]) VALUES (N'12', N'3', N'03', 6, NULL)
INSERT [dbo].[CTHD_BanHang] ([MaCTHD], [MaHoaDon], [MaMon], [SoLuong], [ThanhToan]) VALUES (N'13', N'4', N'04', 7, NULL)
INSERT [dbo].[CTHD_Nhap] ([MaCTHD_Nhap], [MaHD_Nhap], [MaNL], [SoLuong], [DVT]) VALUES (N'CTA', N'01', N'NL1', 500, N'Gói')
INSERT [dbo].[CTHD_Nhap] ([MaCTHD_Nhap], [MaHD_Nhap], [MaNL], [SoLuong], [DVT]) VALUES (N'CTB', N'02', N'NL2', 50, N'Gói')
INSERT [dbo].[CTHD_Nhap] ([MaCTHD_Nhap], [MaHD_Nhap], [MaNL], [SoLuong], [DVT]) VALUES (N'CTC', N'03', N'NL3', 10, N'Kg')
INSERT [dbo].[CTHD_Nhap] ([MaCTHD_Nhap], [MaHD_Nhap], [MaNL], [SoLuong], [DVT]) VALUES (N'CTD', N'04', N'NL4', 30, N'Gói')
INSERT [dbo].[CTHD_Nhap] ([MaCTHD_Nhap], [MaHD_Nhap], [MaNL], [SoLuong], [DVT]) VALUES (N'CTE', N'05', N'NL5', 30, N'Gói')
SET IDENTITY_INSERT [dbo].[DangNhap] ON 

INSERT [dbo].[DangNhap] ([ID], [Ma_NV], [UserName], [PassWord], [Quyen]) VALUES (10, N'01', N'admin', N'ŒivåµA½é½Mîß±g©ÈsüK¸¨o*´H©', N'admin')
INSERT [dbo].[DangNhap] ([ID], [Ma_NV], [UserName], [PassWord], [Quyen]) VALUES (11, N'02', N'nhanvien1', N'°¦ç®7œÑåh4œˆçe}ñ­…÷
™Rx oƠ', N'nhanvien')
SET IDENTITY_INSERT [dbo].[DangNhap] OFF
INSERT [dbo].[HoaDonBanHang] ([MaHoaDon], [MaBan], [Ma_NV], [NgayLap]) VALUES (N'1', N'ALPHA', N'01', CAST(0x0000A84900000000 AS DateTime))
INSERT [dbo].[HoaDonBanHang] ([MaHoaDon], [MaBan], [Ma_NV], [NgayLap]) VALUES (N'2', N'ALPHA', N'01', CAST(0x0000A5AE00000000 AS DateTime))
INSERT [dbo].[HoaDonBanHang] ([MaHoaDon], [MaBan], [Ma_NV], [NgayLap]) VALUES (N'3', N'DELTA', N'02', CAST(0x0000A72800000000 AS DateTime))
INSERT [dbo].[HoaDonBanHang] ([MaHoaDon], [MaBan], [Ma_NV], [NgayLap]) VALUES (N'4', N'BETA', N'02', CAST(0x0000A71900000000 AS DateTime))
INSERT [dbo].[HoaDonBanHang] ([MaHoaDon], [MaBan], [Ma_NV], [NgayLap]) VALUES (N'5', N'BETA', N'02', CAST(0x00008CC400000000 AS DateTime))
INSERT [dbo].[HoaDonBanHang] ([MaHoaDon], [MaBan], [Ma_NV], [NgayLap]) VALUES (N'6', N'ALPHA', N'01', CAST(0x00008BF000000000 AS DateTime))
INSERT [dbo].[HoaDonBanHang] ([MaHoaDon], [MaBan], [Ma_NV], [NgayLap]) VALUES (N'7', N'DELTA', N'02', CAST(0x00008BF000000000 AS DateTime))
INSERT [dbo].[HoaDonBanHang] ([MaHoaDon], [MaBan], [Ma_NV], [NgayLap]) VALUES (N'8', N'DELTA', N'01', CAST(0x0000A84900000000 AS DateTime))
INSERT [dbo].[HoaDonNhapHang] ([MaHD_Nhap], [MaNCC], [NgayNhap]) VALUES (N'01', N'VDA', CAST(0x00008CC400000000 AS DateTime))
INSERT [dbo].[HoaDonNhapHang] ([MaHD_Nhap], [MaNCC], [NgayNhap]) VALUES (N'02', N'VDC', CAST(0x00008C6200000000 AS DateTime))
INSERT [dbo].[HoaDonNhapHang] ([MaHD_Nhap], [MaNCC], [NgayNhap]) VALUES (N'03', N'GTA', CAST(0x00008CC400000000 AS DateTime))
INSERT [dbo].[HoaDonNhapHang] ([MaHD_Nhap], [MaNCC], [NgayNhap]) VALUES (N'04', N'GTX', CAST(0x00008C6200000000 AS DateTime))
INSERT [dbo].[HoaDonNhapHang] ([MaHD_Nhap], [MaNCC], [NgayNhap]) VALUES (N'05', N'VDB', CAST(0x00008CBE00000000 AS DateTime))
INSERT [dbo].[Menu] ([MaMon], [TenMon], [Loai], [DonGia], [DVT]) VALUES (N'01', N'Cà Phê đen', N'Đồ uống', 10000, N'Ly')
INSERT [dbo].[Menu] ([MaMon], [TenMon], [Loai], [DonGia], [DVT]) VALUES (N'02', N'Cà phê sữa', N'Đồ uống', 12000, N'Ly')
INSERT [dbo].[Menu] ([MaMon], [TenMon], [Loai], [DonGia], [DVT]) VALUES (N'03', N'Mì', N'Đồ ăn', 20000, N'Tô')
INSERT [dbo].[Menu] ([MaMon], [TenMon], [Loai], [DonGia], [DVT]) VALUES (N'04', N'Phở', N'Đồ ăn', 20000, N'Tô')
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [SoLuongNhap], [DVT]) VALUES (N'NL1', N'Cà Phê đen', 500, N'Gói')
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [SoLuongNhap], [DVT]) VALUES (N'NL2', N'Cà Phê', 50, N'Gói')
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [SoLuongNhap], [DVT]) VALUES (N'NL3', N'Sữa', 10, N'Kg')
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [SoLuongNhap], [DVT]) VALUES (N'NL4', N'Mì', 30, N'Gói')
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [SoLuongNhap], [DVT]) VALUES (N'NL5', N'Phở', 30, N'Gói')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SoDienThoai]) VALUES (N'GTA', N'FPTShop', N'2480 Quận Gò Vấp', N'01672493107')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SoDienThoai]) VALUES (N'GTX', N'WorkShop', N'213 Quận 1', N'090921313122')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SoDienThoai]) VALUES (N'VDA', N'Bách Hóa Xanh', N'245 Đường Bùi Văn Ngữ', N'0934243332')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SoDienThoai]) VALUES (N'VDB', N'Siêu Thị CoopMart', N'275 Đường Nguyễn Oanh', N'01267638120')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SoDienThoai]) VALUES (N'VDC', N'Vinamilk', N'147 Đường Hiệp Thành', N'01493628107')
INSERT [dbo].[NhanVien] ([Ma_NV], [HoTen_NV], [NgaySinh], [GioiTinh], [QueQuan], [DiaChi], [Email], [SoDienThoai]) VALUES (N'01', N'Trần Đức Sơn', CAST(0x00008CC400000000 AS DateTime), N'Nam', N'Thái Bình123', N'247 Đường Bùi Văn Ngữ, Quận 12', N'tranducson1998tb@gmail.com', N'01672493107')
INSERT [dbo].[NhanVien] ([Ma_NV], [HoTen_NV], [NgaySinh], [GioiTinh], [QueQuan], [DiaChi], [Email], [SoDienThoai]) VALUES (N'02', N'Nguyễn Thành Đạt', CAST(0x00008C6200000000 AS DateTime), N'Nam', N'Quảng Ngãi', N'241 ', N'datgaghe@gmail.com', N'0975565710')
INSERT [dbo].[NhanVien] ([Ma_NV], [HoTen_NV], [NgaySinh], [GioiTinh], [QueQuan], [DiaChi], [Email], [SoDienThoai]) VALUES (N'02123', N'Nguyễn Thành Đạt', CAST(0x00008C6200000000 AS DateTime), N'Nam', N'Quảng Ngãi', N'241 ', N'datgaghe@gmail.com', N'0975565710')
INSERT [dbo].[NhanVien] ([Ma_NV], [HoTen_NV], [NgaySinh], [GioiTinh], [QueQuan], [DiaChi], [Email], [SoDienThoai]) VALUES (N'04', N'04', CAST(0x00008CBE00000000 AS DateTime), N'4', N'41231', N'4', N'4qwewq', N'4')
ALTER TABLE [dbo].[CongThuc]  WITH CHECK ADD  CONSTRAINT [FK_CongThuc_Menu] FOREIGN KEY([MaMon])
REFERENCES [dbo].[Menu] ([MaMon])
GO
ALTER TABLE [dbo].[CongThuc] CHECK CONSTRAINT [FK_CongThuc_Menu]
GO
ALTER TABLE [dbo].[CongThuc]  WITH CHECK ADD  CONSTRAINT [FK_CongThuc_NguyenLieu] FOREIGN KEY([MaNL])
REFERENCES [dbo].[NguyenLieu] ([MaNL])
GO
ALTER TABLE [dbo].[CongThuc] CHECK CONSTRAINT [FK_CongThuc_NguyenLieu]
GO
ALTER TABLE [dbo].[CTHD_BanHang]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_BanHang_HoaDonBanHang] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDonBanHang] ([MaHoaDon])
GO
ALTER TABLE [dbo].[CTHD_BanHang] CHECK CONSTRAINT [FK_CTHD_BanHang_HoaDonBanHang]
GO
ALTER TABLE [dbo].[CTHD_BanHang]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_BanHang_Menu] FOREIGN KEY([MaMon])
REFERENCES [dbo].[Menu] ([MaMon])
GO
ALTER TABLE [dbo].[CTHD_BanHang] CHECK CONSTRAINT [FK_CTHD_BanHang_Menu]
GO
ALTER TABLE [dbo].[CTHD_Nhap]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_Nhap_HoaDonNhapHang] FOREIGN KEY([MaHD_Nhap])
REFERENCES [dbo].[HoaDonNhapHang] ([MaHD_Nhap])
GO
ALTER TABLE [dbo].[CTHD_Nhap] CHECK CONSTRAINT [FK_CTHD_Nhap_HoaDonNhapHang]
GO
ALTER TABLE [dbo].[CTHD_Nhap]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_Nhap_NguyenLieu] FOREIGN KEY([MaNL])
REFERENCES [dbo].[NguyenLieu] ([MaNL])
GO
ALTER TABLE [dbo].[CTHD_Nhap] CHECK CONSTRAINT [FK_CTHD_Nhap_NguyenLieu]
GO
ALTER TABLE [dbo].[DangNhap]  WITH CHECK ADD  CONSTRAINT [FK_DangNhap_NhanVien] FOREIGN KEY([Ma_NV])
REFERENCES [dbo].[NhanVien] ([Ma_NV])
GO
ALTER TABLE [dbo].[DangNhap] CHECK CONSTRAINT [FK_DangNhap_NhanVien]
GO
ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBanHang_Ban] FOREIGN KEY([MaBan])
REFERENCES [dbo].[Ban] ([MaBan])
GO
ALTER TABLE [dbo].[HoaDonBanHang] CHECK CONSTRAINT [FK_HoaDonBanHang_Ban]
GO
ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBanHang_NhanVien] FOREIGN KEY([Ma_NV])
REFERENCES [dbo].[NhanVien] ([Ma_NV])
GO
ALTER TABLE [dbo].[HoaDonBanHang] CHECK CONSTRAINT [FK_HoaDonBanHang_NhanVien]
GO
ALTER TABLE [dbo].[HoaDonNhapHang]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonNhapHang_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[HoaDonNhapHang] CHECK CONSTRAINT [FK_HoaDonNhapHang_NhaCungCap]
GO
USE [master]
GO
ALTER DATABASE [QLBanHangCaFe] SET  READ_WRITE 
GO
