ALTER TABLE [dbo].[ChuyenBay]  WITH CHECK ADD  CONSTRAINT [FK_ChuyenBay_TuyenBay] FOREIGN KEY([MaTuyenBay])
REFERENCES [dbo].[TuyenBay] ([MaTuyenBay])
GO

ALTER TABLE [dbo].[ChuyenBay] CHECK CONSTRAINT [FK_ChuyenBay_TuyenBay]