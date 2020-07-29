CREATE PROCEDURE [dbo].[SelectTaiKhoan] 
@User nchar(10),
@Password nchar(10),
@ChucVu int
AS 
	SELECT [User], Password, ChucVu FROM TaiKhoan WHERE [User] = @User AND Password = @Password