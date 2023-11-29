CREATE DATABASE ql_banhang;

USE ql_banhang;

CREATE TABLE nguoi_dung (
    id INT IDENTITY(1,1) PRIMARY KEY,
    ho_ten NVARCHAR(255) NOT NULL,
    gioi_tinh NVARCHAR(10),
    dia_chi NVARCHAR(255),
    sdt NVARCHAR(15),
    mat_khau NVARCHAR(255) NOT NULL,
    nam_sinh INT
);

INSERT INTO nguoi_dung (ho_ten, gioi_tinh, dia_chi, sdt, mat_khau, nam_sinh) 
VALUES 
    (N'Nguyễn Hoàng Trung', N'Nam', N'Hồ Chí Minh, Phú Nhuận', N'0853040379', N'trung123', 2002),
    (N'Võ Đoàn Yến Nhi', N'Nữ', N'Phú Hoà, Bình Dương', N'0123456789', N'nhi1234', 1995);

SELECT * FROM nguoi_dung;

CREATE TABLE login_reg (
    taikhoan varchar(50) PRIMARY KEY,
	matkhau varchar(50)
);

INSERT INTO login_reg (taikhoan, matkhau) 
VALUES 
    ('admin', 'admin'),
	('trung', 'admin')
