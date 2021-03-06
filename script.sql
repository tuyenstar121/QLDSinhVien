USE [master]
GO
/****** Object:  Database [QLDSV_TC]    Script Date: 6/12/2022 9:28:30 PM ******/
CREATE DATABASE [QLDSV_TC]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLDSV_TC', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLDSV_TC.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLDSV_TC_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLDSV_TC_log.ldf' , SIZE = 2368KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLDSV_TC] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLDSV_TC].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLDSV_TC] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLDSV_TC] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLDSV_TC] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLDSV_TC] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLDSV_TC] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLDSV_TC] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLDSV_TC] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLDSV_TC] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLDSV_TC] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLDSV_TC] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLDSV_TC] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLDSV_TC] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLDSV_TC] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLDSV_TC] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLDSV_TC] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLDSV_TC] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLDSV_TC] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLDSV_TC] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLDSV_TC] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLDSV_TC] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLDSV_TC] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLDSV_TC] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLDSV_TC] SET RECOVERY FULL 
GO
ALTER DATABASE [QLDSV_TC] SET  MULTI_USER 
GO
ALTER DATABASE [QLDSV_TC] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLDSV_TC] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLDSV_TC] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLDSV_TC] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLDSV_TC] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLDSV_TC', N'ON'
GO
USE [QLDSV_TC]
GO
/****** Object:  User [N15DCCN002]    Script Date: 6/12/2022 9:28:30 PM ******/
CREATE USER [N15DCCN002] FOR LOGIN [sv2] WITH DEFAULT_SCHEMA=[N15DCCN002]
GO
/****** Object:  User [N15DCCN001]    Script Date: 6/12/2022 9:28:30 PM ******/
CREATE USER [N15DCCN001] FOR LOGIN [sv1] WITH DEFAULT_SCHEMA=[N15DCCN001]
GO
/****** Object:  User [GV04]    Script Date: 6/12/2022 9:28:30 PM ******/
CREATE USER [GV04] FOR LOGIN [khoa2] WITH DEFAULT_SCHEMA=[GV04]
GO
/****** Object:  User [GV03]    Script Date: 6/12/2022 9:28:30 PM ******/
CREATE USER [GV03] FOR LOGIN [pgv2] WITH DEFAULT_SCHEMA=[GV03]
GO
/****** Object:  User [GV02]    Script Date: 6/12/2022 9:28:30 PM ******/
CREATE USER [GV02] FOR LOGIN [khoa1] WITH DEFAULT_SCHEMA=[GV02]
GO
/****** Object:  User [GV01]    Script Date: 6/12/2022 9:28:30 PM ******/
CREATE USER [GV01] FOR LOGIN [pgv1] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [SinhVien]    Script Date: 6/12/2022 9:28:30 PM ******/
CREATE ROLE [SinhVien]
GO
/****** Object:  DatabaseRole [PGV]    Script Date: 6/12/2022 9:28:30 PM ******/
CREATE ROLE [PGV]
GO
/****** Object:  DatabaseRole [Khoa]    Script Date: 6/12/2022 9:28:30 PM ******/
CREATE ROLE [Khoa]
GO
/****** Object:  DatabaseRole [BGH]    Script Date: 6/12/2022 9:28:30 PM ******/
CREATE ROLE [BGH]
GO
ALTER ROLE [SinhVien] ADD MEMBER [N15DCCN002]
GO
ALTER ROLE [SinhVien] ADD MEMBER [N15DCCN001]
GO
ALTER ROLE [PGV] ADD MEMBER [GV03]
GO
ALTER ROLE [db_owner] ADD MEMBER [GV03]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [GV03]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [GV03]
GO
ALTER ROLE [db_datareader] ADD MEMBER [GV03]
GO
ALTER ROLE [Khoa] ADD MEMBER [GV02]
GO
ALTER ROLE [db_datareader] ADD MEMBER [GV02]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [GV02]
GO
ALTER ROLE [PGV] ADD MEMBER [GV01]
GO
ALTER ROLE [db_owner] ADD MEMBER [GV01]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [GV01]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [GV01]
GO
ALTER ROLE [db_datareader] ADD MEMBER [GV01]
GO
ALTER ROLE [db_owner] ADD MEMBER [PGV]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [PGV]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [PGV]
GO
ALTER ROLE [db_datareader] ADD MEMBER [PGV]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Khoa]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Khoa]
GO
ALTER ROLE [db_owner] ADD MEMBER [BGH]
GO
/****** Object:  Schema [GV02]    Script Date: 6/12/2022 9:28:31 PM ******/
CREATE SCHEMA [GV02]
GO
/****** Object:  Schema [GV03]    Script Date: 6/12/2022 9:28:31 PM ******/
CREATE SCHEMA [GV03]
GO
/****** Object:  Schema [GV04]    Script Date: 6/12/2022 9:28:31 PM ******/
CREATE SCHEMA [GV04]
GO
/****** Object:  Schema [N15DCCN001]    Script Date: 6/12/2022 9:28:31 PM ******/
CREATE SCHEMA [N15DCCN001]
GO
/****** Object:  Schema [N15DCCN002]    Script Date: 6/12/2022 9:28:31 PM ******/
CREATE SCHEMA [N15DCCN002]
GO
/****** Object:  Table [dbo].[DANGKY]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANGKY](
	[MALTC] [int] NOT NULL,
	[MASV] [nchar](10) NOT NULL,
	[DIEM_CC] [int] NULL,
	[DIEM_GK] [float] NULL,
	[DIEM_CK] [float] NULL,
	[HUYDANGKY] [bit] NULL,
 CONSTRAINT [PK_DANGKY] PRIMARY KEY CLUSTERED 
(
	[MALTC] ASC,
	[MASV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GIANGVIEN]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIANGVIEN](
	[MAGV] [nchar](10) NOT NULL,
	[MAKHOA] [nchar](10) NOT NULL,
	[HO] [nvarchar](50) NOT NULL,
	[TEN] [nvarchar](10) NOT NULL,
	[HOCVI] [nvarchar](20) NULL,
	[HOCHAM] [nvarchar](20) NULL,
	[CHUYENMON] [nvarchar](50) NULL,
 CONSTRAINT [PK_GIANGVIEN] PRIMARY KEY CLUSTERED 
(
	[MAGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHOA]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOA](
	[MAKHOA] [nchar](10) NOT NULL,
	[TENKHOA] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_KHOA] PRIMARY KEY CLUSTERED 
(
	[MAKHOA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOP]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOP](
	[MALOP] [nchar](10) NOT NULL,
	[TENLOP] [nvarchar](50) NOT NULL,
	[KHOAHOC] [nchar](9) NOT NULL,
	[MAKHOA] [nchar](10) NOT NULL,
 CONSTRAINT [PK_LOP] PRIMARY KEY CLUSTERED 
(
	[MALOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOPTINCHI]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOPTINCHI](
	[MALTC] [int] IDENTITY(1,1) NOT NULL,
	[NIENKHOA] [nchar](9) NOT NULL,
	[HOCKY] [int] NOT NULL,
	[MAMH] [nchar](10) NOT NULL,
	[NHOM] [int] NOT NULL,
	[MAGV] [nchar](10) NOT NULL,
	[MAKHOA] [nchar](10) NOT NULL,
	[SOSVTOITHIEU] [int] NOT NULL,
	[HUYLOP] [bit] NOT NULL CONSTRAINT [DF_LOPTINCHI_HUYLOP]  DEFAULT ('false'),
 CONSTRAINT [PK_LOPTINCHI] PRIMARY KEY CLUSTERED 
(
	[MALTC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONHOC](
	[MAMH] [nchar](10) NOT NULL,
	[TENMH] [nvarchar](50) NOT NULL,
	[SOTIET_LT] [int] NOT NULL,
	[SOTIET_TH] [int] NOT NULL,
 CONSTRAINT [PK_MONHOC] PRIMARY KEY CLUSTERED 
(
	[MAMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[MASV] [nchar](10) NOT NULL,
	[HO] [nvarchar](50) NOT NULL,
	[TEN] [nvarchar](10) NOT NULL,
	[PHAI] [bit] NOT NULL CONSTRAINT [DF_SINHVIEN_PHAI]  DEFAULT ('false'),
	[DIACHI] [nvarchar](100) NULL,
	[NGAYSINH] [date] NULL,
	[MALOP] [nchar](10) NOT NULL,
	[PASSWORD] [nvarchar](40) NULL CONSTRAINT [DF_SINHVIEN_PASSWORD]  DEFAULT (''),
 CONSTRAINT [PK_SINHVIEN] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[View_1]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_1]
AS
SELECT    dbo.MONHOC.TENMH, dbo.SINHVIEN.TEN, dbo.SINHVIEN.HO
FROM         dbo.SINHVIEN INNER JOIN
                      dbo.DANGKY ON dbo.SINHVIEN.MASV = dbo.DANGKY.MASV INNER JOIN
                      dbo.LOPTINCHI ON dbo.DANGKY.MALTC = dbo.LOPTINCHI.MALTC INNER JOIN
                      dbo.MONHOC ON dbo.LOPTINCHI.MAMH = dbo.MONHOC.MAMH

GO
INSERT [dbo].[DANGKY] ([MALTC], [MASV], [DIEM_CC], [DIEM_GK], [DIEM_CK], [HUYDANGKY]) VALUES (1, N'N15DCCN001', 10, 8, 10, 0)
INSERT [dbo].[DANGKY] ([MALTC], [MASV], [DIEM_CC], [DIEM_GK], [DIEM_CK], [HUYDANGKY]) VALUES (1, N'N15DCCN002', 10, 10, 5, 0)
INSERT [dbo].[DANGKY] ([MALTC], [MASV], [DIEM_CC], [DIEM_GK], [DIEM_CK], [HUYDANGKY]) VALUES (1, N'N15DCCN003', 3, 10, 0, 0)
INSERT [dbo].[DANGKY] ([MALTC], [MASV], [DIEM_CC], [DIEM_GK], [DIEM_CK], [HUYDANGKY]) VALUES (1, N'N15DCCN004', 0, 0, 0, 0)
INSERT [dbo].[DANGKY] ([MALTC], [MASV], [DIEM_CC], [DIEM_GK], [DIEM_CK], [HUYDANGKY]) VALUES (1, N'N15DCCN005', 5, 7, 6, 0)
INSERT [dbo].[DANGKY] ([MALTC], [MASV], [DIEM_CC], [DIEM_GK], [DIEM_CK], [HUYDANGKY]) VALUES (1, N'N15DCCN006', 10, 9, 10, 0)
INSERT [dbo].[DANGKY] ([MALTC], [MASV], [DIEM_CC], [DIEM_GK], [DIEM_CK], [HUYDANGKY]) VALUES (2, N'N15DCCN001', 10, 8, 8, 0)
INSERT [dbo].[DANGKY] ([MALTC], [MASV], [DIEM_CC], [DIEM_GK], [DIEM_CK], [HUYDANGKY]) VALUES (2, N'N15DCCN004', 10, 5, 10, 0)
INSERT [dbo].[DANGKY] ([MALTC], [MASV], [DIEM_CC], [DIEM_GK], [DIEM_CK], [HUYDANGKY]) VALUES (3, N'N15DCCN001', 0, 0, 0, 0)
INSERT [dbo].[DANGKY] ([MALTC], [MASV], [DIEM_CC], [DIEM_GK], [DIEM_CK], [HUYDANGKY]) VALUES (3, N'N15DCCN002', 0, 0, 0, 0)
INSERT [dbo].[DANGKY] ([MALTC], [MASV], [DIEM_CC], [DIEM_GK], [DIEM_CK], [HUYDANGKY]) VALUES (3, N'N15DCCN003', 10, 10, 8, 0)
INSERT [dbo].[DANGKY] ([MALTC], [MASV], [DIEM_CC], [DIEM_GK], [DIEM_CK], [HUYDANGKY]) VALUES (3, N'N15DCCN004', 0, 0, 0, 0)
INSERT [dbo].[DANGKY] ([MALTC], [MASV], [DIEM_CC], [DIEM_GK], [DIEM_CK], [HUYDANGKY]) VALUES (3, N'N15DCCN005', 0, 0, 0, 0)
INSERT [dbo].[DANGKY] ([MALTC], [MASV], [DIEM_CC], [DIEM_GK], [DIEM_CK], [HUYDANGKY]) VALUES (4, N'N15DCCN001', NULL, NULL, NULL, 0)
INSERT [dbo].[DANGKY] ([MALTC], [MASV], [DIEM_CC], [DIEM_GK], [DIEM_CK], [HUYDANGKY]) VALUES (4, N'N15DCVT002', NULL, NULL, NULL, 0)
INSERT [dbo].[DANGKY] ([MALTC], [MASV], [DIEM_CC], [DIEM_GK], [DIEM_CK], [HUYDANGKY]) VALUES (5, N'N15DCCN001', NULL, NULL, NULL, 0)
INSERT [dbo].[DANGKY] ([MALTC], [MASV], [DIEM_CC], [DIEM_GK], [DIEM_CK], [HUYDANGKY]) VALUES (6, N'N15DCCN001', NULL, NULL, NULL, 0)
INSERT [dbo].[DANGKY] ([MALTC], [MASV], [DIEM_CC], [DIEM_GK], [DIEM_CK], [HUYDANGKY]) VALUES (8, N'N15DCCN001', NULL, NULL, NULL, 0)
INSERT [dbo].[DANGKY] ([MALTC], [MASV], [DIEM_CC], [DIEM_GK], [DIEM_CK], [HUYDANGKY]) VALUES (8, N'N15DCVT002', NULL, NULL, NULL, 0)
INSERT [dbo].[DANGKY] ([MALTC], [MASV], [DIEM_CC], [DIEM_GK], [DIEM_CK], [HUYDANGKY]) VALUES (11, N'N15DCCN001', NULL, NULL, NULL, 0)
INSERT [dbo].[DANGKY] ([MALTC], [MASV], [DIEM_CC], [DIEM_GK], [DIEM_CK], [HUYDANGKY]) VALUES (12, N'N15DCCN001', NULL, NULL, NULL, 0)
INSERT [dbo].[DANGKY] ([MALTC], [MASV], [DIEM_CC], [DIEM_GK], [DIEM_CK], [HUYDANGKY]) VALUES (13, N'N15DCCN001', NULL, NULL, NULL, 0)
INSERT [dbo].[GIANGVIEN] ([MAGV], [MAKHOA], [HO], [TEN], [HOCVI], [HOCHAM], [CHUYENMON]) VALUES (N'GV01      ', N'CNTT      ', N'Lưu Nguyễn Kỳ', N'Thư', N'Thạc sĩ', N'', N'Phần mềm')
INSERT [dbo].[GIANGVIEN] ([MAGV], [MAKHOA], [HO], [TEN], [HOCVI], [HOCHAM], [CHUYENMON]) VALUES (N'GV02      ', N'CNTT      ', N'Lê Thành', N'Trì', N'Thạc sĩ', N'', N'Mạng máy tính')
INSERT [dbo].[GIANGVIEN] ([MAGV], [MAKHOA], [HO], [TEN], [HOCVI], [HOCHAM], [CHUYENMON]) VALUES (N'GV03      ', N'CNTT      ', N'Huỳnh Trung', N'Trụ', N'Thạc sĩ', N'', N'Web, Phần mềm')
INSERT [dbo].[GIANGVIEN] ([MAGV], [MAKHOA], [HO], [TEN], [HOCVI], [HOCHAM], [CHUYENMON]) VALUES (N'GV04      ', N'VT        ', N'Nguyễn Quốc', N'Minh', N'Tiến sĩ', NULL, N'Truyền thông')
INSERT [dbo].[GIANGVIEN] ([MAGV], [MAKHOA], [HO], [TEN], [HOCVI], [HOCHAM], [CHUYENMON]) VALUES (N'GV05      ', N'CNTT      ', N'Châu Minh', N'Lâm', N'Tiến sĩ', NULL, N'Xử lý ảnh')
INSERT [dbo].[GIANGVIEN] ([MAGV], [MAKHOA], [HO], [TEN], [HOCVI], [HOCHAM], [CHUYENMON]) VALUES (N'GV06      ', N'CNTT      ', N'Nguyễn Văn', N'Sáu', N'Thạc Sĩ', NULL, N'Phần mềm')
INSERT [dbo].[GIANGVIEN] ([MAGV], [MAKHOA], [HO], [TEN], [HOCVI], [HOCHAM], [CHUYENMON]) VALUES (N'GV07      ', N'VT        ', N'Nguyễn Minh ', N'Phương', N'Giáo Sư', NULL, N'Truyền Thông')
INSERT [dbo].[GIANGVIEN] ([MAGV], [MAKHOA], [HO], [TEN], [HOCVI], [HOCHAM], [CHUYENMON]) VALUES (N'GV08      ', N'VT        ', N'Đỗ Văn ', N'Tuấn', N'Phó Giáo Sư', NULL, N'Phần Mèm')
INSERT [dbo].[GIANGVIEN] ([MAGV], [MAKHOA], [HO], [TEN], [HOCVI], [HOCHAM], [CHUYENMON]) VALUES (N'GV09      ', N'CNTT      ', N'Trần Văn', N'Tuấn', N'Tiến Sĩ', NULL, N'Phần Mềm')
INSERT [dbo].[KHOA] ([MAKHOA], [TENKHOA]) VALUES (N'CNTT      ', N'Công nghệ thông tin')
INSERT [dbo].[KHOA] ([MAKHOA], [TENKHOA]) VALUES (N'VT        ', N'Viễn Thông')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [KHOAHOC], [MAKHOA]) VALUES (N'D15CQCP01 ', N'Công nghệ phần mềm 2015', N'2015-2019', N'CNTT      ')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [KHOAHOC], [MAKHOA]) VALUES (N'D15CQIS01 ', N'Hệ thống thông tin 2017', N'2015-2020', N'CNTT      ')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [KHOAHOC], [MAKHOA]) VALUES (N'D15CQVT01 ', N'Thông tin truyền thông 2015', N'2015-2019', N'VT        ')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [KHOAHOC], [MAKHOA]) VALUES (N'D16CQCP01 ', N'Công Nghệ Phần Mềm 2016', N'2016-2020', N'CNTT      ')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [KHOAHOC], [MAKHOA]) VALUES (N'D16CQVT01 ', N'Thông tin truyền thông 2016', N'2016-2020', N'VT        ')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [KHOAHOC], [MAKHOA]) VALUES (N'D17CQVT01 ', N'Thông Tin Truyền Thông 2017', N'2017-2021', N'VT        ')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [KHOAHOC], [MAKHOA]) VALUES (N'D19CQCN01 ', N'Công Nghệ Phần Mềm 2019', N'2019-2023', N'CNTT      ')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [KHOAHOC], [MAKHOA]) VALUES (N'D19QCQN3  ', N'Công Nghệ Thông Tin 2019', N'2019-2024', N'CNTT      ')
SET IDENTITY_INSERT [dbo].[LOPTINCHI] ON 

INSERT [dbo].[LOPTINCHI] ([MALTC], [NIENKHOA], [HOCKY], [MAMH], [NHOM], [MAGV], [MAKHOA], [SOSVTOITHIEU], [HUYLOP]) VALUES (1, N'2021-2022', 1, N'CTDL      ', 1, N'GV01      ', N'CNTT      ', 10, 0)
INSERT [dbo].[LOPTINCHI] ([MALTC], [NIENKHOA], [HOCKY], [MAMH], [NHOM], [MAGV], [MAKHOA], [SOSVTOITHIEU], [HUYLOP]) VALUES (2, N'2021-2022', 1, N'CTDL      ', 2, N'GV01      ', N'CNTT      ', 10, 0)
INSERT [dbo].[LOPTINCHI] ([MALTC], [NIENKHOA], [HOCKY], [MAMH], [NHOM], [MAGV], [MAKHOA], [SOSVTOITHIEU], [HUYLOP]) VALUES (3, N'2021-2022', 1, N'AV        ', 1, N'GV05      ', N'CNTT      ', 10, 0)
INSERT [dbo].[LOPTINCHI] ([MALTC], [NIENKHOA], [HOCKY], [MAMH], [NHOM], [MAGV], [MAKHOA], [SOSVTOITHIEU], [HUYLOP]) VALUES (4, N'2021-2022', 1, N'CTDL      ', 3, N'GV04      ', N'VT        ', 10, 0)
INSERT [dbo].[LOPTINCHI] ([MALTC], [NIENKHOA], [HOCKY], [MAMH], [NHOM], [MAGV], [MAKHOA], [SOSVTOITHIEU], [HUYLOP]) VALUES (5, N'2021-2022', 2, N'LTW       ', 1, N'GV03      ', N'CNTT      ', 10, 0)
INSERT [dbo].[LOPTINCHI] ([MALTC], [NIENKHOA], [HOCKY], [MAMH], [NHOM], [MAGV], [MAKHOA], [SOSVTOITHIEU], [HUYLOP]) VALUES (6, N'2021-2022', 2, N'KTDH      ', 1, N'GV06      ', N'CNTT      ', 10, 0)
INSERT [dbo].[LOPTINCHI] ([MALTC], [NIENKHOA], [HOCKY], [MAMH], [NHOM], [MAGV], [MAKHOA], [SOSVTOITHIEU], [HUYLOP]) VALUES (8, N'2021-2022', 2, N'MMT       ', 1, N'GV02      ', N'CNTT      ', 10, 0)
INSERT [dbo].[LOPTINCHI] ([MALTC], [NIENKHOA], [HOCKY], [MAMH], [NHOM], [MAGV], [MAKHOA], [SOSVTOITHIEU], [HUYLOP]) VALUES (11, N'2021-2022', 2, N'AV        ', 1, N'GV06      ', N'CNTT      ', 10, 0)
INSERT [dbo].[LOPTINCHI] ([MALTC], [NIENKHOA], [HOCKY], [MAMH], [NHOM], [MAGV], [MAKHOA], [SOSVTOITHIEU], [HUYLOP]) VALUES (12, N'2022-2023', 2, N'AV        ', 3, N'GV05      ', N'VT        ', 5, 0)
INSERT [dbo].[LOPTINCHI] ([MALTC], [NIENKHOA], [HOCKY], [MAMH], [NHOM], [MAGV], [MAKHOA], [SOSVTOITHIEU], [HUYLOP]) VALUES (13, N'2021-2022', 1, N'LTW       ', 3, N'GV03      ', N'CNTT      ', 7, 0)
INSERT [dbo].[LOPTINCHI] ([MALTC], [NIENKHOA], [HOCKY], [MAMH], [NHOM], [MAGV], [MAKHOA], [SOSVTOITHIEU], [HUYLOP]) VALUES (17, N'2022-2023', 2, N'HDH       ', 5, N'GV01      ', N'VT        ', 6, 0)
SET IDENTITY_INSERT [dbo].[LOPTINCHI] OFF
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [SOTIET_LT], [SOTIET_TH]) VALUES (N'AV        ', N'Anh văn', 44, 0)
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [SOTIET_LT], [SOTIET_TH]) VALUES (N'CTDL      ', N'Cấu trúc dữ liệu & Giải thuật', 45, 0)
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [SOTIET_LT], [SOTIET_TH]) VALUES (N'GT1       ', N'Giải Tích 1', 30, 15)
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [SOTIET_LT], [SOTIET_TH]) VALUES (N'GT3       ', N'Giải Tich', 15, 0)
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [SOTIET_LT], [SOTIET_TH]) VALUES (N'HDH       ', N'Hệ điều hành', 45, 0)
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [SOTIET_LT], [SOTIET_TH]) VALUES (N'KTDH      ', N'Kỹ thuật đồ họa1', 45, 0)
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [SOTIET_LT], [SOTIET_TH]) VALUES (N'LTW       ', N'Lập trình Web', 45, 15)
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [SOTIET_LT], [SOTIET_TH]) VALUES (N'MMT       ', N'Mạng máy tính', 30, 15)
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [SOTIET_LT], [SOTIET_TH]) VALUES (N'TTCS      ', N'Thực Tập Cở Sở', 30, 15)
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [SOTIET_LT], [SOTIET_TH]) VALUES (N'TRR       ', N'Toán Rời Rạt', 30, 15)
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [SOTIET_LT], [SOTIET_TH]) VALUES (N'XLA       ', N'Xử Lý Ảnh', 30, 0)
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [MALOP], [PASSWORD]) VALUES (N'N15DCCN001', N'Võ Văn', N'Đức', 0, N'Quận 9', CAST(N'1997-02-08' AS Date), N'D15CQCP01 ', N'')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [MALOP], [PASSWORD]) VALUES (N'N15DCCN002', N'Lê Hữu', N'Tài', 0, N'Thủ Đức', CAST(N'1997-03-07' AS Date), N'D15CQCP01 ', N'')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [MALOP], [PASSWORD]) VALUES (N'N15DCCN003', N'Hoàng Thanh', N'Bùi', 0, N'Quận 9', CAST(N'1997-08-07' AS Date), N'D15CQCP01 ', N'')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [MALOP], [PASSWORD]) VALUES (N'N15DCCN004', N'Phạm', N'Tuấn', 0, N'Quận 9', CAST(N'1997-10-11' AS Date), N'D15CQCP01 ', N'')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [MALOP], [PASSWORD]) VALUES (N'N15DCCN005', N'Lê Thanh', N'Hà', 1, N'Quận 4', CAST(N'1997-08-29' AS Date), N'D15CQIS01 ', N'')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [MALOP], [PASSWORD]) VALUES (N'N15DCCN006', N'Tiền Hà', N'Nam', 0, N'Thủ Đức', CAST(N'1997-10-09' AS Date), N'D15CQIS01 ', N'')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [MALOP], [PASSWORD]) VALUES (N'N15DCCN007', N'Bùi Thị', N'Thanh', 1, N'Q.9', CAST(N'1997-07-07' AS Date), N'D15CQIS01 ', N'')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [MALOP], [PASSWORD]) VALUES (N'N15DCCN008', N'Lê Thanh', N'Bình', 0, N'Thủ Đức', CAST(N'1996-07-07' AS Date), N'D15CQIS01 ', N'')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [MALOP], [PASSWORD]) VALUES (N'N15DCVT001', N'Huỳnh Văn', N'Nghĩa', 0, N'Quận 9', CAST(N'1996-07-29' AS Date), N'D15CQVT01 ', N'')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [MALOP], [PASSWORD]) VALUES (N'N15DCVT002', N'Nguyễn Anh', N'Tài', 0, N'Thủ Đức', CAST(N'1997-07-29' AS Date), N'D15CQVT01 ', N'')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [MALOP], [PASSWORD]) VALUES (N'N15DCVT003', N'Phan', N'Tuấn', 0, N'Thủ Đức', CAST(N'1997-08-28' AS Date), N'D15CQVT01 ', N'')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [MALOP], [PASSWORD]) VALUES (N'N16DCVT001', N'Trần Thanh', N'Phan', 1, N'Thủ Đức', CAST(N'1998-07-12' AS Date), N'D16CQVT01 ', N'')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [MALOP], [PASSWORD]) VALUES (N'N16DCVT002', N'Nguyễn Thanh', N'Hoàng', 0, N'Thủ Đức', CAST(N'1998-02-03' AS Date), N'D15CQCP01 ', N'')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [MALOP], [PASSWORD]) VALUES (N'N19DCCN148', N'Nguyen Minh', N'Phuong', 0, N'Tphcm', CAST(N'2001-10-05' AS Date), N'D15CQCP01 ', N'')
SET ANSI_PADDING ON

GO
/****** Object:  Index [UK_DANGKY]    Script Date: 6/12/2022 9:28:31 PM ******/
ALTER TABLE [dbo].[DANGKY] ADD  CONSTRAINT [UK_DANGKY] UNIQUE NONCLUSTERED 
(
	[MALTC] ASC,
	[MASV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UK_LOPTINCHI]    Script Date: 6/12/2022 9:28:31 PM ******/
ALTER TABLE [dbo].[LOPTINCHI] ADD  CONSTRAINT [UK_LOPTINCHI] UNIQUE NONCLUSTERED 
(
	[NIENKHOA] ASC,
	[HOCKY] ASC,
	[MAMH] ASC,
	[NHOM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_MALOP]    Script Date: 6/12/2022 9:28:31 PM ******/
CREATE NONCLUSTERED INDEX [IX_MALOP] ON [dbo].[SINHVIEN]
(
	[MALOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DANGKY]  WITH CHECK ADD  CONSTRAINT [FK_CTLTC_SINHVIEN] FOREIGN KEY([MASV])
REFERENCES [dbo].[SINHVIEN] ([MASV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[DANGKY] CHECK CONSTRAINT [FK_CTLTC_SINHVIEN]
GO
ALTER TABLE [dbo].[DANGKY]  WITH CHECK ADD  CONSTRAINT [FK_DANGKY_LOPTINCHI] FOREIGN KEY([MALTC])
REFERENCES [dbo].[LOPTINCHI] ([MALTC])
GO
ALTER TABLE [dbo].[DANGKY] CHECK CONSTRAINT [FK_DANGKY_LOPTINCHI]
GO
ALTER TABLE [dbo].[GIANGVIEN]  WITH CHECK ADD  CONSTRAINT [FK_GIANGVIEN_KHOA] FOREIGN KEY([MAKHOA])
REFERENCES [dbo].[KHOA] ([MAKHOA])
GO
ALTER TABLE [dbo].[GIANGVIEN] CHECK CONSTRAINT [FK_GIANGVIEN_KHOA]
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD  CONSTRAINT [FK_LOP_KHOA] FOREIGN KEY([MAKHOA])
REFERENCES [dbo].[KHOA] ([MAKHOA])
GO
ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [FK_LOP_KHOA]
GO
ALTER TABLE [dbo].[LOPTINCHI]  WITH CHECK ADD  CONSTRAINT [FK_LOPTINCHI_GIANGVIEN] FOREIGN KEY([MAGV])
REFERENCES [dbo].[GIANGVIEN] ([MAGV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LOPTINCHI] CHECK CONSTRAINT [FK_LOPTINCHI_GIANGVIEN]
GO
ALTER TABLE [dbo].[LOPTINCHI]  WITH CHECK ADD  CONSTRAINT [FK_LOPTINCHI_KHOA] FOREIGN KEY([MAKHOA])
REFERENCES [dbo].[KHOA] ([MAKHOA])
GO
ALTER TABLE [dbo].[LOPTINCHI] CHECK CONSTRAINT [FK_LOPTINCHI_KHOA]
GO
ALTER TABLE [dbo].[LOPTINCHI]  WITH CHECK ADD  CONSTRAINT [FK_LOPTINCHI_MONHOC] FOREIGN KEY([MAMH])
REFERENCES [dbo].[MONHOC] ([MAMH])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LOPTINCHI] CHECK CONSTRAINT [FK_LOPTINCHI_MONHOC]
GO
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SINHVIEN_LOP] FOREIGN KEY([MALOP])
REFERENCES [dbo].[LOP] ([MALOP])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIEN_LOP]
GO
ALTER TABLE [dbo].[LOPTINCHI]  WITH CHECK ADD  CONSTRAINT [CK_SOSVTOITHIEU] CHECK  (([SOSVTOITHIEU]>(0)))
GO
ALTER TABLE [dbo].[LOPTINCHI] CHECK CONSTRAINT [CK_SOSVTOITHIEU]
GO
/****** Object:  StoredProcedure [dbo].[GetAllHocKy]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAllHocKy] @NIENKHOA nchar(9)  as 
select HOCKY from LOPTINCHI where NIENKHOA= @NIENKHOA group by HOCKY
GO
/****** Object:  StoredProcedure [dbo].[GetAllNienKhoa]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create proc [dbo].[GetAllNienKhoa]
 as 
select NIENKHOA from LOPTINCHI group by NIENKHOA
GO
/****** Object:  StoredProcedure [dbo].[GetAllNhom]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllNhom] @NIENKHOA varchar(9), @HOCKI int
as select NHOM FROM LOPTINCHI where @NIENKHOA = NIENKHOA AND HOCKY = @HOCKI group by NHOM
GO
/****** Object:  StoredProcedure [dbo].[SP_BDMH]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_BDMH] @NienKhoa varchar(9), @HocKy int, @Nhom int,@MonHoc nvarchar(50)
as
declare @LOPTINCHI int
select @LOPTINCHI= MALTC from LOPTINCHI,MONHOC
where LOPTINCHI.NIENKHOA = @NienKhoa AND LOPTINCHI.HOCKY = @HocKy AND LOPTINCHI.NHOM = @Nhom
AND MONHOC.TENMH = @MonHoc AND LOPTINCHI.MAMH = MONHOC.MAMH
select MALC=@LOPTINCHI,SINHVIEN.MASV,HOTEN=HO+' '+TEN,DIEM_CC,DIEM_GK,DIEM_CK,DIEM_TK= DIEM_CC*0.1 + DIEM_GK*0.3 + DIEM_CK*0.6 from DANGKY,SINHVIEN
where  DANGKY.MASV = SINHVIEN.MASV AND DANGKY.MALTC = @LOPTINCHI 
order by TEN,HO

GO
/****** Object:  StoredProcedure [dbo].[SP_CHECKID]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CHECKID] @Code NVARCHAR(15),
@Type NVARCHAR(15)
AS
BEGIN
	-- LOP
	IF(@Type = 'MALOP')
	BEGIN
		
		IF EXISTS(SELECT * FROM dbo.LOP WHERE dbo.LOP.MALOP = @Code)
			RETURN 1; -- Mã tồn tại ở phân mãnh hiện tại
	
		
	END

	--MON Hoc
	IF(@Type = 'MAMONHOC')
	BEGIN
		IF EXISTS(SELECT * FROM dbo.MONHOC WHERE MAMH = @Code)
		RETURN 1;
	END
	
	


		IF(@Type = 'MASV')
	BEGIN
		
		IF EXISTS(SELECT * FROM dbo.SINHVIEN WHERE dbo.SINHVIEN.MASV = @Code)
			RETURN 1; -- Mã tồn tại ở phân mãnh hiện tại
	
		
	END

	RETURN 0	--Không bị trùng được thêm
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CHECKNAME]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CHECKNAME]
@Name NVARCHAR(50),
@Type NVARCHAR(15)
AS
BEGIN
	--Kiểm tra Table lop của server hiện tại
	IF(@Type = 'TENLOP')
	BEGIN
		IF EXISTS(SELECT * FROM dbo.LOP WHERE dbo.LOP.TENLOP = @Name)
			RETURN 1; -- @name bị trùng  ở phân mãnh hiện tại
	
	
	END

	IF(@Type = 'TENMONHOC')
	BEGIN
		IF EXISTS(SELECT * FROM dbo.MONHOC WHERE TENMH = @Name)
		RETURN 1;
	END
	
	RETURN 0	--Không bị trùng ,được thêm
END

GO
/****** Object:  StoredProcedure [dbo].[SP_DANGNHAP]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROC [dbo].[SP_DANGNHAP]
@TENLOGIN nchar(10)
AS
DECLARE @TENUSER nchar(10)
SELECT @TENUSER=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@TENLOGIN)
 
 SELECT USERNAME = @TENUSER, 
  HOTEN = (SELECT HO+ ' '+ TEN FROM SINHVIEN  WHERE MASV = @TENUSER ),
   ROLENAME=NAME
   FROM sys.sysusers 
   WHERE UID = (SELECT GROUPUID 
                 FROM SYS.SYSMEMBERS 
                   WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
                                      WHERE NAME=@TENUSER))


GO
/****** Object:  StoredProcedure [dbo].[sp_doimatkhau]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [dbo].[sp_doimatkhau] 	-- Add the parameters for the stored procedure here	
 @LGNAME VARCHAR(50),
 @NEWPASS VARCHAR (50),
 @OLDPASS VARCHAR (50)
AS
BEGIN
	DECLARE @RET INT
	EXEC @RET = sp_password @OLDPASS,@NEWPASS,@LGNAME 
	if @RET=1
	  Return 1
	if @RET =0
	return 0


    -- Insert statements for procedure here

END

GO
/****** Object:  StoredProcedure [dbo].[SP_FULLMARK]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_FULLMARK]
 @MSSV varchar(10),
 @Nienkhoa varchar(10),
 @Hocki int 
as
BEGIN
	IF EXISTS (SELECT 1 FROM SINHVIEN WHERE MASV=@MSSV)  
				BEGIN
                    with GETDIEMMON (MaLTC,MAMH,DIEM_CC,DIEM_GK ,DIEM_CK,DIEMTK) as
					(select LOPTINCHI.MALTC, LOPTINCHI.MAMH,DIEM_CC,DIEM_GK ,DIEM_CK,DIEMTK= DIEM_CC * 0.1 + DIEM_GK * 0.3 + DIEM_CK * 0.6 
					from DANGKY,LOPTINCHI 
					where DANGKY.MASV = @MSSV AND DANGKY.MALTC = LOPTINCHI.MALTC AND LOPTINCHI.NIENKHOA=@Nienkhoa AND LOPTINCHI.HOCKY=@Hocki AND HUYDANGKY=0)
					select TENMH,DIEM_CC,DIEM_GK ,DIEM_CK,DIEMTK 
					from MONHOC,GETDIEMMON
					where GETDIEMMON.MAMH = MONHOC.MAMH
					
                END
				
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Lay_Thong_Tin_GV_Tu_Login]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROC [dbo].[SP_Lay_Thong_Tin_GV_Tu_Login]
 @TENLOGIN NVARCHAR(100)
 AS
 DECLARE @UID INT
 DECLARE @MAGV NVARCHAR(100)
 SELECT @UID = uid, @MAGV = name FROM SYS.sysusers
	WHERE sid = SUSER_SID(@TENLOGIN)
 SELECT MAGV = @MAGV,
		HOTEN = (SELECT HO+ ' '+TEN FROM dbo.GIANGVIEN WHERE MAGV=@MAGV),
		TENNHOM= name
		FROM SYS.sysusers
		WHERE uid = (SELECT groupuid FROM SYS.sysmembers WHERE memberuid = @UID)



GO
/****** Object:  StoredProcedure [dbo].[SP_LayLOTCTHEOMAGV]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_LayLOTCTHEOMAGV]
@MaGV nchar(10)
AS

	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	

    -- Insert statements for procedure here
	SELECT* FROM LOPTINCHI WHERE LOPTINCHI.MAGV=@MaGV


GO
/****** Object:  StoredProcedure [dbo].[SP_LAYMALOP]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_LAYMALOP]
@MaKhoa nchar(10)
AS
SELECT LOP.MALOP FROM LOP where MAKHOA=@MaKhoa

GO
/****** Object:  StoredProcedure [dbo].[sp_LayTTDK]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_LayTTDK]
@MASV NCHAR(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SELECT * FROM DANGKY WHERE MASV=@MASV
END

GO
/****** Object:  StoredProcedure [dbo].[SP_LAYTTLOPTheoKhoa]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_LAYTTLOPTheoKhoa]
@maKhoa nchar(10)
AS
SELECT * FROM LOP Where MAKHOA=@maKhoa
GO
/****** Object:  StoredProcedure [dbo].[sp_LAYTTSVTULOGIN]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_LAYTTSVTULOGIN]
	@TenLogin nvarChar(100)
AS 
	
  DECLARE @UID INT
  DECLARE @MaSV nchar(10)
  SELECT @UID= uid, @MaSV = name
  FROM sys.sysusers
  WHERE sid=SUSER_SID(@TenLogin)

  
SELECT MaSV= @MaSV, TEN=(SELECT HO+ ' '+TEN FROM SINHVIEN WHERE MASV=@MaSV),
TENNHOM= name
FROM sys.sysusers
WHERE uid in (SELECT groupuid FROM sys.sysmembers WHERE memberuid=@UID)
GO
/****** Object:  StoredProcedure [dbo].[SP_LIST_SVHUYDANGKY]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE proc [dbo].[SP_LIST_SVHUYDANGKY] @MASSV varchar(20)
as
with GETLIST_HUYDANGKY(MALTC,NIENKHOA,HOCKY,MAMH,MAGV,NHOM)
as
(select DANGKY.MALTC,NIENKHOA,HOCKY,MAMH,MAGV,NHOM 
from DANGKY,LOPTINCHI
where DANGKY.MASV=@MASSV AND DANGKY.MALTC = LOPTINCHI.MALTC AND DANGKY.HUYDANGKY = 0 
AND DANGKY.DIEM_CC IS NULL AND DANGKY.DIEM_CK IS NULL AND DANGKY.DIEM_GK IS NULL	
)
select A.MALTC,NIENKHOA,HOCKY,TENMH,HOTENGV=HO + ' '+ TEN,NHOM
from (select MALTC,NIENKHOA,HOCKY,HO,TEN,NHOM
from GETLIST_HUYDANGKY,GIANGVIEN
where GETLIST_HUYDANGKY.MAGV = GIANGVIEN.MAGV) as A,
(select MALTC,TENMH from GETLIST_HUYDANGKY,MONHOC 
where GETLIST_HUYDANGKY.MAMH = MONHOC.MAMH) as B
where A.MALTC = B.MALTC



GO
/****** Object:  StoredProcedure [dbo].[SP_SVDangKyLTC]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_SVDangKyLTC] @NienKhoa VARCHAR(9),
@HocKy int , @Nhom int, @TenMh nvarchar(50)
as
declare @LOPTINCHI int
select @LOPTINCHI = MALTC  from LOPTINCHI,MONHOC
where LOPTINCHI.NIENKHOA=@NienKhoa AND LOPTINCHI.HOCKY = @HocKy
AND LOPTINCHI.NHOM = @Nhom AND MONHOC.TENMH = @TenMh AND LOPTINCHI.MAMH = MONHOC.MAMH
select SINHVIEN.MASV,HOTEN=HO+' '+TEN,PHAI = IIF(PHAI=1,N'Nữ',N'Nam'),MALOP from SINHVIEN,DANGKY
where DANGKY.MASV = SINHVIEN.MASV AND DANGKY.MALTC = @LOPTINCHI AND HUYDANGKY = 0
order by TEN,HO

GO
/****** Object:  StoredProcedure [dbo].[SP_TAOLOGIN]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: SQLQuery34.sql|7|0|C:\Users\tuyen\AppData\Local\Temp\~vs33C9.sql
CREATE PROC [dbo].[SP_TAOLOGIN]
  @LGNAME VARCHAR(50),
  @PASS VARCHAR(50),
  @USERNAME VARCHAR(50),
  @ROLE VARCHAR(50)
AS

	-- check login , user bị trùng 
	IF EXISTS(SELECT name FROM sys.server_principals 
				WHERE TYPE IN ('U', 'S', 'G')	--U: Windows Login Accounts
				AND name NOT LIKE '%##%'		--S: SQL Login Accounts
				AND name = @LGNAME)				--G: Windows Group Login Accounts
		RETURN 1	--Trùng Login
	ELSE IF EXISTS(SELECT name FROM sys.database_principals
					WHERE type_desc = 'SQL_USER'
					AND name = @USERNAME)
		RETURN 2	--Trùng User

	-- băt đầu tạo tài khoản
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'QLDSV_TC'
  IF (@RET =1) 
     RETURN 3 -- tạo tài khoản không thành công
 
  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1) 
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RETURN 3 -- tạo  tài khoảng không thành công
  END
  EXEC sp_addrolemember @ROLE, @USERNAME

  --THEM ROLE SECURITYADMIN DE CO QUYEN TAO TAI KHOAN
  IF @ROLE='PGV'
  BEGIN
  EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
    EXEC sp_addsrvrolemember @LGNAME, 'dbcreator'

  END
  IF @ROLE='SinhVien'
  IF @ROLE='Khoa'

  RETURN 0  -- THANH CONG


GO
/****** Object:  StoredProcedure [dbo].[SP_TTLOPTCTHEOKHOA]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_TTLOPTCTHEOKHOA]
	-- Add the parameters for the stored procedure here
@MAKHOA NVARCHAR(50)
AS
BEGIN

    -- Insert statements for procedure here
	SELECT * From LOPTINCHI WHERE MAKHOA=@MAKHOA
END

GO
/****** Object:  StoredProcedure [dbo].[SP_TTLTC]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_TTLTC] @NienKhoa varchar(9), @HocKy int
AS

 
BEGIN
SELECT MALTC,TENMH=(SELECT MONHOC.TENMH FROM MONHOC WHERE MAMH=LOPTINCHI.MAMH),NHOM,GIANGVIEN=(SELECT TENGC=HO+' '+TEN FROM GIANGVIEN WHERE MAGV=LOPTINCHI.MAGV),KHOA=(SELECT TENKHOA FROM KHOA WHERE MAKHOA=LOPTINCHI.MAKHOA) FROM LOPTINCHI  WHERE NIENKHOA=@NienKhoa AND HOCKY=@HocKy 



END
GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATESV]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =========================================IN====
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROC [dbo].[SP_UPDATESV]
@MASV NVARCHAR(10),
@HO nvarchar(50),
@TEN nvarchar(10),
@DIACHI nvarchar(100),
@PHAI bit,
@MALOP nchar(10),
@NGAYSINH date
AS
BEGIN
UPDATE SINHVIEN
SET HO=@HO,TEN=@TEN,DIACHI=@DIACHI,PHAI=@PHAI,@NGAYSINH=@NGAYSINH,MALOP=@MALOP
WHERE MASV=@MASV
END
GO
/****** Object:  StoredProcedure [dbo].[SP_XULY_DIEM]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROC [dbo].[SP_XULY_DIEM]
@MSSV varchar(20),
@MALTC int,
@DIEMCC float,
@DIEMGK float,
@DIEMCK float
as 
BEGIN
	IF EXISTS (Select 1 From DANGKY where MASV = @MSSV AND MALTC = @MALTC)
	BEGIN
		UPDATE DANGKY
		SET DIEM_CC = @DIEMCC, DIEM_GK = @DIEMGK, DIEM_CK = @DIEMCK
		WHERE MASV = @MSSV AND MALTC = @MALTC
	END
	ELSE 
	RAISERROR(N'THÔNG TIN ĐĂNG KÝ KHÔNG TỒN TẠI',16,1)
	END


GO
/****** Object:  StoredProcedure [dbo].[SP_XULY_LTC]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_XULY_LTC] @MASV NVARCHAR(10),  
@MALTC INT,  
@type smallint
--type=1 : đăng ký
--type=0 : hủy
-- SP này để vừa cho sinh viên đăng ký hoặc hủy môn đăng ký
AS  
BEGIN  
	IF (@type=1)
	BEGIN
            IF EXISTS (SELECT 1 FROM DANGKY WHERE MASV=@MASV AND MALTC=@MALTC)  
				BEGIN
			   DECLARE @TAM bit
					SELECT @TAM= HUYDANGKY FROM DANGKY WHERE MASV=@MASV AND MALTC=@MALTC
					IF @TAM=1
					BEGIN 
				   UPDATE DANGKY SET HUYDANGKY=0 WHERE MALTC = @MALTC AND MASV = @MASV
				END
					ELSE
					BEGIN 
                    raiserror(N'SINH VIÊN ĐÃ ĐĂNG KÝ LỚP',16,1)
					RETURN
					END
                END  
            ELSE  
                BEGIN  
                    INSERT INTO DBO.DANGKY(MALTC, MASV,HUYDANGKY)  
                    VALUES (@MALTC, @MASV,0)  
                END
	END
	ELSE IF(@type = 2)
	BEGIN
		IF EXISTS (SELECT 1 FROM DANGKY WHERE MASV=@MASV AND MALTC=@MALTC)  
				BEGIN
                    UPDATE DANGKY SET HUYDANGKY=1 WHERE MALTC = @MALTC AND MASV = @MASV
                END
		ELSE
			BEGIN
				raiserror(N'SINH VIÊN CHƯA ĐĂNG KÝ LỚP',16,1)
				
			END
	END
		
END



GO
/****** Object:  StoredProcedure [dbo].[UDATELOP]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UDATELOP]
	-- Add the parameters for the stored procedure here\
	@MALTC  nchar(10),
	@NIENKHOA  NVARCHAR(50),
	@HOCKY  INT,
	@MAKHOA nchar(10),
	@MAMH nchar(10),
	@MAGV nchar(10),
	@SOSVTOITHIEU INT,
	@NHOM INT


AS
BEGIN
UPDATE LOPTINCHI
SET NIENKHOA=@NIENKHOA,HOCKY=@HOCKY,MAKHOA=@MAKHOA,MAMH=@MAMH,MAGV=@MAGV,NHOM=@NHOM WHERE MALTC=@MALTC
END

GO
/****** Object:  StoredProcedure [dbo].[UPDATELOPTC]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UPDATELOPTC]
	-- Add the parameters for the stored procedure here\
	@MALTC  nchar(10),
	@NIENKHOA  NVARCHAR(50),
	@HOCKY  INT,
	@MAKHOA nchar(10),
	@MAMH nchar(10),
	@MAGV nchar(10),
	@SOSVTOITHIEU INT,
	@NHOM INT


AS
BEGIN
UPDATE LOPTINCHI
SET NIENKHOA=@NIENKHOA,HOCKY=@HOCKY,MAKHOA=@MAKHOA,MAMH=@MAMH,MAGV=@MAGV,NHOM=@NHOM,SOSVTOITHIEU=@SOSVTOITHIEU WHERE MALTC=@MALTC
END

GO
/****** Object:  StoredProcedure [dbo].[Xoa_Login]    Script Date: 6/12/2022 9:28:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Xoa_Login]
  @LGNAME VARCHAR(50)
 
  
AS
  DECLARE @UID INT
  DECLARE @MaSV nchar(10)
  SELECT @UID= uid, @MaSV = name
  FROM sys.sysusers
  WHERE sid=SUSER_SID(@LGNAME)


  EXEC SP_DROPLOGIN @LGNAME
  EXEC SP_DROPUSER @MaSV  

GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "SINHVIEN"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LOPTINCHI"
            Begin Extent = 
               Top = 7
               Left = 290
               Bottom = 170
               Right = 485
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "DANGKY"
            Begin Extent = 
               Top = 7
               Left = 533
               Bottom = 170
               Right = 727
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MONHOC"
            Begin Extent = 
               Top = 7
               Left = 775
               Bottom = 170
               Right = 969
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1'
GO
USE [master]
GO
ALTER DATABASE [QLDSV_TC] SET  READ_WRITE 
GO
