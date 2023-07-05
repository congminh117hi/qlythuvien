USE [master]
GO
/****** Object:  Database [QuanLyThuVien]    Script Date: 05/24/2023 7:03:18 PM ******/
CREATE DATABASE [QuanLyThuVien]
GO
ALTER DATABASE [QuanLyThuVien] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyThuVien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyThuVien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyThuVien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyThuVien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyThuVien] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyThuVien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyThuVien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyThuVien] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyThuVien] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyThuVien] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyThuVien', N'ON'
GO
ALTER DATABASE [QuanLyThuVien] SET QUERY_STORE = OFF
GO
USE [QuanLyThuVien]
GO
/****** Object:  User [aaa]    Script Date: 05/24/2023 7:03:18 PM ******/
CREATE USER [aaa] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [aaa]
GO
/****** Object:  Table [dbo].[ChiTietMuon]    Script Date: 05/24/2023 7:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietMuon](
	[MaPM] [char](10) NOT NULL,
	[MaCS] [char](15) NOT NULL,
	[TinhTrang] [nvarchar](20) NULL,
 CONSTRAINT [PK_ChiTietMuon] PRIMARY KEY CLUSTERED 
(
	[MaPM] ASC,
	[MaCS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CuonSach]    Script Date: 05/24/2023 7:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuonSach](
	[MaCS] [char](15) NOT NULL,
	[MaTS] [varchar](10) NOT NULL,
 CONSTRAINT [PK__CuonSach__B235742D9CA18FE1] PRIMARY KEY CLUSTERED 
(
	[MaCS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuMuon]    Script Date: 05/24/2023 7:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuMuon](
	[MaPM] [char](10) NOT NULL,
	[NgayMuon] [date] NOT NULL,
	[NgayTra] [date] NOT NULL,
	[MaDG] [char](10) NOT NULL,
	[MaTT] [char](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_ThongKeChuaMuon]    Script Date: 05/24/2023 7:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_ThongKeChuaMuon]
AS	
SELECT sach.MaCS,
       sach.MaTS,
       c.MaPM,
       c.NgayMuon,
       c.NgayTra,
       c.MaDG,
       c.MaTT FROM (
SELECT a.MaCS, a.MaTS, b.MaPM FROM dbo.CuonSach AS a
LEFT JOIN dbo.ChiTietMuon AS b ON a.MaCS = b.MaCS) AS sach
LEFT JOIN dbo.PhieuMuon AS c ON c.MaPM = sach.MaPM
WHERE c.NgayTra <= GETDATE() OR c.MaPM IS NULL
GO
/****** Object:  Table [dbo].[ChiTietNhap]    Script Date: 05/24/2023 7:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietNhap](
	[MaPN] [char](10) NOT NULL,
	[MaTS] [varchar](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [int] NOT NULL,
 CONSTRAINT [PK_ChiTietNhap] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC,
	[MaTS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 05/24/2023 7:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocGia](
	[MaDG] [char](10) NOT NULL,
	[DocGiaID] [varchar](10) NULL,
	[TenDG] [nvarchar](30) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [nchar](5) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [char](15) NULL,
 CONSTRAINT [PK__DocGia__27258660FFC6C246] PRIMARY KEY CLUSTERED 
(
	[MaDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 05/24/2023 7:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[MaGV] [varchar](10) NOT NULL,
	[TenGV] [nvarchar](100) NULL,
	[DienThoai] [varchar](20) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[MaKhoa] [varchar](10) NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [nvarchar](50) NULL,
 CONSTRAINT [PK__GiaoVien__2725AEF3E0886432] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KeSach]    Script Date: 05/24/2023 7:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KeSach](
	[MaKe] [char](10) NOT NULL,
	[ChatLieu] [nvarchar](30) NULL,
	[SucChua] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 05/24/2023 7:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [varchar](10) NOT NULL,
	[TenKhoa] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 05/24/2023 7:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [varchar](10) NOT NULL,
	[MaKhoa] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NCC]    Script Date: 05/24/2023 7:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NCC](
	[MaNCC] [char](10) NOT NULL,
	[TenNCC] [nvarchar](30) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [char](13) NULL,
	[Email] [nchar](40) NULL,
 CONSTRAINT [PK__NCC__3A185DEB79758A68] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 05/24/2023 7:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[MaNguoiDung] [varchar](10) NOT NULL,
	[MaTT] [char](10) NULL,
	[MatKhau] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NXB]    Script Date: 05/24/2023 7:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NXB](
	[MaNXB] [char](10) NOT NULL,
	[TenNXB] [nchar](30) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [char](15) NULL,
	[Email] [char](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 05/24/2023 7:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyen](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaNguoiDung] [varchar](10) NULL,
	[MaQuyen] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 05/24/2023 7:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPN] [char](10) NOT NULL,
	[NgayLap] [date] NOT NULL,
	[MaTT] [char](10) NOT NULL,
	[MaNCC] [char](10) NOT NULL,
	[TongTien] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Quyen]    Script Date: 05/24/2023 7:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quyen](
	[MaQuyen] [varchar](10) NOT NULL,
	[XemSach] [bit] NULL,
	[SuaSach] [bit] NULL,
	[XoaSach] [bit] NULL,
	[ThemSach] [bit] NULL,
	[ThemNguoiDung] [bit] NULL,
	[XemNguoiDung] [bit] NULL,
	[SuaNguoiDung] [bit] NULL,
	[XoaNguoiDung] [bit] NULL,
	[XemMuonTra] [bit] NULL,
	[ThemMuonTra] [bit] NULL,
	[SuaMuonTra] [bit] NULL,
	[XoaMuonTra] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 05/24/2023 7:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSV] [varchar](10) NOT NULL,
	[TenSV] [nvarchar](100) NULL,
	[MaLop] [varchar](10) NULL,
	[DienThoai] [varchar](20) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [nchar](5) NULL,
 CONSTRAINT [PK__SinhVien__2725081AC4BB4EA6] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 05/24/2023 7:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGia](
	[MaTG] [char](10) NOT NULL,
	[TenTG] [nvarchar](30) NOT NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nchar](5) NULL,
	[QueQuan] [nvarchar](50) NULL,
 CONSTRAINT [PK_TacGia] PRIMARY KEY CLUSTERED 
(
	[MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThuThu]    Script Date: 05/24/2023 7:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThuThu](
	[MaTT] [char](10) NOT NULL,
	[TenTT] [nvarchar](30) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [nchar](5) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [char](15) NULL,
	[Chucvu] [nvarchar](30) NULL,
 CONSTRAINT [PK_ThuThu] PRIMARY KEY CLUSTERED 
(
	[MaTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TuaSach]    Script Date: 05/24/2023 7:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TuaSach](
	[MaTS] [varchar](10) NOT NULL,
	[TenTS] [nvarchar](50) NOT NULL,
	[NamXB] [int] NULL,
	[TheLoai] [nvarchar](30) NULL,
	[MaNXB] [char](10) NULL,
	[MaKe] [char](10) NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK__TuaSach__27250078A777EB3F] PRIMARY KEY CLUSTERED 
(
	[MaTS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Viet]    Script Date: 05/24/2023 7:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Viet](
	[MaTS] [varchar](10) NOT NULL,
	[MaTG] [char](10) NOT NULL,
	[SoTrang] [int] NULL,
 CONSTRAINT [PK_Viet] PRIMARY KEY CLUSTERED 
(
	[MaTS] ASC,
	[MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietMuon] ([MaPM], [MaCS], [TinhTrang]) VALUES (N'PM001     ', N'CS002          ', N'Tốt')
GO
INSERT [dbo].[ChiTietMuon] ([MaPM], [MaCS], [TinhTrang]) VALUES (N'PM002     ', N'CS006          ', N'Tốt')
GO
INSERT [dbo].[ChiTietMuon] ([MaPM], [MaCS], [TinhTrang]) VALUES (N'PM003     ', N'CS002          ', N'Tốt')
GO
INSERT [dbo].[ChiTietMuon] ([MaPM], [MaCS], [TinhTrang]) VALUES (N'PM004     ', N'CS001          ', N'Tốt')
GO
INSERT [dbo].[ChiTietMuon] ([MaPM], [MaCS], [TinhTrang]) VALUES (N'PM004     ', N'CS022          ', N'Tốt')
GO
INSERT [dbo].[ChiTietMuon] ([MaPM], [MaCS], [TinhTrang]) VALUES (N'PM005     ', N'CS010          ', N'Tốt')
GO
INSERT [dbo].[ChiTietMuon] ([MaPM], [MaCS], [TinhTrang]) VALUES (N'PM006     ', N'CS006          ', N'Cũ')
GO
INSERT [dbo].[ChiTietMuon] ([MaPM], [MaCS], [TinhTrang]) VALUES (N'PM007     ', N'CS008          ', N'Tốt')
GO
INSERT [dbo].[ChiTietMuon] ([MaPM], [MaCS], [TinhTrang]) VALUES (N'PM008     ', N'CS011          ', N'Tốt')
GO
INSERT [dbo].[ChiTietMuon] ([MaPM], [MaCS], [TinhTrang]) VALUES (N'PM009     ', N'CS006          ', N'Tốt')
GO
INSERT [dbo].[ChiTietMuon] ([MaPM], [MaCS], [TinhTrang]) VALUES (N'PM010     ', N'CS018          ', N'Cũ')
GO
INSERT [dbo].[ChiTietMuon] ([MaPM], [MaCS], [TinhTrang]) VALUES (N'PM011     ', N'CS012          ', N'Tốt')
GO
INSERT [dbo].[ChiTietMuon] ([MaPM], [MaCS], [TinhTrang]) VALUES (N'PM012     ', N'CS001          ', N'Tốt')
GO
INSERT [dbo].[ChiTietNhap] ([MaPN], [MaTS], [SoLuong], [DonGia]) VALUES (N'PN001     ', N'TS001', 5, 68000)
GO
INSERT [dbo].[ChiTietNhap] ([MaPN], [MaTS], [SoLuong], [DonGia]) VALUES (N'PN002     ', N'TS004', 7, 72000)
GO
INSERT [dbo].[ChiTietNhap] ([MaPN], [MaTS], [SoLuong], [DonGia]) VALUES (N'PN003     ', N'TS009', 3, 58000)
GO
INSERT [dbo].[ChiTietNhap] ([MaPN], [MaTS], [SoLuong], [DonGia]) VALUES (N'PN004     ', N'TS002', 5, 62000)
GO
INSERT [dbo].[ChiTietNhap] ([MaPN], [MaTS], [SoLuong], [DonGia]) VALUES (N'PN005     ', N'TS002', 3, 55000)
GO
INSERT [dbo].[ChiTietNhap] ([MaPN], [MaTS], [SoLuong], [DonGia]) VALUES (N'PN006     ', N'TS004', 2, 78000)
GO
INSERT [dbo].[ChiTietNhap] ([MaPN], [MaTS], [SoLuong], [DonGia]) VALUES (N'PN007     ', N'TS003', 6, 46000)
GO
INSERT [dbo].[ChiTietNhap] ([MaPN], [MaTS], [SoLuong], [DonGia]) VALUES (N'PN008     ', N'TS005', 4, 48000)
GO
INSERT [dbo].[ChiTietNhap] ([MaPN], [MaTS], [SoLuong], [DonGia]) VALUES (N'PN009     ', N'TS006', 3, 56000)
GO
INSERT [dbo].[ChiTietNhap] ([MaPN], [MaTS], [SoLuong], [DonGia]) VALUES (N'PN010     ', N'TS004', 4, 38000)
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS001          ', N'TS004     ')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS002          ', N'TS001     ')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS003          ', N'TS002     ')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS004          ', N'TS002     ')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS005          ', N'TS003')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS006          ', N'TS003')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS007          ', N'TS005')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS008          ', N'TS007')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS009          ', N'TS011')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS010          ', N'TS010')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS011          ', N'TS010')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS012          ', N'TS009')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS013          ', N'TS003')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS014          ', N'TS005')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS015          ', N'TS004')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS016          ', N'TS006')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS017          ', N'TS007')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS018          ', N'TS008')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS019          ', N'TS006')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS020          ', N'TS004')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS021          ', N'TS001')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS022          ', N'TS002')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS023          ', N'TS003')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS024          ', N'TS005')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS025          ', N'TS009')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS026          ', N'TS002')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS027          ', N'TS004')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS028          ', N'TS011')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS029          ', N'TS008')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS030          ', N'TS007')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS031          ', N'TS010')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS032          ', N'TS001')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS033          ', N'TS008')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS034          ', N'TS002')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS035          ', N'TS001')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS036          ', N'TS004')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS037          ', N'TS011')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS038          ', N'TS009')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS039          ', N'TS007')
GO
INSERT [dbo].[CuonSach] ([MaCS], [MaTS]) VALUES (N'CS040          ', N'TS003')
GO
INSERT [dbo].[DocGia] ([MaDG], [DocGiaID], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'117001    ', N'GV002', N'Nguyễn Thế Anh', CAST(N'1985-11-15' AS Date), N'Nam  ', N'Hà Nội', N'0367475754     ')
GO
INSERT [dbo].[DocGia] ([MaDG], [DocGiaID], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'117002    ', N'GV001', N'Nguyễn Tuấn Anh', CAST(N'2002-02-08' AS Date), N'Nam  ', N'Lạng Sơn', N'0974535643     ')
GO
INSERT [dbo].[DocGia] ([MaDG], [DocGiaID], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'117003    ', N'SV001', N'Bùi Ngọc Sơn', CAST(N'2004-05-07' AS Date), N'Nam  ', N'Tuyên Quang', N'0965425345     ')
GO
INSERT [dbo].[DocGia] ([MaDG], [DocGiaID], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'117004    ', N'GV003', N'Lê Ngọc Anh', CAST(N'1988-02-21' AS Date), N'Nữ   ', N'Hà Nội', N'0364757565     ')
GO
INSERT [dbo].[DocGia] ([MaDG], [DocGiaID], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'117005    ', N'SV002', N'Đào Thu Trang', CAST(N'2001-04-14' AS Date), N'Nữ   ', N'Hà Nội', N'0367558665     ')
GO
INSERT [dbo].[DocGia] ([MaDG], [DocGiaID], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'117006    ', N'SV003', N'Nguyễn Viết Long', CAST(N'2003-11-11' AS Date), N'Nam  ', N'Thái Nguyên', N'0978756543     ')
GO
INSERT [dbo].[DocGia] ([MaDG], [DocGiaID], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'117007    ', N'SV004', N'Bùi Quang Lâm', CAST(N'2004-01-12' AS Date), N'Nam  ', N'Hải Phòng', N'0365557783     ')
GO
INSERT [dbo].[DocGia] ([MaDG], [DocGiaID], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'117008    ', N'SV005', N'Nguyễn Phương Thảo', CAST(N'2001-12-15' AS Date), N'Nữ   ', N'Hà Nội', N'0988535352     ')
GO
INSERT [dbo].[DocGia] ([MaDG], [DocGiaID], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'117009    ', N'SV006', N'Đỗ Thị Phương', CAST(N'2003-08-12' AS Date), N'Nữ   ', N'Hà Nội', N'0344678665     ')
GO
INSERT [dbo].[DocGia] ([MaDG], [DocGiaID], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'117010    ', N'SV007', N'Đặng Duy Long', CAST(N'2003-04-06' AS Date), N'Nam  ', N'Phú Thọ', N'0977442465     ')
GO
INSERT [dbo].[DocGia] ([MaDG], [DocGiaID], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'117011    ', N'SV008', N'Nguyễn Thảo Linh', CAST(N'2001-09-05' AS Date), N'Nữ   ', N'Hà Nội', N'0345546776     ')
GO
INSERT [dbo].[DocGia] ([MaDG], [DocGiaID], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'117012    ', N'SV009', N'Bùi Việt Dũng', CAST(N'2004-08-07' AS Date), N'Nam  ', N'Hòa Bình', N'0356678975     ')
GO
INSERT [dbo].[DocGia] ([MaDG], [DocGiaID], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'117013    ', N'SV010', N'Đỗ Bảo Nam', CAST(N'2001-02-03' AS Date), N'Nam  ', N'Hà Nội', N'0988535653     ')
GO
INSERT [dbo].[DocGia] ([MaDG], [DocGiaID], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'117014    ', N'SV011', N'Trần Việt Hoàng', CAST(N'2003-08-03' AS Date), N'Nam  ', N'Hà Nội', N'0974535353     ')
GO
INSERT [dbo].[DocGia] ([MaDG], [DocGiaID], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'117015    ', N'SV012', N'Nguyễn Kim Ngân', CAST(N'2001-04-03' AS Date), N'Nữ   ', N'Bắc Giang', N'0345646785     ')
GO
INSERT [dbo].[DocGia] ([MaDG], [DocGiaID], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'117016    ', N'SV013', N'Quách Cẩm Anh', CAST(N'2001-04-03' AS Date), N'Nữ   ', N'Hà Nội', N'0976594393     ')
GO
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [DienThoai], [DiaChi], [MaKhoa], [NgaySinh], [GioiTinh]) VALUES (N'GV001', N'Nguyễn Tuấn Anh', N'0974535643     ', N'Lạng Sơn', N'TIN', CAST(N'2002-02-08' AS Date), N'Nam  ')
GO
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [DienThoai], [DiaChi], [MaKhoa], [NgaySinh], [GioiTinh]) VALUES (N'GV002', N'Nguyễn Thế Anh', N'0367475754     ', N'Hà Nội', N'TOAN', CAST(N'1985-11-15' AS Date), N'Nam  ')
GO
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [DienThoai], [DiaChi], [MaKhoa], [NgaySinh], [GioiTinh]) VALUES (N'GV003', N'Lê Ngọc Anh', N'0364757565     ', N'Hà Nội', N'NGVAN', CAST(N'1988-02-21' AS Date), N'Nữ')
GO
INSERT [dbo].[KeSach] ([MaKe], [ChatLieu], [SucChua]) VALUES (N'KE001     ', N'Gỗ', 26)
GO
INSERT [dbo].[KeSach] ([MaKe], [ChatLieu], [SucChua]) VALUES (N'KE002     ', N'Gỗ', 19)
GO
INSERT [dbo].[KeSach] ([MaKe], [ChatLieu], [SucChua]) VALUES (N'KE003     ', N'Gỗ', 36)
GO
INSERT [dbo].[KeSach] ([MaKe], [ChatLieu], [SucChua]) VALUES (N'KE004     ', N'Thép', 32)
GO
INSERT [dbo].[KeSach] ([MaKe], [ChatLieu], [SucChua]) VALUES (N'KE005     ', N'Thép', 56)
GO
INSERT [dbo].[KeSach] ([MaKe], [ChatLieu], [SucChua]) VALUES (N'KE006     ', N'Gỗ', 52)
GO
INSERT [dbo].[KeSach] ([MaKe], [ChatLieu], [SucChua]) VALUES (N'KE007     ', N'Thép', 68)
GO
INSERT [dbo].[KeSach] ([MaKe], [ChatLieu], [SucChua]) VALUES (N'KE008     ', N'Thép', 46)
GO
INSERT [dbo].[KeSach] ([MaKe], [ChatLieu], [SucChua]) VALUES (N'KE009     ', N'Gỗ', 62)
GO
INSERT [dbo].[KeSach] ([MaKe], [ChatLieu], [SucChua]) VALUES (N'KE010     ', N'Thép', 57)
GO
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'COKHI', N'CƠ KHÍ')
GO
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'NGVAN', N'NGỮ VĂN')
GO
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'TIN', N'TIN HỌC')
GO
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'TOAN', N'KHOA TOÁN')
GO
INSERT [dbo].[Lop] ([MaLop], [MaKhoa]) VALUES (N'0212021', N'TIN')
GO
INSERT [dbo].[Lop] ([MaLop], [MaKhoa]) VALUES (N'0324501', N'TOAN')
GO
INSERT [dbo].[Lop] ([MaLop], [MaKhoa]) VALUES (N'0411424', N'COKHI')
GO
INSERT [dbo].[Lop] ([MaLop], [MaKhoa]) VALUES (N'0544125', N'NGVAN')
GO
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [DiaChi], [SDT], [Email]) VALUES (N'NCC001    ', N'Thiên Long', N'Đà Nẵng', N'0976749564   ', N'thienlong@gmail.com                     ')
GO
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [DiaChi], [SDT], [Email]) VALUES (N'NCC002    ', N'Hồng Hà', N'Hà Nội', N'0943459693   ', N'hongha@gmail.com                        ')
GO
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [DiaChi], [SDT], [Email]) VALUES (N'NCC003    ', N'Giáo Dục', N'Hà Nội', N'0356695943   ', N'giaoduc@gmail.com                       ')
GO
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [DiaChi], [SDT], [Email]) VALUES (N'NCC004    ', N'Huyền Vũ', N'Hà Nội', N'0984563564   ', N'huyenvu@gmail.com                       ')
GO
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [DiaChi], [SDT], [Email]) VALUES (N'NCC005    ', N'Thanh Long', N'Hà Nội', N'0943594959   ', N'thanhlong@gmail.com                     ')
GO
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [DiaChi], [SDT], [Email]) VALUES (N'NCC006    ', N'Nam Hồng', N'Hà Nam', N'0935459595   ', N'namhong@gmail.com                       ')
GO
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [DiaChi], [SDT], [Email]) VALUES (N'NCC007    ', N'Tuổi Trẻ', N'Hà Nội', N'0345697065   ', N'tuoitre@gmail.com                       ')
GO
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [MaTT], [MatKhau]) VALUES (N'ADMIN', N'TT001     ', N'12345')
GO
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [MaTT], [MatKhau]) VALUES (N'USER01', N'TT002     ', N'12345')
GO
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [MaTT], [MatKhau]) VALUES (N'USER02', N'TT003     ', N'12345')
GO
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [MaTT], [MatKhau]) VALUES (N'USER123', N'TT006     ', N'12345')
GO
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChi], [SDT], [Email]) VALUES (N'NXB001    ', N'Kim Đồng                      ', N'Hà Nội', N'0976665443     ', N'kimdong@gmail.com                                 ')
GO
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChi], [SDT], [Email]) VALUES (N'NXB002    ', N'Đhqghn                        ', N'Hà Nội', N'0967764345     ', N'dhqg@gmail.com                                    ')
GO
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChi], [SDT], [Email]) VALUES (N'NXB003    ', N'Tuổi Trẻ                      ', N'Hà Nội', N'0975463554     ', N'tuoitre@gmaill.com                                ')
GO
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChi], [SDT], [Email]) VALUES (N'NXB004    ', N'Tri Thức                      ', N'Hà Nội', N'0977554454     ', N'trithuc@gmail.com                                 ')
GO
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChi], [SDT], [Email]) VALUES (N'NXB005    ', N'Lao Động                      ', N'Hà Nội', N'0955333403     ', N'laodong@gmail.com                                 ')
GO
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChi], [SDT], [Email]) VALUES (N'NXB006    ', N'Thanh Niên                    ', N'Hà Nội', N'0988649394     ', N'thanhnien@gmail.com                               ')
GO
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChi], [SDT], [Email]) VALUES (N'NXB007    ', N'Nghệ An                       ', N'Nghệ An', N'0979584956     ', N'nghean@gmail.com                                  ')
GO
SET IDENTITY_INSERT [dbo].[PhanQuyen] ON 
GO
INSERT [dbo].[PhanQuyen] ([ID], [MaNguoiDung], [MaQuyen]) VALUES (1, N'ADMIN', N'ADMIN')
GO
INSERT [dbo].[PhanQuyen] ([ID], [MaNguoiDung], [MaQuyen]) VALUES (2, N'USER01', N'USER')
GO
INSERT [dbo].[PhanQuyen] ([ID], [MaNguoiDung], [MaQuyen]) VALUES (3, N'USER02', N'MOD')
GO
INSERT [dbo].[PhanQuyen] ([ID], [MaNguoiDung], [MaQuyen]) VALUES (5, N'USER123', N'ADMIN')
GO
SET IDENTITY_INSERT [dbo].[PhanQuyen] OFF
GO
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayMuon], [NgayTra], [MaDG], [MaTT]) VALUES (N'PM001     ', CAST(N'2023-02-03' AS Date), CAST(N'2023-04-02' AS Date), N'117005    ', N'TT003     ')
GO
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayMuon], [NgayTra], [MaDG], [MaTT]) VALUES (N'PM002     ', CAST(N'2023-01-12' AS Date), CAST(N'2023-02-03' AS Date), N'117001    ', N'TT001     ')
GO
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayMuon], [NgayTra], [MaDG], [MaTT]) VALUES (N'PM003     ', CAST(N'2023-02-05' AS Date), CAST(N'2023-12-03' AS Date), N'117003    ', N'TT005     ')
GO
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayMuon], [NgayTra], [MaDG], [MaTT]) VALUES (N'PM004     ', CAST(N'2023-03-06' AS Date), CAST(N'2023-04-06' AS Date), N'117016    ', N'TT001     ')
GO
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayMuon], [NgayTra], [MaDG], [MaTT]) VALUES (N'PM005     ', CAST(N'2023-02-19' AS Date), CAST(N'2023-03-19' AS Date), N'117009    ', N'TT002     ')
GO
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayMuon], [NgayTra], [MaDG], [MaTT]) VALUES (N'PM006     ', CAST(N'2023-02-27' AS Date), CAST(N'2023-03-21' AS Date), N'117004    ', N'TT006     ')
GO
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayMuon], [NgayTra], [MaDG], [MaTT]) VALUES (N'PM007     ', CAST(N'2023-02-15' AS Date), CAST(N'2023-03-15' AS Date), N'117005    ', N'TT003     ')
GO
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayMuon], [NgayTra], [MaDG], [MaTT]) VALUES (N'PM008     ', CAST(N'2023-02-26' AS Date), CAST(N'2023-04-10' AS Date), N'117001    ', N'TT006     ')
GO
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayMuon], [NgayTra], [MaDG], [MaTT]) VALUES (N'PM009     ', CAST(N'2023-02-10' AS Date), CAST(N'2023-03-10' AS Date), N'117015    ', N'TT007     ')
GO
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayMuon], [NgayTra], [MaDG], [MaTT]) VALUES (N'PM010     ', CAST(N'2023-02-14' AS Date), CAST(N'2023-03-14' AS Date), N'117014    ', N'TT004     ')
GO
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayMuon], [NgayTra], [MaDG], [MaTT]) VALUES (N'PM011     ', CAST(N'2023-03-05' AS Date), CAST(N'2023-03-25' AS Date), N'117012    ', N'TT005     ')
GO
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayMuon], [NgayTra], [MaDG], [MaTT]) VALUES (N'PM012     ', CAST(N'2023-03-02' AS Date), CAST(N'2023-04-02' AS Date), N'117007    ', N'TT001     ')
GO
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayLap], [MaTT], [MaNCC], [TongTien]) VALUES (N'PN001     ', CAST(N'2023-04-20' AS Date), N'TT002     ', N'NCC001    ', NULL)
GO
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayLap], [MaTT], [MaNCC], [TongTien]) VALUES (N'PN002     ', CAST(N'2023-04-13' AS Date), N'TT001     ', N'NCC004    ', NULL)
GO
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayLap], [MaTT], [MaNCC], [TongTien]) VALUES (N'PN003     ', CAST(N'2023-03-18' AS Date), N'TT002     ', N'NCC002    ', NULL)
GO
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayLap], [MaTT], [MaNCC], [TongTien]) VALUES (N'PN004     ', CAST(N'2023-11-02' AS Date), N'TT004     ', N'NCC001    ', NULL)
GO
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayLap], [MaTT], [MaNCC], [TongTien]) VALUES (N'PN005     ', CAST(N'2023-02-12' AS Date), N'TT001     ', N'NCC003    ', NULL)
GO
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayLap], [MaTT], [MaNCC], [TongTien]) VALUES (N'PN006     ', CAST(N'2023-04-11' AS Date), N'TT002     ', N'NCC001    ', NULL)
GO
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayLap], [MaTT], [MaNCC], [TongTien]) VALUES (N'PN007     ', CAST(N'2023-04-08' AS Date), N'TT004     ', N'NCC005    ', NULL)
GO
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayLap], [MaTT], [MaNCC], [TongTien]) VALUES (N'PN008     ', CAST(N'2023-03-10' AS Date), N'TT005     ', N'NCC007    ', NULL)
GO
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayLap], [MaTT], [MaNCC], [TongTien]) VALUES (N'PN009     ', CAST(N'2023-04-01' AS Date), N'TT006     ', N'NCC003    ', NULL)
GO
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayLap], [MaTT], [MaNCC], [TongTien]) VALUES (N'PN010     ', CAST(N'2023-02-11' AS Date), N'TT004     ', N'NCC003    ', NULL)
GO
INSERT [dbo].[Quyen] ([MaQuyen], [XemSach], [SuaSach], [XoaSach], [ThemSach], [ThemNguoiDung], [XemNguoiDung], [SuaNguoiDung], [XoaNguoiDung], [XemMuonTra], [ThemMuonTra], [SuaMuonTra], [XoaMuonTra]) VALUES (N'ADMIN', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
GO
INSERT [dbo].[Quyen] ([MaQuyen], [XemSach], [SuaSach], [XoaSach], [ThemSach], [ThemNguoiDung], [XemNguoiDung], [SuaNguoiDung], [XoaNguoiDung], [XemMuonTra], [ThemMuonTra], [SuaMuonTra], [XoaMuonTra]) VALUES (N'MOD', 1, 1, 0, 1, 0, 1, 0, 0, 1, 1, 1, 0)
GO
INSERT [dbo].[Quyen] ([MaQuyen], [XemSach], [SuaSach], [XoaSach], [ThemSach], [ThemNguoiDung], [XemNguoiDung], [SuaNguoiDung], [XoaNguoiDung], [XemMuonTra], [ThemMuonTra], [SuaMuonTra], [XoaMuonTra]) VALUES (N'USER', 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0)
GO
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [MaLop], [DienThoai], [DiaChi], [NgaySinh], [GioiTinh]) VALUES (N'SV001', N'Bùi Ngọc Sơn', N'0212021', N'0965425341', N'Tuyên Quang 1', CAST(N'2004-05-07' AS Date), N'Nam  ')
GO
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [MaLop], [DienThoai], [DiaChi], [NgaySinh], [GioiTinh]) VALUES (N'SV002', N'Đào Thu Tran', N'0324501', N'0367558665     ', N'Hà Nội', CAST(N'2001-04-14' AS Date), N'Nữ   ')
GO
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [MaLop], [DienThoai], [DiaChi], [NgaySinh], [GioiTinh]) VALUES (N'SV003', N'Nguyễn Viết Long', N'0212021', N'0978756543     ', N'Thái Nguyên', CAST(N'2003-11-11' AS Date), N'Nam  ')
GO
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [MaLop], [DienThoai], [DiaChi], [NgaySinh], [GioiTinh]) VALUES (N'SV004', N'Bùi Quang Lâm', N'0324501', N'0365557783     ', N'Hải Phòng', CAST(N'2004-01-12' AS Date), N'Nam  ')
GO
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [MaLop], [DienThoai], [DiaChi], [NgaySinh], [GioiTinh]) VALUES (N'SV005', N'Nguyễn Phương Thảo', N'0212021', N'0988535352     ', N'Hà Nội', CAST(N'2001-12-15' AS Date), N'Nữ   ')
GO
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [MaLop], [DienThoai], [DiaChi], [NgaySinh], [GioiTinh]) VALUES (N'SV006', N'Đỗ Thị Phương', N'0411424', N'0344678665     ', N'Hà Nội', CAST(N'2003-08-12' AS Date), N'Nữ   ')
GO
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [MaLop], [DienThoai], [DiaChi], [NgaySinh], [GioiTinh]) VALUES (N'SV007', N'Đặng Duy Long', N'0212021', N'0977442465     ', N'Phú Thọ', CAST(N'2003-04-06' AS Date), N'Nam  ')
GO
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [MaLop], [DienThoai], [DiaChi], [NgaySinh], [GioiTinh]) VALUES (N'SV008', N'Nguyễn Thảo Linh', N'0544125', N'0345546776     ', N'Hà Nội', CAST(N'2001-09-05' AS Date), N'Nữ   ')
GO
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [MaLop], [DienThoai], [DiaChi], [NgaySinh], [GioiTinh]) VALUES (N'SV009', N'Bùi Việt Dũng', N'0212021', N'0356678975     ', N'Hòa Bình 1', CAST(N'2004-08-07' AS Date), N'Nam  ')
GO
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [MaLop], [DienThoai], [DiaChi], [NgaySinh], [GioiTinh]) VALUES (N'SV010', N'Đỗ Bảo Nam', N'0544125', N'0988535653     ', N'Hà Nội', CAST(N'2001-02-03' AS Date), N'Nam  ')
GO
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [MaLop], [DienThoai], [DiaChi], [NgaySinh], [GioiTinh]) VALUES (N'SV011', N'Trần Việt Hoàng', N'0411424', N'0974535353     ', N'Hà Nội 1', CAST(N'2003-08-03' AS Date), N'Nam  ')
GO
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [NgaySinh], [GioiTinh], [QueQuan]) VALUES (N'TG001     ', N'Vũ Trọng Phụng', CAST(N'1969-12-11' AS Date), N'Nam  ', N'Hà Nội')
GO
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [NgaySinh], [GioiTinh], [QueQuan]) VALUES (N'TG002     ', N'Quang Lân', CAST(N'1974-05-05' AS Date), N'Nam  ', N'Hải Dương')
GO
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [NgaySinh], [GioiTinh], [QueQuan]) VALUES (N'TG003     ', N'Thành Vũ', CAST(N'1964-02-04' AS Date), N'Nam  ', N'Hà Nội')
GO
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [NgaySinh], [GioiTinh], [QueQuan]) VALUES (N'TG004     ', N'Nguyễn Đình Phúc', CAST(N'1971-03-05' AS Date), N'Nam  ', N'Bắc Ninh')
GO
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [NgaySinh], [GioiTinh], [QueQuan]) VALUES (N'TG005     ', N'Thành Nam', CAST(N'1972-01-05' AS Date), N'Nam  ', N'Hà Nội')
GO
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [NgaySinh], [GioiTinh], [QueQuan]) VALUES (N'TG006     ', N'Xuân Mai', CAST(N'1975-03-05' AS Date), N'Nữ   ', N'Vĩnh Phúc')
GO
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [NgaySinh], [GioiTinh], [QueQuan]) VALUES (N'TG007     ', N'Bùi Quang Ngọc', CAST(N'1965-05-06' AS Date), N'Nam  ', N'Hà Nội')
GO
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [NgaySinh], [GioiTinh], [QueQuan]) VALUES (N'TG008     ', N'Đào Thế Phượng', CAST(N'1976-03-03' AS Date), N'Nam  ', N'Cao Bằng')
GO
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [NgaySinh], [GioiTinh], [QueQuan]) VALUES (N'TG009     ', N'Nguyễn Chí Minh', CAST(N'1966-06-03' AS Date), N'Nam  ', N'Hà Nội')
GO
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [NgaySinh], [GioiTinh], [QueQuan]) VALUES (N'TG010     ', N'Ngô Thị Vân', CAST(N'1973-01-05' AS Date), N'Nữ   ', N'Hải Phòng')
GO
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [NgaySinh], [GioiTinh], [QueQuan]) VALUES (N'TG011     ', N'Võ Văn Khánh', CAST(N'1972-04-07' AS Date), N'Nam  ', N'Phú Thọ')
GO
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [NgaySinh], [GioiTinh], [QueQuan]) VALUES (N'TG012     ', N'Bùi Đức Thịnh', CAST(N'1971-09-02' AS Date), N'Nam  ', N'Hà Nội')
GO
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [NgaySinh], [GioiTinh], [QueQuan]) VALUES (N'TG013     ', N'Đỗ Văn Hải', CAST(N'1968-07-03' AS Date), N'Nam  ', N'Vĩnh Phúc')
GO
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [NgaySinh], [GioiTinh], [QueQuan]) VALUES (N'TG014     ', N'Nguyễn Minh Châu', CAST(N'1962-05-07' AS Date), N'Nam  ', N'Hà Nội')
GO
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [NgaySinh], [GioiTinh], [QueQuan]) VALUES (N'TG015     ', N'Nguyễn Văn Nam', CAST(N'1969-09-12' AS Date), N'Nam  ', N'Hà Nội')
GO
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [NgaySinh], [GioiTinh], [QueQuan]) VALUES (N'TG016     ', N'Trần Bảo Sơn', CAST(N'1957-12-11' AS Date), N'Nam  ', N'Hà Nam')
GO
INSERT [dbo].[ThuThu] ([MaTT], [TenTT], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Chucvu]) VALUES (N'TT001     ', N'Nguyễn Minh Triết', CAST(N'1982-12-12' AS Date), N'Nam  ', N'Hà Nội', N'0345673674     ', N'Nhân viên')
GO
INSERT [dbo].[ThuThu] ([MaTT], [TenTT], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Chucvu]) VALUES (N'TT002     ', N'Nguyễn Thị Na', CAST(N'1971-08-18' AS Date), N'Nữ   ', N'Hà Nam', N'0975462646     ', N'Nhân viên')
GO
INSERT [dbo].[ThuThu] ([MaTT], [TenTT], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Chucvu]) VALUES (N'TT003     ', N'Ngô Thị Lan', CAST(N'1985-04-19' AS Date), N'Nữ   ', N'Hà Nội', N'0964674636     ', N'Nhân viên')
GO
INSERT [dbo].[ThuThu] ([MaTT], [TenTT], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Chucvu]) VALUES (N'TT004     ', N'Nguyễn Thành Long', CAST(N'1985-03-28' AS Date), N'Nam  ', N'Băc Ninh', N'036746864      ', N'Nhân viên')
GO
INSERT [dbo].[ThuThu] ([MaTT], [TenTT], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Chucvu]) VALUES (N'TT005     ', N'Lê Thị Oanh', CAST(N'1980-10-11' AS Date), N'Nữ   ', N'Hải Dương', N'0967435758     ', N'Nhân viên')
GO
INSERT [dbo].[ThuThu] ([MaTT], [TenTT], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Chucvu]) VALUES (N'TT006     ', N'Bùi Xuân Hương', CAST(N'1987-07-03' AS Date), N'Nữ   ', N'Hà Nội', N'0975342421     ', N'Nhân viên')
GO
INSERT [dbo].[ThuThu] ([MaTT], [TenTT], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Chucvu]) VALUES (N'TT007     ', N'Nguyễn Xuân Yến', CAST(N'1982-05-04' AS Date), N'Nữ   ', N'Hà Nội', N'0360959546     ', N'Nhân Viên')
GO
INSERT [dbo].[TuaSach] ([MaTS], [TenTS], [NamXB], [TheLoai], [MaNXB], [MaKe], [SoLuong]) VALUES (N'TS001', N'Giết con chim nhại', 2021, N'Truyện', N'NXB003    ', N'KE003     ', 16)
GO
INSERT [dbo].[TuaSach] ([MaTS], [TenTS], [NamXB], [TheLoai], [MaNXB], [MaKe], [SoLuong]) VALUES (N'TS002', N'Centimet trên giây', 2022, N'Truyện', N'NXB002    ', N'KE002     ', 18)
GO
INSERT [dbo].[TuaSach] ([MaTS], [TenTS], [NamXB], [TheLoai], [MaNXB], [MaKe], [SoLuong]) VALUES (N'TS003', N'Ông già và biển cả', 2021, N'Truyện', N'NXB004    ', N'KE001     ', 25)
GO
INSERT [dbo].[TuaSach] ([MaTS], [TenTS], [NamXB], [TheLoai], [MaNXB], [MaKe], [SoLuong]) VALUES (N'TS004', N'Không gia đình', 2021, N'Truyện', N'NXB006    ', N'KE007     ', 15)
GO
INSERT [dbo].[TuaSach] ([MaTS], [TenTS], [NamXB], [TheLoai], [MaNXB], [MaKe], [SoLuong]) VALUES (N'TS005', N'Chiến binh cầu vồng', 2022, N'Truyện', N'NXB004    ', N'KE005     ', 23)
GO
INSERT [dbo].[TuaSach] ([MaTS], [TenTS], [NamXB], [TheLoai], [MaNXB], [MaKe], [SoLuong]) VALUES (N'TS006', N'Suối nguồn', 2021, N'Truyện', N'NXB003    ', N'KE001     ', 14)
GO
INSERT [dbo].[TuaSach] ([MaTS], [TenTS], [NamXB], [TheLoai], [MaNXB], [MaKe], [SoLuong]) VALUES (N'TS007', N'Số đỏ', 2022, N'Truyện', N'NXB001    ', N'KE004     ', 21)
GO
INSERT [dbo].[TuaSach] ([MaTS], [TenTS], [NamXB], [TheLoai], [MaNXB], [MaKe], [SoLuong]) VALUES (N'TS008', N'Kiêu hãnh và định kiến', 2021, N'Truyện', N'NXB002    ', N'KE002     ', 17)
GO
INSERT [dbo].[TuaSach] ([MaTS], [TenTS], [NamXB], [TheLoai], [MaNXB], [MaKe], [SoLuong]) VALUES (N'TS009', N'Bỉ vỏ', 2022, N'Truyện', N'NXB005    ', N'KE005     ', 13)
GO
INSERT [dbo].[TuaSach] ([MaTS], [TenTS], [NamXB], [TheLoai], [MaNXB], [MaKe], [SoLuong]) VALUES (N'TS010', N'Nỗi buồn chiến tranh', 2021, N'Truyện', N'NXB002    ', N'KE003     ', 26)
GO
INSERT [dbo].[TuaSach] ([MaTS], [TenTS], [NamXB], [TheLoai], [MaNXB], [MaKe], [SoLuong]) VALUES (N'TS011', N'Hai số phận', 2021, N'Truyện', N'NXB004    ', N'KE003     ', 17)
GO
INSERT [dbo].[Viet] ([MaTS], [MaTG], [SoTrang]) VALUES (N'TS001', N'TG003     ', 126)
GO
INSERT [dbo].[Viet] ([MaTS], [MaTG], [SoTrang]) VALUES (N'TS002', N'TG001     ', 225)
GO
INSERT [dbo].[Viet] ([MaTS], [MaTG], [SoTrang]) VALUES (N'TS003', N'TG005     ', 168)
GO
INSERT [dbo].[Viet] ([MaTS], [MaTG], [SoTrang]) VALUES (N'TS004', N'TG004     ', 206)
GO
INSERT [dbo].[Viet] ([MaTS], [MaTG], [SoTrang]) VALUES (N'TS005', N'TG006     ', 179)
GO
INSERT [dbo].[Viet] ([MaTS], [MaTG], [SoTrang]) VALUES (N'TS006', N'TG007     ', 148)
GO
INSERT [dbo].[Viet] ([MaTS], [MaTG], [SoTrang]) VALUES (N'TS007', N'TG001     ', 185)
GO
INSERT [dbo].[Viet] ([MaTS], [MaTG], [SoTrang]) VALUES (N'TS008', N'TG002     ', 156)
GO
INSERT [dbo].[Viet] ([MaTS], [MaTG], [SoTrang]) VALUES (N'TS009', N'TG004     ', 140)
GO
INSERT [dbo].[Viet] ([MaTS], [MaTG], [SoTrang]) VALUES (N'TS010', N'TG002     ', 168)
GO
INSERT [dbo].[Viet] ([MaTS], [MaTG], [SoTrang]) VALUES (N'TS011', N'TG003     ', 253)
GO
ALTER TABLE [dbo].[ChiTietMuon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietMuon_CuonSach_MaSach] FOREIGN KEY([MaCS])
REFERENCES [dbo].[CuonSach] ([MaCS])
GO
ALTER TABLE [dbo].[ChiTietMuon] CHECK CONSTRAINT [FK_ChiTietMuon_CuonSach_MaSach]
GO
ALTER TABLE [dbo].[ChiTietMuon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietMuon_PhieuMuon_MaPM] FOREIGN KEY([MaPM])
REFERENCES [dbo].[PhieuMuon] ([MaPM])
GO
ALTER TABLE [dbo].[ChiTietMuon] CHECK CONSTRAINT [FK_ChiTietMuon_PhieuMuon_MaPM]
GO
ALTER TABLE [dbo].[ChiTietNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietNhap_PhieuNhap_MaPN] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PhieuNhap] ([MaPN])
GO
ALTER TABLE [dbo].[ChiTietNhap] CHECK CONSTRAINT [FK_ChiTietNhap_PhieuNhap_MaPN]
GO
ALTER TABLE [dbo].[ChiTietNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietNhap_TuaSach_MaTS] FOREIGN KEY([MaTS])
REFERENCES [dbo].[TuaSach] ([MaTS])
GO
ALTER TABLE [dbo].[ChiTietNhap] CHECK CONSTRAINT [FK_ChiTietNhap_TuaSach_MaTS]
GO
ALTER TABLE [dbo].[CuonSach]  WITH CHECK ADD  CONSTRAINT [FK_CuonSach_TuaSach_MaTS] FOREIGN KEY([MaTS])
REFERENCES [dbo].[TuaSach] ([MaTS])
GO
ALTER TABLE [dbo].[CuonSach] CHECK CONSTRAINT [FK_CuonSach_TuaSach_MaTS]
GO
ALTER TABLE [dbo].[GiaoVien]  WITH CHECK ADD  CONSTRAINT [FK__GiaoVien__MaKhoa__30C33EC3] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[GiaoVien] CHECK CONSTRAINT [FK__GiaoVien__MaKhoa__30C33EC3]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD FOREIGN KEY([MaTT])
REFERENCES [dbo].[ThuThu] ([MaTT])
GO
ALTER TABLE [dbo].[PhanQuyen]  WITH CHECK ADD FOREIGN KEY([MaNguoiDung])
REFERENCES [dbo].[NguoiDung] ([MaNguoiDung])
GO
ALTER TABLE [dbo].[PhanQuyen]  WITH CHECK ADD FOREIGN KEY([MaQuyen])
REFERENCES [dbo].[Quyen] ([MaQuyen])
GO
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuon_DocGia_MaDG] FOREIGN KEY([MaDG])
REFERENCES [dbo].[DocGia] ([MaDG])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_PhieuMuon_DocGia_MaDG]
GO
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuon_ThuThu_MaTT] FOREIGN KEY([MaTT])
REFERENCES [dbo].[ThuThu] ([MaTT])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_PhieuMuon_ThuThu_MaTT]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NCC_MaNCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NCC] ([MaNCC])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NCC_MaNCC]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_ThuThu_MaTT] FOREIGN KEY([MaTT])
REFERENCES [dbo].[ThuThu] ([MaTT])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_ThuThu_MaTT]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK__SinhVien__MaLop__2DE6D218] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK__SinhVien__MaLop__2DE6D218]
GO
ALTER TABLE [dbo].[TuaSach]  WITH CHECK ADD  CONSTRAINT [FK_TuaSach_KeSach_MaKe] FOREIGN KEY([MaKe])
REFERENCES [dbo].[KeSach] ([MaKe])
GO
ALTER TABLE [dbo].[TuaSach] CHECK CONSTRAINT [FK_TuaSach_KeSach_MaKe]
GO
ALTER TABLE [dbo].[TuaSach]  WITH CHECK ADD  CONSTRAINT [FK_TuaSach_NXB_MaNXB] FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NXB] ([MaNXB])
GO
ALTER TABLE [dbo].[TuaSach] CHECK CONSTRAINT [FK_TuaSach_NXB_MaNXB]
GO
ALTER TABLE [dbo].[Viet]  WITH CHECK ADD  CONSTRAINT [FK_Viet_TuaSach_MaTG] FOREIGN KEY([MaTG])
REFERENCES [dbo].[TacGia] ([MaTG])
GO
ALTER TABLE [dbo].[Viet] CHECK CONSTRAINT [FK_Viet_TuaSach_MaTG]
GO
ALTER TABLE [dbo].[Viet]  WITH CHECK ADD  CONSTRAINT [FK_Viet_TuaSach_MaTS] FOREIGN KEY([MaTS])
REFERENCES [dbo].[TuaSach] ([MaTS])
GO
ALTER TABLE [dbo].[Viet] CHECK CONSTRAINT [FK_Viet_TuaSach_MaTS]
GO
ALTER TABLE [dbo].[ChiTietMuon]  WITH CHECK ADD  CONSTRAINT [CK__ChiTietMu__TinhT__35BCFE0A] CHECK  (([TinhTrang]=N'Cũ' OR [TinhTrang]=N'Tốt'))
GO
ALTER TABLE [dbo].[ChiTietMuon] CHECK CONSTRAINT [CK__ChiTietMu__TinhT__35BCFE0A]
GO
ALTER TABLE [dbo].[DocGia]  WITH CHECK ADD  CONSTRAINT [CK__DocGia__GioiTinh__48CFD27E] CHECK  (([GioiTinh]=N'Nữ' OR [GioiTinh]=N'Nam'))
GO
ALTER TABLE [dbo].[DocGia] CHECK CONSTRAINT [CK__DocGia__GioiTinh__48CFD27E]
GO
ALTER TABLE [dbo].[TacGia]  WITH CHECK ADD CHECK  (([GioiTinh]=N'Nữ' OR [GioiTinh]=N'Nam'))
GO
ALTER TABLE [dbo].[ThuThu]  WITH CHECK ADD CHECK  (([GioiTinh]=N'Nữ' OR [GioiTinh]=N'Nam'))
GO
/****** Object:  StoredProcedure [dbo].[CapNhat_TS_V]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CapNhat_TS_V](@mats varchar(10),@tents nvarchar(50),@namxb int,@theloai nvarchar (30),@manxb char(10),@make char(10),@soluong int, @matg char(10), @sotrang int)
as
begin
update TuaSach
set tenTS=@tents,
	namXB=@namxb,
	TheLoai=@theloai,
	maNXB = @manxb,
	MaKe=@make,
	SoLuong=@soluong
where maTS=@mats
update Viet
set
	MaTG=@matg,
	SoTrang=@sotrang
where maTS=@mats
end
GO
/****** Object:  StoredProcedure [dbo].[Cbb_CS]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Cbb_CS]
as
select * from CuonSach
GO
/****** Object:  StoredProcedure [dbo].[Cbb_DG]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Cbb_DG]
as
select MaDG as 'Mã Độc Giả', TenDG as 'Tên Độc Giả' from DocGia
GO
/****** Object:  StoredProcedure [dbo].[Cbb_KeSach]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Cbb_KeSach]
as
select MaKe, MaKe as 'Mã Kệ' from KeSach
GO
/****** Object:  StoredProcedure [dbo].[Cbb_NCC]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Cbb_NCC]
as
select MaNCC as 'Mã NCC', TenNCC as 'Tên NCC' from NCC
GO
/****** Object:  StoredProcedure [dbo].[Cbb_NXB]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Cbb_NXB]
as
select MaNXB as 'Mã NXB', TenNXB as 'Tên NXB' from NXB
GO
/****** Object:  StoredProcedure [dbo].[Cbb_TacGia]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Cbb_TacGia]
as
select MaTG as 'Mã TG', TenTG as 'Tên TG' from TacGia
GO
/****** Object:  StoredProcedure [dbo].[Cbb_TS]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Cbb_TS]
as
select MaTS as 'Mã Tựa Sách', TenTS as 'Tên Tựa Sách' from TuaSach
GO
/****** Object:  StoredProcedure [dbo].[Cbb_TT]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Cbb_TT]
as
select MaTT as 'Mã Thủ Thư', TenTT as'Tên Thủ Thư' from ThuThu
GO
/****** Object:  StoredProcedure [dbo].[ChuaMuon]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ChuaMuon]
as
select CuonSach.MaCS as ChuaMuon from CuonSach except select MaCS from ChiTietMuon
GO
/****** Object:  StoredProcedure [dbo].[DaMuon]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DaMuon]
as
select CuonSach.MaCS as DM, TenTS from CuonSach, TuaSach, ChiTietMuon where CuonSach.MaCS=ChiTietMuon.MaCS and TuaSach.MaTS=CuonSach.MaTS
GO
/****** Object:  StoredProcedure [dbo].[Delete_CS]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Delete_CS](@macs char(10))
as
begin
delete CuonSach
where MaCS=@macs
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_CTM]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Delete_CTM](@mapm char(10),@macs char(10))
as
begin
	delete ChiTietMuon
	where MaPM=@mapm and MaCS=@macs
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_CTN]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Delete_CTN](@MaPN char(10))
as
begin
delete ChiTietNhap
where MaPN=@MaPN
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_DG]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Delete_DG](@madg char(10))
as
begin
	delete DocGia
	where maDG=@madg
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_GV]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Delete_GV]
	@MaGV varchar(10)
AS
BEGIN
    DELETE FROM dbo.GiaoVien
    WHERE  MaGV=@MaGV
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_KeSach]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[Delete_KeSach](@make char(10))
 as
 delete KeSach
 where MaKe=@make
---------------NXB--------------------------
GO
/****** Object:  StoredProcedure [dbo].[Delete_Khoa]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Delete_Khoa]
	@MaKhoa varchar(10)
AS
BEGIN
    DELETE FROM dbo.Khoa
	WHERE MaKhoa = @MaKhoa
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_Lop]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Delete_Lop]
	@MaLop varchar(10)
AS
BEGIN
    DELETE FROM dbo.Lop
	WHERE MaLop = @MaLop
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_NCC]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Delete_NCC](@mancc char(10))
as
begin
delete NCC
where maNCC=@mancc
end		
GO
/****** Object:  StoredProcedure [dbo].[Delete_Nguoidung]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Delete_Nguoidung]
	@MaNguoiDung VARCHAR(10)
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM dbo.NguoiDung
	WHERE MaNguoiDung = @MaNguoiDung
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_NXB]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Delete_NXB](@manxb char(10))
as
begin
delete NXB
where maNXB=@manxb
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_PM]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Delete_PM](@mapm char(10))
as
begin
	delete PhieuMuon
	where MaPM=@mapm
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_PN]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Delete_PN](@MaPN char(10))
as
begin
delete PhieuNhap
where MaPN=@MaPN
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_PQ]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC	[dbo].[Delete_PQ]
@MaQuyen VARCHAR(10),
@MaNguoiDung CHAR(10)
AS
BEGIN
    DELETE FROM dbo.PhanQuyen
	WHERE MaNguoiDung = @MaNguoiDung AND MaQuyen = @MaQuyen
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_Quyen]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Delete_Quyen]
@MaQuyen VARCHAR(10)
AS
BEGIN
    DELETE FROM dbo.Quyen
	WHERE MaQuyen = @MaQuyen
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_SV]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Delete_SV]
	@MaSV varchar(10)
AS
BEGIN
    DELETE FROM dbo.SinhVien
    WHERE  MaSV=@MaSV
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_TG]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Delete_TG](@matg char(10))
as
begin
delete TacGia
where maTG=@matg
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_TS]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Delete_TS](@mats char(10))
as
begin
delete TuaSach
where maTS=@mats
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_TT]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Delete_TT](@matt char(10))
as
begin
	delete ThuThu
	where maTT=@matt
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_V]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Delete_V](@mats char(10),@matg char(10))
as
begin
delete Viet
where maTS=@mats and maTG=@matg
end
GO
/****** Object:  StoredProcedure [dbo].[DemSoLanDaMuon]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DemSoLanDaMuon]
AS
BEGIN
	SELECT MaCS, COUNT(MaCS) AS SoLuong FROM vw_ThongKeChuaMuon
	GROUP BY MaCS    
END
GO
/****** Object:  StoredProcedure [dbo].[Get_GV]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Get_GV]
	@MaGV varchar(10)
AS
BEGIN
	SET NOCOUNT ON
    SELECT * FROM dbo.GiaoVien
    WHERE  MaGV=@MaGV
END
GO
/****** Object:  StoredProcedure [dbo].[Get_NguoiDung]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Get_NguoiDung]
@MaNguoiDung VARCHAR(10)
AS
BEGIN
    SELECT * FROM dbo.NguoiDung
	WHERE MaNguoiDung = @MaNguoiDung
END
GO
/****** Object:  StoredProcedure [dbo].[Get_SV]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Get_SV]
	@MaSV varchar(10)
AS
BEGIN
	SET NOCOUNT ON
    SELECT * FROM dbo.SinhVien
    WHERE  MaSV=@MaSV
END
GO
/****** Object:  StoredProcedure [dbo].[Get_ThuThu]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Get_ThuThu]
@MaThuThu CHAR(10)
AS
BEGIN
    SELECT * FROM dbo.ThuThu
	WHERE MaTT = @MaThuThu
END
GO
/****** Object:  StoredProcedure [dbo].[Get_TS]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Get_TS]
as
begin
declare @i  int
declare @ts varchar(10)
declare @j  int =1
declare @k int
declare @mats varchar(5)
declare @mm	varchar(15)
set @i=10
select @mats= MaTS from TuaSach where MaTS='TS002'
select @ts= MaCS from (select top 1 MaCS from CuonSach where MaTS = 'TS001' order by MaCS DESC ) as A
set @k=	convert( int,substring(@ts,7,3))
while (@j<=@i)
	begin
	if((@j+@k)<10)
			set  @mm=@mats+'_00'+CONVERT(char(5),(@j+@k))
		else if ((@j+@k)<100)
			set @mm=@mats+'_0'+CONVERT(char(5),(@j+@k))
		else 
			set @mm=@mats+'_'+CONVERT(char(5),(@j+@k))
		print @mm
		set @j=@j+1

	end;
--insert into CuonSach values(@mats+'_0'+CONVERT(char(5),@i),@mats)
end;


--Get_TS



--select TuaSach.MaTS,TenTS,NamXB,TheLoai,SoTrang, MaKe,TenNXB,TenTG,SoLuong from TuaSach,TacGia,NXB,Viet
 --where TuaSach.MaTS=Viet.MaTS and Viet.MaTG=TacGia.MaTG and TuaSach.MaNXB=NXB.MaNXB
 --and TuaSach.MaTS=@mats
GO
/****** Object:  StoredProcedure [dbo].[Insert_CS]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Insert_CS](@macs char(10),@mats char(10))
as
begin
if exists(select MaCS from CuonSach where MaCS=@macs) print('Khong the Insert')
else
insert into CuonSach values(@macs,@mats)
end
GO
/****** Object:  StoredProcedure [dbo].[Insert_CTM]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
		


--3. Chi tiet muon
CREATE proc [dbo].[Insert_CTM](@mapm char(10),@macs char(10),@tinhtrang nvarchar(30) )
as
begin
	if exists(select MaPM, MaCS from ChiTietMuon where MaPM=@mapm and MaCS=@macs) print(N'Đã tồn tại!!!')
	else
	insert into ChiTietMuon values(@mapm ,@macs ,@tinhtrang )
end
GO
/****** Object:  StoredProcedure [dbo].[Insert_CTN]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
				
				
CREATE proc [dbo].[Insert_CTN](@mapn char(10),@mats varchar(10),@soluong int,@dongia int)
as
begin
if exists(select MaPN,MaTS from ChiTietNhap where MaPN=@mapn and MaTS=@mats) print(N'Đã tồn tại!!!')
else 
insert into ChiTietNhap values(@mapn,@mats,@soluong,@dongia)
end
GO
/****** Object:  StoredProcedure [dbo].[Insert_DG]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-------------------------Doc gia-------------------
CREATE proc [dbo].[Insert_DG](
@madg char(10), @iddg varchar(10),@tendg nvarchar(30),@gioitinhdg nvarchar(3),@ngaysinhdg date,@diachidg nvarchar(50), @sdtdg char(13))
as
begin
	if exists(select maDG from DocGia where maDG=@madg) print(N'Đã tồn tại!!!')
	else 
	insert into DocGia values (@madg,@iddg,@tendg,@ngaysinhdg,@gioitinhdg,@diachidg,@sdtdg)
end
GO
/****** Object:  StoredProcedure [dbo].[Insert_GV]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Insert_GV]
	@MaGV varchar(10)
    ,@TenGV nvarchar(100)
    ,@DienThoai varchar(20)
    ,@DiaChi nvarchar(200)
    ,@MaKhoa varchar(10)
    ,@NgaySinh DATE
    ,@GioiTinh nvarchar(50)
AS
BEGIN
    INSERT INTO dbo.GiaoVien
    (
        MaGV,
        TenGV,
        DienThoai,
        DiaChi,
        MaKhoa,
        NgaySinh,
        GioiTinh
    )
    VALUES
    (   @MaGV,
        @TenGV,
        @DienThoai,
        @DiaChi,
        @MaKhoa,
        @NgaySinh,
        @GioiTinh
        )
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_KeSach]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Insert_KeSach](@make char(10),@chatlieu nvarchar(30),@succhua int)
as
begin
if exists (select MaKe from KeSach where MaKe=@make)
print N'Đã tồn tại!!!'
else 
insert into KeSach values (@make, @chatlieu, @succhua)
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_Khoa]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Insert_Khoa]
	@MaKhoa varchar(10),
    @TenKhoa nvarchar(50)
AS
BEGIN
    INSERT INTO dbo.Khoa
    (
        MaKhoa,
        TenKhoa
    )
    VALUES
    (   @MaKhoa,
        @TenKhoa
        )
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_Lop]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Insert_Lop]
	@MaLop varchar(10),
	@MaKhoa VARCHAR(10)
AS
BEGIN
    INSERT INTO dbo.Lop
    (
        MaLop,
        MaKhoa
    )
    VALUES
    (   @MaLop,
        @MaKhoa
        )
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_NCC]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

		
CREATE proc [dbo].[Insert_NCC](@mancc char(10),@tenncc nvarchar(50),@diachincc nvarchar(50),@sdtncc char(13),@email nchar(40))
as
begin
if exists(select maNCC from NCC where maNCC=@mancc)  print(N'Đã tồn tại!!!')
else
insert into NCC values (@mancc,@tenncc,@diachincc,@sdtncc,@email)
end
GO
/****** Object:  StoredProcedure [dbo].[Insert_Nguoidung]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Insert_Nguoidung]
	@MaNguoiDung VARCHAR(10),
	@MaTT CHAR(10),
	@MatKhau VARCHAR(20)
AS
BEGIN
	INSERT INTO dbo.NguoiDung
	(
	    MaNguoiDung,
	    MaTT,
	    MatKhau
	)
	VALUES
	(   @MaNguoiDung,
	    @MaTT,
	    @MatKhau
	    )
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_NXB]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	
CREATE proc [dbo].[Insert_NXB](@manxb char(10),@tennxb nvarchar(50),@diachinxb nvarchar(30),@sdtnxb char(13),@emailnxb char(50))
as
begin
if exists(select maNXB from NXB where maNXB=@manxb)
	print(N'Đã tồn tại!!!')
else
insert into NXB(MaNXB,TenNXB,DiaChi,SDT,Email) values(@manxb,@tennxb,@diachinxb,@sdtnxb,@emailnxb)
end
GO
/****** Object:  StoredProcedure [dbo].[Insert_PhanQuyen]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Insert_PhanQuyen]
	@MaNguoiDung  varchar(10),
    @MaQuyen varchar(10)
AS
BEGIN
    INSERT INTO dbo.PhanQuyen
    (
        MaNguoiDung,
        MaQuyen
    )
    VALUES
    (   @MaNguoiDung,
        @MaQuyen
        )
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_PhieuMuon]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[Insert_PhieuMuon](@mapm char(10),@ngaymuon date,@ngaytra date, @madg char(10),@matt char(10),@macs char(10),@tinhtrang nvarchar(30))
as
if exists(select MaPM from PhieuMuon where MaPM=@mapm) print(N'Đã tồn tại!!!')
	else
	insert into PhieuMuon values(@mapm,@ngaymuon,@ngaytra,@madg,@matt)
if exists(select MaPM, MaCS from ChiTietMuon where MaPM=@mapm and MaCS=@macs) print(N'Đã tồn tại!!!')
	else
	insert into ChiTietMuon values(@mapm,@macs,@tinhtrang)
GO
/****** Object:  StoredProcedure [dbo].[Insert_PhieuNhap]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[Insert_PhieuNhap](@mapn char(10),@ngaylap date,@matt char(10),@mancc char(10),@mats varchar(10),@soluong int,@dongia int)
as

if exists(select MaPN from PhieuNhap where MaPN=@mapn) print('Khong The Insert')
else
insert into PhieuNhap(MaPN,NgayLap,MaTT,MaNCC) values(@mapn,@ngaylap,@matt,@mancc)
if exists(select MaPN,MaTS from ChiTietNhap where MaPN=@mapn and MaTS=@mats) print(N'Đã tồn tại!!!')
else 
insert into ChiTietNhap values(@mapn,@mats,@soluong,@dongia)
GO
/****** Object:  StoredProcedure [dbo].[Insert_PM]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------2.Phieu Muon-------------------
CREATE proc [dbo].[Insert_PM](@mapm char(10),@ngaymuon date,@ngaytra date, @madg char(10),@matt char(10))
as
begin
if exists(select MaPM from PhieuMuon where MaPM=@mapm) print(N'Đã tồn tại!!!')
	else
	insert into PhieuMuon values(@mapm,@ngaymuon,@ngaytra,@madg,@matt)
end
GO
/****** Object:  StoredProcedure [dbo].[Insert_PN]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

		

CREATE proc [dbo].[Insert_PN](@mapn char(10),@ngaylap date,@matt char(10),@mancc char(10))
as
begin
if exists(select MaPN from PhieuNhap where MaPN=@mapn) print('Khong The Insert')
else
insert into PhieuNhap(MaPN,NgayLap,MaTT,MaNCC) values(@mapn,@ngaylap,@matt,@mancc)
end		
GO
/****** Object:  StoredProcedure [dbo].[Insert_Quyen]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Insert_Quyen]
	@MaQuyen VARCHAR(10),
    @XemSach bit,
    @SuaSach bit,
    @XoaSach bit,
    @ThemSach bit,
    @ThemNguoiDung bit,
    @XemNguoiDung bit,
    @SuaNguoiDung bit,
    @XoaNguoiDung bit,
    @XemMuonTra bit,
    @ThemMuonTra bit,
    @SuaMuonTra bit,
    @XoaMuonTra bit
AS
BEGIN
    INSERT INTO dbo.Quyen
    (
        MaQuyen,
        XemSach,
        SuaSach,
        XoaSach,
        ThemSach,
        ThemNguoiDung,
        XemNguoiDung,
        SuaNguoiDung,
        XoaNguoiDung,
        XemMuonTra,
        ThemMuonTra,
        SuaMuonTra,
        XoaMuonTra
    )
    VALUES
    (   @MaQuyen,
        @XemSach,
		@SuaSach,
		@XoaSach,
		@ThemSach,
		@ThemNguoiDung,
		@XemNguoiDung,
		@SuaNguoiDung,
		@XoaNguoiDung,
		@XemMuonTra,
		@ThemMuonTra,
		@SuaMuonTra,
		@XoaMuonTra
        )
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_SV]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Insert_SV]
	@MaSV varchar(10),
    @TenSV nvarchar(100),
    @MaLop varchar(10),
    @DienThoai varchar(20),
    @DiaChi nvarchar(200),
    @NgaySinh date,
    @GioiTinh nchar(5)
AS
BEGIN
    INSERT INTO dbo.SinhVien
    (
        MaSV,
        TenSV,
        MaLop,
        DienThoai,
        DiaChi,
        NgaySinh,
        GioiTinh
    )
    VALUES
    (   @MaSV,
		@TenSV,
		@MaLop,
		@DienThoai,
		@DiaChi,
		@NgaySinh,
		@GioiTinh
        )
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_TG]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
		

create proc [dbo].[Insert_TG](@matg char(10),@tentg nvarchar(50),@gioitinhtg nvarchar(3),@ngaysinhtg date,@quequantg nvarchar(50))
as
begin
if exists(select maTG from TacGia where maTG=@matg) print(N'Đã tồn tại!!!')
else
insert into TacGia(maTG,tenTG,gioiTinh,ngaySinh,queQuan) values(@matg,@tentg,@gioitinhtg,@ngaysinhtg,@quequantg)
end
GO
/****** Object:  StoredProcedure [dbo].[Insert_TS]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Insert_TS](@mats char(10),@tents nvarchar(50),@namxb int,@theloai nvarchar (30),@manxb char(10),@make char(10),@soluong int)
as
begin
if exists(select maTS from TuaSach where maTS=@mats) print(N'Đã tồn tại!!!')
else 
insert into TuaSach values(@mats,@tents,@namxb,@theloai,@manxb,@make,@soluong)
end
GO
/****** Object:  StoredProcedure [dbo].[Insert_TT]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--5. Thu Thu
CREATE proc [dbo].[Insert_TT](@matt char(10),@tentt nvarchar(30),@gioitinhtt nvarchar(3),@ngaysinhtt date,@diachitt nvarchar(50),@sdttt char(13),@Chucvu nvarchar(30))
as
begin
if exists(select maTT from ThuThu where maTT=@matt) print(N'Đã tồn tại!!!')
else
	insert into ThuThu values(@matt,@tentt,@ngaysinhtt,@gioitinhtt,@diachitt,@sdttt,@Chucvu)
end
GO
/****** Object:  StoredProcedure [dbo].[Insert_V]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
		

CREATE proc [dbo].[Insert_V](@mats char(10),@matg char(10),@sotrang int)
as
begin
if exists(select maTS,maTG from Viet where MaTS=@mats and MaTG=@matg) print('Khong the Insert')
else
insert into Viet values(@mats,@matg,@sotrang)
end
GO
/****** Object:  StoredProcedure [dbo].[Select_CS]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------Cuon sach-------------------------------
CREATE proc [dbo].[Select_CS]
as
begin
select MaCS, CuonSach.MaTS,TenTS from CuonSach, TuaSach
where CuonSach.MaTS=TuaSach.MaTS
end
 
GO
/****** Object:  StoredProcedure [dbo].[Select_CTM]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Select_CTM]
as
begin
select MaPM as[Số Phiếu Mượn Trả],MaCS as[Mã Cuốn Sách],TinhTrang as[Tình trạng]  from ChiTietMuon
end
GO
/****** Object:  StoredProcedure [dbo].[Select_CTN]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Select_CTN]
as
begin
select MaPN  ,ChiTietNhap.maTS ,tenTS ,ChiTietNhap.SoLuong ,donGia  
from ChiTietNhap,TuaSach 
where ChiTietNhap.maTS=TuaSach.maTS
end
GO
/****** Object:  StoredProcedure [dbo].[Select_DG]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Select_DG]
as
begin
select *from DocGia
end
GO
/****** Object:  StoredProcedure [dbo].[Select_GV]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Select_GV]
AS
BEGIN
    SELECT * FROM dbo.GiaoVien
END
GO
/****** Object:  StoredProcedure [dbo].[Select_KeSach]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------Ke Sach----------
CREATE proc [dbo].[Select_KeSach]
as
select KeSach.MaKe,ChatLieu,SucChua, SL from KeSach full join(select MaKe,count( MaCS) as SL from TuaSach,CuonSach where CuonSach.MaTS=TuaSach.MaTS
 group by MaKe)as temp on temp.MaKe=KeSach.MaKe

GO
/****** Object:  StoredProcedure [dbo].[Select_NCC]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

------------------------Nha cung cap--------------------------
CREATE proc [dbo].[Select_NCC]
as
begin
select * from NCC
end									
GO
/****** Object:  StoredProcedure [dbo].[Select_Nguoidung]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Select_Nguoidung]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM dbo.NguoiDung
END
GO
/****** Object:  StoredProcedure [dbo].[Select_NXB]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Select_NXB]
as
select* from NXB
GO
/****** Object:  StoredProcedure [dbo].[Select_PM]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Select_PM]
as
begin
	select PhieuMuon.MaPM,NgayMuon,NgayTra,PhieuMuon.MaDG,TenDG,PhieuMuon.MaTT, TenTT,ChiTietMuon.MaCS,TuaSach.MaTS,TenTS,TinhTrang
	from PhieuMuon, DocGia, ThuThu, ChiTietMuon, TuaSach,CuonSach
	where PhieuMuon.MaDG= DocGia.MaDG and PhieuMuon.MaTT=ThuThu.MaTT and PhieuMuon.MaPM=ChiTietMuon.MaPM
		and TuaSach.MaTS= CuonSach.MaTS and CuonSach.MaCS=ChiTietMuon.MaCS
end
GO
/****** Object:  StoredProcedure [dbo].[Select_PN]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-------------------------Phieu Nhap---------------------------------
CREATE proc [dbo].[Select_PN]
as
begin
select PhieuNhap.MaPN, NgayLap,PhieuNhap.MaTT,TenTT,TenNCC,ChiTietNhap.MaTS, TenTS,ChiTietNhap.SoLuong,DonGia, ChiTietNhap.SoLuong*DonGia as TT,TongTien
 from PhieuNhap, NCC, ThuThu,Chitietnhap, TuaSach
where PhieuNhap.MaNCC=NCC.MaNCC and PhieuNhap.MaTT=ThuThu.MaTT and ChiTietNhap.MaTS=TuaSach.MaTS and ChiTietNhap.MaPN=PhieuNhap.MaPN

end
GO
/****** Object:  StoredProcedure [dbo].[Select_PQ]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC	[dbo].[Select_PQ]
AS
BEGIN
    SELECT * FROM dbo.PhanQuyen
END
GO
/****** Object:  StoredProcedure [dbo].[Select_Quyen]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Select_Quyen]
AS
BEGIN
    SELECT * FROM dbo.Quyen
END
GO
/****** Object:  StoredProcedure [dbo].[Select_SV]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Select_SV]
AS
BEGIN
    SELECT * FROM dbo.SinhVien
END
GO
/****** Object:  StoredProcedure [dbo].[Select_TG]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------------Tac Gia-----------------------
CREATE proc [dbo].[Select_TG]
as
begin
select *from TacGia
end
GO
/****** Object:  StoredProcedure [dbo].[Select_TS]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


				----------------------------Tua Sach------------------------
CREATE proc [dbo].[Select_TS]
as
begin
select TuaSach.MaTS,TenTS,NamXB,TheLoai,SoTrang, MaKe,TenNXB,TenTG,SoLuong from TuaSach,TacGia,NXB,Viet
 where TuaSach.MaTS=Viet.MaTS and Viet.MaTG=TacGia.MaTG and TuaSach.MaNXB=NXB.MaNXB
end
GO
/****** Object:  StoredProcedure [dbo].[Select_TT]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Select_TT]
as
select *from ThuThu
GO
/****** Object:  StoredProcedure [dbo].[Select_V]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------Viet------------------
create proc [dbo].[Select_V]
as
begin
select maTS as[Mã Tựa Sách],maTG as[Mã Tác Giả],soTrang as[Số Trang] from Viet
end		
GO
/****** Object:  StoredProcedure [dbo].[test]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[test](@mats varchar(10),@tents nvarchar(50),@namxb int,@theloai nvarchar (30),@manxb char(10),@make char(10),@soluong int, @matg char(10), @sotrang int, @macs char(15))
as
begin
if exists(select maTS from TuaSach where maTS=@mats) print(N'Đã tồn tại!!!')
else 
insert into TuaSach (MaTS,TenTS,NamXB,TheLoai,MaNXB,MaKe,SoLuong) values(@mats,@tents,@namxb,@theloai,@manxb,@make,@soluong)
insert into Viet (MaTS,MaTG,SoTrang) values(@mats,@matg,@sotrang)
insert into CuonSach(MaTS,MaCS) values(@mats,@macs)
end
GO
/****** Object:  StoredProcedure [dbo].[Them_TS_V]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Them_TS_V](@mats varchar(10),@tents nvarchar(50),@namxb int,@theloai nvarchar (30),@manxb char(10),@make char(10),@soluong int, @matg char(10), @sotrang int)
as
begin
if exists(select maTS from TuaSach where maTS=@mats) print(N'Đã tồn tại!!!')
else 
insert into TuaSach (MaTS,TenTS,NamXB,TheLoai,MaNXB,MaKe,SoLuong) values(@mats,@tents,@namxb,@theloai,@manxb,@make,@soluong)
insert into Viet (MaTS,MaTG,SoTrang) values(@mats,@matg,@sotrang)
end
GO
/****** Object:  StoredProcedure [dbo].[ThongKe]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThongKe]
as
begin
select CuonSach.MaCS as DM from CuonSach, ChiTietMuon where CuonSach.MaCS=ChiTietMuon.MaCS
select CuonSach.MaCS as CM from CuonSach except select MaCS from ChiTietMuon
end
GO
/****** Object:  StoredProcedure [dbo].[Update_CTM]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Update_CTM](@mapm char(10),@macs char(10),@tinhtrang nvarchar(30) )
as
begin
	update ChiTietMuon
	set 
	TinhTrang=@tinhtrang
	where MaPM=@mapm and MaCS=@macs
end
GO
/****** Object:  StoredProcedure [dbo].[Update_CTN]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Update_CTN](@mapn char(10),@mats char(10),@soluong int,@dongia money)
as
begin
update ChiTietNhap
set
MaTS=@mats,
SoLuong=@soluong,
DonGia=@dongia
where MaPN=@mapn
end
GO
/****** Object:  StoredProcedure [dbo].[Update_DG]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Update_DG](@madg char(10),@iddg varchar(10),@tendg nvarchar(30),@gioitinhdg nvarchar(3),@ngaysinhdg date,@diachidg nvarchar(50), @sdtdg char(13))
as
begin
	update DocGia
	set tenDG=@tendg,
		DocGiaID = @iddg,
		gioiTinh=@gioitinhdg,
		ngaySinh=@ngaysinhdg,
		diaChi=@diachidg,
		SDT=@sdtdg
	where maDG=@madg
end
GO
/****** Object:  StoredProcedure [dbo].[Update_GV]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Update_GV]
@maGV VARCHAR(10), @tenGV NVARCHAR(100), @maKhoa VARCHAR(10), 
@sdtGV VARCHAR(20), @diachiGV NVARCHAR(200), @ngaysinhGV DATE, @gioitinhGV NCHAR(5)
AS
BEGIN
    UPDATE dbo.GiaoVien
	SET TenGV = @tenGV,
		MaKhoa = @maKhoa,
		DienThoai = @sdtGV,
		DiaChi = @diachiGV,
		NgaySinh = @ngaysinhGV,
		GioiTinh = @gioitinhGV
	WHERE MaGV = @maGV
END
GO
/****** Object:  StoredProcedure [dbo].[Update_KeSach]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Update_KeSach](@make char(10),@chatlieu nvarchar(30), @succhua int)
as
begin
update KeSach
set 
	ChatLieu=@chatlieu,
	SucChua=@succhua
where MaKe=@make
end

GO
/****** Object:  StoredProcedure [dbo].[Update_Khoa]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Update_Khoa]
	@MaKhoa varchar(10),
    @TenKhoa nvarchar(50)
AS
BEGIN
    UPDATE dbo.Khoa
	SET	TenKhoa = @TenKhoa
	WHERE MaKhoa = @MaKhoa
END
GO
/****** Object:  StoredProcedure [dbo].[Update_Lop]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Update_Lop]
	@MaLop varchar(10),
	@MaKhoa VARCHAR(10)
AS
BEGIN
    UPDATE dbo.Lop
	SET	 MaKhoa = @MaKhoa
	WHERE MaLop = @MaLop
END
GO
/****** Object:  StoredProcedure [dbo].[Update_NCC]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Update_NCC](@mancc char(10),@tenncc nvarchar(50),@diachincc nvarchar(50),@sdtncc char(13),@email char(40))
as
begin 
update NCC
set tenNCC=@tenncc,
diaChi=@diachincc,
SDT=@sdtncc,
Email=@email
where maNCC=@mancc
end		
GO
/****** Object:  StoredProcedure [dbo].[Update_Nguoidung]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Update_Nguoidung]
	@MaNguoiDung VARCHAR(10),
	@MaTT CHAR(10),
	@MatKhau VARCHAR(20)
AS
BEGIN
	UPDATE dbo.NguoiDung
	SET MaTT = @MaTT, MatKhau = @MatKhau
	WHERE MaNguoiDung = @MaNguoiDung
END
GO
/****** Object:  StoredProcedure [dbo].[Update_NXB]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Update_NXB](@manxb char(10),@tennxb nvarchar(50),@diachinxb nvarchar(30),@sdtnxb char(13),@emailnxb char(50))
as
begin
update NXB
set tenNXB=@tennxb,
	diaChi=@diachinxb,
	SDT=@sdtnxb,
	email=@emailnxb
	where maNXB=@manxb
end
GO
/****** Object:  StoredProcedure [dbo].[Update_PhieuMuon]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[Update_PhieuMuon](@mapm char(10),@ngaymuon date,@ngaytra date, @madg char(10),@matt char(10),@macs char(10),@tinhtrang nvarchar(30))
as
begin
update PhieuMuon
	set NgayMuon=@ngaymuon,
		NgayTra =@ngaytra,
		MaDG = @madg,
		MaTT = @matt
	where MaPM = @mapm
update ChiTietMuon
	set 
	TinhTrang=@tinhtrang
	where MaPM=@mapm and MaCS=@macs
end
GO
/****** Object:  StoredProcedure [dbo].[Update_PhieuNhap]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[Update_PhieuNhap](@mapn char(10),@ngaylap date,@matt char(10),@mancc char(10),@mats varchar(10),@soluong int,@dongia int)
as
begin
update PhieuNhap
set ngayLap=@ngaylap,
maTT=@matt,
maNCC=@mancc
where MaPN=@mapn
update ChiTietNhap
set
MaTS=@mats,
SoLuong=@soluong,
DonGia=@dongia
where MaPN=@mapn
end
GO
/****** Object:  StoredProcedure [dbo].[Update_PM]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Update_PM](@mapm char(10),@ngaymuon date,@ngaytra date,  @madg char(10),@matt char(10))
as
begin
	update PhieuMuon
	set NgayMuon=@ngaymuon,
		NgayTra =@ngaytra,
		MaDG = @madg,
		MaTT = @matt
	where MaPM = @mapm
end
GO
/****** Object:  StoredProcedure [dbo].[Update_PN]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Update_PN](@MaPN char(10),@ngaylap date,@matt char(10),@mancc char(10))
as
begin
update PhieuNhap
set ngayLap=@ngaylap,
maTT=@matt,
maNCC=@mancc
where MaPN=@MaPN
end		
GO
/****** Object:  StoredProcedure [dbo].[Update_SV]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE	 PROC [dbo].[Update_SV]
@maSV VARCHAR(10), @tenSV NVARCHAR(100), @maLop VARCHAR(10), 
@sdtSV VARCHAR(20), @diachiSV NVARCHAR(200), @ngaysinhSV DATE, @gioitinhSV NCHAR(5)
AS
BEGIN
    UPDATE dbo.SinhVien
	SET TenSV = @tenSV,
		MaLop = @maLop,
		DienThoai = @sdtSV,
		DiaChi = @diachiSV,
		NgaySinh = @ngaysinhSV,
		GioiTinh = @gioitinhSV
	WHERE MaSV = @maSV
END
GO
/****** Object:  StoredProcedure [dbo].[Update_TG]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[Update_TG](@matg char(10),@tentg nvarchar(50),@gioitinhtg nvarchar(3),@ngaysinhtg date,@quequantg nvarchar(50))
as
begin
update TacGia
set tenTG=@tentg,
gioiTinh=@gioitinhtg,
ngaySinh=@ngaysinhtg,
queQuan=@quequantg
where maTG=@matg
end
GO
/****** Object:  StoredProcedure [dbo].[Update_TS]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE proc [dbo].[Update_TS](@mats char(10),@tents nvarchar(50),@namxb int,@theloai nvarchar (30),@manxb char(10),@make char(10),@soluong int)
as
begin
update TuaSach
set tenTS=@tents,
	namXB=@namxb,
	TheLoai=@theloai,
	maNXB = @manxb,
	SoLuong=@soluong
where maTS=@mats
end
GO
/****** Object:  StoredProcedure [dbo].[Update_TT]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Update_TT](@matt char(10),@tentt nvarchar(30),@gioitinhtt nvarchar(3),@ngaysinhtt date,@diachitt nvarchar(50),@sdttt char(13),@Chucvu nvarchar(30))
as
begin
	update ThuThu
	set TenTT = @tentt,
		gioiTinh=@gioitinhtt,
		ngaySinh=@ngaysinhtt,
		diaChi=@diachitt,
		SDT=@sdttt,
		Chucvu=@Chucvu
	where maTT=@matt
end
GO
/****** Object:  StoredProcedure [dbo].[Update_V]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Update_V](@mats char(10),@matg char(10),@sotrang int)
as
begin
update Viet
set soTrang=@sotrang
where maTS=@mats and maTG=@matg
end
GO
/****** Object:  StoredProcedure [dbo].[Xoa_TS_V]    Script Date: 05/24/2023 7:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Xoa_TS_V](@macs char(15),@mats varchar(10))
as
begin
delete CuonSach
where MaCS=@macs
delete TuaSach
where maTS=@mats
delete Viet
where MaTS=@mats
end
GO
USE [master]
GO
ALTER DATABASE [QuanLyThuVien] SET  READ_WRITE 
GO
