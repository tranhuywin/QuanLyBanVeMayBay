CREATE PROC [dbo].[SelectKhachHangVaVeChuyenBay]
@CMND nvarchar(50),
@MaVeChuyenBay nchar(10)
as
SELECT HoTenKH as "Họ tên", SDT as "Số điện thoại", VeChuyenBay.MaVeChuyenBay as "Mã vé Chuyến Bay", PhieuDatCho.NgayDat as "Ngày đặt", PhieuDatCho.SoGhe as "Số ghế"
FROM KhachHang, PhieuDatCho, VeChuyenBay,ChuyenBay
WHERE KhachHang.MaKH = PhieuDatCho.MaKH and PhieuDatCho.MaPhieu = VeChuyenBay.MaPhieu and PhieuDatCho.MaChuyenBay = ChuyenBay.MaChuyenBay
and CMND = @CMND and VeChuyenBay.MaVeChuyenBay = @MaVeChuyenBay