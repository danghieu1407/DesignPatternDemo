create database DemoDesignPattern
go

use DemoDesignPattern
go

--Đồ Ăn
-- Bàn Ăn
-- Danh Sách Đồ Ăn
-- Tài Khoản Đăng Nhập
-- Hóa Đơn
-- Thông tin hóa đơn

create table BanAn
(
	id_table int identity primary key,
	name_table nvarchar (100),
	status_table nvarchar(20)
)
go

create table Account
(
	email nvarchar(100) primary key,
	name nvarchar(100) not null default 'Vippro123',
	password nvarchar(100) not null default '1',
	role int not null default 0
)
go


create table DanhSachMonAn
(
	id_DS int identity primary key,
	name nvarchar(100),

)
go

create table MonAn
(
	id_MonAn int identity primary key,
	name nvarchar(100) not null,
	id_DS int not null,
	price int not null,

	foreign key (id_DS) references DanhSachMonAn(id_DS)
)
go

create table HoaDon
(
	id_Bill int identity primary key,
	Checkin Date Not null default getDate(),
	Checkout date not null, 
	id_table int not null,
	isPay int not null default 0,  --Quy Định 0 là chưa trả, 1 là ngược lại

	foreign key (id_table) references BanAn(id_table)
)
go 

create table ChiTietHoaDon
(
	id_Detail_Bill int identity primary key,
	id_Bill int not null,
	id_Food int not null,
	count int not null default 0
	foreign key (id_Bill) references HoaDon(id_Bill),
	foreign key (id_Food) references MonAn(id_MonAn)
)
go


insert BanAn(name_table, status_table) values (N'Bàn 1','0')
insert BanAn(name_table, status_table) values (N'Bàn 2','0')
insert BanAn(name_table, status_table) values (N'Bàn 3','0')
insert BanAn(name_table, status_table) values (N'Bàn 4','0')
insert BanAn(name_table, status_table) values (N'Bàn 5','0')
insert BanAn(name_table, status_table) values (N'Bàn 6','0')
insert BanAn(name_table, status_table) values (N'Bàn 7','0')
insert BanAn(name_table, status_table) values (N'Bàn 8','0')
insert BanAn(name_table, status_table) values (N'Bàn 9','0')
insert BanAn(name_table, status_table) values (N'Bàn 10','0')
insert BanAn(name_table, status_table) values (N'Bàn 11','0')
insert BanAn(name_table, status_table) values (N'Bàn 12','0')
insert BanAn(name_table, status_table) values (N'Bàn 13','0')
insert BanAn(name_table, status_table) values (N'Bàn 14','0')
insert BanAn(name_table, status_table) values (N'Bàn 15','0')
insert BanAn(name_table, status_table) values (N'Bàn 16','0')
insert BanAn(name_table, status_table) values (N'Bàn 17','0')
insert BanAn(name_table, status_table) values (N'Bàn 18','0')
insert BanAn(name_table, status_table) values (N'Bàn 19','0')
insert BanAn(name_table, status_table) values (N'Bàn 20','0')



insert Account(email,name,role) values ('PH01@gmail.com',N'Đặng Phúc Huy',3)
insert Account(email,name,role) values ('GD02@gmail.com',N'Giang Vinh Diễn',1)
insert Account(email,name) values ('DH03@gmail.com',N'Nguyễn Đặng Hiếu')
insert Account(email,name) values ('GH04@gmail.com',N'Trần Gia Huy')

