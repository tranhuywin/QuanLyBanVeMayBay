Create PROC [dbo].[UpdateChiTietTaiKhoan]
@User nchar(10),
@Password nchar(10),
@NgaySinh date,
@CMND nvarchar(50),
@DiaChi nvarchar(50),
@HoTen nvarchar(50)
as
UPDATE TaiKhoan
SET [User] = @User, Password = @Password, NgaySinh = @NgaySinh,
CMND =@CMND, DiaChi = @DiaChi, HoTen = @HoTen
FROM TaiKhoan
WHERE [User] = @User AND Password = @Password