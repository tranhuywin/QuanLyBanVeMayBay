create procedure [dbo].[SelectKhachHangTheoTenVaCMND]
@HoTenKH nvarchar(50),
@CMND nvarchar(50)
AS
SELECT * from KhachHang
WHERE HoTenKH = @HoTenKH or CMND = @CMND