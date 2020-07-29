create procedure [dbo].[EditChuyenBay]
@MaChuyenBay nchar(10),
@SanBayDi nvarchar(50),
@SanBayDen nvarchar(50),
@NgayGio date,
@ThoiGianDung date,
@SanBayTrungGian nvarchar(50),
@ThoiGianBay time(7),
@TenMayBay nvarchar(50)
AS 
Update TuyenBay
Set SanBayDi = @SanBayDi, SanBayDen = @SanBayDen
from TuyenBay
inner join ChuyenBay
on (TuyenBay.MaTuyenBay = ChuyenBay.MaTuyenBay)
WHERE ChuyenBay.MaChuyenBay=@MaChuyenBay
Update ChuyenBay 
Set NgayGio = @NgayGio,ThoiGianBay = @ThoiGianBay
from ChuyenBay
Update ChiTietChuyenBay
Set SanBayTrungGian = @SanBayTrungGian, ThoiGianDung = @ThoiGianDung
from ChiTietChuyenBay
inner join ChuyenBay
on (ChiTietChuyenBay.MaChiTietChuyenBay = ChuyenBay.MaChiTietChuyenBay)
WHERE ChuyenBay.MaChuyenBay=@MaChuyenBay