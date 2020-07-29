ALTER TABLE [dbo].[VeChuyenBay]  WITH CHECK ADD  CONSTRAINT [FK_VeChuyenBay_DonGia] FOREIGN KEY([MaDonGia])
REFERENCES [dbo].[DonGia] ([MaDonGia])
GO

ALTER TABLE [dbo].[VeChuyenBay] CHECK CONSTRAINT [FK_VeChuyenBay_DonGia]