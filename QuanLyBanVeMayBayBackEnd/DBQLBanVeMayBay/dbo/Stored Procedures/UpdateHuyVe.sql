Create Proc [dbo].[UpdateHuyVe]
@MaVeChuyenBay nchar(10)
as
UPDATE VeChuyenBay
SET TinhTrangVe = 'Trong'
FROM VeChuyenBay
WHERE MaVeChuyenBay = @MaVeChuyenBay