CREATE PROCEDURE [dbo].[SelectVeMayBayXuatPhat]
@NgayGio date,
@ThoiGianBay time,
@SogheHang1 int,
@SogheHang2 int,
@SanBayDi nvarchar(50),
@SanBayDen nvarchar(50)
as
SELECT ve.MaChuyenBay as "Mã chuyến bay", count(MaVeChuyenBay) as "Số vé trống", NgayGio as "Ngày bay",ThoiGianBay as "Thời gian", SanBayDi as "Sân bay đi", SanBayDen as "Sân bay đến", SanBayTrungGian as "Sân bay trung gian", ThoiGianDung as "Thời gian dừng"
FROM TuyenBay, ChuyenBay, ChiTietChuyenBay CT, VeChuyenBay ve
WHERE TuyenBay.MaTuyenBay = ChuyenBay.MaTuyenBay AND ChuyenBay.MaChiTietChuyenBay = CT.MaChiTietChuyenBay AND ve.MaChuyenBay = ChuyenBay.MaChuyenBay 
AND @NgayGio < NgayGio AND @ThoiGianBay < ThoiGianBay AND @SogheHang1 <= SoGheHang1 AND @SoGheHang2 <= SoGheHang2 AND @SanBayDi =SanBayDi AND @SanBayDen = SanBayDen AND TinhTrangVe = 'Trong'
GROUP BY ve.MaChuyenBay, NgayGio,ThoiGianBay,SanBayDi,SanBayDen,SoGheHang1,SoGheHang2,SanBayTrungGian,ThoiGianDung
HAVING count(MaVeChuyenBay) > @SogheHang1 and count(MaVeChuyenBay) > @SogheHang2