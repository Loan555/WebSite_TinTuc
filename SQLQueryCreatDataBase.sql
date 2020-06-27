go
create database WebDuLich_286
use WebDuLich_286
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

create table Anh
(
IDAnh int identity(1,1) primary key,
TenAnhDM nvarchar(50),
Anh1 char(32),
Anh2 char(32),
Anh3 char(32),
Anh4 char(32),
Anh5 char(32),
Anh6 char(32)
)
create table NoiDung
(
IDNoiDung int identity(1,1) primary key,
TenND_DM nvarchar(50),
Doan1 ntext,
Doan2 ntext,
Doan3 ntext,
Doan4 ntext,
Doan5 ntext,
Doan6 ntext
)
create table BanTin(
IDBanTin  int identity(1,1) primary key,
TieuDe nvarchar(255),
BanTinNgan nvarchar(255),
NgayDang datetime,
SoLuotXem int,
ViTri nvarchar(100),
IDDanhMuc int references DanhMuc(IDDanhMuc),
Username char(8) references TableUser(Username),
IDAnh int references Anh(IDAnh),
IDNoiDung int references NoiDung(IDnoiDung)
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
