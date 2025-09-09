create database QLCN

go

use QLCN

go

/*
EXEC sp_configure 'show advanced options', 1;
RECONFIGURE;
EXEC sp_configure 'Ad Hoc Distributed Queries', 1;
RECONFIGURE;
*/

create table Tinh (
    MaTinh int primary key,
    TenTinh nvarchar(50) not null unique
)

create table QuanHuyen (
    MaQH int primary key,
    TenQH nvarchar(50) not null,
    MaTinh int foreign key references Tinh(MaTinh) on update cascade on delete cascade
)

create table XaPhuong (
    MaXP int primary key,
    TenXP nvarchar(50) not null,
    MaQH int foreign key references QuanHuyen(MaQH) on update cascade on delete cascade
)

create table CongTrinh (
      MaCT varchar(20) primary key,
      TenCT nvarchar(max) not null,
      TinhTrang nvarchar(max),
      NgayBatDau datetime default getdate(),
      NgayKetThuc datetime,
      DuToan decimal(18,2),
      ChuDauTu nvarchar(max),
      GhiChu nvarchar(max),
	  constraint CK_CongTrinh_Ngay check (NgayKetThuc >= NgayBatDau)
)

create table DiaChiCongTrinh (
      MaCT varchar(20) primary key foreign key references CongTrinh(MaCT) on delete cascade on update cascade,
      MaXP int foreign key references XaPhuong(MaXP) on update cascade,
      MoTaChiTiet nvarchar(max),
      GhiChu nvarchar(max)
)

create table CongNhan (
      MaCN varchar(20) primary key,
      Ho nvarchar (50) not null,
      TenDem nvarchar (50) not null,
      Ten nvarchar (50) not null,
      NgaySinh date not null,
      GioiTinh nvarchar (50) not null default 'Nam',
      SDT varchar(10) unique check (SDT like '0[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	  CCCD varchar(12) unique check (CCCD not like '%[^0-9]%'),
	  MaCT varchar(20) foreign key references CongTrinh(MaCT) on update cascade,
	  GhiChu nvarchar(max)
)

create table DiaChiCongNhan (
      MaCN varchar(20) primary key foreign key references CongNhan (MaCN) on delete cascade on update cascade,
      MaXP int foreign key references XaPhuong (MaXP) on update cascade,
      MoTaChiTiet nvarchar(max),
      GhiChu nvarchar(max)
)

create table HopDong(
    MaCN varchar(20) primary key foreign key references CongNhan (MaCN) on delete cascade on update cascade,
    LoaiHD nvarchar(max),
    NgayBatDau datetime default getdate(),
    NgayKetThuc datetime,
    LuongCB decimal(18,2) check (LuongCB > 0),
    PhuCap decimal(18, 0) check (PhuCap >= 0),
    GhiChu nvarchar(max),
	constraint CK_HopDong_Ngay check (NgayKetThuc >= NgayBatDau)
)

create table ChamCong (
    ID int identity primary key,
    MaCN varchar(20) foreign key references CongNhan (MaCN) on delete cascade on update cascade,
    GioVao datetime,
    GioRa datetime,
    GhiChu nvarchar(max),
	constraint CK_ChamCong_Gio check (GioRa >= GioVao)
)

go

-- Nh?p d? li?u t? file csv b?ng bulk insert
BULK INSERT Tinh
FROM 'C:\Users\trann\Documents\Zalo Received Files\tinh.csv'
WITH (
    FORMAT = 'CSV',
    FIRSTROW = 2, --b? qua tiêu ??
    FIELDTERMINATOR = ';', --d?u phân cách gi?a các c?t
	CODEPAGE = '65001', --nh?p d? li?u không b? l?i ti?ng Vi?t
    ROWTERMINATOR = '\n'
)

BULK INSERT QuanHuyen
FROM 'C:\Users\trann\Documents\Zalo Received Files\huyen.csv'
WITH (
    FORMAT = 'CSV',
    FIRSTROW = 2,
    FIELDTERMINATOR = ';',
    CODEPAGE = '65001',
    ROWTERMINATOR = '\n'
)

BULK INSERT XaPhuong
FROM 'C:\Users\trann\Documents\Zalo Received Files\xa.csv'
WITH (
    FORMAT = 'CSV',
    FIRSTROW = 2,
    FIELDTERMINATOR = ';',
    CODEPAGE = '65001',
    ROWTERMINATOR = '\n'
)
go

select * from XaPhuong
delete from tinh