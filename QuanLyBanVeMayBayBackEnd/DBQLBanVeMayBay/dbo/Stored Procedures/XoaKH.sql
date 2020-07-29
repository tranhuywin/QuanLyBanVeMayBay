create procedure [dbo].[XoaKH]
@MaKH nchar(10),
@HoTenKH nvarchar(50),
@SDT nvarchar(50),
@Email nvarchar(50),
@GioiTinh nchar(10),
@CMND nvarchar(50)
AS
DELETE FROM KhachHang WHERE MaKH=@MaKH