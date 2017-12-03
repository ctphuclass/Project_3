CREATE DATABASE QLBanHangCaFe
GO
USE QLBanHangCaFe
GO

/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 18/11/2017 14:23:43 ******/
DROP TABLE [dbo].[NhaCungCap]
GO

/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 18/11/2017 14:23:43 ******/
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

SELECT * FROM dbo.NhaCungCap
GO

/*Stored procedure load danh sach Nha Cung Cap*/
CREATE PROCEDURE [dbo].[ds_NCC_GetNccList]
AS
BEGIN
	SELECT * FROM [NhaCungCap]
END
GO
/*Stored procedure New Nha Cung Cap*/
CREATE PROCEDURE [dbo].[proc_NewNCC] @MaNCC varchar(50), @TenNCC nvarchar(50), @DiaChi nvarchar(50), @SDT varchar(50)
AS
BEGIN
	INSERT INTO NhaCungCap(MaNCC, TenNCC, DiaChi, SoDienThoai)
	VALUES (@MaNCC,@TenNCC,@DiaChi,@SDT)
END
GO 
/*Stored procedure Update Nha Cung Cap*/
CREATE PROCEDURE [dbo].[proc_UpdateNCC] @MaNCC varchar(50), @TenNCC nvarchar(50), @DiaChi nvarchar(50), @SDT varchar(50)
AS
BEGIN
	UPDATE NhaCungCap SET TenNCC=@TenNCC,DiaChi = @DiaChi,SoDienThoai=@SDT WHERE MaNCC=@MaNCC
END
GO
/*Stored procedure Delete Nha Cung Cap*/
CREATE PROCEDURE [dbo].[proc_DeleteNCC] @MaNCC varchar(50), @TenNCC nvarchar(50), @DiaChi nvarchar(50), @SDT varchar(50)
AS
BEGIN
	DELETE FROM NhaCungCap WHERE MaNCC = @MaNCC
END
GO

DROP proc proc_DeleteNCC
GO
/*Stored procedure Search Nha Cung Cap*/
CREATE PROCEDURE [dbo].[proc_SearchNCC] @MaNCC varchar(50), @TenNCC nvarchar(50)
AS
BEGIN
	SELECT * FROM NhaCungCap
	Where MaNCC = @MaNCC or TenNCC = @TenNCC
END
GO
/*Stored procedure [usp_USER_ChangePassword] */
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
/*Stored Procedure Kiểm tra tài khoản Login*/
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
/*Stored Procedure phân quyền*/
CREATE PROCEDURE [dbo].[usp_USER_GetUserPermision]
	@piUserID int,
	@psQuyen varchar(50)
AS
BEGIN
	SELECT ID,Quyen FROM DangNhap WHERE ID = @piUserID and Quyen = @psQuyen
END
GO
/*Stored Procedure phân quyền*/
ALTER PROCEDURE [dbo].[usp_USER_GetUserListPermision]
@UserName varchar(50)
AS
BEGIN
	SELECT UserName,Quyen FROM DangNhap WHERE  UserName = @UserName 
END
GO
SELECT * FROM DangNhap where ID = 10 and Quyen = 'admin'
EXEC [dbo].[usp_USER_GetUserListPermision] 'nhanvien1'
GO