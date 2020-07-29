ALTER TABLE [dbo].[VeChuyenBay]  WITH CHECK ADD  CONSTRAINT [FK_VeChuyenBay_PhieuDatCho] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PhieuDatCho] ([MaPhieu])
GO

ALTER TABLE [dbo].[VeChuyenBay] CHECK CONSTRAINT [FK_VeChuyenBay_PhieuDatCho]