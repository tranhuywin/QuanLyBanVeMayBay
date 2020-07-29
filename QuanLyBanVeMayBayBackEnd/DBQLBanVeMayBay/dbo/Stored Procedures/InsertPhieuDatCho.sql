CREATE PROC [dbo].[InsertPhieuDatCho]
@MaPhieu nchar(10),
@SoGhe nchar(10),
@MaKH nchar(10),
@MaChuyenBay nchar(10)
as
Insert into PhieuDatCho(MaPhieu, NgayDat, SoGhe, MaKH, MaChuyenBay) Values(@MaPhieu, GETDATE(), @SoGhe, @MaKH, @MaChuyenBay)