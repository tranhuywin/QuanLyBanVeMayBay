create PROCEDURE [dbo].[INSERT_STEP3_KHACHHANG]
@HoTenKH nvarchar(50),
@MaKH nchar(10),
@SDT nvarchar(50),
@Email nvarchar(50),
@GioiTinh nchar(10),
@CMND nvarchar(50)
as
Insert into KHACHHANG(MaKH, HoTenKH, CMND, SDT, Email,GioiTinh) values (@MaKH, @HoTenKH, @CMND, @SDT, @Email, @GioiTinh)