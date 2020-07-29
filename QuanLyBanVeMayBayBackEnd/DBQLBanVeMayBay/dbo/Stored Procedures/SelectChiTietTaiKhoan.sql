Create PROC [dbo].[SelectChiTietTaiKhoan]
@User nchar(10),
@Password nchar(10)
as
Select HoTen, DiaChi, CMND,NgaySinh
from TaiKhoan
Where [User] = @User and Password = @Password