CREATE procedure [dbo].[SelectTheoMaChuyenBay]
@MaChuyenBay nchar(10)
AS
SELECT MaChuyenBay, SanBayDi, SanBayDen, NgayGio, ThoiGianDung,SanBayTrungGian, TenMayBay, ThoiGianBay
FROM ChuyenBay, ChiTietChuyenBay, TuyenBay
WHERE ChuyenBay.MaChuyenBay = @MaChuyenBay and ChuyenBay.MaChiTietChuyenBay = ChiTietChuyenBay.MaChiTietChuyenBay