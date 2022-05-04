create database QLHV
use QLHV
--
create table HocVien(
								IdHocVien numeric(18,0) identity primary key,
								HoTen nvarchar(50),
								QueQuan nvarchar(50)
								)
--						
insert into HocVien(HoTen,QueQuan) values(N'An', N'Đà Nẵng')
insert into HocVien(HoTen,QueQuan) values(N'Nguyễn Nam', N'Huế')
insert into HocVien(HoTen,QueQuan) values(N'Sơn Tùng', N'Quảng Nam')