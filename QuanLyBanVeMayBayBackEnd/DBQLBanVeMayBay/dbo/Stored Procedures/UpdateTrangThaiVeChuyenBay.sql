CREATE PROC [dbo].[UpdateTrangThaiVeChuyenBay]
@MaChuyenBay nchar(10),
@MaPhieu  nchar(10),
@SoGhe int
AS
UPDATE VeChuyenBay
SET TinhTrangVe = 'DaDat', VeChuyenBay.MaPHieu = @MaPhieu
FROM VeChuyenBay
WHERE MaVeChuyenBay = (SELECT  TOP(@SoGhe) MaVeChuyenBay
					from VeChuyenBay, PhieuDatCho
					Where VeChuyenBay.MaChuyenBay = PhieuDatCho.MaChuyenBay AND PhieuDatCho.MaChuyenBay = @MaChuyenBay
					)