
USE [master]
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

/****** Object:  Table [dbo].[ChiTietChuyenBay]    Script Date: 7/28/2020 3:48:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[ChuyenBay]    Script Date: 7/28/2020 3:48:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[DonGia]    Script Date: 7/28/2020 3:48:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[HoaDon]    Script Date: 7/28/2020 3:48:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[KhachHang]    Script Date: 7/28/2020 3:48:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[PhieuDatCho]    Script Date: 7/28/2020 3:48:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[SanBay]    Script Date: 7/28/2020 3:48:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 7/28/2020 3:48:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[TuyenBay]    Script Date: 7/28/2020 3:48:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[VeChuyenBay]    Script Date: 7/28/2020 3:48:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

INSERT [dbo].[ChiTietChuyenBay] ([MaChiTietChuyenBay], [SanBayTrungGian], [ThoiGianDung]) VALUES (N'1         ', N'Da Nang', CAST(N'2020-07-02' AS Date))
GO

INSERT [dbo].[ChiTietChuyenBay] ([MaChiTietChuyenBay], [SanBayTrungGian], [ThoiGianDung]) VALUES (N'2         ', N'Da Nang', CAST(N'2020-07-02' AS Date))
GO

INSERT [dbo].[ChuyenBay] ([MaChuyenBay], [NgayGio], [ThoiGianBay], [SoGheHang1], [SoGheHang2], [MaTuyenBay], [MaChiTietChuyenBay], [TenMayBay]) VALUES (N'1         ', CAST(N'2021-12-31' AS Date), CAST(N'01:01:01' AS Time), 100, 100, N'1         ', N'1         ', NULL)
GO

INSERT [dbo].[ChuyenBay] ([MaChuyenBay], [NgayGio], [ThoiGianBay], [SoGheHang1], [SoGheHang2], [MaTuyenBay], [MaChiTietChuyenBay], [TenMayBay]) VALUES (N'2         ', CAST(N'2322-12-31' AS Date), CAST(N'01:01:01' AS Time), 100, 100, N'2         ', N'2         ', NULL)
GO

INSERT [dbo].[DonGia] ([MaDonGia], [USD], [VND]) VALUES (N'1         ', 100, 2000000)
GO

INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [Email], [GioiTinh], [CMND]) VALUES (N'1         ', N'admin', N'12345678', N'admin@gmail.com', N'Nam       ', N'12345678')
GO

INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [Email], [GioiTinh], [CMND]) VALUES (N'20f204acdb', N'1', N'123', N'1', N'Nam       ', N'123')
GO

INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [Email], [GioiTinh], [CMND]) VALUES (N'21a5258fd6', N'test5', N'123', N'test5', N'Nam       ', N'123')
GO

INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [Email], [GioiTinh], [CMND]) VALUES (N'278994f5ab', N'test7', N'123', N'test7', N'Nữ        ', N'123')
GO

INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [Email], [GioiTinh], [CMND]) VALUES (N'2bc9611723', N'abc', N'1234', N'123', N'          ', N'12345')
GO

INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [Email], [GioiTinh], [CMND]) VALUES (N'2da335b17b', N'test2', N'1234', N'test2', N'Nữ        ', N'1234')
GO

INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [Email], [GioiTinh], [CMND]) VALUES (N'3eb0c8abca', N'abc', N'1', N'1', N'Nam       ', N'1')
GO

INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [Email], [GioiTinh], [CMND]) VALUES (N'42b4c9b35b', N'a', N'123', N'a', N'Nam       ', N'123')
GO

INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [Email], [GioiTinh], [CMND]) VALUES (N'4d0568b98e', N'abc', N'123', N'ab123', N'Nam       ', N'12345')
GO

INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [Email], [GioiTinh], [CMND]) VALUES (N'5e226dbc47', N'test5', N'123', N'test5', N'Nam       ', N'123')
GO

INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [Email], [GioiTinh], [CMND]) VALUES (N'70a2df29b0', N'a', N'123', N'a', N'Nam       ', N'123')
GO

INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [Email], [GioiTinh], [CMND]) VALUES (N'747aa76689', N'abc1', N'1234', N'123', N'Nam       ', N'12345')
GO

INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [Email], [GioiTinh], [CMND]) VALUES (N'7e525d5566', N'test6', N'123', N'test6', N'Nam       ', N'123')
GO

INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [Email], [GioiTinh], [CMND]) VALUES (N'80922616ed', N'testupdatetrangthai', N'123', N'testupdatetrangthai', N'Nam       ', N'12344')
GO

INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [Email], [GioiTinh], [CMND]) VALUES (N'8550e5edb3', N'abc', N'1234', N'123', N'Nam       ', N'12345')
GO

INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [Email], [GioiTinh], [CMND]) VALUES (N'8c9f41fe5e', N'test5', N'123', N'test5', N'Nam       ', N'123')
GO

INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [Email], [GioiTinh], [CMND]) VALUES (N'8fdd63b9ff', N'28', N'28', N'28', N'Nam       ', N'28')
GO

INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [Email], [GioiTinh], [CMND]) VALUES (N'94bafbed11', N'test6', N'123', N'test6', N'Nam       ', N'123')
GO

INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [Email], [GioiTinh], [CMND]) VALUES (N'9a3526af18', N'q', N'123', N'q', N'Nam       ', N'123')
GO

INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [Email], [GioiTinh], [CMND]) VALUES (N'b7c78bc5d1', N'test7', N'123', N'test7', N'Nam       ', N'123')
GO

INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [Email], [GioiTinh], [CMND]) VALUES (N'd1e2a2d779', N'test4', N'123', N'test4', N'Nữ        ', N'123')
GO

INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [Email], [GioiTinh], [CMND]) VALUES (N'd644312629', N'test3', N'123', N'test3', N'Nữ        ', N'123')
GO

INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [Email], [GioiTinh], [CMND]) VALUES (N'e5ed7fa2ee', N'1', N'123', N'1', N'Nam       ', N'123')
GO

INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [Email], [GioiTinh], [CMND]) VALUES (N'f781c7ccc2', N'abcd', N'123456', N'abcd', N'Nam       ', N'1234567')
GO

INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [Email], [GioiTinh], [CMND]) VALUES (N'ffe2484c46', N'f', N'123', N'f', N'Nam       ', N'123')
GO

INSERT [dbo].[PhieuDatCho] ([MaPhieu], [NgayDat], [SoGhe], [MaKH], [MaChuyenBay]) VALUES (N'1         ', CAST(N'2020-07-02' AS Date), N'2         ', N'2bc9611723', N'1         ')
GO

INSERT [dbo].[PhieuDatCho] ([MaPhieu], [NgayDat], [SoGhe], [MaKH], [MaChuyenBay]) VALUES (N'2         ', CAST(N'2020-07-02' AS Date), N'3         ', N'8550e5edb3', N'2         ')
GO

INSERT [dbo].[PhieuDatCho] ([MaPhieu], [NgayDat], [SoGhe], [MaKH], [MaChuyenBay]) VALUES (N'3d59214a27', CAST(N'2020-07-28' AS Date), N'1         ', N'8fdd63b9ff', N'1         ')
GO

INSERT [dbo].[PhieuDatCho] ([MaPhieu], [NgayDat], [SoGhe], [MaKH], [MaChuyenBay]) VALUES (N'405910d213', CAST(N'2020-07-23' AS Date), N'1         ', N'3eb0c8abca', N'1         ')
GO

INSERT [dbo].[PhieuDatCho] ([MaPhieu], [NgayDat], [SoGhe], [MaKH], [MaChuyenBay]) VALUES (N'cde308d704', CAST(N'2020-07-06' AS Date), N'1         ', N'ffe2484c46', N'1         ')
GO

INSERT [dbo].[PhieuDatCho] ([MaPhieu], [NgayDat], [SoGhe], [MaKH], [MaChuyenBay]) VALUES (N'e318b4b4fe', CAST(N'2020-07-06' AS Date), N'1         ', N'7e525d5566', N'1         ')
GO

INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'1         ', N'Tan Son Nhat, Ho Chi Minh')
GO

INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'2         ', N'Noi Bai, Ha Noi')
GO

INSERT [dbo].[TaiKhoan] ([Id], [User], [Password], [ChucVu], [NgaySinh], [CMND], [DiaChi], [HoTen]) VALUES (N'1         ', N'admin     ', N'admin     ', 1, CAST(N'2000-01-01' AS Date), N'123456789', N'Hồ Chí Minh', N'Admin')
GO

INSERT [dbo].[TaiKhoan] ([Id], [User], [Password], [ChucVu], [NgaySinh], [CMND], [DiaChi], [HoTen]) VALUES (N'3afd40d084', N'test      ', N'test      ', 0, CAST(N'2020-07-24' AS Date), N'123', N'123', N'test')
GO

INSERT [dbo].[TuyenBay] ([MaTuyenBay], [SanBayDi], [SanBayDen], [MaSanbay]) VALUES (N'1         ', N'Tan Son Nhat, Ho Chi Minh', N'Noi Bai, Ha Noi', N'1         ')
GO

INSERT [dbo].[TuyenBay] ([MaTuyenBay], [SanBayDi], [SanBayDen], [MaSanbay]) VALUES (N'2         ', N'Noi Bai, Ha Noi', N'Tan Son Nhat, Ho Chi Minh', N'1         ')
GO

INSERT [dbo].[VeChuyenBay] ([MaVeChuyenBay], [TinhTrangVe], [MaChuyenBay], [MaDonGia], [MaPhieu], [HangVe]) VALUES (N'1         ', N'DaDat', N'1         ', N'1         ', N'3d59214a27', NULL)
GO

INSERT [dbo].[VeChuyenBay] ([MaVeChuyenBay], [TinhTrangVe], [MaChuyenBay], [MaDonGia], [MaPhieu], [HangVe]) VALUES (N'2         ', N'Trong', N'1         ', N'1         ', N'1         ', NULL)
GO

INSERT [dbo].[VeChuyenBay] ([MaVeChuyenBay], [TinhTrangVe], [MaChuyenBay], [MaDonGia], [MaPhieu], [HangVe]) VALUES (N'3         ', N'Trong', N'1         ', N'1         ', N'2         ', NULL)
GO

INSERT [dbo].[VeChuyenBay] ([MaVeChuyenBay], [TinhTrangVe], [MaChuyenBay], [MaDonGia], [MaPhieu], [HangVe]) VALUES (N'4         ', N'Trong', N'2         ', N'1         ', NULL, NULL)
GO

INSERT [dbo].[VeChuyenBay] ([MaVeChuyenBay], [TinhTrangVe], [MaChuyenBay], [MaDonGia], [MaPhieu], [HangVe]) VALUES (N'5         ', N'Trong', N'2         ', N'1         ', NULL, NULL)
GO

/****** Object:  StoredProcedure [dbo].[CreateTaiKhoan]    Script Date: 7/28/2020 3:48:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[EditChuyenBay]    Script Date: 7/28/2020 3:48:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[INSERT_STEP3_KHACHHANG]    Script Date: 7/28/2020 3:48:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[InsertPhieuDatCho]    Script Date: 7/28/2020 3:48:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[SelectAllSanBay]    Script Date: 7/28/2020 3:48:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[SelectChiTietTaiKhoan]    Script Date: 7/28/2020 3:48:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[SelectKhachHang]    Script Date: 7/28/2020 3:48:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[SelectKhachHangTheoTenVaCMND]    Script Date: 7/28/2020 3:48:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[SelectKhachHangVaVeChuyenBay]    Script Date: 7/28/2020 3:48:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[SelectTaiKhoan]    Script Date: 7/28/2020 3:48:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[SelectTheoMaChuyenBay]    Script Date: 7/28/2020 3:48:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[SelectVeMayBayDaDat]    Script Date: 7/28/2020 3:48:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[SelectVeMayBayXuatPhat]    Script Date: 7/28/2020 3:48:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[ThemMoiChuyenBay]    Script Date: 7/28/2020 3:48:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[ThemMoiKhachHang]    Script Date: 7/28/2020 3:48:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[UpdateChiTietTaiKhoan]    Script Date: 7/28/2020 3:48:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[UpdateHuyVe]    Script Date: 7/28/2020 3:48:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[UpdateKhachHang]    Script Date: 7/28/2020 3:48:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[UpdateTrangThaiVeChuyenBay]    Script Date: 7/28/2020 3:48:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[XoaKH]    Script Date: 7/28/2020 3:48:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

USE [master]
GO

ALTER DATABASE [QLBanVeMayBay] SET  READ_WRITE
GO

/****** Object:  Database [QLBanVeMayBay]    Script Date: 7/28/2020 3:48:21 PM ******/
CREATE DATABASE [QLBanVeMayBay]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLBanVeMayBay', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLBanVeMayBay.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLBanVeMayBay_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLBanVeMayBay_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT

