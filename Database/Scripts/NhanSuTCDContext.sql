create table [dbo].[BienChe] (
    [idBienChe] [int] not null identity,
    [maBienChe] [nvarchar](50) not null,
    [bienChe] [nvarchar](100) not null,
    primary key ([idBienChe])
);
create table [dbo].[CapBac] (
    [idCapBac] [int] not null identity,
    [maCapBac] [nvarchar](50) not null,
    [capBac] [nvarchar](100) not null,
    primary key ([idCapBac])
);
create table [dbo].[ChucVu] (
    [idChucVu] [int] not null identity,
    [MaChucVu] [nvarchar](50) not null,
    [ChucVu] [nvarchar](150) not null,
    primary key ([idChucVu])
);
create table [dbo].[Doi] (
    [idDoi] [int] not null identity,
    [idPhong] [int] not null,
    [maDoi] [nvarchar](50) not null,
    [tenDoi] [nvarchar](100) not null,
    primary key ([idDoi])
);
create table [dbo].[HopDongLaoDong] (
    [idHopDongLaoDong] [int] not null identity,
    [idNhanVien] [int] not null,
    [soHopDong_TTHDLD] [nvarchar](20) not null,
    [nguoiBaoLanh_TTHDLD] [nvarchar](150) not null,
    [chucDanh] [nvarchar](150) not null,
    [idLoaiHopDong] [int] not null,
    [ngayBatDau] [datetime] not null,
    [ngayKetThuc] [datetime] not null,
    [ghiChu] [nvarchar](max) null,
    primary key ([idHopDongLaoDong])
);
create table [dbo].[KhenThuong] (
    [idKhenThuong] [int] not null identity,
    [idNhanVien] [int] not null,
    [namKhenThuong] [datetime] not null,
    [loaiKhenThuong] [nvarchar](100) not null,
    [capKhenThuong] [nvarchar](100) not null,
    [soSoKhenThuong] [nvarchar](100) not null,
    [nguoiKhenThuong] [nvarchar](100) not null,
    [thanhTichKhenThuong] [nvarchar](100) not null,
    [ghiChu] [nvarchar](max) null,
    primary key ([idKhenThuong])
);
create table [dbo].[KyLuat] (
    [idKyLuat] [int] not null identity,
    [idNhanVien] [int] not null,
    [ngayKyLuat] [datetime] not null,
    [loaiKyLuat] [nvarchar](150) not null,
    [capKyLuat] [nvarchar](100) not null,
    [soQuyetDinhKyLuat] [nvarchar](50) not null,
    [nguoiKyQuyetDinh] [nvarchar](100) not null,
    [hanhViBiKyLuat] [nvarchar](max) not null,
    [ghiChu] [nvarchar](max) null,
    primary key ([idKyLuat])
);
create table [dbo].[LoaiHopDong] (
    [idLoaiHopDong] [int] not null identity,
    [loaiHopDong] [nvarchar](150) null,
    [idCha] [int] not null,
    primary key ([idLoaiHopDong])
);
create table [dbo].[LoaiTo] (
    [idLoaiTo] [int] not null identity,
    [idTo] [int] not null,
    [maLoaiTo] [nvarchar](50) not null,
    [tenLoaiTo] [nvarchar](150) not null,
    primary key ([idLoaiTo])
);
create table [dbo].[Phong] (
    [idPhong] [int] not null identity,
    [maPhong] [nvarchar](50) not null,
    [tenPhong] [nvarchar](100) not null,
    primary key ([idPhong])
);
create table [dbo].[sysdiagrams] (
    [diagram_id] [int] not null identity,
    [name] [nvarchar](128) not null,
    [principal_id] [int] not null,
    [version] [int] null,
    [definition] [varbinary](max) null,
    primary key ([diagram_id])
);
create table [dbo].[TD-DD-BN-TV] (
    [idTDDDBNTV] [int] not null identity,
    [idNhanVien] [int] not null,
    [hoTenDD] [nvarchar](50) not null,
    [noiDung] [nvarchar](20) not null,
    [namThucHien] [datetime] not null,
    [viTriCu] [nvarchar](max) null,
    [viTriMoi] [nvarchar](max) null,
    [dienLaoDong] [nvarchar](100) null,
    [dienHuongLuong] [nvarchar](50) null,
    [soQuyetDinh] [nvarchar](50) null,
    [ngayKyQD] [datetime] null,
    [ngayHieuLuc] [datetime] null,
    [ghiChu] [nvarchar](max) null,
    primary key ([idTDDDBNTV])
);
create table [dbo].[ThanhPho] (
    [idThanhPho] [int] not null identity,
    [maTP] [nvarchar](10) not null,
    [tenTP] [nvarchar](150) not null,
    primary key ([idThanhPho])
);
create table [dbo].[ThongTinGiaDinh] (
    [idThongTinGiaDinh] [int] not null identity,
    [idNhanVien] [int] not null,
    [hoTenCha] [nvarchar](100) not null,
    [namSinhCha] [datetime] not null,
    [ngheNghiepCha] [nvarchar](100) not null,
    [hoTenMe] [nvarchar](100) not null,
    [namSinhMe] [datetime] not null,
    [ngheNghiepMe] [nvarchar](100) not null,
    [hoTenVoChong] [nvarchar](100) not null,
    [ngheNghiepVoChong] [nvarchar](100) not null,
    [namSinhVoChong] [nvarchar](100) not null,
    [hoTenCon] [nvarchar](100) not null,
    [namSinhCon] [datetime] not null,
    [ngheNghiepCon] [nvarchar](100) not null,
    primary key ([idThongTinGiaDinh])
);
create table [dbo].[ThongTinNhanVIen] (
    [idNhanVien] [int] not null identity,
    [MaNV] [nvarchar](20) not null,
    [idTo] [int] not null,
    [userName] [nvarchar](20) not null,
    [password] [nvarchar](150) not null,
    [permission] [int] not null,
    [idBienChe] [int] not null,
    [idCapBac] [int] not null,
    [idChucVu] [int] not null,
    [idTP] [int] not null,
    [CongViecDangLam] [nvarchar](max) null,
    [hoTen] [nvarchar](100) not null,
    [gioiTinh] [tinyint] not null,
    [namSinh] [datetime] not null,
    [nguyenQuan] [nvarchar](max) null,
    [noiOHienNay] [nvarchar](max) null,
    [hoKhau] [nvarchar](max) null,
    [CMND] [nvarchar](50) null,
    [ngayCapCMND] [datetime] null,
    [noiCapCMND] [nvarchar](50) null,
    [soDienThoaiNha] [nvarchar](50) null,
    [soDienThoaiDiDong] [nvarchar](50) null,
    [nguoiBaoLanh] [nvarchar](50) null,
    [moiQuanHeBaoLanh] [nvarchar](50) null,
    [noiCongTac] [nvarchar](max) null,
    [ngayVaoCang] [datetime] null,
    [namVaoSongThan] [datetime] null,
    [ngayNhapNgu] [datetime] null,
    [tinhTrangHonNhan] [nvarchar](100) null,
    [hinhAnhCaNhan] [nvarchar](max) not null,
    primary key ([idNhanVien])
);
create table [dbo].[To] (
    [idTo] [int] not null identity,
    [idDoi] [int] not null,
    [maTo] [nvarchar](50) not null,
    [tenTo] [nvarchar](100) not null,
    primary key ([idTo])
);
create table [dbo].[TrinhDo] (
    [idTrinhDo] [int] not null identity,
    [idNhanVien] [int] not null,
    [vanHoa] [nvarchar](50) null,
    [trinhDo] [nvarchar](max) null,
    [noiDaoTao] [nvarchar](max) null,
    [chuyenNganh] [nvarchar](max) null,
    [loaiHinh] [nvarchar](50) null,
    [thoiGianTotNghiep] [datetime] null,
    [bangCapPhu_CC] [nvarchar](255) null,
    primary key ([idTrinhDo])
);
alter table [dbo].[Doi] add constraint [Doi_Phong] foreign key ([idPhong]) references [dbo].[Phong]([idPhong]) on delete cascade;
alter table [dbo].[HopDongLaoDong] add constraint [HopDongLaoDong_LoaiHopDong] foreign key ([idLoaiHopDong]) references [dbo].[LoaiHopDong]([idLoaiHopDong]) on delete cascade;
alter table [dbo].[HopDongLaoDong] add constraint [HopDongLaoDong_ThongTinNhanVIen] foreign key ([idNhanVien]) references [dbo].[ThongTinNhanVIen]([idNhanVien]) on delete cascade;
alter table [dbo].[KhenThuong] add constraint [KhenThuong_ThongTinNhanVIen] foreign key ([idNhanVien]) references [dbo].[ThongTinNhanVIen]([idNhanVien]) on delete cascade;
alter table [dbo].[KyLuat] add constraint [KyLuat_ThongTinNhanVIen] foreign key ([idNhanVien]) references [dbo].[ThongTinNhanVIen]([idNhanVien]) on delete cascade;
alter table [dbo].[LoaiTo] add constraint [LoaiTo_To] foreign key ([idTo]) references [dbo].[To]([idTo]) on delete cascade;
alter table [dbo].[TD-DD-BN-TV] add constraint [TD_DD_BN_TV_ThongTinNhanVIen] foreign key ([idNhanVien]) references [dbo].[ThongTinNhanVIen]([idNhanVien]) on delete cascade;
alter table [dbo].[ThongTinGiaDinh] add constraint [ThongTinGiaDinh_ThongTinNhanVIen] foreign key ([idNhanVien]) references [dbo].[ThongTinNhanVIen]([idNhanVien]) on delete cascade;
alter table [dbo].[ThongTinNhanVIen] add constraint [ThongTinNhanVIen_BienChe] foreign key ([idBienChe]) references [dbo].[BienChe]([idBienChe]) on delete cascade;
alter table [dbo].[ThongTinNhanVIen] add constraint [ThongTinNhanVIen_CapBac] foreign key ([idCapBac]) references [dbo].[CapBac]([idCapBac]) on delete cascade;
alter table [dbo].[ThongTinNhanVIen] add constraint [ThongTinNhanVIen_ChucVu] foreign key ([idChucVu]) references [dbo].[ChucVu]([idChucVu]) on delete cascade;
alter table [dbo].[ThongTinNhanVIen] add constraint [ThongTinNhanVIen_ThanhPho] foreign key ([idTP]) references [dbo].[ThanhPho]([idThanhPho]) on delete cascade;
alter table [dbo].[ThongTinNhanVIen] add constraint [ThongTinNhanVIen_To] foreign key ([idTo]) references [dbo].[To]([idTo]) on delete cascade;
alter table [dbo].[To] add constraint [To_Doi] foreign key ([idDoi]) references [dbo].[Doi]([idDoi]) on delete cascade;
alter table [dbo].[TrinhDo] add constraint [TrinhDo_ThongTinNhanVIen] foreign key ([idNhanVien]) references [dbo].[ThongTinNhanVIen]([idNhanVien]) on delete cascade;
