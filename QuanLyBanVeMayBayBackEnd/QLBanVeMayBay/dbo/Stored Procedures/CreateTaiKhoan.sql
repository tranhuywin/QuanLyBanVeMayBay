Create Proc [dbo].[CreateTaiKhoan]
@ID nchar(10),
@User nchar(10),
@Password nchar(10),
@NgaySinh date,
@CMND nvarchar(50),
@DiaChi nvarchar(50),
@HoTen nvarchar(50)
as
Insert into TaiKhoan (Id,[User], Password, NgaySinh, CMND,DiaChi,HoTen,ChucVu)
values(@ID,@User, @Password, @NgaySinh, @CMND, @DiaChi, @HoTen, '1')