GO

--Syntax Error: Expected DEFAULT_FULLTEXT_LANGUAGE but encountered CATALOG_COLLATION instead.
--/****** Object:  Database [QLBanVeMayBay]    Script Date: 7/28/2020 3:48:21 PM ******/
--CREATE DATABASE [QLBanVeMayBay]
-- CONTAINMENT = NONE
-- ON  PRIMARY 
--( NAME = N'QLBanVeMayBay', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLBanVeMayBay.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
-- LOG ON 
--( NAME = N'QLBanVeMayBay_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLBanVeMayBay_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
-- WITH CATALOG_COLLATION = DATABASE_DEFAULT

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

--Syntax Error: Incorrect syntax near OPTIMIZE_FOR_SEQUENTIAL_KEY.
--CREATE TABLE [dbo].[ChiTietChuyenBay](
--	[MaChiTietChuyenBay] [nchar](10) NOT NULL,
--	[SanBayTrungGian] [nvarchar](50) NULL,
--	[ThoiGianDung] [date] NULL,
-- CONSTRAINT [PK_ChiTietChuyenBay] PRIMARY KEY CLUSTERED 
--(
--	[MaChiTietChuyenBay] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]

GO

CREATE TABLE [dbo].[ChuyenBay](
	[MaChuyenBay] [nchar](10) NOT NULL,
	[NgayGio] [date] NULL,
	[ThoiGianBay] [time](7) NULL,
	[SoGheHang1] [int] NULL,
	[SoGheHang2] [int] NULL,
	[MaTuyenBay] [nchar](10) NULL,
	[MaChiTietChuyenBay] [nchar](10) NULL,
	[TenMayBay] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChuyenBay] PRIMARY KEY CLUSTERED 
(
	[MaChuyenBay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO

--Syntax Error: Incorrect syntax near OPTIMIZE_FOR_SEQUENTIAL_KEY.
--CREATE TABLE [dbo].[ChuyenBay](
--	[MaChuyenBay] [nchar](10) NOT NULL,
--	[NgayGio] [date] NULL,
--	[ThoiGianBay] [time](7) NULL,
--	[SoGheHang1] [int] NULL,
--	[SoGheHang2] [int] NULL,
--	[MaTuyenBay] [nchar](10) NULL,
--	[MaChiTietChuyenBay] [nchar](10) NULL,
--	[TenMayBay] [nvarchar](50) NULL,
-- CONSTRAINT [PK_ChuyenBay] PRIMARY KEY CLUSTERED 
--(
--	[MaChuyenBay] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]

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

--Syntax Error: Incorrect syntax near OPTIMIZE_FOR_SEQUENTIAL_KEY.
--CREATE TABLE [dbo].[DonGia](
--	[MaDonGia] [nchar](10) NOT NULL,
--	[USD] [int] NULL,
--	[VND] [int] NULL,
-- CONSTRAINT [PK_DonGia] PRIMARY KEY CLUSTERED 
--(
--	[MaDonGia] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]

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

--Syntax Error: Incorrect syntax near OPTIMIZE_FOR_SEQUENTIAL_KEY.
--CREATE TABLE [dbo].[HoaDon](
--	[MaHoaDon] [nchar](10) NOT NULL,
--	[NgayLap] [date] NULL,
--	[ThanhTien] [int] NOT NULL,
--	[Id] [nchar](10) NULL,
--	[MaKH] [nchar](10) NULL,
-- CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
--(
--	[MaHoaDon] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]

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

--Syntax Error: Incorrect syntax near OPTIMIZE_FOR_SEQUENTIAL_KEY.
--CREATE TABLE [dbo].[KhachHang](
--	[MaKH] [nchar](10) NOT NULL,
--	[HoTenKH] [nvarchar](50) NULL,
--	[SDT] [nvarchar](50) NULL,
--	[Email] [nvarchar](50) NULL,
--	[GioiTinh] [nchar](10) NULL,
--	[CMND] [nvarchar](50) NULL,
-- CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
--(
--	[MaKH] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]

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

--Syntax Error: Incorrect syntax near OPTIMIZE_FOR_SEQUENTIAL_KEY.
--CREATE TABLE [dbo].[PhieuDatCho](
--	[MaPhieu] [nchar](10) NOT NULL,
--	[NgayDat] [date] NULL,
--	[SoGhe] [nchar](10) NULL,
--	[MaKH] [nchar](10) NULL,
--	[MaChuyenBay] [nchar](10) NULL,
-- CONSTRAINT [PK_PhieuDatCho] PRIMARY KEY CLUSTERED 
--(
--	[MaPhieu] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]

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

--Syntax Error: Incorrect syntax near OPTIMIZE_FOR_SEQUENTIAL_KEY.
--CREATE TABLE [dbo].[SanBay](
--	[MaSanBay] [nchar](10) NOT NULL,
--	[TenSanBay] [nvarchar](50) NULL,
-- CONSTRAINT [PK_SanBay] PRIMARY KEY CLUSTERED 
--(
--	[MaSanBay] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]

GO

CREATE TABLE [dbo].[TaiKhoan](
	[Id] [nchar](10) NOT NULL,
	[User] [nchar](10) NULL,
	[Password] [nchar](10) NULL,
	[ChucVu] [int] NULL,
	[NgaySinh] [date] NULL,
	[CMND] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[HoTen] [nvarchar](50) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO

--Syntax Error: Incorrect syntax near OPTIMIZE_FOR_SEQUENTIAL_KEY.
--CREATE TABLE [dbo].[TaiKhoan](
--	[Id] [nchar](10) NOT NULL,
--	[User] [nchar](10) NULL,
--	[Password] [nchar](10) NULL,
--	[ChucVu] [int] NULL,
--	[NgaySinh] [date] NULL,
--	[CMND] [nvarchar](50) NULL,
--	[DiaChi] [nvarchar](50) NULL,
--	[HoTen] [nvarchar](50) NULL,
-- CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
--(
--	[Id] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]

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

--Syntax Error: Incorrect syntax near OPTIMIZE_FOR_SEQUENTIAL_KEY.
--CREATE TABLE [dbo].[TuyenBay](
--	[MaTuyenBay] [nchar](10) NOT NULL,
--	[SanBayDi] [nvarchar](50) NULL,
--	[SanBayDen] [nvarchar](50) NULL,
--	[MaSanbay] [nchar](10) NULL,
-- CONSTRAINT [PK_TuyenBay] PRIMARY KEY CLUSTERED 
--(
--	[MaTuyenBay] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]

GO

CREATE TABLE [dbo].[VeChuyenBay](
	[MaVeChuyenBay] [nchar](10) NOT NULL,
	[TinhTrangVe] [nvarchar](50) NULL,
	[MaChuyenBay] [nchar](10) NULL,
	[MaDonGia] [nchar](10) NULL,
	[MaPhieu] [nchar](10) NULL,
	[HangVe] [nvarchar](50) NULL,
 CONSTRAINT [PK_VeChuyenBay] PRIMARY KEY CLUSTERED 
(
	[MaVeChuyenBay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO

--Syntax Error: Incorrect syntax near OPTIMIZE_FOR_SEQUENTIAL_KEY.
--CREATE TABLE [dbo].[VeChuyenBay](
--	[MaVeChuyenBay] [nchar](10) NOT NULL,
--	[TinhTrangVe] [nvarchar](50) NULL,
--	[MaChuyenBay] [nchar](10) NULL,
--	[MaDonGia] [nchar](10) NULL,
--	[MaPhieu] [nchar](10) NULL,
--	[HangVe] [nvarchar](50) NULL,
-- CONSTRAINT [PK_VeChuyenBay] PRIMARY KEY CLUSTERED 
--(
--	[MaVeChuyenBay] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]



GO
