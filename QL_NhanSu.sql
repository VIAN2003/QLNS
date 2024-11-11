create database _QL_NhanSu
use _QL_NhanSu

create table tbl_ChucVu
(
	ID_ChucVu int primary key not null,
	Ma_ChucVu nvarchar(50),
	Ten_ChucVu nvarchar(100),
	Ghi_Chu nvarchar(300)
)

create table tbl_TaiKhoan
(
	Ten_TaiKhoan nvarchar(50) primary key not null,
	Mat_Khau nvarchar(100) not null,
	Loai_TaiKhoan int not null
)

create table tbl_PhongBan
(
	ID_PhongBan int primary key not null,
	Ma_PhongBan nvarchar(50),
	Ten_PhongBan nvarchar(100),
	Dia_Chi nvarchar(300),
	S�T nvarchar(12),
	Ghi_Chu nvarchar(300)
)

create table tbl_NhanVien
(
	ID_NhanVien int primary key not null,
	ID_ChucVu int not null,
	ID_PhongBan int not null,
	Ten_TaiKhoan nvarchar(50) not null,
	Ho_Ten nvarchar(100) not null,
	Ngay_Sinh date not null,
	Gioi_Tinh int not null,
	Que_Quan nvarchar(300) not null,
	So_CMT nvarchar(12) not null,
	Ngay_Cap date not null,
	Noi_Cap nvarchar(150) not null,
	SoDT nvarchar(12) not null,
	Email nvarchar(50) not null,
	Ngay_Tao date not null,
	Nguoi_Tao nvarchar(50) not null,
	Ngay_Sua date not null,
	Nguoi_Sua nvarchar(50) not null,
	 CONSTRAINT FK_ID_ChucVu FOREIGN KEY (ID_ChucVu) REFERENCES tbl_ChucVu(ID_ChucVu),
	 CONSTRAINT FK_ID_PhongBan FOREIGN KEY (ID_PhongBan) REFERENCES tbl_PhongBan(ID_PhongBan),
	 CONSTRAINT FK_Ten_TaiKhoan FOREIGN KEY (Ten_TaiKhoan) REFERENCES tbl_TaiKhoan(Ten_TaiKhoan)
)

//0 là admin
//1 là user

INSERT INTO tbl_TaiKhoan VALUES ('admin','123','0')

INSERT INTO tbl_ChucVu VALUES ('1','GD',N'Giám đốc',N'Giám đốc công ty'),
							  ('2','PGD',N'Phó Giám đốc',N'Phó giám đốc công ty')