ALTER TABLE [dbo].[ChuyenBay]  WITH CHECK ADD  CONSTRAINT [FK_ChuyenBay_PhieuDatCho] FOREIGN KEY([MaChuyenBay])
REFERENCES [dbo].[PhieuDatCho] ([MaPhieu])
GO

ALTER TABLE [dbo].[ChuyenBay] CHECK CONSTRAINT [FK_ChuyenBay_PhieuDatCho]