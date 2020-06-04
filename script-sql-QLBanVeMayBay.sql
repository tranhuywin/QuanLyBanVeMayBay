USE [master]
GO
/****** Object:  Database [QLBanVeMayBay]    Script Date: 6/4/2020 11:34:38 AM ******/
CREATE DATABASE [QLBanVeMayBay]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLBanVeMayBay', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLBanVeMayBay.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLBanVeMayBay_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLBanVeMayBay_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLBanVeMayBay] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLBanVeMayBay].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLBanVeMayBay] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLBanVeMayBay] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLBanVeMayBay] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLBanVeMayBay] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLBanVeMayBay] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLBanVeMayBay] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLBanVeMayBay] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLBanVeMayBay] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLBanVeMayBay] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLBanVeMayBay] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLBanVeMayBay] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLBanVeMayBay] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLBanVeMayBay] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLBanVeMayBay] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLBanVeMayBay] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLBanVeMayBay] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLBanVeMayBay] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLBanVeMayBay] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLBanVeMayBay] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLBanVeMayBay] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLBanVeMayBay] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLBanVeMayBay] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLBanVeMayBay] SET RECOVERY FULL 
GO
ALTER DATABASE [QLBanVeMayBay] SET  MULTI_USER 
GO
ALTER DATABASE [QLBanVeMayBay] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLBanVeMayBay] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLBanVeMayBay] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLBanVeMayBay] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLBanVeMayBay] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLBanVeMayBay', N'ON'
GO
ALTER DATABASE [QLBanVeMayBay] SET QUERY_STORE = OFF
GO
USE [QLBanVeMayBay]
GO
/****** Object:  Table [dbo].[ChiTietChuyenBay]    Script Date: 6/4/2020 11:34:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietChuyenBay](
	[MaChiTietChuyenBay] [nchar](10) NOT NULL,
	[SanBayTrungGian] [nvarchar](50) NULL,
	[ThoiGianDung] [date] NULL,
 CONSTRAINT [PK_ChiTietChuyenBay] PRIMARY KEY CLUSTERED 
(
	[MaChiTietChuyenBay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChuyenBay]    Script Date: 6/4/2020 11:34:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuyenBay](
	[MaChuyenBay] [nchar](10) NOT NULL,
	[NgayGio] [date] NULL,
	[ThoiGianBay] [date] NULL,
	[SoGheHang1] [int] NULL,
	[SoGheHang2] [int] NULL,
	[MaTuyenBay] [nchar](10) NULL,
	[MaChiTietChuyenBay] [nchar](10) NULL,
 CONSTRAINT [PK_ChuyenBay] PRIMARY KEY CLUSTERED 
(
	[MaChuyenBay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonGia]    Script Date: 6/4/2020 11:34:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonGia](
	[MaDonGia] [nchar](10) NOT NULL,
	[USD] [int] NULL,
	[VND] [int] NULL,
 CONSTRAINT [PK_DonGia] PRIMARY KEY CLUSTERED 
(
	[MaDonGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangVe]    Script Date: 6/4/2020 11:34:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangVe](
	[MaHV] [nchar](10) NOT NULL,
	[TenHV] [nvarchar](50) NULL,
	[MaVeChuyenBay] [nchar](10) NULL,
	[MaPhieu] [nchar](10) NULL,
 CONSTRAINT [PK_HangVe] PRIMARY KEY CLUSTERED 
(
	[MaHV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 6/4/2020 11:34:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [nchar](10) NOT NULL,
	[NgayLap] [date] NULL,
	[ThanhTien] [int] NOT NULL,
	[Id] [nchar](10) NULL,
	[MaKH] [nchar](10) NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 6/4/2020 11:34:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nchar](10) NOT NULL,
	[HoTenKH] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[GioiTinh] [nchar](10) NULL,
	[CMND] [nvarchar](50) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MayBay]    Script Date: 6/4/2020 11:34:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MayBay](
	[MaMayBay] [nchar](10) NOT NULL,
	[TenMayBay] [nvarchar](50) NULL,
	[MaChuyenBay] [nchar](10) NULL,
 CONSTRAINT [PK_MayBay] PRIMARY KEY CLUSTERED 
(
	[MaMayBay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuDatCho]    Script Date: 6/4/2020 11:34:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuDatCho](
	[MaPhieu] [nchar](10) NOT NULL,
	[NgayDat] [date] NULL,
	[SoGhe] [nchar](10) NULL,
	[MaKH] [nchar](10) NULL,
	[MaChuyenBay] [nchar](10) NULL,
 CONSTRAINT [PK_PhieuDatCho] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanBay]    Script Date: 6/4/2020 11:34:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanBay](
	[MaSanBay] [nchar](10) NOT NULL,
	[TenSanBay] [nvarchar](50) NULL,
 CONSTRAINT [PK_SanBay] PRIMARY KEY CLUSTERED 
(
	[MaSanBay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 6/4/2020 11:34:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[Id] [nchar](10) NOT NULL,
	[User] [nchar](10) NULL,
	[Password] [nchar](10) NULL,
	[ChucVu] [int] NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TuyenBay]    Script Date: 6/4/2020 11:34:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TuyenBay](
	[MaTuyenBay] [nchar](10) NOT NULL,
	[SanBayDi] [nvarchar](50) NULL,
	[SanBayDen] [nvarchar](50) NULL,
	[MaSanbay] [nchar](10) NULL,
 CONSTRAINT [PK_TuyenBay] PRIMARY KEY CLUSTERED 
(
	[MaTuyenBay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VeChuyenBay]    Script Date: 6/4/2020 11:34:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VeChuyenBay](
	[MaVeChuyenBay] [nchar](10) NOT NULL,
	[TinhTrangVe] [nvarchar](50) NULL,
	[MaChuyenBay] [nchar](10) NULL,
	[MaDonGia] [nchar](10) NULL,
 CONSTRAINT [PK_VeChuyenBay] PRIMARY KEY CLUSTERED 
(
	[MaVeChuyenBay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChuyenBay]  WITH CHECK ADD  CONSTRAINT [FK_ChuyenBay_ChiTietChuyenBay] FOREIGN KEY([MaChiTietChuyenBay])
REFERENCES [dbo].[ChiTietChuyenBay] ([MaChiTietChuyenBay])
GO
ALTER TABLE [dbo].[ChuyenBay] CHECK CONSTRAINT [FK_ChuyenBay_ChiTietChuyenBay]
GO
ALTER TABLE [dbo].[ChuyenBay]  WITH CHECK ADD  CONSTRAINT [FK_ChuyenBay_TuyenBay] FOREIGN KEY([MaTuyenBay])
REFERENCES [dbo].[TuyenBay] ([MaTuyenBay])
GO
ALTER TABLE [dbo].[ChuyenBay] CHECK CONSTRAINT [FK_ChuyenBay_TuyenBay]
GO
ALTER TABLE [dbo].[HangVe]  WITH CHECK ADD  CONSTRAINT [FK_HangVe_PhieuDatCho] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PhieuDatCho] ([MaPhieu])
GO
ALTER TABLE [dbo].[HangVe] CHECK CONSTRAINT [FK_HangVe_PhieuDatCho]
GO
ALTER TABLE [dbo].[HangVe]  WITH CHECK ADD  CONSTRAINT [FK_HangVe_VeChuyenBay] FOREIGN KEY([MaVeChuyenBay])
REFERENCES [dbo].[VeChuyenBay] ([MaVeChuyenBay])
GO
ALTER TABLE [dbo].[HangVe] CHECK CONSTRAINT [FK_HangVe_VeChuyenBay]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_TaiKhoan] FOREIGN KEY([Id])
REFERENCES [dbo].[TaiKhoan] ([Id])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_TaiKhoan]
GO
ALTER TABLE [dbo].[MayBay]  WITH CHECK ADD  CONSTRAINT [FK_MayBay_ChuyenBay] FOREIGN KEY([MaChuyenBay])
REFERENCES [dbo].[ChuyenBay] ([MaChuyenBay])
GO
ALTER TABLE [dbo].[MayBay] CHECK CONSTRAINT [FK_MayBay_ChuyenBay]
GO
ALTER TABLE [dbo].[PhieuDatCho]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDatCho_ChuyenBay] FOREIGN KEY([MaChuyenBay])
REFERENCES [dbo].[ChuyenBay] ([MaChuyenBay])
GO
ALTER TABLE [dbo].[PhieuDatCho] CHECK CONSTRAINT [FK_PhieuDatCho_ChuyenBay]
GO
ALTER TABLE [dbo].[PhieuDatCho]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDatCho_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[PhieuDatCho] CHECK CONSTRAINT [FK_PhieuDatCho_KhachHang]
GO
ALTER TABLE [dbo].[TuyenBay]  WITH CHECK ADD  CONSTRAINT [FK_TuyenBay_SanBay] FOREIGN KEY([MaSanbay])
REFERENCES [dbo].[SanBay] ([MaSanBay])
GO
ALTER TABLE [dbo].[TuyenBay] CHECK CONSTRAINT [FK_TuyenBay_SanBay]
GO
ALTER TABLE [dbo].[VeChuyenBay]  WITH CHECK ADD  CONSTRAINT [FK_VeChuyenBay_ChuyenBay] FOREIGN KEY([MaChuyenBay])
REFERENCES [dbo].[ChuyenBay] ([MaChuyenBay])
GO
ALTER TABLE [dbo].[VeChuyenBay] CHECK CONSTRAINT [FK_VeChuyenBay_ChuyenBay]
GO
ALTER TABLE [dbo].[VeChuyenBay]  WITH CHECK ADD  CONSTRAINT [FK_VeChuyenBay_DonGia] FOREIGN KEY([MaDonGia])
REFERENCES [dbo].[DonGia] ([MaDonGia])
GO
ALTER TABLE [dbo].[VeChuyenBay] CHECK CONSTRAINT [FK_VeChuyenBay_DonGia]
GO
USE [master]
GO
ALTER DATABASE [QLBanVeMayBay] SET  READ_WRITE 
GO
