CREATE PROC [dbo].[SelectKhachHang]
@CMND nvarchar(50),
@HoTenKH nvarchar(50),
@Email nvarchar(50),
@SDT nvarchar(50)
as
SELECT HoTenKH, CMND, Email, SDT
FROM KhachHang
WHERE (CMND like '%'+@CMND + '%') AND (HoTenKH like '%'+@HoTenKH + '%') 
AND (Email LIKE '%'+@Email + '%') AND (SDT LIKE '%'+@SDT + '%')