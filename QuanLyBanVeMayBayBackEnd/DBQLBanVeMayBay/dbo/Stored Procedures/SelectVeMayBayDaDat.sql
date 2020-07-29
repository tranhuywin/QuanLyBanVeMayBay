CREATE Proc [dbo].[SelectVeMayBayDaDat]
@CMND nvarchar(50),
@MaVeChuyenBay nchar(10)
as
Select CMND as "CMND của KH", HoTenKH as"Họ tên của KH", MaVeChuyenbay as "Mã vé chuyến bay", VeChuyenBay.MaChuyenbay as "Mã chuyến bay"
from KhachHang, VeChuyenBay, ChuyenBay, PhieuDatCho
WHERE KhachHang.MaKH = PhieuDatCho.MaKH AND PhieuDatCho.MaPhieu = VeChuyenBay.MaPhieu AND VeChuyenBay.MaChuyenBay = ChuyenBay.MaChuyenBay AND TinhTrangVe = 'DaDat'
AND (CMND like '%'+@CMND + '%') AND (MaVeChuyenBay like '%'+ @MaVeChuyenBay + '%')