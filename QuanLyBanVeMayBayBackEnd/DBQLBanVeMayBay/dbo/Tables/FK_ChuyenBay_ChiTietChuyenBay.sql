ALTER TABLE [dbo].[ChuyenBay]  WITH CHECK ADD  CONSTRAINT [FK_ChuyenBay_ChiTietChuyenBay] FOREIGN KEY([MaChiTietChuyenBay])
REFERENCES [dbo].[ChiTietChuyenBay] ([MaChiTietChuyenBay])
GO

ALTER TABLE [dbo].[ChuyenBay] CHECK CONSTRAINT [FK_ChuyenBay_ChiTietChuyenBay]