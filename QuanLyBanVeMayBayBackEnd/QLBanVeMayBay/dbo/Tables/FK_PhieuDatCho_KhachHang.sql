ALTER TABLE [dbo].[PhieuDatCho]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDatCho_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO

ALTER TABLE [dbo].[PhieuDatCho] CHECK CONSTRAINT [FK_PhieuDatCho_KhachHang]