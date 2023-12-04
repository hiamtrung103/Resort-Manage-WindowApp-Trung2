-- Tạo database
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
INSERT INTO NhanVien (HoTen, GioiTinh, NamSinh, DiaChi, DienThoai, TenTaiKhoan, Email, MatKhau, QuyenHan)
VALUES 
('Nguyen Hoang Trung', 'Nam', '2002', 'TP.HCM', '0123456789', 'trung', 'trung@email.com', '1', 'Admin');


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

INSERT INTO KhachHang (HoTen, GioiTinh, NamSinh, DiaChi, DienThoai, TenTaiKhoan, Email, Password)
VALUES 
    ('Nguyen Hoang Trung', 'Nam', '2002', 'TP.HCM', '0123456789', 'trung', 'trung@email.com', '1');

CREATE TABLE accommodation (
    MaDiaDiem NVARCHAR(100) NOT NULL PRIMARY KEY,
    TenDiaDiem NVARCHAR(200) NULL,
    HinhAnhDiaDiem NVARCHAR(200) NULL,
    MoTaDiaDiem NVARCHAR(MAX)
);

INSERT INTO accommodation (MaDiaDiem, TenDiaDiem, HinhAnhDiaDiem, MoTaDiaDiem) VALUES 
    (N'L001', N'Vinpearl Nha Trang', N'VinpearlNhaTrang.jpg', N'Khu nghỉ sang trọng tại Nha Trang, Việt Nam'),
    (N'L002', N'Ana Mandara Dalat', N'AnaMandaraDalat.jpg', N'Khu nghỉ yên bình giữa vùng núi Đà Lạt'),
    (N'L003', N'InterContinental Danang', N'InterContinentalDanang.jpg', N'Resort 5 sao ven biển Đà Nẵng');

CREATE TABLE bookingsinfo (
    MaDatPhong NVARCHAR(100) NOT NULL PRIMARY KEY,
    MaKhuNghi NVARCHAR(100) NULL,
    MaPhong NVARCHAR(100) NULL,
    TenDiaDiem NVARCHAR(100) NULL,
    MaNguoiDung NVARCHAR(100) NULL,
    LoaiThanhVien NVARCHAR(100) NULL,
    PhiPhong FLOAT NULL,
    [TuNgay] DATE NULL,
    [DenNgay] DATE NULL,
    TrangThaiDatPhong NVARCHAR(100) NULL
);

INSERT INTO bookingsinfo 
	(MaDatPhong, MaKhuNghi, MaPhong, TenDiaDiem, MaNguoiDung, LoaiThanhVien, PhiPhong, [TuNgay], [DenNgay], TrangThaiDatPhong) VALUES 
    (N'MDP001', N'MKN001', N'MP001', N'Vinpearl Nha Trang', 375, N'Platinum', 500,'03-12-2023', '10-12-2023', N'CheckedOut');

CREATE TABLE feedback (
    ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    TenKhachHang NVARCHAR(100) ,
	Danhgia NVARCHAR(100),
	TieuDe NVARCHAR(100),
    PhanHoi NVARCHAR(MAX),
    NgayGui DATETIME NOT NULL
);


CREATE TABLE ThongTinDangNhap (
    ID INT PRIMARY KEY IDENTITY(1,1),
    TenTaiKhoan NVARCHAR(50) NOT NULL,
    ThoiGianDangNhap DATETIME NOT NULL
);

select * from ThongTinDangNhap;
select * from KhachHang;
select * from NhanVien;