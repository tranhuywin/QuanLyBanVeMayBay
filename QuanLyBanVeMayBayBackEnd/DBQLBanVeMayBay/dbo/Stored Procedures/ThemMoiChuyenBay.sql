CREATE procedure [dbo].[ThemMoiChuyenBay]
@cttbMaChiTietChuyenBay nchar(10),
@tbMaTuyenBay nchar(10),
@MaChuyenBay nchar(10),
@SanBayDi nvarchar(50),
@SanBayDen nvarchar(50),
@NgayGio date,
@ThoiGianDung date,
@ThoiGianBay time(7),
@SanBayTrungGian nvarchar(50),
@TenMayBay nvarchar(50)
AS 
begin
INSERT INTO ChiTietChuyenBay(MaChiTietChuyenBay, SanBayTrungGian,ThoiGianDung)
		VALUES(@cttbMaChiTietChuyenBay,@SanBayTrungGian,@ThoiGianDung)
INSERT INTO TuyenBay(MaTuyenBay, SanBayDi,SanBayDen)
		VALUES(@tbMaTuyenBay,@SanBayDi, @SanBayDen)
INSERT INTO ChuyenBay(MaChuyenBay,ThoiGianBay, MaChiTietChuyenBay, MaTuyenBay , TenMayBay, NgayGio)
		VALUES(@MaChuyenBay,@ThoiGianBay, @cttbMaChiTietChuyenBay, @tbMaTuyenBay, @TenMayBay, @NgayGio)
end