-- T?o database
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
    QuyenHan NVARCHAR(50),
	Avatar VARBINARY(MAX)
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
	MaGiamGia Int,
	Avatar VARBINARY(MAX)
);

CREATE TABLE Ban
(
    MaBan NVARCHAR(50) PRIMARY KEY,
    TenBan NVARCHAR(100),
	Lau NVARCHAR(50),
    Gia INT,
    TrangThai NVARCHAR(50)
);

CREATE TABLE feedback (
    ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    TenKhachHang NVARCHAR(100),
	TrangThai NVARCHAR(100),
	TieuDe NVARCHAR(100),
    PhanHoi NVARCHAR(MAX),
    NgayGui DATETIME NOT NULL
);

CREATE TABLE ThongTinDangNhap (
    ID INT PRIMARY KEY IDENTITY(1,1),
    TenTaiKhoan NVARCHAR(50) NOT NULL,
    ThoiGianDangNhap DATETIME NOT NULL
);

CREATE TABLE HangHoa (
    ID INT PRIMARY KEY IDENTITY(1,1),
	SoLuong INT,
    DonGia INT,
	TenHangHoa NVARCHAR(50),
	Avatar VARBINARY(MAX)
);

CREATE TABLE Bill (
    ID INT PRIMARY KEY IDENTITY(1,1),
    TenKhachHang NVARCHAR(100),
	ThucUong NVARCHAR(100),
	SoLuong INT,
    DonGia INT,
	ThanhTien INT,
	ThoiGian DATETIME NOT NULL
);

select * from bill
SELECT COUNT(ID) FROM Bill

INSERT INTO feedback (TenKhachHang, TrangThai, TieuDe, PhanHoi, NgayGui)
VALUES
('Nguyen Van A', 'Hoàn thành', 'Rất hài lòng với dịch vụ', 'Dịch vụ rất tốt, nhân viên phục vụ nhiệt tình.', '2023-01-01 08:30:00'),
('Tran Thi B', 'Chưa giải quyết', 'Gặp vấn đề về thanh toán', 'Tôi gặp vấn đề khi thanh toán hóa đơn, mong được giải quyết sớm.', '2023-01-02 12:45:00'),
('Le Van C', 'Đang xử lý', 'Cần hỗ trợ kỹ thuật', 'Tôi cần hỗ trợ kỹ thuật về việc cài đặt phần mềm mới.', '2023-01-03 15:20:00');

INSERT INTO Ban (MaBan, TenBan, Lau, Gia, TrangThai)
VALUES
('P1', 'Bàn 1', 'Tầng 1', 50000, 'Đang trống'),
('P2', 'Bàn 2', 'Tầng 1', 60000, 'Có khách'),
('P3', 'Bàn 3', 'Tầng 2', 80000, 'Đang trống'),
('P4', 'Bàn 4', 'Tầng 2', 70000, 'Đang trống'),
('P5', 'Bàn 5', 'Tầng 1', 55000, 'Có khách'),
('P6', 'Bàn 6', 'Tầng 1', 60000, 'Có khách'),
('P7', 'Bàn 7', 'Tầng 1', 45000, 'Đang trống'),
('P8', 'Bàn 8', 'Tầng 2', 70000, 'Đang trống'),
('P9', 'Bàn 9', 'Tầng 2', 65000, 'Có khách'),
('P10', 'Bàn 10', 'Tầng 2', 80000, 'Đang trống'),
('P11', 'Bàn 11', 'Tầng 3', 90000, 'Có khách'),
('P12', 'Bàn 12', 'Tầng 3', 95000, 'Đang trống'),
('P13', 'Bàn 13', 'Tầng 3', 100000, 'Có khách'),
('P14', 'Bàn 14', 'Tầng 3', 85000, 'Đang trống'),
('P15', 'Bàn 15', 'Tầng 4', 120000, 'Có khách'),
('P16', 'Bàn 16', 'Tầng 4', 110000, 'Có khách');