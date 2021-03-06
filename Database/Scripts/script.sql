USE [NhanSuTCD]
GO
/****** Object:  Table [dbo].[BienChe]    Script Date: 9/7/2015 10:28:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BienChe](
	[idBienChe] [int] IDENTITY(1,1) NOT NULL,
	[maBienChe] [nvarchar](50) NOT NULL,
	[bienChe] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idBienChe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CapBac]    Script Date: 9/7/2015 10:28:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CapBac](
	[idCapBac] [int] IDENTITY(1,1) NOT NULL,
	[maCapBac] [nvarchar](50) NOT NULL,
	[capBac] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCapBac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 9/7/2015 10:28:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[idChucVu] [int] IDENTITY(1,1) NOT NULL,
	[MaChucVu] [nvarchar](50) NOT NULL,
	[ChucVu] [nvarchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HopDongLaoDong]    Script Date: 9/7/2015 10:28:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HopDongLaoDong](
	[idHopDongLaoDong] [int] IDENTITY(1,1) NOT NULL,
	[idNhanVien] [int] NOT NULL,
	[soHopDong_TTHDLD] [nvarchar](20) NOT NULL,
	[nguoiBaoLanh_TTHDLD] [nvarchar](150) NOT NULL,
	[chucDanh] [nvarchar](150) NOT NULL,
	[idLoaiHopDong] [int] NOT NULL,
	[ngayBatDau] [datetime] NOT NULL,
	[ngayKetThuc] [datetime] NOT NULL,
	[ghiChu] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[idHopDongLaoDong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhenThuong]    Script Date: 9/7/2015 10:28:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhenThuong](
	[idKhenThuong] [int] IDENTITY(1,1) NOT NULL,
	[idNhanVien] [int] NOT NULL,
	[namKhenThuong] [datetime] NOT NULL,
	[loaiKhenThuong] [nvarchar](100) NOT NULL,
	[capKhenThuong] [nvarchar](100) NOT NULL,
	[soSoKhenThuong] [nvarchar](100) NOT NULL,
	[nguoiKhenThuong] [nvarchar](100) NOT NULL,
	[thanhTichKhenThuong] [nvarchar](100) NOT NULL,
	[ghiChu] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[idKhenThuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KyLuat]    Script Date: 9/7/2015 10:28:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KyLuat](
	[idKyLuat] [int] IDENTITY(1,1) NOT NULL,
	[idNhanVien] [int] NOT NULL,
	[ngayKyLuat] [datetime] NOT NULL,
	[loaiKyLuat] [nvarchar](150) NOT NULL,
	[capKyLuat] [nvarchar](100) NOT NULL,
	[soQuyetDinhKyLuat] [nvarchar](50) NOT NULL,
	[nguoiKyQuyetDinh] [nvarchar](100) NOT NULL,
	[hanhViBiKyLuat] [nvarchar](max) NOT NULL,
	[ghiChu] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[idKyLuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiHopDong]    Script Date: 9/7/2015 10:28:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiHopDong](
	[idLoaiHopDong] [int] IDENTITY(1,1) NOT NULL,
	[loaiHopDong] [nvarchar](150) NULL,
	[idCha] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idLoaiHopDong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhongDoiToLoaiTo]    Script Date: 9/7/2015 10:28:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongDoiToLoaiTo](
	[idPhongDoiToLoai] [int] IDENTITY(1,1) NOT NULL,
	[maPhongDoiToLoai] [nvarchar](50) NOT NULL,
	[tenPhongDoiToLoai] [nvarchar](100) NOT NULL,
	[idCha] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idPhongDoiToLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TD-DD-BN-TV]    Script Date: 9/7/2015 10:28:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TD-DD-BN-TV](
	[idTDDDBNTV] [int] IDENTITY(1,1) NOT NULL,
	[idNhanVien] [int] NOT NULL,
	[hoTenDD] [nvarchar](50) NOT NULL,
	[noiDung] [nvarchar](20) NOT NULL,
	[namThucHien] [datetime] NOT NULL,
	[viTriCu] [nvarchar](max) NULL,
	[viTriMoi] [nvarchar](max) NULL,
	[dienLaoDong] [nvarchar](100) NULL,
	[dienHuongLuong] [nvarchar](50) NULL,
	[soQuyetDinh] [nvarchar](50) NULL,
	[ngayKyQD] [datetime] NULL,
	[ngayHieuLuc] [datetime] NULL,
	[ghiChu] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[idTDDDBNTV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThanhPho]    Script Date: 9/7/2015 10:28:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhPho](
	[idThanhPho] [int] IDENTITY(1,1) NOT NULL,
	[maTP] [nvarchar](10) NOT NULL,
	[tenTP] [nvarchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idThanhPho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThongTinGiaDinh]    Script Date: 9/7/2015 10:28:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinGiaDinh](
	[idThongTinGiaDinh] [int] IDENTITY(1,1) NOT NULL,
	[idNhanVien] [int] NOT NULL,
	[hoTenCha] [nvarchar](100) NOT NULL,
	[namSinhCha] [datetime] NOT NULL,
	[ngheNghiepCha] [nvarchar](100) NOT NULL,
	[hoTenMe] [nvarchar](100) NOT NULL,
	[namSinhMe] [datetime] NOT NULL,
	[ngheNghiepMe] [nvarchar](100) NOT NULL,
	[hoTenVoChong] [nvarchar](100) NOT NULL,
	[ngheNghiepVoChong] [nvarchar](100) NOT NULL,
	[namSinhVoChong] [date] NOT NULL,
	[thongTinConCai] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idThongTinGiaDinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThongTinNhanVIen]    Script Date: 9/7/2015 10:28:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinNhanVIen](
	[idNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [nvarchar](20) NOT NULL,
	[idPhongDoiToLoai] [int] NOT NULL,
	[userName] [nvarchar](20) NOT NULL,
	[password] [nvarchar](150) NOT NULL,
	[permission] [int] NOT NULL,
	[idBienChe] [int] NOT NULL,
	[idCapBac] [int] NOT NULL,
	[idChucVu] [int] NOT NULL,
	[idTP] [int] NOT NULL,
	[CongViecDangLam] [nvarchar](max) NULL,
	[hoTen] [nvarchar](100) NOT NULL,
	[gioiTinh] [tinyint] NOT NULL,
	[namSinh] [datetime] NOT NULL,
	[nguyenQuan] [nvarchar](max) NULL,
	[noiOHienNay] [nvarchar](max) NULL,
	[hoKhau] [nvarchar](max) NULL,
	[CMND] [nvarchar](50) NULL,
	[ngayCapCMND] [datetime] NULL,
	[noiCapCMND] [nvarchar](50) NULL,
	[soDienThoaiNha] [nvarchar](50) NULL,
	[soDienThoaiDiDong] [nvarchar](50) NULL,
	[nguoiBaoLanh] [nvarchar](50) NULL,
	[moiQuanHeBaoLanh] [nvarchar](50) NULL,
	[noiCongTac] [nvarchar](max) NULL,
	[ngayVaoCang] [datetime] NULL,
	[namVaoSongThan] [datetime] NULL,
	[ngayNhapNgu] [datetime] NULL,
	[tinhTrangHonNhan] [nvarchar](100) NULL,
	[hinhAnhCaNhan] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThongTinTrinhDo]    Script Date: 9/7/2015 10:28:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinTrinhDo](
	[idThongTinTrinhDo] [int] IDENTITY(1,1) NOT NULL,
	[idNhanVien] [int] NOT NULL,
	[idTrinhDo] [int] NOT NULL,
	[noiDaoTao] [nvarchar](150) NOT NULL,
	[chuyenNganh] [nvarchar](150) NOT NULL,
	[loaiHinh] [nvarchar](50) NOT NULL,
	[thoiGianTotNghiep] [date] NOT NULL,
	[bangCapPhu_CC] [nvarchar](150) NULL,
 CONSTRAINT [PK_ThongTinTrinhDo] PRIMARY KEY CLUSTERED 
(
	[idThongTinTrinhDo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TrinhDo]    Script Date: 9/7/2015 10:28:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrinhDo](
	[idTrinhDo] [int] IDENTITY(1,1) NOT NULL,
	[TrinhDo] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[idTrinhDo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[BienChe] ON 

INSERT [dbo].[BienChe] ([idBienChe], [maBienChe], [bienChe]) VALUES (1, N'SQ', N'Sỹ Quan')
INSERT [dbo].[BienChe] ([idBienChe], [maBienChe], [bienChe]) VALUES (2, N'QNCN', N'Quân Nhân Chuyên Nghiệp')
INSERT [dbo].[BienChe] ([idBienChe], [maBienChe], [bienChe]) VALUES (3, N'null', N'Không')
INSERT [dbo].[BienChe] ([idBienChe], [maBienChe], [bienChe]) VALUES (4, N'CS', N'Chiến Sỹ')
INSERT [dbo].[BienChe] ([idBienChe], [maBienChe], [bienChe]) VALUES (5, N'LDQP', N'Lao Động Quốc Phòng')
SET IDENTITY_INSERT [dbo].[BienChe] OFF
SET IDENTITY_INSERT [dbo].[CapBac] ON 

INSERT [dbo].[CapBac] ([idCapBac], [maCapBac], [capBac]) VALUES (1, N'1/', N'Thiếu Uý')
INSERT [dbo].[CapBac] ([idCapBac], [maCapBac], [capBac]) VALUES (2, N'2/', N'Trung Uý')
INSERT [dbo].[CapBac] ([idCapBac], [maCapBac], [capBac]) VALUES (3, N'3/', N'Thượng Uý')
INSERT [dbo].[CapBac] ([idCapBac], [maCapBac], [capBac]) VALUES (4, N'4/', N'Đại Uý')
INSERT [dbo].[CapBac] ([idCapBac], [maCapBac], [capBac]) VALUES (5, N'1/CN', N'Thiếu Uý CN')
INSERT [dbo].[CapBac] ([idCapBac], [maCapBac], [capBac]) VALUES (6, N'2/CN', N'Trung Uý CN')
INSERT [dbo].[CapBac] ([idCapBac], [maCapBac], [capBac]) VALUES (7, N'3/CN', N'Thượng Uý CN')
INSERT [dbo].[CapBac] ([idCapBac], [maCapBac], [capBac]) VALUES (8, N'4/CN', N'Đại Uý CN')
INSERT [dbo].[CapBac] ([idCapBac], [maCapBac], [capBac]) VALUES (9, N'1//', N'Thiếu Tá')
INSERT [dbo].[CapBac] ([idCapBac], [maCapBac], [capBac]) VALUES (10, N'2//', N'Trung Tá')
INSERT [dbo].[CapBac] ([idCapBac], [maCapBac], [capBac]) VALUES (11, N'3//', N'Thượng Tá')
INSERT [dbo].[CapBac] ([idCapBac], [maCapBac], [capBac]) VALUES (12, N'4//', N'Đại Tá')
INSERT [dbo].[CapBac] ([idCapBac], [maCapBac], [capBac]) VALUES (13, N'1//CN', N'Thiếu Tá CN')
INSERT [dbo].[CapBac] ([idCapBac], [maCapBac], [capBac]) VALUES (14, N'2//CN', N'Trung Tá CN')
INSERT [dbo].[CapBac] ([idCapBac], [maCapBac], [capBac]) VALUES (15, N'3//CN', N'Thượng Tá CN')
INSERT [dbo].[CapBac] ([idCapBac], [maCapBac], [capBac]) VALUES (16, N'4//CN', N'Đại Tá CN')
INSERT [dbo].[CapBac] ([idCapBac], [maCapBac], [capBac]) VALUES (17, N'#N/A', N'#N/A')
SET IDENTITY_INSERT [dbo].[CapBac] OFF
SET IDENTITY_INSERT [dbo].[ChucVu] ON 

INSERT [dbo].[ChucVu] ([idChucVu], [MaChucVu], [ChucVu]) VALUES (1, N'GD', N'Ban Giám Đốc')
INSERT [dbo].[ChucVu] ([idChucVu], [MaChucVu], [ChucVu]) VALUES (2, N'TP', N'Trưởng Phòng ')
INSERT [dbo].[ChucVu] ([idChucVu], [MaChucVu], [ChucVu]) VALUES (3, N'PP', N'Phó Phòng')
INSERT [dbo].[ChucVu] ([idChucVu], [MaChucVu], [ChucVu]) VALUES (4, N'TT', N'Tổ Trưởng')
INSERT [dbo].[ChucVu] ([idChucVu], [MaChucVu], [ChucVu]) VALUES (5, N'NV', N'Nhân Viên')
INSERT [dbo].[ChucVu] ([idChucVu], [MaChucVu], [ChucVu]) VALUES (6, N'DP', N'Đội Phó')
INSERT [dbo].[ChucVu] ([idChucVu], [MaChucVu], [ChucVu]) VALUES (7, N'DT', N'Đội Trưởng')
INSERT [dbo].[ChucVu] ([idChucVu], [MaChucVu], [ChucVu]) VALUES (8, N'XT', N'Xe Trưởng')
SET IDENTITY_INSERT [dbo].[ChucVu] OFF
SET IDENTITY_INSERT [dbo].[HopDongLaoDong] ON 

INSERT [dbo].[HopDongLaoDong] ([idHopDongLaoDong], [idNhanVien], [soHopDong_TTHDLD], [nguoiBaoLanh_TTHDLD], [chucDanh], [idLoaiHopDong], [ngayBatDau], [ngayKetThuc], [ghiChu]) VALUES (1, 1, N'abcdas', N'Cao Tiến Thuận', N'Giám Đốc', 8, CAST(0x0000A4BF008C4240 AS DateTime), CAST(0x0000A907008C4240 AS DateTime), N'3 Năm')
SET IDENTITY_INSERT [dbo].[HopDongLaoDong] OFF
SET IDENTITY_INSERT [dbo].[LoaiHopDong] ON 

INSERT [dbo].[LoaiHopDong] ([idLoaiHopDong], [loaiHopDong], [idCha]) VALUES (2, N'Có thời hạn', 0)
INSERT [dbo].[LoaiHopDong] ([idLoaiHopDong], [loaiHopDong], [idCha]) VALUES (3, N'Không thời hạn', 0)
INSERT [dbo].[LoaiHopDong] ([idLoaiHopDong], [loaiHopDong], [idCha]) VALUES (4, N'Thử việc', 2)
INSERT [dbo].[LoaiHopDong] ([idLoaiHopDong], [loaiHopDong], [idCha]) VALUES (5, N'6 Tháng', 2)
INSERT [dbo].[LoaiHopDong] ([idLoaiHopDong], [loaiHopDong], [idCha]) VALUES (6, N'1 năm', 2)
INSERT [dbo].[LoaiHopDong] ([idLoaiHopDong], [loaiHopDong], [idCha]) VALUES (8, N'3 năm', 2)
SET IDENTITY_INSERT [dbo].[LoaiHopDong] OFF
SET IDENTITY_INSERT [dbo].[PhongDoiToLoaiTo] ON 

INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (1, N'BGD', N'Ban Giám Đốc', 0)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (2, N'TC-KT', N'Phòng Tài Chính Kế Toán', 0)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (3, N'KH-KD', N'Phòng Kế Hoạch Kinh Doanh', 0)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (4, N'CT', N'Ban Chính Trị', 0)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (5, N'TCLD-TL', N'Ban Tổ Chức Lao Động - Tiền Lương', 0)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (6, N'HC-QS', N'Phòng Hành Chính - Quân Sự', 0)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (7, N'CG-XD', N'Phòng Cơ Giới - Xếp Dỡ', 0)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (8, N'DD', N'Phòng Điều Độ', 0)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (9, N'HC-HC', N'Ban Hành Chính - Hậu Cần', 6)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (10, N'DN', N'Đội Doanh Trại Điện - Nước', 6)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (11, N'BV', N'Đội Bảo Vệ', 6)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (12, N'TBSX', N'Đội Trực Ban Điều Hành', 8)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (13, N'NQ-ND', N'Khu Kho Hàng Ngoại Quan - Nội Địa', 8)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (14, N'CFS', N'Khu Kho Hàng CFS', 8)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (15, N'TV-TN', N'Đội Thương Vụ - Thu Ngân', 8)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (16, N'KCV', N'Khu Phân Phối KC', 8)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (17, N'XN-CK', N'Tổ Xe Nâng Cẩu Khung', 7)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (18, N'XNK', N'Tổ Xe Nâng Kho', 7)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (19, N'XDK', N'Tổ Xe Đầu Kéo', 7)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (20, N'HC-PV', N'Tổ Hành Chính Phục Vụ', 9)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (21, N'XE-CQ', N'Tổ Xe Cơ Quan', 9)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (22, N'QY-VS', N'Tổ Quân Y - Vệ Sinh MT', 9)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (23, N'NA', N'Tổ Nấu Ăn', 9)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (24, N'BVE', N'Tổ Bảo Vệ', 11)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (25, N'CS', N'Chiến Sỹ', 11)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (26, N'GX', N'Tổ Giữ Xe', 11)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (27, N'GNHT', N'Tổ Giao Nhận Hiện Trường', 12)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (28, N'ICP', N'TTPP ICP', 13)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (29, N'TVTN', N'Tổ Thương Vụ Thu Ngân', 15)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (30, N'GNC', N'Tổ Giao Nhận Cổng', 15)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (31, N'VP-DVKH', N'Tổ Văn Phòng - DVKH', 16)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (32, N'HT', N'Tổ Hiện Trường', 16)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (33, N'HT-ND', N'Tổ Hiện Trường Hàng Nội Địa', 32)
INSERT [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai], [maPhongDoiToLoai], [tenPhongDoiToLoai], [idCha]) VALUES (34, N'HT-XK', N'Tổ Hiện Trường Hàng Xuất Khẩu', 32)
SET IDENTITY_INSERT [dbo].[PhongDoiToLoaiTo] OFF
SET IDENTITY_INSERT [dbo].[TD-DD-BN-TV] ON 

INSERT [dbo].[TD-DD-BN-TV] ([idTDDDBNTV], [idNhanVien], [hoTenDD], [noiDung], [namThucHien], [viTriCu], [viTriMoi], [dienLaoDong], [dienHuongLuong], [soQuyetDinh], [ngayKyQD], [ngayHieuLuc], [ghiChu]) VALUES (1, 1, N'Test', N'Tuyển Dụng', CAST(0x0000A4A5010E90D8 AS DateTime), N'test cũ', N'test mới', N'culi', N'thời vụ', N'12345', CAST(0x0000A494010E90D8 AS DateTime), CAST(0x0000A495010E90D8 AS DateTime), N'test')
INSERT [dbo].[TD-DD-BN-TV] ([idTDDDBNTV], [idNhanVien], [hoTenDD], [noiDung], [namThucHien], [viTriCu], [viTriMoi], [dienLaoDong], [dienHuongLuong], [soQuyetDinh], [ngayKyQD], [ngayHieuLuc], [ghiChu]) VALUES (2, 2, N'Test lần 2', N'Tuyển Dụng', CAST(0x0000A4A4011139B4 AS DateTime), N'cũ lần 2', N'mới lần 2', N'nghèo', N'nghèo lương', N'121212', CAST(0x0000A4A3011139B4 AS DateTime), CAST(0x0000A4A7011139B4 AS DateTime), N'TEst')
INSERT [dbo].[TD-DD-BN-TV] ([idTDDDBNTV], [idNhanVien], [hoTenDD], [noiDung], [namThucHien], [viTriCu], [viTriMoi], [dienLaoDong], [dienHuongLuong], [soQuyetDinh], [ngayKyQD], [ngayHieuLuc], [ghiChu]) VALUES (3, 1, N'dá', N'Tuyển Dụng', CAST(0x0000A3460110C808 AS DateTime), N'sadsadsadasd', N'dsasasad', N'sadasdsadsad', N'sadasdsad', N'ấdsadsadas', CAST(0x0000A4AB0110C808 AS DateTime), CAST(0x0000A4A50110C808 AS DateTime), N'ádsdasd')
SET IDENTITY_INSERT [dbo].[TD-DD-BN-TV] OFF
SET IDENTITY_INSERT [dbo].[ThanhPho] ON 

INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (1, N'AG', N'An Giang')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (2, N'BD', N'Bình Dương')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (3, N'BDinh', N'Bình Định')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (4, N'BG', N'Bắc Giang')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (5, N'BK', N'Bắc Kạn')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (6, N'BL', N'Bạc Liêu')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (7, N'BN', N'Bắc Ninh')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (8, N'BP', N'Bình Phước')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (9, N'BRVT', N'Bà Rịa-Vũng Tàu')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (10, N'BT', N'Bình Thuận')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (11, N'BTre', N'Bến Tre')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (12, N'CB', N'Cao Bằng')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (13, N'CM', N'Cà Mau')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (14, N'CT', N'Cần Thơ (TP)')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (15, N'DB', N'Điện Biên')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (16, N'DL', N'Đắk Lắk')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (17, N'DN', N'Đà Nẵng (TP)')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (18, N'DNai', N'Đồng Nai')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (19, N'DNong', N'Đắk Nông')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (20, N'DThap', N'Đồng Tháp')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (21, N'GL', N'Gia Lai')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (22, N'HB', N'Hòa Bình')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (23, N'HCM', N'Hồ Chí Minh (TP)')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (24, N'HDuong', N'Hải Dương')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (25, N'HG', N'Hà Giang')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (26, N'HGiang', N'Hậu Giang')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (27, N'HN', N'Hà Nội (TP)')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (28, N'HNam', N'Hà Nam')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (29, N'HP', N'Hải Phòng (TP)')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (30, N'HTay', N'Hà Tây')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (31, N'HTinh', N'Hà Tĩnh')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (32, N'HY', N'Hưng Yên')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (33, N'KG', N'Kiên Giang')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (34, N'KH', N'Khánh Hòa')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (35, N'KT', N'Kon Tum')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (36, N'LA', N'Long An')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (37, N'LaoCai', N'Lào Cai')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (38, N'LC', N'Lai Châu')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (39, N'LD', N'Lâm Đồng')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (40, N'LSon', N'Lạng Sơn')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (41, N'NA', N'Nghệ An')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (42, N'NB', N'Ninh Bình')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (43, N'ND', N'Nam Định')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (44, N'NT', N'Ninh Thuận')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (45, N'PT', N'Phú Thọ')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (46, N'PY', N'Phú Yên')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (47, N'QB', N'Quảng Bình')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (48, N'QN', N'Quảng Nam')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (49, N'QNgai', N'Quảng Ngãi')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (50, N'QNinh', N'Quảng Ninh')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (51, N'QT', N'Quảng Trị')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (52, N'SL', N'Sơn La')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (53, N'ST', N'Sóc Trăng')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (54, N'TB', N'Thái Bình')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (55, N'TG', N'Tiền Giang')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (56, N'TH', N'Thanh Hóa')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (57, N'TN', N'Tây Ninh')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (58, N'TNguyen', N'Thái Nguyên')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (59, N'TQ', N'Tuyên Quang')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (60, N'TTH', N'Thừa Thiên - Huế')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (61, N'TV', N'Trà Vinh')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (62, N'VL', N'Vĩnh Long')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (63, N'VP', N'Vĩnh Phúc')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (64, N'YB', N'Yên Bái')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (65, N'BQP', N'Bộ Quốc Phòng')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (66, N'#N/A', N'#N/A')
INSERT [dbo].[ThanhPho] ([idThanhPho], [maTP], [tenTP]) VALUES (67, N'QCHQ', N'QC Hải Quân')
SET IDENTITY_INSERT [dbo].[ThanhPho] OFF
SET IDENTITY_INSERT [dbo].[ThongTinGiaDinh] ON 

INSERT [dbo].[ThongTinGiaDinh] ([idThongTinGiaDinh], [idNhanVien], [hoTenCha], [namSinhCha], [ngheNghiepCha], [hoTenMe], [namSinhMe], [ngheNghiepMe], [hoTenVoChong], [ngheNghiepVoChong], [namSinhVoChong], [thongTinConCai]) VALUES (2, 1, N'test cha', CAST(0x0000A4C0001C3E78 AS DateTime), N'test cha', N'test me', CAST(0x0000A4C6001C3E78 AS DateTime), N'test me', N'test vk', N'test vk', CAST(0x153A0B00 AS Date), N'test con')
SET IDENTITY_INSERT [dbo].[ThongTinGiaDinh] OFF
SET IDENTITY_INSERT [dbo].[ThongTinNhanVIen] ON 

INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (1, N'ICD000', 5, N'ICD000', N'5c6ec9f886bf0a02695ba293780c67f0', 1, 5, 17, 5, 23, N'Nhân Viên Tin Học', N'Nguyễn Xuân Tân', 0, CAST(0x0000827D015036B4 AS DateTime), N'Hải Dương', N'621 QL13, P Hiệp BÌnh Phước, Thủ Đức', N'549/14/14a Xô Viết Nghệ Tĩnh, P26, Q Bình Thạnh', N'02612228', CAST(0x0000A469015036B4 AS DateTime), N'Hồ Chí Minh (TP)', N'', N'0986.066.174', N'Cao Tiến Thuận', N'Chú', N'ICDST', CAST(0x0000A49D015036F7 AS DateTime), CAST(0x0000A49D015036F9 AS DateTime), CAST(0x0000A49D015036F5 AS DateTime), N'Độc Thân', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (2, N'ICD001', 1, N'ICD001', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 1, 12, 1, 23, N'Giám Đốc', N'Cao Tiến Thuận', 0, CAST(0x000050760150F48C AS DateTime), N'Hải Dương', N'292 Chu Văn An-P26-BThạnh Tp.HCM
', N'292 Chu Văn An-P26-BThạnh Tp.HCM
', N'5A0E440291', CAST(0x0000981E0150F48C AS DateTime), N'Bộ Quốc Phòng', N'', N'0913.803.134', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x0000A4960150F48C AS DateTime), CAST(0x0000A48E0150F48C AS DateTime), CAST(0x0000A4A80150F48C AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (3, N'ICD278', 1, N'ICD278', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 1, 10, 1, 23, N'Phó Giám Đốc Kinh Doanh', N'Nguyễn Thành Sơn', 0, CAST(0x0000638A009D6110 AS DateTime), N'#N/A', N'3A Điện Biên Phủ, Phường 25, Quận BT-TPHCM
', N'3A Điện Biên Phủ, Phường 25, Quận BT-TPHCM
', N'022427138', CAST(0x0000A02E009D6110 AS DateTime), N'Hồ Chí Minh (TP)', N'', N'0903.706.125', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x00008565009D6110 AS DateTime), CAST(0x0000A4B4009D61F7 AS DateTime), CAST(0x0000A4B4009D61F0 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (4, N'ICD194', 1, N'ICD194', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 1, 11, 1, 66, N'Phó Giám Đốc Nội Chính', N'Nguyễn Văn Sỹ', 0, CAST(0x0000647F00A02BE8 AS DateTime), N'#N/A', N'108, Đường 147, P. Phước Long B, Quận 9, Tp. HCM
', N'108, Đường 147, P. Phước Long B, Quận 9, Tp. HCM
', N'94024670', CAST(0x0000A4B400A02CAB AS DateTime), N'Bộ Quốc Phòng', N'', N'0982.002.731', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x0000995E00A02BE8 AS DateTime), CAST(0x00009D6900A02BE8 AS DateTime), CAST(0x0000A4B400A02CA9 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (5, N'ICD014', 1, N'ICD014', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 1, 11, 1, 23, N'Phó Giám Đốc Kỹ Thuật', N'Vũ Khánh Đông', 0, CAST(0x00005AE300A02BE8 AS DateTime), N'Hà Tây', N'17-10 Block B-CC An Khang- P. An Phú- Q.2- TP. HCM
', N'17-10 Block B-CC An Khang- P. An Phú- Q.2- TP. HCM
', N'022765748', CAST(0x000099E000A02BE8 AS DateTime), N'Hồ Chí Minh (TP)', N'', N'0903.952.652', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x000083DA00A02BE8 AS DateTime), CAST(0x00009D6900A02BE8 AS DateTime), CAST(0x000083DA00A02BE8 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (6, N'ICD246', 4, N'ICD246', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên Thống kê CTĐ-CTCT', N'Đỗ Thị Nguyên Ngọc', 1, CAST(0x00007F6200A45D58 AS DateTime), N'Lâm Đồng', N'84/24 A3 Lê Thị Hoa, P. Bình Chiểu, Q. Thủ Đức, TP. HCM
', N'84/24 A3 Lê Thị Hoa, P. Bình Chiểu, Q. Thủ Đức, TP. HCM
', N'250797241', CAST(0x00009DC000A45D58 AS DateTime), N'Lâm Đồng', N'', N'0908.362.970', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x00009F6F00A45D58 AS DateTime), CAST(0x00009F6F00A45D58 AS DateTime), CAST(0x0000A4B400A45D8A AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (7, N'ICD009', 4, N'ICD009', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên CT', N'Vũ Thị Lụa', 1, CAST(0x0000741300A5BE14 AS DateTime), N'Nam Định', N'A1103 Chung cư An Bình, P. An Bình, TX. Dĩ An, T. Bình Dương
', N'A1103 Chung cư An Bình, P. An Bình, TX. Dĩ An, T. Bình Dương
', N'025223409', CAST(0x00009CDD00A5BE14 AS DateTime), N'Hồ Chí Minh (TP)', N'', N'0986.991.600', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x0000979600A5BE14 AS DateTime), CAST(0x0000979600A5BE14 AS DateTime), CAST(0x0000A4B400A5BEC1 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (8, N'ICD006', 3, N'ICD006', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 2, 8, 2, 23, N'Trưởng Phòng KH-KD', N'Trần Trí Dũng', 0, CAST(0x0000741300A5BE14 AS DateTime), N'Thanh Hóa', N'7b/6, KP. Đông Nhì, P. Lái Thiêu, TX. Thuận An, T. Bình Dương
', N'7b/6, KP. Đông Nhì, P. Lái Thiêu, TX. Thuận An, T. Bình Dương
', N'171873904', CAST(0x00008D2000A5BE14 AS DateTime), N'Thanh Hóa', N'', N'0914.285.758', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x0000999C00A5BE14 AS DateTime), CAST(0x0000999C00A5BE14 AS DateTime), CAST(0x0000A4B400A5BEC1 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (9, N'ICD263', 3, N'ICD263', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 1, 4, 3, 23, N'Phó Phòng KH-KD', N'Đỗ Chiến Công', 0, CAST(0x0000721A00A5BE14 AS DateTime), N'Quảng Ninh', N'292 Chu Văn An-P26-BThạnh Tp.HCM
', N'292 Chu Văn An-P26-BThạnh Tp.HCM
', N'100729215', CAST(0x00008B1A00A5BE14 AS DateTime), N'Thanh Hóa', N'', N'0903.352.886', N'Cao Tiến Thuận', N'Bố', N'ICDST', CAST(0x000094BE00A5BE14 AS DateTime), CAST(0x0000A28100A5BE14 AS DateTime), CAST(0x0000A4B400A5BEC1 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (10, N'ICD247', 3, N'ICD247', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 2, 8, 5, 23, N'Nhân viên tổng hợp - thống kê', N'Nguyễn Thị Hoà', 1, CAST(0x00006A7B00A5BE14 AS DateTime), N'Hải Dương', N'788/25D Nguyễn Kiệm - Phường 3 - Quận Gò Vấp - Tp HCM
', N'788/25D Nguyễn Kiệm - Phường 3 - Quận Gò Vấp - Tp HCM
', N'023080846', CAST(0x0000939600A5BE14 AS DateTime), N'Hồ Chí Minh (TP)', N'', N'0989.064.873', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x00009F8E00A5BE14 AS DateTime), CAST(0x00009F8E00A5BE14 AS DateTime), CAST(0x0000A4B400A5BEC1 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (11, N'ICD223', 3, N'ICD223', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên Kế hoạch-tổng hợp', N'Hồ Hải Đăng', 0, CAST(0x00007B9600A5BE14 AS DateTime), N'Quảng Bình', N'49/1D Nguyễn Hữu Cảnh, P.22, Q. Bình Thạnh, Tp. HCM
', N'49/1D Nguyễn Hữu Cảnh, P.22, Q. Bình Thạnh, Tp. HCM
', N'191582545', CAST(0x00009D2800A5BE14 AS DateTime), N'Thừa Thiên - Huế', N'', N'0905.371.766', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x00009EA000A5BE14 AS DateTime), CAST(0x00009EA000A5BE14 AS DateTime), CAST(0x0000A4B400A5BEC1 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (12, N'ICD224', 3, N'ICD224', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên Đại lý khai thuê hải quan', N'Trịnh Quang Hiệu', 0, CAST(0x00007D0D00A5BE14 AS DateTime), N'Nam Định', N'66-D39, Tổ 4, KP7, TT Củ Chi, H. Củ Chi, TP. HCM
', N'66-D39, Tổ 4, KP7, TT Củ Chi, H. Củ Chi, TP. HCM
', N'024267531', CAST(0x0000997400A5BE14 AS DateTime), N'Hồ Chí Minh (TP)', N'', N'0937.452.276', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x00009EA000A5BE14 AS DateTime), CAST(0x00009EA000A5BE14 AS DateTime), CAST(0x0000A4B400A5BEC1 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (13, N'ICD272', 3, N'ICD272', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên Marketting-CS khách hàng', N'Trần Lê Minh Phúc', 0, CAST(0x00007D0D00A5BE14 AS DateTime), N'Nam Định', N'113/G/14 Lạc Long Quân, P3, Q11, Tp HCM
', N'113/G/14 Lạc Long Quân, P3, Q11, Tp HCM
', N'024989336', CAST(0x00009EFC00A5BE14 AS DateTime), N'Hồ Chí Minh (TP)', N'', N'01656.153.796', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x0000A30000A5BE14 AS DateTime), CAST(0x0000A30000A5BE14 AS DateTime), CAST(0x0000A4B400A5BEC1 AS DateTime), N'Độc Thân', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (14, N'ICD035', 3, N'ICD035', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên Thương vụ - pháp chế', N'Nguyễn Thị Thanh Thuỷ', 1, CAST(0x0000729C00A5BE14 AS DateTime), N'Vĩnh Phúc', N'3.2 Chung cư 24/16 Đường D3, P.25, Q. Bình Thạnh, TP. HCM
', N'3.2 Chung cư 24/16 Đường D3, P.25, Q. Bình Thạnh, TP. HCM
', N'023619479', CAST(0x00009EFC00A5BE14 AS DateTime), N'Hồ Chí Minh (TP)', N'', N'0907.806.035', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x0000A30000A5BE14 AS DateTime), CAST(0x0000A30000A5BE14 AS DateTime), CAST(0x0000A4B400A5BEC1 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (15, N'ICD010', 2, N'ICD010', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 1, 9, 2, 23, N'Trưởng phòng TC-KT', N'Phạm Văn Vượng', 0, CAST(0x0000681C00A5BE14 AS DateTime), N'Hà Nam', N'136 Tầng 2, P. Đakao, Quận 1, Tp. HCM
', N'136 Tầng 2, P. Đakao, Quận 1, Tp. HCM
', N'32A921113436', CAST(0x0000923C00A5BE14 AS DateTime), N'QC Hải Quân', N'', N'0982.224.672', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x00008FBD00A5BE14 AS DateTime), CAST(0x00008FBD00A5BE14 AS DateTime), CAST(0x0000A4B400A5BEC1 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (16, N'ICD011', 2, N'ICD011', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 2, 13, 3, 23, N'Phó phòng TC-KT', N'Nguyễn Thị Minh Hương', 1, CAST(0x0000719200DEE9A0 AS DateTime), N'Hải Phòng (TP)', N'P.17-02 Lô N, Nhà F, Chung cư Bình Khánh, P. AN Phú, Q2, TP. HCM
', N'P.17-02 Lô N, Nhà F, Chung cư Bình Khánh, P. AN Phú, Q2, TP. HCM
', N'32A021113616', CAST(0x000096C200DEE9A0 AS DateTime), N'QC Hải Quân', N'', N'01689.079.879', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x0000922C00DEE9A0 AS DateTime), CAST(0x0000922C00DEE9A0 AS DateTime), CAST(0x0000A4B400DEEA41 AS DateTime), N'Ly Dị', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (17, N'ICD033', 2, N'ICD033', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên Kế toán', N'Phạm Mạnh Nhân', 0, CAST(0x000075CD00DEE9A0 AS DateTime), N'Bình Dương', N'36F-KDC K8- P.Hiệp thành- Thủ dầu 1-Bình Dương
', N'36F-KDC K8- P.Hiệp thành- Thủ dầu 1-Bình Dương
', N'280798565', CAST(0x0000954600DEE9A0 AS DateTime), N'Bình Dương', N'', N'0983.336.354', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x0000971400DEE9A0 AS DateTime), CAST(0x0000971400DEE9A0 AS DateTime), CAST(0x0000A4B400DEEA41 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (18, N'ICD012', 2, N'ICD012', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên Kế toán', N'Mai Thị Ngọc Quý', 1, CAST(0x0000736100DEE9A0 AS DateTime), N'Quảng Bình', N'P.16-03 Lô J, Nhà E, Chung cư Bình Khánh, P. AN Phú, Q2, TP. HCM
', N'P.16-03 Lô J, Nhà E, Chung cư Bình Khánh, P. AN Phú, Q2, TP. HCM
', N'194096179', CAST(0x00008A2D00DEE9A0 AS DateTime), N'Quảng Bình', N'', N'01689.079.679', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x0000922C00DEE9A0 AS DateTime), CAST(0x0000922C00DEE9A0 AS DateTime), CAST(0x0000A4B400DEEA41 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (19, N'ICD273', 2, N'ICD273', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên Kế toán', N'Lê Quốc Trung', 0, CAST(0x00007F5D00DEE9A0 AS DateTime), N'Đồng Tháp', N'NULL', N'NULL', N'', CAST(0x00008A2D00DEE9A0 AS DateTime), N'Quảng Bình', N'', N'0984.329.047', N'Phạm Văn Vượng', N'....', N'ICDST', CAST(0x0000A33D00DEE9A0 AS DateTime), CAST(0x0000A33D00DEE9A0 AS DateTime), CAST(0x0000A4B400DEEA41 AS DateTime), N'Độc Thân', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (20, N'ICD034', 2, N'ICD034', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên Thủ quỹ', N'Đồng Thị Thương', 1, CAST(0x00006A4B00EF2E78 AS DateTime), N'Hải Phòng (TP)', N'466- Khu phô 6, Quốc lộ 13, P. Hiệp Bình Phước- Q. Thủ Đức, TP. HCM
', N'466- Khu phô 6, Quốc lộ 13, P. Hiệp Bình Phước- Q. Thủ Đức, TP. HCM
', N'024624623', CAST(0x0000983C00EF2E78 AS DateTime), N'Hồ Chí Minh (TP)', N'', N'0973.331.739', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x000099BA00EF2E78 AS DateTime), CAST(0x000099BA00EF2E78 AS DateTime), CAST(0x0000A4B400EF2F9A AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (21, N'ICD073', 5, N'ICD073', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 2, 23, N'Trưởng ban TCLĐ-TL', N'Cao Thị Hoà', 1, CAST(0x00007A1D00F011D0 AS DateTime), N'Hải Dương', N'47/94 Bùi Đình Tuý P.24 Q.BT TP.HCM
', N'47/94 Bùi Đình Tuý P.24 Q.BT TP.HCM
', N'025269557', CAST(0x00009D8500F011D0 AS DateTime), N'Hồ Chí Minh (TP)', N'', N'0979.764.885', N'Cao Tiến Thuận', N'Chú', N'ICDST', CAST(0x0000990300F011D0 AS DateTime), CAST(0x0000990300F011D0 AS DateTime), CAST(0x0000A4B400F012A7 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (22, N'ICD176', 5, N'ICD176', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên Chính sách - Định mức', N'Trịnh Thị Thu Hà', 1, CAST(0x00007ACA00F17160 AS DateTime), N'Thanh Hóa', N'Số 1, Đường 24A, P. An Phú, Quận 2, TP. HCM
', N'Số 1, Đường 24A, P. An Phú, Quận 2, TP. HCM
', N'024161080', CAST(0x000094A700F17160 AS DateTime), N'Hồ Chí Minh (TP)', N'', N'0989.117.345', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x00009C0E00F17160 AS DateTime), CAST(0x00009C0E00F17160 AS DateTime), CAST(0x0000A4B400F17278 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (23, N'ICD257', 5, N'ICD257', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên Tiền lương', N'Lê Công Bộ', 0, CAST(0x00007D8800F33DEC AS DateTime), N'Hưng Yên', N'Số 41C, Nguyễn Ái Quốc, P.Tân Hiệp,
 TP. Biên Hòa
', N'Số 41C, Nguyễn Ái Quốc, P.Tân Hiệp,
 TP. Biên Hòa
', N'145245034', CAST(0x0000935600F33DEC AS DateTime), N'Hưng Yên', N'', N'0915.79.89.29', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x0000A10300F33DEC AS DateTime), CAST(0x0000A10300F33DEC AS DateTime), CAST(0x0000A4B400F33DF4 AS DateTime), N'Độc Thân', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (24, N'ICD026', 5, N'ICD026', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân Viên Chính Sách', N'Hồ Ngọc Anh', 0, CAST(0x00006FD300F33DEC AS DateTime), N'Hà Tĩnh', N'11 Đường 14 - Phường An Phú - Q2 - TP. HCM
', N'11 Đường 14 - Phường An Phú - Q2 - TP. HCM
', N'023035415', CAST(0x00009B7500F33DEC AS DateTime), N'Hồ Chí Minh (TP)', N'', N'0918.683.239', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x0000932100F33DEC AS DateTime), CAST(0x0000932100F33DEC AS DateTime), CAST(0x0000A4B400F33DF4 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (25, N'ICD068', 6, N'ICD068', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 1, 11, 2, 23, N'Trưởng phòng HC-QS', N'Nguyễn Hữu Vĩnh', 0, CAST(0x00005C0500F5C97C AS DateTime), N'Quảng Ninh', N'11/10 tổ 11-KP5-Plong B-Q9-TPHCM
', N'11/10 tổ 11-KP5-Plong B-Q9-TPHCM
', N'8Q8B400302', CAST(0x00009B3F00F5C97C AS DateTime), N'QC Hải Quân', N'', N'0918.263.906', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x0000929C00F5C97C AS DateTime), CAST(0x000098F900F5C97C AS DateTime), CAST(0x0000A4B400F5C9CB AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (26, N'ICD071', 6, N'ICD071', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 2, 8, 3, 23, N'Phó phòng HC-QS', N'Nguyễn Khắc Thiếp', 0, CAST(0x0000686400F5C97C AS DateTime), N'Hà Nam', N'Lô số 3 Ô số 8 Khu C Đường Quang Trung-P.12-Quận GV-TPHCM
', N'Lô số 3 Ô số 8 Khu C Đường Quang Trung-P.12-Quận GV-TPHCM
', N'82A921182898', CAST(0x000091FF00F5C97C AS DateTime), N'QC Hải Quân', N'', N'0979.366.633', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x000098CE00F5C97C AS DateTime), CAST(0x000098CE00F5C97C AS DateTime), CAST(0x0000A4B400F5C9CB AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (27, N'ICD207', 20, N'ICD207', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên Hành chính', N'Trần Thị Nga', 1, CAST(0x00006BC800F5C97C AS DateTime), N'Hà Nam', N'34/5c2- n6 Bình Đáng-Bình Hoà-Thuận An - Bình Dương
', N'34/5c2- n6 Bình Đáng-Bình Hoà-Thuận An - Bình Dương
', N'012939604', CAST(0x000098F200F5C97C AS DateTime), N'Hà Nội (TP)', N'', N'01687.620.975', N'Phạm Văn Vượng', N'Em', N'ICDST', CAST(0x00009E4400F5C97C AS DateTime), CAST(0x00009E4400F5C97C AS DateTime), CAST(0x0000A4B400F5C9CB AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (28, N'ICD074', 20, N'ICD074', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên Văn thư', N'Nguyễn Thị Giang', 1, CAST(0x0000736C00F99F84 AS DateTime), N'Nghệ An', N'3A/35 KP. Bình Đức 1, P. Bình Hòa, TX. Thuận An, Tỉnh Bình Dương
', N'3A/35 KP. Bình Đức 1, P. Bình Hòa, TX. Thuận An, Tỉnh Bình Dương', N'182435281', CAST(0x00008D8400F99F84 AS DateTime), N'Nghệ An', N'', N'0973.813.916', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x00009A9000F99F84 AS DateTime), CAST(0x00009A9000F99F84 AS DateTime), CAST(0x0000A4B400F9A090 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (29, N'ICD185', 21, N'ICD185', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 2, 14, 4, 23, N'Tổ trưởng tổ xe CQ kiêm NV Lái xe 16 chỗ', N'Nguyễn Minh Đức', 0, CAST(0x00005CD000FBD7E0 AS DateTime), N'Quảng Bình', N'38/12 A Tổ 7 - KP3 - Phước Long B - Quận 9 - HCM
', N'38/12 A Tổ 7 - KP3 - Phước Long B - Quận 9 - HCM
', N'024391229', CAST(0x000096D800FBD7E0 AS DateTime), N'Hồ Chí Minh (TP)', N'', N'0907.276.631', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x0000882100FBD7E0 AS DateTime), CAST(0x00009CB400FBD7E0 AS DateTime), CAST(0x0000A4B400FBD8F0 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (30, N'ICD145', 21, N'ICD145', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 2, 6, 5, 23, N'Nhân viên lái xe Giám đốc', N'Lại Hữu Hiếu', 0, CAST(0x00007A5F00FBD7E0 AS DateTime), N'Hà Nam', N'9E/8 KP. Đồng An 3, P. Bình Hòa, TX. Thuận An, T. Bình Dương
', N'9E/8 KP. Đồng An 3, P. Bình Hòa, TX. Thuận An, T. Bình Dương
', N'168147188', CAST(0x000091BD00FBD7E0 AS DateTime), N'Hà Nam', N'', N'0984.525.242', N'Cao Tiến Thuận', N'Chưa Cập Nhật', N'ICDST', CAST(0x000098C200FBD7E0 AS DateTime), CAST(0x000098C200FBD7E0 AS DateTime), CAST(0x0000A4B400FBD8F0 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (31, N'ICD120', 21, N'ICD120', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên lái xe buýt nội bộ', N'Nguyễn Văn Oánh', 0, CAST(0x00005C2400FBD7E0 AS DateTime), N'Hưng Yên', N'595C Lê Văn Việt-KP5-P.Tăng Nhơn Phú A- Q9 Tp HCM
', N'595C Lê Văn Việt-KP5-P.Tăng Nhơn Phú A- Q9 Tp HCM
', N'025320029', CAST(0x00009DA300FBD7E0 AS DateTime), N'Hồ Chí Minh (TP)', N'', N'01666.618.224', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x0000914F00FBD7E0 AS DateTime), CAST(0x0000914F00FBD7E0 AS DateTime), CAST(0x0000A4B400FBD8F0 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (32, N'ICD106', 21, N'ICD106', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên lái xe buýt nội bộ', N'Cao Mạnh Cường', 0, CAST(0x0000566200FBD7E0 AS DateTime), N'Hà Tây', N'267/4D, tổ 6, kp 3, Tăng Nhơn Phú - Q9-HCM
', N'267/4D, tổ 6, kp 3, Tăng Nhơn Phú - Q9-HCM
', N'025064876', CAST(0x00009B9100FBD7E0 AS DateTime), N'Hồ Chí Minh (TP)', N'', N'0984.047.069', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x0000922C00FBD7E0 AS DateTime), CAST(0x000099A700FBD7E0 AS DateTime), CAST(0x0000A4B400FBD8F0 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (33, N'ICD167', 21, N'ICD167', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên lái xe buýt nội bộ', N'Hà Văn Cường', 0, CAST(0x0000595C00FBD7E0 AS DateTime), N'Bắc Giang', N'328/18 Tổ 18 Chiêu Liêu Tân Đông Hiệp Dĩ An Bình Dương
', N'328/18 Tổ 18 Chiêu Liêu Tân Đông Hiệp Dĩ An Bình Dương
', N'281062039', CAST(0x00009CBA00FBD7E0 AS DateTime), N'Bình Dương', N'', N'0973.908.938', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x00009B0300FBD7E0 AS DateTime), CAST(0x00009B0300FBD7E0 AS DateTime), CAST(0x0000A4B400FBD8F0 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (34, N'ICD075', 22, N'ICD075', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên Quân y', N'Lê Thị Thu Hiền', 1, CAST(0x00006CD700FBD7E0 AS DateTime), N'Hà Tĩnh', N'180/28/5 Nguyễn Hữu Cảnh - F22- Bình Thạnh-HCM
', N'180/28/5 Nguyễn Hữu Cảnh - F22- Bình Thạnh-HCM
', N'183056897', CAST(0x000087AE00FBD7E0 AS DateTime), N'Hà Tĩnh', N'', N'0989.021.595', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x0000912B00FBD7E0 AS DateTime), CAST(0x0000912B00FBD7E0 AS DateTime), CAST(0x0000A4B400FBD8F0 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (35, N'ICD131', 22, N'ICD131', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên Vệ sinh', N'Khúc Thị Châm', 1, CAST(0x0000670800FBD7E0 AS DateTime), N'Thái Bình', N'58/2 Bình Đáng, Bình Hòa, Thuận An, Bình Dương
', N'58/2 Bình Đáng, Bình Hòa, Thuận An, Bình Dương
', N'150965820', CAST(0x00009C5000FBD7E0 AS DateTime), N'Thái Bình', N'', N'0985.708.360', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x000094B200FBD7E0 AS DateTime), CAST(0x000094B200FBD7E0 AS DateTime), CAST(0x0000A4B400FBD8F0 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (36, N'ICD132', 22, N'ICD132', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên Vệ sinh', N'Phạm Thị Liên', 1, CAST(0x00005ECC00FBD7E0 AS DateTime), N'Nghệ An', N'45/6A, KP. THống NHất, P. Dĩ an, TX Dĩ An, T. Bình Dương
', N'45/6A, KP. THống NHất, P. Dĩ an, TX Dĩ An, T. Bình Dương
', N'182278785', CAST(0x00008AF800FBD7E0 AS DateTime), N'Nghệ An', N'', N'01265.267.882', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x000094B200FBD7E0 AS DateTime), CAST(0x000094B200FBD7E0 AS DateTime), CAST(0x0000A4B400FBD8F0 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (37, N'ICD133', 22, N'ICD133', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên Vệ sinh', N'Vũ Thị Dung', 1, CAST(0x000072FD00FBD7E0 AS DateTime), N'Hải Phòng (TP)', N'Nhị Đồng II, P. Dĩ An, TX. Dĩ an. T. Bình Dương
', N'Nhị Đồng II, P. Dĩ An, TX. Dĩ an. T. Bình Dương
', N'31172572', CAST(0x00008CA300FBD7E0 AS DateTime), N'Hải Phòng (TP)', N'', N'01695.871.019', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x000099F700FBD7E0 AS DateTime), CAST(0x000099F700FBD7E0 AS DateTime), CAST(0x0000A4B400FBD8F0 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (38, N'ICD138', 22, N'ICD138', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên Vệ sinh', N'Đinh Thị Oanh', 1, CAST(0x0000731A00FBD7E0 AS DateTime), N'Nghệ An', N'20/5 C4 KDC Minh Tuấn, Bình Đáng, Bình Hòa, Thuận An, Bình Dương
', N'20/5 C4 KDC Minh Tuấn, Bình Đáng, Bình Hòa, Thuận An, Bình Dương
', N'182424642', CAST(0x00008D3700FBD7E0 AS DateTime), N'Nghệ An', N'', N'0974.161.938', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x0000990300FBD7E0 AS DateTime), CAST(0x0000990300FBD7E0 AS DateTime), CAST(0x0000A4B400FBD8F0 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (39, N'ICD150', 22, N'ICD150', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên Vệ sinh', N'Vũ Thị Hoa', 1, CAST(0x0000653A00FBD7E0 AS DateTime), N'Thái Bình', N'9/93- KP. Bình Đức- Bình Hòa- Thuận An- Bình Dương
', N'9/93- KP. Bình Đức- Bình Hòa- Thuận An- Bình Dương
', N'151630882', CAST(0x0000933900FBD7E0 AS DateTime), N'Nghệ An', N'', N'0976.540.589', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x0000990300FBD7E0 AS DateTime), CAST(0x0000990300FBD7E0 AS DateTime), CAST(0x0000A4B400FBD8F0 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (40, N'ICD162', 22, N'ICD162', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên Vệ sinh', N'Hà Thị Thoa', 1, CAST(0x0000761800FBD7E0 AS DateTime), N'Nam Định', N'BT07C- P. An Bình, TX. Dĩ An, T. Bình Dương
', N'BT07C- P. An Bình, TX. Dĩ An, T. Bình Dương
', N'281014522', CAST(0x000099F300FBD7E0 AS DateTime), N'Bình Dương', N'', N'0908.272.360', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x00009AF100FBD7E0 AS DateTime), CAST(0x00009AF100FBD7E0 AS DateTime), CAST(0x0000A4B400FBD8F0 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (41, N'ICD140', 22, N'ICD140', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên Chăm sóc cây xanh', N'Nguyễn Văn Nhiệm', 0, CAST(0x0000628000FBD7E0 AS DateTime), N'Hải Phòng (TP)', N'3/17B, Bình Đức 1, Bình Hòa, Thuận An, Bình Dương
', N'3/17B, Bình Đức 1, Bình Hòa, Thuận An, Bình Dương
', N'141542388', CAST(0x0000869600FBD7E0 AS DateTime), N'Hải Dương', N'', N'0989.510.290', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x0000946100FBD7E0 AS DateTime), CAST(0x0000946100FBD7E0 AS DateTime), CAST(0x0000A4B400FBD8F0 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (42, N'ICD097', 23, N'ICD097', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Bếp trưởng', N'Bùi Đăng Sánh', 0, CAST(0x0000650300FBD7E0 AS DateTime), N'Hưng Yên', N'109/41 Đường số 8, KP 1, P. Linh Xuân, Q. Thủ Đức, HCM
', N'109/41 Đường số 8, KP 1, P. Linh Xuân, Q. Thủ Đức, HCM
', N'145279955', CAST(0x0000947B00FBD7E0 AS DateTime), N'Hưng Yên', N'', N'0917.103.188', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x0000871000FBD7E0 AS DateTime), CAST(0x0000918700FBD7E0 AS DateTime), CAST(0x0000A4B400FBD8F0 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (43, N'ICD163', 23, N'ICD163', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên Nấu ăn', N'Vũ Thị Ngoan', 1, CAST(0x00006F1A00FBD7E0 AS DateTime), N'Nam Định', N'86/13 Đường 12 KP 4, P. Tam Bình, Q. Thủ Đức, Tp. HCM
', N'86/13 Đường 12 KP 4, P. Tam Bình, Q. Thủ Đức, Tp. HCM
', N'32A961119089', CAST(0x0000947B00FBD7E0 AS DateTime), N'QC Hải Quân', N'', N'0988.290.723', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x00009AF000FBD7E0 AS DateTime), CAST(0x00009AF000FBD7E0 AS DateTime), CAST(0x0000A4B400FBD8F0 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (44, N'ICD242', 23, N'ICD242', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên Nấu ăn', N'Trần Thị Thanh Huyền', 1, CAST(0x0000790700B6ACD8 AS DateTime), N'Bắc Giang', N'48 Tổ 9 Đường Dân Chủ- KP 1, P. Hiệp Bình Phú- Q.9, Tp. HCM
', N'48 Tổ 9 Đường Dân Chủ- KP 1, P. Hiệp Bình Phú- Q.9, Tp. HCM
', N'024476447', CAST(0x0000974E00B6ACD8 AS DateTime), N'Hồ Chí Minh (TP)', N'', N'01654.070.883', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x00009F6300B6ACD8 AS DateTime), CAST(0x00009F6300B6ACD8 AS DateTime), CAST(0x0000A4B500B6AD4D AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (45, N'ICD151', 23, N'ICD151', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên Nấu ăn', N'Vũ Thị Hương Nhài', 1, CAST(0x0000755A00B6ACD8 AS DateTime), N'Vĩnh Phúc', N'25/16 A Đông Chiêu, Tân Đông Hiệp, Dĩ An, Bình Dương
', N'25/16 A Đông Chiêu, Tân Đông Hiệp, Dĩ An, Bình Dương
', N'135004196', CAST(0x0000915F00B6ACD8 AS DateTime), N'Vĩnh Phúc', N'', N'0982.413.021', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x0000990300B6ACD8 AS DateTime), CAST(0x0000990300B6ACD8 AS DateTime), CAST(0x0000A4B500B6AD4D AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (46, N'ICD212', 23, N'ICD212', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên Nấu ăn', N'Trần Thị Hiền', 1, CAST(0x0000765C00B882C4 AS DateTime), N'Hà Tây', N'4/5 KP Bình Đức 2, Bình Hòa, Thuận An, Bình Dương
', N'4/5 KP Bình Đức 2, Bình Hòa, Thuận An, Bình Dương
', N'111653402', CAST(0x000097A000B882C4 AS DateTime), N'Hà Tây', N'', N'0974.901.574', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x00009E4400B882C4 AS DateTime), CAST(0x00009E4400B882C4 AS DateTime), CAST(0x0000A4B500B882C8 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (47, N'ICD077', 10, N'ICD077', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 7, 23, N'Đội trưởng Đội DT-Điện nước', N'Phạm Đức Cơ', 0, CAST(0x00006A3800B882C4 AS DateTime), N'Thái Bình', N'15/5C2 Bình Đáng-Bình Hoà-Thuận An - Bình Dương
', N'15/5C2 Bình Đáng-Bình Hoà-Thuận An - Bình Dương
', N'151078989', CAST(0x0000947A00B882C4 AS DateTime), N'Thái Bình', N'', N'0989.177.026', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x0000869500B882C4 AS DateTime), CAST(0x0000946100B882C4 AS DateTime), CAST(0x0000A4B500B882C8 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (48, N'ICD078', 10, N'ICD078', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên DT-Điện nước', N'Vũ Văn Chiến', 0, CAST(0x0000633600E33604 AS DateTime), N'Thanh Hóa', N'13/13/12 Đường Tổ 7-8, Kp Thắng Lợi II, Dĩ An, Bình Dương
', N'13/13/12 Đường Tổ 7-8, Kp Thắng Lợi II, Dĩ An, Bình Dương
', N'171430761', CAST(0x0000932200E33604 AS DateTime), N'Thanh Hóa', N'', N'0983.682.319', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x0000977D00E33604 AS DateTime), CAST(0x0000977D00E33604 AS DateTime), CAST(0x0000A4B500E33718 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (49, N'ICD079', 10, N'ICD079', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên DT-Điện nước', N'Phùng Đình Hoàn', 0, CAST(0x0000699B00E33604 AS DateTime), N'Nghệ An', N'20/A6 KP3 Phường An Phú - Thuận An - Bình Dương
', N'20/A6 KP3 Phường An Phú - Thuận An - Bình Dương
', N'182060677', CAST(0x0000863600E33604 AS DateTime), N'Thanh Hóa', N'', N'0976.893.943', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x00008EE600E33604 AS DateTime), CAST(0x0000998600E33604 AS DateTime), CAST(0x0000A4B500E33718 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (50, N'ICD080', 10, N'ICD080', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 2, N'Nhân viên DT-Điện nước', N'Vũ Văn Thơi', 0, CAST(0x000078F300E54D90 AS DateTime), N'Thái Bình', N'44/20/13 Đường Cây Găng Cây Sao, KP Nhị Đồng II Phường Dĩ An - Thuận An - Bình Dương
', N'44/20/13 Đường Cây Găng Cây Sao, KP Nhị Đồng II Phường Dĩ An - Thuận An - Bình Dương
', N'151461966', CAST(0x00008F6800E54D90 AS DateTime), N'Thái Bình', N'', N'0902.626.355', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x000099A700E54D90 AS DateTime), CAST(0x000099A700E54D90 AS DateTime), CAST(0x0000A4B500E54E00 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (51, N'ICD200', 10, N'ICD200', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 2, N'Nhân viên DT-Điện nước', N'Phạm Công Lương', 0, CAST(0x00007BA900E54D90 AS DateTime), N'Quảng Ninh', N'10A/5I Kp Bình Đáng Bình Hòa - Thuận An - Bình Dương
', N'10A/5I Kp Bình Đáng Bình Hòa - Thuận An - Bình Dương
', N'100942123', CAST(0x000094A500E54D90 AS DateTime), N'Quảng Ninh', N'', N'01682.770.009', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x00009E4400E54D90 AS DateTime), CAST(0x00009E4400E54D90 AS DateTime), CAST(0x0000A4B500E54E00 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (52, N'ICD081', 11, N'ICD081', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 2, 8, 7, 2, N'Đội trưởng đội Bảo vệ', N'Nguyễn Duy Hoàng', 0, CAST(0x00006CAC00E54D90 AS DateTime), N'Thanh Hóa', N'12A/5/14 Bình Đáng, Bình Hòa, Thuận An, Bình Dương
', N'12A/5/14 Bình Đáng, Bình Hòa, Thuận An, Bình Dương
', N'32A951113404', CAST(0x0000923C00E54D90 AS DateTime), N'QC Hải Quân', N'', N'0908.177.840', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x0000885E00E54D90 AS DateTime), CAST(0x0000885E00E54D90 AS DateTime), CAST(0x0000A4B500E54E00 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (53, N'ICD085', 24, N'ICD085', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 4, 23, N'Tổ Trưởng Bảo vệ', N'Lê Minh Hà', 0, CAST(0x00005F6E00E54D90 AS DateTime), N'Hồ Chí Minh (TP)', N'113/39/13 Đường 11 Tổ 10 KP 4 Linh Xuân - Thủ Đức-TpHCM
', N'113/39/13 Đường 11 Tổ 10 KP 4 Linh Xuân - Thủ Đức-TpHCM
', N'21774334', CAST(0x00009B7B00E54D90 AS DateTime), N'#N/A', N'', N'0903.000.692', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x0000885E00E54D90 AS DateTime), CAST(0x0000885E00E54D90 AS DateTime), CAST(0x0000A4B500E54E00 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (54, N'ICD087', 24, N'ICD087', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 4, 2, N'Tổ Trưởng Bảo vệ', N'Phạm Văn Hinh', 0, CAST(0x000063D70100C728 AS DateTime), N'Nam Định', N'100/23 Tổ 23B Tân Long-Tân Đông Hiệp- Dĩ An - Bình Dương
', N'100/23 Tổ 23B Tân Long-Tân Đông Hiệp- Dĩ An - Bình Dương
', N'161774968', CAST(0x00008ECA0100C728 AS DateTime), N'Nam Định', N'', N'0908.939.982', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x000092C90100C728 AS DateTime), CAST(0x000092C90100C728 AS DateTime), CAST(0x0000A4B50100C7F1 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (55, N'ICD092', 24, N'ICD092', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 4, 2, N'Tổ Trưởng Bảo vệ', N'Nguyễn Xuân Tân', 0, CAST(0x00005441010227E4 AS DateTime), N'Hải Dương', N'13B/5K Bình Đáng - Bình Hòa - Thuận An - Bình Dương
', N'13B/5K Bình Đáng - Bình Hòa - Thuận An - Bình Dương
', N'280983986', CAST(0x00009834010227E4 AS DateTime), N'Bình Dương', N'', N'0987.002.980', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x00009261010227E4 AS DateTime), CAST(0x00009261010227E4 AS DateTime), CAST(0x0000A4B5010228E6 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (56, N'ICD094', 24, N'ICD094', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 4, 2, N'Tổ Trưởng Bảo vệ', N'Nguyễn Văn Trưởng', 0, CAST(0x0000693A010227E4 AS DateTime), N'Nam Định', N'30K/29 KP Đông Tân - Phường Dĩ An - Bình Dương
', N'30K/29 KP Đông Tân - Phường Dĩ An - Bình Dương
', N'352021349', CAST(0x00009812010227E4 AS DateTime), N'An Giang', N'', N'0918.798.868', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x00008565010227E4 AS DateTime), CAST(0x00008565010227E4 AS DateTime), CAST(0x0000A4B5010228E6 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (57, N'ICD082', 24, N'ICD082', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên Bảo vệ', N'Lâm Văn Anh', 0, CAST(0x00006F28010227E4 AS DateTime), N'Hải Phòng (TP)', N'20/6/24/17/14 KP 6 P Thạnh Xuân Q12
', N'20/6/24/17/14 KP 6 P Thạnh Xuân Q12
', N'31050226', CAST(0x000093BA010227E4 AS DateTime), N'Hải Phòng (TP)', N'', N'01688.253.474', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x0000902C010227E4 AS DateTime), CAST(0x0000902C010227E4 AS DateTime), CAST(0x0000A4B5010228E6 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (58, N'ICD083', 24, N'ICD083', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên Bảo vệ', N'Lê Ngọc Cẩm', 0, CAST(0x000069FD00909B88 AS DateTime), N'Hà Tĩnh', N'1/4 D Đường 74 Tổ 4 KP 5 Phước Long A Q9 Tp HCM', N'1/4 D Đường 74 Tổ 4 KP 5 Phước Long A Q9 Tp HCM', N'25064598', CAST(0x00009B7D00909B88 AS DateTime), N'Hồ Chí Minh (TP)', N'', N'0913.726.591', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x0000895900909B88 AS DateTime), CAST(0x0000895900909B88 AS DateTime), CAST(0x0000A4B900909C38 AS DateTime), N'Đã kết hôn', N'')
INSERT [dbo].[ThongTinNhanVIen] ([idNhanVien], [MaNV], [idPhongDoiToLoai], [userName], [password], [permission], [idBienChe], [idCapBac], [idChucVu], [idTP], [CongViecDangLam], [hoTen], [gioiTinh], [namSinh], [nguyenQuan], [noiOHienNay], [hoKhau], [CMND], [ngayCapCMND], [noiCapCMND], [soDienThoaiNha], [soDienThoaiDiDong], [nguoiBaoLanh], [moiQuanHeBaoLanh], [noiCongTac], [ngayVaoCang], [namVaoSongThan], [ngayNhapNgu], [tinhTrangHonNhan], [hinhAnhCaNhan]) VALUES (59, N'ICD086', 24, N'ICD086', N'5c6ec9f886bf0a02695ba293780c67f0', 0, 5, 17, 5, 23, N'Nhân viên Bảo vệ', N'Trần Thanh Hải', 0, CAST(0x0000518000909B88 AS DateTime), N'Hà Tĩnh', N'40 Tổ 1 KP 3 Phước Long B Q9 Tp HCM', N'40 Tổ 1 KP 3 Phước Long B Q9 Tp HCM', N'24301692', CAST(0x0000959A00909B88 AS DateTime), N'Hồ Chí Minh (TP)', N'', N'01652.776.817', N'Chưa Cập Nhật', N'Chưa Cập Nhật', N'ICDST', CAST(0x000087FD00909B88 AS DateTime), CAST(0x00009CD200909B88 AS DateTime), CAST(0x0000A4B900909C38 AS DateTime), N'Đã kết hôn', N'')
SET IDENTITY_INSERT [dbo].[ThongTinNhanVIen] OFF
SET IDENTITY_INSERT [dbo].[TrinhDo] ON 

INSERT [dbo].[TrinhDo] ([idTrinhDo], [TrinhDo]) VALUES (1, N'12/12')
INSERT [dbo].[TrinhDo] ([idTrinhDo], [TrinhDo]) VALUES (2, N'Trung Cấp')
INSERT [dbo].[TrinhDo] ([idTrinhDo], [TrinhDo]) VALUES (3, N'Cao Đẳng')
INSERT [dbo].[TrinhDo] ([idTrinhDo], [TrinhDo]) VALUES (4, N'Đại Học')
INSERT [dbo].[TrinhDo] ([idTrinhDo], [TrinhDo]) VALUES (5, N'Thạc Sĩ')
INSERT [dbo].[TrinhDo] ([idTrinhDo], [TrinhDo]) VALUES (6, N'Tiến Sĩ')
SET IDENTITY_INSERT [dbo].[TrinhDo] OFF
ALTER TABLE [dbo].[PhongDoiToLoaiTo] ADD  CONSTRAINT [DF_PhongDoiToLoaiTo_idCha]  DEFAULT ((0)) FOR [idCha]
GO
ALTER TABLE [dbo].[HopDongLaoDong]  WITH CHECK ADD  CONSTRAINT [HopDongLaoDong_LoaiHopDong] FOREIGN KEY([idLoaiHopDong])
REFERENCES [dbo].[LoaiHopDong] ([idLoaiHopDong])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HopDongLaoDong] CHECK CONSTRAINT [HopDongLaoDong_LoaiHopDong]
GO
ALTER TABLE [dbo].[HopDongLaoDong]  WITH CHECK ADD  CONSTRAINT [HopDongLaoDong_ThongTinNhanVIen] FOREIGN KEY([idNhanVien])
REFERENCES [dbo].[ThongTinNhanVIen] ([idNhanVien])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HopDongLaoDong] CHECK CONSTRAINT [HopDongLaoDong_ThongTinNhanVIen]
GO
ALTER TABLE [dbo].[KhenThuong]  WITH CHECK ADD  CONSTRAINT [KhenThuong_ThongTinNhanVIen] FOREIGN KEY([idNhanVien])
REFERENCES [dbo].[ThongTinNhanVIen] ([idNhanVien])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KhenThuong] CHECK CONSTRAINT [KhenThuong_ThongTinNhanVIen]
GO
ALTER TABLE [dbo].[KyLuat]  WITH CHECK ADD  CONSTRAINT [KyLuat_ThongTinNhanVIen] FOREIGN KEY([idNhanVien])
REFERENCES [dbo].[ThongTinNhanVIen] ([idNhanVien])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KyLuat] CHECK CONSTRAINT [KyLuat_ThongTinNhanVIen]
GO
ALTER TABLE [dbo].[PhongDoiToLoaiTo]  WITH NOCHECK ADD  CONSTRAINT [FK_PhongDoiToLoaiTo_PhongDoiToLoaiTo] FOREIGN KEY([idCha])
REFERENCES [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai])
GO
ALTER TABLE [dbo].[PhongDoiToLoaiTo] CHECK CONSTRAINT [FK_PhongDoiToLoaiTo_PhongDoiToLoaiTo]
GO
ALTER TABLE [dbo].[TD-DD-BN-TV]  WITH CHECK ADD  CONSTRAINT [TD_DD_BN_TV_ThongTinNhanVIen] FOREIGN KEY([idNhanVien])
REFERENCES [dbo].[ThongTinNhanVIen] ([idNhanVien])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TD-DD-BN-TV] CHECK CONSTRAINT [TD_DD_BN_TV_ThongTinNhanVIen]
GO
ALTER TABLE [dbo].[ThongTinGiaDinh]  WITH CHECK ADD  CONSTRAINT [ThongTinGiaDinh_ThongTinNhanVIen] FOREIGN KEY([idNhanVien])
REFERENCES [dbo].[ThongTinNhanVIen] ([idNhanVien])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ThongTinGiaDinh] CHECK CONSTRAINT [ThongTinGiaDinh_ThongTinNhanVIen]
GO
ALTER TABLE [dbo].[ThongTinNhanVIen]  WITH CHECK ADD  CONSTRAINT [ThongTinNhanVIen_BienChe] FOREIGN KEY([idBienChe])
REFERENCES [dbo].[BienChe] ([idBienChe])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ThongTinNhanVIen] CHECK CONSTRAINT [ThongTinNhanVIen_BienChe]
GO
ALTER TABLE [dbo].[ThongTinNhanVIen]  WITH CHECK ADD  CONSTRAINT [ThongTinNhanVIen_CapBac] FOREIGN KEY([idCapBac])
REFERENCES [dbo].[CapBac] ([idCapBac])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ThongTinNhanVIen] CHECK CONSTRAINT [ThongTinNhanVIen_CapBac]
GO
ALTER TABLE [dbo].[ThongTinNhanVIen]  WITH CHECK ADD  CONSTRAINT [ThongTinNhanVIen_ChucVu] FOREIGN KEY([idChucVu])
REFERENCES [dbo].[ChucVu] ([idChucVu])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ThongTinNhanVIen] CHECK CONSTRAINT [ThongTinNhanVIen_ChucVu]
GO
ALTER TABLE [dbo].[ThongTinNhanVIen]  WITH CHECK ADD  CONSTRAINT [ThongTinNhanVIen_PhongDoiToLoai] FOREIGN KEY([idPhongDoiToLoai])
REFERENCES [dbo].[PhongDoiToLoaiTo] ([idPhongDoiToLoai])
GO
ALTER TABLE [dbo].[ThongTinNhanVIen] CHECK CONSTRAINT [ThongTinNhanVIen_PhongDoiToLoai]
GO
ALTER TABLE [dbo].[ThongTinNhanVIen]  WITH CHECK ADD  CONSTRAINT [ThongTinNhanVIen_ThanhPho] FOREIGN KEY([idTP])
REFERENCES [dbo].[ThanhPho] ([idThanhPho])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ThongTinNhanVIen] CHECK CONSTRAINT [ThongTinNhanVIen_ThanhPho]
GO
ALTER TABLE [dbo].[ThongTinTrinhDo]  WITH CHECK ADD  CONSTRAINT [FK_ThongTinTrinhDo_ThongTinNhanVIen] FOREIGN KEY([idNhanVien])
REFERENCES [dbo].[ThongTinNhanVIen] ([idNhanVien])
GO
ALTER TABLE [dbo].[ThongTinTrinhDo] CHECK CONSTRAINT [FK_ThongTinTrinhDo_ThongTinNhanVIen]
GO
ALTER TABLE [dbo].[ThongTinTrinhDo]  WITH CHECK ADD  CONSTRAINT [FK_ThongTinTrinhDo_TrinhDo] FOREIGN KEY([idTrinhDo])
REFERENCES [dbo].[TrinhDo] ([idTrinhDo])
GO
ALTER TABLE [dbo].[ThongTinTrinhDo] CHECK CONSTRAINT [FK_ThongTinTrinhDo_TrinhDo]
GO
