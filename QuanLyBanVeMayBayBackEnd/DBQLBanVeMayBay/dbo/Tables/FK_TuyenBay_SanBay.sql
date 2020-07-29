ALTER TABLE [dbo].[TuyenBay]  WITH CHECK ADD  CONSTRAINT [FK_TuyenBay_SanBay] FOREIGN KEY([MaSanbay])
REFERENCES [dbo].[SanBay] ([MaSanBay])
GO

ALTER TABLE [dbo].[TuyenBay] CHECK CONSTRAINT [FK_TuyenBay_SanBay]