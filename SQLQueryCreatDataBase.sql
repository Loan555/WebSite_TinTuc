go
create database WebDuLich_276
use WebDuLich_276
go 

create table TableUser(
Username char(8) primary key,
Pass char(8),
Quyen char(32),
)
create table DanhMucDad (
IDDanhMucDad int identity(1,1) primary key,
TenDanhMucDad nvarchar(255)
)

create table DanhMuc
(
IDDanhMuc int identity(1,1) primary key,
TenDanhMuc nvarchar(255),
IDDanhMucDad int references DanhMucDad(IDDanhMucDad)
)

create table BanTin(
IDBanTin  int identity(1,1) primary key,
TieuDe nvarchar(255),
BanTinNgan nvarchar(255),
NoiDung text,
NgayDang datetime,
Anh char(32),
SoLuotXem int,
ViTri nvarchar(100),
IDDanhMuc int references DanhMuc(IDDanhMuc),
Username char(8) references TableUser(Username)
)

create table NguoiDung(
TenNguoiDung nvarchar(8) primary key,
Email char(32),
Pass char(8),
)

create table BinhLuan(
IDBinhLuan int identity(1,1) primary key,
NoiDung nvarchar(255),
IDBanTin int references BanTin(IDBanTin),
TenNguoiDung nvarchar(8) references NguoiDung(TenNguoiDung),
)

create table PhanHoiBinhLuan(
IDPhanHoi int identity(1,1) primary key,
NoiDung nvarchar(255),
IDBinhLuan int references BinhLuan(IDBinhLuan),
TenNguoiDung nvarchar(8) references NguoiDung(TenNguoiDung),
)
