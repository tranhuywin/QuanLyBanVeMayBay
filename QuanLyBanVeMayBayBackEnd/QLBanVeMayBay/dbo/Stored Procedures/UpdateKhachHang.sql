create procedure [dbo].[UpdateKhachHang]
@MaKH nchar(10),
@HoTenKH nvarchar(50),
@SDT nvarchar(50),
@Email nvarchar(50),
@GioiTinh nchar(10),
@CMND nvarchar(50)
AS
UPDATE KhachHang 
SET HoTenKH=@HoTenKH, SDT=@SDT, Email=@Email, GioiTinh=@GioiTinh, CMND=@CMND
WHERE MaKH = @MaKH