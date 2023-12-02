CREATE DATABASE ql_resort;

USE ql_resort;

CREATE TABLE NhanVien
(
    ID INT PRIMARY KEY IDENTITY(1,1),
    HoTen NVARCHAR(255) NOT NULL,
    GioiTinh NVARCHAR(10),
    NamSinh NVARCHAR(10),
    DiaChi NVARCHAR(255),
    DienThoai NVARCHAR(20),
    TenTaiKhoan NVARCHAR(50),
    Email NVARCHAR(100),
    MatKhau NVARCHAR(50),
    QuyenHan NVARCHAR(50)
);

CREATE TABLE KhachHang
(
    ID INT PRIMARY KEY IDENTITY(1,1),
    HoTen NVARCHAR(255) NOT NULL,
    GioiTinh NVARCHAR(10),
    NamSinh NVARCHAR(10),
    DiaChi NVARCHAR(255),
    DienThoai INT,
    TenTaiKhoan NVARCHAR(50),
    Email NVARCHAR(100),
    Password NVARCHAR(50),
	MaGiamGia Int
);

INSERT INTO NhanVien (ho_ten, gioi_tinh, nam_sinh, dia_chi, sdt, ten_tai_khoan, email, mat_khau, quyen_han)
VALUES 
('Nguyen Hoang Trung', 'Nam', '2002', 'TP.HCM', '0123456789', 'trung', 'trung@email.com', '1', 'Admin');


INSERT INTO KhachHang (HoTen, GioiTinh, NamSinh, DiaChi, DienThoai, TenTaiKhoan, Email, Password)
VALUES 
    ('Nguyen Hoang Trung', 'Nam', '2002', 'TP.HCM', '0123456789', 'trung', 'trung@email.com', '1');

SELECT * FROM NhanVien;
SELECT * FROM KhachHang;
