USE [QL_DUNGCU]
GO
/****** Object:  Table [dbo].[CART_ITEM]    Script Date: 7/4/2021 12:44:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CART_ITEM](
	[TENTK] [char](20) NOT NULL,
	[MASP] [char](5) NOT NULL,
	[TENSP] [nvarchar](50) NULL,
	[GIABAN] [int] NULL,
	[SOLUONG] [int] NULL,
	[THANHTIEN] [bigint] NULL,
	[TRANGTHAI] [int] NULL,
	[HINH] [nvarchar](max) NULL,
 CONSTRAINT [PK_GIOHANG] PRIMARY KEY CLUSTERED 
(
	[TENTK] ASC,
	[MASP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 7/4/2021 12:44:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[MAHD] [int] NOT NULL,
	[MASP] [char](5) NOT NULL,
	[SOLUONG] [int] NULL,
	[THANHTIEN] [float] NULL,
	[GIABAN] [int] NULL,
 CONSTRAINT [PK_CTHOADON] PRIMARY KEY CLUSTERED 
(
	[MAHD] ASC,
	[MASP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DANHMUC]    Script Date: 7/4/2021 12:44:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DANHMUC](
	[MADM] [char](5) NOT NULL,
	[TENDM] [nvarchar](50) NULL,
	[HINH] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MADM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 7/4/2021 12:44:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOADON](
	[MAHD] [int] IDENTITY(1,1) NOT NULL,
	[TENTK] [char](20) NULL,
	[NGAYDAT] [date] NULL,
	[DIACHIGIAO] [nvarchar](50) NULL,
	[TRANGTHAI] [nvarchar](50) NULL,
	[TONGTIEN] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 7/4/2021 12:44:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MANCC] [char](5) NOT NULL,
	[TENNCC] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MANCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 7/4/2021 12:44:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MASP] [char](5) NOT NULL,
	[TENSP] [nvarchar](50) NULL,
	[MOTA] [nvarchar](50) NULL,
	[HINHANH] [char](50) NULL,
	[GIABAN] [int] NULL,
	[SOLUONGTON] [int] NULL,
	[MADM] [char](5) NULL,
	[MANCC] [char](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[MASP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SPTHICH]    Script Date: 7/4/2021 12:44:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SPTHICH](
	[TENTK] [char](20) NOT NULL,
	[MASP] [char](5) NOT NULL,
 CONSTRAINT [PK_SPTHICH] PRIMARY KEY CLUSTERED 
(
	[TENTK] ASC,
	[MASP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 7/4/2021 12:44:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[TENTK] [char](20) NOT NULL,
	[MATKHAU] [char](30) NULL,
	[HOTEN] [nvarchar](50) NULL,
	[VAITRO] [nvarchar](10) NULL,
	[TRANGTHAI] [char](10) NULL,
	[SDT] [varchar](11) NULL,
	[DIACHI] [nvarchar](255) NULL,
	[QUEQUAN] [nvarchar](100) NULL,
	[THANHPHO] [nvarchar](100) NULL,
	[HINH] [nvarchar](255) NULL,
	[EMAIL] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[TENTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CHITIETHOADON] ([MAHD], [MASP], [SOLUONG], [THANHTIEN], [GIABAN]) VALUES (4, N'ji002', 5, 900000, 180000)
INSERT [dbo].[CHITIETHOADON] ([MAHD], [MASP], [SOLUONG], [THANHTIEN], [GIABAN]) VALUES (5, N'lq001', 2, 500000, 250000)
INSERT [dbo].[CHITIETHOADON] ([MAHD], [MASP], [SOLUONG], [THANHTIEN], [GIABAN]) VALUES (5, N'lq005', 2, 600000, 300000)
INSERT [dbo].[CHITIETHOADON] ([MAHD], [MASP], [SOLUONG], [THANHTIEN], [GIABAN]) VALUES (6, N'fa001', 2, 100000, 50000)
INSERT [dbo].[CHITIETHOADON] ([MAHD], [MASP], [SOLUONG], [THANHTIEN], [GIABAN]) VALUES (6, N'sp010', 1, 250000, 250000)
INSERT [dbo].[DANHMUC] ([MADM], [TENDM], [HINH]) VALUES (N'1    ', N'Bình Lắc (Shaker)', N'shaker.jpg')
INSERT [dbo].[DANHMUC] ([MADM], [TENDM], [HINH]) VALUES (N'10   ', N'Set Dụng Cụ Bar (Set Tool)', N'settools.jpg')
INSERT [dbo].[DANHMUC] ([MADM], [TENDM], [HINH]) VALUES (N'11   ', N'Vòi Rót Rượu (Pour)', N'pour.jpg')
INSERT [dbo].[DANHMUC] ([MADM], [TENDM], [HINH]) VALUES (N'2    ', N'Bộ Ly Đo Lường (Jigger)', N'jigger.jpg')
INSERT [dbo].[DANHMUC] ([MADM], [TENDM], [HINH]) VALUES (N'3    ', N'Chày Dằm Bar (Muddle)', N'muddler.jpg')
INSERT [dbo].[DANHMUC] ([MADM], [TENDM], [HINH]) VALUES (N'4    ', N'Dụng Cụ Biểu Diễn (Flairs)', N'flairs.jpg')
INSERT [dbo].[DANHMUC] ([MADM], [TENDM], [HINH]) VALUES (N'5    ', N'Dụng Cụ Ép Chanh (Lemon Squueezer)', N'lemonsqueeze.jpg')
INSERT [dbo].[DANHMUC] ([MADM], [TENDM], [HINH]) VALUES (N'6    ', N'Đồ Lọc Đá (Strainer)', N'strainer.jpg')
INSERT [dbo].[DANHMUC] ([MADM], [TENDM], [HINH]) VALUES (N'7    ', N'Ly TIKI Các Loại', N'tikiglass.jpg')
INSERT [dbo].[DANHMUC] ([MADM], [TENDM], [HINH]) VALUES (N'8    ', N'Mixologist', N'mixology.jpg')
INSERT [dbo].[DANHMUC] ([MADM], [TENDM], [HINH]) VALUES (N'9    ', N'Muỗng Bar (Bar Spoon)', N'barspoon.jpg')
SET IDENTITY_INSERT [dbo].[HOADON] ON 

INSERT [dbo].[HOADON] ([MAHD], [TENTK], [NGAYDAT], [DIACHIGIAO], [TRANGTHAI], [TONGTIEN]) VALUES (4, N'tuthanh2309         ', CAST(N'2021-05-22' AS Date), N'298/4 Đường số 12,Bình Tân,Hồ Chí Minh', N'Chưa giao', 900000)
INSERT [dbo].[HOADON] ([MAHD], [TENTK], [NGAYDAT], [DIACHIGIAO], [TRANGTHAI], [TONGTIEN]) VALUES (5, N'vunguyen            ', CAST(N'2021-05-22' AS Date), N'23 Phạm Đăng Giảng,Bình Tân,Hồ Chí Minh', N'Chưa giao', 1100000)
INSERT [dbo].[HOADON] ([MAHD], [TENTK], [NGAYDAT], [DIACHIGIAO], [TRANGTHAI], [TONGTIEN]) VALUES (6, N'phatpheo            ', CAST(N'2021-05-23' AS Date), N'29/3 Đường số 12,Bình Tân,Hồ Chí Minh', N'Chưa giao', 350000)
SET IDENTITY_INSERT [dbo].[HOADON] OFF
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC]) VALUES (N'1    ', N'VinBar')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC]) VALUES (N'2    ', N'Bartender''s Mart')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC]) VALUES (N'3    ', N'DVP Market')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'fa001', N'Flairs-001', N'', N'flairs001.jpg                                     ', 50000, 228, N'4    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'fa002', N'Flairs-002', N'', N'flairs002.jpg                                     ', 40000, 25, N'4    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'fa003', N'Flairs-003', N'', N'flairs003.jpg                                     ', 40000, 148, N'4    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'fa004', N'Flairs-004', N'', N'flairs004.jpg                                     ', 45000, 500, N'4    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'fa005', N'Flairs-005', N'', N'flairs005.jpg                                     ', 45000, 482, N'4    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'fa006', N'Flairs-006', N'', N'flairs006.jpg                                     ', 45000, 510, N'4    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'fa007', N'Flairs-007', N'', N'flairs007.jpg                                     ', 45000, 510, N'4    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'fa008', N'Flairs-008', N'', N'flairs008.jpg                                     ', 55000, 150, N'4    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'fa009', N'Flairs-009', N'', N'flairs009.jpg                                     ', 55000, 300, N'4    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'fa010', N'Flairs-010', N'', N'flairs010.jpg                                     ', 55000, 300, N'4    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'ji001', N'Jigger-001', N'', N'jigger001.jpg                                     ', 80000, 300, N'2    ', N'2    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'ji002', N'Jigger-002', N'', N'jigger002.jpg                                     ', 180000, 495, N'2    ', N'2    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'ji003', N'Jigger-003', N'', N'jigger003.jpg                                     ', 180000, 505, N'2    ', N'2    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'ji004', N'Jigger-004', N'', N'jigger004.jpg                                     ', 180000, 100, N'2    ', N'2    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'ji005', N'Jigger-005', N'', N'jigger005.jpg                                     ', 300000, 200, N'2    ', N'2    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'ji006', N'Jigger-006', N'', N'jigger006.jpg                                     ', 400000, 200, N'2    ', N'2    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'ji007', N'Jigger-007', N'', N'jigger007.jpg                                     ', 400000, 200, N'2    ', N'2    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'ji008', N'Jigger-008', N'', N'jigger008.jpg                                     ', 600000, 200, N'2    ', N'2    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'ji009', N'Jigger-009', N'', N'jigger009.jpg                                     ', 900000, 200, N'2    ', N'2    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'ji010', N'Jigger-010', N'', N'jigger010.jpg                                     ', 1000000, 120, N'2    ', N'2    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'lq001', N'Lemon Squeezer-001', N'', N'lq001.jpg                                         ', 250000, 298, N'5    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'lq002', N'Lemon Squeezer-002', N'', N'lq002.jpg                                         ', 250000, 300, N'5    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'lq003', N'Lemon Squeezer-003', N'', N'lq002.jpg                                         ', 350000, 300, N'5    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'lq004', N'Lemon Squeezer-004', N'', N'lq004.jpg                                         ', 350000, 300, N'5    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'lq005', N'Lemon Squeezer-005', N'', N'lq005.jpg                                         ', 300000, 298, N'5    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'lq006', N'Lemon Squeezer-006', N'', N'lq006.jpg                                         ', 300000, 300, N'5    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'lq007', N'Lemon Squeezer-007', N'', N'lq007.jpg                                         ', 500000, 300, N'5    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'lq008', N'Lemon Squeezer-008', N'', N'lq008.jpg                                         ', 500000, 400, N'5    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'lq009', N'Lemon Squeezer-009', N'', N'lq009.jpg                                         ', 500000, 400, N'5    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'lq010', N'Lemon Squeezer-010', N'', N'lq010.jpg                                         ', 500000, 400, N'5    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'mu001', N'Muddler-001', N'', N'muddler001.jpg                                    ', 150000, 300, N'3    ', N'3    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'mu002', N'Muddler-002', N'', N'muddler001.jpg                                    ', 150000, 300, N'3    ', N'3    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'mu003', N'Muddler-003', N'', N'muddler003.jpg                                    ', 200000, 300, N'3    ', N'3    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'mu004', N'Muddler-004', N'', N'muddler004.jpg                                    ', 400000, 300, N'3    ', N'3    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'mu005', N'Muddler-005', N'', N'muddler005.jpg                                    ', 400000, 300, N'3    ', N'3    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'mu006', N'Muddler-006', N'', N'muddler006.jpg                                    ', 500000, 300, N'3    ', N'3    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'mu007', N'Muddler-007', N'', N'muddler007.jpg                                    ', 500000, 400, N'3    ', N'3    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'mu008', N'Muddler-008', N'', N'muddler008.jpg                                    ', 500000, 400, N'3    ', N'3    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'mu009', N'Muddler-009', N'', N'muddler009.jpg                                    ', 600000, 400, N'3    ', N'3    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'mu010', N'Muddler-010', N'', N'muddler010.jpg                                    ', 600000, 400, N'3    ', N'3    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'po001', N'Pour-001', N'', N'pour001.jpg                                       ', 200000, 299, N'11   ', N'3    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'po002', N'Pour-002', N'', N'pour002.jpg                                       ', 200000, 300, N'11   ', N'3    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'po003', N'Pour-003', N'', N'pour003.jpg                                       ', 500000, 300, N'11   ', N'3    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'po004', N'Pour-004', N'', N'pour004.jpg                                       ', 300000, 300, N'11   ', N'3    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'po005', N'Pour-005', N'', N'pour005.jpg                                       ', 300000, 300, N'11   ', N'3    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'sa001', N'Shaker-001', N'', N'pour005.jpg                                       ', 500000, 300, N'1    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'sa002', N'Shaker-002', N'', N'shaker002.jpg                                     ', 600000, 300, N'1    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'sa003', N'Shaker-003', N'', N'shaker003.jpg                                     ', 500000, 169, N'1    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'sa004', N'Shaker-004', N'', N'shaker004.jpg                                     ', 500000, 200, N'1    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'sa005', N'Shaker-005', N'', N'shaker005.jpg                                     ', 500000, 200, N'1    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'sa006', N'Shaker-006', N'', N'shaker006.jpg                                     ', 700000, 200, N'1    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'sa007', N'Shaker-007', N'', N'shaker007.jpg                                     ', 700000, 220, N'1    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'sa008', N'Shaker-008', N'', N'shaker008.jpg                                     ', 700000, 200, N'1    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'sa009', N'Shaker-009', N'', N'shaker009.jpg                                     ', 700000, 200, N'1    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'sa010', N'Shaker-010', N'', N'shaker010.jpg                                     ', 800000, 200, N'1    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'sp001', N'Spoon-001', N'', N'spoon001.jpg                                      ', 100000, 400, N'9    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'sp002', N'Spoon-002', N'', N'spoon002.jpg                                      ', 100000, 400, N'9    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'sp003', N'Spoon-003', N'', N'spoon003.jpg                                      ', 100000, 400, N'9    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'sp004', N'Spoon-004', N'', N'spoon004.jpg                                      ', 100000, 400, N'9    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'sp005', N'Spoon-005', N'', N'spoon005.jpg                                      ', 100000, 400, N'9    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'sp006', N'Spoon-006', N'', N'spoon006.jpg                                      ', 200000, 400, N'9    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'sp007', N'Spoon-007', N'', N'spoon007.jpg                                      ', 400000, 400, N'9    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'sp008', N'Spoon-008', N'', N'spoon008.jpg                                      ', 250000, 400, N'9    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'sp009', N'Spoon-009', N'', N'spoon009.jpg                                      ', 250000, 400, N'9    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'sp010', N'Spoon-010', N'', N'spoon010.jpg                                      ', 250000, 399, N'9    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'st001', N'Strainer-001', N'', N'strainer001.jpg                                   ', 199000, 399, N'6    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'st002', N'Strainer-002', N'', N'strainer002.jpg                                   ', 199000, 400, N'6    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'st003', N'Strainer-003', N'', N'strainer003.jpg                                   ', 199000, 400, N'6    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'st004', N'Strainer-004', N'', N'strainer004.jpg                                   ', 299000, 400, N'6    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'st005', N'Strainer-005', N'', N'strainer005.jpg                                   ', 299000, 400, N'6    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'st006', N'Strainer-006', N'', N'strainer006.jpg                                   ', 299000, 400, N'6    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'st007', N'Strainer-007', N'', N'strainer007.jpg                                   ', 299000, 400, N'6    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'st008', N'Strainer-008', N'', N'strainer008.jpg                                   ', 299000, 400, N'6    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'st009', N'Strainer-009', N'', N'strainer009.jpg                                   ', 299000, 400, N'6    ', N'1    ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [HINHANH], [GIABAN], [SOLUONGTON], [MADM], [MANCC]) VALUES (N'st010', N'Strainer-010', N'', N'strainer010.jpg                                   ', 499000, 300, N'6    ', N'1    ')
INSERT [dbo].[TAIKHOAN] ([TENTK], [MATKHAU], [HOTEN], [VAITRO], [TRANGTHAI], [SDT], [DIACHI], [QUEQUAN], [THANHPHO], [HINH], [EMAIL]) VALUES (N'adbao               ', N'11                            ', N'Lê Quốc Bảo', N'ADMIN', N'ok        ', N'0703456682', N'15/14 Ap Chien Luoc, Binh Tan', NULL, N'HCM', NULL, N'lequocbao102000@gmail.com')
INSERT [dbo].[TAIKHOAN] ([TENTK], [MATKHAU], [HOTEN], [VAITRO], [TRANGTHAI], [SDT], [DIACHI], [QUEQUAN], [THANHPHO], [HINH], [EMAIL]) VALUES (N'adminh              ', N'1                             ', N'Nguyễn Hoàng Minh', N'ADMIN', N'ok        ', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TAIKHOAN] ([TENTK], [MATKHAU], [HOTEN], [VAITRO], [TRANGTHAI], [SDT], [DIACHI], [QUEQUAN], [THANHPHO], [HINH], [EMAIL]) VALUES (N'hyluadao            ', N'123                           ', N'Dương Hớn Hy', N'Khách hàng', N'ok        ', N'09382529001', N'Tân phú', N'Trung Quốc', N'Quảng Châu', N'default-avatar.jpg', N'hy.duonng@gmail.com')
INSERT [dbo].[TAIKHOAN] ([TENTK], [MATKHAU], [HOTEN], [VAITRO], [TRANGTHAI], [SDT], [DIACHI], [QUEQUAN], [THANHPHO], [HINH], [EMAIL]) VALUES (N'phatpheo            ', N'123                           ', N'Vũ Tiến Phát', N'Khách hàng', N'ok        ', N'0703456682', N'', N'', N'', N'default-avatar.jpg', N'')
INSERT [dbo].[TAIKHOAN] ([TENTK], [MATKHAU], [HOTEN], [VAITRO], [TRANGTHAI], [SDT], [DIACHI], [QUEQUAN], [THANHPHO], [HINH], [EMAIL]) VALUES (N'tuthanh2309         ', N'2309                          ', N'Phạm Tú Thanh', N'Khách hàng', N'ok        ', N'0703456682', N'', N'', N'', N'default-avatar.jpg', N'')
INSERT [dbo].[TAIKHOAN] ([TENTK], [MATKHAU], [HOTEN], [VAITRO], [TRANGTHAI], [SDT], [DIACHI], [QUEQUAN], [THANHPHO], [HINH], [EMAIL]) VALUES (N'vunguyen            ', N'71                            ', N'Nguyễn Hoàng Vũ', N'Khách hàng', N'ok        ', N'09382529001', N'Bình Tân', N'Việt Nam', N'TP.HCM', N'default-avatar.jpg', N'vunguyen@gmail.com')
ALTER TABLE [dbo].[CART_ITEM]  WITH CHECK ADD  CONSTRAINT [FK_CART_SP] FOREIGN KEY([MASP])
REFERENCES [dbo].[SANPHAM] ([MASP])
GO
ALTER TABLE [dbo].[CART_ITEM] CHECK CONSTRAINT [FK_CART_SP]
GO
ALTER TABLE [dbo].[CART_ITEM]  WITH CHECK ADD  CONSTRAINT [FK_CART_TK] FOREIGN KEY([TENTK])
REFERENCES [dbo].[TAIKHOAN] ([TENTK])
GO
ALTER TABLE [dbo].[CART_ITEM] CHECK CONSTRAINT [FK_CART_TK]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CTHOADON_HD] FOREIGN KEY([MAHD])
REFERENCES [dbo].[HOADON] ([MAHD])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CTHOADON_HD]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CTHOADON_SP] FOREIGN KEY([MASP])
REFERENCES [dbo].[SANPHAM] ([MASP])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CTHOADON_SP]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HD_TK] FOREIGN KEY([TENTK])
REFERENCES [dbo].[TAIKHOAN] ([TENTK])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HD_TK]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_SP_DM] FOREIGN KEY([MADM])
REFERENCES [dbo].[DANHMUC] ([MADM])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_SP_DM]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_SP_NCC] FOREIGN KEY([MANCC])
REFERENCES [dbo].[NHACUNGCAP] ([MANCC])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_SP_NCC]
GO
ALTER TABLE [dbo].[SPTHICH]  WITH CHECK ADD  CONSTRAINT [FK_LIKE_SP] FOREIGN KEY([MASP])
REFERENCES [dbo].[SANPHAM] ([MASP])
GO
ALTER TABLE [dbo].[SPTHICH] CHECK CONSTRAINT [FK_LIKE_SP]
GO
ALTER TABLE [dbo].[SPTHICH]  WITH CHECK ADD  CONSTRAINT [FK_LIKE_TK] FOREIGN KEY([TENTK])
REFERENCES [dbo].[TAIKHOAN] ([TENTK])
GO
ALTER TABLE [dbo].[SPTHICH] CHECK CONSTRAINT [FK_LIKE_TK]
GO
