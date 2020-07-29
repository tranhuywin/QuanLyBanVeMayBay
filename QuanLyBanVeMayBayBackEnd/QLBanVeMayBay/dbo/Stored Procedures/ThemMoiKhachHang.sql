create procedure [dbo].[ThemMoiKhachHang]
@MaKH nchar(10),
@HoTenKH nvarchar(50),
@SDT nvarchar(50),
@Email nvarchar(50),
@GioiTinh nchar(10),
@CMND nvarchar(50)
AS
INSERT INTO KhachHang (MaKH, HoTenKH, SDT, Email, GioiTinh, CMND)
VALUES(@MaKH, @HoTenKH, @SDT, @Email, @GioiTinh, @CMND)